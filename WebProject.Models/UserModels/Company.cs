using System;
using System.Collections.Generic;
using System.Text;

namespace WebProject.Models.UserModels
{
    public class Company
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string ContactName { get; set; }
        public string City { get; set; }                        //TODO Check List() Cities
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string UIC { get; set; }                         //TODO Check
        public string VatNumber { get; set; }                   //TODO CHECK
    }
}
