using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Prestamos : Form
    {
        public Prestamos()
        {
            InitializeComponent();
        }

        public void Actualizar()
        {
            try
            {
                PrestamoBLL logicaPrestamo = new();

                Grilla_Prestamos.DataSource = null;
                Grilla_Prestamos.DataSource = logicaPrestamo.Obtener_Prestamos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Prestamos_Load(object sender, EventArgs e)
        {
            Actualizar();
        }
    }
}
