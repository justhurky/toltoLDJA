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
using System.Windows.Shapes;

namespace tolto
{
    /// <summary>
    /// Interaction logic for Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
            grid2.Visibility = Visibility.Hidden;
            grid3.Visibility = Visibility.Hidden;
        }

        private void next_Click(object sender, RoutedEventArgs e)
        {
            if (grid1.Visibility == Visibility.Visible)
            {
                grid1.Visibility = Visibility.Hidden;
                grid2.Visibility = Visibility.Visible;
                grid3.Visibility = Visibility.Hidden;
            }
            else if (grid2.Visibility == Visibility.Visible)
            {
                grid1.Visibility = Visibility.Hidden;
                grid2.Visibility = Visibility.Hidden;
                grid3.Visibility = Visibility.Visible;
            }
            
        }

        private void prev_Click(object sender, RoutedEventArgs e)
        {
            if (grid2.Visibility == Visibility.Visible)
            {
                grid1.Visibility = Visibility.Visible;
                grid2.Visibility = Visibility.Hidden;
                grid3.Visibility = Visibility.Hidden;
            }
            else if (grid3.Visibility == Visibility.Visible)
            {
                grid1.Visibility = Visibility.Hidden;
                grid2.Visibility = Visibility.Visible;
                grid3.Visibility = Visibility.Hidden;
            }
        }
    }
}
