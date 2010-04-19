using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_Ale
{
    // Brew class - used as a base class - contains all common brew properties
    class Brew
    {
        #region Properties
        public int Id { get; set; }
        public string Type { get; set; }
        public string Sugar { get; set; }
        public string Yeast { get; set; }
        /*
        public DateTime DateBrewed { get; set; }
        public int InitialGravity { get; set; }
        public int InitialTemp { get; set; }
        public DateTime DateBottled { get; set; }
        public int FinalGravity { get; set; }
         */ 
        public string Status { get; set; }
        #endregion        
    }
}
