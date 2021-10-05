
namespace ProyectoProgramacion.Forms
{
    partial class FormularioJuego
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gbxMarcadores = new System.Windows.Forms.GroupBox();
            this.lblNivel = new System.Windows.Forms.Label();
            this.lblPutos = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.btnJugarNuevamente = new System.Windows.Forms.Button();
            this.gbxMarcadores.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblTitulo.Location = new System.Drawing.Point(69, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(78, 26);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "label1";
            // 
            // gbxMarcadores
            // 
            this.gbxMarcadores.Controls.Add(this.lblTiempo);
            this.gbxMarcadores.Controls.Add(this.lblPutos);
            this.gbxMarcadores.Controls.Add(this.lblNivel);
            this.gbxMarcadores.Font = new System.Drawing.Font("Modern No. 20", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbxMarcadores.Location = new System.Drawing.Point(12, 67);
            this.gbxMarcadores.Name = "gbxMarcadores";
            this.gbxMarcadores.Size = new System.Drawing.Size(776, 81);
            this.gbxMarcadores.TabIndex = 1;
            this.gbxMarcadores.TabStop = false;
            this.gbxMarcadores.Text = "Marcador";
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Location = new System.Drawing.Point(6, 36);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(66, 21);
            this.lblNivel.TabIndex = 0;
            this.lblNivel.Text = "Nivel: 0";
            // 
            // lblPutos
            // 
            this.lblPutos.AutoSize = true;
            this.lblPutos.Location = new System.Drawing.Point(99, 36);
            this.lblPutos.Name = "lblPutos";
            this.lblPutos.Size = new System.Drawing.Size(77, 21);
            this.lblPutos.TabIndex = 1;
            this.lblPutos.Text = "Puntos: 0";
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Font = new System.Drawing.Font("Impact", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTiempo.Location = new System.Drawing.Point(683, 23);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(87, 45);
            this.lblTiempo.TabIndex = 3;
            this.lblTiempo.Text = "0:00";
            // 
            // btnJugarNuevamente
            // 
            this.btnJugarNuevamente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJugarNuevamente.Location = new System.Drawing.Point(628, 362);
            this.btnJugarNuevamente.Name = "btnJugarNuevamente";
            this.btnJugarNuevamente.Size = new System.Drawing.Size(154, 67);
            this.btnJugarNuevamente.TabIndex = 5;
            this.btnJugarNuevamente.Text = "Jugar Nuevamente";
            this.btnJugarNuevamente.UseVisualStyleBackColor = true;
            // 
            // FormularioJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnJugarNuevamente);
            this.Controls.Add(this.gbxMarcadores);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormularioJuego";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormularioJuego_Load);
            this.gbxMarcadores.ResumeLayout(false);
            this.gbxMarcadores.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gbxMarcadores;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Label lblPutos;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.Button btnJugarNuevamente;
    }
}