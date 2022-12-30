namespace Membership;
public static class AuthManager
{
     public static bool Validate(string? email,string? password){
        bool status=false;
        if(email == "akashpatole2609@gmail.com" && password == "zoro")
        {
           status=true;
           return status;
        }
        return status;
     }

public static bool Register(int id,string? firstname,string? lastname,string? location,int mobileNO,string? email)
{
  bool status=false;
  
  try{
     User theuser=new User();
     theuser.ID=id;
     theuser.Firstname=firstname;
     theuser.Lastname=lastname;
     theuser.Location=location;
     theuser.Mobileno=mobileNO;
     theuser.Email=email;
     status=true;
   
  }catch(Exception)
  {

  }
  finally
  {

  }
  return status;

}


}
