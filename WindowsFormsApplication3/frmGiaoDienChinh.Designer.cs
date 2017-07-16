namespace WindowsFormsApplication3
{
    partial class frmGiaoDienChinh
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.NhanVientoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SanPhamtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NhaCungCaptoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ThoattoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.HoaDontoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DoanhThutoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.TimNhanVientoolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.IntoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(617, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItem1
            // 
            this.ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NhanVientoolStripMenuItem,
            this.SanPhamtoolStripMenuItem,
            this.NhaCungCaptoolStripMenuItem,
            this.toolStripSeparator1,
            this.ThoattoolStripMenuItem});
            this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
            this.ToolStripMenuItem1.Size = new System.Drawing.Size(106, 20);
            this.ToolStripMenuItem1.Text = "Cập nhật dữ liệu";
            this.ToolStripMenuItem1.Click += new System.EventHandler(this.cậpNhậtDữLiệuToolStripMenuItem_Click);
            // 
            // NhanVientoolStripMenuItem
            // 
            this.NhanVientoolStripMenuItem.Name = "NhanVientoolStripMenuItem";
            this.NhanVientoolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.NhanVientoolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.NhanVientoolStripMenuItem.Text = "Nhân viên";
            this.NhanVientoolStripMenuItem.Click += new System.EventHandler(this.NhanVientoolStripMenuItem_Click);
            // 
            // SanPhamtoolStripMenuItem
            // 
            this.SanPhamtoolStripMenuItem.Name = "SanPhamtoolStripMenuItem";
            this.SanPhamtoolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.SanPhamtoolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.SanPhamtoolStripMenuItem.Text = "Sản phẩm";
            this.SanPhamtoolStripMenuItem.Click += new System.EventHandler(this.SanPhamtoolStripMenuItem_Click);
            // 
            // NhaCungCaptoolStripMenuItem
            // 
            this.NhaCungCaptoolStripMenuItem.Name = "NhaCungCaptoolStripMenuItem";
            this.NhaCungCaptoolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.NhaCungCaptoolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.NhaCungCaptoolStripMenuItem.Text = "Nhà cung cấp";
            this.NhaCungCaptoolStripMenuItem.Click += new System.EventHandler(this.NhaCungCaptoolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(185, 6);
            // 
            // ThoattoolStripMenuItem
            // 
            this.ThoattoolStripMenuItem.Name = "ThoattoolStripMenuItem";
            this.ThoattoolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.ThoattoolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.ThoattoolStripMenuItem.Text = "Thoát";
            this.ThoattoolStripMenuItem.Click += new System.EventHandler(this.ThoattoolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HoaDontoolStripMenuItem,
            this.DoanhThutoolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(45, 20);
            this.toolStripMenuItem2.Text = "Xử lý";
            // 
            // HoaDontoolStripMenuItem
            // 
            this.HoaDontoolStripMenuItem.Name = "HoaDontoolStripMenuItem";
            this.HoaDontoolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D4)));
            this.HoaDontoolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.HoaDontoolStripMenuItem.Text = "Hóa đơn";
            this.HoaDontoolStripMenuItem.Click += new System.EventHandler(this.HoaDontoolStripMenuItem_Click);
            // 
            // DoanhThutoolStripMenuItem
            // 
            this.DoanhThutoolStripMenuItem.Name = "DoanhThutoolStripMenuItem";
            this.DoanhThutoolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D7)));
            this.DoanhThutoolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.DoanhThutoolStripMenuItem.Text = "Doanh Thu";
            this.DoanhThutoolStripMenuItem.Click += new System.EventHandler(this.DoanhThutoolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TimNhanVientoolStripMenuItem4,
            this.IntoolStripMenuItem});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(127, 20);
            this.toolStripMenuItem3.Text = "Tìm kiếm- Thống kê";
            // 
            // TimNhanVientoolStripMenuItem4
            // 
            this.TimNhanVientoolStripMenuItem4.Name = "TimNhanVientoolStripMenuItem4";
            this.TimNhanVientoolStripMenuItem4.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D5)));
            this.TimNhanVientoolStripMenuItem4.Size = new System.Drawing.Size(219, 22);
            this.TimNhanVientoolStripMenuItem4.Text = "Tìm kiếm nhân viên";
            this.TimNhanVientoolStripMenuItem4.Click += new System.EventHandler(this.TimNhanVientoolStripMenuItem4_Click);
            // 
            // IntoolStripMenuItem
            // 
            this.IntoolStripMenuItem.Name = "IntoolStripMenuItem";
            this.IntoolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D6)));
            this.IntoolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.IntoolStripMenuItem.Text = "In hóa đơn";
            this.IntoolStripMenuItem.Click += new System.EventHandler(this.IntoolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(0, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(617, 362);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::WindowsFormsApplication3.Properties.Resources.cafe_1;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(6, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(599, 356);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmGiaoDienChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(617, 401);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmGiaoDienChinh";
            this.Text = "frmGiaoDienChinh";
            this.Load += new System.EventHandler(this.frmGiaoDienChinh_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem NhanVientoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SanPhamtoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NhaCungCaptoolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ThoattoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem HoaDontoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem TimNhanVientoolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem IntoolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem DoanhThutoolStripMenuItem;
    }
}