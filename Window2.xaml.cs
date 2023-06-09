﻿using System;
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
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        
        public Window2()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Window1 reg = new Window1();
            reg.Show();
        }
        public string felhasznalonev;
        public string email;

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string inputFelhasznalonev = textBox.Text;
            string inputJelszo = passwordBox.Password;
            if (EllenorizHelyesBejelentkezes(inputFelhasznalonev, inputJelszo))
            {
                
                felhasznalonev = inputFelhasznalonev;
                email = GetFelhasznaloEmail(inputFelhasznalonev); 
                Close();
            }
            else
            {
                MessageBox.Show("Helytelen felhasználónév vagy jelszó!");
            }

        }
        private bool EllenorizHelyesBejelentkezes(string felhasznalonev, string jelszo)
        {
            if (felhasznalonev == textBox.Text && jelszo == passwordBox.Password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private string GetFelhasznaloEmail(string felhasznalonev)
        {
            if (felhasznalonev == textBox.Text)
            {
                return email;
            }
            else
            {
                return string.Empty;
            }
        }
    }
    
}
