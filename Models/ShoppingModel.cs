namespace MVC1.Models;

public class ShoppingViewModel
{
    public class order
    {
        public int? OrderID { get; set; }
        public int? CustomerID { get; set; }
        public DateTime? OrderDate { get; set; }
        public string? ShippingAddress { get; set; }
        public string? BillingAddress { get; set; }
        public Double? Total { get; set; }
    }

        
    
}