namespace Aplikacja
{
    partial class Dodaj_towar
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
            this.Nazwa = new System.Windows.Forms.TextBox();
            this.Producent = new System.Windows.Forms.TextBox();
            this.NrSeryjny = new System.Windows.Forms.TextBox();
            this.Cena = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Kategoria = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Ilosc = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Dodaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wroc
            // 
            this.wroc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wroc.ForeColor = System.Drawing.SystemColors.Highlight;
            this.wroc.Location = new System.Drawing.Point(9, 246);
            this.wroc.Margin = new System.Windows.Forms.Padding(2);
            this.wroc.Name = "wroc";
            this.wroc.Size = new System.Drawing.Size(75, 32);
            this.wroc.TabIndex = 3;
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
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nazwa";
            // 
            // Nazwa
            // 
            this.Nazwa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Nazwa.Location = new System.Drawing.Point(9, 26);
            this.Nazwa.Margin = new System.Windows.Forms.Padding(2);
            this.Nazwa.Name = "Nazwa";
            this.Nazwa.Size = new System.Drawing.Size(183, 26);
            this.Nazwa.TabIndex = 5;
            // 
            // Producent
            // 
            this.Producent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Producent.Location = new System.Drawing.Point(9, 72);
            this.Producent.Margin = new System.Windows.Forms.Padding(2);
            this.Producent.Name = "Producent";
            this.Producent.Size = new System.Drawing.Size(183, 26);
            this.Producent.TabIndex = 6;
            // 
            // NrSeryjny
            // 
            this.NrSeryjny.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NrSeryjny.Location = new System.Drawing.Point(9, 117);
            this.NrSeryjny.Margin = new System.Windows.Forms.Padding(2);
            this.NrSeryjny.Name = "NrSeryjny";
            this.NrSeryjny.Size = new System.Drawing.Size(183, 26);
            this.NrSeryjny.TabIndex = 7;
            // 
            // Cena
            // 
            this.Cena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Cena.Location = new System.Drawing.Point(9, 211);
            this.Cena.Margin = new System.Windows.Forms.Padding(2);
            this.Cena.MaxLength = 7;
            this.Cena.Name = "Cena";
            this.Cena.Size = new System.Drawing.Size(76, 26);
            this.Cena.TabIndex = 8;
            this.Cena.TextChanged += new System.EventHandler(this.Cena_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Location = new System.Drawing.Point(9, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Producent";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label3.Location = new System.Drawing.Point(6, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Numer seryjny";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label4.Location = new System.Drawing.Point(6, 144);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Kategoria";
            // 
            // Kategoria
            // 
            this.Kategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Kategoria.FormattingEnabled = true;
            this.Kategoria.Items.AddRange(new object[] {
            "Telewizor",
            "Telefon",
            "Laptop",
            "Komputer"});
            this.Kategoria.Location = new System.Drawing.Point(9, 163);
            this.Kategoria.Margin = new System.Windows.Forms.Padding(2);
            this.Kategoria.Name = "Kategoria";
            this.Kategoria.Size = new System.Drawing.Size(116, 28);
            this.Kategoria.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label5.Location = new System.Drawing.Point(9, 193);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Cena";
            // 
            // Ilosc
            // 
            this.Ilosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Ilosc.FormattingEnabled = true;
            this.Ilosc.Items.AddRange(new object[] {
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
            this.Ilosc.Location = new System.Drawing.Point(94, 209);
            this.Ilosc.Margin = new System.Windows.Forms.Padding(2);
            this.Ilosc.Name = "Ilosc";
            this.Ilosc.Size = new System.Drawing.Size(98, 28);
            this.Ilosc.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label6.Location = new System.Drawing.Point(91, 193);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Ilość";
            // 
            // Dodaj
            // 
            this.Dodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Dodaj.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Dodaj.Location = new System.Drawing.Point(202, 246);
            this.Dodaj.Margin = new System.Windows.Forms.Padding(2);
            this.Dodaj.Name = "Dodaj";
            this.Dodaj.Size = new System.Drawing.Size(75, 32);
            this.Dodaj.TabIndex = 16;
            this.Dodaj.Text = "Dodaj";
            this.Dodaj.UseVisualStyleBackColor = true;
            this.Dodaj.Click += new System.EventHandler(this.Dodaj_Click);
            // 
            // Dodaj_towar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(286, 288);
            this.Controls.Add(this.Dodaj);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Ilosc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Kategoria);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cena);
            this.Controls.Add(this.NrSeryjny);
            this.Controls.Add(this.Producent);
            this.Controls.Add(this.Nazwa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wroc);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Dodaj_towar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj_towar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button wroc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Nazwa;
        private System.Windows.Forms.TextBox Producent;
        private System.Windows.Forms.TextBox NrSeryjny;
        private System.Windows.Forms.TextBox Cena;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Kategoria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Ilosc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Dodaj;
    }
}