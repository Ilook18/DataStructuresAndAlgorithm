using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAlgorithm.Utility
{
    class Palindrome
    {
        public void PalindromeChecker(string str)
        {
            QueueOperation<char> queue = new QueueOperation<char>();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                queue.Enqueue(str[i]);
            }
            string reverse = "";
            while (!queue.IsEmpty())
            {
                reverse = reverse + queue.DeQueue();
            }
            if (str.Equals(reverse))
            {
                Console.WriteLine("string is palindrome");
            }
            else
            {
                Console.WriteLine("string is not palindrome");
            }
        }
    }
}