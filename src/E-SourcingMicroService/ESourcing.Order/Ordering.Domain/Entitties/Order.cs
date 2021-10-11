using Ordering.Domain.Entitties.Base;
using System;

namespace Ordering.Domain.Entitties
{
    public class Order: Entity
    {
        public string AuctionId { get; set; }
        public string SellerUserName { get; set; }
        public string ProductId { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
