using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto303
{
    public partial class Form1 : Form
    {
        // ocultar contraseña
        private bool showPassword = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
            //muestra el cuadro de dialogo al ejecutar nuestra aplicación
        {
            MessageBox.Show("Bienvenidos a Programa");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //evento de cierre de la aplicación
            Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //datos de ingreso y contraseña
            if (txtName.Text == "Sonia" && txtEmail.Text == "sonia@gmail.com" && txtContrasenia.Text == "1234")
            {
                MessageBox.Show("Bienvenida a nuestra aplicación");

                //Abrir Nuevo formulario
                IniciarSesion iniciarSesion = new IniciarSesion();
                // Mostrar el nuevo formulario
                iniciarSesion.Show();

                // Opcional: ocultar el formulario actual si es necesario
                this.Hide();
            }
            else
            {
                //mensaje cuando son incorrecto los datos
                MessageBox.Show("Los datos son incorrectos");
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // contraseña ocultar y mostrar datos
            showPassword =! showPassword;
            if (showPassword)
            {
                txtContrasenia.PasswordChar = '\0';
                                  //nombre de solución. Propiedad. Recursos: imagenes de ojos abierto y cerrado
                pbPassword.Image = proyecto303.Properties.Resources.close_eye;
            }
            else {
                txtContrasenia.PasswordChar = '*';
                pbPassword.Image = proyecto303.Properties.Resources.Eye;


            }
        }
    }
}
