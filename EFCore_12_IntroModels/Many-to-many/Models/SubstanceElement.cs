using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore_12_IntroModels.Many_to_many.Models
{
    public class SubstanceElement
    {
        public int SubstanceId { get; set; }
        public Substance Substance { get; set; }


        public int ElementSerialNum { get; set; }
        public Element Element { get; set; }

    }
}
