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
    public partial class Dodaj_towar : Form
    {
        public Dodaj_towar()
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

        private void Dodaj_Click(object sender, EventArgs e)
        {
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (System.IO.Path.GetDirectoryName(executable));
            AppDomain.CurrentDomain.SetData("DataDirectory", path);
            SqlConnection cn = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=|DataDirectory|\\Aplikacja_database.mdf;Integrated Security=True");
            try
            {
                string sql = "INSERT INTO Produkty (Numer_seryjny,Nazwa_produktu,Producent,Kategoria,Cena,Ilość) VALUES ('" +NrSeryjny.Text + "','" +Nazwa.Text + "','" + Producent.Text + "','"+ Kategoria.SelectedItem+"','"+Convert.ToDecimal(Cena.Text)+"','"+Ilosc.SelectedValue+"');";


                SqlCommand exeSql = new SqlCommand(sql, cn);
                cn.Open();
                exeSql.ExecuteNonQuery();

                MessageBox.Show("Dodano nowego towaru", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                cn.Close();
            }
            /*string cname = Nazwa.Text;
            string cprod = Producent.Text;
            ulong cnumber = Convert.ToUInt64(NrSeryjny.Text);
            string ccat = Kategoria.SelectedText;
            uint cprice = Convert.ToUInt32(Cena.Text);
            uint ccount = Convert.ToUInt32(Ilosc.SelectedText);
            Towar nowy = new Towar(cname, cprod, cnumber, ccat, cprice, ccount);
            MessageBox.Show("Dodano towar.");*/
        }

        private void Cena_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
