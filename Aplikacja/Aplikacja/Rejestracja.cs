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
    public partial class Rejestracja : Form
    {
        Menu_Menedżer menedzer = new Menu_Menedżer();

        public Rejestracja()
        {
            InitializeComponent();
            

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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
            menedzer.Show();
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (System.IO.Path.GetDirectoryName(executable));
            AppDomain.CurrentDomain.SetData("DataDirectory", path);
            SqlConnection cn = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=|DataDirectory|\\Aplikacja_database.mdf;Integrated Security=True");
            
            try
            {
                string sql = "INSERT INTO Users (Imie,Nazwisko,Pesel,Data_urodzenia,Dzial,Login,Haslo,Typ_konta) VALUES ('"+Imie.Text+"','"+Nazwisko.Text+"','"+Pesel.Text+"','"+Convert.ToString(data.Value)+"','"+Dzial.Text+"','"+Login.Text+"','"+Haslo.Text+"','"+Typ_konta.SelectedItem+"');";


                SqlCommand exeSql = new SqlCommand(sql, cn);
                cn.Open();
                exeSql.ExecuteNonQuery();

                MessageBox.Show("Dodano nowego użytkownika", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                cn.Close();
            }
            this.Hide();
            foreach (Form frm in Application.OpenForms)
            {
                if (frm is Menu_Menedżer)
                {
                    frm.Show();
                    return;
                }
            }
            menedzer.Show();
        }

        private void Dataur_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void Rejestracja_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aplikacja_databaseDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.aplikacja_databaseDataSet.Users);

        }
    }
}
