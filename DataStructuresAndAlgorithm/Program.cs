using System;
using DataStructuresAlgorithm.Utility;

namespace DataStructuresAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("CHOOSE OPTION : 1.Unordered List\n2.OrderedList\n 3.BalancedParanthesis\n 4.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        UnOrderedList unorder = new UnOrderedList();
                        unorder.WordSearch(@"C:\Users\DELL\source\repos\DataStructuresAndAlgorithm\Utility\Word.txt");
                        break;
                    case 2:
                        OrderedList order = new OrderedList();
                        order.Numbers(@"c:\users\dell\source\repos\datastructuresandalgorithm\Utility\Numbers.txt");
                        break;
                    case 3:
                        BalancedParenthesis Bal = new BalancedParenthesis();
                        Bal.ParanthsisCheck(@"C:\Users\DELL\source\repos\DataStructuresAndAlgorithm\Utility\parenthesis.txt");
                        break;
                    case 4:
                        flag = false;
                        break;

                }
            }

        }
    }
}