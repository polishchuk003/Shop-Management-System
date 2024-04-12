using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Management_System.Model
{
    public class Bill
    {
        public int Id { get; set; }
        public Item Item { get; set; }
        public int Quality { get; set; }
        public Customer Customer { get; set; }
        public decimal Total { get; set; }
    }
}
