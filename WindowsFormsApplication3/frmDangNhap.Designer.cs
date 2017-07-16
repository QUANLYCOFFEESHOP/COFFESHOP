namespace WindowsFormsApplication3
{
    partial class frmDangNhap
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txbTK1 = new System.Windows.Forms.TextBox();
            this.txbMK1 = new System.Windows.Forms.TextBox();
            this.btnDN = new System.Windows.Forms.Button();
            this.btnTh = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txbTK1
            // 
            this.txbTK1.Location = new System.Drawing.Point(149, 65);
            this.txbTK1.Name = "txbTK1";
            this.txbTK1.Size = new System.Drawing.Size(284, 26);
            this.txbTK1.TabIndex = 0;
            this.txbTK1.TextChanged += new System.EventHandler(this.txbTK1_TextChanged);
            // 
            // txbMK1
            // 
            this.txbMK1.Location = new System.Drawing.Point(149, 111);
            this.txbMK1.Name = "txbMK1";
            this.txbMK1.PasswordChar = '*';
            this.txbMK1.Size = new System.Drawing.Size(284, 26);
            this.txbMK1.TabIndex = 1;
            // 
            // btnDN
            // 
            this.btnDN.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDN.Location = new System.Drawing.Point(149, 167);
            this.btnDN.Name = "btnDN";
            this.btnDN.Size = new System.Drawing.Size(146, 41);
            this.btnDN.TabIndex = 2;
            this.btnDN.Text = "đăng nhập";
            this.btnDN.UseVisualStyleBackColor = true;
            this.btnDN.Click += new System.EventHandler(this.btnDN_Click);
            // 
            // btnTh
            // 
            this.btnTh.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnTh.Location = new System.Drawing.Point(315, 167);
            this.btnTh.Name = "btnTh";
            this.btnTh.Size = new System.Drawing.Size(118, 41);
            this.btnTh.TabIndex = 3;
            this.btnTh.Text = "thoát";
            this.btnTh.UseVisualStyleBackColor = true;
            this.btnTh.Click += new System.EventHandler(this.btnTh_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "tài khoản";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "mật khẩu";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication3.Properties.Resources.chia_khoa;
            this.pictureBox1.Location = new System.Drawing.Point(43, 140);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // frmDangNhap
            // 
            this.AcceptButton = this.btnDN;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CancelButton = this.btnTh;
            this.ClientSize = new System.Drawing.Size(476, 260);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnTh);
            this.Controls.Add(this.btnDN);
            this.Controls.Add(this.txbMK1);
            this.Controls.Add(this.txbTK1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmDangNhap";
            this.Text = "a";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDangNhap_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load_2);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbTK;
        private System.Windows.Forms.TextBox txbMK;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txbTK1;
        private System.Windows.Forms.TextBox txbMK1;
        private System.Windows.Forms.Button btnDN;
        private System.Windows.Forms.Button btnTh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}