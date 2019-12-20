using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore_12_IntroModels.Many_to_many.Models
{
    public class Substance
    {
        public int Id { get; set; }
        public string Name { get; set; }



        public IList<SubstanceElement> SubstanceElements { get; set; }

        public Substance()
        {
            SubstanceElements = new List<SubstanceElement>();
        }
    }
}
