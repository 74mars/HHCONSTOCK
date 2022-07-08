using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace Conndb
{
    public class dbConnInfo
    {
        public static string ServerIP { get; set; } = "192.168.250.203";
        public static string Division { get; set; } = "10";

        public static string DataBaseName
        {
            get
            {
                string databaseName = "";

                switch (Division) // ServerIP
                {
                    //case "192.168.250.203":
                    //    databaseName = "HANHO_YC";
                    //    break;
                    case "10":
                        databaseName = "HANHO_YC";
                        break;
                    case "20":
                        databaseName = "HANHO_ET";
                        break;
                }
                return databaseName;
            }
        }

        /// <summary>
        /// DataBaseID
        ///</summary>
        public static string DataBaseID
        {
            get
            {
                string databaseID = "";

                switch (ServerIP) // ServerIP
                {
                    case "192.168.250.203":
                        databaseID = "werp";
                        break;

                }

                return databaseID;
            }

        }
        /// <summary>
        /// DatabasePassword
        /// </summary>
        public static string DataBasePwd
        {
            get
            {
                string databasePwd = "";

                switch (ServerIP)
                {
                    case "192.168.250.203":
                        databasePwd = "werp";
                        break;

                }

                return databasePwd;
            }
        }
        /// <summary>
        /// DatabasePort
        /// </summary>
        public static string DataBasePort
        {
            get
            {
                string databasePort = "";

                switch (ServerIP)
                {
                    case "192.168.250.203":
                        databasePort = "1521";
                        break;
                }

                return databasePort;

            }
        }
        /// <summary>
        ///  DatabaseSID
        /// </summary>
        public static string DatabaseSID
        {
            get
            {
                string databaseSid = "";
                switch (Division) // ServerIP
                {
                    //case "192.168.250.203":
                    //    databaseSid = "ORCL";
                    //    break;
                    case "10":
                        databaseSid = "ORCL";
                        break;
                    case "20":
                        databaseSid = "HANHOET";
                        break;
                }
                return databaseSid;
            }
        }
    }
}
