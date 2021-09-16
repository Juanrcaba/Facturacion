using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturacion
{
    public partial class fmr_menu : Form
    {
        public fmr_menu()
        {
            InitializeComponent();
        }

        private void participantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_participantes form = new frm_participantes();
            form.ShowDialog();
        }
    }
}
