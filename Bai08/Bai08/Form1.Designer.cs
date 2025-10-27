namespace Bai08
{
    partial class Form
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
            components = new System.ComponentModel.Container();
            lbl_QLTK = new Label();
            lbl_SoTK = new Label();
            txt_SoTK = new TextBox();
            txt_Ten = new TextBox();
            lbl_Ten = new Label();
            lbl_DiaChi = new Label();
            txt_DiaChi = new TextBox();
            txt_Tien = new TextBox();
            lbl_Tien = new Label();
            btn_Exit = new Button();
            btn_Del = new Button();
            btn_Add = new Button();
            lbl_TotalCost = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            txt_TotalCost = new TextBox();
            lvTaiKhoan = new ListView();
            colSTT = new ColumnHeader();
            colSoTK = new ColumnHeader();
            colTen = new ColumnHeader();
            colDiaChi = new ColumnHeader();
            colSoTien = new ColumnHeader();
            SuspendLayout();
            // 
            // lbl_QLTK
            // 
            lbl_QLTK.Anchor = AnchorStyles.Top;
            lbl_QLTK.Font = new Font("Segoe UI", 20.2F, FontStyle.Bold);
            lbl_QLTK.ForeColor = SystemColors.MenuHighlight;
            lbl_QLTK.Location = new Point(0, 0);
            lbl_QLTK.Name = "lbl_QLTK";
            lbl_QLTK.Size = new Size(800, 38);
            lbl_QLTK.TabIndex = 0;
            lbl_QLTK.Text = "QUẢN LÍ THÔNG TIN TÀI KHOẢN";
            lbl_QLTK.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_SoTK
            // 
            lbl_SoTK.AutoSize = true;
            lbl_SoTK.Font = new Font("Segoe UI", 10F);
            lbl_SoTK.Location = new Point(144, 51);
            lbl_SoTK.Name = "lbl_SoTK";
            lbl_SoTK.Size = new Size(105, 23);
            lbl_SoTK.TabIndex = 1;
            lbl_SoTK.Text = "Số tài khoản";
            // 
            // txt_SoTK
            // 
            txt_SoTK.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_SoTK.BorderStyle = BorderStyle.FixedSingle;
            txt_SoTK.Location = new Point(254, 49);
            txt_SoTK.Name = "txt_SoTK";
            txt_SoTK.Size = new Size(380, 27);
            txt_SoTK.TabIndex = 2;
            // 
            // txt_Ten
            // 
            txt_Ten.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_Ten.BorderStyle = BorderStyle.FixedSingle;
            txt_Ten.Location = new Point(255, 82);
            txt_Ten.Name = "txt_Ten";
            txt_Ten.Size = new Size(380, 27);
            txt_Ten.TabIndex = 3;
            // 
            // lbl_Ten
            // 
            lbl_Ten.AutoSize = true;
            lbl_Ten.Font = new Font("Segoe UI", 10F);
            lbl_Ten.Location = new Point(119, 84);
            lbl_Ten.Name = "lbl_Ten";
            lbl_Ten.Size = new Size(130, 23);
            lbl_Ten.TabIndex = 4;
            lbl_Ten.Text = "Tên khách hàng";
            // 
            // lbl_DiaChi
            // 
            lbl_DiaChi.AutoSize = true;
            lbl_DiaChi.Font = new Font("Segoe UI", 10F);
            lbl_DiaChi.Location = new Point(92, 118);
            lbl_DiaChi.Name = "lbl_DiaChi";
            lbl_DiaChi.Size = new Size(156, 23);
            lbl_DiaChi.TabIndex = 5;
            lbl_DiaChi.Text = "Địa chỉ khách hàng";
            // 
            // txt_DiaChi
            // 
            txt_DiaChi.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_DiaChi.BorderStyle = BorderStyle.FixedSingle;
            txt_DiaChi.Location = new Point(254, 115);
            txt_DiaChi.Name = "txt_DiaChi";
            txt_DiaChi.Size = new Size(380, 27);
            txt_DiaChi.TabIndex = 6;
            // 
            // txt_Tien
            // 
            txt_Tien.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_Tien.BorderStyle = BorderStyle.FixedSingle;
            txt_Tien.Location = new Point(255, 148);
            txt_Tien.Name = "txt_Tien";
            txt_Tien.Size = new Size(380, 27);
            txt_Tien.TabIndex = 7;
            txt_Tien.TextChanged += txt_Tien_TextChanged;
            // 
            // lbl_Tien
            // 
            lbl_Tien.AutoSize = true;
            lbl_Tien.Font = new Font("Segoe UI", 10F);
            lbl_Tien.Location = new Point(63, 150);
            lbl_Tien.Name = "lbl_Tien";
            lbl_Tien.Size = new Size(186, 23);
            lbl_Tien.TabIndex = 8;
            lbl_Tien.Text = "Số tiền trong tài khoản";
            // 
            // btn_Exit
            // 
            btn_Exit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Exit.Location = new Point(543, 190);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(94, 29);
            btn_Exit.TabIndex = 10;
            btn_Exit.Text = "Thoát";
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // btn_Del
            // 
            btn_Del.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Del.Location = new Point(433, 190);
            btn_Del.Name = "btn_Del";
            btn_Del.Size = new Size(94, 29);
            btn_Del.TabIndex = 11;
            btn_Del.Text = "Xóa";
            btn_Del.UseVisualStyleBackColor = true;
            btn_Del.Click += btn_Del_Click;
            // 
            // btn_Add
            // 
            btn_Add.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Add.Location = new Point(293, 190);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(121, 29);
            btn_Add.TabIndex = 12;
            btn_Add.Text = "Thêm/Cập nhật";
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btn_Add_Click;
            // 
            // lbl_TotalCost
            // 
            lbl_TotalCost.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lbl_TotalCost.AutoSize = true;
            lbl_TotalCost.Location = new Point(433, 403);
            lbl_TotalCost.Name = "lbl_TotalCost";
            lbl_TotalCost.Size = new Size(72, 20);
            lbl_TotalCost.TabIndex = 14;
            lbl_TotalCost.Text = "Tổng tiền";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // txt_TotalCost
            // 
            txt_TotalCost.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txt_TotalCost.BorderStyle = BorderStyle.FixedSingle;
            txt_TotalCost.Location = new Point(518, 400);
            txt_TotalCost.Name = "txt_TotalCost";
            txt_TotalCost.ReadOnly = true;
            txt_TotalCost.Size = new Size(270, 27);
            txt_TotalCost.TabIndex = 16;
            // 
            // lvTaiKhoan
            // 
            lvTaiKhoan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvTaiKhoan.Columns.AddRange(new ColumnHeader[] { colSTT, colSoTK, colTen, colDiaChi, colSoTien });
            lvTaiKhoan.FullRowSelect = true;
            lvTaiKhoan.GridLines = true;
            lvTaiKhoan.Location = new Point(18, 229);
            lvTaiKhoan.Name = "lvTaiKhoan";
            lvTaiKhoan.Size = new Size(770, 165);
            lvTaiKhoan.TabIndex = 17;
            lvTaiKhoan.UseCompatibleStateImageBehavior = false;
            lvTaiKhoan.View = View.Details;
            lvTaiKhoan.SelectedIndexChanged += lvTaiKhoan_SelectedIndexChanged;
            // 
            // colSTT
            // 
            colSTT.Text = "STT";
            colSTT.Width = 36;
            // 
            // colSoTK
            // 
            colSoTK.Text = "Mã tài khoản";
            colSoTK.Width = 98;
            // 
            // colTen
            // 
            colTen.Text = "Tên khách hàng";
            colTen.Width = 115;
            // 
            // colDiaChi
            // 
            colDiaChi.Text = "Địa chỉ";
            colDiaChi.Width = 58;
            // 
            // colSoTien
            // 
            colSoTien.Text = "Số tiền";
            colSoTien.Width = 459;
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lvTaiKhoan);
            Controls.Add(txt_TotalCost);
            Controls.Add(lbl_TotalCost);
            Controls.Add(btn_Add);
            Controls.Add(btn_Del);
            Controls.Add(btn_Exit);
            Controls.Add(lbl_Tien);
            Controls.Add(txt_Tien);
            Controls.Add(txt_DiaChi);
            Controls.Add(lbl_DiaChi);
            Controls.Add(lbl_Ten);
            Controls.Add(txt_Ten);
            Controls.Add(txt_SoTK);
            Controls.Add(lbl_SoTK);
            Controls.Add(lbl_QLTK);
            Name = "Form";
            Text = "Quản Lý Tài Khoản";
            Paint += Form_Paint;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_QLTK;
        private Label lbl_SoTK;
        private TextBox txt_SoTK;
        private TextBox txt_Ten;
        private Label lbl_Ten;
        private Label lbl_DiaChi;
        private TextBox txt_DiaChi;
        private TextBox txt_Tien;
        private Label lbl_Tien;
        private Button btn_Exit;
        private Button btn_Del;
        private Button btn_Add;
        private Label lbl_TotalCost;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox txt_TotalCost;
        private ListView lvTaiKhoan;
        private ColumnHeader colSTT;
        private ColumnHeader colSoTK;
        private ColumnHeader colTen;
        private ColumnHeader colDiaChi;
        private ColumnHeader colSoTien;
    }
}
