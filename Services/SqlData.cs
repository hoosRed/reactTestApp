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
            List<Contact> list = new List<Contact>();
            // Connect to the DB using EF DBContext
            using (var context = new UserInformationContext())
            {

                //Contact user = context.Contact.Where(s => s.Name == "Tyler").FirstOrDefault();
                List<Contact> contacts = context.Contact.ToList();
                //list.Add(user);


                return contacts;
            }
        }
    }
}
