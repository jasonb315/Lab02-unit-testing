using System;

namespace ATM
{
    public class Program
    {

        public static double balance = 100;

        public static void Main(string[] args)
        {
            string appName = "ATM";
            string appVersion = "1.0.0";
            string appAuthor = "Jason Burns";
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            Console.ForegroundColor = ConsoleColor.Green;

            try
            {
                Core();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Program complete.");

            }

        }
        /// <summary>
        ///     Takes commands to run and executes functions
        /// </summary>
        public static void Core()
        {

            while (true)
            {
                int command = Prompt();

                if (command == 1)
                {
                    Balance();
                }
                else if (command == 2)
                {
                    Console.WriteLine("WITHDRAW");
                    Console.Write("enter amount:");

                    try
                    {
                        string inputStr = Console.ReadLine();
                        int inputVal;
                        inputVal = Convert.ToInt32(inputStr);

                        Withdraw(inputVal);
                    }
                    catch (Exception)
                    {
                        throw;
                    }


                }
                else if (command == 3)
                {
                    try
                    {
                        Console.WriteLine("DEPOSIT");
                        Console.Write("enter amount:");
                        string inputStr = Console.ReadLine();
                        int inputVal;
                        inputVal = Convert.ToInt32(inputStr);

                        Deposit(inputVal);
                    }
                    catch (Exception)
                    {
                        throw;
                    }

                }
                else if (command == 4)
                {
                    // exit
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid");
                }
            }
        }
        /// <summary>
        ///    collects user cli input
        /// </summary>
        /// <returns>user input as int</returns>
        public static int Prompt()
        {
            Console.WriteLine();
            Console.WriteLine("1] BALANCE");
            Console.WriteLine("2] WITHDRAWL");
            Console.WriteLine("3] DEPOSIT");
            Console.WriteLine("4] EXIT");

            string inputStr = Console.ReadLine();
            int inputVal;
            inputVal = Convert.ToInt32(inputStr);
            return inputVal;
        }
        /// <summary>
        ///     subtracts from balance by input
        /// </summary>
        /// <param name="num">int num</param>
        /// <returns>string pass</returns>
        public static string Withdraw(int num)
        {
            if (balance - num < 0)
            {
                Console.WriteLine($"Only {balance} avaliavle.");
                return "fail";
            }
            else if (num < 0)
            {
                Console.WriteLine("Invalid entry.");
                return "fail";
            }
            else
            {
                balance -= num;
                Console.WriteLine($">>>{num}");
                Console.WriteLine($"NEW BALANCE: {num}");
                return "pass";
            }
        }
        /// <summary>
        ///     increases balance by user input
        /// </summary>
        /// <param name="num">int num</param>
        /// <returns>new balance</returns>
        public static double Deposit(int num)
        {
            if (num < 0)
            {
                Console.WriteLine("Invalid entry.");
                return balance;
            }
            else
            {
                balance = balance += num;
                Console.WriteLine($"<<<{num}");
                Console.WriteLine($"NEW BALANCE: {balance}");
                return balance;
            }
            
        }
        /// <summary>
        ///    Print out current balance
        /// </summary>
        public static void Balance()
        {
            Console.WriteLine($"BALANCE: {balance}");
        }
    }
}
