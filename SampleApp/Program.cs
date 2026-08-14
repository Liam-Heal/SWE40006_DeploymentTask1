using System;
using Newtonsoft.Json;

namespace SampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new { Message = "Deployment Task Test", Level = "Distinction (1.3)" };
            string json = JsonConvert.SerializeObject(data, Formatting.Indented);

            Console.WriteLine("Deployment Task Pass Level Test!");
            Console.WriteLine("Using Newtonsoft.Json to serialize sample data:");
            Console.WriteLine(json);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}