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
using ClientWinForms.ServiceReference1;
using System.IO;
using System.Data.SqlClient;
using System.Configuration;

namespace ClientWinForms
{
    public partial class FormStudents : Form
    {

        AppService AppService = new AppService();
        AppServiceClient client;
        private List<ServerUser> _users;
        ServerUser user;
        string[] arrFaculties = new string[9];
        List<ServerUser> iteratedList;

        public FormStudents()
        {
            client = new AppServiceClient();
            _users = AppService.MakeList();
            InitializeComponent();
            dgvStudents.ReadOnly = true;
            CreateForm.StudentUpdated += CreateM;
            EditForm.StudentUpdated += EditM;

        }

        private List<ServerUser> UpdateTbl(List<ServerUser> users)
        {
            List<ServerUser> users2 = new List<ServerUser>();
            if (users.Count > 0)
            {
                foreach (var user in users)
                {
                    users2.Add(user);
                }
            }
            else
            {
                MessageBox.Show("users not found");
            }
            return users2;

        }

        private void btnSearchAll_Click(object sender, EventArgs e)
        {
            _users = AppService.MakeList();
            Iterate(_users);
            dgvStudents.DataSource = UpdateTbl(iteratedList);
            lblUpdate.Visible = false;
        }
        
        private List<ServerUser> Iterate(List<ServerUser> us)
        {
            iteratedList = new List<ServerUser>();

            iteratedList = us.OrderBy(x => x.Id).ToList<ServerUser>();

            return iteratedList;
        }

        public ServerUser[] ConvertToUsersArr()
        {
            ServerUser[] massiv = AppService.Users.ToArray<ServerUser>();
            return massiv;
        }

        private void btnSearchId_Click(object sender, EventArgs e)
        {
            ServerUser serU = new ServerUser();
            List<ServerUser> lU = new List<ServerUser>();

            try
            {
                serU = client.GetInfoAboutUsersByNum(int.Parse(tbId.Text), ConvertToUsersArr());

                lU.Add(serU);

                dgvStudents.DataSource = lU;
            }
            catch (Exception)
            {
                MessageBox.Show("incorrectly filled fields");

            }

            ClearFields();
        }


        private void ClearFields()
        {
            tbName.Clear();
            tbSecName.Clear();
            tbNameOfFam.Clear();
            tbId.Clear();
            tbAge.Clear();
            tbCourse.Clear();
        }

        private void btnSearchName_Click(object sender, EventArgs e)
        {
            ServerUser serU = new ServerUser();
            List<ServerUser> lU = new List<ServerUser>();

            serU = client.ShowInfoAboutUsersByName(tbName.Text, ConvertToUsersArr());

            if (serU != null)
            {
                lU.Add(serU);

                dgvStudents.DataSource = lU;
            }
            else
            {
                MessageBox.Show("incorrectly filled fields");
            }

            ClearFields();
        }

        private void btgSearchAge_Click(object sender, EventArgs e)
        {
            ServerUser[] lU;
            try
            {
                dgvStudents.DataSource = lU = client.GetInfoAboutUsersByAge(int.Parse(tbAge.Text), ConvertToUsersArr());

            }
            catch (Exception)
            {
                MessageBox.Show("incorrectly filled fields");
            }
            ClearFields();
        }

        private void btnSearchCourse_Click(object sender, EventArgs e)
        {
            ServerUser serU = new ServerUser();
            ServerUser[] lU;
            try
            {
                dgvStudents.DataSource = lU = (client.GetInfoAboutUsersByCourse(int.Parse(tbCourse.Text), ConvertToUsersArr()));
            }
            catch (Exception)
            {
                MessageBox.Show("incorrectly filled fields");
            }
            ClearFields();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ServerUser serU = new ServerUser();
            ServerUser[] lU;
            try
            {
                dgvStudents.DataSource = lU = client.GetInfoAboutUsersByFaculty(comboBoxFac.SelectedItem.ToString(), ConvertToUsersArr());
            }
            catch (Exception)
            {
                MessageBox.Show("incorrectly filled fields");
            }
            ClearFields();
        }

        private void FormStudents_Load(object sender, EventArgs e)
        {
            comboBoxFac.DataSource = AppService.ShowFaculties(ConvertToUsersArr());
        }

        private void btnGoToCreate_Click(object sender, EventArgs e)
        {
            arrFaculties = client.ShowFaculties(ConvertToUsersArr());
            CreateForm dialog = new CreateForm(arrFaculties);
            dialog.ShowDialog(this);
            lblUpdate.Visible = true;
            
        }

        private void dgvStudents_SelectionChanged(object sender, EventArgs e)
        {
            btnEdit.Visible = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var userId = this.dgvStudents.SelectedCells[0].RowIndex + 1;
            user = _users.FirstOrDefault(x => x.Id == userId);
            arrFaculties = client.ShowFaculties(ConvertToUsersArr());
            EditForm editForm = new EditForm(user, arrFaculties);
            editForm.ShowDialog(this);
            lblUpdate.Visible = true;

        }

        public void EditM(ServerUser user, ServerUser newUser)
        {
            client.Edit(user.Id, newUser.Name, newUser.SecondName, newUser.NameOfFamily, newUser.Faculty, newUser.Age, newUser.Course);
        }

        public void CreateM(ServerUser newUser)
        {
            client.Save(newUser.Id, newUser.Name, newUser.SecondName, newUser.NameOfFamily, newUser.Faculty, newUser.Age, newUser.Course);
        }
    }
}