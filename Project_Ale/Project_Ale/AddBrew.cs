using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_Ale
{
    class AddBrew
    {
        private HomebrewManager _homebrewManager;
        private OperationResult _result;
        private Object _brewType;

        public AddBrew(HomebrewManager inHomebrewManager, OperationResult inResult, Object inBrewType)
        {
            _homebrewManager = inHomebrewManager;
            _result = inResult;
            _brewType = inBrewType;

            // Determine which kind of object to add
            switch (this._brewType.GetType().ToString())
            {
                // ### determine the object type
                default:
                    break;
            }
        }
    }
}
