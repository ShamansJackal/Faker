using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker.Tests.TestClasses
{
    public class UserWithCtors
    {
        public int id { get; set; }
        public string name { get; set; }
        public DateTime createdAt { get; set; }

        public string password;

        public UserWithCtors(int id)
        {
            this.id = id;
        }

        public UserWithCtors(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
