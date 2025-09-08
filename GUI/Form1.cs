using Microsoft.VisualBasic;
using BE;
using BLL;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTN_AGREGAR_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioBE usuario = new();
                usuario.Nombre = Interaction.InputBox(" Ingrese un nombre ");
                usuario.Mail = Interaction.InputBox(" Ingrese un mail ");
                usuario.Contrasenia = Interaction.InputBox("Ingrese una contrasenia");

                UsuarioBLL logica_Usuario = new UsuarioBLL();

                logica_Usuario.Register(usuario);

                Grilla_Usuario.DataSource = null;
                Grilla_Usuario.DataSource = logica_Usuario.Obtener_Usuarios();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UsuarioBLL logica_Usuario = new UsuarioBLL();

            Grilla_Usuario.DataSource = null;
            Grilla_Usuario.DataSource = logica_Usuario.Obtener_Usuarios();
        }
    }
}
