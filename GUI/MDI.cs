using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        public void AbrirFormulario(Form formulario)
        {
            try
            {
                panel1.Controls.Clear();
                formulario.TopLevel = false;
                formulario.IsMdiContainer = false;
                formulario.MdiParent = this;
                formulario.Dock = DockStyle.Fill;
                panel1.Controls.Add(formulario);
                formulario.Show();
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Form1());
        }

        private void librosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Libros());
        }

        private void prestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Prestamos());
        }
    }
}
