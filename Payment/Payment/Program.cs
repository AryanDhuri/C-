using System;

interface Ipayment
{
    string Makepayment(double amount);
}

class credit_card : Ipayment
{
   public string Makepayment(double amount)
    {
        return $"payment done with credit card: {amount}";
    }
}

class paypal : Ipayment
{
    public string Makepayment(double amount)
    {
        return $"payment done with paypal: {amount}";
    }
}

class upi : Ipayment
{
    public string Makepayment(double amount)
    {
        return $"payment done with UPI: {amount}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter amount to withdraw");
        double amount = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter a number 1:Credit card 2:paypal 3:UPI");
        int n = Convert.ToInt32(Console.ReadLine());
        switch (n)
        {
            case 1:
                credit_card c = new credit_card();
                Console.WriteLine(c.Makepayment(amount));
                break;

            case 2:
                paypal p = new paypal();
                Console.WriteLine(p.Makepayment(amount));
                break;

            case 3:
                upi u = new upi();
                Console.WriteLine(u.Makepayment(amount));
                break;

            default:
                Console.WriteLine("invalid try again");
                break;
        }
    }
}
