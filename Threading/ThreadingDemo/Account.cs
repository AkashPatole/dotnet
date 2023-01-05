namespace Banking;
using System;
using System.Threading;
public class Account{


    public double Balance{get;set;}
    public Account(double amount){
        this.Balance=amount;
    }
    public void Deposit(double amount){
        lock (this)
        {
        Console.WriteLine("Amount Before Deposite: "+Balance);
        this.Balance+=amount;
        Console.WriteLine("Amount After Deposite: "+Balance);
        }
        
    }
    public void Withdraw(double amount){
         Console.WriteLine("Amount Before Withdraw: "+Balance);
        this.Balance-=amount;
         Console.WriteLine("Amount After Withdraw: "+Balance);
    }
    public override string ToString()
    {
        return base.ToString() + "Current Balance ="+ this.Balance;
    }



}