using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Entries
    {
        private List<DataToSave> entries = new List<DataToSave>();

        public List<DataToSave> DataEntries { get => entries; set => entries = value; }
    }
}
