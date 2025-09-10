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
            Grilla_Prestamos.MultiSelect = false;
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

        private void BTN_ELIMINAR_Click(object sender, EventArgs e)
        {
            try
            {
                PrestamoBLL logicaPrestamo = new();
                if (Grilla_Prestamos.Rows.Count < 0) throw new ArgumentException("Seleccione una fila");
                int NumeroPrestamo = Convert.ToInt32(Grilla_Prestamos.Rows[0].Cells["NUMERO_PRESTAMO"].Value);

                logicaPrestamo.Devolver_Prestamo(NumeroPrestamo);

                Actualizar();
            }
            catch( Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
