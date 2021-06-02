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

    [DataContract]
    public partial class AppService : IAppService
    {
        public List<ServerUser> Users;

        private static T CreateItemFromRow<T>(DataRow row, IList<PropertyInfo> properties) where T : new()
        {
            T item = new T();
            foreach (var property in properties)
            {
                if (property.PropertyType == typeof(System.DayOfWeek))
                {
                    DayOfWeek day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), row[property.Name].ToString());
                    property.SetValue(item, day, null);
                }
                else
                {
                    if (row[property.Name] == DBNull.Value)
                        property.SetValue(item, null, null);
                    else
                        property.SetValue(item, row[property.Name], null);
                }
            }
            return item;
        }

        public ServerUser[] GetInfoAboutUsersByAge(int age, ServerUser[] users)
        {
            return users.Where(u => u.Age == age).ToArray();
        }

        public ServerUser[] GetInfoAboutUsersByCourse(int course, ServerUser[] users)
        {
            return users.Where(u => u.Course == course).ToArray();
        }

        public ServerUser[] GetInfoAboutUsersByFaculty(string faculty, ServerUser[] users)
        {
            return users.Where(u => u.Faculty == faculty).ToArray();
        }

        public ServerUser GetInfoAboutUsersByNum(int num, ServerUser[] users)
        {
            return users.FirstOrDefault(n => n.Id == num);
        }

        public ServerUser ShowInfoAboutUsersByName(string name, ServerUser[] users)
        {
            return users.FirstOrDefault(n => n.Name == name); 
        }

        public List<string> ShowFaculties(ServerUser[] users)
        {
            List<string> Faculies = new List<string>();
            foreach (var item in users)
            {
                if (!Faculies.Contains(item.Faculty))
                {
                    Faculies.Add(item.Faculty);
                }
            }
            return Faculies;
        }
    }
}
