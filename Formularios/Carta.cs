using Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Formularios
{

    public partial class Carta : Form
    {
        private Peque peque = new Peque();
        public Carta()
        {
            InitializeComponent();
        }

        // Coge el peque que viene del formulario anterior
        public Carta(Peque p)
        {
            peque = p;
            InitializeComponent();
        }

        // Muestra los datos del peque
        private void Carta_Load(object sender, EventArgs e)
        {
            lbNombre.Text = peque.Nombre;
            lbEdad.Text = peque.CalcularEdad().ToString();
            bool esBueno = peque.Bueno;
            checkBien.Checked = esBueno;
            checkRegu.Checked = !esBueno;

            List<Label> labels = new List<Label>
            {
                lbRegalo1, lbRegalo2, lbRegalo3, lbRegalo4, lbRegalo5,
                lbRegalo6, lbRegalo7, lbRegalo8, lbRegalo9, lbRegalo10
            };

            int maxRegalos = esBueno ? 10 : 5;

            for (int i = 0; i < maxRegalos; i++)
            {
                labels[i].Text = (i < peque.Regalos.Count) ? peque.Regalos[i] : "";
                labels[i].Visible = (i < peque.Regalos.Count);
            }
        }

        // Permite volver al formulario anterior
        private void picVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
