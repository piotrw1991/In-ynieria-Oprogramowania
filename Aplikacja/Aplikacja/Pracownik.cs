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
    public partial class Pracownik : Form
    {
        Zamówienia zamowienia = new Zamówienia();
        public Pracownik()
        {
            InitializeComponent();
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

        private void menu_zamowienia_Click(object sender, EventArgs e)
        {
            Zmienne.formularze = 2;
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

    }
}
