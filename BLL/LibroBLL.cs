using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BE;

namespace BLL
{
    public class LibroBLL
    {
        /// <summary>
        ///  Por que pusimos estos metodos de agregar libro dentro de la BLL ? bueno por que en el diseño
        ///  esta dentro de la clase LIBRO, y la pregunta que disparo este diseño fue
        ///  " Quien tiene los datos ? "
        /// </summary>

        LibroDAL mapper = new();
       

        public void Agregar_Libro( LibroBE libroNuevo )
        {
            /// Levanta por bubujeo al llamador GUI
            if (libroNuevo == null)
                throw new ArgumentNullException();
            try
            {
                mapper.AgregarLibro_(libroNuevo);
            }
            catch 
            {

            }
        }
        public void Eliminar_Libro( string TITULO )
        {
            try
            {
                mapper.Eliminar_Libro(TITULO);
            }
            catch (Exception ex)
            {
                throw new Exception( ex.ToString() );   
            }
        }
        public void Modificar_Libro(string titulo, LibroBE libroNuevo )
        {
            try
            {
                mapper.Modificar_Libro(titulo, libroNuevo);
            }
            catch (Exception ex )
            {
                throw new ArgumentException( ex.Message );
            }
        }

        public List<LibroBE> Obtener_Libro()
        {
            try
            {
                return mapper.Obtener_Libros();
            }
            catch ( Exception ex )
            {
                throw new ArgumentException( ex.Message );
            }
        }

    }
}
