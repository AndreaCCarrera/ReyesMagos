using Model;
using Data;
using System;
using System.Collections.Generic;


namespace Business
{
    public class Encargos
    {
        private List<Peque> listaPeques;
        Fichero fichero = new Fichero();    

        public List<Peque> ListaPeques { get => listaPeques; set => listaPeques = value; }

        public Encargos(List<Peque> listaPeques)
        {
            this.listaPeques = listaPeques;
        }

        // Constructor con la lista del fic
        public Encargos()
        {
            this.listaPeques = ListarPeques();
        }

        public List<Peque> ListarPeques()
        {
            if (fichero.ExisteConexion())
            {
                return fichero.ListarElementos();
            }
            else
            {
                fichero.CrearData();
                return fichero.ListarElementos();
            }
           

        }
        public bool AnadirPeque(Peque peque) {

            Boolean anadido = false;

            if(peque != null)
            {
                fichero.AnadirElemento(peque);
                fichero.ListarElementos();
                anadido = true;
            }
        
            return anadido;
        
        }

        public bool BorrarPeque(Peque peque)
        {

            Boolean anadido = false;

            if (peque != null)
            {
               if(fichero.BorrarElemento(peque.Id))
                {
                    fichero.ListarElementos();
                    anadido = true;
                }
               
            }

            return anadido;

        }

        public bool ModificarPeque (Peque peque)
        {

            Boolean anadido = false;

            if (peque != null)
            {
               if( fichero.ModificarElemento(peque.Id, peque))
                {
                    fichero.ListarElementos();
                    anadido = true;
                }
               
            }

            return anadido;

        }

        public Peque BuscarPeque(int id)
        {
            Peque pequeId = null; // Inicializa como null para indicar que no se ha encontrado aún.

            if (id != 0)
            {
                foreach (Peque peque in listaPeques)
                {
                    if (peque.Id == id)
                    {
                        pequeId = peque;
                        break;
                    }
                }
            }

            return pequeId;
        }

        // Lista de regalos de un peque por su id
        public List<string> ObtenerListaRegalos(int id)
        {
            List<string> regalos = new List<String>();

            foreach(Peque peque in listaPeques)
            {
                if(peque.Id == id)
                {
                    foreach(string regalo in regalos)
                    {
                        regalos.Add(regalo);
                    }
                }
            }  

            return regalos;

        }

        // Obtener la lista de regalos de todos los peques
        public List<string> ObtenerTodosRegalos()
        {
            List<string> regalos = new List<String>();

            foreach (Peque peque in listaPeques)
            {
                {
                    foreach (string regalo in peque.Regalos)
                    {
                        regalos.Add(regalo);
                    }
                }
            }

            return regalos;

        }

        // Filtrar peques por su rey favorito

        public List<Peque> FiltrarReyFavorito(String reyMago)
        {
            List<Peque> listaFiltrada = new List<Peque>();

            foreach (Peque peque in this.listaPeques)
            {

                if (peque.ReyFavorito.Equals(reyMago))
                {
                    listaFiltrada.Add(peque);
                }
            }


            return listaFiltrada;
        }


        // Filtrar peques por el boolean bueno
        public List<Peque> FiltrarBuenos(List<Peque> filtrada)
        {
            List<Peque> listaFiltrada = new List<Peque>();

            foreach (Peque peque in filtrada)
            {

                if (peque.Bueno)
                {
                    listaFiltrada.Add(peque);
                }
            }

            return listaFiltrada;
        }

        // Modificar la ruta del archivo del que se obtienen los datos

        public bool CambiarRuta(String nuevaRuta)
        {
           if(fichero.CambiarRuta(nuevaRuta))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
