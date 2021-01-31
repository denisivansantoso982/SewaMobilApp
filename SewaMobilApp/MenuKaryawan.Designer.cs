
namespace SewaMobilApp
{
    partial class MenuKaryawan
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCari = new System.Windows.Forms.TextBox();
            this.dataGridKaryawan = new System.Windows.Forms.DataGridView();
            this.btnTambahKaryawan = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKaryawan)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(69)))), ((int)(((byte)(90)))));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(69)))), ((int)(((byte)(90)))));
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(54)))), ((int)(((byte)(66)))));
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Snow;
            this.btnRefresh.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRefresh.Location = new System.Drawing.Point(1081, 36);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(9);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(115, 33);
            this.btnRefresh.TabIndex = 20;
            this.btnRefresh.Text = "Segarkan";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Filter Data :";
            // 
            // textBoxCari
            // 
            this.textBoxCari.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCari.Font = new System.Drawing.Font("Nirmala UI", 11F);
            this.textBoxCari.ForeColor = System.Drawing.Color.Black;
            this.textBoxCari.Location = new System.Drawing.Point(153, 36);
            this.textBoxCari.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCari.Name = "textBoxCari";
            this.textBoxCari.Size = new System.Drawing.Size(914, 32);
            this.textBoxCari.TabIndex = 18;
            this.textBoxCari.TextChanged += new System.EventHandler(this.textBoxCari_TextChanged);
            // 
            // dataGridKaryawan
            // 
            this.dataGridKaryawan.AllowUserToAddRows = false;
            this.dataGridKaryawan.AllowUserToDeleteRows = false;
            this.dataGridKaryawan.AllowUserToResizeColumns = false;
            this.dataGridKaryawan.AllowUserToResizeRows = false;
            this.dataGridKaryawan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridKaryawan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(69)))), ((int)(((byte)(90)))));
            this.dataGridKaryawan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridKaryawan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridKaryawan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridKaryawan.ColumnHeadersHeight = 30;
            this.dataGridKaryawan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(69)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridKaryawan.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridKaryawan.GridColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridKaryawan.Location = new System.Drawing.Point(37, 119);
            this.dataGridKaryawan.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridKaryawan.MultiSelect = false;
            this.dataGridKaryawan.Name = "dataGridKaryawan";
            this.dataGridKaryawan.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Nirmala UI", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridKaryawan.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridKaryawan.RowHeadersWidth = 51;
            this.dataGridKaryawan.RowTemplate.DividerHeight = 1;
            this.dataGridKaryawan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridKaryawan.Size = new System.Drawing.Size(1609, 462);
            this.dataGridKaryawan.TabIndex = 17;
            this.dataGridKaryawan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridKaryawan_CellClick);
            // 
            // btnTambahKaryawan
            // 
            this.btnTambahKaryawan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTambahKaryawan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(69)))), ((int)(((byte)(90)))));
            this.btnTambahKaryawan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTambahKaryawan.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTambahKaryawan.FlatAppearance.BorderSize = 0;
            this.btnTambahKaryawan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(69)))), ((int)(((byte)(90)))));
            this.btnTambahKaryawan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(54)))), ((int)(((byte)(66)))));
            this.btnTambahKaryawan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambahKaryawan.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambahKaryawan.ForeColor = System.Drawing.Color.Snow;
            this.btnTambahKaryawan.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnTambahKaryawan.Location = new System.Drawing.Point(1265, 36);
            this.btnTambahKaryawan.Margin = new System.Windows.Forms.Padding(9);
            this.btnTambahKaryawan.Name = "btnTambahKaryawan";
            this.btnTambahKaryawan.Size = new System.Drawing.Size(115, 33);
            this.btnTambahKaryawan.TabIndex = 21;
            this.btnTambahKaryawan.Text = "Tambah";
            this.btnTambahKaryawan.UseVisualStyleBackColor = false;
            this.btnTambahKaryawan.Click += new System.EventHandler(this.btnTambahKaryawan_Click);
            // 
            // btnUbah
            // 
            this.btnUbah.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUbah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(69)))), ((int)(((byte)(90)))));
            this.btnUbah.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUbah.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUbah.FlatAppearance.BorderSize = 0;
            this.btnUbah.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(69)))), ((int)(((byte)(90)))));
            this.btnUbah.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(54)))), ((int)(((byte)(66)))));
            this.btnUbah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUbah.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUbah.ForeColor = System.Drawing.Color.Snow;
            this.btnUbah.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnUbah.Location = new System.Drawing.Point(1398, 36);
            this.btnUbah.Margin = new System.Windows.Forms.Padding(9);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(115, 33);
            this.btnUbah.TabIndex = 22;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseVisualStyleBackColor = false;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHapus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(69)))), ((int)(((byte)(90)))));
            this.btnHapus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHapus.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHapus.FlatAppearance.BorderSize = 0;
            this.btnHapus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(69)))), ((int)(((byte)(90)))));
            this.btnHapus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(54)))), ((int)(((byte)(66)))));
            this.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHapus.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapus.ForeColor = System.Drawing.Color.Snow;
            this.btnHapus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnHapus.Location = new System.Drawing.Point(1531, 36);
            this.btnHapus.Margin = new System.Windows.Forms.Padding(9);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(115, 33);
            this.btnHapus.TabIndex = 23;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // MenuKaryawan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.btnTambahKaryawan);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCari);
            this.Controls.Add(this.dataGridKaryawan);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MenuKaryawan";
            this.Size = new System.Drawing.Size(1687, 615);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKaryawan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCari;
        private System.Windows.Forms.DataGridView dataGridKaryawan;
        private System.Windows.Forms.Button btnTambahKaryawan;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnHapus;
    }
}
