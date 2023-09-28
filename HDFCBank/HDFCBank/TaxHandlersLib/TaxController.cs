namespace TaxHandlersLib;

public class TaxController
{
    public double PayIncomeTax(double amount)
    {
        //setting tax 20%
        double finalAmount = (0.80) * amount;
        Console.WriteLine("Final amount after deducting income tax = {0}", finalAmount);
        return finalAmount;
    }

    public double paySalesTax(double amount)
    {
        //setting tax 5%
        double finalAmount = (0.95) * amount;
        Console.WriteLine("Final amount after deducting sales tax = {0}", finalAmount);
        return finalAmount;
    }

    public double payProfessionalTax(double amount)
    {
        //setting tax 10%
        double finalAmount = (0.90) * amount;
        Console.WriteLine("Final amount after deducting professional tax = {0}", finalAmount);
        return finalAmount;
    }
}
