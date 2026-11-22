
using System;
using System.Windows.Forms;
using System.IO;
//Universidad Hispanoamericana
//Estructura de Datos, INFO-105.
//Proyecto Programado II
//Est. Wilton Benedict Castillo
//Est. Leandro Bonilla Lobo
//Est. Johan Araya Retana

namespace listas_doblemente_enlazadas_circular_video
{
    public partial class Form1 : Form
    {
        // Objeto que administrará nuestra lista doblemente enlazada circular
        private ListaDobleCircular galeriaCanales = new ListaDobleCircular();

        // Constructor del formulario
        public Form1()
        {
            InitializeComponent();

            // Ocultar los controles de Windows Media Player
            axWindowsMediaPlayer1.uiMode = "none";
            axWindowsMediaPlayer1.stretchToFit = true;

            // Crear nuestra lista y agregar los canales
            InicializarCanales();
        }

        // Método para crear la lista y agregar los videos

        private void InicializarCanales()
        {
            // Canal 1: No lo sé Rick
            galeriaCanales.AgregarCanal(
                "castillo en el cielo",
                "https://dn721600.ca.archive.org/0/items/the-cat-returns_202508/All_Movies/Castle%20in%20the%20Sky%20%281986%29.mp4");

            galeriaCanales.AgregarCanal(
                "Mister Ed",
                "https://dn720308.ca.archive.org/0/items/mister-ed-s-03/Mister%20Ed%20S03E03%20Wilbur%20and%20Ed%20in%20Showbiz.mp4");

            galeriaCanales.AgregarCanal(
                "Bonanza",
                "https://dn711103.ca.archive.org/0/items/Bonanza_pd/BonanzaS02e06.mp4");

            galeriaCanales.AgregarCanal(
                "El Carnval de las galletas",
                "https://dn720306.ca.archive.org/0/items/walt-disneys-silly-symphonies-the-complete-collection-1929-39/53%20-%20The%20Cookie%20Carnival%20%281935%29.mp4");

            // Reproducir el primer canal
            ReproducirCanal(galeriaCanales.ObtenerCanalActual());
        }


        // Método para reproducir el canal seleccionado
        private void ReproducirCanal(NodosVideo? canal)
        {
            if (canal != null)
            {
                // Mostrar el nombre del canal
                LBLCanalActual.Text = "Canal actual: " + canal.Nombre;

                // Reproducir el video
                axWindowsMediaPlayer1.URL = canal.UrlStream;
            }
            else
            {
                LBLCanalActual.Text = "No hay canales disponibles";

                axWindowsMediaPlayer1.URL = string.Empty;
            }
        }

        // Botón SIGUIENTE
        private void BTNsiguiente_Click(object sender, EventArgs e)
        {
            NodosVideo? siguienteCanal =
                galeriaCanales.ObtenerSiguienteCanal();

            ReproducirCanal(siguienteCanal);
        }

        // Botón ANTERIOR
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            NodosVideo? anteriorCanal =
                galeriaCanales.ObtenerAnteriorCanal();

            ReproducirCanal(anteriorCanal);
        }

        // Botón REINICIAR
        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            galeriaCanales.Reiniciar();

            ReproducirCanal(galeriaCanales.ObtenerCanalActual());
        }
    }
}
