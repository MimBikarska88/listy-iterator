using System;
using System.Linq;

namespace ListyIterator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            ListyIterator<string> listyIterator = null;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }else if (input.Contains("Create"))
                {
                    var collection = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    if (collection.Length > 1)
                    {
                        listyIterator = new ListyIterator<string>(collection.Skip(1).ToArray());

                    }
                    else
                    {
                        listyIterator = new ListyIterator<string>();
                    }
                }else if (input.Contains("Move"))
                {
                    Console.WriteLine(listyIterator.Move());
                }else if (input.Contains("HasNext"))
                {
                    Console.WriteLine(listyIterator.HasNext());
                }else if (input.Contains("PrintAll"))
                {
                    Console.WriteLine(string.Join(" ",listyIterator));
                }else if (input.Contains("Print"))
                {
                    try
                    {
                        listyIterator.Print();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Invalid operation!");
                    }
                }
                
            }
        }
    }
}