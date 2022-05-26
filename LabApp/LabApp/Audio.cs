using OpenCvSharp;
using OpenCvSharp.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;
using NAudio.Vorbis;
using NAudio.Wave;
using NAudio;

namespace LabApp
{
    class Audio
    {
        List<byte[]> Records;
        WaveInEvent WaveInEvent;

        public void StartRec()
        {
            WaveInEvent = new NAudio.Wave.WaveInEvent();
            WaveInEvent.DeviceNumber = 0;
            WaveInEvent.WaveFormat = new WaveFormat(16000, 1);

            WaveInEvent.DataAvailable += new EventHandler<NAudio.Wave.WaveInEventArgs>(WaveInEvent_DataAvailable);
            //waveFile = new WaveFileWriter("C:\Users\serin\Desktop\409Lab.wav", waveSource.WaveFormat);
            

            Records = new List<byte[]>();
        }

        private void WaveInEvent_DataAvailable(object sender, WaveInEventArgs e)
        {
            if (Records != null)
            {
                Records.Add(e.Buffer);
            }

        }

        public void Recording()
        {
            WaveInEvent.StartRecording();

        }


        public void StopRecording(object sender, StoppedEventArgs e)
        {

            if (WaveInEvent != null)
            {
                WaveInEvent.StopRecording();
                WaveInEvent.Dispose();
                WaveInEvent = null;
            }

        }
    }
}
