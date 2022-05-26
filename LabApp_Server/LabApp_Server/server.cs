using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.Timers;
using System.IO;


namespace LabApp_Server
{
    class Server
    {
        List<LectureRoom> lectureRooms;
        object lockObj;
        System.Timers.Timer CheckTimer;
        public Server()
        {
            lectureRooms = new List<LectureRoom>();

            lockObj = new System.Timers.Timer();
            CheckTimer.Interval = 10000;
            CheckTimer.Elapsed += new ElapsedEventHandler(RoomCheck);
            CheckTimer.Start();
            RunServer();
        }

        public void RoomCheck(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("RoomCount : {0}", lectureRooms.Count);
            lock (lockObj)
            {
                for (int i = lectureRooms.Count - 1; i>= 0; i--)
                {
                    if (!lectureRooms[i].isAlive)
                    {
                        lectureRooms.RemoveAt(i);
                    }
                }
            }
        }

        public void RunServer()
        {
            TcpListener server = new TcpListener(IPAddress.Any, 7000);

            server.Start();

            Console.WriteLine("서버 실행");

            while(true)
            {
                try
                {
                    TcpClient client = server.AcceptTcpClient();

                    IPEndPoint ipep = (IPEndPoint)client.Client.RemoteEndPoint;

                    byte[] recvLen = new byte[4];
                    client.GetStream().Read(recvLen, 0, recvLen.Length);
                    int dataLen = BitConverter.ToInt32(recvLen, 0);

                    byte[] recvData = new byte[dataLen];
                    client.GetStream().Read(recvData, 0, recvData.Length);
                    string RecvString = Encoding.Default.GetString(recvData);

                    string[] splited = RecvString.Split(';');

                    //통화방 배정 후 정보 전송
                    if (splited[0] == "Create")
                    {
                        Console.WriteLine(string.Format("Recv : {0};{1};", splited[0], splited[1]));

                        string RoomCode = CreateNewRoomCode();
                        //int port = GetPort();

                        Socket sock = client.Client;

                        LectureRoom room = new LectureRoom(RoomCode);
                        string userId = room.CreateUserID();
                        room.AddUser(splited[1], userId, sock, true);
                        room.presenter = userId;

                        lock (lockObj)
                        {
                            lectureRooms.Add(room);
                        }

                        Console.WriteLine(string.Format("Send : CreateComplete;{0};{1};", room.LectureCode, userId));

                        byte[] msg = Encoding.Default.GetBytes(string.Format("CreateComplete;{0};{1};", room.LectureCode, userId));
                        sock.Send(msg);
                    }
                    else if (splited[0] == "Join")
                    {
                        Console.WriteLine(string.Format("Send : {0};{1};{2};", splited[0], splited[1], splited[2]));

                        string Roomcode = splited[2];

                        Socket sock = client.Client;

                        bool find = false;
                        string UserId = "";
                        for (int i = 0; i < lectureRooms.Count; i++)
                        {
                            if (lectureRooms[i].LectureCode == Roomcode)
                            {
                                find = true;
                                UserId = lectureRooms[i].CreateUserID();
                                lectureRooms[i].AddUser(splited[1], UserId, sock, false);
                                break;
                            }
                        }

                        if (find)
                        {
                            Console.WriteLine(string.Format("JoinComplete;{0};{1}", Roomcode, UserId));

                            byte[] msg = Encoding.Default.GetBytes(string.Format("JoinComplete;{0};{1}", RoomCode, UserId));
                            sock.Send(msg);
                        }
                        else
                        {
                            Console.WriteLine("Send : JoinFailed;");

                            byte[] msg = Encoding.Default.GetBytes("JoinFailed;");
                            sock.Send(msg);
                        }
                    }
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }

         
        }
        
        string CreateNewRoomCode()
        {
            string RoomCode;
            while (true)
            {
                Random rand = new Random();
                int intCode = rand.Next(0, 999999999);
                RoomCode = intCode.ToString("D9");

                bool isExists = false;
                for (int idx = 0; idx < lectureRooms.Count; idx++)
                {
                    if (lectureRooms[idx].LectureCode == RoomCode)
                    {
                        isExists = true;
                        break;
                    }
                }

                if (!isExists)
                {
                    break;
                }
            }


            return RoomCode;
        }
    }
}
