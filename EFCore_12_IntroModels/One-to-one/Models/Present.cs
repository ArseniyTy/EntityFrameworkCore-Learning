using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore_12_IntroModels.One_to_one.Models
{
    public class Present
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        //One-to-one (in principle class)
        public Box PresentBox { get; set; } //nav ref property
    }
}
