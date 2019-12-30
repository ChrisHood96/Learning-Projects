using System;

namespace FirstCalculator

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Method: ");
            string Function = Console.ReadLine();


            if (Function.ToUpper() == ("ADD"))
            {
                Console.WriteLine(Add(num1, num2));
                
            }
            else if (Function.ToUpper() == ("MULTIPLY"))
            {
                Console.WriteLine(Multiply(num1, num2));
            }
            else if (Function.ToUpper() == ("SUBTRACT"))
            {
                Console.WriteLine(Subtract(num1, num2));
            }
            else if (Function.ToUpper() == ("DIVIDE"))
            {
                Console.WriteLine(Divide(num1, num2));
            }
            else
            {
                Console.WriteLine("Something went wrong, please input a recognised method");
                Console.Write("Enter Method: ");
                string Function1 = Console.ReadLine();
                if (Function1.ToUpper() == ("ADD"))
                {
                    Console.WriteLine(Add(num1, num2));
                }
                else if (Function1.ToUpper() == ("MULTIPLY"))
                {
                    Console.WriteLine(Multiply(num1, num2));
                }
                else if (Function1.ToUpper() == ("SUBTRACT"))
                {
                    Console.WriteLine(Subtract(num1, num2));
                }
                else if (Function1.ToUpper() == ("DIVIDE"))
                {
                    Console.WriteLine(Divide(num1, num2));
                }
                else
                {
                    Console.WriteLine("Please try again later");
                }

            }  
              


                Console.ReadLine();
        }

        static double Add(double arguement1 , double arguement2)
        {
            double answer = arguement1 + arguement2;
            return answer;
        }
        static double Multiply(double arguement1, double arguement2)
        {
            double answer = arguement1 * arguement2;
            return answer;
        }
        static double Subtract(double arguement1, double arguement2)
        {
            double answer = arguement1 - arguement2;
            return answer;
        }
        static double Divide(double arguement1, double arguement2)
        {
            double answer = arguement1 / arguement2;
            return answer;
        }


    }


}
