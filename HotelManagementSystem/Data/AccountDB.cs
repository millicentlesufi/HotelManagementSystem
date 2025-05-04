using HotelManagementSystem.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.Business.Accounts
{
    internal class AccountDB : DataBase
    {
        #region Data Members
        private Collection<Account> _accounts;
        private string sqlLocal = "SELECT * FROM Accounts";
        private string table = "Accounts";
        #endregion

        #region Mutators
        public Collection<Account> allAccounts { get => _accounts; }
        #endregion

        #region Constructor
        public AccountDB() : base()
        {
            _accounts = new Collection<Account>();
        }
        #endregion

        #region Utility methods
        public void AddToCollection(string table)
        {
            //DataRow row = null;
            Account account;

            foreach (DataRow r in dsMain.Tables[table].Rows)
            {
                if (!(r.RowState == DataRowState.Deleted))
                {
                    account = new Account();
                    account.empID = Convert.ToString(r["EMP_ID"]);
                    account.password = Convert.ToString(r["Password"]);
                    account.role = Convert.ToInt32(r["Role"]);
                    _accounts.Add(account);
                }

            }
        }

        public void RunQuery(string sql, string table)
        {
            FillDataSet(sql, table);
            AddToCollection(table);
        }

        private int FindRow (string id)
        {
            int index = 0;
            int value = -1;

            foreach (DataRow r in dsMain.Tables[table].Rows)
            {
                if (r.RowState != DataRowState.Deleted)
                {
                    if (id == Convert.ToString(dsMain.Tables[table].Rows[index]["EMP_ID"]))
                    {
                        value = index;
                    }
                }
                index++;
            }
            return value;
        }

        public void UpdateDataSet(Account a, int flag)
        {
            DataRow row = null;
            if (flag == 1)
            {
                int index = FindRow(a.empID);
                row = dsMain.Tables[table].Rows[index];
                row["Password"] = Convert.ToString(a.password);
                row["Role"] = Convert.ToString(a.role);
                AddToCollection(table);

            }
            else if (flag == 2)
            {
                row = dsMain.Tables[table].NewRow();
                row["EMP_ID"] = a.empID;
                row["Password"]= Convert.ToString(a.password);
                row["Role"] = a.role;
                dsMain.Tables[table].Rows.Add(row);
                AddToCollection (table);
            }
            else if (flag == 3)
            {
                int index = FindRow(a.empID);
                dsMain.Tables[table].Rows[index].Delete();
                _accounts.Clear();
                AddToCollection(table);
            }
            
        }
        #endregion
    }
}
