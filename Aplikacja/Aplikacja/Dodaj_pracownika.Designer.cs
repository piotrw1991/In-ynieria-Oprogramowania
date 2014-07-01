namespace Aplikacja
{
    partial class Dodaj_pracownika
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
            this.wroc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.imie = new System.Windows.Forms.TextBox();
            this.nazwisko = new System.Windows.Forms.TextBox();
            this.pesel = new System.Windows.Forms.TextBox();
            this.Dataur = new System.Windows.Forms.DateTimePicker();
            this.dodaj = new System.Windows.Forms.Button();
            this.Dzial = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // wroc
            // 
            this.wroc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wroc.ForeColor = System.Drawing.SystemColors.Highlight;
            this.wroc.Location = new System.Drawing.Point(12, 254);
            this.wroc.Margin = new System.Windows.Forms.Padding(2);
            this.wroc.Name = "wroc";
            this.wroc.Size = new System.Drawing.Size(75, 32);
            this.wroc.TabIndex = 2;
            this.wroc.Text = "Wróć";
            this.wroc.UseVisualStyleBackColor = true;
            this.wroc.Click += new System.EventHandler(this.wroc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Imię";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Location = new System.Drawing.Point(9, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nazwisko";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label3.Location = new System.Drawing.Point(9, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pesel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label4.Location = new System.Drawing.Point(9, 144);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data urodzenia";
            // 
            // imie
            // 
            this.imie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.imie.Location = new System.Drawing.Point(9, 26);
            this.imie.Margin = new System.Windows.Forms.Padding(2);
            this.imie.Name = "imie";
            this.imie.Size = new System.Drawing.Size(174, 26);
            this.imie.TabIndex = 7;
            // 
            // nazwisko
            // 
            this.nazwisko.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nazwisko.Location = new System.Drawing.Point(9, 72);
            this.nazwisko.Margin = new System.Windows.Forms.Padding(2);
            this.nazwisko.Name = "nazwisko";
            this.nazwisko.Size = new System.Drawing.Size(174, 26);
            this.nazwisko.TabIndex = 8;
            // 
            // pesel
            // 
            this.pesel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pesel.Location = new System.Drawing.Point(9, 117);
            this.pesel.Margin = new System.Windows.Forms.Padding(2);
            this.pesel.Name = "pesel";
            this.pesel.Size = new System.Drawing.Size(174, 26);
            this.pesel.TabIndex = 9;
            // 
            // Dataur
            // 
            this.Dataur.CustomFormat = "00-00-0000";
            this.Dataur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Dataur.Location = new System.Drawing.Point(12, 163);
            this.Dataur.Margin = new System.Windows.Forms.Padding(2);
            this.Dataur.MinDate = new System.DateTime(1959, 1, 1, 0, 0, 0, 0);
            this.Dataur.Name = "Dataur";
            this.Dataur.Size = new System.Drawing.Size(171, 26);
            this.Dataur.TabIndex = 10;
            this.Dataur.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // dodaj
            // 
            this.dodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dodaj.ForeColor = System.Drawing.SystemColors.Highlight;
            this.dodaj.Location = new System.Drawing.Point(200, 254);
            this.dodaj.Margin = new System.Windows.Forms.Padding(2);
            this.dodaj.Name = "dodaj";
            this.dodaj.Size = new System.Drawing.Size(75, 32);
            this.dodaj.TabIndex = 11;
            this.dodaj.Text = "Dodaj";
            this.dodaj.UseVisualStyleBackColor = true;
            this.dodaj.Click += new System.EventHandler(this.dodaj_Click);
            // 
            // Dzial
            // 
            this.Dzial.FormattingEnabled = true;
            this.Dzial.Items.AddRange(new object[] {
            "Sprzedaż",
            "Dostawa",
            "Magazynier"});
            this.Dzial.Location = new System.Drawing.Point(12, 212);
            this.Dzial.Name = "Dzial";
            this.Dzial.Size = new System.Drawing.Size(171, 21);
            this.Dzial.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label5.Location = new System.Drawing.Point(47, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Dział";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Dodaj_pracownika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(286, 297);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Dzial);
            this.Controls.Add(this.dodaj);
            this.Controls.Add(this.Dataur);
            this.Controls.Add(this.pesel);
            this.Controls.Add(this.nazwisko);
            this.Controls.Add(this.imie);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wroc);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Dodaj_pracownika";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj_pracownika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button wroc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox imie;
        private System.Windows.Forms.TextBox nazwisko;
        private System.Windows.Forms.TextBox pesel;
        private System.Windows.Forms.DateTimePicker Dataur;
        private System.Windows.Forms.Button dodaj;
        private System.Windows.Forms.ComboBox Dzial;
        private System.Windows.Forms.Label label5;
    }
}