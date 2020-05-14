using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            // Request for operation to be performed

            Console.WriteLine("Select the operation to be performed");
            Console.Write("Please enter an operator (+, -, /, *): ");
            String operation = Console.ReadLine();
            
            //Accept the inputs from the user 
            Console.WriteLine("Enter 1st input");
                Double input1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter 2nd input");
                Double input2 = Convert.ToDouble(Console.ReadLine());
                Double result = 0;

                switch (operation)
                {
                    case "+":
                        {
                            result = input1+input2;
                            break;
                        }
                    case "-":
                        {
                            result = input1-input2;
                            break;
                        }
                    case "*":
                        {
                            result = input1*input2;
                            break;
                        }
                    case "/":
                        {
                            result =input1/input2;
                            break;
                        }
                    default:
                        Console.WriteLine("Wrong action!! try again");
                        break;
                }

            // Displaying the output
               Console.WriteLine("Output:"+input1.ToString() + " " + operation + " " + input2.ToString() + " = " + result.ToString());
               Console.ReadKey();
        }       
    }
}
    

