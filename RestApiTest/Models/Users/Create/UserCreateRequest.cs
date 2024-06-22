using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApiTest.Models.Users.Create
{
    public class UserCreateRequest
    {
        public string name { get; set; }
        public string job { get; set; }
    }
}
