using System;
using System.Drawing;
using System.Windows.Forms;

namespace Formularios
{
    public partial class Acceso : Form
    {
        public static string reyMago;
        private string rutaOjo1 = "ojo1.PNG";
        private string rutaOjo2 = "ojo2.PNG";
        public Acceso()
        {
            InitializeComponent();
            txtNombre.Text = string.Empty;
            txtContrasena.Text = string.Empty;
            lbAviso.Visible = false;
            txtNombre.KeyUp += TextBox_KeyUp;
            txtContrasena.KeyUp += TextBox_KeyUp;
        }

        // Modifica el color del botón de Entrar según si se han cumplimentado los datos
        private void NewTextChanged(object sender, EventArgs e)
        {
            
            if (txtNombre.Text != string.Empty && txtContrasena.Text != string.Empty)
            {
                btEntrar.BackColor = Color.Blue;
                btEntrar.ForeColor = Color.White;

            }
        }

        //Verifica si el bloque de mayúsculas está activado
        private void TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            bool capsLockActivado = Control.IsKeyLocked(Keys.CapsLock);
            lbAviso.Visible = capsLockActivado;
            lbAviso.Text = "Bloque mayúsculas activado";
        }

        // Verificar si el carácter introducido no es un dígito
        private void CheckKeyPress(object sender, KeyPressEventArgs e)
        {

            if (!(char.IsLetter(e.KeyChar) || e.KeyChar == ' ' || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        // Lógica de acceso 
        private void btEntrar_Click(object sender, EventArgs e)
        {
            if (btEntrar.BackColor == Color.Blue)
            {
                if ((txtNombre.Text == "Melchor") && (txtContrasena.Text == "Melchor") ||
                   (txtNombre.Text == "Gaspar") && (txtContrasena.Text == "Gaspar") ||
                   (txtNombre.Text == "Baltasar") && (txtContrasena.Text == "Baltasar"))
                {
                    reyMago = txtNombre.Text;
                    new GestorPeques().Show();
                    this.Close();
                }

                else
                {
                    lbAviso.Text = "El usuario o contraseña son incorrectos";
                    lbAviso.Visible = true;
                    btEntrar.ResetBackColor();
                    btEntrar.ResetForeColor();
                }


            }
            else
            {
                lbAviso.Text = "Por favor, rellene los campos";
                lbAviso.Visible = true;
            }
        }

        // Resetea el label aviso
        private void Acceso_Click(object sender, EventArgs e)
        {
            lbAviso.Visible = false;
        }

        // Gestiona que se muestre o no la contraseña
        private void picOjo_Click(object sender, EventArgs e)
        {
            if (picOjo.ImageLocation == rutaOjo1)
            {
                txtContrasena.PasswordChar = '\0';
                picOjo.ImageLocation = rutaOjo2;
                picOjo.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                txtContrasena.PasswordChar = '*';
                picOjo.ImageLocation = rutaOjo1;
                picOjo.SizeMode = PictureBoxSizeMode.Zoom;
            }

        }     
    }
}

