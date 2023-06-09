
using Microsoft.AspNetCore.Mvc.RazorPages;

public class ContactRequestModel : PageModel{
    public string UsedId {get;set;} = "XuanThuLAb";

    private readonly ILogger<ContactRequestModel> _logger;
    public ContactRequestModel(ILogger<ContactRequestModel> logger){
        _logger = logger;
        _logger.LogInformation("Init contact ...");
        Console.WriteLine("Init contact...");
    }

    public double Tong(double a, double b){
        return a + b;
    }
}