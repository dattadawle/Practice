
Console.WriteLine(" Program Starts here..");

Console.WriteLine("Enter Customer Type...");

string customer= Console.ReadLine().ToUpper();

Customer c= null;
/*c.Insert();

if (customer == "SILVER")
{
   c.Insert();
}
else if (customer == "GOLD")
{
    c.Insert();
}
*/

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
}
Console.WriteLine(" Program Ends here..");

Console.ReadLine();