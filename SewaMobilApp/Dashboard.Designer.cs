namespace SewaMobilApp
{
    partial class Dashboard
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
            if ( disposing && (components != null) )
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPesan = new System.Windows.Forms.Button();
            this.btnPengembalian = new System.Windows.Forms.Button();
            this.btnGudang = new System.Windows.Forms.Button();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.btnRiwayat = new System.Windows.Forms.Button();
            this.btnKaryawan = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.menuGudang = new SewaMobilApp.Gudang();
            this.menuUser = new SewaMobilApp.Menu();
            this.menuKaryawan = new SewaMobilApp.MenuKaryawan();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(69)))), ((int)(((byte)(90)))));
            this.panel1.Controls.Add(this.labelTime);
            this.panel1.Controls.Add(this.label1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // labelTime
            // 
            resources.ApplyResources(this.labelTime, "labelTime");
            this.labelTime.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelTime.Name = "labelTime";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Name = "label1";
            // 
            // btnPesan
            // 
            resources.ApplyResources(this.btnPesan, "btnPesan");
            this.btnPesan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(69)))), ((int)(((byte)(90)))));
            this.btnPesan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesan.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPesan.FlatAppearance.BorderSize = 0;
            this.btnPesan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(69)))), ((int)(((byte)(90)))));
            this.btnPesan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(54)))), ((int)(((byte)(66)))));
            this.btnPesan.ForeColor = System.Drawing.Color.Snow;
            this.btnPesan.Name = "btnPesan";
            this.btnPesan.UseVisualStyleBackColor = false;
            this.btnPesan.Click += new System.EventHandler(this.btnPesan_Click);
            // 
            // btnPengembalian
            // 
            resources.ApplyResources(this.btnPengembalian, "btnPengembalian");
            this.btnPengembalian.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(69)))), ((int)(((byte)(90)))));
            this.btnPengembalian.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPengembalian.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPengembalian.FlatAppearance.BorderSize = 0;
            this.btnPengembalian.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(69)))), ((int)(((byte)(90)))));
            this.btnPengembalian.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(54)))), ((int)(((byte)(66)))));
            this.btnPengembalian.ForeColor = System.Drawing.Color.Snow;
            this.btnPengembalian.Name = "btnPengembalian";
            this.btnPengembalian.UseVisualStyleBackColor = false;
            this.btnPengembalian.Click += new System.EventHandler(this.btnPengembalian_Click);
            // 
            // btnGudang
            // 
            resources.ApplyResources(this.btnGudang, "btnGudang");
            this.btnGudang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(69)))), ((int)(((byte)(90)))));
            this.btnGudang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGudang.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGudang.FlatAppearance.BorderSize = 0;
            this.btnGudang.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(69)))), ((int)(((byte)(90)))));
            this.btnGudang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(54)))), ((int)(((byte)(66)))));
            this.btnGudang.ForeColor = System.Drawing.Color.Snow;
            this.btnGudang.Name = "btnGudang";
            this.btnGudang.UseVisualStyleBackColor = false;
            this.btnGudang.Click += new System.EventHandler(this.btnGudang_Click);
            // 
            // btnKeluar
            // 
            resources.ApplyResources(this.btnKeluar, "btnKeluar");
            this.btnKeluar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnKeluar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKeluar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnKeluar.FlatAppearance.BorderSize = 0;
            this.btnKeluar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnKeluar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnKeluar.ForeColor = System.Drawing.Color.Snow;
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.UseVisualStyleBackColor = false;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // btnRiwayat
            // 
            resources.ApplyResources(this.btnRiwayat, "btnRiwayat");
            this.btnRiwayat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(69)))), ((int)(((byte)(90)))));
            this.btnRiwayat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRiwayat.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRiwayat.FlatAppearance.BorderSize = 0;
            this.btnRiwayat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(69)))), ((int)(((byte)(90)))));
            this.btnRiwayat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(54)))), ((int)(((byte)(66)))));
            this.btnRiwayat.ForeColor = System.Drawing.Color.Snow;
            this.btnRiwayat.Name = "btnRiwayat";
            this.btnRiwayat.UseVisualStyleBackColor = false;
            this.btnRiwayat.Click += new System.EventHandler(this.btnRiwayat_Click);
            // 
            // btnKaryawan
            // 
            resources.ApplyResources(this.btnKaryawan, "btnKaryawan");
            this.btnKaryawan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(69)))), ((int)(((byte)(90)))));
            this.btnKaryawan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKaryawan.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnKaryawan.FlatAppearance.BorderSize = 0;
            this.btnKaryawan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(69)))), ((int)(((byte)(90)))));
            this.btnKaryawan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(54)))), ((int)(((byte)(66)))));
            this.btnKaryawan.ForeColor = System.Drawing.Color.Snow;
            this.btnKaryawan.Name = "btnKaryawan";
            this.btnKaryawan.UseVisualStyleBackColor = false;
            this.btnKaryawan.Click += new System.EventHandler(this.btnKaryawan_Click);
            // 
            // btnMenu
            // 
            resources.ApplyResources(this.btnMenu, "btnMenu");
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(69)))), ((int)(((byte)(90)))));
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(69)))), ((int)(((byte)(90)))));
            this.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(54)))), ((int)(((byte)(66)))));
            this.btnMenu.ForeColor = System.Drawing.Color.Snow;
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // menuGudang
            // 
            resources.ApplyResources(this.menuGudang, "menuGudang");
            this.menuGudang.Name = "menuGudang";
            // 
            // menuUser
            // 
            resources.ApplyResources(this.menuUser, "menuUser");
            this.menuUser.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.menuUser.Name = "menuUser";
            // 
            // menuKaryawan
            // 
            resources.ApplyResources(this.menuKaryawan, "menuKaryawan");
            this.menuKaryawan.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.menuKaryawan.Name = "menuKaryawan";
            // 
            // Dashboard
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Controls.Add(this.menuKaryawan);
            this.Controls.Add(this.menuGudang);
            this.Controls.Add(this.menuUser);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnKaryawan);
            this.Controls.Add(this.btnRiwayat);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.btnGudang);
            this.Controls.Add(this.btnPengembalian);
            this.Controls.Add(this.btnPesan);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPesan;
        private System.Windows.Forms.Button btnPengembalian;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.Button btnRiwayat;
        private System.Windows.Forms.Button btnKaryawan;
        private System.Windows.Forms.Button btnMenu;
        private Menu menuUser;
        private Gudang menuGudang;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timer;
        public System.Windows.Forms.Button btnGudang;
        private MenuKaryawan menuKaryawan;
    }
}