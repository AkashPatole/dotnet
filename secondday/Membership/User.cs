namespace Membership;

public class User{

    public int ID{get;set;}
    public string? Firstname{get;set;}
    public string? Lastname{get;set;}
    public string? Location{get;set;}
    public int Mobileno{get;set;}
    public string? Email{get;set;}
  
  ~User(){}
}