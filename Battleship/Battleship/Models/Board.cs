using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;

namespace Battleship.Models
{
    class Board
    {




        public static void CreateBoard(Grid player)
        {
            for (int y = 0; y < 11; y++)
            {
                player.ColumnDefinitions.Add(new ColumnDefinition());
                //{Width= new GridLength(1,GridUnitType.Star)}
            }
            for (int x = 0; x < 11; x++)
            {
                player.RowDefinitions.Add(new RowDefinition());
                //{ Height = new GridLength(1, GridUnitType.Star) }
            }
            for (int x = 0; x < 11; x++)
            {
                for (int y = 0; y < 11; y++)
                {
                    if (x!=0 && y==0)
                    {
                        TextBlock alpha = new TextBlock();
                        if (x==1)
                        {
                            alpha.Text = "      A";
                        }
                        if (x == 2)
                        {
                            alpha.Text = "      B";
                        }
                        if (x == 3)
                        {
                            alpha.Text = "      C";
                        }
                        if (x == 4)
                        {
                            alpha.Text = "      D";
                        }
                        if (x == 5)
                        {
                            alpha.Text = "      E";
                        }
                        if (x == 6)
                        {
                            alpha.Text = "      F";
                        }
                        if (x == 7)
                        {
                            alpha.Text = "      G";
                        }
                        if (x == 8)
                        {
                            alpha.Text = "      H";
                        }
                        if (x == 9)
                        {
                            alpha.Text = "      I";
                        }
                        if (x == 10)
                        {
                            alpha.Text = "      J";
                        }
                        alpha.Width = 50;
                        alpha.Height = 50;
                        Grid.SetColumn(alpha, y);
                        Grid.SetRow(alpha, x);
                        alpha.HorizontalAlignment = HorizontalAlignment.Center;
                        alpha.VerticalAlignment = VerticalAlignment.Center;
                        alpha.TextAlignment = TextAlignment.Center;
                        
                        player.Children.Add(alpha);
                        
                    }
                    if (x == 0 && y != 0)
                    {
                        TextBlock nums = new TextBlock();
                        if (y == 1)
                        {
                            nums.Text = "1";
                        }
                        if (y == 2)
                        {
                            nums.Text = "2";
                        }
                        if (y == 3)
                        {
                            nums.Text = "3";
                        }
                        if (y == 4)
                        {
                            nums.Text = "4";
                        }
                        if (y == 5)
                        {
                            nums.Text = "5";
                        }
                        if (y == 6)
                        {
                            nums.Text = "6";
                        }
                        if (y == 7)
                        {
                            nums.Text = "7";
                        }
                        if (y == 8)
                        {
                            nums.Text = "8";
                        }
                        if (y == 9)
                        {
                            nums.Text = "9";
                        }
                        if (y == 10)
                        {
                            nums.Text = "10";
                        }
                        nums.Width = 50;
                        nums.Height = 50;
                        nums.TextWrapping = TextWrapping.Wrap;
                        nums.HorizontalAlignment = HorizontalAlignment.Center;
                        nums.VerticalAlignment = VerticalAlignment.Center;
                        nums.TextAlignment = TextAlignment.Center;
                        player.Children.Add(nums);
                        Grid.SetColumn(nums, y);
                        Grid.SetRow(nums, x);
                    }
                    else if(x!=0 && y!=0)
                    {
                    Rectangle cell = new Rectangle();
                    SolidColorBrush myBrush = new SolidColorBrush(Color.FromArgb(255, 11, 154, 255));
                    cell.Fill = myBrush;
                    cell.Margin = new Thickness(1);
                    cell.Width = 50;
                    cell.Height = 50;
                    player.Children.Add(cell);
                    Grid.SetColumn(cell, y);
                    Grid.SetRow(cell, x);

                    }
                }
            }
        }

    }
    
}
