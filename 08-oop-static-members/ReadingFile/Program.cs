using System;
using System.IO;

namespace ReadingFile
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader("./data.csv"))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();


                    Console.WriteLine(line);
                    break;
                }
            }
        }
    }
    class DataReader
    {
        public static string Name(string row)
        {
            string[] divided = row.Split(",");
            string age = divided[1];
            foreach (char c in age)
            {
                if (Char.IsNumber(c))
                {
                    
                    return "hi";
                }
            
            }
        }

    }

}
