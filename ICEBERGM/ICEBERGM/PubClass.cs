using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ICEBERGM
{
    public class PubClass
    {
        public static SqlConnection con = new SqlConnection("Data Source=G1000\\SQLEXPRESS; initial catalog= ICEBERGM; integrated security = true");
        public static string strSessionName;
        public static string strRole;
        public static string strUsername;
        public static string strLocation;
        
       
    }
}
