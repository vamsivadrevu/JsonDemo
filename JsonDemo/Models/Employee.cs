using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using Newtonsoft.Json;

namespace JsonDemo.Models
{
    public class Employee
    {
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public string gender { get; set; }
        public string ip_address { get; set; }

        public List<Employee> DeserializeJson()
        {
            List<Employee> returnval = new List<Employee>();

            returnval = JsonConvert.DeserializeObject<List<Employee>>(File.ReadAllText(@"C:\Users\vamsi\Downloads\MOCK_DATA.json"));

            return returnval;

        }

    }
}