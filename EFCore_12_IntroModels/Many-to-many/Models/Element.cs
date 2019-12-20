using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore_12_IntroModels.Many_to_many.Models
{
    public class Element
    {
        public int SerialNum { get; set; }
        public string Name { get; set; }
        public int Mass { get; set; }


        public IList<SubstanceElement> SubstanceElements { get; set; }


        public Element()
        {
            SubstanceElements = new List<SubstanceElement>();
        }
    }
}
