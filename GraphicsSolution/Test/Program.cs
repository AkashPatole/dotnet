using Drawing;
using System.Collections.Generic;

Console.WriteLine("Enter Point X: ");
int x=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Point Y: ");
int y=Convert.ToInt32(Console.ReadLine());
Point p1=new Point(x,y);

Console.WriteLine("Enter Point X: ");
int a=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Point Y: ");
int b=Convert.ToInt32(Console.ReadLine());
Point p2=new Point(a,b);

Shapes shape1=new Rectangle(p1,p2);
Shapes shape2=new Line(p1,p2);
Shapes shape3=new Circle(p1,26);

List<Shapes> shape=new List<Shapes>();

shape.Add(shape1);
shape.Add(shape2);
shape.Add(shape3);

foreach (Shapes s in shape)
{
    Console.WriteLine("Draw Method: ");
    s.Draw();
     IPrintable obj= (IPrintable)s;
    obj.Print();
   
}

// shape1.Print();
