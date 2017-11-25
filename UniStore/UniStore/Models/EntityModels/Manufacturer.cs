using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace UniStore.Models.EntityModels
{
    public class Manufacturer
    {
        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        public string Name { get; set; }

        [DisplayName("Contact information")]
        public string ContactInformation { get; set; }
    }
}