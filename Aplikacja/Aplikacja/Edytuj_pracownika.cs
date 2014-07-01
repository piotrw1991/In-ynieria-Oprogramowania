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
    public partial class Edytuj_pracownika : Form
    {
        public Edytuj_pracownika()
        {
            InitializeComponent();
        }


        private void wroc_Click(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                this.Hide();
                if (frm is Wyświetl_pracowników)
                {
                    frm.Show();
                    return;
                }
            }

        }

        private void Edytuj_pracownika_Load(object sender, EventArgs e)
        {
           
            
           
        }

        private void Zapisz_Click(object sender, EventArgs e)
        {
            Wyświetl_pracowników form1 = new Wyświetl_pracowników();
            SqlConnection cn = new SqlConnection("Data Source=(LocalDB)\\v11.0;AttachDbFilename=C:\\Users\\Potr\\Documents\\Visual Studio 2012\\Projects\\Aplikacja2\\Aplikacja_database.mdf;Integrated Security=True");
            //DateTimePicker datetimePicker = new DateTimePicker();
            //string dt=datetimePicker.Value.ToString("yyyy-MM-dd");
            try
            {
                //string sql = "Update Pracownicy Set pesel='" + pesel.Text + "',imie='" + imie.Text + "',nazwisko='" + nazwisko.Text + "',Dzial='" + Dzial.SelectedItem + "',Dataur='" + Convert.ToString(Dataur.Value) + "'pesel='" + pesel.Text + "';";

                SqlDataAdapter dataAdpater = new SqlDataAdapter("SELECT CategoryID, CategoryName FROM Categories",cn);

                dataAdpater.UpdateCommand = new SqlCommand("Update Pracownicy Set pesel='" + pesel.Text + "',imie='" + imie.Text + "',nazwisko='" + nazwisko.Text + "',Dzial='" + Dzial.SelectedItem + "',Dataur='" + Convert.ToString(Dataur.Value) + "'pesel='" + pesel.Text + "';", cn);

                //SqlCommand exeSql = new SqlCommand(sql, cn);
                cn.Open();
                /*exeSql.ExecuteNonQuery();
                
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                ds.Tables.Add(dt);
                SqlDataAdapter da = new SqlDataAdapter();
                da = new SqlDataAdapter(sql, cn);
                form1.dataGridView1.DataSource = ds.Tables[0];*/

                DataSet ds = new DataSet();
                DataTable table = new DataTable();
                ds.Tables.Add(table);
                table=ds.Tables["Pracownicy"];

                SqlDataAdapter da = new SqlDataAdapter();
                dataAdpater = new SqlDataAdapter("Update Pracownicy Set pesel='" + pesel.Text + "',imie='" + imie.Text + "',nazwisko='" + nazwisko.Text + "',Dzial='" + Dzial.SelectedItem + "',Dataur='" + Convert.ToString(Dataur.Value) + "'pesel='" + pesel.Text + "';", cn);
                form1.dataGridView1.DataSource = ds.Tables["Pracownicy"];
                da.Update(table);


                //da.Update(dt);
                MessageBox.Show("Zmodyfikowano pracownika", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                cn.Close();
            }
            

            this.Close();
        }
    }
}
