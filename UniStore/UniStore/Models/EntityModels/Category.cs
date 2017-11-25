using System.Collections.Generic;

namespace UniStore.Models.EntityModels
{
    public class Category:BaseCategory
    {
        public int? DepartmentId { get; set; }

        public virtual Department Department { get; set; }

        public virtual List<SubCategory> SubCategories { get; set; } = new List<SubCategory>();
    }
}