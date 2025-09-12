using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryZarateGUI
{
    public partial class frmBotonera : Form
    {
        public frmBotonera()
        {
            InitializeComponent();
        }
        
        string[] vecNombres = new string[3];
        int indice = 0;

        private void btnSiguiente_Click(object sender, EventArgs e)
        {

            indice++;

            if (vecNombres.Length > indice)
            {
                lblNombre.Text = vecNombres[indice];
            }
            else
            {
                btnSiguiente.Enabled = true;
            }

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (vecNombres.Length < indice)
                indice--;
            lblNombre.Text = vecNombres[indice];
        }

        private void frmBotonera_Load_1(object sender, EventArgs e)
        {
            vecNombres[0] = "Chofi";
            vecNombres[1] = "Camiluchi";
            vecNombres[2] = "Agu";
            lblNombre.Text = vecNombres[0];

        }
    }
}
