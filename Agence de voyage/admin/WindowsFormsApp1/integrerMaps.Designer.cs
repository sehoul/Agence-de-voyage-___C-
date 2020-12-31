namespace WindowsFormsApp1
{
    partial class integrerMaps
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
            this.taskLabel1 = new NanoByte.Common.Controls.TaskLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.isButton1 = new WindowsFormsApp6.ISButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // taskLabel1
            // 
            this.taskLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.taskLabel1.BackColor = System.Drawing.Color.Transparent;
            this.taskLabel1.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskLabel1.ForeColor = System.Drawing.Color.White;
            this.taskLabel1.Location = new System.Drawing.Point(84, 114);
            this.taskLabel1.Name = "taskLabel1";
            this.taskLabel1.Size = new System.Drawing.Size(275, 208);
            this.taskLabel1.TabIndex = 0;
            this.taskLabel1.Text = "Pour voir toutes les localisations de nôtres agences dans le Maroc utiliser le ma" +
    "ps pour voir la localisation exacte et bon voyage";
            this.taskLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.magnifying_glass;
            this.pictureBox1.Location = new System.Drawing.Point(635, 243);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // isButton1
            // 
            this.isButton1.Angle = 248F;
            this.isButton1.BorderRadius = 60;
            this.isButton1.Color0 = System.Drawing.Color.Crimson;
            this.isButton1.Color1 = System.Drawing.Color.Maroon;
            this.isButton1.Contenue = "Search";
            this.isButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.isButton1.ForeColor = System.Drawing.Color.White;
            this.isButton1.Location = new System.Drawing.Point(671, 228);
            this.isButton1.Name = "isButton1";
            this.isButton1.Size = new System.Drawing.Size(62, 61);
            this.isButton1.TabIndex = 5;
            this.isButton1.Click += new System.EventHandler(this.isButton1_Click);
            this.isButton1.MouseHover += new System.EventHandler(this.isButton1_MouseHover);
            // 
            // integrerMaps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(853, 480);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.isButton1);
            this.Controls.Add(this.taskLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "integrerMaps";
            this.Text = "integrerMaps";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private NanoByte.Common.Controls.TaskLabel taskLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private WindowsFormsApp6.ISButton isButton1;
    }
}