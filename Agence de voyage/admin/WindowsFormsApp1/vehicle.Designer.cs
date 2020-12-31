namespace WindowsFormsApp1
{
    partial class vehicle
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
            this.istravelDataSet5 = new WindowsFormsApp1.istravelDataSet5();
            this.vVehiculeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_VehiculeTableAdapter = new WindowsFormsApp1.istravelDataSet5TableAdapters.V_VehiculeTableAdapter();
            this.istravelDataSet6 = new WindowsFormsApp1.istravelDataSet6();
            this.vehiculeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehiculeTableAdapter = new WindowsFormsApp1.istravelDataSet6TableAdapters.VehiculeTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbrplacesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartegriseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proprietaireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehiculeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.istravelDataSet7 = new WindowsFormsApp1.istravelDataSet7();
            this.vehiculeTableAdapter1 = new WindowsFormsApp1.istravelDataSet7TableAdapters.VehiculeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.istravelDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vVehiculeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.istravelDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.istravelDataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // taskLabel2
            // 
            this.taskLabel2.AutoSize = true;
            this.taskLabel2.BackColor = System.Drawing.Color.Transparent;
            this.taskLabel2.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskLabel2.ForeColor = System.Drawing.Color.White;
            this.taskLabel2.Location = new System.Drawing.Point(431, 53);
            this.taskLabel2.Name = "taskLabel2";
            this.taskLabel2.Size = new System.Drawing.Size(170, 42);
            this.taskLabel2.TabIndex = 49;
            this.taskLabel2.Text = "Vehicule";
            // 
            // istravelDataSet5
            // 
            this.istravelDataSet5.DataSetName = "istravelDataSet5";
            this.istravelDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vVehiculeBindingSource
            // 
            this.vVehiculeBindingSource.DataMember = "V_Vehicule";
            this.vVehiculeBindingSource.DataSource = this.istravelDataSet5;
            // 
            // v_VehiculeTableAdapter
            // 
            this.v_VehiculeTableAdapter.ClearBeforeFill = true;
            // 
            // istravelDataSet6
            // 
            this.istravelDataSet6.DataSetName = "istravelDataSet6";
            this.istravelDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vehiculeBindingSource
            // 
            this.vehiculeBindingSource.DataMember = "Vehicule";
            this.vehiculeBindingSource.DataSource = this.istravelDataSet6;
            // 
            // vehiculeTableAdapter
            // 
            this.vehiculeTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.categorieDataGridViewTextBoxColumn,
            this.nbrplacesDataGridViewTextBoxColumn,
            this.cartegriseDataGridViewTextBoxColumn,
            this.proprietaireDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vehiculeBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(265, 167);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(546, 385);
            this.dataGridView1.TabIndex = 50;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // categorieDataGridViewTextBoxColumn
            // 
            this.categorieDataGridViewTextBoxColumn.DataPropertyName = "Categorie";
            this.categorieDataGridViewTextBoxColumn.HeaderText = "Categorie";
            this.categorieDataGridViewTextBoxColumn.Name = "categorieDataGridViewTextBoxColumn";
            // 
            // nbrplacesDataGridViewTextBoxColumn
            // 
            this.nbrplacesDataGridViewTextBoxColumn.DataPropertyName = "Nbr_places";
            this.nbrplacesDataGridViewTextBoxColumn.HeaderText = "Nbr_places";
            this.nbrplacesDataGridViewTextBoxColumn.Name = "nbrplacesDataGridViewTextBoxColumn";
            // 
            // cartegriseDataGridViewTextBoxColumn
            // 
            this.cartegriseDataGridViewTextBoxColumn.DataPropertyName = "Carte_grise";
            this.cartegriseDataGridViewTextBoxColumn.HeaderText = "Carte_grise";
            this.cartegriseDataGridViewTextBoxColumn.Name = "cartegriseDataGridViewTextBoxColumn";
            // 
            // proprietaireDataGridViewTextBoxColumn
            // 
            this.proprietaireDataGridViewTextBoxColumn.DataPropertyName = "Proprietaire";
            this.proprietaireDataGridViewTextBoxColumn.HeaderText = "Proprietaire";
            this.proprietaireDataGridViewTextBoxColumn.Name = "proprietaireDataGridViewTextBoxColumn";
            // 
            // vehiculeBindingSource1
            // 
            this.vehiculeBindingSource1.DataMember = "Vehicule";
            this.vehiculeBindingSource1.DataSource = this.istravelDataSet7;
            // 
            // istravelDataSet7
            // 
            this.istravelDataSet7.DataSetName = "istravelDataSet7";
            this.istravelDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vehiculeTableAdapter1
            // 
            this.vehiculeTableAdapter1.ClearBeforeFill = true;
            // 
            // vehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._4k_wallpaper_adventure_beach_165505;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1015, 601);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.taskLabel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "vehicle";
            this.Text = "vehicle";
            this.Load += new System.EventHandler(this.vehicle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.istravelDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vVehiculeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.istravelDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.istravelDataSet7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NanoByte.Common.Controls.TaskLabel taskLabel2;
        private istravelDataSet5 istravelDataSet5;
        private System.Windows.Forms.BindingSource vVehiculeBindingSource;
        private istravelDataSet5TableAdapters.V_VehiculeTableAdapter v_VehiculeTableAdapter;
        private istravelDataSet6 istravelDataSet6;
        private System.Windows.Forms.BindingSource vehiculeBindingSource;
        private istravelDataSet6TableAdapters.VehiculeTableAdapter vehiculeTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private istravelDataSet7 istravelDataSet7;
        private System.Windows.Forms.BindingSource vehiculeBindingSource1;
        private istravelDataSet7TableAdapters.VehiculeTableAdapter vehiculeTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categorieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbrplacesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cartegriseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proprietaireDataGridViewTextBoxColumn;
    }
}