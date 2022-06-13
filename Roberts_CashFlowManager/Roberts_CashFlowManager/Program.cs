using System;

/*
 * Rayleen Roberts
 * IT 112
 * Notes:  A: I have yet to get the switch statement down with these
 *         B: I vaguely understand that I should be able to use the enum value
 *            to call the totals....ran out of time to work that out //** UPDATE!  Got it!!
 *         C: After writing this the 3rd time, I'm pretty cool with how all 
 *            these things talk to eachother, 3rd time I didn't have to peek during 
 *            build...and I made it better each time.  I like that I made a good use of 
 *            the ledger class and got rid of a LOT of lines of code by figuring out the 
 *            use of the Enums for my totals...with help of course :D
 *            
 *         D: Something is wrong with GitHub....unlike before, it will not accept my changes
 *            I have had to open a new repository and pull the changed files !! :(
 *            this is copy 4742 >:(
 * 
 * Behaviors Not Implemented and Why: trying to overload my array might break it, it's not
 *                                    a requirement of the assignment, which I usually don't
 *                                    care, but I gotta get my c++ final done and I am behind 
 *                                    now ;)
 *                                
 *    
 *      
 *  PS:  You are a great teacher, have a great summer, see you in the fall  :)
 *     
 */
namespace Roberts_CashFlowManager
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Ledger ledger = new Ledger();
            IPayable[] payables = new IPayable[20];
            Ledger.ledgerType type;
            Random r = new Random();
            bool isRunning = true;
            int choice;
            string firstName;
            string lastName;
            string ssn;

            payables[0] = new Invoice(r, "200", "bike", 5, 25M);
            payables[1] = new Invoice(r, "200", "bike", 5, 25M);
            payables[2] = new HourlyEmployee("Bob","Marley","555-55-5555",42.50M,52);
            payables[3] = new HourlyEmployee("Mary","Marley","444-44-4444",57.80M,87);
            payables[4] = new SalariedEmployee("Fred","Marley","333-33-3333",4502.57M);
            payables[5] = new SalariedEmployee("Ginger","Marley","222-22-2222",3674.22M);
            Console.WriteLine("\n\t");
            Console.WriteLine("\t----Cash Flow Manager----");
            Console.Write(ledger.Menu());
            while (isRunning)
            {
                for (int i = 6; i < payables.Length; i++)
                {
                    choice = int.Parse(Console.ReadLine());
                    if (choice == 1)
                    {
                        Console.Write("\n\tPart Number: ");
                        string partNumber = Console.ReadLine();
                        Console.Write("\n\tPart Description: ");
                        string partDescription = Console.ReadLine();
                        Console.Write("\n\tQuantity: ");
                        int quantity = int.Parse(Console.ReadLine());
                        Console.Write("\n\tUnit Price: ");
                        decimal price = decimal.Parse(Console.ReadLine());
                        payables[i] = new Invoice(r, partNumber, partDescription, quantity, price);
                        Console.Write(ledger.Menu2());
                    }
                    else if (choice == 2)
                    {
                        Console.Write("\n\tFirst Name: ");
                        firstName = Console.ReadLine();
                        Console.Write("\n\tLast Name: ");
                        lastName = Console.ReadLine();
                        Console.Write("\n\tSocial Security Number (include dashes):  ");
                        ssn = Console.ReadLine();
                        Console.Write("\n\tHourly Wage:  ");
                        decimal wage = decimal.Parse(Console.ReadLine());
                        Console.Write("\n\tHours Worked:  ");
                        int hours = int.Parse(Console.ReadLine());
                        payables[i] = new HourlyEmployee(firstName,lastName,ssn,wage,hours);
                        Console.Write(ledger.Menu2());  
                    }
                    else if(choice == 3)
                    {
                        Console.Write("\n\tFirst Name: ");
                        firstName = Console.ReadLine();
                        Console.Write("\n\tLast Name: ");
                        lastName = Console.ReadLine();
                        Console.Write("\n\tSocial Security Number (include dashes):  ");
                        ssn = Console.ReadLine();
                        Console.Write("\n\tWeekly Salary:  ");
                        decimal wage = decimal.Parse(Console.ReadLine());
                        payables[i] = new SalariedEmployee(firstName, lastName, ssn, wage);
                        Console.Write(ledger.Menu2());
                    }
                    else if (choice == 4)
                    {
                       
                        isRunning = false;
                        Console.WriteLine("\n\tWeekly Cashflow is as Follows: ");
                        foreach(IPayable payable in payables)
                        {
                            if(payable == null)
                            {
                                break;
                            }
                            else
                            {
                                if(payable.ledgerType == Ledger.ledgerType.Invoice)
                                {
                                    ledger.setInv(payable.Payable);
                                }
                                else if (payable.ledgerType == Ledger.ledgerType.Hourly)
                                {
                                    ledger.setHour(payable.Payable);
                                }
                                else if(payable.ledgerType == Ledger.ledgerType.Salaried)
                                {
                                    ledger.setSal(payable.Payable);
                                }

                                Console.WriteLine(payable.ToString());
                            }
                            
                        }
                        Console.Write(ledger.report());
                        Environment.Exit(0);

                        // ** BOOO YA!!!!
                    }
                }

            }
            
        }
       
    }
}
