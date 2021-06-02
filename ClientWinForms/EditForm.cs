using ClientWinForms.ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WcfApplication;

namespace ClientWinForms
{
    public partial class EditForm : Form
    {

        public delegate void WithParams(ServerUser su, ServerUser newUser);
        ServerUser _user;
        public static event WithParams StudentUpdated;
        string[] _faculties;
        ServerUser newUser;
        FormStudents fs;


        public EditForm(ServerUser serU, string[] faculties)
        {
            _faculties = faculties;
            _user = serU;
            InitializeComponent();
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            tbId3.Text = _user.Id.ToString();
            tbName3.Text = _user.Name;
            tbSecName3.Text = _user.SecondName;
            tbNameOfFam3.Text = _user.NameOfFamily;
            cmbFac.DataSource = _faculties;
            cmbFac.SelectedItem = _user.Faculty;
            tbCourse3.Text = _user.Course.ToString();
            tbAge3.Text = _user.Age.ToString();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            newUser = new ServerUser();
            newUser.Name = tbName3.Text;
            newUser.SecondName = tbSecName3.Text;
            newUser.NameOfFamily = tbNameOfFam3.Text;
            newUser.Faculty = cmbFac.SelectedItem.ToString();
            newUser.Age = int.Parse(tbAge3.Text);
            newUser.Course = int.Parse(tbCourse3.Text);

            StudentUpdated.Invoke(_user, newUser);

            this.Hide();

        }

        private void EditForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                EditForm.StudentUpdated -= fs.EditM;
            }
            catch (Exception) { }
            
        }
    }
}