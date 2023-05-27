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

namespace tolto
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Window1 reg = new Window1();
            reg.Show();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Window3 info= new Window3();
            info.Show();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Window2 beje = new Window2();
            beje.Show();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            string mess = "Bem József utca.\nÁr: 750 Ft/h\nHelyek száma: 5";
            MessageBox.Show(mess);
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Window5 fiok = new Window5();
            fiok.Show();
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            string mess = "Lovassy Sándor utca.\nÁr: 650 Ft/h\nHelyek száma: 7";
            MessageBox.Show(mess);
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            string mess = "Erzsébet királyné útja.\nÁr: 750 Ft/h\nHelyek száma: 4";
            MessageBox.Show(mess);
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            string mess = "Fő tér.\nÁr: 550 Ft/h\nHelyek száma: 2";
            MessageBox.Show(mess);
        }
    }
}
