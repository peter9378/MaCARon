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
using System.Security.Cryptography;

namespace Macaron {
    public partial class SigninForm : Form {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        // MySQL Data
        private string query;
        private MySqlDataReader reader;
        private bool userExist;

        private bool CheckUser() {
            query = "SELECT * FROM User";
            MySqlCommand command = new MySqlCommand(query, DBManager.Instance.Connection);
            reader = command.ExecuteReader();

            return reader.Read();
        }

        // Constructor
        public SigninForm() {
            InitializeComponent();

            userExist = CheckUser();    // user existance check
            textBox_Password.PasswordChar = '*';    // password field

            var pos = this.PointToScreen(label_SigninBtn.Location);
            pos = pictureBox2.PointToClient(pos);
            label_SigninBtn.Parent = pictureBox2;
            label_SigninBtn.Location = pos;
            label_SigninBtn.BackColor = Color.Transparent;
            pos = this.PointToScreen(label3.Location);
            pos = pictureBox1.PointToClient(pos);
            label3.Parent = pictureBox1;
            label3.Location = pos;
            label3.BackColor = Color.Transparent;
            pos = this.PointToScreen(pictureBox3.Location);
            pos = pictureBox1.PointToClient(pos);
            pictureBox3.Parent = pictureBox1;
            pictureBox3.Location = pos;
            pictureBox3.BackColor = Color.Transparent;
        }
        private void label_SigninBtn_Click(object sender, EventArgs e) {
            reader.Close(); // 공용으로 쓰던 이력이 있다면 종료

            // textfield empty check
            if (!Convert.ToBoolean(textBox_Password.TextLength)) {
                MessageBox.Show("패스워드를 입력해주세요.", "MaCARon");
                return;
            }

            query = "SELECT Password FROM User WHERE CompanyName='" + label_User.Text + "'";
            MySqlCommand command = new MySqlCommand(query, DBManager.Instance.Connection);
            reader = command.ExecuteReader();
            reader.Read();
            

            if (PasswordHash.ValidatePassword(textBox_Password.Text, reader.GetString("Password"))) {
                MessageBox.Show(label_User.Text + " 사장님 반갑습니다!", "MaCARon", MessageBoxButtons.OK);
                reader.Close(); // no more use

                this.Visible = false;
                MainForm mForm = new MainForm();    // 로그인시에는 여기서 mainform이 생성
                foreach (var item in OwnedForms) {
                    item.Owner = mForm;
                }
                this.Owner = mForm;
                mForm.Show();
            }
            else {
                MessageBox.Show("패스워드가 일치하지 않습니다.", "MaCARon");
            }


        }


        private void pictureBox1_MouseUp_1(object sender, MouseEventArgs e) {
            dragging = false;
        }

        private void pictureBox1_MouseDown_1(object sender, MouseEventArgs e) {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void pictureBox1_MouseMove_1(object sender, MouseEventArgs e) {
            if (dragging) {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void label_Close_Click(object sender, EventArgs e) {
            Environment.Exit(0);
        }


        private void label_Minimize_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }

        private void SigninForm_Shown(object sender, EventArgs e) {
            // MySQL : User sign in
            if (!userExist) {
                this.Visible = false;
                MessageBox.Show("첫 사용을 환영합니다. 사용자 등록을 진행합니다.");
                SignupForm suForm = new SignupForm();
                this.Owner = suForm;
                suForm.Show();
            }
            reader.Close();
        }

        private void SigninForm_Load(object sender, EventArgs e) {
            if (userExist) {
                label_User.Text = reader.GetString("CompanyName");
            }
        }

        private void textBox_Password_KeyDown(object sender, KeyEventArgs e) {
            // Enter(return)key >> Sign in button
            if (e.KeyCode == Keys.Enter) {
                label_SigninBtn_Click(sender, e);
            }
        }
    }
}