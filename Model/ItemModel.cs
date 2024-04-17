using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Management_System.Model
{
    public class ItemModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }
        public string Manufacturer { get; set; }
        public virtual CategoryModel Category { get; set; }
        public int CategoryId { get; set; }





    }
}
