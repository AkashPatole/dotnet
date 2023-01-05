using Banking;
using System.Threading;

Account acc1=new Account(60000);


// Thread primaryThread=Thread.CurrentThread;
// Console.WriteLine("Thread Id= "+primaryThread.ManagedThreadId);

//Thread thread1=new Thread(new ThreadStart(acc1.Deposit(50000)));
//Thread thread2=new Thread(new ThreadStart(acc1.Withdraw(20000)));
Thread thread1=new Thread(()=>acc1.Deposit(50000));
Thread thread2=new Thread(()=>acc1.Withdraw(50000));
thread1.Name="Deposit";
thread2.Name="Withdraw";
thread1.Start();
thread2.Start();

Console.WriteLine("Balance= "+acc1.Balance);
