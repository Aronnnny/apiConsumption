using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apiConsumption.Models
{
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public Address Address { get; set; }
    }
}
