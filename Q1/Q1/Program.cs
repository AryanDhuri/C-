using System;

class Bank
{

    private int bankaccount;
    
    public int Bank_account
    {
        get
        {
            return bank_account;
        }
        set
        {
            Console.WriteLine("Enter Bank account Number");
            int n = Convert.ToInt32(Console.ReadLine(value));
            if (bank_account != n)
            {
                Console.WriteLine("Invalid");
            }
            else
            {
                Console.WriteLine("Valid");
            }

        }
    }


}

class Program
{
    static void Main(string[] args)
    {
        Bank b = new Bank();
        b.Bank;
    }
}
