using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class DataToSave
    {
        private String name;
        private String nachname;
        private string email;
        private String password;
        private DateTime datum;
        private string produkt;
        private int rating;
        private string bemerkung;

        public string Name { get => name; set => name = value; }
        public string Nachname { get => nachname; set => nachname = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public DateTime Datum { get => datum; set => datum = value; }
        public string Produkt { get => produkt; set => produkt = value; }
        public int Rating { get => rating; set => rating = value; }
        public string Bemerkung { get => bemerkung; set => bemerkung = value; }
    }
}
