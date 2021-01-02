using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace simpleCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber;
            string operation;
            int secondNumer;
            int result = 0;
            
            // enter first number 
            Console.WriteLine("Enter your first number.\n");
            String enteredVal = Console.ReadLine();            
            int.TryParse(enteredVal, out firstNumber);
            
            if (firstNumber == 0)
            {
                Console.WriteLine("please enter a number, 0 is not a valid one");
                return;
            }

            Console.WriteLine("Enter your operation '+' or 'sum', '-' or 'minus'\n" +
                "'*' or 'multiply', '/' or 'divide'\n");
            operation = Console.ReadLine().ToLower();

            if (operation != "+" || operation != "sum" ||
               operation != "-" || operation != "minus" ||
               operation != "*" || operation != "multiply" ||
               operation != "/" || operation != "divide"
                )
            {


                Console.WriteLine("Enter your second number.\n");
                enteredVal = Console.ReadLine();
                int.TryParse(enteredVal, out secondNumer);
                if (secondNumer == 0)
                {
                    Console.WriteLine("please enter a number, 0 is not a valid one");
                    return;
                }

            } else { 
                Console.WriteLine("Entered an invalid operation, try again");
                return;
            }
            //if (firstNumber is not int || secondNumer is int)
            //{
            //    Console.WriteLine("Error not a number");
            //}

            if (operation == "+" || operation == "add")
            {
                result = firstNumber + secondNumer;
                Console.WriteLine(result);                    
            }
            else if ( operation == "-" || operation == "substaction" )
                {
                result = firstNumber - secondNumer;
                Console.WriteLine(result);
            }
            else if (operation == "*" || operation == "multiply" )
                {
                result = firstNumber * secondNumer;
                Console.WriteLine(result);
            }
            else if (operation == "/" || operation == "divide")
                {
                result = firstNumber / secondNumer;
                Console.WriteLine(result);
            } 
            else
            {
                Console.WriteLine("it is not possible to perform the operation");
            }

            Console.WriteLine("The result is = " + result);
        }
    }
}
