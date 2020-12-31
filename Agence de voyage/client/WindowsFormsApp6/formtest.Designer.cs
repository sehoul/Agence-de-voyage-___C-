namespace WindowsFormsApp6
{
    partial class formtest
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
            this.timerR = new System.Windows.Forms.Timer(this.components);
            this.timerB = new System.Windows.Forms.Timer(this.components);
            this.timerG = new System.Windows.Forms.Timer(this.components);
            this.jMaterialTextbox1 = new JMaterialTextbox.JMaterialTextbox();
            this.jMaterialTextbox2 = new JMaterialTextbox.JMaterialTextbox();
            this.jMaterialTextbox3 = new JMaterialTextbox.JMaterialTextbox();
            this.jMaterialTextbox4 = new JMaterialTextbox.JMaterialTextbox();
            this.jMaterialTextbox5 = new JMaterialTextbox.JMaterialTextbox();
            this.SuspendLayout();
            // 
            // timerR
            // 
            this.timerR.Interval = 1;
            this.timerR.Tick += new System.EventHandler(this.timerR_Tick);
            // 
            // timerB
            // 
            this.timerB.Interval = 1;
            this.timerB.Tick += new System.EventHandler(this.timerB_Tick);
            // 
            // timerG
            // 
            this.timerG.Interval = 1;
            this.timerG.Tick += new System.EventHandler(this.timerG_Tick);
            // 
            // jMaterialTextbox1
            // 
            this.jMaterialTextbox1.BackColor = System.Drawing.Color.Transparent;
            this.jMaterialTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.jMaterialTextbox1.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.jMaterialTextbox1.ForeColors = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(235)))), ((int)(((byte)(252)))));
            this.jMaterialTextbox1.HintText = null;
            this.jMaterialTextbox1.IsPassword = false;
            this.jMaterialTextbox1.LineBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(109)))), ((int)(((byte)(165)))));
            this.jMaterialTextbox1.LineThickness = 1;
            this.jMaterialTextbox1.Location = new System.Drawing.Point(24, 131);
            this.jMaterialTextbox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.jMaterialTextbox1.MaxLength = 32767;
            this.jMaterialTextbox1.Name = "jMaterialTextbox1";
            this.jMaterialTextbox1.OnFocusedColor = System.Drawing.Color.Black;
            this.jMaterialTextbox1.OnFocusedTextColor = System.Drawing.Color.Black;
            this.jMaterialTextbox1.ReadOnly = false;
            this.jMaterialTextbox1.Size = new System.Drawing.Size(306, 22);
            this.jMaterialTextbox1.TabIndex = 0;
            this.jMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.jMaterialTextbox1.TextName = "From";
            this.jMaterialTextbox1.Load += new System.EventHandler(this.jMaterialTextbox1_Load);
            // 
            // jMaterialTextbox2
            // 
            this.jMaterialTextbox2.BackColor = System.Drawing.Color.Transparent;
            this.jMaterialTextbox2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.jMaterialTextbox2.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.jMaterialTextbox2.ForeColors = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(127)))), ((int)(((byte)(177)))));
            this.jMaterialTextbox2.HintText = null;
            this.jMaterialTextbox2.IsPassword = false;
            this.jMaterialTextbox2.LineBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(109)))), ((int)(((byte)(165)))));
            this.jMaterialTextbox2.LineThickness = 1;
            this.jMaterialTextbox2.Location = new System.Drawing.Point(24, 179);
            this.jMaterialTextbox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.jMaterialTextbox2.MaxLength = 32767;
            this.jMaterialTextbox2.Name = "jMaterialTextbox2";
            this.jMaterialTextbox2.OnFocusedColor = System.Drawing.Color.Black;
            this.jMaterialTextbox2.OnFocusedTextColor = System.Drawing.Color.Black;
            this.jMaterialTextbox2.ReadOnly = false;
            this.jMaterialTextbox2.Size = new System.Drawing.Size(306, 22);
            this.jMaterialTextbox2.TabIndex = 1;
            this.jMaterialTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.jMaterialTextbox2.TextName = "To";
            this.jMaterialTextbox2.Load += new System.EventHandler(this.jMaterialTextbox2_Load_1);
            // 
            // jMaterialTextbox3
            // 
            this.jMaterialTextbox3.BackColor = System.Drawing.Color.Transparent;
            this.jMaterialTextbox3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.jMaterialTextbox3.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.jMaterialTextbox3.ForeColors = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(127)))), ((int)(((byte)(177)))));
            this.jMaterialTextbox3.HintText = null;
            this.jMaterialTextbox3.IsPassword = false;
            this.jMaterialTextbox3.LineBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(109)))), ((int)(((byte)(165)))));
            this.jMaterialTextbox3.LineThickness = 1;
            this.jMaterialTextbox3.Location = new System.Drawing.Point(24, 227);
            this.jMaterialTextbox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.jMaterialTextbox3.MaxLength = 32767;
            this.jMaterialTextbox3.Name = "jMaterialTextbox3";
            this.jMaterialTextbox3.OnFocusedColor = System.Drawing.Color.Black;
            this.jMaterialTextbox3.OnFocusedTextColor = System.Drawing.Color.Black;
            this.jMaterialTextbox3.ReadOnly = false;
            this.jMaterialTextbox3.Size = new System.Drawing.Size(306, 22);
            this.jMaterialTextbox3.TabIndex = 2;
            this.jMaterialTextbox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.jMaterialTextbox3.TextName = "From";
            this.jMaterialTextbox3.Load += new System.EventHandler(this.jMaterialTextbox3_Load_1);
            // 
            // jMaterialTextbox4
            // 
            this.jMaterialTextbox4.BackColor = System.Drawing.Color.Transparent;
            this.jMaterialTextbox4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.jMaterialTextbox4.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.jMaterialTextbox4.ForeColors = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(127)))), ((int)(((byte)(177)))));
            this.jMaterialTextbox4.HintText = null;
            this.jMaterialTextbox4.IsPassword = false;
            this.jMaterialTextbox4.LineBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(109)))), ((int)(((byte)(165)))));
            this.jMaterialTextbox4.LineThickness = 1;
            this.jMaterialTextbox4.Location = new System.Drawing.Point(24, 275);
            this.jMaterialTextbox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.jMaterialTextbox4.MaxLength = 32767;
            this.jMaterialTextbox4.Name = "jMaterialTextbox4";
            this.jMaterialTextbox4.OnFocusedColor = System.Drawing.Color.Black;
            this.jMaterialTextbox4.OnFocusedTextColor = System.Drawing.Color.Black;
            this.jMaterialTextbox4.ReadOnly = false;
            this.jMaterialTextbox4.Size = new System.Drawing.Size(306, 22);
            this.jMaterialTextbox4.TabIndex = 3;
            this.jMaterialTextbox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.jMaterialTextbox4.TextName = "From";
            this.jMaterialTextbox4.Load += new System.EventHandler(this.jMaterialTextbox4_Load_1);
            // 
            // jMaterialTextbox5
            // 
            this.jMaterialTextbox5.BackColor = System.Drawing.Color.Transparent;
            this.jMaterialTextbox5.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.jMaterialTextbox5.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.jMaterialTextbox5.ForeColors = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(127)))), ((int)(((byte)(177)))));
            this.jMaterialTextbox5.HintText = null;
            this.jMaterialTextbox5.IsPassword = false;
            this.jMaterialTextbox5.LineBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(109)))), ((int)(((byte)(165)))));
            this.jMaterialTextbox5.LineThickness = 1;
            this.jMaterialTextbox5.Location = new System.Drawing.Point(24, 323);
            this.jMaterialTextbox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.jMaterialTextbox5.MaxLength = 32767;
            this.jMaterialTextbox5.Name = "jMaterialTextbox5";
            this.jMaterialTextbox5.OnFocusedColor = System.Drawing.Color.Black;
            this.jMaterialTextbox5.OnFocusedTextColor = System.Drawing.Color.Black;
            this.jMaterialTextbox5.ReadOnly = false;
            this.jMaterialTextbox5.Size = new System.Drawing.Size(306, 22);
            this.jMaterialTextbox5.TabIndex = 4;
            this.jMaterialTextbox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.jMaterialTextbox5.TextName = "From";
            this.jMaterialTextbox5.Load += new System.EventHandler(this.jMaterialTextbox5_Load_1);
            // 
            // formtest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(80)))), ((int)(((byte)(137)))));
            this.ClientSize = new System.Drawing.Size(343, 450);
            this.Controls.Add(this.jMaterialTextbox5);
            this.Controls.Add(this.jMaterialTextbox4);
            this.Controls.Add(this.jMaterialTextbox3);
            this.Controls.Add(this.jMaterialTextbox2);
            this.Controls.Add(this.jMaterialTextbox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formtest";
            this.Text = "formtest";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerR;
        private System.Windows.Forms.Timer timerB;
        private System.Windows.Forms.Timer timerG;
        private JMaterialTextbox.JMaterialTextbox jMaterialTextbox1;
        private JMaterialTextbox.JMaterialTextbox jMaterialTextbox2;
        private JMaterialTextbox.JMaterialTextbox jMaterialTextbox3;
        private JMaterialTextbox.JMaterialTextbox jMaterialTextbox4;
        private JMaterialTextbox.JMaterialTextbox jMaterialTextbox5;
    }
}