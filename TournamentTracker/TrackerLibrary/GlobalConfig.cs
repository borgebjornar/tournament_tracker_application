﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();

        public static void InitalizeConnections(bool database, bool textFiles)
        {
            if (database)
            {
                // TODO: Set up the SQL Connector properly.
                SqlConnector sql = new SqlConnector();
                Connections.Add(sql);
            }
            
            if (textFiles)
            {
                // TODO: Set up the Text connections properly.
                TextConnection text = new TextConnection();
                Connections.Add(text);
            }
        }
    }
}