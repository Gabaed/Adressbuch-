
    
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
    public partial class Hinzufuegen : Form
    {
        public Hinzufuegen()
        {
            InitializeComponent();
        }

        private void Hinzufuegen_Load(object sender, EventArgs e)
        {
           

         
        }
       
        private void btnHinzufuegen_Click(object sender, EventArgs e)
        {
            Datenbankverbindung hinzufuegen = new Datenbankverbindung();

            try
            {
                hinzufuegen.FirmaInDatenbankHinzufuegen(txtVorname.Text,
                                                        txtNachname.Text,
                                                        txtStrasse.Text,
                                                        txtHausnummer.Text,
                                                        txtPostleitzahl.Text,
                                                        txtOrt.Text,
                                                        txtEmailadress.Text,
                                                         txtTelefonnummer.Text,
                                                        txtHandynummer.Text,
                                                        txtAnmerkungen.Text);

            }
            catch
            {
                MessageBox.Show("Die eigegeben Daten sind fehlerhaft!");
            }
        }
    }
}
