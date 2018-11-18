using System;
using System.Collections.Generic;
using System.Text;

namespace WebProject.Models.UserModels
{
    public class Client
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string UIC { get; set; }                         // TODO: check int?
        public string VatNumber { get; set; }
        public string State { get; set; }
    }
}
