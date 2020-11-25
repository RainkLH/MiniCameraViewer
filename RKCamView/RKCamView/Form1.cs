using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using System.Diagnostics;

namespace RKCamView
{
    public partial class RKCamView : Form
    {
        private FilterInfoCollection CaptureDevices;
        private VideoCaptureDevice captureDevice;
        private VideoCapabilities[] videoCapabilities;
        private VideoCapabilities videoCapabilitie;

        private string saveDir;
        private string currentPicturePath;
        public RKCamView()
        {
            InitializeComponent();
            btn_View.Enabled = false;
            btn_View.Text = "Closed";
            btn_Photo.Enabled = false;
            pBox_View.SizeMode = PictureBoxSizeMode.StretchImage;
            CaptureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in CaptureDevices)
            {
                coBox_CamList.Items.Add(filterInfo.Name);
            }

            saveDir = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)+"\\RKCamView";
            if (!Directory.Exists(saveDir))
            {
                Directory.CreateDirectory(saveDir);
            }
            currentPicturePath = "";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (captureDevice != null)
            {
                captureDevice.Stop();
            }
            CaptureDevices.Clear();
            AVPlayer.VideoSource = null;
            AVPlayer.Stop();
        }

        private void coBox_CamList_SelectedIndexChanged(object sender, EventArgs e)
        {
            coBox_ResoList.Items.Clear();
            FilterInfo filterInfo = CaptureDevices[coBox_CamList.SelectedIndex];
            captureDevice = new VideoCaptureDevice(filterInfo.MonikerString);
            videoCapabilities = captureDevice.VideoCapabilities;
            foreach (VideoCapabilities capabilitie in videoCapabilities)
            {
                coBox_ResoList.Items.Add(capabilitie.FrameSize.Width.ToString() +
                "×" + capabilitie.FrameSize.Height.ToString());
            }
            if (coBox_ResoList.Items.Count > 0)
            {
                coBox_ResoList.SelectedIndex = 0;
            }
        }

        private void coBox_ResoList_SelectedIndexChanged(object sender, EventArgs e)
        {
            videoCapabilitie = videoCapabilities[coBox_ResoList.SelectedIndex];
            if (AVPlayer.IsRunning)
            {
                captureDevice.Stop();
                AVPlayer.VideoSource = null;
                btn_View.Text = "Closed";
            }
            btn_View.Enabled = true;
            btn_Photo.Enabled = true;
            btn_View.BackColor = Color.FromArgb(221, 59, 68);
        }

        private void btn_View_Click(object sender, EventArgs e)
        {
            if (btn_View.Text == "Closed")
            {
                captureDevice.VideoResolution = videoCapabilitie;
                AVPlayer.VideoSource = captureDevice;
                captureDevice.SimulateTrigger();
                AVPlayer.Start();
                btn_View.Text = "Viewing";
                btn_View.BackColor = Color.FromArgb(93, 172, 129);
            }
            else
            {
                AVPlayer.Stop();
                AVPlayer.VideoSource = null;
                btn_View.Text = "Closed";
                btn_View.BackColor = Color.FromArgb(221, 59, 68);
            }
        }
        private void btn_Photo_Click(object sender, EventArgs e)
        {
            Image image = AVPlayer.GetCurrentVideoFrame();
            pBox_View.Image = image;
            string fileName = DateTime.Now.ToString("yyyy,MM,dd,HH,mm,ss,ffff").Replace(",","");
            currentPicturePath = saveDir + "\\" +fileName + ".bmp";
            image.Save(currentPicturePath);
        }

        private void pBox_View_MouseClick(object sender, MouseEventArgs e)
        {
            if (File.Exists(currentPicturePath))
            {
                try
                {
                    Process.Start(currentPicturePath);
                }
                catch
                {
                    MessageBox.Show("Failed to open the picture with the default image viewing software\r\n" +
                        $"Please try to check under\"{saveDir}\"", "Error", MessageBoxButtons.OK);
                }
            }
        }
    }
}
