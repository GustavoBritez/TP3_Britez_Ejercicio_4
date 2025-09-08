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


        public void Agregar( LibroBE libroNuevo )
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
        public void Eliminar_Libro()
        {
            try
            {

            }
            catch 
            {

            }
        }
        public void Modificar_Libro()
        {
            try
            {

            }
            catch 
            {

            }
        }
    }
}
