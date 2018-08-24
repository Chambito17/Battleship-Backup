using Battleship.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Battleship
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainGameBoard : Page
    {

        MediaPlayer fire = new MediaPlayer();

        public MainGameBoard()
        {
            this.InitializeComponent();
            ApplicationView.PreferredLaunchViewSize = new Size(1500, 1000);
            ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.PreferredLaunchViewSize;
            Board.CreateBoard(player1);
            Board.CreateBoard(player2);
        }

        private void FirePlayer1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            fire.Source = MediaSource.CreateFromUri(new Uri("ms-appx:///Assets/firingset.mp3"));
           

            fire.Play();
        }
        private void FirePlayer2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            fire.Source = MediaSource.CreateFromUri(new Uri("ms-appx:///Assets/firingset.mp3"));

            fire.Play();
        }

        private void Carrier_Tapped(object sender, TappedRoutedEventArgs e)
        {
            string shipname = "Carrier";
            ShipPlacer(shipname);
            Carrier.IsEnabled = false;
        }

        private void Battleship_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }

        private void Crusier_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }

        private void Destroyer_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }

        private void Submarine_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }

        private void PTBoat_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }
        private async void ShipPlacer(string ship)
        {
            ContentDialog placeShip = new ContentDialog()
            {
                Title = "Ship Placer",
                Content = $"Ship that is being placed: {ship}",
                PrimaryButtonText = "Place Ship",
                CloseButtonText = "Cancel"
            };

            await placeShip.ShowAsync();
        }
    }
}
