namespace Formularios
{
    partial class ListaRegalos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaRegalos));
            this.txtLista = new System.Windows.Forms.TextBox();
            this.picVolver = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picVolver)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLista
            // 
            this.txtLista.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtLista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLista.Cursor = System.Windows.Forms.Cursors.No;
            this.txtLista.Font = new System.Drawing.Font("Gabriola", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLista.Location = new System.Drawing.Point(124, 165);
            this.txtLista.Multiline = true;
            this.txtLista.Name = "txtLista";
            this.txtLista.ReadOnly = true;
            this.txtLista.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLista.Size = new System.Drawing.Size(285, 339);
            this.txtLista.TabIndex = 0;
            this.txtLista.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // picVolver
            // 
            this.picVolver.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picVolver.BackgroundImage")));
            this.picVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picVolver.Location = new System.Drawing.Point(195, 96);
            this.picVolver.Name = "picVolver";
            this.picVolver.Size = new System.Drawing.Size(75, 46);
            this.picVolver.TabIndex = 1;
            this.picVolver.TabStop = false;
            this.picVolver.Click += new System.EventHandler(this.picVolver_Click);
            // 
            // ListaRegalos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(478, 654);
            this.Controls.Add(this.picVolver);
            this.Controls.Add(this.txtLista);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ListaRegalos";
            this.Text = "Lista Regalos";
            this.Load += new System.EventHandler(this.ListaRegalos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picVolver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLista;
        private System.Windows.Forms.PictureBox picVolver;
    }
}