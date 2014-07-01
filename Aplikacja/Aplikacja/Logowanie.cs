using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Aplikacja
{

    public partial class Logowanie : Form
    {
        
        Menu_Menedżer menedzer = new Menu_Menedżer();
        Pracownik pracownik = new Pracownik();
        public Logowanie()
        {
            InitializeComponent();
        }


        private void Zaloguj_Click(object sender, EventArgs e)
        {
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (System.IO.Path.GetDirectoryName(executable));
            AppDomain.CurrentDomain.SetData("DataDirectory", path);
            SqlConnection cn = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=|DataDirectory|\\Aplikacja_database.mdf;Integrated Security=True");
            try
            {
                cn.Open();
            }
            catch
            {
                MessageBox.Show("Error with the database connection");
            }

            string sql = "Select * from Users where Login=@Login and Haslo=@Haslo and Typ_konta=@Typ_konta;";
            string sql2 = "Select * from Users where Login=@Login and Haslo=@Haslo and Typ_konta=@Typ_konta;";
            SqlCommand exeSql = new SqlCommand(sql, cn);
            SqlCommand exeSql2 = new SqlCommand(sql2, cn);
            exeSql.Parameters.AddWithValue("@Login", this.Login.Text);
            exeSql.Parameters.AddWithValue("@Haslo", this.Haslo.Text);
            exeSql.Parameters.AddWithValue("@Typ_konta", "Administrator");

            exeSql2.Parameters.AddWithValue("@Login", this.Login.Text);
            exeSql2.Parameters.AddWithValue("@Haslo", this.Haslo.Text);
            exeSql2.Parameters.AddWithValue("@Typ_Konta", "Uzytkownik");

            SqlDataReader dr = exeSql.ExecuteReader();
            bool logged = false;
            while (dr.Read())
            {
                if (dr.HasRows == true)
                {

                    logged = true;
                    MessageBox.Show("Login Successfull", "Login Information");
                    this.Hide();
                    menedzer.Show();
                }
                
              }
            if (!logged)
            {
                dr.Close();
                dr = exeSql2.ExecuteReader();
                while (dr.Read())
                {
                    if (dr.HasRows == true)
                    {
                        MessageBox.Show("Login Successfull", "Login Information");
                        this.Hide();
                        pracownik.Show();
                    }

                    else
                    {
                        MessageBox.Show("Access Denied", "Login Information");
                        this.Close();
                    }
                }

            }   

           
            
            /*if (Login.Text == "Admin")
                if (Haslo.Text == "admin")
                {
                    
                    Login.Text = "";
                    Haslo.Text = "";
                    this.Hide();
                    foreach (Form frm in Application.OpenForms)
                    {
                        if (frm is Menedżer)
                        {
                            frm.Show();
                            return;
                        }
                    }
                    menedzer.Show();

                }
                else
                    MessageBox.Show("Błędne Hasło");
            else if (Login.Text == "Pracownik")
                if (Haslo.Text == "pracownik")
                {
                    Login.Text = "";
                    Haslo.Text = "";
                    this.Hide();
                    foreach (Form frm in Application.OpenForms)
                    {
                        if (frm is Pracownik)
                        {
                            frm.Show();
                            return;
                        }
                    }
                    pracownik.Show();                  
                }
                else
                    MessageBox.Show("Błędne Hasło");
            else MessageBox.Show("Błędny login lub hasło");
            */
         
        }
        
        
        private void Closer_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
