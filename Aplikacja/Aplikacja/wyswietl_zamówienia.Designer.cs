namespace Aplikacja
{
    partial class wyswietl_zamówienia
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
            this.wroc = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idzamówieniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datazłożeniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrproduktuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilośćtowaruDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wydajacyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sklepDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zamowieniaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aplikacja_databaseDataSet = new Aplikacja.Aplikacja_databaseDataSet();
            this.Pokaz = new System.Windows.Forms.Button();
            this.zamowieniaTableAdapter = new Aplikacja.Aplikacja_databaseDataSetTableAdapters.ZamowieniaTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamowieniaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aplikacja_databaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // wroc
            // 
            this.wroc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wroc.ForeColor = System.Drawing.SystemColors.Highlight;
            this.wroc.Location = new System.Drawing.Point(11, 246);
            this.wroc.Margin = new System.Windows.Forms.Padding(2);
            this.wroc.Name = "wroc";
            this.wroc.Size = new System.Drawing.Size(97, 46);
            this.wroc.TabIndex = 9;
            this.wroc.Text = "Wróć";
            this.wroc.UseVisualStyleBackColor = true;
            this.wroc.Click += new System.EventHandler(this.wroc_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idzamówieniaDataGridViewTextBoxColumn,
            this.datazłożeniaDataGridViewTextBoxColumn,
            this.nrproduktuDataGridViewTextBoxColumn,
            this.ilośćtowaruDataGridViewTextBoxColumn,
            this.wydajacyDataGridViewTextBoxColumn,
            this.sklepDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.zamowieniaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(11, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(544, 221);
            this.dataGridView1.TabIndex = 8;
            // 
            // idzamówieniaDataGridViewTextBoxColumn
            // 
            this.idzamówieniaDataGridViewTextBoxColumn.DataPropertyName = "Id_zamówienia";
            this.idzamówieniaDataGridViewTextBoxColumn.HeaderText = "Id_zamówienia";
            this.idzamówieniaDataGridViewTextBoxColumn.Name = "idzamówieniaDataGridViewTextBoxColumn";
            this.idzamówieniaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datazłożeniaDataGridViewTextBoxColumn
            // 
            this.datazłożeniaDataGridViewTextBoxColumn.DataPropertyName = "Data_złożenia";
            this.datazłożeniaDataGridViewTextBoxColumn.HeaderText = "Data_złożenia";
            this.datazłożeniaDataGridViewTextBoxColumn.Name = "datazłożeniaDataGridViewTextBoxColumn";
            this.datazłożeniaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nrproduktuDataGridViewTextBoxColumn
            // 
            this.nrproduktuDataGridViewTextBoxColumn.DataPropertyName = "Nr_produktu";
            this.nrproduktuDataGridViewTextBoxColumn.HeaderText = "Nr_produktu";
            this.nrproduktuDataGridViewTextBoxColumn.Name = "nrproduktuDataGridViewTextBoxColumn";
            this.nrproduktuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ilośćtowaruDataGridViewTextBoxColumn
            // 
            this.ilośćtowaruDataGridViewTextBoxColumn.DataPropertyName = "Ilość_towaru";
            this.ilośćtowaruDataGridViewTextBoxColumn.HeaderText = "Ilość_towaru";
            this.ilośćtowaruDataGridViewTextBoxColumn.Name = "ilośćtowaruDataGridViewTextBoxColumn";
            this.ilośćtowaruDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wydajacyDataGridViewTextBoxColumn
            // 
            this.wydajacyDataGridViewTextBoxColumn.DataPropertyName = "wydajacy";
            this.wydajacyDataGridViewTextBoxColumn.HeaderText = "wydajacy";
            this.wydajacyDataGridViewTextBoxColumn.Name = "wydajacyDataGridViewTextBoxColumn";
            this.wydajacyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sklepDataGridViewTextBoxColumn
            // 
            this.sklepDataGridViewTextBoxColumn.DataPropertyName = "Sklep";
            this.sklepDataGridViewTextBoxColumn.HeaderText = "Sklep";
            this.sklepDataGridViewTextBoxColumn.Name = "sklepDataGridViewTextBoxColumn";
            this.sklepDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zamowieniaBindingSource
            // 
            this.zamowieniaBindingSource.DataMember = "Zamowienia";
            this.zamowieniaBindingSource.DataSource = this.aplikacja_databaseDataSet;
            // 
            // aplikacja_databaseDataSet
            // 
            this.aplikacja_databaseDataSet.DataSetName = "Aplikacja_databaseDataSet";
            this.aplikacja_databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Pokaz
            // 
            this.Pokaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Pokaz.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Pokaz.Location = new System.Drawing.Point(424, 246);
            this.Pokaz.Name = "Pokaz";
            this.Pokaz.Size = new System.Drawing.Size(108, 46);
            this.Pokaz.TabIndex = 7;
            this.Pokaz.Text = "wyswietl";
            this.Pokaz.UseVisualStyleBackColor = true;
            this.Pokaz.Click += new System.EventHandler(this.Pokaz_Click);
            // 
            // zamowieniaTableAdapter
            // 
            this.zamowieniaTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button2.Location = new System.Drawing.Point(284, 246);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 46);
            this.button2.TabIndex = 11;
            this.button2.Text = "Usuń";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(157, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 46);
            this.button1.TabIndex = 10;
            this.button1.Text = "Edytuj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // wyswietl_zamówienia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(570, 329);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.wroc);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Pokaz);
            this.Name = "wyswietl_zamówienia";
            this.Text = "wyswietl_zamówienia";
            this.Load += new System.EventHandler(this.wyswietl_zamówienia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamowieniaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aplikacja_databaseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button wroc;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Pokaz;
        private Aplikacja_databaseDataSet aplikacja_databaseDataSet;
        private System.Windows.Forms.BindingSource zamowieniaBindingSource;
        private Aplikacja_databaseDataSetTableAdapters.ZamowieniaTableAdapter zamowieniaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idzamówieniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datazłożeniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrproduktuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilośćtowaruDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wydajacyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sklepDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}