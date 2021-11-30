using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAlgorithm.Utility
{
    class BalancedParenthesis
    {

        StackOperation<string> stack = new StackOperation<string>();
        public void ParanthsisCheck(string BalFilePath)
        {
            string text = File.ReadAllText(BalFilePath);
            string[] par = text.Split(" ");
            foreach (var item in par)
            {
                if (item == "(")
                {
                    stack.Push("(");
                }
                if (item == ")")
                {
                    stack.Pop(")");
                }
            }
            if (stack.IsEmpty())
            {
                Console.WriteLine("This is a Balanced Prenthesis");
            }
            else
            {
                Console.WriteLine("This is not a Balanced Parenthesis");
            }
        }
    }
}