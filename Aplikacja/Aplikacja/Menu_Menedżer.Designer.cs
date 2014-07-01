namespace Aplikacja
{
    partial class Menu_Menedżer
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
            this.menu_pracownik = new System.Windows.Forms.Button();
            this.menu_towar = new System.Windows.Forms.Button();
            this.menu_zamówienia = new System.Windows.Forms.Button();
            this.Wyloguj = new System.Windows.Forms.Button();
            this.Rejestracja = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // menu_pracownik
            // 
            this.menu_pracownik.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.menu_pracownik.ForeColor = System.Drawing.SystemColors.Highlight;
            this.menu_pracownik.Location = new System.Drawing.Point(61, 57);
            this.menu_pracownik.Margin = new System.Windows.Forms.Padding(2);
            this.menu_pracownik.Name = "menu_pracownik";
            this.menu_pracownik.Size = new System.Drawing.Size(165, 41);
            this.menu_pracownik.TabIndex = 0;
            this.menu_pracownik.Text = "Menu Pracownik";
            this.menu_pracownik.UseVisualStyleBackColor = true;
            this.menu_pracownik.Click += new System.EventHandler(this.menu_pracownika_Click);
            // 
            // menu_towar
            // 
            this.menu_towar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.menu_towar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.menu_towar.Location = new System.Drawing.Point(61, 109);
            this.menu_towar.Margin = new System.Windows.Forms.Padding(2);
            this.menu_towar.Name = "menu_towar";
            this.menu_towar.Size = new System.Drawing.Size(165, 41);
            this.menu_towar.TabIndex = 1;
            this.menu_towar.Text = "Menu Towar";
            this.menu_towar.UseVisualStyleBackColor = true;
            this.menu_towar.Click += new System.EventHandler(this.menu_towar_Click);
            // 
            // menu_zamówienia
            // 
            this.menu_zamówienia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.menu_zamówienia.ForeColor = System.Drawing.SystemColors.Highlight;
            this.menu_zamówienia.Location = new System.Drawing.Point(61, 164);
            this.menu_zamówienia.Margin = new System.Windows.Forms.Padding(2);
            this.menu_zamówienia.Name = "menu_zamówienia";
            this.menu_zamówienia.Size = new System.Drawing.Size(165, 41);
            this.menu_zamówienia.TabIndex = 2;
            this.menu_zamówienia.Text = "Menu Zamówienia";
            this.menu_zamówienia.UseVisualStyleBackColor = true;
            this.menu_zamówienia.Click += new System.EventHandler(this.menu_zamówienia_Click);
            // 
            // Wyloguj
            // 
            this.Wyloguj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Wyloguj.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Wyloguj.Location = new System.Drawing.Point(9, 246);
            this.Wyloguj.Margin = new System.Windows.Forms.Padding(2);
            this.Wyloguj.Name = "Wyloguj";
            this.Wyloguj.Size = new System.Drawing.Size(75, 32);
            this.Wyloguj.TabIndex = 3;
            this.Wyloguj.Text = "Wyloguj";
            this.Wyloguj.UseVisualStyleBackColor = true;
            this.Wyloguj.Click += new System.EventHandler(this.Wyloguj_Click);
            // 
            // Rejestracja
            // 
            this.Rejestracja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Rejestracja.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Rejestracja.Location = new System.Drawing.Point(180, 246);
            this.Rejestracja.Name = "Rejestracja";
            this.Rejestracja.Size = new System.Drawing.Size(94, 32);
            this.Rejestracja.TabIndex = 4;
            this.Rejestracja.Text = "Rejestracja";
            this.Rejestracja.UseVisualStyleBackColor = true;
            this.Rejestracja.Click += new System.EventHandler(this.button1_Click);
            // 
            // Menu_Menedżer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(286, 288);
            this.Controls.Add(this.Rejestracja);
            this.Controls.Add(this.Wyloguj);
            this.Controls.Add(this.menu_zamówienia);
            this.Controls.Add(this.menu_towar);
            this.Controls.Add(this.menu_pracownik);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Menu_Menedżer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu_Menedżer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button menu_pracownik;
        private System.Windows.Forms.Button menu_towar;
        private System.Windows.Forms.Button menu_zamówienia;
        private System.Windows.Forms.Button Wyloguj;
        private System.Windows.Forms.Button Rejestracja;

    }
}