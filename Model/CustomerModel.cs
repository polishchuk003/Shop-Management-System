using System.Collections.Generic;

namespace Shop_Management_System.Model
{
    public class CustomerModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public virtual List<BillModel> Bills { get; set; }


    }
}
