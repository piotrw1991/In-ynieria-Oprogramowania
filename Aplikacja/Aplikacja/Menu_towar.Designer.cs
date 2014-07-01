namespace Aplikacja
{
    partial class Menu_towar
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
            this.dodaj = new System.Windows.Forms.Button();
            this.Wyświetl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wroc
            // 
            this.wroc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wroc.ForeColor = System.Drawing.SystemColors.Highlight;
            this.wroc.Location = new System.Drawing.Point(11, 250);
            this.wroc.Margin = new System.Windows.Forms.Padding(2);
            this.wroc.Name = "wroc";
            this.wroc.Size = new System.Drawing.Size(75, 32);
            this.wroc.TabIndex = 2;
            this.wroc.Text = "Wróć";
            this.wroc.UseVisualStyleBackColor = true;
            this.wroc.Click += new System.EventHandler(this.wroc_Click);
            // 
            // dodaj
            // 
            this.dodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dodaj.ForeColor = System.Drawing.SystemColors.Highlight;
            this.dodaj.Location = new System.Drawing.Point(63, 34);
            this.dodaj.Margin = new System.Windows.Forms.Padding(2);
            this.dodaj.Name = "dodaj";
            this.dodaj.Size = new System.Drawing.Size(165, 41);
            this.dodaj.TabIndex = 6;
            this.dodaj.Text = "Dodaj";
            this.dodaj.UseVisualStyleBackColor = true;
            this.dodaj.Click += new System.EventHandler(this.dodaj_Click);
            // 
            // Wyświetl
            // 
            this.Wyświetl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Wyświetl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Wyświetl.Location = new System.Drawing.Point(63, 97);
            this.Wyświetl.Margin = new System.Windows.Forms.Padding(2);
            this.Wyświetl.Name = "Wyświetl";
            this.Wyświetl.Size = new System.Drawing.Size(165, 41);
            this.Wyświetl.TabIndex = 8;
            this.Wyświetl.Text = "Wyświetl";
            this.Wyświetl.UseVisualStyleBackColor = true;
            this.Wyświetl.Click += new System.EventHandler(this.Wyświetl_Click);
            // 
            // Menu_towar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(286, 295);
            this.Controls.Add(this.Wyświetl);
            this.Controls.Add(this.dodaj);
            this.Controls.Add(this.wroc);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Menu_towar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu_towar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button wroc;
        private System.Windows.Forms.Button dodaj;
        private System.Windows.Forms.Button Wyświetl;
    }
}