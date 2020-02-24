using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseContext
{
    public class Connection
    {
        private const string Conn = "data source=WINTENDO\\SQLEXPRESS;Database=CallInfo;Trusted_Connection=True;MultipleActiveResultSets=true;App=EntityFramework";

        public static string GetConnection()
        {
            return Conn;
        }

        public bool IsTest()
        {
            if (GetConnection() == "data source=WINTENDO\\SQLEXPRESS;Database=CallInfo;Trusted_Connection=True;MultipleActiveResultSets=true;App=EntityFramework")
            {

                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
