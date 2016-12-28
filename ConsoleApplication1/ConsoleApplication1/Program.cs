using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //project2();
            //project3();
            project4();
            Console.Read();
        }
        public static void project2()
        {
            Console.WriteLine("Hello World!");

        }
        public static void project3()
        {
            Lesson ls = new Lesson()
            {
                Name = "Day 1 Task 3",
                Code = "C++ Kodlama"
            };
            string json = JsonConvert.SerializeObject(ls);
            Console.WriteLine(json);
        }
        public static void project4()
        {
            //string url = "https://raw.githubusercontent.com/mhs/world-currencies/master/currencies.json";
            //WebClient client = new WebClient();
            //string reply = client.DownloadString(url);
            //Console.WriteLine(reply);

            Lesson2 currency = new Lesson2
            {
                url = "https://raw.githubusercontent.com/mhs/world-currencies/master/currencies.json"
            };
            currency.Donustur();

            currency.Goruntule();
        }
    }
}
