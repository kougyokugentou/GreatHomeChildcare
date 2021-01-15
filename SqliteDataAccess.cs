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

/* REFERENCES:
https://stackoverflow.com/questions/16436485/sqlite-selecting-the-maximum-corresponding-value
*/

namespace GreatHomeChildcare
{
    class SqliteDataAccess
    {
        #region student
        // ***************** Create *****************
        // ***************** Read *******************
        // ***************** Update *****************
        // ***************** Delete *****************
        #endregion

        #region guardian
        // ***************** Create *****************

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
        // ***************** Update *****************
        // ***************** Delete *****************
        #endregion

        #region authorized_guardians
        // ***************** Create *****************

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
        // ***************** Update *****************
        // ***************** Delete *****************
        #endregion

        #region attendance
        // ***************** Create *****************

        /* Creates a new entry in the attendence table each time
         * a child is signed in our out of the system.
         * Does --NOT-- need an Update function as the system
         * is designed to keep track of --all-- times a child
         * is signed in or out, and by which guardian.
         * INPUTS: child, guardian
         * OUTPUT: none to program, new row to sql db.
         */
        internal void SignChildInOut(Child child_in, Guardian guardian_in)
        {
            string strStudentStatus = GetChildSignInOut(child_in);

            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string strInOut = (strStudentStatus == "in" ? "out" : "in");
                string strQuery = "INSERT INTO Attendence(child_id, guardian_id,in_out) VALUES(@child_id, @guardian_id, @in_out)";
                cnn.Execute(strQuery, new
                {
                    child_id = child_in.id,
                    guardian_id = guardian_in.id,
                    in_out = strInOut
                });
            }
        }

        // ***************** Read *****************

        /* gets a single child in/out status.
         * INPUT Child
         * OUTPUT string "in" or "out".
         */
        internal string GetChildSignInOut(Child child_in)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                //Select only the latest attendence data for this student.
                string strQuery = "SELECT in_out FROM Attendence WHERE child_id=@id AND id = (SELECT MAX(id) FROM Attendence WHERE child_id = @id)";

                string output = cnn.Query<string>(strQuery, child_in).SingleOrDefault();
                return output;
            }
        }
        // ***************** Update *****************

        // ***************** Delete *****************
        #endregion

        #region misc
        // ***************** Create *****************
        // ***************** Read *******************

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
        // ***************** Update *****************
        // ***************** Delete *****************
        #endregion

        #region reports
        // ***************** Create *****************
        // ***************** Read *******************
        // ***************** Update *****************
        // ***************** Delete *****************
        #endregion

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
