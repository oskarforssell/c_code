using System;

namespace NeedleInHaystack
{
    class Program
    {
        static void Main(string[] args)
        {

            string hay = "There are Snakes on the plane";
            Console.WriteLine(NeedleInAHaystack("snakes", hay));
            Console.WriteLine(NeedleInAHaystack("Snakes", hay));
            Console.WriteLine(NeedleInAHaystack("snakes2", hay));

            static bool NeedleInAHaystack(string needle, string haystack)
            {
                int needleLen = needle.Length;

                for (int i=0; i < haystack.Length - needleLen; i++)
                {
                    string tmp = haystack.Substring(i, needleLen);
                    // Console.WriteLine(tmp); //only to see the output of the substring

                    if (tmp.Equals(needle))
                    {
                        return true;
                    }
                }
                return false;
            }
        }
    }
}
