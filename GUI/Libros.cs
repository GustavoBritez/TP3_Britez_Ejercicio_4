using BE;
using BLL;
using Microsoft.VisualBasic;
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
    public partial class Libros : Form
    {
        public Libros()
        {
            InitializeComponent();
        }

        public void Actualizar()
        {
            LibroBLL logica_Libro = new();
            Grilla_Libros.DataSource = null;
            Grilla_Libros.DataSource = logica_Libro.Obtener_Libro();
        }

        private void BTN_Agregar_Click(object sender, EventArgs e)
        {
            LibroBLL logica_Libro = new();
            try
            {
                string autor = Interaction.InputBox("Ingrese autor");
                string titulo = Interaction.InputBox("Ingrese titulo del libro");
                if (int.TryParse(Interaction.InputBox("Ingrese el numero de ejemplar"), out int number))
                {
                    LibroBE libroNuevo = new LibroBE
                    {
                        Autor = autor,
                        Titulo = titulo,
                        Ejemplar = number
                    };

                    logica_Libro.Agregar_Libro(libroNuevo);
                }

                Actualizar();
            }
            catch (Exception ex)
            {
                throw new ArgumentNullException(ex.Message);
            }
        }

        private void Libros_Load(object sender, EventArgs e)
        {
            try
            {
                LibroBLL logica_Libro = new();
                Grilla_Libros.DataSource = null;
                Grilla_Libros.DataSource = logica_Libro.Obtener_Libro();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BTN_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Grilla_Libros.SelectedRows.Count < 0) throw new ArgumentException("Selecciona antes de borrar almenos un libro");
                string id = Grilla_Libros.Rows[0].Cells["TITULO"].Value.ToString();

                LibroBLL logica_Libro = new();
                logica_Libro.Eliminar_Libro(id);

                Actualizar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BTN_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Grilla_Libros.SelectedRows.Count < 0) throw new ArgumentException("Selecciona algo antes de eliminar");
                string autor = Grilla_Libros.Rows[0].Cells["AUTOR"].Value.ToString();
                string titulo = Grilla_Libros.Rows[0].Cells["TITULO"].Value.ToString();
                string ejemplar = Grilla_Libros.Rows[0].Cells["EJEMPLAR"].Value.ToString();

                MessageBox.Show($"MODIFICAR DATOS \n" +
                    $"{autor}\n{titulo}\n{ejemplar}\n");

                string autor1 = Interaction.InputBox("Ingrese nuevo autor");
                string titulo1 = Interaction.InputBox("Ingrese nuevo titulo");
                int ejemplar1 = Convert.ToInt32(Interaction.InputBox("Ingrese nuevo ejemplar"));
                LibroBE newlibro = new();

                newlibro.Autor = autor1;
                newlibro.Titulo = titulo1;
                newlibro.Ejemplar = ejemplar1;

                LibroBLL logica_Libro = new();
                logica_Libro.Modificar_Libro(titulo,newlibro);

                Actualizar();
            }
            catch( Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
