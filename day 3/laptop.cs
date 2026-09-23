public class Laptop : Computer
{
    public Laptop(){}
    public Laptop(int ram, int mem, string k, double w):base(ram, mem, k)
    {
        w=Weight;
    }
    public double Weight{get; set;}
    public void WeightCheck()
    {
      Console.WriteLine(Weight); 
    }
}