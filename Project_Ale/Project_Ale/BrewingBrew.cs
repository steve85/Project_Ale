using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_Ale
{
    class BrewingBrew : Brew
    {
        #region Properties
        public int BrewingBrewId { get; set; }
        public DateTime DateBrewed { get; set; }
        public int InitialGravity { get; set; }
        public int InitialTemp { get; set; }
        #endregion
    }
}
