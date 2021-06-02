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
    public partial class Students : Form
    {
        public Students()
        {
            InitializeComponent();
            dgvStudents.ReadOnly = true;
            dgvStudents.AllowUserToAddRows = false;
            GetDataToCmb();
        }
        private void GetDataToCmb()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["SQLConnection"].ConnectionString;

            SqlConnection con = new SqlConnection(connectionString);

            con.Open();

            string sqlFcl = "SELECT [Faculty] FROM[StudentsDB].[dbo].[StudentsTB]";

            SqlCommand cmd = new SqlCommand(sqlFcl, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            List<string> faculties = new List<string>();

            var list = dt.Select().SelectMany(row => row.ItemArray).Select(x => (string)x).ToList();
            for (int i = 0; i < list.Count; i++)
            {
                string str = "";
                str = list[i].Trim();
                if (!faculties.Contains(str))
                {
                    faculties.Add(str);

                }
            }

            comboBoxFac.DataSource = faculties;
            con.Close();
        }

        private void GetData()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["SQLConnection"].ConnectionString;

            string sql = "SELECT * FROM StudentsTB";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);

                DataSet ds = new DataSet();

                adapter.Fill(ds);

                dgvStudents.DataSource = ds.Tables[0];

            }

        }

        private void btnSearchAll_Click(object sender, EventArgs e)
        {
            GetData();

            lblUpdate.Visible = false;
        }

        private void btnGoToCreate_Click(object sender, EventArgs e)
        {
            CreateForm dialog = new CreateForm();

            dialog.ShowDialog(this);

            lblUpdate.Visible = true;
        }

        private void btnSearchId_Click(object sender, EventArgs e)
        {

            GetDataById(int.Parse(tbId.Text));

        }

        private void ClearFeild()
        {
            tbId.Clear();
            tbName.Clear();
            tbSecName.Clear();
            tbNameOfFam.Clear();
            tbCourse.Clear();
            tbAge.Clear();
        }

        private void GetDataById(int id)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["SQLConnection"].ConnectionString;

            string sql = $"SELECT * FROM StudentsTB where Id = {id}";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);

                DataSet ds = new DataSet();

                adapter.Fill(ds);

                dgvStudents.DataSource = ds.Tables[0];

            }

            ClearFeild();

        }

        private void btnSearchName_Click(object sender, EventArgs e)
        {
            GetDataByName(tbName.Text);
        }

        private void GetDataByName(string name)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["SQLConnection"].ConnectionString;

            string sql = $"SELECT * FROM StudentsTB where Name = '{name}'";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);

                DataSet ds = new DataSet();

                adapter.Fill(ds);

                dgvStudents.DataSource = ds.Tables[0];

            }

            ClearFeild();
        }

        private void btgSearchAge_Click(object sender, EventArgs e)
        {
            GetDataByAge(int.Parse(tbAge.Text));
        }

        private void GetDataByAge(int age)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["SQLConnection"].ConnectionString;

            string sql = $"SELECT * FROM StudentsTB where Age = {age}";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);

                DataSet ds = new DataSet();

                adapter.Fill(ds);

                dgvStudents.DataSource = ds.Tables[0];

            }

            ClearFeild();
        }

        private void btnSearchCourse_Click(object sender, EventArgs e)
        {
            GetDataByCourse(int.Parse(tbCourse.Text));
        }

        private void GetDataByCourse(int course)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["SQLConnection"].ConnectionString;

            string sql = $"SELECT * FROM StudentsTB where Course = {course}";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);

                DataSet ds = new DataSet();

                adapter.Fill(ds);

                dgvStudents.DataSource = ds.Tables[0];

            }

            ClearFeild();
        }

        private void comboBoxFac_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetDataByFaculty(comboBoxFac.SelectedItem.ToString());
        }

        private void GetDataByFaculty(string faculty)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["SQLConnection"].ConnectionString;

            string sql = $"SELECT * FROM StudentsTB where Faculty = '{faculty}'";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);

                DataSet ds = new DataSet();

                adapter.Fill(ds);

                dgvStudents.DataSource = ds.Tables[0];

            }

            ClearFeild();
        }

        private void dgvStudents_SelectionChanged(object sender, EventArgs e)
        {
            btnEdit.Visible = true;
        }

        public static int IdOfStdn { get; set; }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            IdOfStdn = this.dgvStudents.SelectedCells[0].RowIndex + 1;

            EditForm ef = new EditForm();

            ef.ShowDialog(this);

            lblUpdate.Visible = true;



        }
    }
}
