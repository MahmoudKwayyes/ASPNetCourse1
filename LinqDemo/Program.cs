using System.Security.Cryptography;

namespace LinqDemo
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            List<Customer> AllCustomers = new()
            {
                new Customer(){CustomerId=1, FirstName="Ahmad", LastName="AlAhmad", Phone="123456", State="Aleppo", Balance=1500.00M},
                new Customer(){CustomerId=2, FirstName="Mahmoud", LastName="AlMahmoud", Phone="123456", State="Aleppo", Balance=250},
                new Customer(){CustomerId=3, FirstName="Jamal", LastName="AlJamal", Phone="452896", State="Idleb", Balance=8000},
                new Customer(){CustomerId=4, FirstName="Jalal", LastName="AlJalal", Phone="458214", State="Idleb", Balance=1457.5M},
                new Customer(){CustomerId=5, FirstName="Kamal", LastName="AlKamal", Phone="658621", State = "Damascus", Balance=288.75M},
                new Customer(){CustomerId=6, FirstName="Nidal", LastName="AlNidal", Phone="897566", State = "Aleppo", Balance=15000},
                new Customer(){CustomerId=7, FirstName="Wesal", LastName="AlWesal", Phone="254125", State = "Homs", Balance=45000},
                new Customer(){CustomerId=8, FirstName="Amal", LastName="AlAmal", Phone="785496", State = "Hamah", Balance=120},
                new Customer(){CustomerId=9, FirstName="Salim", LastName="AlSalim", Phone="875632", State = "Idleb", Balance=400},
                new Customer(){CustomerId=10, FirstName="Samir", LastName="AlSamir", Phone="874565", State = "Homs", Balance=9855.50M},
            };

            ////Query linq
            //var Customers=
            //from c
            //in AllCustomers
            //where c.Balance >= 500
            //select c;

            //Non-Query syntax/ Method syntax/ Fluent
            // List<Customer> result;
            //FilteredCustomers= AllCustomers.Where(c=>c.Balance>=5000 && c.State=="Homs").ToList();

            //result = AllCustomers.Where(c => c.Balance >= 5000 && c.State == "Homs")
            //                    .OrderBy(c => c.FirstName)
            //                    .ThenBy(c=>c.LastName)
            //                    .Distinct()
            //                    .ToList();


            //decimal maxBalance;
            //maxBalance= AllCustomers.Max(c => c.Balance);

            //var avg = AllCustomers.Average(c => c.Balance);

            //AllCustomers.Sum(x => x.Balance);

            //var result=AllCustomers.GroupBy(x=>x.State).ToList();

            //var result = AllCustomers.Single();
            //var result = AllCustomers.SingleOrDefault();

            //var result = AllCustomers.First();
            //var result = AllCustomers.FirstOrDefault();

            //var result = AllCustomers.Find(c => c.FirstName.StartsWith("A"));

            //var result=AllCustomers.Skip(1).ToList();
            //var result = AllCustomers.Take(5).ToList();
            //var result = AllCustomers.Skip(4).Take(1).ToList();

            var result = AllCustomers.Where(c => c.Balance >= 5000).Select(c=>new {c.FirstName, c.LastName})
                .ToList();

            //Console.WriteLine(result.FirstName);
            printCustomersData(result);


        }
        static void printCustomersData(List<Customer> customers)
        {
            foreach (var customer in customers)
            {
                Console.WriteLine($"{customer.FirstName} {customer.LastName}");
            }
        }
    }

    #region Old Code
    //List<string> list = new()
    //{
    //    "abc",
    //    "def",
    //    "ghi"
    //};

    /**/

    //() => Console.WriteLine(x);

    //    int method()
    //{
    //    int x = 4, y = 5;
    //    return x + y;
    //}
    /**/

    //TestClass.TestMethod(list);
    //list.TestMethod();
    static class TestClass
    {
        public static void TestMethod(this List<string> lst)
        {
            foreach (var item in lst)
            {
                Console.WriteLine(item);
            }
        }
    }
    #endregion
}