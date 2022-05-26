using OpenCvSharp;
using OpenCvSharp.Extensions;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;



namespace LabApp
{
    public partial class RoomForm : Form
    {
        private readonly VideoCapture capture;
        private object backgroundWorker1;

        public RoomForm()
        {
            InitializeComponent();
            capture = new VideoCapture();
        }

        private void RoomForm_Load(object sender, EventArgs e)
        {
            capture.Open(0, VideoCaptureAPIs.ANY);
            if (!capture.IsOpened())
            {
                Close();
                return;
            }

            ClientSize = new System.Drawing.Size(capture.FrameWidth, capture.FrameHeight);
            //backgroundWorker1.RunWorkerAsync();
        }

        private void RoomForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //backgroundWorker1.CancelAsync();
            capture.Dispose();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            var bgWorker = (BackgroundWorker)sender;

            while (!bgWorker.CancellationPending)
            {
                using (var frameMat = capture.RetrieveMat())
                {
                    var frameBitmap = BitmapConverter.ToBitmap(frameMat);
                    bgWorker.ReportProgress(0, frameBitmap);
                }

                //ThreadExceptionDialog.Sleep(100);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            var frameBitmap = (Bitmap)e.UserState;
            pictureBox1.Image?.Dispose();
            pictureBox1.Image = frameBitmap;
        }

        private void CameraButton_Click(object sender, EventArgs e)
        {

        }

        private void AudioOnButton_Click(object sender, EventArgs e)
        {

        }

        private void ShareButton_Click(object sender, EventArgs e)
        {

        }

    }
}







