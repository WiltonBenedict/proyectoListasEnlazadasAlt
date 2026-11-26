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

        // Agrega una imagen al final de la lista
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
            Cola.Siguiente = nuevoNodo; // 1. El último actual apunta al nuevo
            nuevoNodo.Anterior = Cola; // 2. El nuevo apunta de vuelta al último actual
            Cola = nuevoNodo;  // 3. El nuevo pasa a ser la Cola
        }

        // Avanza al siguiente nodo y devuelve su imagen
        public Image ObtenerSiguienteImagen()
        {
            if (actual == null) return null; // Lista vacía: no hay nada que mostrar.

            if (actual.Siguiente != null)
                actual = actual.Siguiente; // Avanza solo si hay un siguiente nodo.

            return actual.Imagen;
        }

        // retrocede al nodo anterior y devuelve su imagen
        public Image ObtenerImagenAnterior()
        {
            if (actual == null) return null; // Lista vacía: no hay nada que mostrar.

            if (actual.Anterior != null)
                actual = actual.Anterior;// Avanza solo si hay un anterior nodo.

            return actual.Imagen;
        }

        public Image ObtenerImagenActual()
        {
            return actual?.Imagen;  //Si actual es null, devuelve null. De lo contrario, devuelve la imagen actual.
        }

        public void Reiniciar()
        {
            actual = Cabeza;
        }
    }
}
