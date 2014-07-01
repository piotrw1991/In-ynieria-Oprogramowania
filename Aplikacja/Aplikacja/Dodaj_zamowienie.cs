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
    public partial class Dodaj_zamowienie : Form
    {
        public Dodaj_zamowienie()
        {
            InitializeComponent();
        }

        private void wroc_Click(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                this.Hide();
                if (frm is Menu_zamówień)
                {
                    frm.Show();
                    return;
                }
            }
        }

        private void dodaj_Click(object sender, EventArgs e)
        {
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (System.IO.Path.GetDirectoryName(executable));
            AppDomain.CurrentDomain.SetData("DataDirectory", path);
            SqlConnection cn = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=|DataDirectory|\\Aplikacja_database.mdf;Integrated Security=True");
            try
            {
                string sql = "INSERT INTO Zamowienia (Sklep,Data_złożenia,Ilość_towaru) VALUES ('" + sklep.SelectedItem + "','" + Convert.ToString(data_zlozenia.Value) + "','" + ilosc.SelectedValue + "');";


                SqlCommand exeSql = new SqlCommand(sql, cn);
                cn.Open();
                exeSql.ExecuteNonQuery();

                MessageBox.Show("Dodano nowe zamówienie", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                cn.Close();
            }
            /*string nshop = sklep.Text;
            string nproduct = towar.Text;
            uint ncount = Convert.ToUInt32(ilosc.Text);
            string nwho = kto.Text;
            DateTime nwhen = Convert.ToDateTime(data_zlozenia.Text);
            zamowienie nowy = new zamowienie(nshop, nproduct, ncount, nwho, nwhen);
            MessageBox.Show("Dodano zamówienie.");*/
        }

        private void Dodaj_zamowienie_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aplikacja_databaseDataSet.Produkty' table. You can move, or remove it, as needed.
            this.produktyTableAdapter.Fill(this.aplikacja_databaseDataSet.Produkty);
            // TODO: This line of code loads data into the 'aplikacja_databaseDataSet.Zamowienia' table. You can move, or remove it, as needed.
            this.zamowieniaTableAdapter.Fill(this.aplikacja_databaseDataSet.Zamowienia);
            // TODO: This line of code loads data into the 'aplikacja_databaseDataSet.Pracownicy' table. You can move, or remove it, as needed.
            this.pracownicyTableAdapter.Fill(this.aplikacja_databaseDataSet.Pracownicy);

        }

        private void Towar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
