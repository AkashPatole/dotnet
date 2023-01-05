using Maths;

MathEngine m=new MathEngine();

int result=m.Addition(10,20);
Console.WriteLine("Addition= "+result);
result=m.Substraction(50,20);
Console.WriteLine("substraction= "+result);

result=m.Multiply(20,30);
Console.WriteLine("multiply= "+result);
Demo d=new Demo();
result=d.Divide(60,30);
Console.WriteLine("Divide= "+result);
