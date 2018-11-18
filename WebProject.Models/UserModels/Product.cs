using System;
using System.Collections.Generic;
using System.Text;

namespace WebProject.Models.UserModels
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Barcode { get; set; } //TODO Check
        public string CatalogueNumber { get; set; } //TODO check
        public string Description { get; set; }
        public string State { get; set; } //TODO Check list()?
    }
}
