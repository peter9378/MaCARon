namespace Macaron {
    partial class MainForm {
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
            this.menu_control = new System.Windows.Forms.Panel();
            this.resv_management_button = new System.Windows.Forms.Button();
            this.member_management_button = new System.Windows.Forms.Button();
            this.car_management_button = new System.Windows.Forms.Button();
            this.logo_control = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.area_control = new System.Windows.Forms.Panel();
            this.top_control = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label_Username = new System.Windows.Forms.Label();
            this.menu_control.SuspendLayout();
            this.logo_control.SuspendLayout();
            this.top_control.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menu_control
            // 
            this.menu_control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(209)))), ((int)(((byte)(234)))));
            this.menu_control.Controls.Add(this.resv_management_button);
            this.menu_control.Controls.Add(this.member_management_button);
            this.menu_control.Controls.Add(this.car_management_button);
            this.menu_control.Controls.Add(this.logo_control);
            this.menu_control.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu_control.Location = new System.Drawing.Point(0, 0);
            this.menu_control.Name = "menu_control";
            this.menu_control.Size = new System.Drawing.Size(152, 537);
            this.menu_control.TabIndex = 2;
            this.menu_control.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // resv_management_button
            // 
            this.resv_management_button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resv_management_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resv_management_button.Font = new System.Drawing.Font("NanumGothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.resv_management_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(71)))), ((int)(((byte)(82)))));
            this.resv_management_button.Location = new System.Drawing.Point(0, 169);
            this.resv_management_button.Name = "resv_management_button";
            this.resv_management_button.Size = new System.Drawing.Size(152, 49);
            this.resv_management_button.TabIndex = 1;
            this.resv_management_button.Text = "예약 관리";
            this.resv_management_button.UseVisualStyleBackColor = true;
            // 
            // member_management_button
            // 
            this.member_management_button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.member_management_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.member_management_button.Font = new System.Drawing.Font("NanumGothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.member_management_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(71)))), ((int)(((byte)(82)))));
            this.member_management_button.Location = new System.Drawing.Point(0, 123);
            this.member_management_button.Name = "member_management_button";
            this.member_management_button.Size = new System.Drawing.Size(152, 49);
            this.member_management_button.TabIndex = 1;
            this.member_management_button.Text = "고객 관리";
            this.member_management_button.UseVisualStyleBackColor = true;
            // 
            // car_management_button
            // 
            this.car_management_button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.car_management_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.car_management_button.Font = new System.Drawing.Font("NanumGothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.car_management_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(71)))), ((int)(((byte)(82)))));
            this.car_management_button.Location = new System.Drawing.Point(0, 75);
            this.car_management_button.Name = "car_management_button";
            this.car_management_button.Size = new System.Drawing.Size(152, 49);
            this.car_management_button.TabIndex = 0;
            this.car_management_button.Text = "차량 관리";
            this.car_management_button.UseVisualStyleBackColor = true;
            this.car_management_button.Click += new System.EventHandler(this.car_management_button_Click);
            // 
            // logo_control
            // 
            this.logo_control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(186)))), ((int)(((byte)(197)))));
            this.logo_control.Controls.Add(this.label2);
            this.logo_control.Location = new System.Drawing.Point(0, 0);
            this.logo_control.Name = "logo_control";
            this.logo_control.Size = new System.Drawing.Size(152, 75);
            this.logo_control.TabIndex = 0;
            this.logo_control.MouseDown += new System.Windows.Forms.MouseEventHandler(this.logo_control_MouseDown);
            this.logo_control.MouseMove += new System.Windows.Forms.MouseEventHandler(this.logo_control_MouseMove);
            this.logo_control.MouseUp += new System.Windows.Forms.MouseEventHandler(this.logo_control_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("NanumGothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "Macaron";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // area_control
            // 
            this.area_control.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.area_control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(255)))), ((int)(((byte)(234)))));
            this.area_control.Location = new System.Drawing.Point(152, 75);
            this.area_control.Name = "area_control";
            this.area_control.Size = new System.Drawing.Size(723, 462);
            this.area_control.TabIndex = 4;
            // 
            // top_control
            // 
            this.top_control.Controls.Add(this.label_Username);
            this.top_control.Controls.Add(this.pictureBox2);
            this.top_control.Controls.Add(this.label1);
            this.top_control.Controls.Add(this.pictureBox1);
            this.top_control.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_control.Location = new System.Drawing.Point(152, 0);
            this.top_control.Name = "top_control";
            this.top_control.Size = new System.Drawing.Size(723, 75);
            this.top_control.TabIndex = 3;
            this.top_control.Paint += new System.Windows.Forms.PaintEventHandler(this.top_control_Paint_1);
            this.top_control.MouseDown += new System.Windows.Forms.MouseEventHandler(this.top_control_MouseDown);
            this.top_control.MouseMove += new System.Windows.Forms.MouseEventHandler(this.top_control_MouseMove);
            this.top_control.MouseUp += new System.Windows.Forms.MouseEventHandler(this.top_control_MouseUp);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Macaron.Properties.Resources.web_page_home;
            this.pictureBox2.Location = new System.Drawing.Point(32, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(653, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "_";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Macaron.Properties.Resources.delete_cross;
            this.pictureBox1.Location = new System.Drawing.Point(686, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label_Username
            // 
            this.label_Username.Font = new System.Drawing.Font("NanumGothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_Username.Location = new System.Drawing.Point(68, 22);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(288, 36);
            this.label_Username.TabIndex = 8;
            this.label_Username.Text = "[Username]";
            this.label_Username.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(875, 537);
            this.Controls.Add(this.area_control);
            this.Controls.Add(this.top_control);
            this.Controls.Add(this.menu_control);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.menu_control.ResumeLayout(false);
            this.logo_control.ResumeLayout(false);
            this.logo_control.PerformLayout();
            this.top_control.ResumeLayout(false);
            this.top_control.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menu_control;
        private System.Windows.Forms.Panel area_control;
        private System.Windows.Forms.Panel top_control;
        private System.Windows.Forms.Panel logo_control;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button car_management_button;
        private System.Windows.Forms.Button resv_management_button;
        private System.Windows.Forms.Button member_management_button;
        private System.Windows.Forms.Label label_Username;
    }
}

