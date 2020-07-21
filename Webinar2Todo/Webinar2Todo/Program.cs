using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
//to do:
//do skoñczenia czêœæ metod: jest tworzenie list, ale nie ma tworzenia itemów
//stworzyæ widoki do tworzenia itemów, edycji itemów, ewentualnie edycji listy(zmiana nazwy)
//sprawdziæ czy wszystko dzia³a
namespace Webinar2Todo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
