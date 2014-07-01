namespace Aplikacja
{
    partial class Rejestracja
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
            this.label1 = new System.Windows.Forms.Label();
            this.Imie = new System.Windows.Forms.TextBox();
            this.Nazwisko = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Pesel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Dzial = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Haslo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Typ_konta = new System.Windows.Forms.ComboBox();
            this.usersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.aplikacja_databaseDataSet = new Aplikacja.Aplikacja_databaseDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.usersTableAdapter = new Aplikacja.Aplikacja_databaseDataSetTableAdapters.UsersTableAdapter();
            this.usersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.data = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aplikacja_databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Location = new System.Drawing.Point(25, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Imię";
            // 
            // Imie
            // 
            this.Imie.Location = new System.Drawing.Point(108, 17);
            this.Imie.Name = "Imie";
            this.Imie.Size = new System.Drawing.Size(123, 20);
            this.Imie.TabIndex = 1;
            // 
            // Nazwisko
            // 
            this.Nazwisko.Location = new System.Drawing.Point(108, 60);
            this.Nazwisko.Name = "Nazwisko";
            this.Nazwisko.Size = new System.Drawing.Size(123, 20);
            this.Nazwisko.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Location = new System.Drawing.Point(25, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nazwisko";
            // 
            // Pesel
            // 
            this.Pesel.Location = new System.Drawing.Point(108, 108);
            this.Pesel.Name = "Pesel";
            this.Pesel.Size = new System.Drawing.Size(123, 20);
            this.Pesel.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label3.Location = new System.Drawing.Point(25, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pesel";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label4.Location = new System.Drawing.Point(12, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data urodzenia";
            // 
            // Dzial
            // 
            this.Dzial.Location = new System.Drawing.Point(108, 195);
            this.Dzial.Name = "Dzial";
            this.Dzial.Size = new System.Drawing.Size(123, 20);
            this.Dzial.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label5.Location = new System.Drawing.Point(25, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Dział";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(12, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Cofnij";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button2.Location = new System.Drawing.Point(185, 360);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Potwierdź";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(108, 232);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(123, 20);
            this.Login.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label6.Location = new System.Drawing.Point(25, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Login";
            // 
            // Haslo
            // 
            this.Haslo.Location = new System.Drawing.Point(108, 270);
            this.Haslo.Name = "Haslo";
            this.Haslo.PasswordChar = '*';
            this.Haslo.Size = new System.Drawing.Size(123, 20);
            this.Haslo.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label7.Location = new System.Drawing.Point(25, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Hasło";
            // 
            // Typ_konta
            // 
            this.Typ_konta.AutoCompleteCustomSource.AddRange(new string[] {
            "Admnistrator",
            "Użytkownik"});
            this.Typ_konta.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.usersBindingSource2, "Typ_konta", true));
            this.Typ_konta.FormattingEnabled = true;
            this.Typ_konta.Items.AddRange(new object[] {
            "Administrator",
            "Użytkownik"});
            this.Typ_konta.Location = new System.Drawing.Point(108, 306);
            this.Typ_konta.Name = "Typ_konta";
            this.Typ_konta.Size = new System.Drawing.Size(123, 21);
            this.Typ_konta.TabIndex = 16;
            // 
            // usersBindingSource2
            // 
            this.usersBindingSource2.DataMember = "Users";
            this.usersBindingSource2.DataSource = this.aplikacja_databaseDataSet;
            // 
            // aplikacja_databaseDataSet
            // 
            this.aplikacja_databaseDataSet.DataSetName = "Aplikacja_databaseDataSet";
            this.aplikacja_databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.aplikacja_databaseDataSet;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label8.Location = new System.Drawing.Point(28, 313);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Typ_konta";
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // usersBindingSource1
            // 
            this.usersBindingSource1.DataMember = "Users";
            this.usersBindingSource1.DataSource = this.aplikacja_databaseDataSet;
            // 
            // data
            // 
            this.data.CustomFormat = "00-00-0000";
            this.data.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.data.Location = new System.Drawing.Point(109, 151);
            this.data.Margin = new System.Windows.Forms.Padding(2);
            this.data.MinDate = new System.DateTime(1959, 1, 1, 0, 0, 0, 0);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(122, 20);
            this.data.TabIndex = 18;
            this.data.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // Rejestracja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(284, 395);
            this.Controls.Add(this.data);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Typ_konta);
            this.Controls.Add(this.Haslo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Dzial);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Pesel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Nazwisko);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Imie);
            this.Controls.Add(this.label1);
            this.Name = "Rejestracja";
            this.Text = "Rejestracja";
            this.Load += new System.EventHandler(this.Rejestracja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aplikacja_databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Imie;
        private System.Windows.Forms.TextBox Nazwisko;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Pesel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Dzial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Haslo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Typ_konta;
        private System.Windows.Forms.Label label8;
        private Aplikacja_databaseDataSet aplikacja_databaseDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private Aplikacja_databaseDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.BindingSource usersBindingSource2;
        private System.Windows.Forms.BindingSource usersBindingSource1;
        private System.Windows.Forms.DateTimePicker data;
    }
}