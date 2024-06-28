using System;
using System.Windows.Forms;

namespace Formularios
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Acceso acceso = new Acceso();
            acceso.Show();
            acceso.FormClosed += MainForm_Closed;
            Application.Run();
        }

        private static void MainForm_Closed(object sender, FormClosedEventArgs e)
        {
            ((Form)sender).FormClosed -= MainForm_Closed; //Elimina la subscripción al evento porque ya este en la función
            if (Application.OpenForms.Count == 0) // Si no hay ningún form abierto entra
            {
                Application.ExitThread(); // Cierra la aplicación
            }
            else
            {
                Application.OpenForms[0].FormClosed += MainForm_Closed; // Vuelve añadir la subscripción al evento para que cierre
            }
        }
    }
}