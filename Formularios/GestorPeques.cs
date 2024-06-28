using Business;
using Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ToolTip = System.Windows.Forms.ToolTip;

namespace Formularios
{
    public partial class GestorPeques : Form
    {
        private BindingSource bindingSource = new BindingSource();
        public static Encargos encargos = new Encargos();
        public static Peque peque = new Peque();
        private ToolTip genericToolTip;

        public GestorPeques()
        {
            InitializeComponent();
            genericToolTip = new ToolTip();
            genericToolTip.AutoPopDelay = 5000;
            genericToolTip.InitialDelay = 1000;
            genericToolTip.ReshowDelay = 500;

        }

        private void GestorPeques_Load(object sender, EventArgs e)
        {
            bindingSource.DataSource = typeof(Peque);
            dataPeques.AutoGenerateColumns = true;
            dataPeques.DataSource = bindingSource;
            ActualizarDataGridView();
            Resetear();
            lbBienvenida.Text += " " + Acceso.reyMago;
            SetToolTipWithMessage(btAnadir, "Añadir nuevos peques");
            SetToolTipWithMessage(btEliminar, "Borrar el peque seleccionado");
            SetToolTipWithMessage(btModificar, "Modificar un peque");
            SetToolTipWithMessage(picCarta, "Mostrar la carta del peque seleccionado");
            SetToolTipWithMessage(picRegalo, "Mostrar la lista de todos los regalos"); 
            SetToolTipWithMessage(picGuardar, "Realizar copia de seguridad del archivo cargado");
            SetToolTipWithMessage(picSalir, "Cerrar sesión");
            SetToolTipWithMessage(btSalir, "Salir de la aplicación");
            SetToolTipWithMessage(btBuenos, "Ver peques buenos o todos");
            SetToolTipWithMessage(btTodos, "Ver todos o filtrar por rey");
            SetToolTipWithMessage(btMas, "Añadir regalo");
            SetToolTipWithMessage(btMenos, "Eliminar regalo");

        }

        private void ActualizarDataGridView()
        {
            dataPeques.DataSource = null;
            encargos.ListaPeques = encargos.ListarPeques();
            dataPeques.DataSource = encargos.FiltrarReyFavorito(Acceso.reyMago);
            foreach (DataGridViewColumn columna in dataPeques.Columns)
            {
                if (columna.Visible)
                {
                    columna.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
                else
                {
                    columna.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                }
            }
            dataPeques.Columns[dataPeques.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataPeques.CurrentCell = null;

        }

        //Resetear los avisos y elementos no visibles
        private void GestorPeques_Click(object sender, EventArgs e)
        {
            lbAviso.Visible = false;
            txtArchivo.Visible = false;
            groupDatos.Visible = false;
            btEliminar.ResetBackColor();
            btEliminar.ResetForeColor();
            btAnadir.ResetBackColor();
            btAnadir.ResetForeColor();
            btModificar.ResetBackColor();
            btModificar.ResetForeColor();
            dataPeques.ClearSelection();
            

        }

        // Define un ToolTip genérico para asignar en la inicialización del form a cada elemento
        private void SetToolTipWithMessage(Control control, string message)
        {
            genericToolTip.SetToolTip(control, message);
        }

        //Cambia el color de los botones añadir o modificar si todos los campos necesarios están completados
        private void NewTextChanged(object sender, EventArgs e)
        {

            System.Windows.Forms.TextBox txt = sender as System.Windows.Forms.TextBox;

            if (txt != null)
            {
                if (!string.IsNullOrEmpty(txt.Text))
                {
                    txt.ResetBackColor();
                }
            }

            if (!string.IsNullOrEmpty(txtNombre.Text) && !string.IsNullOrEmpty(txtApellidos.Text) &&
               !string.IsNullOrEmpty(txtDireccion.Text) && cmbReyes.SelectedIndex != -1 && dateNacimiento.Value != DateTime.Now)
            {
                
                if (numId.Enabled == false)
                {
                    btAnadir.BackColor = Color.Blue;
                    btAnadir.ForeColor = Color.White;
                }
                else
                {
                    btModificar.BackColor = Color.Blue;
                    btModificar.ForeColor = Color.White;
                }

            }

        }

        // Verificar si el carácter introducido no es un dígito
        private void CheckKeyPress(object sender, KeyPressEventArgs e)
        {

            if (!(char.IsLetter(e.KeyChar) || e.KeyChar == ' ' || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        //Cambia el color para activar el botón Eliminar
        private void dataPeques_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (dataPeques.SelectedRows.Count > 0)
            {
                btEliminar.BackColor = Color.Blue;
                btEliminar.ForeColor = Color.White;
                lbAviso.ForeColor = Color.Black;
                lbAviso.Text = "Peque seleccionado: " + dataPeques.SelectedRows[0].Cells["Nombre"].Value.ToString();
                lbAviso.Visible = true;
                peque = dataPeques.SelectedRows[0].DataBoundItem as Peque;
            }
            else
            {
                btEliminar.ResetBackColor();
                btEliminar.ResetForeColor();
            }

        }

        //Filtrar por buenos dependiendo de si ya está filtrado por todos o los del Rey solamente
        private void btBuenos_Click(object sender, EventArgs e)
        {
            dataPeques.DataSource = null;
            if (btBuenos.Text.Equals("BUENOS"))
            {

                if (btTodos.Text.Equals("TODOS"))
                {
                    List<Peque> filtrada = encargos.FiltrarReyFavorito(Acceso.reyMago);
                    dataPeques.DataSource = encargos.FiltrarBuenos(filtrada);
                    btBuenos.Text = "TODOS";
                }
                else
                {
                    dataPeques.DataSource = encargos.FiltrarBuenos(encargos.ListaPeques);
                    btBuenos.Text = "TODOS";
                }
            }
            else
            {

                if (btTodos.Text.Equals("TODOS"))
                {
                    ActualizarDataGridView();
                    btBuenos.Text = "BUENOS";
                }
                else
                {
                    dataPeques.DataSource = encargos.ListaPeques;
                    btBuenos.Text = "BUENOS";
                }

            }

        }

        //Filtrar por todos o los del Rey dependiendo de si ya están filtrados por buenos o no
        private void btTodos_Click(object sender, EventArgs e)
        {
            dataPeques.DataSource = null;
            if (btTodos.Text.Equals("TODOS"))
            {

                if (btBuenos.Text.Equals("TODOS"))
                {
                    dataPeques.DataSource = encargos.FiltrarBuenos(encargos.ListaPeques);
                    btTodos.Text = "MÍOS";
                }
                else
                {
                    dataPeques.DataSource = encargos.ListaPeques;
                    btTodos.Text = "MÍOS";
                }
            }
            else
            {
                if (btBuenos.Text.Equals("TODOS"))
                {
                    List<Peque> filtrada = encargos.FiltrarReyFavorito(Acceso.reyMago);
                    dataPeques.DataSource = encargos.FiltrarBuenos(filtrada);
                    btTodos.Text = "TODOS";
                }
                else
                {
                    ActualizarDataGridView();
                    btTodos.Text = "TODOS";
                }

            }
        }

        // Acceso a la carta del peque seleccionado en la lista
        private void picCarta_Click(object sender, EventArgs e)
        {
            if (dataPeques.SelectedRows.Count > 0)
            {
                new Carta(peque).ShowDialog();
            }
            else
            {
                lbAviso.ForeColor = Color.Red;
                lbAviso.Text = "Ningún peque seleccionado";
                lbAviso.Visible = true;
            }
        }

        // Acceso a la lista de todos los regalos pedidos por todos los peques
        private void picRegalo_Click(object sender, EventArgs e)
        {
            new ListaRegalos().ShowDialog();
        }

        // Eventos del botón añadir en función de si está activado o no

        private void btAnadir_Click(object sender, EventArgs e)
        {
          
            Boolean bueno = false;
            string nombre;
            string apellidos;
            DateTime fechaNacimiento;
            string direccion;
            string reyFavorito;
            List<String> regalos;
            Peque nuevoPeque;

            if (groupDatos.Visible == false)
            {
                groupDatos.Visible = true;
                numId.Enabled = false;
            }
            else if (btModificar.BackColor == Color.Blue)
            {
                Resetear();
            }
            else
            {

                if (btAnadir.BackColor == Color.Blue)
                {
                 
                    reyFavorito = cmbReyes.SelectedItem.ToString();
                    nombre = txtNombre.Text;
                    apellidos = txtApellidos.Text;
                    direccion = txtDireccion.Text;
                    regalos = CrearListaRegalos(txtRegalos.Text);
                    fechaNacimiento = dateNacimiento.Value;
                    bueno = checkBueno.Checked;

                    nuevoPeque = new Peque (nombre, apellidos, fechaNacimiento, direccion, reyFavorito, regalos, bueno);
                    if (encargos.AnadirPeque(nuevoPeque))
                    {
                        Resetear();
                        lbAviso.ForeColor = Color.Black;
                        lbAviso.Text = "Peque añadido";
                        lbAviso.Visible = true;
                        ActualizarDataGridView();
                    }
                    else
                    {
                        btAnadir.ResetBackColor();
                        btAnadir.ResetForeColor();
                        lbAviso.ForeColor = Color.Red;
                        lbAviso.Text = "No se pudo añadir el peque";
                        lbAviso.Visible = true;
                    }

                }
                else
                {
                    txtNombre.BackColor = Color.Red;
                    txtApellidos.BackColor = Color.Red;
                    txtDireccion.BackColor = Color.Red;
                    lbAviso.ForeColor = Color.Red;
                    lbAviso.Text = "Faltan campos por rellenar";
                    lbAviso.Visible = true;
                }
            }
        }

        // Eventos del botón modificar en función de si está activado o no
        private void btModificar_Click(object sender, EventArgs e)
        {
            String cuerpo;
            String cabecera;
            MessageBoxIcon icono;
            DialogResult result;


            Peque peque = new Peque();
          
            if (groupDatos.Visible == false)
            {
                groupDatos.Visible = true;
                numId.Enabled = true;
            }
            else
            {
                if (btModificar.BackColor == Color.Blue && numId.Value!=0)
                {


                    cuerpo = "¿Está seguro de que desea modificar?";
                    cabecera = "Confirmar modificaciones";
                    icono = MessageBoxIcon.Exclamation;
                    MessageBoxButtons botones = MessageBoxButtons.OKCancel;
                    result = MessageBox.Show(cuerpo, cabecera, botones, icono);

                    if (result == DialogResult.OK)
                    {
                        numId.Enabled = true;
                        peque.Id = Convert.ToInt32(numId.Value);
                        peque.Nombre = txtNombre.Text;
                        peque.Apellidos = txtApellidos.Text;
                        peque.Direccion = txtDireccion.Text;
                        peque.ReyFavorito = cmbReyes.SelectedItem.ToString();
                        peque.FechaNacimiento = dateNacimiento.Value;
                        peque.Bueno = checkBueno.Checked;
                        peque.Regalos = CrearListaRegalos(txtRegalos.Text);

                        if (encargos.ModificarPeque(peque))
                        {
                            Resetear();
                            lbAviso.ForeColor = Color.Black;
                            lbAviso.Text = "Peque modificado";
                            lbAviso.Visible = true;
                            ActualizarDataGridView();
                        }
                        else
                        {
                            btModificar.ResetBackColor();
                            btModificar.ResetForeColor();
                            lbAviso.ForeColor = Color.Red;
                            lbAviso.Text = "No se pudo modificar el peque";
                            lbAviso.Visible = true;
                        }               
                    }
                }

                else
                {
                    txtApellidos.BackColor = Color.Red;
                    txtNombre.BackColor = Color.Red;
                    txtDireccion.BackColor = Color.Red;
                    lbAviso.Text = "Faltan campos por rellenar";
                    lbAviso.ForeColor = Color.Red;
                    lbAviso.Visible = true;
                }
            }
        }

       

        // Cargar datos de los peques en función del id
        private void numId_ValueChanged(object sender, EventArgs e)
        {
            int id = (int)numId.Value;
            Peque pequeModificado;
            numId.Maximum = encargos.ListaPeques.Count;
            

            if (id != 0)
            {
                pequeModificado = encargos.BuscarPeque(id);
                if (pequeModificado != null)
                {
                    cmbReyes.SelectedItem = pequeModificado.ReyFavorito;
                    txtNombre.Text = pequeModificado.Nombre;
                    txtApellidos.Text = pequeModificado.Apellidos;
                    txtDireccion.Text = pequeModificado.Direccion;
                    txtRegalos.Text = "";
                    foreach (String regalo in pequeModificado.Regalos)
                    {
                        txtRegalos.Text = txtRegalos.Text + regalo + "\r\n";

                    }
                    txtRegalos.SelectionStart = txtRegalos.TextLength;
                    txtRegalos.SelectionLength = 0;
                    dateNacimiento.Value = pequeModificado.FechaNacimiento;
                    checkBueno.Checked = pequeModificado.Bueno;
                    lbAviso.Visible = false;
                }
                else
                {

                    txtNombre.Text = string.Empty;
                    txtApellidos.Text = string.Empty;
                    txtDireccion.Text = string.Empty;
                    txtRegalos.Text = string.Empty;
                    numId.Value = id;
                    lbAviso.ForeColor = Color.Red;
                    lbAviso.Text = "El id no corresponde con ningún peque a modificar";
                    lbAviso.Visible = true;

                }

            }
            else
            {
                Resetear();
            }
        }

        // Resetear los valores del cuadro de Datos Peques
        private void Resetear()
        {

            String[] reyes = { "Melchor", "Gaspar", "Baltasar" };
            cmbReyes.Items.Clear();
            cmbReyes.Items.AddRange(reyes);
            cmbReyes.SelectedIndex = 0;
            txtNombre.Text = string.Empty;
            txtApellidos.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtRegalos.Text = string.Empty;
            numId.Value = 0;
            dateNacimiento.Value = DateTime.Now;
            checkBueno.Checked = false;
            btModificar.ResetBackColor();
            btModificar.ResetForeColor();
            btAnadir.ResetBackColor();
            btAnadir.ResetForeColor();


        }
        // Añadir regalos a la lista cuando se Añade o Modifica un Peque
        private void MasMenosClick(object sender, EventArgs e)
        {
            System.Windows.Forms.Button boton = sender as System.Windows.Forms.Button;
            int lineasActuales = txtRegalos.Text.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries).Length;

            if (boton != null)
            {
                if (boton.Text == "+")
                {
                  if (txtRegalo.Text != string.Empty)
                    {
                        if ((checkBueno.Checked && lineasActuales < 10) || (!checkBueno.Checked && lineasActuales < 5))
                        {
                            txtRegalos.Text = txtRegalos.Text + txtRegalo.Text + "\r\n";
                            txtRegalo.Text = string.Empty;
                    
                        }
                        else
                        {
                            lbAviso.Visible = true;
                            lbAviso.Text = "Todos los regalos permitidos completos";
                            
                        }
                    }
                    else
                    {
                        lbAviso.Text = "Por favor, escriba el regalo";
                        txtRegalo.BackColor = Color.Red;  
                        lbAviso.Visible = true;
                    }
                   
                }
                else 
                {
                    if (txtRegalo.Text != string.Empty)
                    {
                        string elementoABorrar = txtRegalo.Text + "\r\n";

                        if (txtRegalos.Text.Contains(elementoABorrar))
                        {
                            txtRegalos.Text = txtRegalos.Text.Replace(elementoABorrar, "");
  
                        }
                        else
                        {
                            lbAviso.Text = "No existe el regalo a borrar";
                            lbAviso.Visible = true;
                        }
                    }
                    else
                    {
                        txtRegalo.BackColor = Color.Red;
                        lbAviso.Text = "Por favor, escriba el regalo";
                        lbAviso.Visible = true;
                    }
                }
            }
        }

        // Devolver el fondo blanco a los textBox si tienen valor
        private void ColorTextChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox txt = sender as System.Windows.Forms.TextBox;
            if(txt.Text != string.Empty)
            {
                txt.ResetBackColor();
            }
        }

        // Cambia el total que se muestra en la lista de regalos en función de si es bueno o no
        private void checkBueno_CheckedChanged(object sender, EventArgs e)
        {
            int n = 0;
            string regalo;
            int id = (int)numId.Value;
            Peque pequeCargado;

            if (id != 0)
            {
                pequeCargado = encargos.BuscarPeque(id);

                if (pequeCargado != null)
                {
                    txtRegalos.Text = "";

                    int limiteRegalos = checkBueno.Checked ? 10 : 5;

                    while (n < limiteRegalos && n < pequeCargado.Regalos.Count)
                    {
                        regalo = pequeCargado.Regalos[n];
                        txtRegalos.Text = txtRegalos.Text + regalo + "\r\n";
                        n++;
                    }

                    txtRegalos.SelectionStart = txtRegalos.TextLength;
                    txtRegalos.SelectionLength = 0;
                }
            }
        }

        // Utiliza el método Split para separar el string por saltos de línea
        private List<string> CrearListaRegalos(string lista)
        {
            lista = txtRegalos.Text;
            string[] lineasArray = lista.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);

            List<string> lineasLista = new List<string>(lineasArray);

            return lineasLista;
        }

        // Eliminar Peque seleccionado en DataGridView
        private void btEliminar_Click(object sender, EventArgs e)
        {
            String cuerpo;
            String cabecera;
            MessageBoxIcon icono;
            DialogResult result;

            if (btEliminar.BackColor == Color.Blue && dataPeques.SelectedRows.Count > 0)
            {
                Peque pequeSeleccionado = dataPeques.SelectedRows[0].DataBoundItem as Peque;


                cuerpo = "¿Está seguro de que desea borrar?";
                cabecera = "Confirmar borrado";
                icono = MessageBoxIcon.Exclamation;
                MessageBoxButtons botones = MessageBoxButtons.OKCancel;
                result = MessageBox.Show(cuerpo, cabecera, botones, icono);

                if (result == DialogResult.OK)
                {
                   if (encargos.BorrarPeque(pequeSeleccionado))
                    {
                        ActualizarDataGridView();

                        btEliminar.ResetBackColor();
                        btEliminar.ResetForeColor();
                        lbAviso.ForeColor = Color.Black;
                        lbAviso.Text = "Peque eliminado";
                        lbAviso.Visible = true;
                        ActualizarDataGridView();
                    }
                    else
                    {
                        btEliminar.ResetBackColor();
                        btEliminar.ResetForeColor();
                        lbAviso.ForeColor = Color.Red;
                        lbAviso.Text = "No se pudo eliminar el peque";
                        lbAviso.Visible = true;
                    }               
                }
            }
            else
            {
                lbAviso.ForeColor = Color.Red;
                lbAviso.Text = "Ningún peque seleccionado.";
                lbAviso.Visible = true;
                btEliminar.ResetBackColor();
                btEliminar.ResetForeColor();
            }
        }

        // Realiza uno u otro evento en función del textBox de la ruta
        private void picGuardar_Click(object sender, EventArgs e)
        {
            if (txtArchivo.Visible==false)
            {
                btCargar_Click(sender, e);
            }
            else
            {
                btGuardar_Click(sender, e);
            }
        }

        // Gestiona la carga de documentos
        private void btCargar_Click(object sender, EventArgs e)
        {
            if (openFilePeques.ShowDialog() == DialogResult.OK)
            {
                txtArchivo.Text = openFilePeques.FileName;
                txtArchivo.Visible = true;
                if (encargos.CambiarRuta(txtArchivo.Text)==false)
                {
                    lbAviso.ForeColor = Color.Red;
                    lbAviso.Text = "No se pudo actualizar el archivo";
                    lbAviso.Visible = true;
                }
                else
                {
                    lbAviso.ForeColor = Color.Black;
                    lbAviso.Text = "Archivo actualizado";
                    lbAviso.Visible = true;

                }
            }
            else
            {
                txtArchivo.Text = "Archivo incorrecto";
                txtArchivo.Visible = true;
            }
        }

        // Gestiona guardar en documento
        private void btGuardar_Click(object sender, EventArgs e)
        {
            if (saveFilePeques.ShowDialog() == DialogResult.OK)
            {
                string nuevoArchivo = saveFilePeques.FileName;
                string contenidoJsonOriginal = File.ReadAllText("ReyesMagos.json");
                File.WriteAllText(nuevoArchivo, contenidoJsonOriginal);

                txtArchivo.Text = nuevoArchivo;
                txtArchivo.Visible = true;
                lbAviso.ForeColor = Color.Black;
                lbAviso.Text = "Copia de seguridad efectuada";
                lbAviso.Visible = true;
            }
            else
            {
                txtArchivo.Text = "Archivo incorrecto";
                txtArchivo.Visible = true;
            }

        }

        // Cerrar sesión y volver al formulario de acceso
        private void picSalir_Click(object sender, EventArgs e)
        {
            String cuerpo;
            String cabecera;
            MessageBoxIcon icono;
            DialogResult result;

            cuerpo = "¿Está seguro de que desea cerrar sesión?";
            cabecera = "Cerrar sesión";
            icono = MessageBoxIcon.Information;
            MessageBoxButtons botones = MessageBoxButtons.OKCancel;
            result = MessageBox.Show(cuerpo, cabecera, botones, icono);

            if (result == DialogResult.OK)
            {   
                new Acceso().Show();
                this.Close();
            }
        }

        // Salir completamente de la app
        private void btSalir_Click(object sender, EventArgs e)
        {
            String cuerpo;
            String cabecera;
            MessageBoxIcon icono;
            DialogResult result;

            cuerpo = "¿Está seguro de que desea salir?";
            cabecera = "Cerrar aplicación";
            icono = MessageBoxIcon.Information;
            MessageBoxButtons botones = MessageBoxButtons.OKCancel;
            result = MessageBox.Show(cuerpo, cabecera, botones, icono);

            if (result == DialogResult.OK)
            {
                this.Close();

            }
        }

      
    }
   
}
