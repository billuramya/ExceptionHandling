using System;

class MYExceptions : Exception
{
    public override string Message
    {
        get
        {
            return " iam from myexception class";
        }
    }
}

class Program
{
    public static void Main(string[] args)
    {
        try {
            int a, b;
            Console.WriteLine("enter the a value");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the b value");
            b = int.Parse(Console.ReadLine());
            
            if (b==0)
            {
                throw new MYExceptions();
            }
        }
        catch(MYExceptions ex) {
            Console.WriteLine(ex.Message);
        }
        finally 
        {
            Console.WriteLine("this is final");
        }
}
}