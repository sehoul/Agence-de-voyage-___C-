namespace WindowsFormsApp1
{
    partial class Form5
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.matriculeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fonctionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.archivesempBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.istravelDataSet = new WindowsFormsApp1.istravelDataSet();
            this.archives_empTableAdapter = new WindowsFormsApp1.istravelDataSetTableAdapters.Archives_empTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villeADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villeDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.archivestrajetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.istravelDataSet1 = new WindowsFormsApp1.istravelDataSet1();
            this.archives_trajetTableAdapter = new WindowsFormsApp1.istravelDataSet1TableAdapters.Archives_trajetTableAdapter();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbrplacesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartegriseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proprietaireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.archivesVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.istravelDataSet2 = new WindowsFormsApp1.istravelDataSet2();
            this.archives_VTableAdapter = new WindowsFormsApp1.istravelDataSet2TableAdapters.Archives_VTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.isButton3 = new WindowsFormsApp6.ISButton();
            this.isButton2 = new WindowsFormsApp6.ISButton();
            this.isButton1 = new WindowsFormsApp6.ISButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.archivesempBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.istravelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.archivestrajetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.istravelDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.archivesVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.istravelDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.matriculeDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.prenomDataGridViewTextBoxColumn,
            this.dateNDataGridViewTextBoxColumn,
            this.fonctionDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.telDataGridViewTextBoxColumn,
            this.adresseDataGridViewTextBoxColumn,
            this.dateEDataGridViewTextBoxColumn,
            this.sexeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.archivesempBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 224);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1025, 276);
            this.dataGridView1.TabIndex = 30;
            // 
            // matriculeDataGridViewTextBoxColumn
            // 
            this.matriculeDataGridViewTextBoxColumn.DataPropertyName = "Matricule";
            this.matriculeDataGridViewTextBoxColumn.HeaderText = "Matricule";
            this.matriculeDataGridViewTextBoxColumn.Name = "matriculeDataGridViewTextBoxColumn";
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "Nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            // 
            // prenomDataGridViewTextBoxColumn
            // 
            this.prenomDataGridViewTextBoxColumn.DataPropertyName = "Prenom";
            this.prenomDataGridViewTextBoxColumn.HeaderText = "Prenom";
            this.prenomDataGridViewTextBoxColumn.Name = "prenomDataGridViewTextBoxColumn";
            // 
            // dateNDataGridViewTextBoxColumn
            // 
            this.dateNDataGridViewTextBoxColumn.DataPropertyName = "Date_N";
            this.dateNDataGridViewTextBoxColumn.HeaderText = "Date_N";
            this.dateNDataGridViewTextBoxColumn.Name = "dateNDataGridViewTextBoxColumn";
            // 
            // fonctionDataGridViewTextBoxColumn
            // 
            this.fonctionDataGridViewTextBoxColumn.DataPropertyName = "Fonction";
            this.fonctionDataGridViewTextBoxColumn.HeaderText = "Fonction";
            this.fonctionDataGridViewTextBoxColumn.Name = "fonctionDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // telDataGridViewTextBoxColumn
            // 
            this.telDataGridViewTextBoxColumn.DataPropertyName = "Tel";
            this.telDataGridViewTextBoxColumn.HeaderText = "Tel";
            this.telDataGridViewTextBoxColumn.Name = "telDataGridViewTextBoxColumn";
            // 
            // adresseDataGridViewTextBoxColumn
            // 
            this.adresseDataGridViewTextBoxColumn.DataPropertyName = "Adresse";
            this.adresseDataGridViewTextBoxColumn.HeaderText = "Adresse";
            this.adresseDataGridViewTextBoxColumn.Name = "adresseDataGridViewTextBoxColumn";
            // 
            // dateEDataGridViewTextBoxColumn
            // 
            this.dateEDataGridViewTextBoxColumn.DataPropertyName = "Date_E";
            this.dateEDataGridViewTextBoxColumn.HeaderText = "Date_E";
            this.dateEDataGridViewTextBoxColumn.Name = "dateEDataGridViewTextBoxColumn";
            // 
            // sexeDataGridViewTextBoxColumn
            // 
            this.sexeDataGridViewTextBoxColumn.DataPropertyName = "Sexe";
            this.sexeDataGridViewTextBoxColumn.HeaderText = "Sexe";
            this.sexeDataGridViewTextBoxColumn.Name = "sexeDataGridViewTextBoxColumn";
            // 
            // archivesempBindingSource
            // 
            this.archivesempBindingSource.DataMember = "Archives_emp";
            this.archivesempBindingSource.DataSource = this.istravelDataSet;
            // 
            // istravelDataSet
            // 
            this.istravelDataSet.DataSetName = "istravelDataSet";
            this.istravelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // archives_empTableAdapter
            // 
            this.archives_empTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.villeADataGridViewTextBoxColumn,
            this.villeDDataGridViewTextBoxColumn,
            this.kmDataGridViewTextBoxColumn,
            this.prixDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.archivestrajetBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(254, 224);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(544, 276);
            this.dataGridView2.TabIndex = 34;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // villeADataGridViewTextBoxColumn
            // 
            this.villeADataGridViewTextBoxColumn.DataPropertyName = "ville_A";
            this.villeADataGridViewTextBoxColumn.HeaderText = "ville_A";
            this.villeADataGridViewTextBoxColumn.Name = "villeADataGridViewTextBoxColumn";
            // 
            // villeDDataGridViewTextBoxColumn
            // 
            this.villeDDataGridViewTextBoxColumn.DataPropertyName = "ville_D";
            this.villeDDataGridViewTextBoxColumn.HeaderText = "ville_D";
            this.villeDDataGridViewTextBoxColumn.Name = "villeDDataGridViewTextBoxColumn";
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
            // archivestrajetBindingSource
            // 
            this.archivestrajetBindingSource.DataMember = "Archives_trajet";
            this.archivestrajetBindingSource.DataSource = this.istravelDataSet1;
            // 
            // istravelDataSet1
            // 
            this.istravelDataSet1.DataSetName = "istravelDataSet1";
            this.istravelDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // archives_trajetTableAdapter
            // 
            this.archives_trajetTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.categorieDataGridViewTextBoxColumn,
            this.nbrplacesDataGridViewTextBoxColumn,
            this.cartegriseDataGridViewTextBoxColumn,
            this.proprietaireDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.archivesVBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(252, 224);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(544, 276);
            this.dataGridView3.TabIndex = 35;
            this.dataGridView3.Visible = false;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
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
            // archivesVBindingSource
            // 
            this.archivesVBindingSource.DataMember = "Archives_V";
            this.archivesVBindingSource.DataSource = this.istravelDataSet2;
            // 
            // istravelDataSet2
            // 
            this.istravelDataSet2.DataSetName = "istravelDataSet2";
            this.istravelDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // archives_VTableAdapter
            // 
            this.archives_VTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.label1.Location = new System.Drawing.Point(458, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 33);
            this.label1.TabIndex = 36;
            this.label1.Text = "Archives";
            // 
            // isButton3
            // 
            this.isButton3.Angle = 67F;
            this.isButton3.BackColor = System.Drawing.Color.Transparent;
            this.isButton3.BorderRadius = 35;
            this.isButton3.Color0 = System.Drawing.Color.OrangeRed;
            this.isButton3.Color1 = System.Drawing.Color.Crimson;
            this.isButton3.Contenue = "Vehicules";
            this.isButton3.ForeColor = System.Drawing.Color.White;
            this.isButton3.Location = new System.Drawing.Point(634, 145);
            this.isButton3.Name = "isButton3";
            this.isButton3.Size = new System.Drawing.Size(114, 46);
            this.isButton3.TabIndex = 33;
            this.isButton3.Click += new System.EventHandler(this.isButton3_Click);
            // 
            // isButton2
            // 
            this.isButton2.Angle = 294F;
            this.isButton2.BackColor = System.Drawing.Color.Transparent;
            this.isButton2.BorderRadius = 35;
            this.isButton2.Color0 = System.Drawing.Color.Indigo;
            this.isButton2.Color1 = System.Drawing.Color.DeepPink;
            this.isButton2.Contenue = "Trajets";
            this.isButton2.ForeColor = System.Drawing.Color.White;
            this.isButton2.Location = new System.Drawing.Point(464, 145);
            this.isButton2.Name = "isButton2";
            this.isButton2.Size = new System.Drawing.Size(114, 46);
            this.isButton2.TabIndex = 32;
            this.isButton2.Click += new System.EventHandler(this.isButton2_Click);
            // 
            // isButton1
            // 
            this.isButton1.Angle = 167F;
            this.isButton1.BackColor = System.Drawing.Color.Transparent;
            this.isButton1.BorderRadius = 35;
            this.isButton1.Color0 = System.Drawing.Color.Yellow;
            this.isButton1.Color1 = System.Drawing.Color.Red;
            this.isButton1.Contenue = "Employees";
            this.isButton1.ForeColor = System.Drawing.Color.White;
            this.isButton1.Location = new System.Drawing.Point(311, 145);
            this.isButton1.Name = "isButton1";
            this.isButton1.Size = new System.Drawing.Size(114, 46);
            this.isButton1.TabIndex = 31;
            this.isButton1.Click += new System.EventHandler(this.isButton1_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(209)))), ((int)(((byte)(219)))));
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.asphalt_auto_automobile_226460;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1025, 580);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.isButton3);
            this.Controls.Add(this.isButton2);
            this.Controls.Add(this.isButton1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.archivesempBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.istravelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.archivestrajetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.istravelDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.archivesVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.istravelDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private istravelDataSet istravelDataSet;
        private System.Windows.Forms.BindingSource archivesempBindingSource;
        private istravelDataSetTableAdapters.Archives_empTableAdapter archives_empTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn matriculeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fonctionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexeDataGridViewTextBoxColumn;
        private WindowsFormsApp6.ISButton isButton1;
        private WindowsFormsApp6.ISButton isButton2;
        private WindowsFormsApp6.ISButton isButton3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private istravelDataSet1 istravelDataSet1;
        private System.Windows.Forms.BindingSource archivestrajetBindingSource;
        private istravelDataSet1TableAdapters.Archives_trajetTableAdapter archives_trajetTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView3;
        private istravelDataSet2 istravelDataSet2;
        private System.Windows.Forms.BindingSource archivesVBindingSource;
        private istravelDataSet2TableAdapters.Archives_VTableAdapter archives_VTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn categorieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbrplacesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cartegriseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proprietaireDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}