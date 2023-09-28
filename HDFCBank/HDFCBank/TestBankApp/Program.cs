using BankingLib;
using TaxHandlersLib;
using TaxPolicyLib;

Account acct = new Account();
acct.Balance = 10000;
double amount = 5000;
acct.Deposit(amount);
Console.WriteLine("Balance={0}", acct.Balance);

//Direct call
//Early binding
//Static linking (Complie time function call is resolved)
//Association of payIncomeTax at compile time
TaxController controller = new TaxController();
Console.WriteLine("Static linked function invocation");
double calculatedAmount1 = controller.PayIncomeTax(acct.Balance);
double calculatedAmount2 = controller.paySalesTax(acct.Balance);
double calculatedAmount3 = controller.payProfessionalTax(acct.Balance);

//Indirect call (at runtime, funcion call is resolved)
//Late Binding
//Dynamic linking
//Dynamic association of payIncomeTax(at runtime)
TaxOperation operation1 = new TaxOperation(controller.PayIncomeTax);
TaxOperation operation2 = new TaxOperation(controller.paySalesTax);
TaxOperation operation3 = new TaxOperation(controller.payProfessionalTax);

TaxOperation managingOperation = operation1;
managingOperation += operation2;
managingOperation += operation3;

//Indirect call
//double latestCalculatedValue = operation1(acct.Balance);
Console.WriteLine("Dynamic linked function invocation");
double latestCalculatedValue = managingOperation(acct.Balance);
acct.Balance = latestCalculatedValue;
Console.WriteLine("Remaining balance = {0}", acct.Balance);

managingOperation -= operation3;
latestCalculatedValue = managingOperation(acct.Balance);
acct.Balance = latestCalculatedValue;
Console.WriteLine("Remaining balance = {0}", acct.Balance);



