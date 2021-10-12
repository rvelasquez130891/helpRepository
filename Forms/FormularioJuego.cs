using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoProgramacion.Forms
{
    public partial class FormularioJuego : Form
    {
        //Variable para recibir el titulo del juego ingresado en el formulario inicial.
        public string _titulo = "";

        //Variable para generar numeros random en los locations de los picturebox
        private Random location = new Random();

        //Lista de locations de tipo point
        List<Point> points = new List<Point>();

        
        public FormularioJuego()
        {
            InitializeComponent();
        }

        private void FormularioJuego_Load(object sender, EventArgs e)
        {
            //Agregar el titulo ingresado en el formulario anterior. 2021-10-04
            this.lblTitulo.Text = this._titulo;

            //Recorrer pictureboxs que estan en el panel para obtener su location
            foreach (PictureBox picture in pnlImagenes.Controls)
            {
                //agregar cada location a la lista de puntos
                points.Add(picture.Location);
            }

            //Recorrremos los pictureboxs para moverlos de posicion asignando un nuevo location
            foreach (PictureBox picture in pnlImagenes.Controls)
            {
                //Generar un numero randon entre 1 y la cantidad de imagenes (actualmente 20)
                int next = location.Next(points.Count);
                //Tomar la posicion random generada de la lista de todas las locations
                Point newPoint = points[next];
                //Asignar la location random al picturbox que estamos recorriendo
                picture.Location = newPoint;
                //Removemos la location que acabos de asignar por que dicha location ya esta ocupada y no podemos poner otra imagen ahi.
                points.Remove(newPoint);
            }

            //Llenamos todos los pictureboxs con las imagenes solicitadas, cada imagen va 2 veces del picturebox 1 al 10 y luego repetiomos las 
            //imagenes del picturebox 11 al 20
            this.pbxImg1.Image = Image.FromFile(Environment.CurrentDirectory + "\\Imagenes\\Imagen1.jpg");
            this.pbxImg2.Image = Image.FromFile(Environment.CurrentDirectory + "\\Imagenes\\Imagen2.jpg");
            this.pbxImg3.Image = Image.FromFile(Environment.CurrentDirectory + "\\Imagenes\\Imagen3.jpg");
            this.pbxImg4.Image = Image.FromFile(Environment.CurrentDirectory + "\\Imagenes\\Imagen4.jpg");
            this.pbxImg5.Image = Image.FromFile(Environment.CurrentDirectory + "\\Imagenes\\Imagen5.jpg");
            this.pbxImg6.Image = Image.FromFile(Environment.CurrentDirectory + "\\Imagenes\\Imagen6.jpg");
            this.pbxImg7.Image = Image.FromFile(Environment.CurrentDirectory + "\\Imagenes\\Imagen7.jpg");
            this.pbxImg8.Image = Image.FromFile(Environment.CurrentDirectory + "\\Imagenes\\Imagen8.jpg");
            this.pbxImg9.Image = Image.FromFile(Environment.CurrentDirectory + "\\Imagenes\\Imagen9.jpg");
            this.pbxImg10.Image = Image.FromFile(Environment.CurrentDirectory + "\\Imagenes\\Imagen10.jpg");
            this.pbxImg11.Image = Image.FromFile(Environment.CurrentDirectory + "\\Imagenes\\Imagen1.jpg");
            this.pbxImg12.Image = Image.FromFile(Environment.CurrentDirectory + "\\Imagenes\\Imagen2.jpg");
            this.pbxImg13.Image = Image.FromFile(Environment.CurrentDirectory + "\\Imagenes\\Imagen3.jpg");
            this.pbxImg14.Image = Image.FromFile(Environment.CurrentDirectory + "\\Imagenes\\Imagen4.jpg");
            this.pbxImg15.Image = Image.FromFile(Environment.CurrentDirectory + "\\Imagenes\\Imagen5.jpg");
            this.pbxImg16.Image = Image.FromFile(Environment.CurrentDirectory + "\\Imagenes\\Imagen6.jpg");
            this.pbxImg17.Image = Image.FromFile(Environment.CurrentDirectory + "\\Imagenes\\Imagen7.jpg");
            this.pbxImg18.Image = Image.FromFile(Environment.CurrentDirectory + "\\Imagenes\\Imagen8.jpg");
            this.pbxImg19.Image = Image.FromFile(Environment.CurrentDirectory + "\\Imagenes\\Imagen9.jpg");
            this.pbxImg20.Image = Image.FromFile(Environment.CurrentDirectory + "\\Imagenes\\Imagen10.jpg");
        }
    }
}
