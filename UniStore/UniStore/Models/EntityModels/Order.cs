using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace UniStore.Models.EntityModels
{
    using UniStore.Models.Enums;
    public class Order
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        public virtual User User { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public virtual List<Purchase> Purchases { get; set; } = new List<Purchase>();

        [Required]
        [MinLength(15, ErrorMessage = "{0} must be at least {1} symbols long!")]
        public string DeliveryAddress { get; set; }

        public OrderStatus OrderStatus { get; set; }

        public decimal Total => this.Purchases.Sum(p => p.Value);
    }
}