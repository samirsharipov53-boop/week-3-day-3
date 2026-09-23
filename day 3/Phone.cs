
public class Phone: Product
{
    int Memory {get; set;}
    int Ram{get; set;}
    string Model{get; set;}
    public Phone(){}
   
  public Phone(string nam, double pri, int ram,int mem, string mod) : base(nam, pri)
    {
        Memory=mem;
        Ram=ram;
        Model=mod;
    }
}