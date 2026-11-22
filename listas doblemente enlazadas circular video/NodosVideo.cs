using System;
using System.Collections.Generic;
using System.Text;
//Universidad Hispanoamericana
//Estructura de Datos, INFO-105.
//Proyecto Programado II
//Est. Wilton Benedict Castillo
//Est. Leandro Bonilla Lobo
//Est. Johan Araya Retana

namespace listas_doblemente_enlazadas_circular_video
{
    internal class NodosVideo
    {
        public string Nombre { get; set; }
        public string UrlStream { get; set; }

        public NodosVideo? Siguiente { get; set; }
        public NodosVideo? Anterior { get; set; }

        public NodosVideo(string nombre, string url)

        {
            Nombre = nombre;
            UrlStream = url;
            Siguiente = null;
            Anterior = null;
        }
    }
}
