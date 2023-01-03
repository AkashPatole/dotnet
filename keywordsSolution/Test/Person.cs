namespace HR;

public sealed class Person{
    public int X{get;set;}
    public string? FirstName{get;set;}
    public string? LastName{get;set;}

    public static Person _ref=null;

    public static Person Createinstance()
    {
        if( _ref == null)
        {
            _ref=new Person();
        }
        return _ref;
    } 
    
    private Person()
    {
       Console.WriteLine("Ctr invoked");
    }

    public void Swap(ref int x,ref int y)
    {
        int temp=x;
        x=y;
        y=temp;
    }

    public void Calculate(double radius,out double area,out double circumference )
    {
        area=3.14*radius*radius;
        circumference=2*3.14*radius;
    }

    public void Display (params int [] sub)
    {
        foreach (int s in sub)
        {
            Console.WriteLine(s);
        }
    }
}