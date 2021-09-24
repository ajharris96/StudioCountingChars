using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace StudioCountingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = @"/Users/andrew300/Desktop/csharp/StudioCountingChars/StudioCountingChars/stringfile.txt";
            string fromTextFile = File.ReadAllText(fileName);

            //Console.WriteLine("Enter a string:");
            //string usrString = Console.ReadLine();

            string usrString1 = fromTextFile.ToLower();
            string cleanString = new string(usrString1.Where(Char.IsLetter).ToArray());

            //string myString = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";

            char[] charactersInString = cleanString.ToCharArray();
            Dictionary<char, int> charCounts = new Dictionary<char, int>();

            foreach (char element in charactersInString)
            {
                if (!charCounts.ContainsKey(element))
                {
                    charCounts.Add(element,0);
                }
                
                charCounts[element] += 1;
            }

            foreach (KeyValuePair<char, int> entry in charCounts)
            {
                Console.WriteLine(entry.Key + ": " + entry.Value);
            }




        }
    }
}
