namespace Bai09
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnl_ThongTinSV = new Panel();
            btn_Erase = new Button();
            btn_Save = new Button();
            btn_Huy = new Button();
            list_MonDaChon = new ListBox();
            btn_Chon = new Button();
            list_MonHoc = new ListBox();
            lbl_Mon = new Label();
            lbl_Sexual = new Label();
            radMale = new RadioButton();
            radFemale = new RadioButton();
            lbl_Major = new Label();
            lbl_Name = new Label();
            lbl_MSSV = new Label();
            combo_Major = new ComboBox();
            txt_Name = new TextBox();
            txt_MSSV = new TextBox();
            dgvSinhVien = new DataGridView();
            colMSSV = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colMajor = new DataGridViewTextBoxColumn();
            colSexual = new DataGridViewTextBoxColumn();
            colSoMon = new DataGridViewTextBoxColumn();
            pnl_ThongTinSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).BeginInit();
            SuspendLayout();
            // 
            // pnl_ThongTinSV
            // 
            pnl_ThongTinSV.Anchor = AnchorStyles.Top;
            pnl_ThongTinSV.Controls.Add(btn_Erase);
            pnl_ThongTinSV.Controls.Add(btn_Save);
            pnl_ThongTinSV.Controls.Add(btn_Huy);
            pnl_ThongTinSV.Controls.Add(list_MonDaChon);
            pnl_ThongTinSV.Controls.Add(btn_Chon);
            pnl_ThongTinSV.Controls.Add(list_MonHoc);
            pnl_ThongTinSV.Controls.Add(lbl_Mon);
            pnl_ThongTinSV.Controls.Add(lbl_Sexual);
            pnl_ThongTinSV.Controls.Add(radMale);
            pnl_ThongTinSV.Controls.Add(radFemale);
            pnl_ThongTinSV.Controls.Add(lbl_Major);
            pnl_ThongTinSV.Controls.Add(lbl_Name);
            pnl_ThongTinSV.Controls.Add(lbl_MSSV);
            pnl_ThongTinSV.Controls.Add(combo_Major);
            pnl_ThongTinSV.Controls.Add(txt_Name);
            pnl_ThongTinSV.Controls.Add(txt_MSSV);
            pnl_ThongTinSV.Location = new Point(12, 12);
            pnl_ThongTinSV.Name = "pnl_ThongTinSV";
            pnl_ThongTinSV.Size = new Size(776, 256);
            pnl_ThongTinSV.TabIndex = 0;
            // 
            // btn_Erase
            // 
            btn_Erase.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn_Erase.AutoSize = true;
            btn_Erase.Font = new Font("Segoe UI", 7F);
            btn_Erase.Location = new Point(358, 223);
            btn_Erase.Name = "btn_Erase";
            btn_Erase.Size = new Size(95, 30);
            btn_Erase.TabIndex = 16;
            btn_Erase.Text = "Xóa Chọn";
            btn_Erase.UseVisualStyleBackColor = true;
            btn_Erase.Click += btn_XoaChon_Click;
            // 
            // btn_Save
            // 
            btn_Save.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn_Save.AutoSize = true;
            btn_Save.Font = new Font("Segoe UI", 7F);
            btn_Save.Location = new Point(257, 223);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(95, 30);
            btn_Save.TabIndex = 15;
            btn_Save.Text = "Lưu Thông Tin";
            btn_Save.UseVisualStyleBackColor = true;
            btn_Save.Click += btn_Save_Click;
            // 
            // btn_Huy
            // 
            btn_Huy.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn_Huy.Location = new Point(376, 179);
            btn_Huy.Name = "btn_Huy";
            btn_Huy.Size = new Size(34, 29);
            btn_Huy.TabIndex = 14;
            btn_Huy.Text = "<";
            btn_Huy.UseVisualStyleBackColor = true;
            btn_Huy.Click += btn_Huy_Click;
            // 
            // list_MonDaChon
            // 
            list_MonDaChon.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            list_MonDaChon.FormattingEnabled = true;
            list_MonDaChon.Location = new Point(416, 138);
            list_MonDaChon.Name = "list_MonDaChon";
            list_MonDaChon.ScrollAlwaysVisible = true;
            list_MonDaChon.SelectionMode = SelectionMode.MultiSimple;
            list_MonDaChon.Size = new Size(220, 84);
            list_MonDaChon.TabIndex = 13;
            // 
            // btn_Chon
            // 
            btn_Chon.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn_Chon.Location = new Point(376, 149);
            btn_Chon.Name = "btn_Chon";
            btn_Chon.Size = new Size(34, 29);
            btn_Chon.TabIndex = 12;
            btn_Chon.Text = ">";
            btn_Chon.UseVisualStyleBackColor = true;
            btn_Chon.Click += btn_Chon_Click;
            // 
            // list_MonHoc
            // 
            list_MonHoc.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            list_MonHoc.FormattingEnabled = true;
            list_MonHoc.Location = new Point(163, 138);
            list_MonHoc.Name = "list_MonHoc";
            list_MonHoc.ScrollAlwaysVisible = true;
            list_MonHoc.SelectionMode = SelectionMode.MultiSimple;
            list_MonHoc.Size = new Size(207, 84);
            list_MonHoc.TabIndex = 11;
            // 
            // lbl_Mon
            // 
            lbl_Mon.Anchor = AnchorStyles.Top;
            lbl_Mon.AutoSize = true;
            lbl_Mon.Font = new Font("Segoe UI", 7F);
            lbl_Mon.Location = new Point(163, 120);
            lbl_Mon.Name = "lbl_Mon";
            lbl_Mon.Size = new Size(126, 15);
            lbl_Mon.TabIndex = 10;
            lbl_Mon.Text = "Các Môn Đã Tham Gia";
            // 
            // lbl_Sexual
            // 
            lbl_Sexual.Anchor = AnchorStyles.Top;
            lbl_Sexual.AutoSize = true;
            lbl_Sexual.Font = new Font("Segoe UI", 7F);
            lbl_Sexual.Location = new Point(163, 94);
            lbl_Sexual.Name = "lbl_Sexual";
            lbl_Sexual.Size = new Size(55, 15);
            lbl_Sexual.TabIndex = 9;
            lbl_Sexual.Text = "Giới Tính";
            // 
            // radMale
            // 
            radMale.Anchor = AnchorStyles.Top;
            radMale.AutoSize = true;
            radMale.Font = new Font("Segoe UI", 7F);
            radMale.Location = new Point(266, 90);
            radMale.Name = "radMale";
            radMale.Size = new Size(54, 19);
            radMale.TabIndex = 8;
            radMale.TabStop = true;
            radMale.Text = "Nam";
            radMale.UseVisualStyleBackColor = true;
            // 
            // radFemale
            // 
            radFemale.Anchor = AnchorStyles.Top;
            radFemale.AutoSize = true;
            radFemale.Font = new Font("Segoe UI", 5F);
            radFemale.Location = new Point(362, 94);
            radFemale.Name = "radFemale";
            radFemale.Size = new Size(38, 16);
            radFemale.TabIndex = 7;
            radFemale.TabStop = true;
            radFemale.Text = "Nữ";
            radFemale.UseVisualStyleBackColor = true;
            // 
            // lbl_Major
            // 
            lbl_Major.Anchor = AnchorStyles.Top;
            lbl_Major.AutoSize = true;
            lbl_Major.Font = new Font("Segoe UI", 7F);
            lbl_Major.Location = new Point(163, 69);
            lbl_Major.Name = "lbl_Major";
            lbl_Major.Size = new Size(87, 15);
            lbl_Major.TabIndex = 6;
            lbl_Major.Text = "Chuyên Ngành";
            // 
            // lbl_Name
            // 
            lbl_Name.AutoSize = true;
            lbl_Name.Font = new Font("Segoe UI", 7F);
            lbl_Name.Location = new Point(163, 40);
            lbl_Name.Name = "lbl_Name";
            lbl_Name.Size = new Size(45, 15);
            lbl_Name.TabIndex = 5;
            lbl_Name.Text = "Họ Tên";
            // 
            // lbl_MSSV
            // 
            lbl_MSSV.Anchor = AnchorStyles.Top;
            lbl_MSSV.AutoSize = true;
            lbl_MSSV.Font = new Font("Segoe UI", 7F);
            lbl_MSSV.Location = new Point(163, 11);
            lbl_MSSV.Name = "lbl_MSSV";
            lbl_MSSV.Size = new Size(76, 15);
            lbl_MSSV.TabIndex = 4;
            lbl_MSSV.Text = "Mã Sinh Viên";
            // 
            // combo_Major
            // 
            combo_Major.Anchor = AnchorStyles.Top;
            combo_Major.Font = new Font("Segoe UI", 7F);
            combo_Major.FormattingEnabled = true;
            combo_Major.Items.AddRange(new object[] { "Hệ Thống Thông Tin", "Công Nghệ Phần Mềm", "Khoa học Máy tính", "Kỹ thuật Máy tính", "Mạng máy tính và Truyền thông", " Khoa học và Kỹ thuật Thông tin" });
            combo_Major.Location = new Point(266, 61);
            combo_Major.Name = "combo_Major";
            combo_Major.Size = new Size(370, 23);
            combo_Major.TabIndex = 3;
            combo_Major.SelectedIndexChanged += combo_Major_SelectedIndexChanged;
            // 
            // txt_Name
            // 
            txt_Name.Anchor = AnchorStyles.Top;
            txt_Name.BorderStyle = BorderStyle.FixedSingle;
            txt_Name.Font = new Font("Segoe UI", 7F);
            txt_Name.Location = new Point(266, 32);
            txt_Name.Name = "txt_Name";
            txt_Name.Size = new Size(370, 23);
            txt_Name.TabIndex = 1;
            // 
            // txt_MSSV
            // 
            txt_MSSV.Anchor = AnchorStyles.Top;
            txt_MSSV.BorderStyle = BorderStyle.FixedSingle;
            txt_MSSV.Font = new Font("Segoe UI", 7F);
            txt_MSSV.Location = new Point(266, 3);
            txt_MSSV.Name = "txt_MSSV";
            txt_MSSV.Size = new Size(370, 23);
            txt_MSSV.TabIndex = 0;
            // 
            // dgvSinhVien
            // 
            dgvSinhVien.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSinhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSinhVien.Columns.AddRange(new DataGridViewColumn[] { colMSSV, colName, colMajor, colSexual, colSoMon });
            dgvSinhVien.Location = new Point(12, 274);
            dgvSinhVien.Name = "dgvSinhVien";
            dgvSinhVien.ReadOnly = true;
            dgvSinhVien.RowHeadersWidth = 51;
            dgvSinhVien.Size = new Size(776, 164);
            dgvSinhVien.TabIndex = 1;
            // 
            // colMSSV
            // 
            colMSSV.HeaderText = "MSSV";
            colMSSV.MinimumWidth = 6;
            colMSSV.Name = "colMSSV";
            colMSSV.ReadOnly = true;
            // 
            // colName
            // 
            colName.HeaderText = "Họ Tên";
            colName.MinimumWidth = 6;
            colName.Name = "colName";
            colName.ReadOnly = true;
            // 
            // colMajor
            // 
            colMajor.HeaderText = "Chuyên Ngành";
            colMajor.MinimumWidth = 6;
            colMajor.Name = "colMajor";
            colMajor.ReadOnly = true;
            // 
            // colSexual
            // 
            colSexual.HeaderText = "Giới Tính";
            colSexual.MinimumWidth = 6;
            colSexual.Name = "colSexual";
            colSexual.ReadOnly = true;
            // 
            // colSoMon
            // 
            colSoMon.HeaderText = "Số Môn";
            colSoMon.MinimumWidth = 6;
            colSoMon.Name = "colSoMon";
            colSoMon.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvSinhVien);
            Controls.Add(pnl_ThongTinSV);
            Name = "Form1";
            Text = "Nhập Liệu Sinh Viên";
            pnl_ThongTinSV.ResumeLayout(false);
            pnl_ThongTinSV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_ThongTinSV;
        private Label lbl_Major;
        private Label lbl_Name;
        private Label lbl_MSSV;
        private ComboBox combo_Major;
        private TextBox txt_Name;
        private TextBox txt_MSSV;
        private Label lbl_Mon;
        private Label lbl_Sexual;
        private RadioButton radMale;
        private RadioButton radFemale;
        private Button btn_Save;
        private Button btn_Huy;
        private ListBox list_MonDaChon;
        private Button btn_Chon;
        private ListBox list_MonHoc;
        private Button btn_Erase;
        private DataGridView dgvSinhVien;
        private DataGridViewTextBoxColumn colMSSV;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colMajor;
        private DataGridViewTextBoxColumn colSexual;
        private DataGridViewTextBoxColumn colSoMon;
    }
}
