using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAppBeta
{
     class User
    {
        public int id { get; set; }
        public int number_phone;
        public string names;
        public string password;

        public User() { }
        public User(int number_phone, string names, string password)
        {
        this.number_phone = number_phone;
            this.names = names;
            this.password = password;
        }
    }
}
