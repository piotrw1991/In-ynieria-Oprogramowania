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
    public partial class Menu_pracownik : Form
    {
        Dodaj_pracownika dodajp = new Dodaj_pracownika();
        Wyświetl_pracowników wyswietlp = new Wyświetl_pracowników();
        public Menu_pracownik()
        {
            InitializeComponent();
        }

        private void wroc_Click(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                this.Hide();
                if (frm is Menu_Menedżer)
                {
                    frm.Show();
                    return;
                }
            }
        }

        private void dodaj_Click(object sender, EventArgs e)
        {
            this.Hide();
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is Dodaj_pracownika)
                {
                    frm.Show();
                    return;
                }
            }
            dodajp.Show();
        }

        private void wyswietl_Click(object sender, EventArgs e)
        {
            this.Hide();
            foreach (Form frm in Application.OpenForms)
            {
                
                if (frm is Wyświetl_pracowników)
                {
                    frm.Show();
                    return;
                }
            }
            wyswietlp.Show();
            
        }
    }
}
