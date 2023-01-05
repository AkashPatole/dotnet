namespace ProdDetails;

public class Product{

    public int ProductId{get;set;}
    public string ProductName{get;set;}
    public int Quantity{get;set;}
    public string Category{get;set;}
    public string Description{get;set;}

    public Product(int pid,string pname,int qty,string category,string description)
    {
       this.ProductId=pid;
       this.ProductName=pname;
       this.Quantity=qty;
       this.Category=category;
       this.Description=description;
    }

    public override bool Equals(object obj)
    {
        
        if (obj == null)
        {
            return false;
        }
        Product p=obj as Product;
        if(p == null)
        {
            return false;
        }
        return this.Quantity.Equals(p.Quantity);
    }
    

    public  int CompareTo(Object? anotherObj)
    {
        Product p=anotherObj as Product;
         if(p != null)
         {
             return this.Quantity.CompareTo(p.Quantity);
         }
         else
         {
            throw new ArgumentException("Object is not a Product");
         }
        
    }

    public override string ToString()
    {
        return "[ ID: "+ProductId+" Name: "+ProductName+" Quantity: "+Quantity+" Category: "+Category+" Description: "+Description+" ]";
    }

}