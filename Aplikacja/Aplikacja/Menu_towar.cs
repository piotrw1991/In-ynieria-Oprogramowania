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
    public partial class Menu_towar : Form
    {
        Dodaj_towar dodajt = new Dodaj_towar();
        Wyświetl_towary wyswietlt = new Wyświetl_towary();
        public Menu_towar()
        {
            InitializeComponent();
        }

        private void wroc_Click(object sender, EventArgs e)
        {
            this.Hide();
            foreach (Form frm in Application.OpenForms)
            {
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
                if (frm is Dodaj_towar)
                {
                    frm.Show();
                    return;
                }
            }
            dodajt.Show();
        }

        private void Wyświetl_Click(object sender, EventArgs e)
        {
            this.Hide();
            foreach (Form frm in Application.OpenForms)
            {

                if (frm is Wyświetl_towary)
                {
                    frm.Show();
                    return;
                }
            }
            wyswietlt.Show();
        }
    }
}
