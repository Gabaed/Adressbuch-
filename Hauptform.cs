using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adresbuch
{
    public partial class Startseite : Form
    {
        public Startseite()
        {
            InitializeComponent();
        }

        private void btnHunzufuegen_Click(object sender, EventArgs e)
        {
            Hinzufuegen form = new Hinzufuegen();
            form.ShowDialog();

        }

        private void Startseite_Load(object sender, EventArgs e)
        {
            
            this.adressbuchtabelleTableAdapter.Fill(this.adressbuchprogrammDataSet.adressbuchtabelle);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = this.adressbuchprogrammDataSet.adressbuchtabelle;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.adressbuchtabelleTableAdapter.Fill(this.adressbuchprogrammDataSet.adressbuchtabelle);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = this.adressbuchprogrammDataSet.adressbuchtabelle;
        }
    }
}
