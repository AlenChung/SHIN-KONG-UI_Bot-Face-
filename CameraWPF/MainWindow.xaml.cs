using System;
using System.Drawing;
using System.IO;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace CameraWPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(View_KeyDown);
        }

        private void SaveSnapshotButton_Click(object sender, RoutedEventArgs e)
        {
            WebcamCtrl.SaveSnapshot();
        }

        private void StartVideoFeed_Click(object sender, RoutedEventArgs e)
        {
            WebcamCtrl.StartVideoFeed();
        }

        private void StopVideoFeed_Click(object sender, RoutedEventArgs e)
        {
            WebcamCtrl.StopVideoFeed();


        }
        private  void View_KeyDown(object sender, KeyEventArgs e)//press F1 code 
        {
            try
            {
                switch (e.Key)
                {
                    case Key.Q:
                        new System.Threading.Thread(() =>
                        {
                            var p1 = new System.Windows.Media.MediaPlayer();
                            p1.Volume = 1.0f;
                            p1.Open(new System.Uri(@"C:\Users\v-bizhon\Desktop\SHIN-KONG-UI_Bot-Face-\Sound\1.wav"));
                            p1.Play();
                            System.Threading.Thread.Sleep(5000);
                        }).Start();

                        break;
                }
            }
            catch (Exception ex)
            {
              
                        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
                        wplayer.URL = "1.wav";
                        wplayer.controls.play();
                        Console.WriteLine("QQQQQQQQQQQQQ");
                
                
            }

            try
            {
                switch (e.Key)
                {
                    case Key.A:
                        new System.Threading.Thread(() =>
                        {
                            var p1 = new System.Windows.Media.MediaPlayer();
                            p1.Volume = 1.0f;
                            p1.Open(new System.Uri(@"C:\Users\v-bizhon\Desktop\SHIN-KONG-UI_Bot-Face-\Sound\2.wav"));
                            p1.Play();
                            System.Threading.Thread.Sleep(5000);
                        }).Start();

                        break;
                    case Key.R:
                        WebcamUserControl.VideoPortControl.Sound_Flag = false;
                        break;

                   case Key.F:
                        String FacePath = Directory.GetCurrentDirectory() + "\\" + "Face"+"\\"+"Final_Card.png";
                        BitmapImage bi = new BitmapImage();
                        // BitmapImage.UriSource must be in a BeginInit/EndInit block.
                        bi.BeginInit();
                        bi.UriSource = new Uri(FacePath, UriKind.RelativeOrAbsolute);
                        bi.EndInit();
                        final_image.Source = bi;
                       
                        break;
                }
            }
            catch (Exception ex)
            {

                WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
                wplayer.URL = "2.wav";
                wplayer.controls.play();
                Console.WriteLine("AAAAAAAAAAAAAA");


            }


            try
            {
                switch (e.Key)
                {
                    case Key.Z:
                        new System.Threading.Thread(() =>
                        {
                            var p1 = new System.Windows.Media.MediaPlayer();
                            p1.Volume = 1.0f;
                            p1.Open(new System.Uri(@"C:\Users\v-bizhon\Desktop\SHIN-KONG-UI_Bot-Face-\Sound\3.wav"));
                            p1.Play();
                            System.Threading.Thread.Sleep(7000);
                        }).Start();

                        break;
                }
            }
            catch (Exception ex)
            {

                WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
                wplayer.URL = "3.wav";
                wplayer.controls.play();
                Console.WriteLine("ZZZZZZZZZZZZZZZZZ");


            }


        }


        private void WebcamCtrl_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}