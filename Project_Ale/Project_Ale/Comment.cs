using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_Ale
{
    class Comment
    {
        #region Properties
        public int Id { get; set; }
        public int BrewId { get; set; }
        public DateTime Added { get; set; }
        public string CommentText { get; set; }
        #endregion
    }
}
