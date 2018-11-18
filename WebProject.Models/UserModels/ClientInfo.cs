using System;
using System.Collections.Generic;
using System.Text;

namespace WebProject.Models.UserModels
{
    public class ClientInfo
    {
        public string Email { get; set; }
        public string BankName { get; set; }
        public string BIC { get; set; } //TODO check int?
        public string Iban { get; set; }
        public string BankVatAcc { get; set; }
        public string PriceGroup { get; set; } //TODO check
        public int Discount { get; set; } //TODO check int nullable
        public string Type { get; set; }
        public string CardNumber { get; set; }
        public int PayTime { get; set; }

    }
}
