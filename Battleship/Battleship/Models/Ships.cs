using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;

namespace Battleship.Models
{
    class Ships
    {
        public void createBattleship()
        {
            int length = 5;
            bool isSunk = false;
            Rectangle battleship = new Rectangle();
            battleship.Fill = new SolidColorBrush(Color.FromArgb(255, 100, 100, 100));

        }
        public void createCarrier()
        {
            int length = 6;
            bool isSunk = false;

        }
        public void createDestroyer()
        {
            int length = 3;
            bool isSunk = false;

        }
        public void createSubmarine()
        {
            int length = 3;
            bool isSunk = false;

        }
        public void createCrusier()
        {
            int length = 4;
            bool isSunk = false;

        }
        public void createPTBoat()
        {
            int length = 2;
            bool isSunk = false;

        }
    }
}
