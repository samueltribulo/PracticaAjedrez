namespace TP_Animales
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
            this.btnCrearLeon = new System.Windows.Forms.Button();
            this.btnCrearLoro = new System.Windows.Forms.Button();
            this.btnCrearConejo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrearLeon
            // 
            this.btnCrearLeon.Location = new System.Drawing.Point(333, 92);
            this.btnCrearLeon.Name = "btnCrearLeon";
            this.btnCrearLeon.Size = new System.Drawing.Size(112, 42);
            this.btnCrearLeon.TabIndex = 0;
            this.btnCrearLeon.Text = "Crear Leon";
            this.btnCrearLeon.UseVisualStyleBackColor = true;
            this.btnCrearLeon.Click += new System.EventHandler(this.btnCrearLeon_Click);
            // 
            // btnCrearLoro
            // 
            this.btnCrearLoro.Location = new System.Drawing.Point(333, 178);
            this.btnCrearLoro.Name = "btnCrearLoro";
            this.btnCrearLoro.Size = new System.Drawing.Size(112, 42);
            this.btnCrearLoro.TabIndex = 1;
            this.btnCrearLoro.Text = "Crear Loro";
            this.btnCrearLoro.UseVisualStyleBackColor = true;
            // 
            // btnCrearConejo
            // 
            this.btnCrearConejo.Location = new System.Drawing.Point(333, 263);
            this.btnCrearConejo.Name = "btnCrearConejo";
            this.btnCrearConejo.Size = new System.Drawing.Size(112, 42);
            this.btnCrearConejo.TabIndex = 2;
            this.btnCrearConejo.Text = "Crear Conejo";
            this.btnCrearConejo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCrearConejo);
            this.Controls.Add(this.btnCrearLoro);
            this.Controls.Add(this.btnCrearLeon);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearLeon;
        private System.Windows.Forms.Button btnCrearLoro;
        private System.Windows.Forms.Button btnCrearConejo;
    }
}

