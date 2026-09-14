using System.Threading.Channels;

Base obj = new Derived();
obj.Show();
public class Base
{
    public Base() => Console.WriteLine("Base constructor");
    public virtual void Show() => Console.WriteLine("Base Show");
}

public class Derived : Base
{
    public Derived() => Console.WriteLine("Derived constructor");
}




