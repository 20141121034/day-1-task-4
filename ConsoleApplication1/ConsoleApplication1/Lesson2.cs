using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Lesson2
    {
        public string cc { get; set; }
        public string symbol { get; set; }
        public string name { get; set; }
        public string url { get; set; }

        public List<Lesson2> Currencies;
        public void Donustur()
        {
            string jsontext = new WebClient().DownloadString(url);

            Currencies = JsonConvert.DeserializeObject<List<Lesson2>>(jsontext);
        }
        public void Goruntule()
        {
            foreach (var data in Currencies)
            {
                Console.WriteLine(data.cc + "\t"
                    + data.symbol + "\t"
                    + data.name);
            }

        }
    }
}
