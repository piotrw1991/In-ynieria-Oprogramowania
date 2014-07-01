namespace Aplikacja
{
    partial class Dodaj_zamowienie
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sklep = new System.Windows.Forms.ComboBox();
            this.zamowieniaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aplikacjadatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aplikacja_databaseDataSet = new Aplikacja.Aplikacja_databaseDataSet();
            this.ilosc = new System.Windows.Forms.ComboBox();
            this.dodaj = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.data_zlozenia = new System.Windows.Forms.DateTimePicker();
            this.Towar = new System.Windows.Forms.ComboBox();
            this.produktyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKZamowieniaProduktyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produktyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.wydajacy = new System.Windows.Forms.ComboBox();
            this.pracownicyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zamowieniaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.aplikacjadatabaseDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pracownicyTableAdapter = new Aplikacja.Aplikacja_databaseDataSetTableAdapters.PracownicyTableAdapter();
            this.zamowieniaTableAdapter = new Aplikacja.Aplikacja_databaseDataSetTableAdapters.ZamowieniaTableAdapter();
            this.produktyTableAdapter = new Aplikacja.Aplikacja_databaseDataSetTableAdapters.ProduktyTableAdapter();
            this.produktyBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.zamowieniaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aplikacjadatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aplikacja_databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKZamowieniaProduktyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktyBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pracownicyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamowieniaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aplikacjadatabaseDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktyBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // wroc
            // 
            this.wroc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wroc.ForeColor = System.Drawing.SystemColors.Highlight;
            this.wroc.Location = new System.Drawing.Point(10, 266);
            this.wroc.Margin = new System.Windows.Forms.Padding(2);
            this.wroc.Name = "wroc";
            this.wroc.Size = new System.Drawing.Size(75, 32);
            this.wroc.TabIndex = 0;
            this.wroc.Text = "Wróć";
            this.wroc.UseVisualStyleBackColor = true;
            this.wroc.Click += new System.EventHandler(this.wroc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Location = new System.Drawing.Point(6, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sklep";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Towar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label3.Location = new System.Drawing.Point(9, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ilość";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label4.Location = new System.Drawing.Point(9, 153);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kto wydał";
            // 
            // sklep
            // 
            this.sklep.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.zamowieniaBindingSource, "Id_zamówienia", true));
            this.sklep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sklep.FormattingEnabled = true;
            this.sklep.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F"});
            this.sklep.Location = new System.Drawing.Point(9, 24);
            this.sklep.Margin = new System.Windows.Forms.Padding(2);
            this.sklep.Name = "sklep";
            this.sklep.Size = new System.Drawing.Size(185, 28);
            this.sklep.TabIndex = 7;
            // 
            // zamowieniaBindingSource
            // 
            this.zamowieniaBindingSource.DataMember = "Zamowienia";
            this.zamowieniaBindingSource.DataSource = this.aplikacjadatabaseDataSetBindingSource;
            // 
            // aplikacjadatabaseDataSetBindingSource
            // 
            this.aplikacjadatabaseDataSetBindingSource.DataSource = this.aplikacja_databaseDataSet;
            this.aplikacjadatabaseDataSetBindingSource.Position = 0;
            // 
            // aplikacja_databaseDataSet
            // 
            this.aplikacja_databaseDataSet.DataSetName = "Aplikacja_databaseDataSet";
            this.aplikacja_databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ilosc
            // 
            this.ilosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ilosc.FormattingEnabled = true;
            this.ilosc.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.ilosc.Location = new System.Drawing.Point(9, 123);
            this.ilosc.Margin = new System.Windows.Forms.Padding(2);
            this.ilosc.Name = "ilosc";
            this.ilosc.Size = new System.Drawing.Size(76, 28);
            this.ilosc.TabIndex = 10;
            // 
            // dodaj
            // 
            this.dodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dodaj.ForeColor = System.Drawing.SystemColors.Highlight;
            this.dodaj.Location = new System.Drawing.Point(200, 266);
            this.dodaj.Margin = new System.Windows.Forms.Padding(2);
            this.dodaj.Name = "dodaj";
            this.dodaj.Size = new System.Drawing.Size(75, 32);
            this.dodaj.TabIndex = 11;
            this.dodaj.Text = "Dodaj";
            this.dodaj.UseVisualStyleBackColor = true;
            this.dodaj.Click += new System.EventHandler(this.dodaj_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label5.Location = new System.Drawing.Point(9, 200);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Data złożenia";
            // 
            // data_zlozenia
            // 
            this.data_zlozenia.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.data_zlozenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.data_zlozenia.Location = new System.Drawing.Point(10, 219);
            this.data_zlozenia.Margin = new System.Windows.Forms.Padding(2);
            this.data_zlozenia.MaxDate = new System.DateTime(2014, 6, 14, 0, 0, 0, 0);
            this.data_zlozenia.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.data_zlozenia.Name = "data_zlozenia";
            this.data_zlozenia.Size = new System.Drawing.Size(184, 26);
            this.data_zlozenia.TabIndex = 13;
            this.data_zlozenia.Value = new System.DateTime(2014, 6, 14, 0, 0, 0, 0);
            // 
            // Towar
            // 
            this.Towar.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.zamowieniaBindingSource, "Nr_produktu", true));
            this.Towar.DataSource = this.produktyBindingSource;
            this.Towar.DisplayMember = "Nazwa_produktu";
            this.Towar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Towar.FormattingEnabled = true;
            this.Towar.Location = new System.Drawing.Point(12, 74);
            this.Towar.Name = "Towar";
            this.Towar.Size = new System.Drawing.Size(182, 28);
            this.Towar.TabIndex = 14;
            this.Towar.ValueMember = "Numer_seryjny";
            this.Towar.SelectedIndexChanged += new System.EventHandler(this.Towar_SelectedIndexChanged);
            // 
            // produktyBindingSource
            // 
            this.produktyBindingSource.DataMember = "Produkty";
            this.produktyBindingSource.DataSource = this.aplikacjadatabaseDataSetBindingSource;
            // 
            // fKZamowieniaProduktyBindingSource
            // 
            this.fKZamowieniaProduktyBindingSource.DataMember = "FK_Zamowienia_Produkty";
            this.fKZamowieniaProduktyBindingSource.DataSource = this.produktyBindingSource1;
            // 
            // produktyBindingSource1
            // 
            this.produktyBindingSource1.DataMember = "Produkty";
            this.produktyBindingSource1.DataSource = this.aplikacjadatabaseDataSetBindingSource;
            // 
            // wydajacy
            // 
            this.wydajacy.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.zamowieniaBindingSource, "wydajacy", true));
            this.wydajacy.DataSource = this.pracownicyBindingSource;
            this.wydajacy.DisplayMember = "Imie";
            this.wydajacy.FormattingEnabled = true;
            this.wydajacy.Location = new System.Drawing.Point(13, 174);
            this.wydajacy.Name = "wydajacy";
            this.wydajacy.Size = new System.Drawing.Size(139, 21);
            this.wydajacy.TabIndex = 15;
            this.wydajacy.ValueMember = "Pesel";
            // 
            // pracownicyBindingSource
            // 
            this.pracownicyBindingSource.DataMember = "Pracownicy";
            this.pracownicyBindingSource.DataSource = this.aplikacjadatabaseDataSetBindingSource;
            // 
            // zamowieniaBindingSource1
            // 
            this.zamowieniaBindingSource1.DataMember = "Zamowienia";
            this.zamowieniaBindingSource1.DataSource = this.aplikacjadatabaseDataSetBindingSource;
            // 
            // pracownicyTableAdapter
            // 
            this.pracownicyTableAdapter.ClearBeforeFill = true;
            // 
            // zamowieniaTableAdapter
            // 
            this.zamowieniaTableAdapter.ClearBeforeFill = true;
            // 
            // produktyTableAdapter
            // 
            this.produktyTableAdapter.ClearBeforeFill = true;
            // 
            // produktyBindingSource2
            // 
            this.produktyBindingSource2.DataMember = "Produkty";
            this.produktyBindingSource2.DataSource = this.aplikacjadatabaseDataSetBindingSource;
            // 
            // Dodaj_zamowienie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(286, 309);
            this.Controls.Add(this.wydajacy);
            this.Controls.Add(this.Towar);
            this.Controls.Add(this.data_zlozenia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dodaj);
            this.Controls.Add(this.ilosc);
            this.Controls.Add(this.sklep);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wroc);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Dodaj_zamowienie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj_zamowienie";
            this.Load += new System.EventHandler(this.Dodaj_zamowienie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zamowieniaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aplikacjadatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aplikacja_databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKZamowieniaProduktyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktyBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pracownicyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zamowieniaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aplikacjadatabaseDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktyBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button wroc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox sklep;
        private System.Windows.Forms.ComboBox ilosc;
        private System.Windows.Forms.Button dodaj;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker data_zlozenia;
        private System.Windows.Forms.ComboBox Towar;
        private System.Windows.Forms.ComboBox wydajacy;
        private System.Windows.Forms.BindingSource aplikacjadatabaseDataSet1BindingSource;
        private Aplikacja_databaseDataSet aplikacja_databaseDataSet;
        private System.Windows.Forms.BindingSource aplikacjadatabaseDataSetBindingSource;
        private System.Windows.Forms.BindingSource pracownicyBindingSource;
        private Aplikacja_databaseDataSetTableAdapters.PracownicyTableAdapter pracownicyTableAdapter;
        private System.Windows.Forms.BindingSource zamowieniaBindingSource;
        private Aplikacja_databaseDataSetTableAdapters.ZamowieniaTableAdapter zamowieniaTableAdapter;
        private System.Windows.Forms.BindingSource zamowieniaBindingSource1;
        private System.Windows.Forms.BindingSource produktyBindingSource;
        private Aplikacja_databaseDataSetTableAdapters.ProduktyTableAdapter produktyTableAdapter;
        private System.Windows.Forms.BindingSource produktyBindingSource1;
        private System.Windows.Forms.BindingSource produktyBindingSource2;
        private System.Windows.Forms.BindingSource fKZamowieniaProduktyBindingSource;
    }
}