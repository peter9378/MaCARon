using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;   // MySQL use.

namespace Macaron {
    /// <summary>
    /// Singleton DB Controller
    /// </summary>
    /// 
   
    
    class DBManager {
        private static DBManager instance;
        private static MySqlConnection con;

        public void Init() {  /* pass */  }

        private DBManager() {
            string cs = @"server=edu.khuhacker.com;userid=macaron;password=A+Please;database=macaron;charset=utf8";
            
            try {
                con = new MySqlConnection(cs);
                con.Open();
            }
            catch (MySqlException e) {
                // exception
                // 0: cannot connect
                // 1: invalid account
                throw e;
            }
        }
        public static DBManager Instance {
            get {
                instance = instance ?? new DBManager();
                return instance;
            }
        }

        public MySqlConnection Connection { get { return con; } }
    }
}
