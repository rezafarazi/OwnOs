using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OwnOs.Plugins.Calculator
{
    class Calculator
    {

        //Calculator Start
        public static void Start_Calculator()
        {
            reset:
            int a = 0, b = 0 ;

            Console.Write("Enter a Number : ");
            a = Convert.ToInt16(Console.ReadLine());

            while(true)
            {
                Console.Write("Enter your opration : ");
                string opration = Console.ReadLine();

                if (opration.ToLower().Equals("exit"))
                {
                    break;
                }
                else if (opration.ToLower().Equals("reset"))
                {
                    goto reset;
                }
                else
                {
                    Console.Write("Enter a number : ");
                    b = Convert.ToInt16(Console.ReadLine());

                    switch (opration)
                    {
                        case "+":
                            a = a + b;
                        break;
                        case "-":
                            a = a - b;
                        break;
                        case "/":
                            a = a / b;
                        break;
                        case "*":
                            a = a * b;
                        break;
                    }
                    Console.WriteLine("="+a);
                }

            }

            return;
        }
        //Calculator End

    }
}
