using System.Collections.Generic;

namespace Shop_Management_System.Model
{
    public class CategoryModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual List<ItemModel> Items { get; set; }
    }
}
