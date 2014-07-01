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
    public partial class Menu_zamówień : Form
    {
        Dodaj_zamowienie dodajz = new Dodaj_zamowienie();
        wyswietl_zamówienia wyswietlz = new wyswietl_zamówienia();
        public Menu_zamówień()
        {
            InitializeComponent();
        }

        private void dodaj_Click(object sender, EventArgs e)
        {
            this.Hide();
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is Dodaj_zamowienie)
                {
                    frm.Show();
                    return;
                }
            }
            dodajz.Show();
        }

        private void wroc_Click(object sender, EventArgs e)
        {
            this.Hide();
            foreach (Form frm in Application.OpenForms)
            {
                if (Zmienne.formularze == 1)
                {
                    if (frm is Menu_Menedżer)
                    {
                        frm.Show();
                        return;
                    }
                }
                else if (Zmienne.formularze == 2)
                {
                    if (frm is Pracownik)
                    {
                        frm.Show();
                        return;
                    }
                }
            }
        }

        private void Wyświetl_Click(object sender, EventArgs e)
        {
            this.Hide();
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is wyswietl_zamówienia)
                {
                    frm.Show();
                    return;
                }
            }
            wyswietlz.Show();
        }
    }
}
