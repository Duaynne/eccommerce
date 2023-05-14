namespace MVC1.Models;

public class ShoppingViewModel
{
    public class order
    {
        public int? OrderID { get; set; }
        public DateTime? OrderDate { get; set; }
        public string? ShippingAddress { get; set; }
        public string? BillingAddress { get; set; }
        public Double? Total { get; set; }
    }

    public class order_details
    {
        public int? OrderDetailsID { get; set; }
        public int? OrderID { get; set; }
        public int? ProductID { get; set; }
        public int? Qty { get; set; }
        public double? Price { get; set; }
    }   

    public class transactions
    {
        public int? transactionID { get; set; }
        public int? OrderID { get; set; }
        public string? PaymentMethod { get; set; }
        public double? PaymentAmount { get; set; }
        public DateTime? PaymentDate { get; set; }
    } 
    
}