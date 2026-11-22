using ListasDoblementeEnlazadaImagenes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Universidad Hispanoamericana
//Estructura de Datos, INFO-105.
//Proyecto Programado II
//Est. Wilton Benedict Castillo
//Est. Leandro Bonilla Lobo
//Est. Johan Araya Retana
namespace ListasDoblementeEnlazadaImagenes
{
    
    public partial class Form1 : Form
    {
        private ListaDoblementeEnlazada galeriaImagenes;
        public Form1()
        {
            InitializeComponent();
            InicializarGaleria();
        }

        private void InicializarGaleria()
        {
            galeriaImagenes = new ListaDoblementeEnlazada();

            galeriaImagenes.AgregarImagen(Path.Combine(AppContext.BaseDirectory, "imagenes", "Arenal.png"));
            galeriaImagenes.AgregarImagen(Path.Combine(AppContext.BaseDirectory, "imagenes", "EnOtrosTerritorios.png"));
            galeriaImagenes.AgregarImagen(Path.Combine(AppContext.BaseDirectory, "imagenes", "FincaGigante.png"));
            galeriaImagenes.AgregarImagen(Path.Combine(AppContext.BaseDirectory, "imagenes", "LunaMia.png"));
            galeriaImagenes.AgregarImagen(Path.Combine(AppContext.BaseDirectory, "imagenes", "PrincipeyBotija.png"));
            // Mostrar la primera imagen al cargar el formulario
            ActualizarPictureBox(galeriaImagenes.ObtenerImagenActual());
        }

        private void ActualizarPictureBox(Image img)
        {
            if (img != null)
            {
                pictureBoxImagen.Image = img;
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            // Esto llama al método de la lista enlazada que retrocede el puntero interno
            Image anteriorImg = galeriaImagenes.ObtenerImagenAnterior();

            // Actualiza la UI
            ActualizarPictureBox(anteriorImg);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            // Esto llama al método de la lista enlazada que avanza el puntero interno
            Image siguienteImg = galeriaImagenes.ObtenerSiguienteImagen();

            // Actualiza la UI
            ActualizarPictureBox(siguienteImg);
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            // Esto llama al método de la lista enlazada que resetea el puntero 'actual' a 'Cabeza'
            galeriaImagenes.Reiniciar();

            // Actualiza la UI con la imagen de la Cabeza
            ActualizarPictureBox(galeriaImagenes.ObtenerImagenActual());
        }
    }
}
