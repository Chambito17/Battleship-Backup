using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Media.Core;
using Windows.Media.Playback;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Battleship
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        MediaPlayer homeMusic = new MediaPlayer();
        MediaPlayer start = new MediaPlayer();

        public MainPage()
        {
            this.InitializeComponent();
            ApplicationView.PreferredLaunchViewSize = new Size(1500, 1000);
            ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.PreferredLaunchViewSize;
            homeMusic.Source = MediaSource.CreateFromUri(new Uri("ms-appx:///Assets/homemusic.mp3"));
           
            homeMusic.Play();
            homeMusic.Volume = .15;
        }

        private void Start_Tapped(object sender, TappedRoutedEventArgs e)
        {            
            start.Source = MediaSource.CreateFromUri(new Uri("ms-appx:///Assets/welcome.mp3"));
            start.Play();
            homeMusic.Volume = .05;
            this.Frame.Navigate(typeof(MainGameBoard));
        }
        private void Exit_Tapped(object sender, TappedRoutedEventArgs e)
        {
            homeMusic.Dispose();
            CoreApplication.Exit();
        }
    }
}
