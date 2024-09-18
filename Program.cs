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
            Stack<int>  numbers = new Stack<int>();
            string operation = "512+4*+3-";
            operation.Trim().Split();
            int n = 0, total = 0;
            char firstChar;

            for (int i = 0; i < operation.Length; i++)
            {
                if (operation[i] == '+')
                {
                    n = numbers.Pop();
                    total = numbers.Pop();
                    total =total+ n;
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
            Console.WriteLine("Total is " + total);

          





        }

            }



        }
