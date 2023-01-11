namespace TPAjedrez
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
            this.btnMoverTorre = new System.Windows.Forms.Button();
            this.btnMoverCaballo = new System.Windows.Forms.Button();
            this.btnMoverPeon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMoverTorre
            // 
            this.btnMoverTorre.Location = new System.Drawing.Point(515, 95);
            this.btnMoverTorre.Name = "btnMoverTorre";
            this.btnMoverTorre.Size = new System.Drawing.Size(156, 29);
            this.btnMoverTorre.TabIndex = 0;
            this.btnMoverTorre.Text = "Mover torre";
            this.btnMoverTorre.UseVisualStyleBackColor = true;
            this.btnMoverTorre.Click += new System.EventHandler(this.btnMoverTorre_Click);
            // 
            // btnMoverCaballo
            // 
            this.btnMoverCaballo.Location = new System.Drawing.Point(515, 151);
            this.btnMoverCaballo.Name = "btnMoverCaballo";
            this.btnMoverCaballo.Size = new System.Drawing.Size(156, 29);
            this.btnMoverCaballo.TabIndex = 1;
            this.btnMoverCaballo.Text = "Mover caballo";
            this.btnMoverCaballo.UseVisualStyleBackColor = true;
            this.btnMoverCaballo.Click += new System.EventHandler(this.btnMoverCaballo_Click);
            // 
            // btnMoverPeon
            // 
            this.btnMoverPeon.Location = new System.Drawing.Point(515, 202);
            this.btnMoverPeon.Name = "btnMoverPeon";
            this.btnMoverPeon.Size = new System.Drawing.Size(156, 29);
            this.btnMoverPeon.TabIndex = 2;
            this.btnMoverPeon.Text = "Mover peón";
            this.btnMoverPeon.UseVisualStyleBackColor = true;
            this.btnMoverPeon.Click += new System.EventHandler(this.btnMoverPeon_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMoverPeon);
            this.Controls.Add(this.btnMoverCaballo);
            this.Controls.Add(this.btnMoverTorre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnMoverTorre;
        private Button btnMoverCaballo;
        private Button btnMoverPeon;
    }
}