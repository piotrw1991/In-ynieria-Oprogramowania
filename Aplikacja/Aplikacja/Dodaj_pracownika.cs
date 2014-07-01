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
    public partial class Dodaj_pracownika : Form
    {
        public Dodaj_pracownika()
        {
            InitializeComponent();
        }

        private void wroc_Click(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                this.Hide();
                if (frm is Menu_pracownik)
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
            //DateTimePicker datetimePicker = new DateTimePicker();
            //string dt=datetimePicker.Value.ToString("yyyy-MM-dd");
            try
            {
                string sql = "INSERT INTO Pracownicy (Pesel,Imie,Nazwisko,Dział,Data_urodzenia) VALUES ('" + pesel.Text + "','" + imie.Text + "','" + nazwisko.Text + "','" + Dzial.SelectedItem + "','"+Convert.ToString(Dataur.Value)+"');";


                SqlCommand exeSql = new SqlCommand(sql, cn);
                cn.Open();
                exeSql.ExecuteNonQuery();

                MessageBox.Show("Dodano nowego pracownika", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                cn.Close();
            }
            /*string nname = imie.Text;
            string nsurname = nazwisko.Text;
            ulong nid = Convert.ToUInt64(pesel.Text);
            DateTime ndate = Convert.ToDateTime(data.Text);
            pracownik nowy = new pracownik(nname, nsurname, nid, ndate);
            MessageBox.Show("Dodano pracwnika.");*/
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}