using System.Security.Cryptography.X509Certificates;

class Gadjets 
{
    List<Computer> computers = new List<Computer>();
    
    public void AddGadject(Computer computer)
    {
        computers.Add(computer);
    }
    public void ShowlistGadjecs()
    {
        System.Console.WriteLine(computers);
    }
    
}