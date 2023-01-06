namespace Students.Models;
using System.ComponentModel.DataAnnotations;

public class Student {
   
    [Required (ErrorMessage="Student Id is Required")]  
    public int StudentId{get;set;} 
    [Display (Name="Enter Your Name")]
    public string Name{get;set;}
    [Required (ErrorMessage="Student Email is Required")]
    public string Email{get;set;}
   [Required (ErrorMessage="Student Password is Required")]
    public string Password{get;set;}

    public Student(int id,string name,string mail,string pass){
      this.StudentId=id;
      this.Name=name;
      this.Email=mail;
      this.Password=pass;
    }

   public override string ToString()
   {
    return "[ Id= "+StudentId+" Name= "+Name+" Email= "+Email+" Password= "+Password+" ]";
   }

}