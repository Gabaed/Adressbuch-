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
    }
}
