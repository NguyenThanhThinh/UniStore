using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniStore.Models.EntityModels
{
    public class ShoppingCart
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        public virtual List<Purchase> Purchases { get; set; }

        public decimal Total => this.Purchases.Sum(p => p.Value);

        public string DeliveryAddress { get; set; }
    }
}