using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        #region reports
        #endregion

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
