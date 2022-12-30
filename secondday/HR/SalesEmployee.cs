namespace HR;

public class SalesEmployee:Employee{
  
    public float Target{get;set;}
    public float SalesDone{get;set;}
    public float Incentive{get;set;}

    public SalesEmployee():base(){
      this.Target=0;
      this.SalesDone=0;
      this.Incentive=0;
    }

    public SalesEmployee(int id,string firstname,string lastname,
                        string location,DateTime bdate,float da,
                        float hra,float basicSalary,float target,
                        float sales):base(id,
                        firstname,lastname,location,bdate,da,
                        hra,basicSalary){

                  this.Target=target;
                  this.SalesDone=sales;
                  this.Incentive=0;
    }

    public override void Dowork()
    {
        if(SalesDone >= Target)
        {
            this.Incentive=5000;
        }
        else
        {
            this.Incentive=0;
        }
    }

    public override float ComputeSalary()
    {
        float salary=base.ComputeSalary() + this.Incentive;
        return salary;
    }

    public override string ToString()
    {
        return base.ToString() + " Incentive="+Incentive+" Target="+Target;
    }

    ~SalesEmployee(){}

}