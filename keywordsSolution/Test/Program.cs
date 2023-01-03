using HR;
using Library;
// Person p=new Person();
//  int x=25;
//  int y=50;

// p.Swap(ref x,ref y);
// Console.WriteLine("X = "+x);
// Console.WriteLine("Y = "+y);

// double area=0;
// double circumference=0;
// double radius=25;
// Console.WriteLine("Area = "+area+"  Circum: "+circumference);
// p.Calculate(radius,out area,out circumference);
// Console.WriteLine("Area = "+area+"  Circum: "+circumference);
// p.Display(1,2,2,1);
// p.Display(9,9,9);
// Console.WriteLine("--------------------");
// // Person q=new Person(2);
// // q.Display(9,9,9);
Person q=Person.Createinstance();
q.Display(2,3);
Person p=Person.Createinstance();
p.Display(1,2);

//One Way Of initializing 2d array
int [,] arr={
    {10,20,30},
    {40,50,60}
};

int value=arr[0,2];
Console.WriteLine("Value= "+value+"  "+arr[1,1]);
Console.WriteLine("----------------------------");

//another Way of initializing multidimentional array
int [,] arr2=new int[2,2] {{1,2},
                           {3,4}};
 int result=arr2[0,1];
Console.WriteLine("Value= "+result+"  "+arr2[1,1]);

//array of arrays
int [][] jaggedarry=new int [2][];
jaggedarry[0]=new int[]{10,20,30,40};
jaggedarry[1]=new int []{50,60,10,20};
Console.WriteLine(jaggedarry[0][1]);

int [][] jarray={
    new int []{10,20,30,40},
    new int [] {50,60,10,20}
};
Console.WriteLine(jarray[1][2]);
Console.WriteLine("Length= "+jarray.Length);
Console.WriteLine("--------------------");

//indexer
Book b=new Book();

Console.WriteLine("Book id: "+b[0]);


