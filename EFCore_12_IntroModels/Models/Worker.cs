using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore_12_IntroModels.Models
{
    public class Worker
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
        public string Profession { get; set; }

        //public Worker(int id, string name, int age, int salary, string profession)
        //{
        //    Id = id;
        //    Name = name;
        //    Age = age;
        //    Salary = salary;
        //    Profession = profession;
        //}
    }
}
