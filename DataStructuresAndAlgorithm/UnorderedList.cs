using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructuresAlgorithm.Utility;

namespace DataStructuresAlgorithm.Utility
{
    class UnOrderedList
    {
        LinkedList<string> linkedList = new LinkedList<string>();

        public void WordSearch(string WordFilepath)
        {
            string data = File.ReadAllText(WordFilepath);
            string[] words = data.Split(" ");
            foreach (var result in words)
            {
                linkedList.Add(result);

            }
            Console.WriteLine("enter the word you want to search for");
            string word = Console.ReadLine();
            if (linkedList.Search(word))
            {
                linkedList.Delete(word);
            }
            else
            {
                linkedList.Add(word);
            }
            linkedList.Display();
            string text = linkedList.Write();
            File.WriteAllText(WordFilepath, text);
        }
    }
}