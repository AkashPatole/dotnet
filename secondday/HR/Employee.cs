namespace HR;
public abstract class Employee
{
   public int ID{get;set;}
   public string? Firstname{get;set;}
   public string? Lastname{get;set;}
   public string? Location{get;set;}
   public DateTime? Birthdate{get;set;}
   public float Da{get;set;}
   public float Hra{get;set;}
   public float BasicSalary{get;set;}
  
   //Constructor Chaining
   public Employee():this(12,"Akash","Patole","Pune",new DateTime(1997,01,09),5000,10000,50000)
   {

   }

   public Employee(int id,string firstname,string lastname,
                  string location,DateTime bdate,float da,
                  float hra,float basicSalary){
           this.ID=id;
           this.Firstname=firstname;
           this.Lastname=lastname;
           this.Location=location;
           this.Birthdate=bdate;
           this.Da=da;
           this.Hra=hra;
           this.BasicSalary=basicSalary;
    }

    public abstract void Dowork();

    public virtual float ComputeSalary()
    {
        float salary=(Da * 25)+Hra+BasicSalary;
        return salary;
    }

    public override string ToString()
    {
        string str=string.Format("{0},{1},{2},{3},{4},{5},{6},{7}",ID,Firstname,Lastname,
                                Location,Birthdate,Da,Hra,BasicSalary);
        return str;
    }

    ~Employee(){}
}
