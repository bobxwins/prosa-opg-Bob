using ProsaOpg.Data;
#if DEBUG
System.Console.WriteLine("Hello, World! - debug");
#else
    System.Console.WriteLine("Hello, World! - release");
#endif
var dataAccessService = DataAccessFactory.CreateDataContext("Data Source=customers.db;Mode=ReadOnly");
var customers= dataAccessService.GetAllCustomers();
foreach(var customer in customers)
 System.Console.WriteLine(customer.Name);

