namespace Formularios
{
    partial class Acceso
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Acceso));
            this.lbAviso = new System.Windows.Forms.Label();
            this.picOjo = new System.Windows.Forms.PictureBox();
            this.btEntrar = new System.Windows.Forms.Button();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lbContrasena = new System.Windows.Forms.Label();
            this.lbDni = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picOjo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbAviso
            // 
            this.lbAviso.AutoSize = true;
            this.lbAviso.BackColor = System.Drawing.SystemColors.Info;
            this.lbAviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAviso.ForeColor = System.Drawing.Color.Firebrick;
            this.lbAviso.Location = new System.Drawing.Point(264, 217);
            this.lbAviso.Name = "lbAviso";
            this.lbAviso.Size = new System.Drawing.Size(46, 16);
            this.lbAviso.TabIndex = 14;
            this.lbAviso.Text = "Aviso";
            this.lbAviso.Visible = false;
            // 
            // picOjo
            // 
            this.picOjo.BackColor = System.Drawing.SystemColors.Info;
            this.picOjo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picOjo.BackgroundImage")));
            this.picOjo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picOjo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picOjo.ErrorImage = null;
            this.picOjo.Location = new System.Drawing.Point(563, 162);
            this.picOjo.Name = "picOjo";
            this.picOjo.Size = new System.Drawing.Size(35, 29);
            this.picOjo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOjo.TabIndex = 13;
            this.picOjo.TabStop = false;
            this.picOjo.Click += new System.EventHandler(this.picOjo_Click);
            // 
            // btEntrar
            // 
            this.btEntrar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEntrar.Location = new System.Drawing.Point(254, 245);
            this.btEntrar.Name = "btEntrar";
            this.btEntrar.Size = new System.Drawing.Size(303, 37);
            this.btEntrar.TabIndex = 12;
            this.btEntrar.Text = "ENTRAR";
            this.btEntrar.UseVisualStyleBackColor = false;
            this.btEntrar.Click += new System.EventHandler(this.btEntrar_Click);
            // 
            // txtContrasena
            // 
            this.txtContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasena.Location = new System.Drawing.Point(372, 167);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '*';
            this.txtContrasena.Size = new System.Drawing.Size(185, 22);
            this.txtContrasena.TabIndex = 11;
            this.txtContrasena.TextChanged += new System.EventHandler(this.NewTextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(372, 115);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(185, 22);
            this.txtNombre.TabIndex = 10;
            this.txtNombre.TextChanged += new System.EventHandler(this.NewTextChanged);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckKeyPress);
            // 
            // lbContrasena
            // 
            this.lbContrasena.AutoSize = true;
            this.lbContrasena.BackColor = System.Drawing.SystemColors.Info;
            this.lbContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContrasena.Location = new System.Drawing.Point(256, 168);
            this.lbContrasena.Name = "lbContrasena";
            this.lbContrasena.Size = new System.Drawing.Size(98, 15);
            this.lbContrasena.TabIndex = 9;
            this.lbContrasena.Text = "CONTRASEÑA";
            // 
            // lbDni
            // 
            this.lbDni.AutoSize = true;
            this.lbDni.BackColor = System.Drawing.SystemColors.Info;
            this.lbDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDni.Location = new System.Drawing.Point(264, 118);
            this.lbDni.Name = "lbDni";
            this.lbDni.Size = new System.Drawing.Size(75, 16);
            this.lbDni.TabIndex = 8;
            this.lbDni.Text = "USUARIO";
            // 
            // Acceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(783, 360);
            this.Controls.Add(this.lbAviso);
            this.Controls.Add(this.picOjo);
            this.Controls.Add(this.btEntrar);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lbContrasena);
            this.Controls.Add(this.lbDni);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Acceso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acceso";
            this.Click += new System.EventHandler(this.Acceso_Click);
            ((System.ComponentModel.ISupportInitialize)(this.picOjo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAviso;
        private System.Windows.Forms.PictureBox picOjo;
        private System.Windows.Forms.Button btEntrar;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lbContrasena;
        private System.Windows.Forms.Label lbDni;
    }
}

