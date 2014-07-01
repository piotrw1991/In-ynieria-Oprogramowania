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
    public partial class wyswietl_zamówienia : Form
    {
        Edytuj_zamowienie edytujz = new Edytuj_zamowienie();
        Usun_zamowienie usunz = new Usun_zamowienie();

        public wyswietl_zamówienia()
        {
            InitializeComponent();
        }

        private void wyswietl_zamówienia_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aplikacja_databaseDataSet.Zamowienia' table. You can move, or remove it, as needed.
            this.zamowieniaTableAdapter.Fill(this.aplikacja_databaseDataSet.Zamowienia);

        }

        private void Pokaz_Click(object sender, EventArgs e)
        {
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (System.IO.Path.GetDirectoryName(executable));
            AppDomain.CurrentDomain.SetData("DataDirectory", path);
            SqlConnection cn = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=|DataDirectory|\\Aplikacja_database.mdf;Integrated Security=True");
            try
            {
                cn.Open();

                string sql = "Select * from Zamowienia;";

                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                ds.Tables.Add(dt);
                SqlDataAdapter da = new SqlDataAdapter();
                da = new SqlDataAdapter(sql, cn);
                dataGridView1.DataSource = ds.Tables[0];
                da.Fill(dt);

                dataGridView1.DataSource = dt.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                cn.Close();
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is Edytuj_zamowienie)
                {
                    frm.Show();
                    return;
                }
            }
            edytujz.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is Usun_zamowienie)
                {
                    frm.Show();
                    return;
                }
            }
            usunz.Show();
        }

        
    }
}
