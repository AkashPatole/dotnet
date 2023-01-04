namespace Egovernance;

//delegate
public delegate void Taxoperations(double amount);
public class Government
{
    public void DeductIncomeTax(double amount)
    {
        Console.WriteLine("15% income tax deducted");
    }

    public void DeductProfessionalTax(double amount)
    {
        Console.WriteLine("25% professional tax deducted");
    }

    public void DeductServiceTax(double amount)
    {
        Console.WriteLine("20% Service tax deducted");
    }
}