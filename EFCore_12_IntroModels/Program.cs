using System;
using System.Collections;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using EFCore_12_IntroModels.Models;
using EFCore_12_IntroModels.One_to_one;
using EFCore_12_IntroModels.One_to_one.Models;
using EFCore_12_IntroModels.Many_to_many;
using EFCore_12_IntroModels.Many_to_many.Models;

namespace EFCore_12_IntroModels
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var humanContext = new HumanContext())
            {
                /*//Deleting
                humanContext.Workers.RemoveRange(humanContext.Workers);
                humanContext.Countries.RemoveRange(humanContext.Countries);
                humanContext.SaveChanges();
                */


                /*//Add
                var country1 = new Country { Name = "Belarus" };
                var country2 = new Country { Name = "Russia" };
                humanContext.Countries.AddRange(country1, country2);
                humanContext.SaveChanges();

                var human1 = new Worker { Name = "Arseniy", Age = 17, Salary = 10000, Profession = "Programmer", CountryName=country1.Name };
                var human2 = new Worker { Name = "Tolic", Age = 44, Salary = 200, Profession = "Scientist", CountryName=country2.Name };
                humanContext.Workers.AddRange(human1, human2);
                humanContext.SaveChanges();
                */


                /*//Read - Eager
                foreach(var country in humanContext.Countries.Include(c => c.NationalWorkers).ToList())
                {
                    Console.WriteLine(country.Name+":");
                    foreach(var worker in country.NationalWorkers)
                        Console.WriteLine(worker.Profession);
                }
                //Read - Explictit
                foreach (var country in humanContext.Countries.ToList())
                {
                    Console.WriteLine(country.Name + ":");
                    humanContext.Entry(country).Collection(c => c.NationalWorkers).Load();
                    foreach (var worker in country.NationalWorkers)
                        Console.WriteLine(worker.Profession);
                }*/
            }

            using (var newYearContext = new NewYearContext())
            {
                /*//Add
                var present1 = new Present { Name = "Socks", Price = 39 };
                var present2 = new Present { Name = "Chocolate", Price = 83 };
                newYearContext.Presents.AddRange(present1,present2);
                newYearContext.SaveChanges();


                var box1 = new Box { Size = 20, Colour = "Blue", PresentId = present1.Id };
                var box2 = new Box { Size = 15, Colour = "Brown", PresentId = present2.Id };
                newYearContext.Boxes.AddRange(box1, box2);
                newYearContext.SaveChanges();
                */






                /*//Read - Eager
                foreach(var present in newYearContext.Presents.Include(p=>p.PresentBox).ToList())
                {
                    Console.WriteLine("{0} - {1} $; Box: {2}, {3}", present.Name, present.Price, present.PresentBox.Size, present.PresentBox.Colour);
                }
                //Read - Explicit
                foreach (var present in newYearContext.Presents.ToList())
                {
                    newYearContext.Entry(present).Reference(p => p.PresentBox).Load();
                    Console.WriteLine("{0} - {1} $; Box: {2}, {3}", present.Name, present.Price, present.PresentBox.Size, present.PresentBox.Colour);
                }
                */
            }

            using(var thingContext = new ThingContext())
            {
                //Add
                var substance1 = new Substance { Name = "H2SO4" };
                var substance2 = new Substance { Name = "H2O" };
                var substance3 = new Substance { Name = "HCl" };
                thingContext.Substances.AddRange(substance1, substance2, substance3);

                var element1 = new Element { Name = "H", Mass = 1, SerialNum = 1 };
                var element2 = new Element { Name = "O", Mass = 16, SerialNum = 12 };
                var element3 = new Element { Name = "S", Mass = 32, SerialNum = 26 };
                var element4 = new Element { Name = "Cl", Mass = 36, SerialNum = 35 };
                thingContext.Elements.AddRange(element1, element2, element3, element4);


                substance1.SubstanceElements.Add(new SubstanceElement { SubstanceId = substance1.Id, ElementSerialNum = element1.SerialNum });
                substance1.SubstanceElements.Add(new SubstanceElement { SubstanceId = substance1.Id, ElementSerialNum = element2.SerialNum });
                substance1.SubstanceElements.Add(new SubstanceElement { SubstanceId = substance1.Id, ElementSerialNum = element3.SerialNum });

                substance2.SubstanceElements.Add(new SubstanceElement { SubstanceId = substance1.Id, ElementSerialNum = element1.SerialNum });
                substance2.SubstanceElements.Add(new SubstanceElement { SubstanceId = substance1.Id, ElementSerialNum = element2.SerialNum });

                substance3.SubstanceElements.Add(new SubstanceElement { SubstanceId = substance1.Id, ElementSerialNum = element1.SerialNum });
                substance3.SubstanceElements.Add(new SubstanceElement { SubstanceId = substance1.Id, ElementSerialNum = element4.SerialNum });

                thingContext.SaveChanges();
            }
        }
    }
}
