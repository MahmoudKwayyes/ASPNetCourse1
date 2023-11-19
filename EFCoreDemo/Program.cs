using EFCoreDemo.Data;
using System.Net.Http.Headers;

namespace EFCoreDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (AppDBContext dbContext = new AppDBContext()) 
            { 
                var departments=dbContext.Department.ToList();
                Console.WriteLine();
            }
        }
    }
}