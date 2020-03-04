using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace SHIELDAgents
{
    public static class AgentList
    {
        public static ObservableCollection<Agent> Agents { set; get; }

        public static void PopulateData()
        {
            Agents = new ObservableCollection<Agent>
            {
                new Agent() { FullName = "Brian Trager", Gender = "Male", Height = "6'0", HairColor = "Brown", Level = 10, AIN = "TRA001", DateOfOrigin = "07/01/2003" }

            };
        }

        /// <summary>
        /// Add an agent to the list
        /// </summary>
        /// <param name="a">Agent object</param>
        public static void AddAgent(Agent a)
        {
            Agents.Add(a);
        }
        
        //Add a method here to edit agent information
    }
}
