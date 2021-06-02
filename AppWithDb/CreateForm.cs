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
    public partial class CreateForm : Form
    {
        public CreateForm()
        {
            InitializeComponent();
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

            cmbFac.DataSource = faculties;

            con.Close();
        }



        private void SendData()
        {
            string name = tbName.Text;
            string secName = tbSecName.Text;
            string nameOfFam = tbNameOfFam.Text;
            int age = int.Parse(tbAge.Text);
            string faculty = cmbFac.SelectedItem.ToString();
            int course = int.Parse(tbCourse.Text);


            var connectionString = ConfigurationManager.ConnectionStrings["SQLConnection"].ConnectionString;

            string sql = $"INSERT INTO StudentsTB(Name,SecondName,NameOfFamily,Age,Faculty,Course) VALUES('{name}','{secName}','{nameOfFam}',{age},'{faculty}',{course});";

            SqlConnection con = new SqlConnection(connectionString);
            
            con.Open();

            SqlCommand cmd = new SqlCommand(sql, con);

            int count = cmd.ExecuteNonQuery();
            MessageBox.Show($"Студент с именем: {name} добавлен в бд.");
            this.Hide();



        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            SendData();
        }
    }
}
