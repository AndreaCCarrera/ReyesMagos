using Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Formatting = Newtonsoft.Json.Formatting;


namespace Data
{
    public class Fichero
    {
        private static string ruta = "ReyesMagos.json";

        public string Ruta { get => ruta; set => ruta = value; }

        // Lista de peques con todos sus datos
        public List<Peque> ListarElementos()

        {
            string contenidoJson = File.ReadAllText(ruta);


            List<Peque> peques = JsonConvert.DeserializeObject<List<Peque>>(contenidoJson);

            if (peques == null)
            {

                peques = new List<Peque>();
            }

            return peques;
        }

        // Método que añade peque a la lista
        public void AnadirElemento(Peque peque)
        {

            peque.Id = UltimoId() + 1;
            List<Peque> listaOG = ListarElementos();
            listaOG.Add(peque);
            string stringOG = JsonConvert.SerializeObject(listaOG, Formatting.Indented);
            File.WriteAllText(ruta, stringOG);

        }

        // Método que borra peque de la lista por su id
        public bool BorrarElemento(int id) // Reescribir el JSON con la lista sin el elemento
        {

            Boolean borrado = false;

            string contenidoJson = File.ReadAllText(ruta);

            List<Peque> nuevaLista = new List<Peque>();

            List<Peque> objetosEspaciales = JsonConvert.DeserializeObject<List<Peque>>(contenidoJson);
            foreach (Peque peque in objetosEspaciales)
            {
                if (peque.Id != id)
                {
                    nuevaLista.Add(peque);
                }
                else
                {
                    borrado = true;
                }

                if (borrado)
                {
                    string stringOG = JsonConvert.SerializeObject(nuevaLista, Formatting.Indented);
                    File.WriteAllText(ruta, stringOG);
                }

            }

            return borrado;

        }

        // Método que modifica peque de la lista por su id
        public bool ModificarElemento(int id, Peque nuevo) 
        {

            Boolean modificado = false;

            string contenidoJson = File.ReadAllText(ruta);

            List<Peque> nuevaLista = new List<Peque>();

            List<Peque> peques = JsonConvert.DeserializeObject<List<Peque>>(contenidoJson);
            foreach (Peque peque in peques)
            {
                if (peque.Id != id)
                {
                    nuevaLista.Add(peque);
                }
                else
                {
                    nuevaLista.Add(nuevo);
                    modificado = true;
                }


                if (modificado)
                {
                    string stringOG = JsonConvert.SerializeObject(nuevaLista, Formatting.Indented);
                    File.WriteAllText(ruta, stringOG);
                }

            }

            return modificado;
        }

        // Devuelve un peque por id desde el JSON
        public Peque VerDetallesElemento(int id)
        {
            Peque peque = null;

            string contenidoJson = File.ReadAllText(ruta);

            List<Peque> objetosEspaciales = JsonConvert.DeserializeObject<List<Peque>>(contenidoJson);
            foreach (Peque p in objetosEspaciales)
            {
                if (p.Id == id)
                {
                    peque = p;
                    break;
                }

            }

            return peque;
        }

        // Filtra peques por el boolean buenos desde el JSON
        public List<Peque> MostrarBuenos()
        {

            string contenidoJson = File.ReadAllText(ruta);

            List<Peque> nuevaLista = new List<Peque>();

            List<Peque> objetosEspaciales = JsonConvert.DeserializeObject<List<Peque>>(contenidoJson);
            foreach (Peque peque in objetosEspaciales)
            {
                if (peque.Bueno)
                {
                    nuevaLista.Add(peque);

                }

            }

            return nuevaLista;
        }

        // Filtra los peques de un determinado Rey desde el JSON
        public List<Peque> MostrarReyFavorito(String reyMago)
        {

            string contenidoJson = File.ReadAllText(ruta);

            List<Peque> nuevaLista = new List<Peque>();

            List<Peque> objetosEspaciales = JsonConvert.DeserializeObject<List<Peque>>(contenidoJson);
            foreach (Peque peque in objetosEspaciales)
            {
                if (peque.ReyFavorito.Equals(reyMago))
                {
                    nuevaLista.Add(peque);

                }

            }

            return nuevaLista;
        }

        // Coge el id del último peque de la lista para generar el siguiente
        public int UltimoId()
        {
            List<Peque> lista = ListarElementos();


            if (ListarElementos().Count == 0)
            {
                return 0;
            }
            else
            {
                Peque ultimo = lista.Last();
                return ultimo.Id;
            }
        }

        // Comprueba si la ruta del JSON existe

        public bool ExisteConexion()
        {
            return File.Exists(ruta);
        }

        // Genera un archivo para guardar los datos
        public bool CrearData()
        {
            FileStream fs = File.Create(ruta);
            fs.Close();

            return true;

        }

        // Modifica la ruta que se va a cargar
        public bool CambiarRuta(String nuevaRuta)
        {
            ruta = nuevaRuta;

            return true;

        }

    }
}
