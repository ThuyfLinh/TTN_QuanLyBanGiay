namespace TTN.GUI
{
    partial class fCTHoaDonBan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel5 = new MetroFramework.Controls.MetroPanel();
            this.txtMaGiay = new System.Windows.Forms.TextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.dgvCTHD = new MetroFramework.Controls.MetroGrid();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.btnThemCTKM = new MetroFramework.Controls.MetroButton();
            this.btnXoaCT = new MetroFramework.Controls.MetroButton();
            this.btnTimKiem = new MetroFramework.Controls.MetroButton();
            this.lblMaKM = new MetroFramework.Controls.MetroLabel();
            this.radNu = new MetroFramework.Controls.MetroRadioButton();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel2.SuspendLayout();
            this.metroPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).BeginInit();
            this.metroPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel2
            // 
            this.metroPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(106)))));
            this.metroPanel2.Controls.Add(this.metroPanel5);
            this.metroPanel2.Controls.Add(this.metroPanel3);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel2.ForeColor = System.Drawing.Color.White;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(20, 95);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(1064, 622);
            this.metroPanel2.TabIndex = 11;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroPanel5
            // 
            this.metroPanel5.Controls.Add(this.txtMaGiay);
            this.metroPanel5.Controls.Add(this.metroLabel2);
            this.metroPanel5.Controls.Add(this.dgvCTHD);
            this.metroPanel5.Controls.Add(this.metroLabel14);
            this.metroPanel5.Controls.Add(this.txtSoLuong);
            this.metroPanel5.Controls.Add(this.metroLabel7);
            this.metroPanel5.Controls.Add(this.txtMaHD);
            this.metroPanel5.Controls.Add(this.metroLabel11);
            this.metroPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel5.HorizontalScrollbarBarColor = true;
            this.metroPanel5.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel5.HorizontalScrollbarSize = 10;
            this.metroPanel5.Location = new System.Drawing.Point(0, 121);
            this.metroPanel5.Name = "metroPanel5";
            this.metroPanel5.Size = new System.Drawing.Size(1064, 501);
            this.metroPanel5.TabIndex = 5;
            this.metroPanel5.UseCustomBackColor = true;
            this.metroPanel5.UseCustomForeColor = true;
            this.metroPanel5.VerticalScrollbarBarColor = true;
            this.metroPanel5.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel5.VerticalScrollbarSize = 10;
            // 
            // txtMaGiay
            // 
            this.txtMaGiay.Location = new System.Drawing.Point(200, 74);
            this.txtMaGiay.Multiline = true;
            this.txtMaGiay.Name = "txtMaGiay";
            this.txtMaGiay.Size = new System.Drawing.Size(256, 40);
            this.txtMaGiay.TabIndex = 48;
            this.txtMaGiay.Tag = "";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(127, 85);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(61, 19);
            this.metroLabel2.TabIndex = 47;
            this.metroLabel2.Text = "Mã giày:";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // dgvCTHD
            // 
            this.dgvCTHD.AllowUserToAddRows = false;
            this.dgvCTHD.AllowUserToDeleteRows = false;
            this.dgvCTHD.AllowUserToResizeRows = false;
            this.dgvCTHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCTHD.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvCTHD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCTHD.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvCTHD.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCTHD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvCTHD.ColumnHeadersHeight = 30;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCTHD.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvCTHD.EnableHeadersVisualStyles = false;
            this.dgvCTHD.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvCTHD.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvCTHD.Location = new System.Drawing.Point(36, 149);
            this.dgvCTHD.MultiSelect = false;
            this.dgvCTHD.Name = "dgvCTHD";
            this.dgvCTHD.ReadOnly = true;
            this.dgvCTHD.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCTHD.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvCTHD.RowHeadersVisible = false;
            this.dgvCTHD.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCTHD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCTHD.Size = new System.Drawing.Size(994, 320);
            this.dgvCTHD.TabIndex = 46;
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel14.Location = new System.Drawing.Point(575, 41);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(0, 0);
            this.metroLabel14.TabIndex = 44;
            this.metroLabel14.UseCustomBackColor = true;
            this.metroLabel14.UseCustomForeColor = true;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(647, 74);
            this.txtSoLuong.Multiline = true;
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(260, 40);
            this.txtSoLuong.TabIndex = 41;
            this.txtSoLuong.Tag = "";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(567, 88);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(66, 19);
            this.metroLabel7.TabIndex = 40;
            this.metroLabel7.Text = "Số lượng:";
            this.metroLabel7.UseCustomBackColor = true;
            this.metroLabel7.UseCustomForeColor = true;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(200, 20);
            this.txtMaHD.Multiline = true;
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(256, 40);
            this.txtMaHD.TabIndex = 33;
            this.txtMaHD.Tag = "";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel11.Location = new System.Drawing.Point(103, 30);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(87, 19);
            this.metroLabel11.TabIndex = 32;
            this.metroLabel11.Text = "Mã hóa đơn:";
            this.metroLabel11.UseCustomBackColor = true;
            this.metroLabel11.UseCustomForeColor = true;
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.btnThemCTKM);
            this.metroPanel3.Controls.Add(this.btnXoaCT);
            this.metroPanel3.Controls.Add(this.btnTimKiem);
            this.metroPanel3.Controls.Add(this.lblMaKM);
            this.metroPanel3.Controls.Add(this.radNu);
            this.metroPanel3.Controls.Add(this.txtTimKiem);
            this.metroPanel3.Controls.Add(this.metroLabel4);
            this.metroPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(0, 0);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(1064, 121);
            this.metroPanel3.TabIndex = 2;
            this.metroPanel3.UseCustomBackColor = true;
            this.metroPanel3.UseCustomForeColor = true;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // btnThemCTKM
            // 
            this.btnThemCTKM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(106)))));
            this.btnThemCTKM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemCTKM.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnThemCTKM.Location = new System.Drawing.Point(853, 45);
            this.btnThemCTKM.Name = "btnThemCTKM";
            this.btnThemCTKM.Size = new System.Drawing.Size(106, 40);
            this.btnThemCTKM.TabIndex = 18;
            this.btnThemCTKM.Text = "Thêm CTHD";
            this.btnThemCTKM.UseCustomBackColor = true;
            this.btnThemCTKM.UseCustomForeColor = true;
            this.btnThemCTKM.UseSelectable = true;
            this.btnThemCTKM.Click += new System.EventHandler(this.btnThemCTKM_Click);
            // 
            // btnXoaCT
            // 
            this.btnXoaCT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(106)))));
            this.btnXoaCT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaCT.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnXoaCT.Location = new System.Drawing.Point(681, 45);
            this.btnXoaCT.Name = "btnXoaCT";
            this.btnXoaCT.Size = new System.Drawing.Size(106, 40);
            this.btnXoaCT.TabIndex = 17;
            this.btnXoaCT.Text = "Xóa CTHD";
            this.btnXoaCT.UseCustomBackColor = true;
            this.btnXoaCT.UseCustomForeColor = true;
            this.btnXoaCT.UseSelectable = true;
            this.btnXoaCT.Click += new System.EventHandler(this.btnXoaCT_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(106)))));
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnTimKiem.Location = new System.Drawing.Point(381, 45);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(106, 40);
            this.btnTimKiem.TabIndex = 13;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseCustomBackColor = true;
            this.btnTimKiem.UseCustomForeColor = true;
            this.btnTimKiem.UseSelectable = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // lblMaKM
            // 
            this.lblMaKM.AutoSize = true;
            this.lblMaKM.Location = new System.Drawing.Point(268, -9);
            this.lblMaKM.Name = "lblMaKM";
            this.lblMaKM.Size = new System.Drawing.Size(0, 0);
            this.lblMaKM.TabIndex = 12;
            this.lblMaKM.UseCustomBackColor = true;
            this.lblMaKM.UseCustomForeColor = true;
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Location = new System.Drawing.Point(882, -9);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(16, 0);
            this.radNu.TabIndex = 3;
            this.radNu.Tag = "Nữ";
            this.radNu.UseCustomBackColor = true;
            this.radNu.UseCustomForeColor = true;
            this.radNu.UseSelectable = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(81, 45);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(264, 30);
            this.txtTimKiem.TabIndex = 1;
            this.txtTimKiem.Tag = "TenCT";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(67, 121);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(0, 0);
            this.metroLabel4.TabIndex = 2;
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(349, 4);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(262, 25);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "CHI TIẾT HÓA ĐƠN BÁN HÀNG";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(106)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.metroPanel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1064, 35);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(106)))));
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.ForeColor = System.Drawing.Color.White;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(3, 3);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1058, 29);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.UseCustomForeColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // fCTHoaDonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 737);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "fCTHoaDonBan";
            this.Text = "fCTHoaDonBan";
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel5.ResumeLayout(false);
            this.metroPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).EndInit();
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroPanel metroPanel5;
        private System.Windows.Forms.TextBox txtMaGiay;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroGrid dgvCTHD;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private System.Windows.Forms.TextBox txtSoLuong;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.TextBox txtMaHD;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroButton btnThemCTKM;
        private MetroFramework.Controls.MetroButton btnXoaCT;
        private MetroFramework.Controls.MetroButton btnTimKiem;
        private MetroFramework.Controls.MetroLabel lblMaKM;
        private MetroFramework.Controls.MetroRadioButton radNu;
        private System.Windows.Forms.TextBox txtTimKiem;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
    }
}