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
using System.Security.Cryptography;

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


            string felhasznalonev = textBox.Text;
            string jelszo = passwordBox.Password;
            string jelszoIsmetles = passwordBox1.Password;
            string email = textBox1.Text;

            
            if (jelszo != jelszoIsmetles)
            {
                MessageBox.Show("A jelszavak nem egyeznek!");
                return;
            }

            
            string titkosJelszo = EncryptString(jelszo);

            
            string adatok = $"Felhasználónév: {felhasznalonev}\n" +
                            $"Titkosított jelszó: {titkosJelszo}\n" +
                            $"E-mail: {email}\n\n";

            string eleresiUtvonal = "adatok.txt";
            File.AppendAllText(eleresiUtvonal, adatok);
            File.ReadAllLines(eleresiUtvonal);

            MessageBox.Show(File.ReadAllText("adatok.txt"));


        }
        private string EncryptString(string text)
        {
            using (Aes aes = Aes.Create())
            {
                byte[] key = Encoding.UTF8.GetBytes("EzAzAesKulcs12345");
                byte[] iv = Encoding.UTF8.GetBytes("EzAzAesIV123456");

                //aes.Key = key;
                //aes.IV = iv;

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter writer = new StreamWriter(cryptoStream))
                        {
                            writer.Write(text);
                        }

                        byte[] encryptedBytes = memoryStream.ToArray();
                        return Convert.ToBase64String(encryptedBytes);
                    }
                }
            }
        }
    }
}
