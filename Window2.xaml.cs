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
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        private string felhasznalonev;
        private string email;
        public Window2()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Window1 reg= new Window1();
            reg.Show();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string inputFelhasznalonev = textBox.Text;
            string inputJelszo = passwordBox.Password;

            // Ellenőrizd a felhasználónév és jelszó helyességét
            if (EllenorizHelyesBejelentkezes(inputFelhasznalonev, inputJelszo))
            {
                // Ha a bejelentkezés helyes, elmentjük a felhasználó adatait
                felhasznalonev = inputFelhasznalonev;
                email = GetFelhasznaloEmail(inputFelhasznalonev); // Függvény, amely visszaadja a felhasználó e-mail címét

                // Az előzőleg megadott oldalra való navigáció
                Window5 window5 = new Window5(felhasznalonev, email);
                window5.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Helytelen felhasználónév vagy jelszó!");
            }

        }
        private bool EllenorizHelyesBejelentkezes(string felhasznalonev, string jelszo)
        {
            // Ellenőrizd a felhasználónév és jelszó helyességét
            // Például: adatbázis lekérdezés vagy más ellenőrzési mechanizmus használata
            // Visszatérési érték a helyes bejelentkezés true/false értéke

            // Ide írd a saját ellenőrzési logikádat
            // Példa:

            if (felhasznalonev == "admin" && jelszo == "password")
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
            // Az adott felhasználóhoz tartozó e-mail cím lekérdezése az adatbázisból vagy más forrásból
            // Például: adatbázis lekérdezés vagy más adatforrás használata
            // Visszatérési érték a felhasználó e-mail címe

            // Ide írd a saját e-mail cím lekérdezési logikádat
            // Példa:

            if (felhasznalonev == "admin")
            {
                return "admin@example.com";
            }
            else
            {
                return string.Empty;
            }
        }
    }
    
}
