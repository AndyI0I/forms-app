using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class DataToSave
    {
        private string name = "no name";
        private string nachname = "no name";
        private string email = "no mail";
        private string password = "no password";
        private DateTime datum = new DateTime();
        private string produkt = "no product";
        private int rating = 0;
        private string bemerkung = "no entry";
        private bool agb = false;

        public string Name { get => name; set => name = value; }
        public string Nachname { get => nachname; set => nachname = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public DateTime Datum { get => datum; set => datum = value; }
        public string Produkt { get => produkt; set => produkt = value; }
        public int Rating { get => rating; set => rating = value; }
        public string Bemerkung { get => bemerkung; set => bemerkung = value; }
        public bool Agb { get => agb; set => agb = value; }
    }
}
