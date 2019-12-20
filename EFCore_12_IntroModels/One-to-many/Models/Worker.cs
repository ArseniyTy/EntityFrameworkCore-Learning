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

        //One to many (in dependent)
        public string CountryName { get; set; } //foreign key (then set by Fluent API)
        public Country Country { get; set; } //reference navigation property
    }
}
