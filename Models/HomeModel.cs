namespace MVC1.Models;

public class HomeModel
{
    public string? RequestId { get; set; }

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}


/* Login register */
public class Login
{
    public int? LoginID { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? EmailID { get; set; }
    public string? Password { get; set; }
    public string? PasswordConfirm { get; set; }
  
}


/* Cart */

public class Cart
{
    public int? ProductID { get; set; }
    public string? ProductName { get; set; }
    public string? ProductDescription { get; set; }
    public double? Price { get; set; }
    public int? Qty { get; set; }

}