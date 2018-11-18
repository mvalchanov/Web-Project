using System;
using System.Collections.Generic;
using System.Text;

namespace WebProject.Models.UserModels
{
    public class ProductInfo
    {
        public string BasicMeasure { get; set; } //TODO Check
        public int Ration { get; set; }
        public string AdditionalMeasure { get; set; }
        public int MinimumQuantity { get; set; }
        public int NominalQuantity { get; set; }
        public string Type { get; set; } //TODO Check
        public string VatGroup { get; set; } //TODO Check
    }
}
