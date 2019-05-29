using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;

namespace ClinicalSystem.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "http://localhost:51636/api/OrderApi";
            var json = new WebClient().DownloadString(url);

            dynamic m = JsonConvert.DeserializeObject(json);
           
            foreach (var item in m)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
