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
        public string _titulo = "";
        
        public FormularioJuego()
        {
            InitializeComponent();
        }

        private void FormularioJuego_Load(object sender, EventArgs e)
        {
            //Agregar el titulo ingresado en el formulario anterior. 2021-10-04
            this.lblTitulo.Text = this._titulo;
        }
    }
}
