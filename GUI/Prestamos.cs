using BLL;
using BE;
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


                LB_Libros.Items.Clear();
                LB_Usuarios.Items.Clear(); 
                Grilla_Prestamos.DataSource = null;
                Grilla_Prestamos.DataSource = logicaPrestamo.Obtener_Prestamos();

                LibroBLL logicaLibro = new();

                List<LibroBE> lista_libros = logicaLibro.Obtener_Libro();

                foreach ( LibroBE libritos in lista_libros )
                {
                    LB_Libros.Items.Add( libritos.Titulo );
                }

                UsuarioBLL logicaUsuario = new();

                List<UsuarioBE> lista_usuarios = logicaUsuario.Obtener_Usuarios();

                foreach( UsuarioBE usuario in lista_usuarios )
                {
                    LB_Usuarios.Items.Add( usuario.Mail );
                }
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
                int NumeroPrestamo = Convert.ToInt32(Grilla_Prestamos.Rows[0].Cells["NumeroPrestamo"].Value);

                logicaPrestamo.Devolver_Prestamo(NumeroPrestamo);

                Actualizar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BTN_AGREGAR_Click(object sender, EventArgs e)
        {
            try
            {
                PrestamoBLL logicaPrestamo = new();

                string titulo = LB_Libros.SelectedItem.ToString();
                string mail = LB_Usuarios.SelectedItem.ToString();

                logicaPrestamo.Solicitar_Prestamo(titulo, mail);

                Actualizar();
            }
            catch( Exception ex )
            {
                MessageBox.Show($"Error en boton Agregar {ex.Message}");
            }
        }
    }
}
