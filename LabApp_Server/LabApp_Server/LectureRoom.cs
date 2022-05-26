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
    public interface RoomInterface
    {

        void AddChat(object Chat);
    }


    class LectureRoom : RoomInterface
    {
        string lectureCode;
        int RoomMode;
        public IPEndPoint presenter;

        List<UserInfo> UserList;
        object ChatLock;
        object UserLock;
        //List<ChatPacket> Chats;
        System.Timers.Timer timer;

        public string LectureCode
        {
            get
            {
                return lectureCode;
            }

        }

        public LectureRoom(string RoomCode)
        {
            lectureCode = RoomCode;
            RoomMode = 1;
            presenter = null;
            UserList = new List<UserInfo>();
            UserLock = new object();

            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            //timer.Elapsed += new System.Timers.ElapsedEventHandler
        }
        

        public void AddUser(UserInfo user)
        {
            user.roomInterface = this as RoomInterface;
            lock(UserLock)
            {
                UserList.Add(user);
            }
        }

        public void AddChat(object Chat)
        {
            throw new NotImplementedException();
        }
    }
}
