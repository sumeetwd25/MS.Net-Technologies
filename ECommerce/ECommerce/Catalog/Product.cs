namespace Catalog;

//POCO (Plain Old CLR Object) - used to define state
public class Product
{
    //Auto Property
    public int Id{get; set;}    //Properties should always be written in title case

    public string Title{get; set;}
    public string Description{get; set;}
    public int Quantity{get; set;}
    public double UnitPrice{get; set;}

}
