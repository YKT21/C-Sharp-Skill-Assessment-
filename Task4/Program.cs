using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Task 4 Ass 3 of 3
            StreamReader reader = new StreamReader(@"e:\YTafe\MProject\characters.txt");
            StreamWriter writer = new StreamWriter(@"e:\YTafe\MProject\character_count.txt", true);

            try
            {
                Dictionary<char, int> countMe = new Dictionary<char, int>();
                while (reader.EndOfStream == false)
                {
                    char c = (char)reader.Read();
                    if (countMe.ContainsKey(c) == true)
                    {
                        countMe[c]++;
                    }
                    else
                    {
                        countMe.Add(c, 1);
                    }
                }

                foreach (KeyValuePair<char, int> charMe in countMe.OrderBy(charMe => charMe.Key))
                {
                    Console.WriteLine($"{charMe.Key} {charMe.Value}");
                    writer.WriteLine($"{charMe.Key}{charMe.Value}");

                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Something has gone wrong");
                Console.WriteLine(e.Message.ToString());
            }
            finally
            {
                reader.Close();
                writer.Close();

            }
        }
    }
}
