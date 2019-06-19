using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ConsoleApp17
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the Path");
            string path = Console.ReadLine();
            ReadTextFile(path);
        }

        // this method can replace with Recursive function to make it more robust 
        // if I'm given job oportunity I will submit code with Recursive function

        private static void ReadTextFile(string path)
        {
            string string1 = ""; Decimal elaps1;
           
            string[] lines = File.ReadAllLines(path);

            var list = new List<KeyValuePair<string, Decimal>>();

            var Listabove = new List<KeyValuePair<string, Decimal>>();

            for (int i = 0; i < lines.Count(); i++)
            {

                int result; int result1;
                int a = 0;

                if (lines[i].Split(',')[0] == "start" && lines[i + 1].Split(',')[0] != "stop")
                  
                   Listabove.Add(new KeyValuePair<string, Decimal>(lines[i].Split(',')[1], Convert.ToDecimal(lines[i].Split(',')[2])));

                if (lines[i].Split(',')[0] == "stop")

                            {
                                if(lines[i - 1].Split(',')[0] != "stop")
                                { 
                                    var j = Convert.ToDecimal(lines[i - 1].Split(',')[2]);
                    
                                    var j1 = Convert.ToDecimal(lines[i].Split(',')[1]);

                                     var elapstime = j1 - j;

                                 list.Add(new KeyValuePair<string, Decimal>(lines[i - 1].Split(',')[1], elapstime));

                                 // catch left over 

                                    if (lines[i + 1].Split(',')[0] == "stop")
                                    {
                                        var k = Convert.ToDecimal(lines[i + 1].Split(',')[1]);
                            
                                        list.Add(new KeyValuePair<string, Decimal>(Listabove.Last().Key, k - Listabove.Last().Value));

                                        Listabove.RemoveAt(Listabove.Count - 1);
                                        if (lines[i + 2].Split(',')[0] == "stop")
                                        {
                                            var k2 = Convert.ToDecimal(lines[i + 2].Split(',')[1]);

                                            list.Add(new KeyValuePair<string, Decimal>(Listabove.Last().Key, k2 - Listabove.Last().Value));

                                            Listabove.RemoveAt(Listabove.Count - 1);

                                            if ((i+3) <= lines.Count()-1)
                                             {

                                                if (lines[i + 3].Split(',')[0] == "stop")
                                                    {
                                                        var k3 = Convert.ToDecimal(lines[i + 3].Split(',')[1]);

                                                        list.Add(new KeyValuePair<string, Decimal>(Listabove.Last().Key, k3 - Listabove.Last().Value));

                                                        Listabove.RemoveAt(Listabove.Count - 1);

                                                            if ((i + 4) <= lines.Count() - 1)
                                                            {

                                                                if (lines[i + 4].Split(',')[0] == "stop")
                                                                {
                                                                    var k4 = Convert.ToDecimal(lines[i + 4].Split(',')[1]);

                                                                    list.Add(new KeyValuePair<string, Decimal>(Listabove.Last().Key, k4 - Listabove.Last().Value));

                                                                    Listabove.RemoveAt(Listabove.Count - 1);

                                                                    if ((i + 5) <= lines.Count() - 1)
                                                                    {

                                                                        if (lines[i + 5].Split(',')[0] == "stop")
                                                                        {
                                                                            var k5 = Convert.ToDecimal(lines[i + 5].Split(',')[1]);

                                                                            list.Add(new KeyValuePair<string, Decimal>(Listabove.Last().Key, k5 - Listabove.Last().Value));

                                                                            Listabove.RemoveAt(Listabove.Count - 1);

                                                                        if ((i + 6) <= lines.Count() - 1)
                                                                        {

                                                                            if (lines[i + 6].Split(',')[0] == "stop")
                                                                            {
                                                                                var k6 = Convert.ToDecimal(lines[i + 6].Split(',')[1]);

                                                                                list.Add(new KeyValuePair<string, Decimal>(Listabove.Last().Key, k6 - Listabove.Last().Value));

                                                                                Listabove.RemoveAt(Listabove.Count - 1);

                                                                                if ((i + 7) <= lines.Count() - 1)
                                                                                {

                                                                                    if (lines[i + 7].Split(',')[0] == "stop")
                                                                                    {
                                                                                        var k7 = Convert.ToDecimal(lines[i + 7].Split(',')[1]);

                                                                                        list.Add(new KeyValuePair<string, Decimal>(Listabove.Last().Key, k7 - Listabove.Last().Value));

                                                                                        Listabove.RemoveAt(Listabove.Count - 1);

                                                                                    if ((i + 8) <= lines.Count() - 1)
                                                                                    {

                                                                                        if (lines[i + 8].Split(',')[0] == "stop")
                                                                                        {
                                                                                            var k8 = Convert.ToDecimal(lines[i + 8].Split(',')[1]);

                                                                                            list.Add(new KeyValuePair<string, Decimal>(Listabove.Last().Key, k8 - Listabove.Last().Value));

                                                                                            Listabove.RemoveAt(Listabove.Count - 1);
                                                                                        if ((i + 9) <= lines.Count() - 1)
                                                                                        {

                                                                                            if (lines[i + 9].Split(',')[0] == "stop")
                                                                                            {
                                                                                                var k9 = Convert.ToDecimal(lines[i + 9].Split(',')[1]);

                                                                                                list.Add(new KeyValuePair<string, Decimal>(Listabove.Last().Key, k9 - Listabove.Last().Value));

                                                                                                Listabove.RemoveAt(Listabove.Count - 1);

                                                                                            }
                                                                                        }

                                                                            }
                                                                                    }

                                                                            }
                                                                                }

                                                            }
                                                                        }

                                                    }
                                                                    }

                                            }
                                                            }
                                                    }
                                            }


                                    }
                                }
                        

                          }
                               
                }

               
            }


            foreach (var item in list)
            {
                Console.WriteLine($" {item.Key} :     {item.Value}");
                
            }
            Console.ReadLine();

        }

    }
}

   
