namespace MVC1.Models;

public class HomeModel
{
    public string? RequestId { get; set; }

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}

public class Login
{
    /* Login register */
    public int? LoginID { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? EmailID { get; set; }
    public string? Password { get; set; }
    public string? PasswordConfirm { get; set; }
  
}