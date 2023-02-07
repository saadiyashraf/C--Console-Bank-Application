using System;
namespace hello
{
    class program
    {
        public static void Main(string[]args)
        {
        
            /*Deposit_Accounts dobj= new Deposit_Accounts();
            Loan_Account lobj=new Loan_Account();
            Mortage_Account mobj=new Mortage_Account();*/
            String input;
            DOB dob = new DOB();
            IDGenerator id = new IDGenerator();
            Credit cr = new Credit();
            Debit db = new Debit();//
            Savings sv = new Savings();
            Bank bn=new Bank();
            Console.ForegroundColor=ConsoleColor.DarkYellow;
            Console.WriteLine("****  Welcome to Bank Management System  ***",Console.ForegroundColor);
            while (true)
            {
                Console.ForegroundColor=ConsoleColor.Green;
                Console.WriteLine("\nServices:",Console.ForegroundColor);
                System.Console.WriteLine("------------------------");
                Console.ForegroundColor=ConsoleColor.DarkMagenta;
                Console.WriteLine("1. Create account");
                Console.WriteLine("2. Deposit from account");
                Console.WriteLine("3. Withdraw from account");
                
                Console.WriteLine("4. Exit",Console.ForegroundColor);
            
            int choice=Convert.ToInt32(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    Console.WriteLine("Enter account Type :");
                    bn.create_account();
                break;
                case 2:
                    Console.WriteLine("Enter Account Id: ");
                    bn.deposit();
                break;
                case 3:
                    Console.WriteLine("Enter Account Id: ");
                    bn.withdraw();
                break;
                case 4:
                    Environment.Exit(0);
                break;
                

            }
            

        System.Console.ReadLine();
        }

        
    }
}
}
