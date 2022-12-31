namespace Drawing;

public class Circle:Shapes,IPrintable{
    private Point Center{get;set;}
    private int Radius{get;set;}

    public Circle(Point p1,int radius)
    {
        this.Center=p1;
        this.Radius=radius;
    }

    public override void Draw()
    {
        Type t=this.GetType();
        Console.WriteLine("Type is: "+t);
        Console.WriteLine("[ Center is: "+this.Center+" ,Radius: "+this.Radius);
    }

    public void Print()
    {
        Console.WriteLine("Print Method: ");
        Type t=this.GetType(); 
        Console.WriteLine("Type is: "+t);
        Console.WriteLine("[ Center is: "+this.Center+" ,Radius: "+this.Radius+" ]");
    }
}