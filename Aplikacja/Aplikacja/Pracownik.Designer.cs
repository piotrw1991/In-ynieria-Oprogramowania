namespace Aplikacja
{
    partial class Pracownik
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
            this.Wyloguj = new System.Windows.Forms.Button();
            this.menu_zamowienia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Wyloguj
            // 
            this.Wyloguj.Location = new System.Drawing.Point(12, 309);
            this.Wyloguj.Name = "Wyloguj";
            this.Wyloguj.Size = new System.Drawing.Size(99, 34);
            this.Wyloguj.TabIndex = 4;
            this.Wyloguj.Text = "Wyloguj";
            this.Wyloguj.UseVisualStyleBackColor = true;
            this.Wyloguj.Click += new System.EventHandler(this.Wyloguj_Click);
            // 
            // menu_zamowienia
            // 
            this.menu_zamowienia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.menu_zamowienia.Location = new System.Drawing.Point(88, 132);
            this.menu_zamowienia.Name = "menu_zamowienia";
            this.menu_zamowienia.Size = new System.Drawing.Size(217, 49);
            this.menu_zamowienia.TabIndex = 5;
            this.menu_zamowienia.Text = "Menu Zamówienia";
            this.menu_zamowienia.UseVisualStyleBackColor = true;
            this.menu_zamowienia.Click += new System.EventHandler(this.menu_zamowienia_Click);
            // 
            // Pracownik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 355);
            this.Controls.Add(this.menu_zamowienia);
            this.Controls.Add(this.Wyloguj);
            this.Name = "Pracownik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pracownik";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Wyloguj;
        private System.Windows.Forms.Button menu_zamowienia;
    }
}