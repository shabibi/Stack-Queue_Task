namespace S_Q_task
{using System.Collections;
    using System.Numerics;
    using System.Timers;

    internal class Program
    {
        static void Main(string[] args)
        {
            ////Stack
            ////Task1
            //Console.WriteLine("********************************\nTask1");
            //Stack<int> numbers = new Stack<int>();
            //string operation = "512+4*+3-";

            //int n = 0, total = 0;


            //for (int i = 0; i < operation.Length; i++)
            //{
            //    if (operation[i] == '+')
            //    {
            //        n = numbers.Pop();
            //        total = numbers.Pop();
            //        total = total + n;
            //        numbers.Push(total);
            //    }

            //    else if (operation[i] == '-')
            //    {
            //        n = numbers.Pop();
            //        total = numbers.Pop();
            //        total = total - n;
            //        numbers.Push(total);
            //    }
            //    else if (operation[i] == '*')
            //    {
            //        n = numbers.Pop();
            //        total = numbers.Pop();
            //        total = total * n;
            //        numbers.Push(total);
            //    }

            //    else if (operation[i] == '/')
            //    {
            //        n = numbers.Pop();
            //        total = numbers.Pop();
            //        total /= n;
            //        numbers.Push(total);
            //    }

            //    else
            //    {
            //        numbers.Push(int.Parse(operation[i].ToString()));
            //    }
            //}
            //Console.WriteLine(" Evaluate Postfix Expression(5 1 2 + 4 * + 3 - ):Total is " + total);

            ////**************************************************************
            ////Task2:
            //Console.WriteLine("********************************\nTask2");
            //Stack<char> stack1 = new Stack<char>();
            //Console.WriteLine("Enter your input");
            //string input = Console.ReadLine();
            //Console.WriteLine("Input reverse is: ");
            //foreach (char s in input)
            //{
            //    stack1.Push(s);
            //}
            //while (stack1.Count > 0)
            //{
            //    Console.Write(stack1.Pop());
            //}
            //Console.WriteLine();
            ////***************************************************
            ////Task3:
            //Console.WriteLine("********************************\nTask3");
            //Stack<char> stack2 = new Stack<char>();
            //Console.WriteLine("Enter parenthesis ");
            //string input2 = Console.ReadLine();
            //int openParenthesis = 0;
            //int CloseParenthesis = 0;

            //foreach (char s in input2)
            //{
            //    stack2.Push(s);
            //}
            //foreach (char s in stack2)
            //{
            //    if (s == '(')
            //        openParenthesis++;
            //    else if (s == ')')
            //        CloseParenthesis++;
            //}
            //if (openParenthesis == CloseParenthesis)
            //    Console.WriteLine("Balanced Parenthesis ");
            //else
            //    Console.WriteLine("Not Balanced Parenthesis");
            ////***************************************************
            ////Task4:
            //Console.WriteLine("********************************\nTask 4");
            //Console.WriteLine("How many numbers you whant to push");
            //int count = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Your Numbers: ");
            //Stack<int> stackMaxNUM = new Stack<int>();
            //int MAXNum = 0;
            //for (int i = 0; i < count; i++)
            //{
            //    stackMaxNUM.Push(int.Parse(Console.ReadLine()));
            //    if(MAXNum > stackMaxNUM.Peek())
            //    {
            //        stackMaxNUM.Pop();
            //    }  
            //    else
            //        MAXNum = stackMaxNUM.Peek();
            //}
            //Console.WriteLine("Maximum Element in a Stack is "+ stackMaxNUM.Peek());

            //***************************************************
            //Bonus : Sort a Stack Using Another Stack
            //Console.WriteLine("********************************\nBonus");
            //Console.WriteLine("How many numbers you whant to push");
            //int countNum = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Your Numbers: ");
            //Stack<int>  stackSort = new Stack<int>();
            //Stack<int> temp = new Stack<int>();
            //int max = 0;
            //for(int i = 0;i < countNum; i++)
            //{
            //  stackSort.Push(int.Parse(Console.ReadLine()));
            //}
            //Console.WriteLine("The elements in ascending order ");
            
            //do
            //{
            //    temp.Clear();
            //    max = stackSort.Max();
            //    while (stackSort.Count > 0)
            //    {
                    
            //        if (max == stackSort.Peek())
            //        {
            //            Console.WriteLine(max);
            //            stackSort.Pop();
            //        }
            //        else
            //        {
            //            temp.Push(stackSort.Pop());
            //        }
            //    }
            //    foreach(int n in temp)
            //    {
            //        stackSort.Push(n);
            //    }
               
                
            //} while (temp.Count > 1);
            //Console.WriteLine(stackSort.Peek());

            //***************************************************
            //Queue
            //Task 1: Reverse a Queue
            //Console.WriteLine("********************************\nQueue\nTask1");
            //Console.WriteLine("Queue: 1, 2, 3, 4, 5");
            //int[] numbers = { 1,2,3,4,5};
            //Queue<int> queue = new Queue<int>();
            //Stack<int> stack = new Stack<int>();
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    stack.Push(numbers[i]);
            //}
            //foreach (int i in stack)
            //{
            //    queue.Enqueue(i);
            //}
            
            //Console.WriteLine();
            //Console.Write("Reversed Queue: ");
            //while(queue.Count>0)
            //{
            //    Console.Write(queue.Dequeue() + " ");
            //}

            //***************************************************
            //Task 2: Check if a Queue is a Palindrome
            //Console.WriteLine("********************************\nTask2:Check if a Queue is a Palindrome");
            //Queue<char> Qpalindrome = new Queue<char>();
            //Stack<char> SPalindrome = new Stack<char>();

            //Console.WriteLine("Enter number ");

            //string num = Console.ReadLine();
            //bool flag = false;
            //for (int i = 0; i < num.Length; i++)
            //{
            //    Qpalindrome.Enqueue(num[i]);
            //    SPalindrome.Push(num[i]);
            //}
            //while (Qpalindrome.Count > 0)
            //{
            //    if (Qpalindrome.Dequeue() == SPalindrome.Pop())
            //        flag = true;
            //    else
            //    {
            //        flag = false;
            //        break;
            //    }
            //}
            //if (flag == true)
            //{
            //    Console.WriteLine("Palindrome");

            //}
            //else
            //{
            //    Console.WriteLine("Not Palindrome");
            //}

            //***************************************************
            //Bonus: Find the Maximum Element in a Sliding Window of Size K 
            Console.WriteLine("********************************" +
                "\nBonus: Find the Maximum Element in a Sliding Window of Size K ");
            Console.WriteLine("Enter number of elements");
            int len = int.Parse(Console.ReadLine());
            Queue<int> number = new Queue<int>();
            Queue<int> Sliding = new Queue<int>();
            int max = 0;
            Console.WriteLine("Enter "+len+" elements");
            for (int i = 0; i < len; i++)
            {
                number.Enqueue(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("Enter Sliding Window of Size  ");
            int k = int.Parse(Console.ReadLine());
            while(number.Count>0)
            {
                while (Sliding.Count < k)
                {
                    Sliding.Enqueue(number.Dequeue());
                }
                max = Sliding.Max();
                Console.Write(max.ToString() +' ');
                Sliding.Dequeue();
                
            }
            
        }

    }

    }
