using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore_12_IntroModels.Models
{
    public class Country
    {
        public string Name { get; set; }

        //One-to-many (in principle)
        public List<Worker> NationalWorkers { get; set; } //reference navigation property
    }
}
