using System;
using System.Collections.Generic;
using System.Linq;
using reactApp.Models;
using Newtonsoft.Json;

using Newtonsoft.Json.Linq;

namespace reactApp.Services
{
    public class SqlData
    {
        UserInformationContext users = new UserInformationContext();
        //var context = new UserInformationContext()
        public List<Contact> GetUsers(){
            
            // Connect to the DB using EF DBContext

            List<Contact> contacts = users.Contact.ToList();
                return contacts;
            
        }


        //updated ID to include password
        public void Signup(string body){
            

            var m = JsonConvert.DeserializeObject<Contact>(body);
            Contact user = new Contact();
            user.Email = m.Email;
            user.Name = m.Name;
            user.Id = m.Id;


            //insert new User
            users.Add(user);
            users.SaveChanges();
        }
    }
}
