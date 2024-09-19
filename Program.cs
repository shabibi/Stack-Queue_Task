namespace S_Q_task
{using System.Collections;
    using System.Numerics;
    using System.Timers;

    internal class Program
    {
        static void Main(string[] args)
        {
            //Stack
            //Task1
            Console.WriteLine("********************************\nTask1");
            Stack<int> numbers = new Stack<int>();
            string operation = "512+4*+3-";

            int n = 0, total = 0;


            for (int i = 0; i < operation.Length; i++)
            {
                if (operation[i] == '+')
                {
                    n = numbers.Pop();
                    total = numbers.Pop();
                    total = total + n;
                    numbers.Push(total);
                }

                else if (operation[i] == '-')
                {
                    n = numbers.Pop();
                    total = numbers.Pop();
                    total = total - n;
                    numbers.Push(total);
                }
                else if (operation[i] == '*')
                {
                    n = numbers.Pop();
                    total = numbers.Pop();
                    total = total * n;
                    numbers.Push(total);
                }

                else if (operation[i] == '/')
                {
                    n = numbers.Pop();
                    total = numbers.Pop();
                    total /= n;
                    numbers.Push(total);
                }

                else
                {
                    numbers.Push(int.Parse(operation[i].ToString()));
                }
            }
            Console.WriteLine(" Evaluate Postfix Expression(5 1 2 + 4 * + 3 - ):Total is " + total);

            //**************************************************************
            //Task2:
            Console.WriteLine("********************************\nTask2");
            Stack<char> stack1 = new Stack<char>();
            Console.WriteLine("Enter your input");
            string input = Console.ReadLine();
            Console.WriteLine("Input reverse is: ");
            foreach (char s in input)
            {
                stack1.Push(s);
            }
            while (stack1.Count > 0)
            {
                Console.Write(stack1.Pop());
            }
            Console.WriteLine();
            //***************************************************
            //Task3:
            Console.WriteLine("********************************\nTask3");
            Stack<char> stack2 = new Stack<char>();
            Console.WriteLine("Enter parenthesis ");
            string input2 = Console.ReadLine();
            int openParenthesis = 0;
            int CloseParenthesis = 0;

            foreach (char s in input2)
            {
                stack2.Push(s);
            }
            foreach (char s in stack2)
            {
                if (s == '(')
                    openParenthesis++;
                else if (s == ')')
                    CloseParenthesis++;
            }
            if (openParenthesis == CloseParenthesis)
                Console.WriteLine("Balanced Parenthesis ");
            else
                Console.WriteLine("Not Balanced Parenthesis");
        }
    }
}
