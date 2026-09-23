using System.Security.Cryptography.X509Certificates;

public class Product
{
    public string? Name{get; set;}
    public double Price {get; set;}
    public Product(){}
    public Product(string n, double p)
    {
        Name=n;
        Price=p;
    }
}