using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading;
using System.Windows.Forms;
using System.Text;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using GreatHomeChildcare.Models;
using System.IO;

namespace GreatHomeChildcare
{
    public partial class SnapShotWin : Form
    {
        SqliteDataAccess SqliteDataAccess = new SqliteDataAccess();
        Child child;
        VideoCapture capture;
        Mat frame;
        Image image;
        private Thread camera;
        bool isCameraRunning = false;
        private void CaptureCamera()
        {
            camera = new Thread(new ThreadStart(CaptureCameraCallback));
            camera.Start();
        }
        private void CaptureCameraCallback()
        {
            frame = new Mat();
            capture = new VideoCapture(0);
            capture.Open(0);

            if (capture.IsOpened())
            {
                while (isCameraRunning)
                {

                    capture.Read(frame);
                    image = BitmapConverter.ToBitmap(frame);
                    if (pictureBox1.Image != null)
                    {
                        pictureBox1.Image.Dispose();
                    }
                    pictureBox1.Image = image;
                }
            }
        }

        public SnapShotWin(int id)
        {
            InitializeComponent();
            child = SqliteDataAccess.GetChildByID(id);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text.Equals("Start"))
            {
                CaptureCamera();
                button1.Text = "Stop";
                isCameraRunning = true;
            }
            else
            {
                capture.Release();
                button1.Text = "Start";
                isCameraRunning = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (isCameraRunning)
            {
                byte[] pic_in;
                Bitmap snapshot = new Bitmap(pictureBox1.Image);

                try
                {
                    using (var stream = new MemoryStream())
                    {
                        snapshot.Save(stream, ImageFormat.Png);
                        pic_in = stream.ToArray();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to picture.  Try again.", "Great Home Childcare", MessageBoxButtons.OK, MessageBoxIcon.None);
                    return;
                }
                try
                {
                    child.id = child.id;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("This child has not been created yet.  Save the child first and then come back.", "Great Home Childcare", MessageBoxButtons.OK, MessageBoxIcon.None);
                    return;
                }
                child.photo = pic_in;
                SqliteDataAccess.UpdateChild(child);
                isCameraRunning = false;

                Close();
            }
            else
            {
                MessageBox.Show("Cannot take picture if camera is not active.");
            }
        }
        /**
         * Simple method for converting a Bitmap to a byte array.
         * @return byte array that can be used to call up an image.
         */
        private byte[] BitmapToByte(Bitmap image)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(image, typeof(byte[]));
        }
    }
}
