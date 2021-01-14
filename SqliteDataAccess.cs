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
        // ***************** Read *****************

        /* Gets a Guardian by a distinct pin number. Distinctness enforced elsewhere.
         * INPUT: integer pin#
         * OUTPUT: Guardian object
         */
        internal Guardian GetGuardianByPin(int guardian_pin_in)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string strQuery = "SELECT * FROM Guardians WHERE PinNumber = @pin_in";
                Guardian guardian = cnn.Query<Guardian>(strQuery, new { pin_in = guardian_pin_in }).SingleOrDefault();
                return guardian;
            }
        }
        #endregion

        #region authorized_guardians
        // ***************** Read *****************

        /* Gets a list of all children per a specific guardian.
         * INPUT: Guardian
         * OUTPUT: List of Child object.
         */
        internal List<Child> GetChildrenByGuardian(Guardian guardian_in)
        {
            //TODO: Remove once valid login check is implemented.
            if (guardian_in == null)
                return null;

            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string strQuery = @"
SELECT
Children.id,
Children.FirstName,
Children.LastName,
DOB,
address,
race,
gender,
photo
FROM Children
INNER JOIN Authorized_Guardians on Children.ID = Authorized_Guardians.child_id
INNER JOIN Guardians on Authorized_Guardians.guardian_id = Guardians.id
WHERE Guardians.id = @id
";
                var output = cnn.Query<Child>(strQuery,guardian_in);
                return output.ToList();
            }
        }

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

        #region reports
        #endregion

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
