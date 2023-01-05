using ProdDetails;

Console.WriteLine("=============================");
List<Product> basket=ProductManager.GetallDetails();
bool exit=false;
while(!exit)
{
   Console.WriteLine("1:Add Product In Basket\n"+
                      "2:SearchById\n3:SortByQuantity\n"+
                      "4:Remove\n5:Display\n6:Exit");
   Console.WriteLine("Enter Your Choice: ");
   switch (int.Parse(Console.ReadLine()))
   {
       case 1:
       basket=ProductManager.GetallDetails();
       break;

       case 2:
       Console.WriteLine("Enter Product Id");
       int id=int.Parse(Console.ReadLine());
       foreach (Product p in basket)
       {
        if(p.ProductId == id)
        {
            Console.WriteLine("Product is: "+p);
        }
       }
    break;
       case 6:
       exit=true;
       break; 
    
   }
}
