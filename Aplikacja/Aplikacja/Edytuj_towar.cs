﻿using System;
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
    public partial class Edytuj_towar : Form
    {
        public Edytuj_towar()
        {
            InitializeComponent();
        }

        private void wroc_Click(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                this.Hide();
                if (frm is Menu_towar)
                {
                    frm.Show();
                    return;
                }
            }
        }
    }
}
