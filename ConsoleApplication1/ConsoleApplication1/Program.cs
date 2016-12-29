using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            step2();
            step3();
            step4();
            step5();
            Console.Read();
        }
        public static void step5()
        {
            string brm1, brm2, miktar, deger, h1, h2;
            Console.WriteLine("Döviz Birimini Giriniz! \n örn: 150 TRY-EUR");
            deger = Console.ReadLine();

            string[] duzen = deger.Split('-',' ');
            miktar = duzen[0];
            brm1 = duzen[1];
            brm2 = duzen[2];

            string url = "http://api.fixer.io/latest?base=" + brm1;
            WebClient client = new WebClient();
            string reply = client.DownloadString(url);
            Lesson3 down = JsonConvert.DeserializeObject<Lesson3>(reply);
            double sonuc = down.rates[brm2] * int.Parse(miktar);
            Console.WriteLine(sonuc + " " + brm2);
        }
        public static void step2()
        {
            Console.WriteLine("Hello World!");

        }
        public static void step3()
        {
            Lesson ls = new Lesson()
            {
                Name = "Day 1 Task 3",
                Code = "C++ Kodlama"
            };
            string json = JsonConvert.SerializeObject(ls);
            Console.WriteLine(json);
        }
        public static void step4()
        {
            //string url = "https://raw.githubusercontent.com/mhs/world-currencies/master/currencies.json";
            //WebClient client = new WebClient();
            //string reply = client.DownloadString(url);
            //Console.WriteLine(reply);
            Lesson2 indirText = new Lesson2
            {
                url = "https://raw.githubusercontent.com/mhs/world-currencies/master/currencies.json"
            };
            indirText.Donustur();
            indirText.Goruntule();
        }
    }
}
