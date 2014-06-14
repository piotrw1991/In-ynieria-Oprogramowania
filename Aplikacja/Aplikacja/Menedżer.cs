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
    public partial class Menedżer : Form
    {
        Zamówienia zamowienia = new Zamówienia();
        public Menedżer()
        {
            InitializeComponent();
        }

        private void menu_pracownika_Click(object sender, EventArgs e)
        {

        }

        private void Wyloguj_Click(object sender, EventArgs e)
        {
            this.Hide();
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is Form1)
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
                if (frm is Zamówienia)
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
        }

    }
}
