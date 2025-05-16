
using SOLID_Principles;

Console.WriteLine(" Program Starts here..");

Console.WriteLine("Enter Customer Type...");

#region old code
/*

Customer c= null;
*//*c.Insert();

if (customer == "SILVER")
{
   c.Insert();
}
else if (customer == "GOLD")
{
    c.Insert();
}
*//*

if (customer == "SILVER")
{
    c = new SilverCustomer();

}

else if (customer == "GOLD")
{
    c = new GoldCustomer();
}
else if (customer == "PLATINUM")
{
    c = new PlatinumCustomer();
}

else if (customer == "VIP")
{
    c= new VIPCustomer();
}

if(customer != null)

{
    c.ShowsTimings();
   // c.PrintTicket();
}
else
{
    Console.WriteLine("Invalid Customer");
}*/
#endregion

//Customer customer = new Customer(new FileLogger());
//customer.Insert();

//Customer customer = new Customer(new DataBaseLogger());
//customer.Insert();

/*Customer customer = new Customer();
customer.setInsatance(new DataBaseLogger());

customer.Insert();*/

Customer customer = new Customer();
customer.instance = new DataBaseLogger();

customer.Insert();




Console.WriteLine(" Program Ends here..");

Console.ReadLine();