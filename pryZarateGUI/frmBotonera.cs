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
using System;
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

        private void frmBotonera_Load(object sender, EventArgs e)
        {
            vecNombres[0] = "Chofi";
            vecNombres[1] = "Camiluchi";
            vecNombres[2] = "Agu";
            indice = 0;
            lblNombre.Text = vecNombres[indice];
            Actualizar();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (indice < vecNombres.Length - 1)
            {
                indice++;
                lblNombre.Text = vecNombres[indice];
                Actualizar();
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (indice > 0)
            {
                indice--;
                lblNombre.Text = vecNombres[indice];
                Actualizar();
            }
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            indice = 0;
            lblNombre.Text = vecNombres[indice];
            Actualizar();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            indice = vecNombres.Length - 1;
            lblNombre.Text = vecNombres[indice];
            Actualizar();
        }

        private void Actualizar()
        {
            btnPrimero.Enabled = (indice != 0);
            btnAnterior.Enabled = (indice != 0);
            btnUltimo.Enabled = (indice != vecNombres.Length - 1);
            btnSiguiente.Enabled = (indice != vecNombres.Length - 1);
        }
    }
}