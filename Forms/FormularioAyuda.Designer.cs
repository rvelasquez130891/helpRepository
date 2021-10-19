
namespace ProyectoProgramacion.Forms
{
    partial class FormularioAyuda
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
            this.lblTItulo = new System.Windows.Forms.Label();
            this.lblPaso1 = new System.Windows.Forms.Label();
            this.lblPaso2 = new System.Windows.Forms.Label();
            this.lblPaso3 = new System.Windows.Forms.Label();
            this.lblPaso4 = new System.Windows.Forms.Label();
            this.lblPaso5 = new System.Windows.Forms.Label();
            this.lblPaso6 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTItulo
            // 
            this.lblTItulo.AutoSize = true;
            this.lblTItulo.Location = new System.Drawing.Point(35, 44);
            this.lblTItulo.Name = "lblTItulo";
            this.lblTItulo.Size = new System.Drawing.Size(97, 20);
            this.lblTItulo.TabIndex = 0;
            this.lblTItulo.Text = "Instrucciones:";
            // 
            // lblPaso1
            // 
            this.lblPaso1.AutoSize = true;
            this.lblPaso1.Location = new System.Drawing.Point(128, 83);
            this.lblPaso1.Name = "lblPaso1";
            this.lblPaso1.Size = new System.Drawing.Size(202, 20);
            this.lblPaso1.TabIndex = 1;
            this.lblPaso1.Text = "1. Ingresar el titulo del juego.";
            // 
            // lblPaso2
            // 
            this.lblPaso2.AutoSize = true;
            this.lblPaso2.Location = new System.Drawing.Point(128, 103);
            this.lblPaso2.Name = "lblPaso2";
            this.lblPaso2.Size = new System.Drawing.Size(307, 20);
            this.lblPaso2.TabIndex = 2;
            this.lblPaso2.Text = "2. Seleccionar 10 imagenes con extesion .jpg.";
            // 
            // lblPaso3
            // 
            this.lblPaso3.AutoSize = true;
            this.lblPaso3.Location = new System.Drawing.Point(128, 123);
            this.lblPaso3.Name = "lblPaso3";
            this.lblPaso3.Size = new System.Drawing.Size(250, 20);
            this.lblPaso3.TabIndex = 3;
            this.lblPaso3.Text = "3. Seleccionar el boton CONTINUAR.";
            // 
            // lblPaso4
            // 
            this.lblPaso4.AutoSize = true;
            this.lblPaso4.Location = new System.Drawing.Point(128, 143);
            this.lblPaso4.Name = "lblPaso4";
            this.lblPaso4.Size = new System.Drawing.Size(341, 20);
            this.lblPaso4.TabIndex = 4;
            this.lblPaso4.Text = "4. Observar las imagenes y memorizar su posicion.";
            // 
            // lblPaso5
            // 
            this.lblPaso5.AutoSize = true;
            this.lblPaso5.Location = new System.Drawing.Point(128, 163);
            this.lblPaso5.Name = "lblPaso5";
            this.lblPaso5.Size = new System.Drawing.Size(295, 40);
            this.lblPaso5.TabIndex = 5;
            this.lblPaso5.Text = "5. Seleccionar las imagenes que conforman\r\n un par.";
            // 
            // lblPaso6
            // 
            this.lblPaso6.AutoSize = true;
            this.lblPaso6.Location = new System.Drawing.Point(128, 183);
            this.lblPaso6.Name = "lblPaso6";
            this.lblPaso6.Size = new System.Drawing.Size(558, 20);
            this.lblPaso6.TabIndex = 6;
            this.lblPaso6.Text = "6. Al ganar o perder seleccionar el boton JUGAR NUEVAMENTE para jugar otra vez.";
            // 
            // btnSalir
            // 
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Location = new System.Drawing.Point(754, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(34, 29);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "X";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormularioAyuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 277);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblPaso6);
            this.Controls.Add(this.lblPaso5);
            this.Controls.Add(this.lblPaso4);
            this.Controls.Add(this.lblPaso3);
            this.Controls.Add(this.lblPaso2);
            this.Controls.Add(this.lblPaso1);
            this.Controls.Add(this.lblTItulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormularioAyuda";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormularioAyuda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTItulo;
        private System.Windows.Forms.Label lblPaso1;
        private System.Windows.Forms.Label lblPaso2;
        private System.Windows.Forms.Label lblPaso3;
        private System.Windows.Forms.Label lblPaso4;
        private System.Windows.Forms.Label lblPaso5;
        private System.Windows.Forms.Label lblPaso6;
        private System.Windows.Forms.Button btnSalir;
    }
}