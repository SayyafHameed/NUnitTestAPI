using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApiTest.Models.Users.Create
{
    public class UserCreateResponse
    {
        public string id { get; set; }
        public DateTime createdAt { get; set; }
    }
}
