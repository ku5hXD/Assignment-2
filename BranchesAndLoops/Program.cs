using System;

namespace Program
{

    class MainClass
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("\n IF Demo : \n");
            BranchesAndLoops.IFDemo();
            Console.WriteLine("\n IF-ELSE Demo : \n");
            BranchesAndLoops.IfElseDemo();
            Console.WriteLine("\n WHILE and DO LOOP Demo : \n");
            BranchesAndLoops.WhileAndDoLoopDemo();
            Console.WriteLine("\n FOR LOOP Demo : \n");
            BranchesAndLoops.ForLoopDemo();
            Console.WriteLine("\n NESTED LOOP Demo : \n");
            BranchesAndLoops.NestedLoopDemo();
            Console.WriteLine("\n CONCLUSION : \n");
            BranchesAndLoops.Conclusion();
        }
    }

    static class BranchesAndLoops
    {

        public static void IFDemo()
        {
            int a = 5;
            int b = 6;
            if (a + b > 10)
                Console.WriteLine("The answer is greater than 10.");
        }

        public static void IfElseDemo()
        {
            int a = 5;
            int b = 3;
            int c = 4;
            if ((a + b + c > 10) || (a == b))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("Or the first number is equal to the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("And the first number is not equal to the second");
            }

            if ((a + b + c > 10) && (a == b))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("And the first number is equal to the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("Or the first number is not equal to the second");
            }
        }

        public static void WhileAndDoLoopDemo()
        {
            int counter = 0;
            while (counter < 10)
            {
                Console.WriteLine($"Using While Loop The counter is {counter}");
                counter++;
            }

            counter = 0;
            do
            {
                Console.WriteLine($"Using DoWhile Loop The counter is {counter}");
                counter++;
            } while (counter < 10);
        }

        public static void ForLoopDemo()
        {
            for (int counter = 0; counter < 10; counter++)
            {
                Console.WriteLine($"Using For Loop , The counter is {counter}");
            }
        }

        public static void NestedLoopDemo()
        {
            for (int row = 1; row < 11; row++)
            {
                for (char column = 'a'; column < 'k'; column++)
                {
                    Console.WriteLine($" cell -> ({row}, {column})");
                }
            }
        }

        public static void Conclusion()
        {
            int sum = 0;
            for (int number = 1; number < 21; number++)
            {
                if (number % 3 == 0)
                {
                    sum = sum + number;
                }
            }
            Console.WriteLine($"The sum is {sum}");
        }

    }
}
