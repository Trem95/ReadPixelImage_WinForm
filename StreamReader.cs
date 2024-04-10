using AForge.Video.DirectShow;
using AForge.Video;
using ReadPixelImage.CaptureReadSettings;
using ReadPixelImage.CaptureSettings;
using ReadPixelImage.Forms;
using System;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace ReadPixelImage
{
    public class StreamReader
    {
        HealthCheckerDisplay streamCaptureDisplay;
        ScreenReader screenReader;
        ReadedPixelsSetting readedPixelSetting;
        CaptureSetting captureSetting;
        Bitmap displayedImage;
        Thread captureThread;

        string streamUrl;

        public StreamReader(string url, ReadedPixelsSetting rdPixSett, CaptureSetting captSett, HealthCheckerDisplay display = null)
        {
            streamUrl = url;
            readedPixelSetting = rdPixSett;
            captureSetting = captSett;
            streamCaptureDisplay = display == null ? new HealthCheckerDisplay() : display;
            screenReader = new ScreenReader();
        }

        public Thread CaptureThread { get { return captureThread; } set { captureThread = value; } }
        public HealthCheckerDisplay StreamCaptureDisplay { get { return streamCaptureDisplay; } }

        public void StartStreamCapture()
        {
            streamCaptureDisplay.Show();
            captureThread = new Thread(new ThreadStart(StartStreamReading));
            captureThread.Start();

        }

        private void StartStreamReading()
        {
            // enumerate video devices
            FilterInfoCollection videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            // create video source
            VideoCaptureDevice videoSource = new VideoCaptureDevice(videoDevices[1].MonikerString);
            // set NewFrame event handler
            videoSource.NewFrame += new NewFrameEventHandler(video_NewFrame);
            // start the video source
            videoSource.Start();
            // ...
            //videoSource.Stop();

        }
        private void video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            // get new frame
            Bitmap bitmap = eventArgs.Frame;
            ShowImage(bitmap);
            // process the frame
        }
        private void ShowImage(Bitmap image)
        {
            displayedImage = screenReader.GetParametredCapture(captureSetting, image);
            // process the frame

            if (streamCaptureDisplay.InvokeRequired)
            {
                streamCaptureDisplay.Invoke((MethodInvoker)delegate
                {
                    streamCaptureDisplay.WindowState = FormWindowState.Normal;
                    streamCaptureDisplay.MaximumSize = displayedImage.Size + new Size(16, 39);
                    streamCaptureDisplay.CaptureImg.Size = displayedImage.Size;
                    streamCaptureDisplay.CaptureImg.Image = displayedImage;
                    streamCaptureDisplay.SetAndDrawRectangles(readedPixelSetting.Rectangles, readedPixelSetting.Rectangles.Count() > 0 ? 0 : -1);
                    //streamCaptureDisplay.Show();
                });
            }
            else
            {
                streamCaptureDisplay.WindowState = FormWindowState.Normal;
                streamCaptureDisplay.MaximumSize = displayedImage.Size + new Size(16, 39);
                streamCaptureDisplay.CaptureImg.Size = displayedImage.Size;
                streamCaptureDisplay.CaptureImg.Image = displayedImage;
                streamCaptureDisplay.SetAndDrawRectangles(readedPixelSetting.Rectangles, readedPixelSetting.Rectangles.Count() > 0 ? 0 : -1);
                //streamCaptureDisplay.Show();
            }
        }

    }


}

