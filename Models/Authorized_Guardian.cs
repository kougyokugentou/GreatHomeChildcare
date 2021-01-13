using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatHomeChildcare.Models
{
    /* The authorized_guardian class and table acts
     * as a bridge table in the database to provide
     * a many-to-many mapping of children to guardians.
     * Therefore, one child can have many guardians;
     * and a single guardian can have many children.
     * eg:
     * id   child_id    guardian_id
     * 1    1           1
     * 2    1           2
     * 3    1           3
     * 4    2           1
     */
    class Authorized_Guardian
    {
        public int id { get; set; }
        public int child_id { get; set; }
        public int guardian_id { get; set; }
    }
}
