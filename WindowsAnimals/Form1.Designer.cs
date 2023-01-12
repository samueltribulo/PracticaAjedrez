namespace WindowsAnimals
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
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
            this.btnCrearLeon.Location = new System.Drawing.Point(324, 107);
            this.btnCrearLeon.Name = "btnCrearLeon";
            this.btnCrearLeon.Size = new System.Drawing.Size(106, 40);
            this.btnCrearLeon.TabIndex = 0;
            this.btnCrearLeon.Text = "Crear Leon";
            this.btnCrearLeon.UseVisualStyleBackColor = true;
            this.btnCrearLeon.Click += new System.EventHandler(this.btnCrearLeon_Click);
            // 
            // btnCrearLoro
            // 
            this.btnCrearLoro.Location = new System.Drawing.Point(324, 180);
            this.btnCrearLoro.Name = "btnCrearLoro";
            this.btnCrearLoro.Size = new System.Drawing.Size(106, 40);
            this.btnCrearLoro.TabIndex = 1;
            this.btnCrearLoro.Text = "Crear Loro";
            this.btnCrearLoro.UseVisualStyleBackColor = true;
            // 
            // btnCrearConejo
            // 
            this.btnCrearConejo.Location = new System.Drawing.Point(324, 251);
            this.btnCrearConejo.Name = "btnCrearConejo";
            this.btnCrearConejo.Size = new System.Drawing.Size(106, 40);
            this.btnCrearConejo.TabIndex = 2;
            this.btnCrearConejo.Text = "Crear Conejo";
            this.btnCrearConejo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
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

        private Button btnCrearLeon;
        private Button btnCrearLoro;
        private Button btnCrearConejo;
    }
}