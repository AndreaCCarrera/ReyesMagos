using System;
using System.Windows.Forms;


namespace Formularios
{
    public partial class ListaRegalos : Form
    {

        public ListaRegalos()
        {
            InitializeComponent();
           
        }

        // Cargar regalos de todos los peques en el textBox
        private void ListaRegalos_Load(object sender, EventArgs e)
        {
            foreach(String regalo in GestorPeques.encargos.ObtenerTodosRegalos())
            {
                txtLista.Text = txtLista.Text + regalo + "\r\n";
                
            }

            txtLista.SelectionStart = txtLista.TextLength;
            txtLista.SelectionLength = 0;
           
        }

        // Permite volver al formulario anterior
        private void picVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
