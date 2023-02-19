using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0217
{
    class Program
    {
        public static string ShowString(string str)
        {
            return str;
        }
        public static string TestMethod(string str)
        {
            Console.WriteLine("This program is created to test delegates");
            return str;
        }

        public static int Sum(int a, int b)
        {
            return a + b;
        }
        public static int Diff(int a, int b)
        {
            return a + b;
        }
        public static int Mult(int a, int b)
        {
            return a * b;
        }
        public static bool ifEven(int a)
        {
            if (a % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool ifOdd(int a)
        {
            if (a % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool ifSimple(int a)
        {
            if (a == 1)
            {
                return true;
            }
            else if (a < 1)
            {
                throw new Exception("Out of range");
            }
            else
            {
                for (int i = 2; i < a; i++)
                {
                    if (a % i == 0)
                        return false;
                }
                return true;
            }
        }

        public static bool ifFibonacci(int a)
        {
            if (a == 1)
            {
                return true;
            }
            else if (a < 1)
            {
                throw new Exception("Out of range");
            }
            else
            {
                int FirstNum = 0;
                int SecondNum = 1;
                int CurrentNum;
                for (int i = 0; i < a; i++)
                {
                    CurrentNum = FirstNum + SecondNum;
                    if (CurrentNum == a)
                    {
                        return true;
                    }
                    else
                    {
                        FirstNum = SecondNum;
                        SecondNum = CurrentNum;
                    }
                }
                return false;
            }
        }

        public static int ChoiceReturn(int a)
        {
            return a;
        }

        public static void NumberTesting(Choice choice)
        {
            Console.Write("\n1 if Even\n2 if Odd \n3 if Simple\n4 if Fibonacci\n5 Exit \nYour choice: ");

            int makechoice = Convert.ToInt32(Console.ReadLine());

            if (makechoice >= 1 && makechoice <= 4)
            {
                Tester[] dg2 = { ifEven, ifOdd, ifSimple, ifFibonacci };
                Console.WriteLine("Enter a number: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(dg2[choice(makechoice) - 1].Invoke(a));
            }
        }


        delegate string GetAsString(string str);
        delegate int Operator(int a, int b);
        public delegate bool Tester(int a);
        public delegate int Choice(int a);

        static void Main(string[] args)
        {
            #region 1
            Console.WriteLine("Enter a string: ");

            GetAsString getStringMethod = ShowString;
            Console.WriteLine(getStringMethod.Invoke(Console.ReadLine()));

            getStringMethod = TestMethod;
            Console.WriteLine(getStringMethod("test string"));

            #endregion

            #region 2
            Operator[] dg = { Sum, Diff, Mult };
            int choice = 0;
            while (choice != 4)
            {
                Console.Write("\n1 Sum\n2 Diff \n3 Mult\n4 Exit\nYour choice: ");

                choice = Convert.ToInt32(Console.ReadLine());

                if (choice >= 1 && choice <= 3)
                {
                    Console.WriteLine("Enter two numbers: ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    int b = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(dg[choice - 1].Invoke(a, b));
                }
            }
            #endregion

            #region 3 and 4
            
            NumberTesting(ChoiceReturn);

            #endregion
        }
    }
}
