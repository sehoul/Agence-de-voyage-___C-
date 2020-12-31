namespace WindowsFormsApp1
{
    partial class Maps
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
            this.components = new System.ComponentModel.Container();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.taskLabel1 = new NanoByte.Common.Controls.TaskLabel();
            this.combo = new VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox();
            this.taskLabel2 = new NanoByte.Common.Controls.TaskLabel();
            this.visualButton1 = new VisualPlus.Toolkit.Controls.Interactivity.VisualButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 58);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(776, 384);
            this.webBrowser1.TabIndex = 0;
            // 
            // taskLabel1
            // 
            this.taskLabel1.AutoSize = true;
            this.taskLabel1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskLabel1.ForeColor = System.Drawing.Color.White;
            this.taskLabel1.Location = new System.Drawing.Point(725, 15);
            this.taskLabel1.Name = "taskLabel1";
            this.taskLabel1.Size = new System.Drawing.Size(63, 23);
            this.taskLabel1.TabIndex = 2;
            this.taskLabel1.Text = "Maps";
            // 
            // combo
            // 
            this.combo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(89)))), ((int)(((byte)(96)))));
            this.combo.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.combo.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(33)))), ((int)(((byte)(44)))));
            this.combo.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(182)))), ((int)(((byte)(188)))));
            this.combo.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.combo.Border.HoverVisible = true;
            this.combo.Border.Rounding = 5;
            this.combo.Border.Thickness = 2;
            this.combo.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.combo.Border.Visible = true;
            this.combo.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(182)))), ((int)(((byte)(188)))));
            this.combo.ButtonImage = null;
            this.combo.ButtonStyle = VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox.ButtonStyles.Arrow;
            this.combo.ButtonWidth = 30;
            this.combo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.combo.DropDownHeight = 100;
            this.combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo.DropDownWidth = 83;
            this.combo.ForeColor = System.Drawing.Color.White;
            this.combo.FormattingEnabled = true;
            this.combo.ImageList = null;
            this.combo.ImageVisible = false;
            this.combo.Index = 0;
            this.combo.IntegralHeight = false;
            this.combo.ItemHeight = 24;
            this.combo.ItemImageVisible = true;
            this.combo.Items.AddRange(new object[] {
            "Oujda",
            "Casablanca",
            "Rabat",
            "Fes",
            "Marrakech"});
            this.combo.Location = new System.Drawing.Point(192, 12);
            this.combo.MenuItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(182)))), ((int)(((byte)(188)))));
            this.combo.MenuItemNormal = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(14)))), ((int)(((byte)(17)))));
            this.combo.MenuTextColor = System.Drawing.Color.White;
            this.combo.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.combo.Name = "combo";
            this.combo.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(89)))), ((int)(((byte)(96)))));
            this.combo.Size = new System.Drawing.Size(188, 30);
            this.combo.State = VisualPlus.Enumerators.MouseStates.Normal;
            this.combo.TabIndex = 77;
            this.combo.TextAlignment = System.Drawing.StringAlignment.Center;
            this.combo.TextDisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(89)))), ((int)(((byte)(96)))));
            this.combo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.combo.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.combo.TextRendering = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.combo.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.combo.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.combo.TextStyle.Hover = System.Drawing.Color.Empty;
            this.combo.TextStyle.Pressed = System.Drawing.Color.Empty;
            this.combo.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.combo.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.combo.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.combo.Watermark.Active = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.combo.Watermark.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo.Watermark.Inactive = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.combo.Watermark.Text = "Watermark text";
            this.combo.Watermark.Visible = false;
            // 
            // taskLabel2
            // 
            this.taskLabel2.AutoSize = true;
            this.taskLabel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskLabel2.ForeColor = System.Drawing.Color.White;
            this.taskLabel2.Location = new System.Drawing.Point(138, 17);
            this.taskLabel2.Name = "taskLabel2";
            this.taskLabel2.Size = new System.Drawing.Size(48, 21);
            this.taskLabel2.TabIndex = 78;
            this.taskLabel2.Text = "Ville :";
            // 
            // visualButton1
            // 
            this.visualButton1.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.visualButton1.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.visualButton1.BackColorState.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.visualButton1.BackColorState.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.visualButton1.Border.Color = System.Drawing.Color.Transparent;
            this.visualButton1.Border.HoverColor = System.Drawing.Color.Transparent;
            this.visualButton1.Border.HoverVisible = true;
            this.visualButton1.Border.Rounding = 6;
            this.visualButton1.Border.Thickness = 1;
            this.visualButton1.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.visualButton1.Border.Visible = true;
            this.visualButton1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visualButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(182)))), ((int)(((byte)(188)))));
            this.visualButton1.Image = null;
            this.visualButton1.Location = new System.Drawing.Point(488, 12);
            this.visualButton1.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.visualButton1.Name = "visualButton1";
            this.visualButton1.Size = new System.Drawing.Size(92, 34);
            this.visualButton1.TabIndex = 79;
            this.visualButton1.Text = "search";
            this.visualButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.visualButton1.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.visualButton1.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(182)))), ((int)(((byte)(188)))));
            this.visualButton1.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(182)))), ((int)(((byte)(188)))));
            this.visualButton1.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(182)))), ((int)(((byte)(188)))));
            this.visualButton1.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.visualButton1.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.visualButton1.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.visualButton1.Click += new System.EventHandler(this.visualButton1_Click);
            this.visualButton1.MouseLeave += new System.EventHandler(this.visualButton1_MouseHover);
            this.visualButton1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.visualButton1_MouseMove);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(182)))), ((int)(((byte)(188)))));
            this.panel1.Location = new System.Drawing.Point(497, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 3);
            this.panel1.TabIndex = 81;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.magnifying_glass__2_;
            this.pictureBox1.Location = new System.Drawing.Point(570, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 80;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.circular_shape_silhouette;
            this.pictureBox2.Location = new System.Drawing.Point(9, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(13, 14);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 82;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Maps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(37)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(800, 454);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.visualButton1);
            this.Controls.Add(this.taskLabel2);
            this.Controls.Add(this.combo);
            this.Controls.Add(this.taskLabel1);
            this.Controls.Add(this.webBrowser1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Maps";
            this.Text = "Maps";
            this.Load += new System.EventHandler(this.Maps_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Maps_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private NanoByte.Common.Controls.TaskLabel taskLabel1;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualComboBox combo;
        private NanoByte.Common.Controls.TaskLabel taskLabel2;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualButton visualButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}