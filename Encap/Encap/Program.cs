using System;

class Bank
{
    private int bank_account=010;
    Console.WriteLine("Enter Bank account Number");
    int value = Convert.ToInt32(Console.ReadLine());
    public int Bank_account
    {
        get
        {
            return bank_account;
        }
        set
        {
            if (bank_account != value)
            {
                Console.WriteLine("Invalid");
            }
            else {
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
        b.Bank_account;
    }
}
