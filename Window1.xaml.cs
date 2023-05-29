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
using System.IO;

namespace tolto
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    
    public partial class Window1 : Window
    {

        public Window1()
        {
            InitializeComponent();
            if (!File.Exists("adat.txt"))
            {
               File.Create("adat.txt");
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

            
            if (string.IsNullOrEmpty(textBox.Text) || string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(passwordBox.Password) || string.IsNullOrEmpty(passwordBox1.Password))
            {
                MessageBox.Show("A felhasználó név, email vagy jelszó üres!");
                return;
            }
            if (IsUsernameTaken(textBox.Text) || IsEmailTaken(textBox1.Text))
            {
                MessageBox.Show("A felhasználónév vagy email foglalt!");
                return;
            }
            string encryptedPassword = Pass(password);
        }

        private bool IsEmailTaken(string text)
        {
            throw new NotImplementedException();
        }

        private bool IsUsernameTaken(string text)
        {
            throw new NotImplementedException();
        }
    }
}
