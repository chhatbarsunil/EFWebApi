using System;
using System.Collections.Generic;

#nullable disable

namespace EFWebApi.Models
{
    public partial class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public long CardNum { get; set; }
        public int CardCvc { get; set; }
        public string CardExpMonth { get; set; }
        public string CardExpYear { get; set; }
        public string ItemName { get; set; }
        public string ItemNumber { get; set; }
        public float ItemPrice { get; set; }
        public string ItemPriceCurrency { get; set; }
        public string PaidAmount { get; set; }
        public string PaidAmountCurrency { get; set; }
        public string TxnId { get; set; }
        public string PaymentStatus { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}
