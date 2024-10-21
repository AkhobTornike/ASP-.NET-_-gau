using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Xml.Linq;

namespace Lecture_3.Models
{
    public class UserList
    {
        public static List<User> UsersList = new List<User>() 
        { 
            new User 
            { Id = 0,
              Name = "admin",
              Email = "admin@gmail.com",
              Password = "123123123",
              IsAdmin = true,
            },
            new User
            { Id = 1,
              Name = "Toko",
              Email = "toko@gmail.com",
              Password = "toko1212",
              IsAdmin = false,
            },
        };
    }
}