using Membership;
using HR;

Console.WriteLine("----------WElcome--------------");
Console.WriteLine("Enter Email");
string? email=Console.ReadLine();
Console.WriteLine("Enter password");
string? password=Console.ReadLine();

if(AuthManager.Validate(email,password))
{
    Console.WriteLine("*******WelCome User*********");
    Employee emp=new SalesManager();
    emp.Dowork();
    Console.WriteLine(emp);
    float salary=emp.ComputeSalary();
    Console.WriteLine("Total Salary is: "+salary);
}
else
{
    Console.WriteLine("Invalid User");
}
Console.WriteLine("Thank you for visiting");

