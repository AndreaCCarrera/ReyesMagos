namespace Formularios
{
    partial class GestorPeques
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestorPeques));
            this.groupLista = new System.Windows.Forms.GroupBox();
            this.lbAviso = new System.Windows.Forms.Label();
            this.picCarta = new System.Windows.Forms.PictureBox();
            this.dataPeques = new System.Windows.Forms.DataGridView();
            this.btTodos = new System.Windows.Forms.Button();
            this.btBuenos = new System.Windows.Forms.Button();
            this.lbBienvenida = new System.Windows.Forms.Label();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btModificar = new System.Windows.Forms.Button();
            this.picFondo = new System.Windows.Forms.PictureBox();
            this.picSalir = new System.Windows.Forms.PictureBox();
            this.btAnadir = new System.Windows.Forms.Button();
            this.picRegalo = new System.Windows.Forms.PictureBox();
            this.btSalir = new System.Windows.Forms.Button();
            this.groupDatos = new System.Windows.Forms.GroupBox();
            this.lbFavorito = new System.Windows.Forms.Label();
            this.lbFecha = new System.Windows.Forms.Label();
            this.lbDireccion = new System.Windows.Forms.Label();
            this.lbApellidos = new System.Windows.Forms.Label();
            this.lNombre = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.checkBueno = new System.Windows.Forms.CheckBox();
            this.cmbReyes = new System.Windows.Forms.ComboBox();
            this.btMenos = new System.Windows.Forms.Button();
            this.btMas = new System.Windows.Forms.Button();
            this.dateNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtRegalo = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.numId = new System.Windows.Forms.NumericUpDown();
            this.txtRegalos = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.picGuardar = new System.Windows.Forms.PictureBox();
            this.txtArchivo = new System.Windows.Forms.TextBox();
            this.openFilePeques = new System.Windows.Forms.OpenFileDialog();
            this.saveFilePeques = new System.Windows.Forms.SaveFileDialog();
            this.groupLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCarta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPeques)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFondo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRegalo)).BeginInit();
            this.groupDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGuardar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupLista
            // 
            this.groupLista.Controls.Add(this.lbAviso);
            this.groupLista.Controls.Add(this.picCarta);
            this.groupLista.Controls.Add(this.dataPeques);
            this.groupLista.Controls.Add(this.btTodos);
            this.groupLista.Controls.Add(this.btBuenos);
            this.groupLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupLista.Location = new System.Drawing.Point(65, 74);
            this.groupLista.Name = "groupLista";
            this.groupLista.Size = new System.Drawing.Size(678, 290);
            this.groupLista.TabIndex = 0;
            this.groupLista.TabStop = false;
            this.groupLista.Text = "MIS PEQUES";
            // 
            // lbAviso
            // 
            this.lbAviso.AutoSize = true;
            this.lbAviso.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lbAviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAviso.ForeColor = System.Drawing.Color.Firebrick;
            this.lbAviso.Location = new System.Drawing.Point(61, 267);
            this.lbAviso.Name = "lbAviso";
            this.lbAviso.Size = new System.Drawing.Size(46, 16);
            this.lbAviso.TabIndex = 16;
            this.lbAviso.Text = "Aviso";
            this.lbAviso.Visible = false;
            // 
            // picCarta
            // 
            this.picCarta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picCarta.BackgroundImage")));
            this.picCarta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picCarta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picCarta.Location = new System.Drawing.Point(567, 196);
            this.picCarta.Name = "picCarta";
            this.picCarta.Size = new System.Drawing.Size(66, 50);
            this.picCarta.TabIndex = 8;
            this.picCarta.TabStop = false;
            this.picCarta.Click += new System.EventHandler(this.picCarta_Click);
            // 
            // dataPeques
            // 
            this.dataPeques.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataPeques.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPeques.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataPeques.Location = new System.Drawing.Point(31, 41);
            this.dataPeques.Name = "dataPeques";
            this.dataPeques.Size = new System.Drawing.Size(481, 218);
            this.dataPeques.TabIndex = 4;
            this.dataPeques.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataPeques_RowHeaderMouseClick);
            // 
            // btTodos
            // 
            this.btTodos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btTodos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTodos.Location = new System.Drawing.Point(550, 130);
            this.btTodos.Name = "btTodos";
            this.btTodos.Size = new System.Drawing.Size(106, 42);
            this.btTodos.TabIndex = 3;
            this.btTodos.Text = "TODOS";
            this.btTodos.UseVisualStyleBackColor = false;
            this.btTodos.Click += new System.EventHandler(this.btTodos_Click);
            // 
            // btBuenos
            // 
            this.btBuenos.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btBuenos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btBuenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuenos.Location = new System.Drawing.Point(550, 57);
            this.btBuenos.Name = "btBuenos";
            this.btBuenos.Size = new System.Drawing.Size(106, 42);
            this.btBuenos.TabIndex = 2;
            this.btBuenos.Text = "BUENOS";
            this.btBuenos.UseVisualStyleBackColor = false;
            this.btBuenos.Click += new System.EventHandler(this.btBuenos_Click);
            // 
            // lbBienvenida
            // 
            this.lbBienvenida.AutoSize = true;
            this.lbBienvenida.Font = new System.Drawing.Font("Gabriola", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBienvenida.Location = new System.Drawing.Point(32, 19);
            this.lbBienvenida.Name = "lbBienvenida";
            this.lbBienvenida.Size = new System.Drawing.Size(90, 39);
            this.lbBienvenida.TabIndex = 1;
            this.lbBienvenida.Text = "Bienvenido,";
            // 
            // btEliminar
            // 
            this.btEliminar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEliminar.Location = new System.Drawing.Point(96, 385);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(115, 42);
            this.btEliminar.TabIndex = 4;
            this.btEliminar.Text = "ELIMINAR";
            this.btEliminar.UseVisualStyleBackColor = false;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // btModificar
            // 
            this.btModificar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btModificar.Location = new System.Drawing.Point(280, 385);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(114, 42);
            this.btModificar.TabIndex = 5;
            this.btModificar.Text = "MODIFICAR";
            this.btModificar.UseVisualStyleBackColor = false;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
            // 
            // picFondo
            // 
            this.picFondo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picFondo.BackgroundImage")));
            this.picFondo.Location = new System.Drawing.Point(-2, 450);
            this.picFondo.Name = "picFondo";
            this.picFondo.Size = new System.Drawing.Size(802, 236);
            this.picFondo.TabIndex = 6;
            this.picFondo.TabStop = false;
            // 
            // picSalir
            // 
            this.picSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picSalir.BackgroundImage")));
            this.picSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSalir.Location = new System.Drawing.Point(699, 12);
            this.picSalir.Name = "picSalir";
            this.picSalir.Size = new System.Drawing.Size(66, 50);
            this.picSalir.TabIndex = 7;
            this.picSalir.TabStop = false;
            this.picSalir.Click += new System.EventHandler(this.picSalir_Click);
            // 
            // btAnadir
            // 
            this.btAnadir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btAnadir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAnadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAnadir.Location = new System.Drawing.Point(464, 385);
            this.btAnadir.Name = "btAnadir";
            this.btAnadir.Size = new System.Drawing.Size(113, 42);
            this.btAnadir.TabIndex = 6;
            this.btAnadir.Text = "AÑADIR";
            this.btAnadir.UseVisualStyleBackColor = false;
            this.btAnadir.Click += new System.EventHandler(this.btAnadir_Click);
            // 
            // picRegalo
            // 
            this.picRegalo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picRegalo.BackgroundImage")));
            this.picRegalo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picRegalo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRegalo.Location = new System.Drawing.Point(627, 366);
            this.picRegalo.Name = "picRegalo";
            this.picRegalo.Size = new System.Drawing.Size(77, 67);
            this.picRegalo.TabIndex = 9;
            this.picRegalo.TabStop = false;
            this.picRegalo.Click += new System.EventHandler(this.picRegalo_Click);
            // 
            // btSalir
            // 
            this.btSalir.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSalir.Location = new System.Drawing.Point(265, 590);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(237, 42);
            this.btSalir.TabIndex = 12;
            this.btSalir.Text = "SALIR";
            this.btSalir.UseVisualStyleBackColor = false;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // groupDatos
            // 
            this.groupDatos.Controls.Add(this.lbFavorito);
            this.groupDatos.Controls.Add(this.lbFecha);
            this.groupDatos.Controls.Add(this.lbDireccion);
            this.groupDatos.Controls.Add(this.lbApellidos);
            this.groupDatos.Controls.Add(this.lNombre);
            this.groupDatos.Controls.Add(this.lbId);
            this.groupDatos.Controls.Add(this.checkBueno);
            this.groupDatos.Controls.Add(this.cmbReyes);
            this.groupDatos.Controls.Add(this.btMenos);
            this.groupDatos.Controls.Add(this.btMas);
            this.groupDatos.Controls.Add(this.dateNacimiento);
            this.groupDatos.Controls.Add(this.txtRegalo);
            this.groupDatos.Controls.Add(this.txtDireccion);
            this.groupDatos.Controls.Add(this.numId);
            this.groupDatos.Controls.Add(this.txtRegalos);
            this.groupDatos.Controls.Add(this.txtApellidos);
            this.groupDatos.Controls.Add(this.txtNombre);
            this.groupDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupDatos.Location = new System.Drawing.Point(39, 480);
            this.groupDatos.Name = "groupDatos";
            this.groupDatos.Size = new System.Drawing.Size(704, 181);
            this.groupDatos.TabIndex = 13;
            this.groupDatos.TabStop = false;
            this.groupDatos.Text = "DATOS PEQUE";
            this.groupDatos.Visible = false;
            // 
            // lbFavorito
            // 
            this.lbFavorito.AutoSize = true;
            this.lbFavorito.Location = new System.Drawing.Point(250, 67);
            this.lbFavorito.Name = "lbFavorito";
            this.lbFavorito.Size = new System.Drawing.Size(35, 16);
            this.lbFavorito.TabIndex = 33;
            this.lbFavorito.Text = "Rey";
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Location = new System.Drawing.Point(13, 146);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(132, 16);
            this.lbFecha.TabIndex = 32;
            this.lbFecha.Text = "Fecha Nacimiento";
            // 
            // lbDireccion
            // 
            this.lbDireccion.AutoSize = true;
            this.lbDireccion.Location = new System.Drawing.Point(227, 30);
            this.lbDireccion.Name = "lbDireccion";
            this.lbDireccion.Size = new System.Drawing.Size(73, 16);
            this.lbDireccion.TabIndex = 31;
            this.lbDireccion.Text = "Dirección";
            // 
            // lbApellidos
            // 
            this.lbApellidos.AutoSize = true;
            this.lbApellidos.Location = new System.Drawing.Point(13, 105);
            this.lbApellidos.Name = "lbApellidos";
            this.lbApellidos.Size = new System.Drawing.Size(73, 16);
            this.lbApellidos.TabIndex = 30;
            this.lbApellidos.Text = "Apellidos";
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Location = new System.Drawing.Point(23, 67);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(62, 16);
            this.lNombre.TabIndex = 29;
            this.lNombre.Text = "Nombre";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(45, 30);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(20, 16);
            this.lbId.TabIndex = 28;
            this.lbId.Text = "Id";
            // 
            // checkBueno
            // 
            this.checkBueno.AutoSize = true;
            this.checkBueno.Location = new System.Drawing.Point(318, 102);
            this.checkBueno.Name = "checkBueno";
            this.checkBueno.Size = new System.Drawing.Size(79, 20);
            this.checkBueno.TabIndex = 27;
            this.checkBueno.Text = "BUENO";
            this.checkBueno.UseVisualStyleBackColor = true;
            this.checkBueno.CheckedChanged += new System.EventHandler(this.checkBueno_CheckedChanged);
            // 
            // cmbReyes
            // 
            this.cmbReyes.FormattingEnabled = true;
            this.cmbReyes.Location = new System.Drawing.Point(305, 62);
            this.cmbReyes.Name = "cmbReyes";
            this.cmbReyes.Size = new System.Drawing.Size(158, 24);
            this.cmbReyes.TabIndex = 26;
            this.cmbReyes.SelectedIndexChanged += new System.EventHandler(this.NewTextChanged);
            // 
            // btMenos
            // 
            this.btMenos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btMenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMenos.Location = new System.Drawing.Point(482, 134);
            this.btMenos.Name = "btMenos";
            this.btMenos.Size = new System.Drawing.Size(29, 37);
            this.btMenos.TabIndex = 25;
            this.btMenos.Text = "-";
            this.btMenos.UseVisualStyleBackColor = true;
            this.btMenos.Click += new System.EventHandler(this.MasMenosClick);
            // 
            // btMas
            // 
            this.btMas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btMas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMas.Location = new System.Drawing.Point(649, 134);
            this.btMas.Name = "btMas";
            this.btMas.Size = new System.Drawing.Size(33, 38);
            this.btMas.TabIndex = 24;
            this.btMas.Text = "+";
            this.btMas.UseVisualStyleBackColor = true;
            this.btMas.Click += new System.EventHandler(this.MasMenosClick);
            // 
            // dateNacimiento
            // 
            this.dateNacimiento.Location = new System.Drawing.Point(163, 143);
            this.dateNacimiento.Name = "dateNacimiento";
            this.dateNacimiento.Size = new System.Drawing.Size(300, 22);
            this.dateNacimiento.TabIndex = 23;
            this.dateNacimiento.ValueChanged += new System.EventHandler(this.NewTextChanged);
            // 
            // txtRegalo
            // 
            this.txtRegalo.Location = new System.Drawing.Point(517, 143);
            this.txtRegalo.Name = "txtRegalo";
            this.txtRegalo.Size = new System.Drawing.Size(126, 22);
            this.txtRegalo.TabIndex = 21;
            this.txtRegalo.TextChanged += new System.EventHandler(this.ColorTextChanged);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(305, 26);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(158, 22);
            this.txtDireccion.TabIndex = 20;
            this.txtDireccion.TextChanged += new System.EventHandler(this.NewTextChanged);
            // 
            // numId
            // 
            this.numId.Location = new System.Drawing.Point(90, 27);
            this.numId.Name = "numId";
            this.numId.Size = new System.Drawing.Size(123, 22);
            this.numId.TabIndex = 19;
            this.numId.ValueChanged += new System.EventHandler(this.numId_ValueChanged);
            // 
            // txtRegalos
            // 
            this.txtRegalos.Location = new System.Drawing.Point(482, 21);
            this.txtRegalos.Multiline = true;
            this.txtRegalos.Name = "txtRegalos";
            this.txtRegalos.ReadOnly = true;
            this.txtRegalos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRegalos.Size = new System.Drawing.Size(200, 103);
            this.txtRegalos.TabIndex = 18;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(90, 102);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(195, 22);
            this.txtApellidos.TabIndex = 17;
            this.txtApellidos.TextChanged += new System.EventHandler(this.NewTextChanged);
            this.txtApellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckKeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(90, 64);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(123, 22);
            this.txtNombre.TabIndex = 16;
            this.txtNombre.TextChanged += new System.EventHandler(this.NewTextChanged);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckKeyPress);
            // 
            // picGuardar
            // 
            this.picGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picGuardar.BackgroundImage")));
            this.picGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGuardar.Location = new System.Drawing.Point(632, 12);
            this.picGuardar.Name = "picGuardar";
            this.picGuardar.Size = new System.Drawing.Size(41, 50);
            this.picGuardar.TabIndex = 14;
            this.picGuardar.TabStop = false;
            this.picGuardar.Click += new System.EventHandler(this.picGuardar_Click);
            // 
            // txtArchivo
            // 
            this.txtArchivo.Location = new System.Drawing.Point(372, 30);
            this.txtArchivo.Name = "txtArchivo";
            this.txtArchivo.Size = new System.Drawing.Size(244, 20);
            this.txtArchivo.TabIndex = 15;
            this.txtArchivo.Visible = false;
            // 
            // openFilePeques
            // 
            this.openFilePeques.Filter = "Archivos JSON (*.json) | *.json";
            // 
            // saveFilePeques
            // 
            this.saveFilePeques.Filter = "Archivos JSON (*.json) | *.json";
            // 
            // GestorPeques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 684);
            this.Controls.Add(this.txtArchivo);
            this.Controls.Add(this.picGuardar);
            this.Controls.Add(this.groupDatos);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.picRegalo);
            this.Controls.Add(this.btModificar);
            this.Controls.Add(this.btAnadir);
            this.Controls.Add(this.picSalir);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.lbBienvenida);
            this.Controls.Add(this.groupLista);
            this.Controls.Add(this.picFondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GestorPeques";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor Peques";
            this.Load += new System.EventHandler(this.GestorPeques_Load);
            this.Click += new System.EventHandler(this.GestorPeques_Click);
            this.groupLista.ResumeLayout(false);
            this.groupLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCarta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPeques)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFondo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRegalo)).EndInit();
            this.groupDatos.ResumeLayout(false);
            this.groupDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGuardar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupLista;
        private System.Windows.Forms.Label lbBienvenida;
        private System.Windows.Forms.Button btBuenos;
        private System.Windows.Forms.Button btTodos;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.PictureBox picFondo;
        private System.Windows.Forms.PictureBox picSalir;
        private System.Windows.Forms.Button btAnadir;
        private System.Windows.Forms.PictureBox picCarta;
        private System.Windows.Forms.DataGridView dataPeques;
        private System.Windows.Forms.PictureBox picRegalo;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.GroupBox groupDatos;
        private System.Windows.Forms.PictureBox picGuardar;
        private System.Windows.Forms.DateTimePicker dateNacimiento;
        private System.Windows.Forms.TextBox txtRegalo;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.NumericUpDown numId;
        private System.Windows.Forms.TextBox txtRegalos;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtArchivo;
        private System.Windows.Forms.ComboBox cmbReyes;
        private System.Windows.Forms.Button btMenos;
        private System.Windows.Forms.Button btMas;
        private System.Windows.Forms.CheckBox checkBueno;
        private System.Windows.Forms.Label lbAviso;
        private System.Windows.Forms.Label lbFavorito;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Label lbDireccion;
        private System.Windows.Forms.Label lbApellidos;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.OpenFileDialog openFilePeques;
        private System.Windows.Forms.SaveFileDialog saveFilePeques;
    }
}