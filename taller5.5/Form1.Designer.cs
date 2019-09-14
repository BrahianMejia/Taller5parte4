using System;

namespace taller5._5
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbltemporizador = new System.Windows.Forms.Label();
            this.tiempo = new System.Windows.Forms.Timer(this.components);
            this.btniniciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbltemporizador
            // 
            this.lbltemporizador.AutoSize = true;
            this.lbltemporizador.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltemporizador.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbltemporizador.Location = new System.Drawing.Point(88, 92);
            this.lbltemporizador.Name = "lbltemporizador";
            this.lbltemporizador.Size = new System.Drawing.Size(55, 39);
            this.lbltemporizador.TabIndex = 0;
            this.lbltemporizador.Text = "10";
            // 
            // tiempo
            // 
            this.tiempo.Interval = 1000;
            this.tiempo.Tick += new System.EventHandler(this.tiempo_Tick);
            // 
            // btniniciar
            // 
            this.btniniciar.Location = new System.Drawing.Point(65, 40);
            this.btniniciar.Name = "btniniciar";
            this.btniniciar.Size = new System.Drawing.Size(97, 37);
            this.btniniciar.TabIndex = 1;
            this.btniniciar.Text = "Iniciar";
            this.btniniciar.UseVisualStyleBackColor = true;
            this.btniniciar.Click += new System.EventHandler(this.Btniniciar_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 186);
            this.Controls.Add(this.btniniciar);
            this.Controls.Add(this.lbltemporizador);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        /*private void btniniciar_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }*/

        #endregion

        private System.Windows.Forms.Label lbltemporizador;
        private System.Windows.Forms.Timer tiempo;
        private System.Windows.Forms.Button btniniciar;
    }
}

