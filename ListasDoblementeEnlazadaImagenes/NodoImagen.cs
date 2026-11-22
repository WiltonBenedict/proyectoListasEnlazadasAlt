using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDoblementeEnlazadaImagenes
{
    internal class NodoImagen
    {
        //Universidad Hispanoamericana
        //Estructura de Datos, INFO-105.
        //Proyecto Programado II
        //Est. Wilton Benedict Castillo
        //Est. Leandro Bonilla Lobo
        //Est. Johan Araya Retana

        // El 'Data' es un objeto Image de Windows Forms
        public Image Imagen { get; set; }
        public NodoImagen Siguiente { get; set; }
        public NodoImagen Anterior { get; set; }

        public NodoImagen(string ruta)
        {
            // Carga la imagen desde la ruta del archivo
            Imagen = Image.FromFile(ruta);
            Siguiente = null;
            Anterior = null; // Para la lista doblemente enlazada
        }
    }
}
