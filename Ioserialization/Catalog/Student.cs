namespace Catalog;
using System.ComponentModel.DataAnnotations;
[Serializable]
public class Student
{
    [Required (ErrorMessage="Student ID is Mandotory")]
   public int StudentId{get;set;}
   public string Name{get;set;}
   public string Email{get;set;}
   public DateTime Dob{get;set;}
   public string Password{get;set;}
    [Required (ErrorMessage="Mobile NO is Mandotory")]
   public int MobileNo{get;set;}

    public Student()
    {
        this.StudentId=1;
        this.Name="Akash";
        this.Email="abc@gmail.com";
        this.Dob=new DateTime(1997,01,09);
        this.Password="12345";
        this.MobileNo=953264;
    }

    public Student(int sid,string nm,string mail,DateTime db,string pass,int num)
    {
        this.StudentId=sid;
        this.Name=nm;
        this.Email=mail;
        this.Dob=db;
        this.Password=pass;
        this.MobileNo=num;
    }
    
    public override string ToString()
    {
          return "StudentID: "+StudentId+" Name: "+Name+" Email: "+Email+" Dob: "+Dob+" Password: "+Password+" MobileNo: "+MobileNo;
    }


}
