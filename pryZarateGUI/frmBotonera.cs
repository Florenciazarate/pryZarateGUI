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
    public partial class frmBotonera : Form
    {
        public frmBotonera()
        {
            InitializeComponent();
        }
        string[] vecNombres = new string[3];
        int indice = 0;

        private void frmBotonera_Load(object sender, EventArgs E)
        {
            vecNombres[0] = "Chofi";
            vecNombres[2] = "Camiluchi";
            vecNombres[3] = "Agu";
            lblNombre.Text = vecNombres[0];
        }
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
  
            if (vecNombres.Length <= indice)
            {
                lblNombre.Text = vecNombres[indice];
                indice++;
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            indice--;
            lblNombre.Text = vecNombres[indice];

        }
    }
}
