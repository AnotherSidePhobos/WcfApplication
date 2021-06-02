using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ClientApp.ServiceReference1;
using WcfApplication;

namespace ClientApp
{
    public partial class MainWindow : Window
    {
        AppServiceClient client;
        AppService service = new AppService();
        public MainWindow()
        {
            this.WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            InitializeComponent();
            client = new AppServiceClient();
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            string Name = tbxNameOrid.Text;
            string SecondName = tbxSecondName.Text;
            string NameOfFamily = tbxNameOfFamily.Text;
            string Faculty = tbxFaculty.Text;
            string Age = tbxAge.Text;
            string Course = tbxCourse.Text;
            try
            {

                service.Users.Add(client.Save(service.Users.Count, Name, SecondName, NameOfFamily, Faculty, int.Parse(Age), int.Parse(Course)));
                ClearFields();
                usersTbl.ItemsSource = UpdateTbl(service.Users);
            }
            catch (Exception)
            {
                MessageBox.Show("incorrectly filled fields");
            }
        }

        private List<ServerUser> Iterate(List<ServerUser> us)
        {
            List<ServerUser> iteratedList = new List<ServerUser>();

            iteratedList = us.OrderBy(x => x.Id).ToList<ServerUser>();

            return iteratedList;
        }


        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            
            try
            {

                var userDe = service.Users.FirstOrDefault(u => u.Id == int.Parse(tbxIdForEdit.Text));


                string nameTmp = tbxNameOrid.Text;
                string secNameTmp = tbxSecondName.Text;
                string nameOfFamilyTmp = tbxNameOfFamily.Text;
                string facultyTmp = tbxFaculty.Text;
                int ageTmp = 0;
                bool age = int.TryParse(tbxAge.Text, out ageTmp);

                int courseTmp = 0;

                bool course = int.TryParse(tbxCourse.Text, out courseTmp);


                if (nameTmp == "")
                {
                    nameTmp = userDe.Name;
                }
                if (secNameTmp == "")
                {
                    secNameTmp = userDe.SecondName;
                }
                if (nameOfFamilyTmp == "")
                {
                    nameOfFamilyTmp = userDe.NameOfFamily;
                }
                if (facultyTmp == "")
                {
                    facultyTmp = userDe.Faculty;
                }
                if (!age)
                {
                    ageTmp = userDe.Age;
                }
                if (!course)
                {
                    courseTmp = userDe.Course;
                }

                var userTmp = client.Edit(int.Parse(tbxIdForEdit.Text), nameTmp, secNameTmp, nameOfFamilyTmp, facultyTmp, ageTmp, courseTmp);
                
                

                var userDel = service.Users.FirstOrDefault(u => u.Id == userTmp.Id);

                if (userDel != null)
                {
                    service.Users.Remove(userDel);
                }

                service.Users.Add(userTmp);

                usersTbl.ItemsSource = UpdateTbl(service.Users);
            }
            catch (Exception)
            {
                MessageBox.Show("incorrectly filled fields");
            }

            ClearFields();
            usersTbl.ItemsSource = Iterate(service.Users);

        }
        ServerUser userTmp;
        private void DeleteById_Click(object sender, RoutedEventArgs e)
        {
                userTmp = new ServerUser();
            try
            {

                userTmp = client.DeleteId(int.Parse(tbxIdForEdit.Text), ConvertToUsersArr());

                List<ServerUser> ListAfterDeleting = new List<ServerUser>();

                var user = service.Users.FirstOrDefault(u => u.Id == userTmp.Id);
                foreach (var item in service.Users)
                {
                    if (item != user)
                    {
                        ListAfterDeleting.Add(item);
                    }
                }

                service.Users.Clear();
                foreach (var item in ListAfterDeleting)
                {
                    service.Users.Add(item);
                }

                tbxIdForEdit.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("incorrectly filled fields");
            }
                       

            ClearFields();
            usersTbl.ItemsSource = UpdateTbl(service.Users);

            usersTbl.ItemsSource = Iterate(service.Users);

        }

        private ServerUser[] ConvertToUsersArr()
        {
            ServerUser[] massiv = service.Users.ToArray<ServerUser>();
            return massiv;
    

        }


        private void ShowById_Click(object sender, RoutedEventArgs e)
        {
            ServerUser serU = new ServerUser();
            List<ServerUser> lU = new List<ServerUser>();

            try
            {
                serU = client.GetInfoAboutUsersByNum(int.Parse(tbxNameOrid.Text), ConvertToUsersArr());

                lU.Add(serU);

                usersTbl.ItemsSource = lU;

            }
            catch (Exception)
            {
                MessageBox.Show("incorrectly filled fields");

            }

            ClearFields();
        }

        private void ShowByName_Click(object sender, RoutedEventArgs e)
        {
            ServerUser serU = new ServerUser();
            List<ServerUser> lU = new List<ServerUser>();
      
            serU = client.ShowInfoAboutUsersByName(tbxNameOrid.Text, ConvertToUsersArr());

            if (serU != null)
            {
                lU.Add(serU);

                usersTbl.ItemsSource = lU;
            }
            else
            {
                MessageBox.Show("incorrectly filled fields");
            }

            ClearFields();
        }

        private void ShowByAge_Click(object sender, RoutedEventArgs e)
        {
            ServerUser[] lU;
            try
            {
                usersTbl.ItemsSource = lU = client.GetInfoAboutUsersByAge(int.Parse(tbxAge.Text), ConvertToUsersArr());

            }
            catch (Exception)
            {
                MessageBox.Show("incorrectly filled fields");
            }
            ClearFields();
        }

        private void ShowByCourse_Click(object sender, RoutedEventArgs e)
        {
            ServerUser serU = new ServerUser();
            ServerUser[] lU;
            try
            {
                usersTbl.ItemsSource = lU = (client.GetInfoAboutUsersByCourse(int.Parse(tbxCourse.Text), ConvertToUsersArr()));
            }
            catch (Exception)
            {
                MessageBox.Show("incorrectly filled fields");
            }
            ClearFields();
        }

        private void ShowAllU_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                usersTbl.ItemsSource = UpdateTbl(service.Users);
            }
            catch (Exception)
            {
                MessageBox.Show("users not found");
            }
            ClearFields();
            
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


        private void ClearFields()
        {
            tbxIdForEdit.Clear();
            tbxNameOrid.Clear();
            tbxSecondName.Clear();
            tbxNameOfFamily.Clear();
            tbxFaculty.Clear();
            tbxAge.Clear();
            tbxCourse.Clear();
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            service.Users = service.MakeList();
            cmbFaculties.ItemsSource = service.ShowFaculties(ConvertToUsersArr());

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            usersTbl.ItemsSource = service.MakeList();
        }

        private void cmbFaculties_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ServerUser serU = new ServerUser();
            ServerUser[] lU;
            try
            {
                usersTbl.ItemsSource = lU =  client.GetInfoAboutUsersByFaculty(cmbFaculties.SelectedItem.ToString(), ConvertToUsersArr());
            }
            catch (Exception)
            {
                MessageBox.Show("incorrectly filled fields");
            }
            ClearFields();
        }

        private void tbxIdForEdit_GotFocus(object sender, RoutedEventArgs e)
        {
            if (tbxIdForEdit.Focus())
            {
                lbForEditing.Visibility = Visibility;
            }
        }

        private void tbxIdForEdit_LostFocus(object sender, RoutedEventArgs e)
        {
            lbForEditing.Visibility = Visibility.Hidden;
        }

        private void tbxNameOrid_GotFocus(object sender, RoutedEventArgs e)
        {
            if (tbxNameOrid.Focus())
            {
                lbForEditing2.Visibility = Visibility;
            }
        }

        private void tbxNameOrid_LostFocus(object sender, RoutedEventArgs e)
        {
            lbForEditing2.Visibility = Visibility.Hidden;
        }
    }
}
