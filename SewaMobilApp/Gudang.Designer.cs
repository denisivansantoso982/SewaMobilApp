namespace SewaMobilApp
{
    partial class Gudang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridGudang = new System.Windows.Forms.DataGridView();
            this.textBoxCari = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.labelHarga = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGudang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridGudang
            // 
            this.dataGridGudang.AllowUserToAddRows = false;
            this.dataGridGudang.AllowUserToDeleteRows = false;
            this.dataGridGudang.AllowUserToResizeColumns = false;
            this.dataGridGudang.AllowUserToResizeRows = false;
            this.dataGridGudang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridGudang.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(69)))), ((int)(((byte)(90)))));
            this.dataGridGudang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridGudang.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridGudang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridGudang.ColumnHeadersHeight = 30;
            this.dataGridGudang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(69)))), ((int)(((byte)(90)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridGudang.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridGudang.GridColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridGudang.Location = new System.Drawing.Point(37, 119);
            this.dataGridGudang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridGudang.MultiSelect = false;
            this.dataGridGudang.Name = "dataGridGudang";
            this.dataGridGudang.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Nirmala UI", 11F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridGudang.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridGudang.RowHeadersWidth = 51;
            this.dataGridGudang.RowTemplate.DividerHeight = 1;
            this.dataGridGudang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridGudang.Size = new System.Drawing.Size(1176, 462);
            this.dataGridGudang.TabIndex = 0;
            this.dataGridGudang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridGudang_CellClick);
            // 
            // textBoxCari
            // 
            this.textBoxCari.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCari.Font = new System.Drawing.Font("Nirmala UI", 11F);
            this.textBoxCari.ForeColor = System.Drawing.Color.Black;
            this.textBoxCari.Location = new System.Drawing.Point(153, 36);
            this.textBoxCari.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCari.Name = "textBoxCari";
            this.textBoxCari.Size = new System.Drawing.Size(914, 32);
            this.textBoxCari.TabIndex = 2;
            this.textBoxCari.TextChanged += new System.EventHandler(this.textBoxCari_TextChanged);
            // 
            // label
            // 
            this.label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(1287, 517);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(204, 28);
            this.label.TabIndex = 9;
            this.label.Text = "Harga (per Hari) :   Rp.";
            // 
            // labelHarga
            // 
            this.labelHarga.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHarga.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHarga.Location = new System.Drawing.Point(1512, 517);
            this.labelHarga.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHarga.Name = "labelHarga";
            this.labelHarga.Size = new System.Drawing.Size(147, 26);
            this.labelHarga.TabIndex = 10;
            this.labelHarga.Text = "harga";
            this.labelHarga.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.ImageLocation = "";
            this.pictureBox.Location = new System.Drawing.Point(1292, 119);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox.MaximumSize = new System.Drawing.Size(399, 369);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(366, 338);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 11;
            this.pictureBox.TabStop = false;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(69)))), ((int)(((byte)(90)))));
            this.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnAdd.FlatAppearance.BorderSize = 0;
            this.BtnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(69)))), ((int)(((byte)(90)))));
            this.BtnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(54)))), ((int)(((byte)(66)))));
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.ForeColor = System.Drawing.Color.Snow;
            this.BtnAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnAdd.Location = new System.Drawing.Point(1292, 36);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(115, 33);
            this.BtnAdd.TabIndex = 12;
            this.BtnAdd.Text = "Tambah";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(69)))), ((int)(((byte)(90)))));
            this.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnDelete.FlatAppearance.BorderSize = 0;
            this.BtnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(69)))), ((int)(((byte)(90)))));
            this.BtnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(54)))), ((int)(((byte)(66)))));
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Font = new System.Drawing.Font("Nirmala UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.ForeColor = System.Drawing.Color.Snow;
            this.BtnDelete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnDelete.Location = new System.Drawing.Point(1543, 34);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(115, 33);
            this.BtnDelete.TabIndex = 13;
            this.BtnDelete.Text = "Hapus";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
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
            this.btnUbah.Location = new System.Drawing.Point(1417, 36);
            this.btnUbah.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(115, 33);
            this.btnUbah.TabIndex = 14;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseVisualStyleBackColor = false;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Filter Data :";
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
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(115, 33);
            this.btnRefresh.TabIndex = 16;
            this.btnRefresh.Text = "Segarkan";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Gudang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.labelHarga);
            this.Controls.Add(this.label);
            this.Controls.Add(this.textBoxCari);
            this.Controls.Add(this.dataGridGudang);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Gudang";
            this.Size = new System.Drawing.Size(1687, 615);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridGudang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridGudang;
        private System.Windows.Forms.TextBox textBoxCari;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label labelHarga;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRefresh;
    }
}
