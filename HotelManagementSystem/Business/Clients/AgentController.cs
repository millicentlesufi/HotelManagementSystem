using HotelManagementSystem.Business.Accounts;
using HotelManagementSystem.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.Business
{
    internal class AgentController
    {
        #region Data Members
        private AgentDB _agentDB;
        private Collection<Agent> _agents;

        #endregion

        #region Mutators
        public Collection<Agent> agents { get => _agents; set => _agents = value; }

        #endregion

        #region Contructor
        public AgentController() 
        {
            _agentDB = new AgentDB();
            GetAgents();
        }

        #endregion

        #region Utility

        public Agent Find(string id)
        {
            //Agent agent = null;
            int index = 0;
            int count = _agents.Count;
            bool found = (_agents[index].agentID == id);
            while (!found && index < count-1)
            {
                index++;
                found = (_agents[index].agentID == id);
                
                
            }
            if (found)
            {
                return _agents[index];
            }
            else
            {
                return null;
            }
        }
        public void GetAgents()
        {
            string query = "SELECT * FROM Agents";
            string table = "Agents";
            _agentDB.RunQuery(query, table);
            _agents = _agentDB.getAgents;
        }

        
        #endregion
    }
}
