using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Aplikacja
{
    public partial class Menu_Menedżer : Form
    {
        Menu_zamówień zamowienia = new Menu_zamówień();
        Menu_pracownik mpracownik = new Menu_pracownik();
        Menu_towar mtowar = new Menu_towar();
        public Menu_Menedżer()
        {
            InitializeComponent();
        }

        private void menu_pracownika_Click(object sender, EventArgs e)
        {
            this.Hide();
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is Menu_pracownik)
                {
                    frm.Show();
                    return;
                }
            }
            mpracownik.Show();
        }

        private void Wyloguj_Click(object sender, EventArgs e)
        {
            this.Hide();
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is Logowanie)
                {
                    frm.Show();
                    return;
                }
            }
        }

        private void menu_zamówienia_Click(object sender, EventArgs e)
        {
            Zmienne.formularze = 1;
            this.Hide();
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is Menu_zamówień)
                {
                    frm.Show();
                    return;
                }
            }
            zamowienia.Show();
        }

        private void menu_towar_Click(object sender, EventArgs e)
        {
            this.Hide();
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is Menu_towar)
                {
                    frm.Show();
                    return;
                }
            }
            mtowar.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rejestracja rejestruj = new Rejestracja();
            this.Hide();
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is Rejestracja)
                {
                    frm.Show();
                    return;
                }
            }
            rejestruj.Show();

        }
    }
}
