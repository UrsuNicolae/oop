class BaseClass
{
    protected string P => "Base";
}

class DerivedClass : BaseClass
{
    protected new string P => "Derived";

    public void Test()
    {
        Console.WriteLine(base.P);
        Console.WriteLine(P);
    }
}

sealed class MoreDerivedClass : DerivedClass
{

}
