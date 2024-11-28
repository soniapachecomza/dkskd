using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace proyecto303
{
    public partial class IniciarSesion : Form
    {
        //ocultar contraseña
        private bool showPassword = false;
        public IniciarSesion()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
            //datos de ingreso a la aplicaión
        {
            if (txtemail.Text == "sonia@gmail.com" && txtcontrasenia.Text == "1234")
            {
               
                //Nuevo formulario
                Inicio inicio = new Inicio();
                // Mostrar el nuevo formulario
                inicio.Show();

                // Opcional: ocultar el formulario actual si es necesario
                this.Hide();
            }
            else
            {
                //mensaje de error
                MessageBox.Show("Los datos son incorrectos");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //ocultar y mostrar contraseña
            showPassword = !showPassword;
            if (showPassword)
            {
                txtcontrasenia.PasswordChar = '\0';
                pbPassword.Image = proyecto303.Properties.Resources.close_eye;
            }
            else
            {
                txtcontrasenia.PasswordChar = '*';
                pbPassword.Image = proyecto303.Properties.Resources.Eye;


            }
        }

        private void txtcontrasenia_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
