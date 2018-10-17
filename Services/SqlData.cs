using System;
using System.Collections.Generic;
using System.Linq;
using MySql.Data.MySqlClient;
using react_test_app.Models;

namespace react_test_app.Services
{
    public class SqlData
    {
        public List<Contact> GetUsers(){
            
            // Connect to the DB using EF DBContext
            using (var context = new UserInformationContext())
            {
                List<Contact> contacts = context.Contact.ToList();
                return contacts;
            }
        }
    }
}
