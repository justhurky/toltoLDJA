namespace tolto
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    class fiok {
        string felhnev;
        string pass;
        string mail;

        public fiok(string felhnev, string pass, string mail)
        {
            this.felhnev = felhnev;
            this.pass = pass;
            this.mail = mail;
        }

        public string Felhnev { get => felhnev; set => felhnev = value; }
        public string Pass { get => pass; set => pass = value; }
        public string Mail { get => mail; set => mail = value; }
    }
}
