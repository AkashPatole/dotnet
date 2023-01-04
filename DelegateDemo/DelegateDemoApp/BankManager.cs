namespace Banking;

public delegate void MangerOperation();
public class BankManager{
    
    public void BlockAccount()
    {
        Console.WriteLine("Account Blocked");
    }

    public void SendSms()
    {
        Console.WriteLine("Sending Sms");
    }

    public void SendMail()
    {
       Console.WriteLine("Sending Mail"); 
    }
}