using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace markoGalavicXMLForms
{
    public partial class filtriranjePodataka : Form
    {
        public static string Ime = "";
        public static string Prezime = "";
        public static string Email = "";
        public static string Razred = "";
        public filtriranjePodataka()
        {
            InitializeComponent();
        }

        private void trecaForma_Load(object sender, EventArgs e)
        {

        }

        private void buttonFiltriraj1_Click(object sender, EventArgs e)
        {
            Ime = textBoxIme.Text;
            Prezime = textBoxPrezime.Text;
            Email = textBoxEmail.Text;
            Razred = (string)comboBox1.SelectedItem;
            this.Hide();
        }

        private void buttonOdustani1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
