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
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random random = new Random();

        public MainWindow()
        {
            InitializeComponent();
            Felder();
            
        }
        // hallo
        public void Felder()
        {
            
            Playground[,] felder = new Playground[20, 20];
            spielFeld.Background = Brushes.Lavender;
            for (int y = 0; y < felder.GetLength(0); y++)
            {
                for (int x = 0; x < felder.GetLength(1); x++)
                {
                    if (y == 0 || (x == 0) || y == 19 || x == 19)
                    {
                        felder[y, x] = new Playground(y, x, 3);
                        spielFeld.Children.Add(felder[y, x].rechteck);
                    }
                    else if (true)
                    {

                    }
                    else
                    {
                        
                        int state = random.Next(1, 100) < 95 ? 1 : 2 ;

                        
                        
                        //if (state >= 1 && state < 6)
                        //{
                        //    state = 1;
                        //}
                        //else
                        //{
                        //    state = 2;
                        //}
                        felder[y, x] = new Playground(y, x, state);
                        spielFeld.Children.Add(felder[y, x].rechteck);
                    }
                    
                }
            }
        }



    }
}
