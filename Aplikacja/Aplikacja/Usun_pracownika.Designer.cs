namespace Aplikacja
{
    partial class Usun_pracownika
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
            this.SuspendLayout();
            // 
            // wroc
            // 
            this.wroc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wroc.ForeColor = System.Drawing.SystemColors.Highlight;
            this.wroc.Location = new System.Drawing.Point(9, 246);
            this.wroc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.wroc.Name = "wroc";
            this.wroc.Size = new System.Drawing.Size(75, 32);
            this.wroc.TabIndex = 2;
            this.wroc.Text = "Wróć";
            this.wroc.UseVisualStyleBackColor = true;
            this.wroc.Click += new System.EventHandler(this.wroc_Click);
            // 
            // Usun_pracownika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(286, 288);
            this.Controls.Add(this.wroc);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Usun_pracownika";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usun_pracownika";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button wroc;
    }
}