using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfApplication
{
    public class ServerUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SecondName { get; set; }
        public string NameOfFamily { get; set; }
        public string Faculty { get; set; }
        public int Age { get; set; }
        public int Course { get; set; }
    }
}