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
    public partial class Wyświetl_pracowników : Form
    {
        Edytuj_pracownika edytujp = new Edytuj_pracownika();
        Usun_pracownika usunp = new Usun_pracownika();
        public Wyświetl_pracowników()
        {
            InitializeComponent();
        }

        private void Wyświetl_pracowników_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aplikacja_databaseDataSet.Pracownicy' table. You can move, or remove it, as needed.
            this.pracownicyTableAdapter.Fill(this.aplikacja_databaseDataSet.Pracownicy);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
           

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

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

                string sql = "Select * From Pracownicy;";
                SqlCommand exeSql = new SqlCommand(sql, cn);

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
                if (frm is Menu_pracownik)
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
                if (frm is Edytuj_pracownika)
                {
                    frm.Show();
                    return;
                }
            }
            

            //Edytuj_pracownika form2 = new Edytuj_pracownika() ;

                edytujp.pesel.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                edytujp.imie.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                edytujp.nazwisko.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                edytujp.Dataur.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                edytujp.Dzial.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
               
            edytujp.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is Usun_pracownika)
                {
                    frm.Show();
                    return;
                }
            }
            usunp.Show();
        }
        public String GetDatagrid()
        {
            return dataGridView1.CurrentRow.Cells.ToString();
        }
    }
}
