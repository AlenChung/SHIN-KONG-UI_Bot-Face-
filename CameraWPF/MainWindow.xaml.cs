using System;
using System.Windows;
using System.Windows.Input;
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
                    case Key.F1:
                        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
                        wplayer.URL = "3022.mp3";
                        wplayer.controls.play();
                        Console.WriteLine("CCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC");

                        break;
                }
            }
            catch (Exception ex)
            {
              
                        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
                        wplayer.URL = "3022.mp3";
                        wplayer.controls.play();
                        Console.WriteLine("FFFFFFFFFFFFFFFFFFFFFFFFFFFF");
                
                
            }
            
        }


        private void WebcamCtrl_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}