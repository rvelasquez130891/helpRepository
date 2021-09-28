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

namespace ProyectoProgramacion.Forms
{
    public partial class FormularioInicial : Form
    {
        public FormularioInicial()
        {
            InitializeComponent();
        }

        //yo soy roberto

        /// <summary>
        /// Metodo de carga del formulario de configuración
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormularioInicial_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Evento click del botón Cargar Imagenes para agrar el openFileDialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCargarImg_Click(object sender, EventArgs e)
        {
            //Abrir form para cargar archivos que de tipo OpenFileDialog(un elemento de windowsform)
            ofdImagenes.ShowDialog();
        }

        /// <summary>
        /// Evento OK (una vez que se seleccionan los archivos) del openFileDialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ofdImagenes_FileOk(object sender, CancelEventArgs e)
        {
            //Validar que se seleccionaron 10 archivos, que son los necesarios para llevar a cabo el juego
            if (ofdImagenes.FileNames.Count() != 10)
            {
                MessageBox.Show("Por favor seleccione 10 archivos...");
                return;
            }

            //Recorrer todos los nombres de los archivos seleccionados para validar que sean imagenes
            foreach (string nombreArchivo in ofdImagenes.FileNames)
            {
                //Path pertenece a la libreria System.IO
                string extension = Path.GetExtension(nombreArchivo);

                //Validamos que la extensión de los archivos sea .JPG
                if (extension != ".jpg")
                {
                    MessageBox.Show("El archivo " + nombreArchivo + " es incorrecto, deberia ser extensión .JPG");
                    return;
                }
            }

            //Variable que contiene el numero para el nombre de la imagen
            int numero = 1;
            //Recorrer todos los archivos para guardarlos en el openFileDialog
            foreach (string nombreArchivo in ofdImagenes.FileNames)
            {
                //Declarar una variable de tipo PictureBox para poder guardar la imagen en el sistema
                PictureBox guardarImg = new PictureBox();
                //Asignamos la imagen del openFileDialog a la propiedad Image del PictureBox
                guardarImg.Image = Image.FromFile(nombreArchivo);
                //Guardamos la imagen en la ruta(Enviroment.CurrentDirectory) donde esta corriendo el programa + la carpeta y el nombre deseado.
                guardarImg.Image.Save(Environment.CurrentDirectory + "\\Imagenes\\Imagen" + numero.ToString() + ".jpg");
                numero++;
            }

            MessageBox.Show("Imagenes cargadas con éxito al sistema.");
        }
    }
}
