using Microsoft.AspNetCore;
using ProyectoEntropy;
using ProyectoEntropy.Models;

namespace EmployeeApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();

            //using (var context = new DBEntropyContext())
            //{
            //    //foreach (var EmployeeType in context.EmployeeTypes.ToList())
            //    //{
            //    //    Console.WriteLine(EmployeeType.Title);
            //    //}
            //}
           
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<StartUp>();


       
    }
}



