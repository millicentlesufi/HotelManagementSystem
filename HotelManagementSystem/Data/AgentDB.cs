using HotelManagementSystem.Business;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.Data
{
    internal class AgentDB:DataBase
    {
        #region Data Members
        //private string sqlLocal = "SELECT * FROM Agents";
       // private string table = "Agents";
        private Collection<Agent> agents;
        #endregion

        #region Mutators
        public Collection<Agent> getAgents { get => agents; }
        #endregion

        #region Constructor
        public AgentDB() : base()
        {
            agents = new Collection<Agent>();
        }
        #endregion

        #region Utility
        public void AddToCollection(string table)
        {
            //DataRow row = null;
            Agent agent;

            foreach (DataRow r in dsMain.Tables[table].Rows)
            {
                if (!(r.RowState == DataRowState.Deleted))
                {
                    agent = new Agent();
                    agent.agentID = Convert.ToString(r["Agent_ID"]);
                    agent.company = Convert.ToString(r["Company"]);
                    agent.phone = Convert.ToString(r["Phone"]);
                    agent.email = Convert.ToString(r["Email"]);
                    agent.address = Convert.ToString(r["Address"]);
                    agents.Add(agent);
                }

            }
        }


        public void RunQuery(string sql, string table)
        {
            FillDataSet(sql, table);
            AddToCollection(table);
        }
        #endregion
    }
}
