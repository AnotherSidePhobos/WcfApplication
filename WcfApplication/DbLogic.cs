using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Text.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Data;
using System.Reflection;
using System.Configuration;
using System.Data.SqlClient;

namespace WcfApplication
{
    public partial class AppService
    {
        public List<ServerUser> MakeList()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["SQLConnection"].ConnectionString;

            string sql = "SELECT * FROM StudentsTB";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);

                DataSet ds = new DataSet();

                adapter.Fill(ds);

                IList<PropertyInfo> properties = typeof(ServerUser).GetProperties().ToList();
                Users = new List<ServerUser>();

                foreach (var row in ds.Tables[0].Rows)
                {
                    var item = CreateItemFromRow<ServerUser>((DataRow)row, properties);
                    item.Name = item.Name.Trim();
                    item.SecondName = item.SecondName.Trim();
                    item.NameOfFamily = item.NameOfFamily.Trim();
                    item.Faculty = item.Faculty.Trim();
                    Users.Add(item);
                }
                return Users;
            }
        }


        public void Edit(int id, string name, string secondName, string nameOfFamily, string faculty, int age, int course)
        {

            var connectionString = ConfigurationManager.ConnectionStrings["SQLConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            string sql = $@"Update [StudentsDB].[dbo].[StudentsTB]
                        SET Name = '{name}', SecondName = '{secondName}', NameOfFamily = '{nameOfFamily}', Age = {age}, Course = {course}, Faculty = '{faculty}'
                        WHERE Id = {id}; ";

            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.ExecuteNonQuery();
            con.Close();

        }


        public void Save(int countUsers, string name, string secondName, string nameOfFamily, string faculty, int age, int course)
        {

            var connectionString = ConfigurationManager.ConnectionStrings["SQLConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            string maxIdQuery = "SELECT Max([id]) FROM [StudentsDB].[dbo].[StudentsTB]";

            SqlCommand cmdMax = new SqlCommand(maxIdQuery, con);
            int maxId = (int)cmdMax.ExecuteScalar();


            string sql = $@"INSERT INTO [StudentsDB].[dbo].[StudentsTB](Name, SecondName, NameOfFamily, Age, Faculty, Course)
                        VALUES('{name}', '{secondName}', '{nameOfFamily}', {age}, '{faculty}', {course}); ";

            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}