using SOLID_Principles;

public abstract class Customer
{
    /*public void Insert()
    {
        try
        {
            int a = 10, b=0;

            int c = a / b;


        }

        catch (Exception ex)
        {
            //File.AppendAllText(@"Logs/Errors.txt",$"{ex.Message}\r\n");

            FileLogger fileLogger = new FileLogger();

            fileLogger.logger(ex.Message);
        }*/

   // public abstract int GetTicketAmount();
  //  public abstract void PrintTicket();

    public void ShowsTimings()
    {
        Console.WriteLine("***All shows timings***");
    }

}

public  interface Icustomer1 
{
    public abstract void PrintTicket();
    public abstract int GetTicketAmount();
}

public interface IcustomerV1
{
    void FreeFood();
}

public class SilverCustomer : Customer, Icustomer1
{
    public  int GetTicketAmount()
    {
        return 200;
    }

    public  void PrintTicket()
    {
        Console.WriteLine("Silver Customer ticket Printed");
    }
}

public class GoldCustomer : Customer, Icustomer1
{
    public  int GetTicketAmount()
    {
        return 300;
    }

    public  void PrintTicket()
    {
       Console.WriteLine("Gold Customer ticket Printed");
    }
}

public class PlatinumCustomer : Customer, Icustomer1
{
    public  int GetTicketAmount()
    {
        return 400;
    }

    public  void PrintTicket()
    {
        Console.WriteLine("Platinum Customer ticket Printed");
    }
}

public class Enquary : Customer
{

  /*  public int GetTicketAmount()
    {
        return 400;
    }

    public void PrintTicket()
    {
        Console.WriteLine("Platinum Customer ticket Printed");
    }*/

}

public class VIPCustomer : Customer, IcustomerV1 // needs some new features
{
    public void FreeFood()
    {
        Console.WriteLine("Free food is activated");
    }

    public int GetTicketAmount()
    {
        return 600;
    }

    public void PrintTicket()
    {
       Console.WriteLine("VIP customer Ticket printed");
    }
}



