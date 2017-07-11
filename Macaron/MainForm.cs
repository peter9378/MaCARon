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
    public partial class MainForm : Form {

        string m_userName;

        // MySQL
        string query;
        MySqlDataReader reader;

        public MainForm() {
            InitializeComponent();

            query = "SELECT * FROM User";
            MySqlCommand command = new MySqlCommand(query, DBManager.Instance.Connection);
            reader = command.ExecuteReader();
            reader.Read();
            m_userName = reader.GetString("CompanyName");
            // 사용자 정보가 존재하는 것이 전제
            label_Username.Text = m_userName;   //current_username

            //button edge 삭제
            delete_button_edge(car_management_button);
            delete_button_edge(member_management_button);
            delete_button_edge(resv_management_button);
        }

        private void delete_button_edge(Button target)  //button edge 안보이게 관리
        {
            target.TabStop = false;
            target.FlatStyle = FlatStyle.Flat;
            target.FlatAppearance.BorderSize = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void top_control_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void top_control_Paint_1(object sender, PaintEventArgs e)
        {

        }
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;


        private void top_control_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;

        }

        private void top_control_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }

        }

        private void top_control_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void logo_control_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void logo_control_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void logo_control_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

      
        private void car_management_button_Click(object sender, EventArgs e)
        {
        }


        protected override bool ShowFocusCues   //button edge 안보이게 할 때 에러 방지
        {
            get
            {
                //return base.ShowFocusCues;
                return false;
            }
        }

        private void MainForm_Shown(object sender, EventArgs e) {

            
        }
    }
}
