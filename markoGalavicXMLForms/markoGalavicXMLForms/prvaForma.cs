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
    public partial class pocetnaForma : Form
    {
        public pocetnaForma()
        {
            InitializeComponent();
        }

        private void buttonUnos1_Click(object sender, EventArgs e)
        {
            unosPodataka form = new unosPodataka();
            form.Show();
        }

        private void buttonPrikaz1_Click(object sender, EventArgs e)
        {
            pregledPodataka form = new pregledPodataka();
            form.Show();
        }
    }
}
