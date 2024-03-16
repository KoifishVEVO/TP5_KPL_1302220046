// See https://aka.ms/new-console-template for more information


public class HaloGeneric
{

    public void SapaUser<thing>(thing x)
    {
        Console.WriteLine("Halo User " + x);
    }
}

public class DataGeneric<T>
{
    private T data;

    public DataGeneric(T data)
    {
        this.data = data;
    }

    public void PrintData()
    {
        Console.WriteLine("Data yang tersimpan adalah: " + data);
    }

}

class Program
{
    static void Main()
    {
        
        HaloGeneric halo = new HaloGeneric();

        
        halo.SapaUser(5.65);


        DataGeneric<string> data = new DataGeneric<string>("1302220046");

        data.PrintData();
    }
}