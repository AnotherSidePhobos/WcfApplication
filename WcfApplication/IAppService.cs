using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfApplication
{
    [ServiceContract]
    public interface IAppService
    {

        [OperationContract]
        List<string> ShowFaculties(ServerUser[] users);

        [OperationContract]
        ServerUser ShowInfoAboutUsersByName(string name, ServerUser[] users);

        [OperationContract]
        ServerUser GetInfoAboutUsersByNum(int num, ServerUser[] users);

        [OperationContract]
        void Edit(int id, string name, string secondName, string nameOfFamily, string faculty, int age, int course);

        [OperationContract]
        ServerUser[] GetInfoAboutUsersByAge(int age, ServerUser[] users);

        [OperationContract]
        ServerUser[] GetInfoAboutUsersByCourse(int course, ServerUser[] users);

        [OperationContract]
        ServerUser[] GetInfoAboutUsersByFaculty(string faculty, ServerUser[] users);

        [OperationContract]
        void Save(int countUsers, string name, string secondName, string nameOfFamily, string faculty, int age, int course);

    }
}