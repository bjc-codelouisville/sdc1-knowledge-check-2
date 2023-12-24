using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sdc1_knowledge_check_2.Models
{
    internal class Food : Item
    {
        //public double Amount { get; set; }
        //public string AmountType { get; set; }
        public string UPC { get; set; }
        //public bool KeepOnHand { get; set; }
        //public int KeepOnHandQty { get; set; }
        //public string PreferredVendor { get; set; }
        public decimal Price { get; set; }
        //public bool Taxable { get; set; }
    }
}
