namespace Macaron {
    partial class SignupForm {
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
            this.label_Register = new System.Windows.Forms.Label();
            this.label_User = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.textBox_User = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_Close = new System.Windows.Forms.PictureBox();
            this.label_Minimize = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Close)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Register
            // 
            this.label_Register.BackColor = System.Drawing.Color.Transparent;
            this.label_Register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_Register.Font = new System.Drawing.Font("SeoulHangang B", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_Register.Location = new System.Drawing.Point(0, 294);
            this.label_Register.Name = "label_Register";
            this.label_Register.Size = new System.Drawing.Size(411, 93);
            this.label_Register.TabIndex = 10;
            this.label_Register.Text = "등록 완료";
            this.label_Register.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Register.Click += new System.EventHandler(this.label_Register_Click);
            // 
            // label_User
            // 
            this.label_User.AutoSize = true;
            this.label_User.BackColor = System.Drawing.Color.Transparent;
            this.label_User.Font = new System.Drawing.Font("NanumGothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_User.Location = new System.Drawing.Point(23, 212);
            this.label_User.Name = "label_User";
            this.label_User.Size = new System.Drawing.Size(158, 34);
            this.label_User.TabIndex = 11;
            this.label_User.Text = "사업체 이름";
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.BackColor = System.Drawing.Color.Transparent;
            this.label_Password.Font = new System.Drawing.Font("NanumGothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_Password.Location = new System.Drawing.Point(23, 254);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(144, 34);
            this.label_Password.TabIndex = 12;
            this.label_Password.Text = "Password";
            // 
            // textBox_User
            // 
            this.textBox_User.Font = new System.Drawing.Font("NanumGothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_User.Location = new System.Drawing.Point(190, 211);
            this.textBox_User.Name = "textBox_User";
            this.textBox_User.Size = new System.Drawing.Size(188, 39);
            this.textBox_User.TabIndex = 13;
            this.textBox_User.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_User_KeyDown);
            // 
            // textBox_Password
            // 
            this.textBox_Password.Font = new System.Drawing.Font("NanumGothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_Password.Location = new System.Drawing.Point(190, 252);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(188, 39);
            this.textBox_Password.TabIndex = 14;
            this.textBox_Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_Password_KeyDown);
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
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // pictureBox_Close
            // 
            this.pictureBox_Close.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Close.Image = global::Macaron.Properties.Resources.delete_cross;
            this.pictureBox_Close.Location = new System.Drawing.Point(381, 4);
            this.pictureBox_Close.Name = "pictureBox_Close";
            this.pictureBox_Close.Size = new System.Drawing.Size(25, 25);
            this.pictureBox_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Close.TabIndex = 15;
            this.pictureBox_Close.TabStop = false;
            this.pictureBox_Close.Click += new System.EventHandler(this.pictureBox_Close_Click);
            // 
            // label_Minimize
            // 
            this.label_Minimize.AutoSize = true;
            this.label_Minimize.BackColor = System.Drawing.Color.Transparent;
            this.label_Minimize.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Minimize.Location = new System.Drawing.Point(354, 3);
            this.label_Minimize.Name = "label_Minimize";
            this.label_Minimize.Size = new System.Drawing.Size(27, 25);
            this.label_Minimize.TabIndex = 16;
            this.label_Minimize.Text = "_";
            this.label_Minimize.Click += new System.EventHandler(this.label_Minimize_Click);
            // 
            // SignupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(411, 493);
            this.Controls.Add(this.label_Minimize);
            this.Controls.Add(this.pictureBox_Close);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_User);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.label_User);
            this.Controls.Add(this.label_Register);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignupForm";
            this.Text = "sign_up";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label_Register;
        private System.Windows.Forms.Label label_User;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.TextBox textBox_User;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.PictureBox pictureBox_Close;
        private System.Windows.Forms.Label label_Minimize;
    }
}