using BankingLib;
using TaxHandlersLib;
using TaxPolicyLib;

Console.WriteLine("Welcome to ICICI Bank");

TaxController controller = new TaxController();
CurrentAccount model = new CurrentAccount();
model.Balance = 90000;

//Event Registration
//Mapping event with event handlers
//Setting route for event to its respective event handlers
model.overBalance += controller.PayIncomeTax;
model.overBalance += controller.paySalesTax;
model.overBalance += controller.payProfessionalTax;

model.Deposit(350000);
Console.WriteLine("Latest balance = {0}", model.Balance);


