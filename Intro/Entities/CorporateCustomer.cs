namespace Intro.Entities;

public class CorporateCustomer:BaseCustomer 
{
    public int ID { get; set; }
    public string CustomerNumber { get; set; }
    public string Name { get; set; }
    public string TaxNumber { get; set; }
}
