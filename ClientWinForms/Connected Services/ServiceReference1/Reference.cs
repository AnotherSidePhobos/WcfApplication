﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientWinForms.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IAppService")]
    public interface IAppService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAppService/ShowFaculties", ReplyAction="http://tempuri.org/IAppService/ShowFacultiesResponse")]
        string[] ShowFaculties(WcfApplication.ServerUser[] users);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAppService/ShowFaculties", ReplyAction="http://tempuri.org/IAppService/ShowFacultiesResponse")]
        System.Threading.Tasks.Task<string[]> ShowFacultiesAsync(WcfApplication.ServerUser[] users);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAppService/DeleteId", ReplyAction="http://tempuri.org/IAppService/DeleteIdResponse")]
        WcfApplication.ServerUser DeleteId(int num, WcfApplication.ServerUser[] users);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAppService/DeleteId", ReplyAction="http://tempuri.org/IAppService/DeleteIdResponse")]
        System.Threading.Tasks.Task<WcfApplication.ServerUser> DeleteIdAsync(int num, WcfApplication.ServerUser[] users);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAppService/ShowInfoAboutUsersByName", ReplyAction="http://tempuri.org/IAppService/ShowInfoAboutUsersByNameResponse")]
        WcfApplication.ServerUser ShowInfoAboutUsersByName(string name, WcfApplication.ServerUser[] users);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAppService/ShowInfoAboutUsersByName", ReplyAction="http://tempuri.org/IAppService/ShowInfoAboutUsersByNameResponse")]
        System.Threading.Tasks.Task<WcfApplication.ServerUser> ShowInfoAboutUsersByNameAsync(string name, WcfApplication.ServerUser[] users);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAppService/GetInfoAboutUsersByNum", ReplyAction="http://tempuri.org/IAppService/GetInfoAboutUsersByNumResponse")]
        WcfApplication.ServerUser GetInfoAboutUsersByNum(int num, WcfApplication.ServerUser[] users);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAppService/GetInfoAboutUsersByNum", ReplyAction="http://tempuri.org/IAppService/GetInfoAboutUsersByNumResponse")]
        System.Threading.Tasks.Task<WcfApplication.ServerUser> GetInfoAboutUsersByNumAsync(int num, WcfApplication.ServerUser[] users);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAppService/Edit", ReplyAction="http://tempuri.org/IAppService/EditResponse")]
        void Edit(int id, string name, string secondName, string nameOfFamily, string faculty, int age, int course);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAppService/Edit", ReplyAction="http://tempuri.org/IAppService/EditResponse")]
        System.Threading.Tasks.Task EditAsync(int id, string name, string secondName, string nameOfFamily, string faculty, int age, int course);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAppService/GetInfoAboutUsersByAge", ReplyAction="http://tempuri.org/IAppService/GetInfoAboutUsersByAgeResponse")]
        WcfApplication.ServerUser[] GetInfoAboutUsersByAge(int age, WcfApplication.ServerUser[] users);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAppService/GetInfoAboutUsersByAge", ReplyAction="http://tempuri.org/IAppService/GetInfoAboutUsersByAgeResponse")]
        System.Threading.Tasks.Task<WcfApplication.ServerUser[]> GetInfoAboutUsersByAgeAsync(int age, WcfApplication.ServerUser[] users);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAppService/GetInfoAboutUsersByCourse", ReplyAction="http://tempuri.org/IAppService/GetInfoAboutUsersByCourseResponse")]
        WcfApplication.ServerUser[] GetInfoAboutUsersByCourse(int course, WcfApplication.ServerUser[] users);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAppService/GetInfoAboutUsersByCourse", ReplyAction="http://tempuri.org/IAppService/GetInfoAboutUsersByCourseResponse")]
        System.Threading.Tasks.Task<WcfApplication.ServerUser[]> GetInfoAboutUsersByCourseAsync(int course, WcfApplication.ServerUser[] users);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAppService/GetInfoAboutUsersByFaculty", ReplyAction="http://tempuri.org/IAppService/GetInfoAboutUsersByFacultyResponse")]
        WcfApplication.ServerUser[] GetInfoAboutUsersByFaculty(string faculty, WcfApplication.ServerUser[] users);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAppService/GetInfoAboutUsersByFaculty", ReplyAction="http://tempuri.org/IAppService/GetInfoAboutUsersByFacultyResponse")]
        System.Threading.Tasks.Task<WcfApplication.ServerUser[]> GetInfoAboutUsersByFacultyAsync(string faculty, WcfApplication.ServerUser[] users);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAppService/Save", ReplyAction="http://tempuri.org/IAppService/SaveResponse")]
        void Save(int countUsers, string name, string secondName, string nameOfFamily, string faculty, int age, int course);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAppService/Save", ReplyAction="http://tempuri.org/IAppService/SaveResponse")]
        System.Threading.Tasks.Task SaveAsync(int countUsers, string name, string secondName, string nameOfFamily, string faculty, int age, int course);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAppServiceChannel : ClientWinForms.ServiceReference1.IAppService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AppServiceClient : System.ServiceModel.ClientBase<ClientWinForms.ServiceReference1.IAppService>, ClientWinForms.ServiceReference1.IAppService {
        
        public AppServiceClient() {
        }
        
        public AppServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AppServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AppServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AppServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string[] ShowFaculties(WcfApplication.ServerUser[] users) {
            return base.Channel.ShowFaculties(users);
        }
        
        public System.Threading.Tasks.Task<string[]> ShowFacultiesAsync(WcfApplication.ServerUser[] users) {
            return base.Channel.ShowFacultiesAsync(users);
        }
        
        public WcfApplication.ServerUser DeleteId(int num, WcfApplication.ServerUser[] users) {
            return base.Channel.DeleteId(num, users);
        }
        
        public System.Threading.Tasks.Task<WcfApplication.ServerUser> DeleteIdAsync(int num, WcfApplication.ServerUser[] users) {
            return base.Channel.DeleteIdAsync(num, users);
        }
        
        public WcfApplication.ServerUser ShowInfoAboutUsersByName(string name, WcfApplication.ServerUser[] users) {
            return base.Channel.ShowInfoAboutUsersByName(name, users);
        }
        
        public System.Threading.Tasks.Task<WcfApplication.ServerUser> ShowInfoAboutUsersByNameAsync(string name, WcfApplication.ServerUser[] users) {
            return base.Channel.ShowInfoAboutUsersByNameAsync(name, users);
        }
        
        public WcfApplication.ServerUser GetInfoAboutUsersByNum(int num, WcfApplication.ServerUser[] users) {
            return base.Channel.GetInfoAboutUsersByNum(num, users);
        }
        
        public System.Threading.Tasks.Task<WcfApplication.ServerUser> GetInfoAboutUsersByNumAsync(int num, WcfApplication.ServerUser[] users) {
            return base.Channel.GetInfoAboutUsersByNumAsync(num, users);
        }
        
        public void Edit(int id, string name, string secondName, string nameOfFamily, string faculty, int age, int course) {
            base.Channel.Edit(id, name, secondName, nameOfFamily, faculty, age, course);
        }
        
        public System.Threading.Tasks.Task EditAsync(int id, string name, string secondName, string nameOfFamily, string faculty, int age, int course) {
            return base.Channel.EditAsync(id, name, secondName, nameOfFamily, faculty, age, course);
        }
        
        public WcfApplication.ServerUser[] GetInfoAboutUsersByAge(int age, WcfApplication.ServerUser[] users) {
            return base.Channel.GetInfoAboutUsersByAge(age, users);
        }
        
        public System.Threading.Tasks.Task<WcfApplication.ServerUser[]> GetInfoAboutUsersByAgeAsync(int age, WcfApplication.ServerUser[] users) {
            return base.Channel.GetInfoAboutUsersByAgeAsync(age, users);
        }
        
        public WcfApplication.ServerUser[] GetInfoAboutUsersByCourse(int course, WcfApplication.ServerUser[] users) {
            return base.Channel.GetInfoAboutUsersByCourse(course, users);
        }
        
        public System.Threading.Tasks.Task<WcfApplication.ServerUser[]> GetInfoAboutUsersByCourseAsync(int course, WcfApplication.ServerUser[] users) {
            return base.Channel.GetInfoAboutUsersByCourseAsync(course, users);
        }
        
        public WcfApplication.ServerUser[] GetInfoAboutUsersByFaculty(string faculty, WcfApplication.ServerUser[] users) {
            return base.Channel.GetInfoAboutUsersByFaculty(faculty, users);
        }
        
        public System.Threading.Tasks.Task<WcfApplication.ServerUser[]> GetInfoAboutUsersByFacultyAsync(string faculty, WcfApplication.ServerUser[] users) {
            return base.Channel.GetInfoAboutUsersByFacultyAsync(faculty, users);
        }
        
        public void Save(int countUsers, string name, string secondName, string nameOfFamily, string faculty, int age, int course) {
            base.Channel.Save(countUsers, name, secondName, nameOfFamily, faculty, age, course);
        }
        
        public System.Threading.Tasks.Task SaveAsync(int countUsers, string name, string secondName, string nameOfFamily, string faculty, int age, int course) {
            return base.Channel.SaveAsync(countUsers, name, secondName, nameOfFamily, faculty, age, course);
        }
    }
}
