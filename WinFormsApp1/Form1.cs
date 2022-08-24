using System.Diagnostics;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        DataToSave dataToSave = new DataToSave(); 

        public Form1()
        {
            InitializeComponent();
        }

        private void ProduktAuswahl_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            try
            {
                string? v = (string)ProduktAuswahl.SelectedValue;
                Debug.WriteLine(v);
                Debug.WriteLine(ProduktAuswahl.Items[0]);
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
    }
}