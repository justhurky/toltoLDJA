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
    /// Interaction logic for Window5.xaml
    /// </summary>
    public partial class Window5 : Window
    {
        private string felhasznalonev;
        private string email;
        public Window5()
        {
            InitializeComponent();
            this.felhasznalonev = felhasznalonev;
            this.email = email;

            textBlock.Text = felhasznalonev;
            textBlock1.Text = email;


        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text = null;
            textBlock1.Text = null;
            Close();
            
        }
    }
}
