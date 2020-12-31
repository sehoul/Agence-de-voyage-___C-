namespace WindowsFormsApp1
{
    partial class trajetuser
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
            this.taskLabel2 = new NanoByte.Common.Controls.TaskLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villeDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villeADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trajetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.istravelDataSet4 = new WindowsFormsApp1.istravelDataSet4();
            this.trajetTableAdapter = new WindowsFormsApp1.istravelDataSet4TableAdapters.TrajetTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trajetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.istravelDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // taskLabel2
            // 
            this.taskLabel2.AutoSize = true;
            this.taskLabel2.BackColor = System.Drawing.Color.Transparent;
            this.taskLabel2.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskLabel2.ForeColor = System.Drawing.Color.White;
            this.taskLabel2.Location = new System.Drawing.Point(434, 58);
            this.taskLabel2.Name = "taskLabel2";
            this.taskLabel2.Size = new System.Drawing.Size(125, 42);
            this.taskLabel2.TabIndex = 44;
            this.taskLabel2.Text = "Trajets";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.villeDDataGridViewTextBoxColumn,
            this.villeADataGridViewTextBoxColumn,
            this.kmDataGridViewTextBoxColumn,
            this.prixDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.trajetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(271, 158);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 404);
            this.dataGridView1.TabIndex = 45;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // villeDDataGridViewTextBoxColumn
            // 
            this.villeDDataGridViewTextBoxColumn.DataPropertyName = "ville_D";
            this.villeDDataGridViewTextBoxColumn.HeaderText = "ville_D";
            this.villeDDataGridViewTextBoxColumn.Name = "villeDDataGridViewTextBoxColumn";
            // 
            // villeADataGridViewTextBoxColumn
            // 
            this.villeADataGridViewTextBoxColumn.DataPropertyName = "ville_A";
            this.villeADataGridViewTextBoxColumn.HeaderText = "ville_A";
            this.villeADataGridViewTextBoxColumn.Name = "villeADataGridViewTextBoxColumn";
            // 
            // kmDataGridViewTextBoxColumn
            // 
            this.kmDataGridViewTextBoxColumn.DataPropertyName = "Km";
            this.kmDataGridViewTextBoxColumn.HeaderText = "Km";
            this.kmDataGridViewTextBoxColumn.Name = "kmDataGridViewTextBoxColumn";
            // 
            // prixDataGridViewTextBoxColumn
            // 
            this.prixDataGridViewTextBoxColumn.DataPropertyName = "prix";
            this.prixDataGridViewTextBoxColumn.HeaderText = "prix";
            this.prixDataGridViewTextBoxColumn.Name = "prixDataGridViewTextBoxColumn";
            // 
            // trajetBindingSource
            // 
            this.trajetBindingSource.DataMember = "Trajet";
            this.trajetBindingSource.DataSource = this.istravelDataSet4;
            // 
            // istravelDataSet4
            // 
            this.istravelDataSet4.DataSetName = "istravelDataSet4";
            this.istravelDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // trajetTableAdapter
            // 
            this.trajetTableAdapter.ClearBeforeFill = true;
            // 
            // trajetuser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.asphalt_countryside_empty_105234;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(928, 608);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.taskLabel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "trajetuser";
            this.Text = "trajetuser";
            this.Load += new System.EventHandler(this.trajetuser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trajetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.istravelDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private NanoByte.Common.Controls.TaskLabel taskLabel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private istravelDataSet4 istravelDataSet4;
        private System.Windows.Forms.BindingSource trajetBindingSource;
        private istravelDataSet4TableAdapters.TrajetTableAdapter trajetTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixDataGridViewTextBoxColumn;
    }
}