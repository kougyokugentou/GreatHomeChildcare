using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreatHomeChildcare.Models;

namespace GreatHomeChildcare
{
    class SqliteDataAccess
    {
        #region student
        #endregion

        #region guardian
        #endregion

        #region attendance
        #endregion

        #region misc
        #endregion

        /* Checks to see if this is the first time the application has run.
         * by counting the number of guardians in the guardian table.
         */
        internal bool isFirstTimeRun()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string strQuery = "SELECT COUNT(*) FROM Guardians";
                int num_guardians = cnn.Query<int>(strQuery).SingleOrDefault();

                if (num_guardians > 0)
                    return false;
                else
                    return true;
            }
        }

        //TODO: implement
        internal List<Child> GetChildrenByGuardianID(int guardian_id_in)
        {
            return null;
        }

        #region reports
        #endregion

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
