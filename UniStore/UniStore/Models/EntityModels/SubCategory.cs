using System.Collections.Generic;

namespace UniStore.Models.EntityModels
{
    public class SubCategory : BaseCategory
    {
        public int? CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public virtual List<Product> Products { get; set; } = new List<Product>();
    }
}