public class Smarthone:Computer
{
    public double Selfier{get; set;}
    public Smarthone(){}
    public Smarthone(int ram, int mem, string k, double s):base(ram, mem, k)
    {
        Selfier=s;
    }
    public void GetSelfie()
    {
        System.Console.WriteLine(Selfier);
    }
}