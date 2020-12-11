using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace SnakeWPF
{
    class Playground
    {
        int PosX { get; set; }
        int PosY { get; set; }
        int PosState { get; set; }
        int Size = 20;
        public Rectangle rechteck = new Rectangle();

        public Playground(int posY, int posX, int posState)
        {
            PosX = posX * Size;
            PosY = posY * Size;
            PosState = posState;
            rechteck.Width = Size;
            rechteck.Height = Size;
            Canvas.SetLeft(rechteck, PosX);
            Canvas.SetTop(rechteck, PosY);
            Color();
            
        }
        void Color()
        {
            
            switch (PosState)
            {
                case 1:
                    rechteck.Fill = Brushes.Green;
                    break;
                case 2: 
                    rechteck.Fill = Brushes.Gray;
                    break;
                default:
                    rechteck.Fill = Brushes.Black;
                    break;
            }
            
        }
    }

}
