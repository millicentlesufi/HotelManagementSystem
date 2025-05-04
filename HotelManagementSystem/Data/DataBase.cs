using HotelManagementSystem.Properties;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;


namespace HotelManagementSystem.Data
{
    internal class DataBase
    {
        #region Data Members
        
        private string strConn = Settings.Default.Hotel_DatabaseConnectionString;
        
        protected SqlConnection cnMain;
        protected DataSet dsMain;
        protected SqlDataAdapter daMain;
        protected SqlCommandBuilder bMain;
        #endregion

        #region Mutators

        #endregion

        #region Constructors
        public DataBase()
        {
            try
            {
                //Open a connection & create a new dataset object
                cnMain = new SqlConnection(strConn);
                dsMain = new DataSet();
                daMain = new SqlDataAdapter();
            }
            catch (SystemException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message, "Error");
                return;
            }
        }
        #endregion

        #region Data set methods
        public void FillDataSet(string aSQLstring, string aTable)
        {
            //fills dataset fresh from the db for a specific table and with a specific Query
            try
            {
                daMain = new SqlDataAdapter(aSQLstring, cnMain);
                dsMain.Clear();
                cnMain.Open();
                
                daMain.Fill(dsMain, aTable);
                cnMain.Close();
            }
            catch (Exception errObj)
            {
                MessageBox.Show(errObj.Message + "  " + errObj.StackTrace);
            }
        }
        public int UpdateDataSource(string sqlQuery, string table)
        {
            bMain = new SqlCommandBuilder();
            bMain.DataAdapter = daMain;
            SqlCommand sqlCommand = new SqlCommand(sqlQuery, cnMain);
            daMain.SelectCommand = sqlCommand;
            int changes = daMain.Update(dsMain, table);
            return changes;
        }
        #endregion
    }
}
