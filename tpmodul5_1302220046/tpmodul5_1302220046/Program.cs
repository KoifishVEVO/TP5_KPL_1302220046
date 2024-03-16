// See https://aka.ms/new-console-template for more information


public class HaloGeneric
{

    public void SapaUser<thing>(thing x)
    {
        Console.WriteLine("Halo User " + x);
    }
}


class Program
{
    static void Main()
    {

        HaloGeneric halo = new HaloGeneric();

 
        halo.SapaUser(5.65);
    }
}