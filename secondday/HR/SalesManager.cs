namespace HR;

public class SalesManager:SalesEmployee{
     public float Bonus{get;set;}

     public SalesManager():base()
     {
        this.Bonus=0;
     }

     public SalesManager(int id,string firstname,string lastname,
                        string location,DateTime bdate,float da,
                        float hra,float basicSalary,float target,
                        float sales,float bonus):base(id,
                        firstname,lastname,location,bdate,da,
                        hra,basicSalary,target,sales){
               this.Bonus=bonus;
    }

    public override void Dowork()
    {
        base.Dowork();
    }

    public override float ComputeSalary()
    {
        return base.ComputeSalary() + Bonus;
    }

    public override string ToString()
    {
        return base.ToString()+" Bonus="+Bonus; 
    }
    ~SalesManager(){}
}