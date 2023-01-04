namespace Banking;
using Egovernance;
public class Account
{
    public event Taxoperations overBalance;
    public event MangerOperation underBalance;
    public double Balance{get;set;}


    public Account(double amount)
    {
        this.Balance=amount;
    }
    public void Deposite(double amount)
    {
        this.Balance+=amount;
    }

    public void Withdraw(double amount)
    {   if(this.Balance<=amount)
        {
            underBalance();
        }
        else
        {
                this.Balance-=amount;
        }
    
    }

    public override string ToString()
    {
        return "Balance: "+Balance;
    }

    public void ProcessTax()
    {
        if(this.Balance>=250000)
        {
            //raise Event
            Console.WriteLine("inProcesstax");
            overBalance(this.Balance);
        }
    }

}