using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_Ale
{
    class BottledBrew : BrewingBrew
    {
        public int BottledBrewId { get; set; }
        public int FinalGravity { get; set; }
        public int FinalTemp { get; set; }
        public string Label { get; set; }
        public int Longnecks { get; set; }
        public int Stubbies { get; set; }
    }
}
