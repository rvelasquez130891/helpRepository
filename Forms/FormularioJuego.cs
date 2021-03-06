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

        //Definir una variable global para guardar el valor de la primer imagen seleccionada antes de validar par 
        PictureBox imgSeleccionada1 = null;

        //Definir una variable global para guardar el valor de la seunda imagen seleccionada antes de validar par 
        PictureBox imgSeleccionada2 = null;

        //Variable para saber cuantos pares de imagenes han sidos acertados correctamente
        int imgSeleccionadasCont = 0;


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

            //Iniciar temporizador que ocultara las imagenes.
            scoreTimer.Start();
            //Reiniciar contador de imagenes encontradas correctamente
            this.imgSeleccionadasCont = 0;
        }

        //Evento para hacer las acciones una vez que el temporizador se inicie.
        private void scoreTimer_Tick(object sender, EventArgs e)
        {
            //Denemos el temporizador
            scoreTimer.Stop();

            //Recorremos todos los PictureBox para ocultar las imagenes
            foreach (PictureBox picture in pnlImagenes.Controls)
            {
                picture.Image = Properties.Resources.Signo;
            }

            //Inciar el temporizador de la etiqueta del tiempo
            secondsTimer.Start();
        }

        //Evento para simular el cronometro de los segundos con el temporizador secondsTimer
        private void secondsTimer_Tick(object sender, EventArgs e)
        {
            //Leemos el tiempo actual
            int segundo = Convert.ToInt32(this.lblTiempo.Text);
            //Restamos un segundo al tiempo
            segundo--;
            //Asignamos el tiempo nuevo a la etiqueta de tiempo
            this.lblTiempo.Text = segundo.ToString();

            //Validar si el temporizador ya llego a 0
            if (segundo == 0)
            {
                this.secondsTimer.Stop();
                MessageBox.Show("Has perdido, tu puntaje alcanzado fue: " + this.lblPuntos.Text + " pts","HAS PERDIDO");
            }
        }

        //Metodo que recibe el pictureBox para validar si al seleccionar 2 son par y corresponden a la misma imagen
        private void validarParImagenes(PictureBox picture1)
        {
            //If imgSeleccionada1 es null es por que estoy dando click a una primer imagen y la debemos guardar en imgSeleccionada1
            if (this.imgSeleccionada1 == null)
            {
                this.imgSeleccionada1 = picture1;
            }
            //Si imgSeleccionada1 ya tiene valor es por que estoy dando click a la segunda imagen, por lo tanto se debe asignar imgSeleccionada2
            else if (this.imgSeleccionada1 != null && this.imgSeleccionada2 == null)
            {
                this.imgSeleccionada2 = picture1;
            }

            //VALIDAR QUE YA SELECCIONE 2 IMAGENES
            if (this.imgSeleccionada1 != null && this.imgSeleccionada2 != null)
            {
                //VALIDACION FINAL, PARA SABER SI AMBAS IMAGENES A LAS QUE SE LE DIO CLICK SON LA MISMA
                if (this.imgSeleccionada1.Tag == this.imgSeleccionada2.Tag)
                {
                    //PONER NULL LAS VARIABLES DONDE SE GUARDAN LAS IMAGENES SELECCIONADAS POR QUE YA ENCONTRAMOS UN PAR
                    this.imgSeleccionada1 = null;
                    this.imgSeleccionada2 = null;
                    //AUMENTAR CONTADOR QUE LLEVA LA CANTIDAD DE PARES CORRECTOS ENCONTRADOS
                    imgSeleccionadasCont++;
                    //SUMAR A LA ETIQUETA PUNTOS LOS PUNTOS POR HABER ENCONTRADO UN PAR CORRECTO
                    this.lblPuntos.Text = (Convert.ToInt32(this.lblPuntos.Text) + 10).ToString();
                    
                }
                else
                    VoltearTimer.Start();
            }

            if (imgSeleccionadasCont == 10)
            {
                this.secondsTimer.Stop();
                MessageBox.Show("F E L I C I D A D E S", "GANAD@R!!!"); 
            }
        }

        #region ::Evento click de todos los pictureBox

        private void pbxImg1_Click(object sender, EventArgs e)
        {
            this.pbxImg1.Image = Image.FromFile(Environment.CurrentDirectory + "\\Imagenes\\Imagen1.jpg");
            validarParImagenes(this.pbxImg1);
        }

        private void pbxImg2_Click(object sender, EventArgs e)
        {
            this.pbxImg2.Image = Image.FromFile(Environment.CurrentDirectory + "\\Imagenes\\Imagen2.jpg");
            validarParImagenes(this.pbxImg2);
        }

        private void pbxImg3_Click(object sender, EventArgs e)
        {
            this.pbxImg3.Image = Image.FromFile(Environment.CurrentDirectory + "\\Imagenes\\Imagen3.jpg");
            validarParImagenes(this.pbxImg3);
        }

        private void pbxImg4_Click(object sender, EventArgs e)
        {
            this.pbxImg4.Image = Image.FromFile(Environment.CurrentDirectory + "\\Imagenes\\Imagen4.jpg");
            validarParImagenes(this.pbxImg4);
        }

        private void pbxImg5_Click(object sender, EventArgs e)
        {
            this.pbxImg5.Image = Image.FromFile(Environment.CurrentDirectory + "\\Imagenes\\Imagen5.jpg");
            validarParImagenes(this.pbxImg5);
        }

        private void pbxImg6_Click(object sender, EventArgs e)
        {
            this.pbxImg6.Image = Image.FromFile(Environment.CurrentDirectory + "\\Imagenes\\Imagen6.jpg");
            validarParImagenes(this.pbxImg6);
        }

        private void pbxImg7_Click(object sender, EventArgs e)
        {
            this.pbxImg7.Image = Image.FromFile(Environment.CurrentDirectory + "\\Imagenes\\Imagen7.jpg");
            validarParImagenes(this.pbxImg7);
        }

        private void pbxImg8_Click(object sender, EventArgs e)
        {
            this.pbxImg8.Image = Image.FromFile(Environment.CurrentDirectory + "\\Imagenes\\Imagen8.jpg");
            validarParImagenes(this.pbxImg8);
        }

        private void pbxImg9_Click(object sender, EventArgs e)
        {
            this.pbxImg9.Image = Image.FromFile(Environment.CurrentDirectory + "\\Imagenes\\Imagen9.jpg");
            validarParImagenes(this.pbxImg9);
        }

        private void pbxImg10_Click(object sender, EventArgs e)
        {
            this.pbxImg10.Image = Image.FromFile(Environment.CurrentDirectory + "\\Imagenes\\Imagen10.jpg");
            validarParImagenes(this.pbxImg10);
        }

        private void pbxImg11_Click(object sender, EventArgs e)
        {
            this.pbxImg11.Image = Image.FromFile(Environment.CurrentDirectory + "\\Imagenes\\Imagen1.jpg");
            validarParImagenes(this.pbxImg11);
        }

        private void pbxImg12_Click(object sender, EventArgs e)
        {
            this.pbxImg12.Image = Image.FromFile(Environment.CurrentDirectory + "\\Imagenes\\Imagen2.jpg");
            validarParImagenes(this.pbxImg12);
        }

        private void pbxImg13_Click(object sender, EventArgs e)
        {
            this.pbxImg13.Image = Image.FromFile(Environment.CurrentDirectory + "\\Imagenes\\Imagen3.jpg");
            validarParImagenes(this.pbxImg13);
        }

        private void pbxImg14_Click(object sender, EventArgs e)
        {
            this.pbxImg14.Image = Image.FromFile(Environment.CurrentDirectory + "\\Imagenes\\Imagen4.jpg");
            validarParImagenes(this.pbxImg14);
        }

        private void pbxImg15_Click(object sender, EventArgs e)
        {
            this.pbxImg15.Image = Image.FromFile(Environment.CurrentDirectory + "\\Imagenes\\Imagen5.jpg");
            validarParImagenes(this.pbxImg15);
        }

        private void pbxImg16_Click(object sender, EventArgs e)
        {
            this.pbxImg16.Image = Image.FromFile(Environment.CurrentDirectory + "\\Imagenes\\Imagen6.jpg");
            validarParImagenes(this.pbxImg16);
        }

        private void pbxImg17_Click(object sender, EventArgs e)
        {
            this.pbxImg17.Image = Image.FromFile(Environment.CurrentDirectory + "\\Imagenes\\Imagen7.jpg");
            validarParImagenes(this.pbxImg17);
        }

        private void pbxImg18_Click(object sender, EventArgs e)
        {
            this.pbxImg18.Image = Image.FromFile(Environment.CurrentDirectory + "\\Imagenes\\Imagen8.jpg");
            validarParImagenes(this.pbxImg18);
        }

        private void pbxImg19_Click(object sender, EventArgs e)
        {
            this.pbxImg19.Image = Image.FromFile(Environment.CurrentDirectory + "\\Imagenes\\Imagen9.jpg");
            validarParImagenes(this.pbxImg19);
        }

        private void pbxImg20_Click(object sender, EventArgs e)
        {
            this.pbxImg20.Image = Image.FromFile(Environment.CurrentDirectory + "\\Imagenes\\Imagen10.jpg");
            validarParImagenes(this.pbxImg20);
        }


        #endregion

        //Temporizador para voltear las imagenes despues de 3 segundos cuando las 2 imagenes seleccionadas no sean el par
        private void VoltearTimer_Tick(object sender, EventArgs e)
        {
            //DETENEMOS EL SERVICIO POR QUE SOLO ES NECESARIO SE EJECUTE UNA VEZ
            VoltearTimer.Stop();
            //ASIGNAR A LAS VARIABLES DONDE SE GUARDAN LAS IMAGENES SELECCIONADAS LA IMAGEN POR DEFECTO DEL SIGNO DE INTERROGACION
            this.imgSeleccionada1.Image = Properties.Resources.Signo;
            this.imgSeleccionada2.Image = Properties.Resources.Signo;
            //ASIGNAR NULL A LAS VARIABLES DONDE SE GUARDAN LAS IMAGENES SELECCIONADAS PARA INDICAR QUE SE A SELECCIONAR IMAGENES NUEVAMENTES
            this.imgSeleccionada1 = null;
            this.imgSeleccionada2 = null;
        }

        //Boton para riniciar el juego
        private void btnJugarNuevamente_Click(object sender, EventArgs e)
        {
            //Llamamos el metodo de inicio del formulario para iniciar todo desde 0
            FormularioJuego_Load(sender, e);
            //Reiniciamos el teporizador de los segundos y la etiqueta del tiempo
            this.lblTiempo.Text = "60";
            //Reiniciar el valor de los puntos
            this.lblPuntos.Text = "0";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
