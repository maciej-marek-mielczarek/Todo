using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
//to do:
//do sko�czenia cz�� metod: jest tworzenie list, ale nie ma tworzenia item�w
//stworzy� widoki do tworzenia item�w, edycji item�w, ewentualnie edycji listy(zmiana nazwy)
//sprawdzi� czy wszystko dzia�a
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
