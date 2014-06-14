using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Aplikacja
{

    public partial class Form1 : Form
    {
        
        Menedżer menedzer = new Menedżer();
        Pracownik pracownik = new Pracownik();
        public Form1()
        {
            InitializeComponent();
        }

        private void Zaloguj_Click(object sender, EventArgs e)
        {
            if (Login.Text == "Admin")
                if (Haslo.Text == "admin")
                {
                    Login.Text = "";
                    Haslo.Text = "";
                    this.Hide();
                    foreach (Form frm in Application.OpenForms)
                    {
                        if (frm is Menedżer)
                        {
                            frm.Show();
                            return;
                        }
                    }
                    menedzer.Show();

                }
                else
                    MessageBox.Show("Błędne Hasło");
            else if (Login.Text == "Pracownik")
                if (Haslo.Text == "pracownik")
                {
                    Login.Text = "";
                    Haslo.Text = "";
                    this.Hide();
                    foreach (Form frm in Application.OpenForms)
                    {
                        if (frm is Pracownik)
                        {
                            frm.Show();
                            return;
                        }
                    }
                    pracownik.Show();                  
                }
                else
                    MessageBox.Show("Błędne Hasło");
            else MessageBox.Show("Błędny login lub hasło");
        }

        private void Closer_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
