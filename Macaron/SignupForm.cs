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

namespace Macaron
{
    public partial class SignupForm : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        // MySQL Data
        string query;
        


        public SignupForm()
        {
            InitializeComponent();
            textBox_Password.PasswordChar = '*';

            var pos = this.PointToScreen(label_Register.Location);
            pos = pictureBox2.PointToClient(pos);
            label_Register.Parent = pictureBox2;
            label_Register.Location = pos;
            label_Register.BackColor = Color.Transparent;
            pos = this.PointToScreen(label_Minimize.Location);
            pos = pictureBox1.PointToClient(pos);
            label_Minimize.Parent = pictureBox1;
            label_Minimize.Location = pos;
            label_Minimize.BackColor = Color.Transparent;
            pos = this.PointToScreen(pictureBox_Close.Location);
            pos = pictureBox1.PointToClient(pos);
            pictureBox_Close.Parent = pictureBox1;
            pictureBox_Close.Location = pos;
            pictureBox_Close.BackColor = Color.Transparent;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        // Register
        private void label_Register_Click(object sender, EventArgs e)
        {
            // textfield empty check
            if (!Convert.ToBoolean(textBox_User.TextLength)) {
                MessageBox.Show("사용자명(상호명)을 입력해주세요!", "MaCARon");
                return;
            }
            else if (!Convert.ToBoolean(textBox_Password.TextLength)) {
                MessageBox.Show("패스워드를 입력해주세요!", "MaCARon");
                return;
            }


            string pw = PasswordHash.HashPassword(textBox_Password.Text);
            query = "INSERT INTO User (CompanyName, Password) VALUES ('" + textBox_User.Text + "', '" + pw + "');";
            MySqlCommand command = new MySqlCommand(query, DBManager.Instance.Connection);
            // ExecuteNonQuery return value: changed rows count
            if (Convert.ToBoolean(command.ExecuteNonQuery())) {
                MessageBox.Show(textBox_User.Text + " 사장님 반갑습니다!", "MaCARon", MessageBoxButtons.OK);
            }

            

            this.Visible = false;
            MainForm mForm = new MainForm();   // 사용자 등록시에는 여기서 폼이 생성
            foreach (var item in OwnedForms) {
                item.Owner = mForm;
            }
            this.Owner = mForm;
            mForm.Show();
        }

        private void pictureBox_Close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void label_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void textBox_User_KeyDown(object sender, KeyEventArgs e) {
            // Enter(return)key >> Sign in button
            if (e.KeyCode == Keys.Enter) {
                label_Register_Click(sender, e);
            }
        }

        private void textBox_Password_KeyDown(object sender, KeyEventArgs e) {
            // Enter(return)key >> Sign in button
            if (e.KeyCode == Keys.Enter) {
                label_Register_Click(sender, e);
            }
        }
    }
}
