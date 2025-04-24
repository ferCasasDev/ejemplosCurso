using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo1
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void perfilPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Openforms -> todos los formularios que esténabiertos
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(Form1))
                {
                    MessageBox.Show("Ya existe una ventanan abierta, por favor termine de trabajar allí");
                    return;
                }
            }// importante para evaluar si hay varios formularios abiertos del 
             // mismo tipo...
            
            
            Form1 ventana = new Form1();
            // al invocar el método ShowDialog, lo inucimos a que abra solo 
            // UNA ventana, con formato de díalogo... caprura el contexto del momento
            // no se puede usar nada más hasta que se cierre la ventana.
            ventana.MdiParent = this; // indicamos que esta ventanan tienen un parent
            
            // ya no podemos usar ShowDialog
            ventana.Show();
        }

        private void tsbPerfilPersona_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(Form1))
                {
                    MessageBox.Show("Ya existe una ventanan abierta, por favor termine de trabajar allí");
                    return;
                }
            }

            Form1 ventana = new Form1();
            ventana.MdiParent = this;
            ventana.Show();

        }

        private void calToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCalendario ventana = new frmCalendario();
            ventana.ShowDialog();
        }
    }
}
