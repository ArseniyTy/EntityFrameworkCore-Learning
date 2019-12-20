using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore_12_IntroModels.One_to_one.Models
{
    public class Box
    {
        public int Id { get; set; }
        public int Size { get; set; }
        public string Colour { get; set; }

        
        //One-to-one (in dependent class)
        public int PresentId { get; set; } //foreign key, conventions
        public Present Present { get; set; } //nav ref property
    }
}
