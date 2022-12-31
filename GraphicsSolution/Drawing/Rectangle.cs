namespace Drawing;

public class Rectangle:Shapes,IPrintable{

      private Point StartPoint{get;set;}
      private Point EndPoint{get;set;}

      public Rectangle()
      {
        this.StartPoint=new Point(0,0);
        this.EndPoint=new Point(0,0);
      }

      public Rectangle(Point p1,Point p2)
      {
        this.StartPoint=p1;
        this.EndPoint=p2;
      }
     
     //draw method of shapes
      public override void Draw()
      {
        Type t=this.GetType();
        Console.WriteLine("Type is: "+t);
        Console.WriteLine("[ "+this.StartPoint+" ,"+this.EndPoint+" ,Width: "+this.Width+" ,Color: "+this.Color);
      }

    //Interface Method
      public void Print()
      {
        Console.WriteLine("Printing Method");
          Type t=this.GetType();
        Console.WriteLine("Type is: "+t);
        Console.WriteLine("[ "+this.StartPoint+" ,"+this.EndPoint+" ,Width: "+this.Width+" ,Color: "+this.Color+" ]");

      }

}