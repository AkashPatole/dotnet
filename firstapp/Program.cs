// See https://aka.ms/new-console-template for more information
using Banking;
using System.Collections.Generic;

Account acc1=new Account("Akash",99000,7852364);
Account acc2=new Account("Prathamesh",99000,78565447);

acc1.WithDraw(9000);
Console.WriteLine("Amount After Withdraw is: "+acc1.Balance);
//deposite
acc1.Deposite(10000);
Console.WriteLine("Amount Details Are: \n"+acc1.Name+"\n"+acc1.Balance+"\n"+acc1.MobileNO);

List<Account> accounts=new List<Account>();
accounts.Add(acc1);
accounts.Add(acc2);

foreach(Account theacc in accounts)
{
    Console.WriteLine(theacc.ToString());
}



// acc1.WithDraw(110000);
// Console.WriteLine("Amount Details Are: \n"+acc1.Name+"\n"+acc1.Balance+"\n"+acc1.MobileNO);