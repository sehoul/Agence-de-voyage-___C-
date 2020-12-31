namespace WindowsFormsApp1
{
    partial class Formhome
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.jThinButton2 = new WindowsFormsApp6.ISButton();
            this.jThinButton1 = new WindowsFormsApp6.ISButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Fichier_31;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.jThinButton1);
            this.panel1.Controls.Add(this.jThinButton2);
            this.panel1.Location = new System.Drawing.Point(721, 444);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 65);
            this.panel1.TabIndex = 2;
            // 
            // jThinButton2
            // 
            this.jThinButton2.Angle = 347F;
            this.jThinButton2.BackColor = System.Drawing.Color.Transparent;
            this.jThinButton2.BorderRadius = 65;
            this.jThinButton2.Color0 = System.Drawing.Color.Aquamarine;
            this.jThinButton2.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(182)))), ((int)(((byte)(188)))));
            this.jThinButton2.Contenue = ">";
            this.jThinButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold);
            this.jThinButton2.ForeColor = System.Drawing.Color.White;
            this.jThinButton2.Location = new System.Drawing.Point(86, 0);
            this.jThinButton2.Name = "jThinButton2";
            this.jThinButton2.Size = new System.Drawing.Size(64, 65);
            this.jThinButton2.TabIndex = 3;
            this.jThinButton2.Click += new System.EventHandler(this.jThinButton2_Click);
            // 
            // jThinButton1
            // 
            this.jThinButton1.Angle = 16F;
            this.jThinButton1.BackColor = System.Drawing.Color.Transparent;
            this.jThinButton1.BorderRadius = 65;
            this.jThinButton1.Color0 = System.Drawing.Color.Aquamarine;
            this.jThinButton1.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(182)))), ((int)(((byte)(188)))));
            this.jThinButton1.Contenue = "<";
            this.jThinButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold);
            this.jThinButton1.ForeColor = System.Drawing.Color.White;
            this.jThinButton1.Location = new System.Drawing.Point(9, 0);
            this.jThinButton1.Name = "jThinButton1";
            this.jThinButton1.Size = new System.Drawing.Size(64, 65);
            this.jThinButton1.TabIndex = 4;
            this.jThinButton1.Click += new System.EventHandler(this.jThinButton1_Click);
            // 
            // Formhome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Fichier_18;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1018, 541);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Formhome";
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.Formhome_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private WindowsFormsApp6.ISButton jThinButton2;
        private WindowsFormsApp6.ISButton jThinButton1;
    }
}