using ClientWinForms.ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WcfApplication;

namespace ClientWinForms
{
    public partial class CreateForm : Form
    {
        public delegate void WithParams(ServerUser newUser);
        ServerUser _user;
        public static event WithParams StudentUpdated;
        string[] _faculties;
        ServerUser newUser;
        FormStudents fs;

        public CreateForm(string[] faculties)
        {
            InitializeComponent();

            cmbFac.DataSource = faculties;
        }


        private void ClearFields()
        {
            tbName.Clear();
            tbSecName.Clear();
            tbNameOfFam.Clear();
            tbAge.Clear();
            tbCourse.Clear();
        }
        ServerUser newU;
        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                newU = new ServerUser();
                newU.Name = tbName.Text;
                newU.SecondName = tbSecName.Text;
                newU.NameOfFamily = tbNameOfFam.Text;
                newU.Faculty = cmbFac.SelectedItem.ToString();
                newU.Age = int.Parse(tbAge.Text);
                newU.Course = int.Parse(tbCourse.Text);

                StudentUpdated.Invoke(newU);

                ClearFields();

                MessageBox.Show($"student with name {newU.Name} created");
                this.Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("Incorrectli fields!");
            }

        }

        private void CreateForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                CreateForm.StudentUpdated -= fs.CreateM;
            }
            catch (Exception) { }
        }
    }
}
