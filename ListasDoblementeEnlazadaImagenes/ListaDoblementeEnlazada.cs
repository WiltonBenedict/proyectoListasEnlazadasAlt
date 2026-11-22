using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
//Universidad Hispanoamericana
//Estructura de Datos, INFO-105.
//Proyecto Programado II
//Est. Wilton Benedict Castillo
//Est. Leandro Bonilla Lobo
//Est. Johan Araya Retana
namespace ListasDoblementeEnlazadaImagenes
{
    public class ListaDoblementeEnlazada
    {
        private NodoImagen Cabeza { get; set; }
        private NodoImagen Cola { get; set; }      
        private NodoImagen actual;                 

        public ListaDoblementeEnlazada()
        {
            Cabeza = null;
            Cola = null;
            actual = null;
        }

        // Agregar una imagen al final de la lista
        public void AgregarImagen(string ruta)
        {
            NodoImagen nuevoNodo = new NodoImagen(ruta);

            if (Cabeza == null)
            {
                Cabeza = nuevoNodo;
                Cola = nuevoNodo;
                actual = Cabeza;
                return;
            }

            // 
            Cola.Siguiente = nuevoNodo;
            nuevoNodo.Anterior = Cola;
            Cola = nuevoNodo;
        }

        // Avanza al siguiente nodo y devuelve su imagen
        public Image ObtenerSiguienteImagen()
        {
            if (actual == null) return null;

            if (actual.Siguiente != null)
                actual = actual.Siguiente;

            return actual.Imagen;
        }

        // retrocede al nodo anterior y devuelve su imagen
        public Image ObtenerImagenAnterior()
        {
            if (actual == null) return null;

            if (actual.Anterior != null)
                actual = actual.Anterior;

            return actual.Imagen;
        }

        public Image ObtenerImagenActual()
        {
            return actual?.Imagen;
        }

        public void Reiniciar()
        {
            actual = Cabeza;
        }
    }
}
