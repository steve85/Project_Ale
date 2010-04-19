using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_Ale
{
    // This class is the core of the application
    class HomebrewManager
    {
        // Local variables
        private List<Brew> _listBrews = new List<Brew>();
        private List<BrewingBrew> _listBrewingBrews = new List<BrewingBrew>();
        private List<BottledBrew> _listBottledBrews = new List<BottledBrew>();
        private List<KeggedBrew> _listKeggedBrews = new List<KeggedBrew>();

        public HomebrewManager()
        {
        }

        // Method called at start will load data from database
        private void LoadData()
        {
            // ### Code here for data loading
        }

        #region List Accessor Methods

        public List<Brew> GetListBrews()
        {
            return this._listBrews;
        }

        public List<BrewingBrew> GetListBrewingBrews()
        {
            return this._listBrewingBrews;
        }

        public List<BottledBrew> GetListBottledBrews()
        {
            return this._listBottledBrews;
        }

        public List<KeggedBrew> GetListKeggedBrews()
        {
            return this._listKeggedBrews;
        }

        #endregion

        #region List Add Methods

        public void AddListBrews(Brew inBrew)
        {
            this._listBrews.Add(inBrew);
        }

        public void AddListBrewingBrews(BrewingBrew inBrewingBrew)
        {
            this._listBrewingBrews.Add(inBrewingBrew);
        }

        public void AddListBottledBrews(BottledBrew inBottledBrew)
        {
            this._listBottledBrews.Add(inBottledBrew);
        }

        public void AddListKeggedBrews(KeggedBrew inKeggedBrew)
        {
            this._listKeggedBrews.Add(inKeggedBrew);
        }

        #endregion

        #region Brew Management Methods

        public OperationResult AddNewBrew()
        {
            OperationResult result = new OperationResult();
            return result;
        }

        public OperationResult EditExistingBrew()
        {
            OperationResult result = new OperationResult();
            return result;
        }

        #endregion
    }
}
