using System.Collections.Generic;

namespace UniStore.Models.EntityModels
{
    public class Department : BaseCategory
    {
        public virtual List<Category> Categories { get; set; } = new List<Category>();
    }
}