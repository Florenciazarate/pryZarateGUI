using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryZarateGUI
{
    public partial class frmControles : Form
    {
        frmBotonera Botones = new frmBotonera();
        public frmControles()
        {
            InitializeComponent();
        }

        private void btnBotonera_Click(object sender, EventArgs e)
        {
            Botones.Show();
            this.Hide();

        }
    }
}
