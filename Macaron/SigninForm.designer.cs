namespace Macaron {
    partial class SigninForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label_SigninBtn = new System.Windows.Forms.Label();
            this.label_User = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.current_user = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_SigninBtn
            // 
            this.label_SigninBtn.BackColor = System.Drawing.Color.Transparent;
            this.label_SigninBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_SigninBtn.Font = new System.Drawing.Font("SeoulHangang B", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_SigninBtn.Location = new System.Drawing.Point(0, 292);
            this.label_SigninBtn.Name = "label_SigninBtn";
            this.label_SigninBtn.Size = new System.Drawing.Size(411, 95);
            this.label_SigninBtn.TabIndex = 11;
            this.label_SigninBtn.Text = "로그인";
            this.label_SigninBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_SigninBtn.Click += new System.EventHandler(this.label_SigninBtn_Click);
            // 
            // label_User
            // 
            this.label_User.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_User.BackColor = System.Drawing.Color.Transparent;
            this.label_User.Font = new System.Drawing.Font("NanumGothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_User.Location = new System.Drawing.Point(41, 209);
            this.label_User.Name = "label_User";
            this.label_User.Size = new System.Drawing.Size(347, 34);
            this.label_User.TabIndex = 12;
            this.label_User.Text = "[현재 사용자]";
            this.label_User.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.BackColor = System.Drawing.Color.Transparent;
            this.label_Password.Font = new System.Drawing.Font("NanumGothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_Password.Location = new System.Drawing.Point(35, 255);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(144, 34);
            this.label_Password.TabIndex = 13;
            this.label_Password.Text = "Password";
            // 
            // textBox_Password
            // 
            this.textBox_Password.Font = new System.Drawing.Font("NanumGothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_Password.Location = new System.Drawing.Point(200, 250);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(188, 39);
            this.textBox_Password.TabIndex = 15;
            this.textBox_Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_Password_KeyDown);
            // 
            // current_user
            // 
            this.current_user.AutoSize = true;
            this.current_user.BackColor = System.Drawing.Color.Transparent;
            this.current_user.Font = new System.Drawing.Font("NanumGothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.current_user.Location = new System.Drawing.Point(266, 213);
            this.current_user.Name = "current_user";
            this.current_user.Size = new System.Drawing.Size(0, 34);
            this.current_user.TabIndex = 16;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Macaron.Properties.Resources.delete_cross;
            this.pictureBox3.Location = new System.Drawing.Point(386, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.label_Close_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox2.Image = global::Macaron.Properties.Resources.background_down;
            this.pictureBox2.Location = new System.Drawing.Point(0, 292);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(411, 201);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::Macaron.Properties.Resources.background_up;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(411, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown_1);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove_1);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(361, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "_";
            this.label3.Click += new System.EventHandler(this.label_Minimize_Click);
            // 
            // SigninForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(411, 493);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.current_user);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.label_User);
            this.Controls.Add(this.label_SigninBtn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SigninForm";
            this.Text = "signin";
            this.Load += new System.EventHandler(this.SigninForm_Load);
            this.Shown += new System.EventHandler(this.SigninForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label_SigninBtn;
        private System.Windows.Forms.Label label_User;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Label current_user;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
    }
}