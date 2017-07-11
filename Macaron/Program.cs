using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using System.Data;

using MySql.Data.MySqlClient;

namespace Macaron {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            try {
                DBManager.Instance.Init();
            }
            catch (MySqlException e) {
                string msg = "문제가 계속 발생하면 프로그램 담당자에게 문의하세요.";
                switch (e.Number) {
                    case 0: // cannot connect
                        MessageBox.Show("데이터베이스에 연결할 수 없습니다.\n" + msg, "Connection Error", MessageBoxButtons.RetryCancel);
                        break;
                    case 1: // invalid account
                        MessageBox.Show("데이터베이스에 연결할 수 없습니다.\n" + msg, "DB Access Error", MessageBoxButtons.RetryCancel);
                        break;
                    default:
                        break;
                }
            }


            Application.Run(new SigninForm());
        }

    }
}
