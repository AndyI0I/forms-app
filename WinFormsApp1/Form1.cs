using System.Diagnostics;
using System.Text.Json;
using System.IO;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        DataToSave dataToSave = new DataToSave();
        Entries entries = new Entries();
        public Form1()
        {
            InitializeComponent();
        }

        private void ProduktAuswahl_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                string? v = (string)ProduktAuswahl.SelectedValue;
                dataToSave.Produkt = v;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }


        //for the first name
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataToSave.Name = textBox1.Text;
        }

        private void datum_ValueChanged(object sender, EventArgs e)
        {
            dataToSave.Datum = datum.Value;
        }


        //not needed 
        private void label7_Click(object sender, EventArgs e)
        {

        }


        //Email
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            dataToSave.Email = textBox2.Text;
        }


        //first name
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            dataToSave.Nachname = textBox6.Text;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            dataToSave.Rating = trackBar1.Value;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            dataToSave.Bemerkung = richTextBox1.Text;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            string json;
            string directory = @"c:\ZCSHARPFILE";
            string filename = "FIRSTFORM.json";
            string path = Path.Combine(directory + @"\files", filename);
            if (!File.Exists(path))
            {
                entries.DataEntries.Add(dataToSave);
                json = JsonSerializer.Serialize<Entries>(entries, new JsonSerializerOptions { WriteIndented = true });
                try
                {
                    Directory.CreateDirectory(directory + @"\files");

                }
                catch (Exception ex)
                { Debug.WriteLine(ex.Message); }


            }
            else
            {
                json = File.ReadAllText(path);
                entries = JsonSerializer.Deserialize<Entries>(json);
                entries.DataEntries.Add(dataToSave);
                json = JsonSerializer.Serialize<Entries>(entries, new JsonSerializerOptions { WriteIndented = true });
            }

            File.WriteAllText(path, json);
            dataToSave = new DataToSave();
        }
    
        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            dataToSave.Agb = checkBox1.Checked;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("nothing");
        }
    }
}