using HotelManagementSystem.Business.Staff;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.Business.Accounts
{
    internal class AccountControll
    {
        #region Data Members
        private Collection<Account> _accounts;
        private AccountDB _accountDB;
        private string sqlQuery = "SELECT * FROM Accounts";
        private string table = "Accounts";
        #endregion

        #region Mutators
        public Collection<Account> allAcounts { get => _accounts; }
        #endregion

        #region Constructors
        public AccountControll()
        {
            //_accounts = new Collection<Account>();
            _accountDB = new AccountDB();
            GetAllAccounts();
        }
        #endregion

        #region CRUD Methods
        private void GetAllAccounts()
        {
            if (_accounts != null) { _accounts.Clear(); }

            
            _accountDB.RunQuery(sqlQuery, table);
            _accounts = _accountDB.allAccounts;
        }

        public void UpdateDataSet(Account a, int flag)
        {
            _accountDB.UpdateDataSet(a, flag);
        }
        public void UpdateDataSource()
        {
            _accountDB.UpdateDataSource(sqlQuery, table);
        }
        #endregion

        #region Utility methods
        public Account Find(string id)
        {
            int index = 0;
            int count = _accounts.Count;
            bool found = (_accounts[index].empID == id);
            while (!found && index < count - 1)
            {
                index++;
                found = (_accounts[index].empID == id);


            }
            if (found)
            {
                return _accounts[index];
            }
            else
            {
                return null;
            }
        }
        #endregion
    }
}
