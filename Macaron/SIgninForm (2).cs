using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace Macaron {
    public partial class LoginForm : Form {
        public LoginForm() {
            InitializeComponent();

            // register
            if (!CheckUser()) {
                //Application.Run(new RegisterForm());
                this.Close();
            }
            

        }

        Label label_id;
        MySqlDataReader reader;

        private void LoginForm_Load(object sender, EventArgs e) {
            label_id.Text = reader.GetString("CompanyName");

        }

        private string query=  "SELECT * FROM User";
        private bool CheckUser() {
            MySqlCommand command = new MySqlCommand(query, DBManager.Instance.Connection);
            reader = command.ExecuteReader();

            return reader.Read();
        }

        private int Register() {
            return 0;
        }
    }
}
