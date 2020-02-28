using System;

namespace GersonMethods
{
    class Program
    {
        /// <summary>
        /// This method is used to perform basic calci operations.
        /// </summary>
        /// <param name="a"> Parameter 1 </param>
        /// <param name="b"> Parameter 2 </param>
        /// <param name="flag"> Flag to identify the type of operation</param>
        /// <returns></returns>
        static double BasicCalciOperation(double a, double b, int flag)
        {
            //Case Handling
            switch (flag)
            {
                //Addition
                case 1: return (a + b);

                //Subtraction
                case 2: return (a - b);

                //Multiplication
                case 3: return (a * b);

                //Division
                case 4:
                    {
                        //Handling Divide by Zero case
                        if (b == 0)
                            Console.WriteLine("Division By Zero is not possible.");
                        else
                            return (a / b);
                        break;
                    }
                default: break;
            }
            //When the divide by zero case exists, then only this will be returned
            return double.NaN;
        }
        static void Main(string[] args)
        {
            //Double Values to store the inputs
            double a, b;
            //Flag to select the type of operation
            int flag;

            //Welcome message
            Console.WriteLine("====================Gerson Berrios====================");
            Console.WriteLine("====================Hello User, Welcome to Basic Calculation====================");
            Console.WriteLine("====================Enter two numbers to perform basic Calci Operations==================");

            //Exception Handling
            try
            {
                //For multiple iterations in a single launch
                while (true)
                {
                    //Input 1
                    Console.WriteLine("Enter number 1: ");
                    a = Convert.ToInt32(Console.ReadLine());

                    //Input 2
                    Console.WriteLine("Enter number 2: ");
                    b = Convert.ToInt32(Console.ReadLine());

                    //Welcome Message
                    Console.WriteLine("====================Basic Calci Operation -> Num_1 # Num_2==================");
                    Console.WriteLine("1.Add\n2.Subtract\n3.Multiply\n4.Divide");
                    Console.WriteLine("Please select your choice ?");

                    //Input Flag
                    flag = Convert.ToInt32(Console.ReadLine());

                    //Calling our method
                    Console.WriteLine("The output of the Basic Calci Operation is " + BasicCalciOperation(a, b, flag));

                    //Continue or Exit
                    Console.WriteLine("Do you want to continue? Y or N\n");

                    char ch = Console.ReadKey().KeyChar;
                    if (ch == 'y' || ch == 'Y')
                        continue; //Continue the program again
                    else
                        break; //Exit the program
                }

            }
            catch (FormatException ex)
            {
                //Handling Format exception when Format of input is incorrect
                Console.WriteLine("Please enter only integers\n" + ex.Message);
                Console.ReadKey();

            }






        }
    }
}
  
