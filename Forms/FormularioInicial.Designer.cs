
namespace ProyectoProgramacion.Forms
{
    partial class FormularioInicial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbxConfiguracion = new System.Windows.Forms.GroupBox();
            this.btnCargarImg = new System.Windows.Forms.Button();
            this.lblImagenes = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.ofdImagenes = new System.Windows.Forms.OpenFileDialog();
            this.gbxConfiguracion.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxConfiguracion
            // 
            this.gbxConfiguracion.Controls.Add(this.btnCargarImg);
            this.gbxConfiguracion.Controls.Add(this.lblImagenes);
            this.gbxConfiguracion.Controls.Add(this.txtTitulo);
            this.gbxConfiguracion.Controls.Add(this.lblTitulo);
            this.gbxConfiguracion.Location = new System.Drawing.Point(12, 12);
            this.gbxConfiguracion.Name = "gbxConfiguracion";
            this.gbxConfiguracion.Size = new System.Drawing.Size(813, 494);
            this.gbxConfiguracion.TabIndex = 0;
            this.gbxConfiguracion.TabStop = false;
            this.gbxConfiguracion.Text = "Configuración";
            // 
            // btnCargarImg
            // 
            this.btnCargarImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarImg.Location = new System.Drawing.Point(183, 143);
            this.btnCargarImg.Name = "btnCargarImg";
            this.btnCargarImg.Size = new System.Drawing.Size(94, 29);
            this.btnCargarImg.TabIndex = 3;
            this.btnCargarImg.Text = "Cargar...";
            this.btnCargarImg.UseVisualStyleBackColor = true;
            this.btnCargarImg.Click += new System.EventHandler(this.btnCargarImg_Click);
            // 
            // lblImagenes
            // 
            this.lblImagenes.AutoSize = true;
            this.lblImagenes.Location = new System.Drawing.Point(6, 152);
            this.lblImagenes.Name = "lblImagenes";
            this.lblImagenes.Size = new System.Drawing.Size(124, 20);
            this.lblImagenes.TabIndex = 2;
            this.lblImagenes.Text = "Cargar imagenes:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(183, 63);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(568, 27);
            this.txtTitulo.TabIndex = 1;
            this.txtTitulo.Text = "Ingrese un titulo....";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(6, 70);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(159, 20);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Titulo de la aplicación:";
            // 
            // ofdImagenes
            // 
            this.ofdImagenes.FileName = "ofdImagenes";
            this.ofdImagenes.Multiselect = true;
            this.ofdImagenes.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdImagenes_FileOk);
            // 
            // FormularioInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 518);
            this.Controls.Add(this.gbxConfiguracion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormularioInicial";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuracion Inicial";
            this.Load += new System.EventHandler(this.FormularioInicial_Load);
            this.gbxConfiguracion.ResumeLayout(false);
            this.gbxConfiguracion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxConfiguracion;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblImagenes;
        private System.Windows.Forms.OpenFileDialog ofdImagenes;
        private System.Windows.Forms.Button btnCargarImg;
    }
}