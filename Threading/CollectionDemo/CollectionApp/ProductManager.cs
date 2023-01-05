namespace ProdDetails;
using System.Collections.Generic;
public class ProductManager{

    public static List<Product> GetallDetails()
{
    List<Product> basket=new List<Product>();
    basket.Add(new Product(1,"Gerbera",50,"Flower","Wedding Flower"));
    basket.Add(new Product(2,"Rose",200,"Flower","Valentine Flower"));
    basket.Add(new Product(3,"Lotus",150,"Flower","Worship Flower"));
    basket.Add(new Product(4,"Carnation",250,"Flower","Wedding Flower"));
    basket.Add(new Product(5,"Lily",27,"Flower","Wedding Flower"));
    basket.Add(new Product(6,"Daffodil",20,"Flower","Wedding Flower"));
    return basket;
}



}
