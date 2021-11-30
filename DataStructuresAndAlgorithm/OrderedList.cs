using System;
using System.IO;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using DataStructuresAlgorithm.Utility;



using System.Threading.Tasks;
using DataStructuresAlgorithm.Utility;

namespace DataStructuresAlgorithm.Utility
{
    class OrderedList
    {
        LinkedList<string> linkedList = new LinkedList<string>();

        public void Numbers(string NumFilePath)
        {
            string num = File.ReadAllText(NumFilePath);
            string[] numbers = num.Split(" ");
            foreach (var result in numbers)
            {
                linkedList.Add(result);

            }
            Console.WriteLine("enter the word you want to search for");
            string number = Console.ReadLine();
            if (linkedList.Search(number))
            {
                linkedList.Delete(number);
            }
            else
            {
                linkedList.Add(number);
            }
            linkedList.Display();
            string text = linkedList.Write();
            File.WriteAllText(NumFilePath, text);
        }
    }
}