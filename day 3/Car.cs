public class Car : Product
{
    public string? Model{get; set;}
    public int Probeg {get; set;}
    public string? Fueltype{get; set;}
    public Car(){}
    public Car(string nam, double pri, string mod, int prob, string fuel):base(nam,pri){
        Model = mod;
        Fueltype=fuel;
        Probeg=prob;
        
    }

}