public class Computer
{
    public int Ram{get; set;}
    public int Memory{get; set;}
    public string? Keybord{get; set;}

    public Computer(){}
    public Computer(int ram, int mem, string k)
    {
        Ram=ram;
        Memory=mem;
        Keybord=k;
    }
    public void AddRam(int r)
    {
        Ram=r+Ram;
    }
    public void AddMemory(int r)
    {
        Memory=r+Memory;
    }
}