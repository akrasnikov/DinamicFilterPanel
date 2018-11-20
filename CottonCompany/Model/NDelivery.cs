using System;
using System.Collections.Generic;

namespace CottonCompany.Model
{
    public partial class NDelivery
    {
        public int Deliveryid { get; set; }
        public int Locationid { get; set; }
        public int Personid { get; set; }
        public int Productid { get; set; }
        public int Quantity { get; set; }
        public DateTime? Deliverydate { get; set; }
        public string Remark { get; set; }
    }
}
