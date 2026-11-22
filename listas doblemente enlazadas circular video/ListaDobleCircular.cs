//Universidad Hispanoamericana
//Estructura de Datos, INFO-105.
//Proyecto Programado II
//Est. Wilton Benedict Castillo
//Est. Leandro Bonilla Lobo
//Est. Johan Araya Retana
namespace listas_doblemente_enlazadas_circular_video
{
    internal class ListaDobleCircular
    {
        private NodosVideo? Cabeza { get; set; }
        private NodosVideo? actual;

        public ListaDobleCircular()
        {
            Cabeza = null;
            actual = null;
        }

        // Método para agregar un nuevo canal
        public void AgregarCanal(string nombre, string url)
        {
            // Crear un nuevo nodo
            NodosVideo nuevoNodo = new NodosVideo(nombre, url);

            // Caso 1: La lista está vacía
            if (Cabeza == null)
            {
                Cabeza = nuevoNodo;
                actual = Cabeza;

                nuevoNodo.Siguiente = nuevoNodo;
                nuevoNodo.Anterior = nuevoNodo;

                return;
            }

            // Caso 2: La lista ya contiene nodos

            // Obtener el último nodo de la lista
            NodosVideo? ultimo = Cabeza.Anterior;

            if (ultimo == null)
            {
                return;
            }

            // Conectar el último nodo con el nuevo
            ultimo.Siguiente = nuevoNodo;
            nuevoNodo.Anterior = ultimo;

            // Conectar el nuevo nodo con la cabeza
            nuevoNodo.Siguiente = Cabeza;
            Cabeza.Anterior = nuevoNodo;
        }

        // Obtiene el canal actual
        public NodosVideo? ObtenerCanalActual()
        {
            return actual;
        }

        // Avanza al siguiente canal
        public NodosVideo? ObtenerSiguienteCanal()
        {
            if (actual != null)
            {
                actual = actual.Siguiente;
            }

            return actual;
        }

        // Retrocede al canal anterior
        public NodosVideo? ObtenerAnteriorCanal()
        {
            if (actual != null)
            {
                actual = actual.Anterior;
            }

            return actual;
        }

        // Regresa al primer canal
        public void Reiniciar()
        {
            actual = Cabeza;
        }
    }
}
