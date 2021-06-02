using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppWithDb
{
    public partial class EditForm : Form
    {
        public EditForm()
        {
            InitializeComponent();
            GetData();
        }

        private void GetData()
        {
            int id = Students.IdOfStdn;
            var connectionString = ConfigurationManager.ConnectionStrings["SQLConnection"].ConnectionString;



            string quStd = $"SELECT * FROM StudentsTB where Id = {id}";


            using (SqlConnection con = new SqlConnection(connectionString))
            {

                con.Open();


                string sqlFcl = "SELECT [Faculty] FROM[StudentsDB].[dbo].[StudentsTB]";

                SqlCommand cmd = new SqlCommand(sqlFcl, con);
                DataTable dt2 = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt2);

                List<string> faculties = new List<string>();

                var list = dt2.Select().SelectMany(row => row.ItemArray).Select(x => (string)x).ToList();
                for (int i = 0; i < list.Count; i++)
                {
                    string str = "";
                    str = list[i].Trim();
                    if (!faculties.Contains(str))
                    {
                        faculties.Add(str);

                    }
                }

                cmbFac.DataSource = faculties;



                SqlDataAdapter adapter = new SqlDataAdapter(quStd, con);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                int idU = (int)dt.Rows[0][0];
                string name = dt.Rows[0][1].ToString().Trim();
                string secName = dt.Rows[0][2].ToString().Trim();
                string nameOfFam = dt.Rows[0][3].ToString().Trim();
                int age = (int)dt.Rows[0][4];
                string fac = dt.Rows[0][5].ToString().Trim();
                int course = (int)dt.Rows[0][6];

                GlbName = name;

                tbId3.Text = idU.ToString();
                tbName3.Text = name;
                tbSecName3.Text = secName;
                tbNameOfFam3.Text = nameOfFam;
                tbAge3.Text = age.ToString();
                cmbFac.SelectedItem = fac;
                tbCourse3.Text = course.ToString();





            }
        }

        string GlbName;

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["SQLConnection"].ConnectionString;

            

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string queUpdate = $@"Update [StudentsDB].[dbo].[StudentsTB] 
                                SET 
                                Name = '{tbName3.Text}', 
                                SecondName = '{tbSecName3.Text}', 
                                NameOfFamily = '{tbNameOfFam3.Text}', 
                                Age = {tbAge3.Text},
                                Course = {tbCourse3.Text},
                                Faculty = '{cmbFac.SelectedItem.ToString()}'
                                WHERE Id = {Students.IdOfStdn}; ";
                SqlCommand cmd = new SqlCommand(queUpdate, con);
                cmd.ExecuteNonQuery();

                MessageBox.Show($"user with name {GlbName} edited");
                this.Hide();
            } 


        }
    }
}
