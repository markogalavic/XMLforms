using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace markoGalavicXMLForms
{
    public partial class pregledPodataka : Form
    {
        public pregledPodataka()
        {
            InitializeComponent();
        }

        private void cetvrtaForma_Load(object sender, EventArgs e)
        {

        }

        private void buttonUcitajDokument_Click(object sender, EventArgs e)
        {
            XElement povuciPodatke = XElement.Load();
            IEnumerable<XElement> Ucenici = from Ucenik in povuciPodatke.Descendants("Ucenik") select Ucenik;
            foreach (var item in Ucenici)
            {
                richTextBox1.Text += item.ToString() + "\n";
            }


        }

        private void buttonFiltriraj2_Click(object sender, EventArgs e)
        {
            filtriranjePodataka form = new filtriranjePodataka();
            form.Show();
            XElement povuciPodatke = XElement.Load();
            IEnumerable<XElement> Ucenici = from Ucenik in povuciPodatke.Descendants("Ucenik")
                                            where (string)Ucenik.Element("Ime") == filtriranjePodataka.Ime
                                            && (string)Ucenik.Element("Prezime") == filtriranjePodataka.Prezime
                                            && (string)Ucenik.Element("Email") == filtriranjePodataka.Email
                                            && (string)Ucenik.Element("Razred") == filtriranjePodataka.comboBox1.Razred
                                            select Ucenik;
            foreach (var item in Ucenici)
            {
                richTextBox1.Text += item.ToString() + "\n";
            }
        }
    }
}
