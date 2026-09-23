public class Shop
{
    List<Product> products=new List<Product>();
    public void AddProduct(Product product)
    {
        products.Add(product);
    }
    public void PrintProduct()
    {
        System.Console.WriteLine(products);
    }
    public void Delete()
    {
        // products.Remove(products[1]);
        //masivi yagon elemetwa udalit mena misol ay index massiv
    }
}