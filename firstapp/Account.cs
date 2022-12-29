namespace Banking;

public class Account
{
    private string name;
    private float balance;
    private int mobileNo;

public Account()
{
    this.name=name;
    this.balance=balance;
    this.mobileNo=mobileNo;
}


public Account(string name,float balance,int mobileNo)
{
    this.name=name;
    this.balance=balance;
    this.mobileNo=mobileNo;
}

public string Name{
    get{return this.name;}
    set{this.name=value;}
}

public float Balance{
    get{return this.balance;}
    set{this.balance=value;}

}

public int MobileNO{
    get{return this.mobileNo;}
    set{this.mobileNo=value;}
}

public void Deposite(float balance)
{
    this.balance+=balance;
}

public void WithDraw(float amount)
{
    if(amount == 0)
    {throw new Exception("Enter Valid Amount");}
    else if(amount > this.balance){
        throw new Exception("Insufficient Balance");
    }
    this.balance-=amount;
    
}

public override string ToString()
{
    return "Name: "+this.name+" Balance: "+this.balance+" Mobile NO: "+this.mobileNo;
}
~Account(){}

}