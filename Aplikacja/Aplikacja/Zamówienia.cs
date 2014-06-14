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
    public partial class Zamówienia : Form
    {
        public Zamówienia()
        {
            InitializeComponent();
        }

        private void edytuj_Click(object sender, EventArgs e)
        {

        }

        private void dodaj_Click(object sender, EventArgs e)
        {

        }

        private void wroc_Click(object sender, EventArgs e)
        {
            this.Hide();
            foreach (Form frm in Application.OpenForms)
            {
                if (Zmienne.formularze == 1)
                {
                    if (frm is Menedżer)
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
    }
}
