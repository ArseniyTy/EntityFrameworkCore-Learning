using System;
using EFCore_12_IntroModels.Models;

namespace EFCore_12_IntroModels
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var humanContext = new HumanContext())
            {
                var country1 = new Country { Name = "Belarus" };
                var human1 = new Worker { Name = "Arseniy", Age = 17, Salary = 10000, Profession = "Programmer", Country=country1, CountryName=country1.Name };
                humanContext.Workers.Add(human1);
                humanContext.Countries.Add(country1);
                humanContext.SaveChanges();
            }
        }
    }
}
