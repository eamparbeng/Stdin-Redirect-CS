using System;
using System.IO;

namespace console_redir_proto1
{
    class Program
    {
        static void Main(string[] args)
        {
            TextReader reader = null;

            if (args.Length == 0 || !File.Exists(args[0]))
            {
                if (!Console.IsInputRedirected)
                {
                    Console.WriteLine("No pipe!");
                    return;
                }
                reader = Console.In;
            }
            else
            {
                reader = new StreamReader(args[0]);
            }

            string line = null;
            int counter = 0;
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine($"{++counter} Processed: {line}");
            }
        }
    }
}
