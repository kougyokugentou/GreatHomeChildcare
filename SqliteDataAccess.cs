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
        #region child
        // ***************** Create *****************

        /* Inserts a new child to the database.
         * INPUT child
         * OUTPUT new row to SQL database, void to program.
         */
        internal void InsertNewChild(Child child)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string strQuery = "INSERT INTO STUDENTS (FirstName, LastName, DOB, address, race, gender, photo)" +
                    "VALUES (@FirstName, @LastName, @DOB, @address, @race, @gender, @photo);";
                cnn.Execute(strQuery, child);
            }
        }

        // ***************** Read *******************

        /* Gets a single child from the sqlite database
         * provided an id number.
         * INPUT: integer id
         * OUTPUT: Child object
         */
        internal Child GetChildByID(int id_in)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string strQuery = "SELECT * FROM Children WHERE id=@id";
                Child output = cnn.Query<Child>(strQuery, new { id = id_in }).SingleOrDefault();
                return output;
            }
        }

        /* Gets all children from the sqlite database.
         * INPUT: void
         * OUTPUT: list of Child objects
         */
        internal List<Child> GetAllChildren()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string strQuery = "SELECT * FROM Children ORDER BY LastName ASC";
                var output = cnn.Query<Child>(strQuery);
                return output.ToList();
            }
        }
        // ***************** Update *****************

        /* Updates an individual child in the DB.
         * Needs to do field mapping in the Execute call because
         * the photo field can be null or not null, and 
         * the conditional operator can be used to change the query on the fly.
         * 
         * INPUT: Child
         * OUTPUT: Data to SQL Database, void to program
         */
        internal void UpdateChild(Child child)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string strQuery = "UPDATE Children SET FirstName = @First_Name, LastName = @Last_Name, " +
                "DOB = @_dob, address = @_address, race = @_race, gender = @_gender, photo = @_photo" +
                "WHERE id = @_id;";

                cnn.Execute(strQuery, new
                {
                    _id = child.id,
                    First_Name = child.FirstName,
                    Last_Name = child.LastName,
                    _dob = child.DOB,
                    _address = child.address,
                    _race = child.race,
                    _gender = child.gender,
                    _photo = child.photo ?? null
                });
            }
        }

        // ***************** Delete *****************
        #endregion

        #region guardian
        // ***************** Create *****************

        // ***************** Read *****************

        /* Gets all guardians from the DB.
         * INPUT: void
         * OUTPUT: list of guardian objects.
         */
        internal List<Guardian> GetAllGuardians()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string strQuery = "SELECT * FROM Guardians ORDER BY LastName ASC;";
                var output = cnn.Query<Guardian>(strQuery);
                return output.ToList();
            }
        }

        /* Gets all guardians for a single child.
         * INPUT: Child
         * OUTPUT: List of guardian object.
         */
        internal List<Guardian> GetGuardiansByChild(Child child_in)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string strQuery = "SELECT * FROM Guardians WHERE id IN (SELECT guardian_id FROM Authorized_Guardians WHERE child_id = @id)";
                var output = cnn.Query<Guardian>(strQuery, child_in);
                return output.ToList();
            }
        }

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

        /* Add a guardian as an authorized_guardian of a specific child.
         * INPUT: child, guardian
         * OUTPUT: void to program, new row in authorized_guardian table of sql db.
         */
        internal void AddNewGuardianToChild(Child child_in, Guardian guardian_in)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string strQuery = "INSERT INTO Authorized_Guardians (child_id, guardian_id) VALUES (@_child_id, @_guardian_id);";
                cnn.Execute(strQuery, new
                {
                    _child_id = child_in.id,
                    _guardian_id = guardian_in.id
                });
            }
        }

        // ***************** Read *****************

        /* Check for octomom.
         * INPUT: Guardian
         * OUTPUT: integer Count of children per guardian.
         */
        internal int CheckForOctomom(Guardian guardian_in)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string strQuery = "SELECT COUNT(child_id) from Authorized_Guardians WHERE guardian_id = @id;";
                int output = cnn.Query<int>(strQuery, guardian_in).SingleOrDefault();
                return output;
            }
        }

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

        //TODO: Not sure if I need this.
        internal void RemoveGuardianFromChild(Child child_in, Guardian guardian_in)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string strQuery = "DELETE FROM Authorized_Guardians WHERE child_id = @_child_id AND guardian_id = @_guardian_id;";
                cnn.Execute(strQuery, new { 
                    _child_id = child_in.id,
                    _guardian_id = guardian_in.id
                });
            }
        }

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
            Attendance strStudentStatus = GetChildSignInOut(child_in);

            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string strInOut = (strStudentStatus.in_out == "in" ? "out" : "in");
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
         * OUTPUT string "in" or "out", plus the timestamp.
         */
        internal Attendance GetChildSignInOut(Child child_in)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                //Select only the latest attendence data for this student.
                string strQuery = "SELECT in_out,timestamp FROM Attendence WHERE child_id=@id AND id = (SELECT MAX(id) FROM Attendence WHERE child_id = @id)";

                Attendance output = cnn.Query<Attendance>(strQuery, child_in).SingleOrDefault();
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
         * INPUT: void from program, count of guardians from db.
         * OUTPUT: boolean true/false.
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

        // Gets the connection string to the db and returns it to the program.
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
