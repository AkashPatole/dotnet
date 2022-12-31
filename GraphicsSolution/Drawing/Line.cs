namespace Drawing;

public class Line:Shapes,IPrintable{

    private Point StartPoint{get;set;}
    private Point EndPoint{get;set;}

    public Line(Point p1,Point p2)
    {
      this.StartPoint=p1;
      this.EndPoint=p2;
    }

    public override void Draw()
    {
        Type t=this.GetType();
        Console.WriteLine("Type: "+t);
        Console.WriteLine("[ startpoint: "+this.StartPoint+" ,endpoint: "+this.EndPoint+" ]");
    }

    public void Print()
    {   
        Console.WriteLine("Print Method: ");
        Type t=this.GetType();
        Console.WriteLine("Type: "+t);
        Console.WriteLine("[ startpoint: "+this.StartPoint+" ,endpoint: "+this.EndPoint+" ]");
    }
    
}