using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Management_System.Model
{
    public class BillModel
    {
        public int Id { get; set; }
        public int Quality { get; set; }
        public decimal Total { get; set; }
        public ItemModel Item { get; set; }
        public int ItemId { get; set; }
        public virtual CustomerModel Customer { get; set; }
        public int CustomerId { get; set; }
    }
}
