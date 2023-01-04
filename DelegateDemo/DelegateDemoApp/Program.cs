using Egovernance;
using Banking;

Government obj=new Government();

//register adress of a function to a instance of Delegate
Taxoperations itOperations=new Taxoperations(obj.DeductIncomeTax);
Taxoperations proOperations=new Taxoperations(obj.DeductProfessionalTax);
Taxoperations serOpeations=new Taxoperations(obj.DeductServiceTax);

// unicast Delegate
// itOperations(6000);
// proOperations(9000);
// serOpeations(1000);


// multicast Delegate
// Taxoperations? generalOperations=null;
// generalOperations=itOperations;
// generalOperations+=proOperations;
// generalOperations+=serOpeations;
// generalOperations(6000);

Account acc1=new Account(10000);

//Event Registration
//Event Configuration

acc1.overBalance+=itOperations;
acc1.overBalance+=proOperations;
acc1.overBalance+=serOpeations;

Console.WriteLine("Enter Amount to be deposited");
double amount=double.Parse(Console.ReadLine());
acc1.Deposite(amount);
acc1.ProcessTax();
Console.WriteLine("Enter After Tax Deduction");
Console.WriteLine(acc1);

BankManager manager=new BankManager();
MangerOperation blockAccount=new MangerOperation(manager.BlockAccount);
MangerOperation sendMail=new MangerOperation(manager.SendMail);
MangerOperation sendSms=new MangerOperation(manager.SendSms);


Account acc2=new Account(6000);
acc2.underBalance+=blockAccount;
acc2.underBalance+=sendMail;
acc2.underBalance+=sendSms;

Console.WriteLine("Enter Amount to be deposited");
double amt=double.Parse(Console.ReadLine());
acc2.Withdraw(amt);
Console.WriteLine("Enter After Block");
Console.WriteLine(acc2);

