using Catalog;
using CRM;
using Membership;
using OrderProcessing;
using ShoppingCart;

//Property Initilizer
//In C#, object can be created w/o using constructor
Product p1 = new Product{
    Id=2,
    Title="Gerbera",
    Description="Wedding Flower",
    UnitPrice=10,
    Quantity=56000
};

Console.WriteLine(p1.Id+" "+p1.Title+" "+p1.Description);   //getter called automatically

p1.Title="Jasmine";     //setter called automatically
Console.WriteLine(p1.Id+" "+p1.Title+" "+p1.Description); 