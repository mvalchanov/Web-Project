using System;
using System.Collections.Generic;
using System.Text;

namespace WebProject.Models.UserModels
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Password { get; set; }
        public Roles Role { get; set; }
        public string Location { get; set; }                //TODO Check location List
        public string UsedCompany { get; set; }             //TODO Check list different companies
        public string CardNumber { get; set; }
        public string State { get; set; }                   //TODO Check list States
    }
}
