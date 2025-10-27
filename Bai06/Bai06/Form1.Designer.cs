namespace Bai06
{
    partial class Calculator
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
            menuStrip = new MenuStrip();
            menu_Edit = new ToolStripMenuItem();
            menu_View = new ToolStripMenuItem();
            menu_Help = new ToolStripMenuItem();
            txt_Display = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            btn_Equal = new Button();
            btn_Add = new Button();
            btn_Decimal = new Button();
            btn_Opposite = new Button();
            btn_0 = new Button();
            btn_Mcong = new Button();
            btn_Fraction = new Button();
            btn_Subtract = new Button();
            btn_3 = new Button();
            btn_2 = new Button();
            btn_1 = new Button();
            btn_MS = new Button();
            btn_Percent = new Button();
            btn_Multiple = new Button();
            btn_6 = new Button();
            btn_5 = new Button();
            btn_4 = new Button();
            btn_MR = new Button();
            btn_Sqrt = new Button();
            btn_Divide = new Button();
            btn_9 = new Button();
            btn_8 = new Button();
            btn_MC = new Button();
            btn_7 = new Button();
            btn_Backspace = new Button();
            btn_CE = new Button();
            btn_C = new Button();
            menuStrip.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { menu_Edit, menu_View, menu_Help });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(582, 28);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // menu_Edit
            // 
            menu_Edit.Name = "menu_Edit";
            menu_Edit.Size = new Size(49, 24);
            menu_Edit.Text = "Edit";
            // 
            // menu_View
            // 
            menu_View.Name = "menu_View";
            menu_View.Size = new Size(55, 24);
            menu_View.Text = "View";
            // 
            // menu_Help
            // 
            menu_Help.Name = "menu_Help";
            menu_Help.Size = new Size(55, 24);
            menu_Help.Text = "Help";
            // 
            // txt_Display
            // 
            txt_Display.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_Display.BorderStyle = BorderStyle.FixedSingle;
            txt_Display.Font = new Font("Segoe UI", 15F);
            txt_Display.Location = new Point(15, 31);
            txt_Display.Name = "txt_Display";
            txt_Display.ReadOnly = true;
            txt_Display.RightToLeft = RightToLeft.No;
            txt_Display.Size = new Size(550, 41);
            txt_Display.TabIndex = 1;
            txt_Display.TextAlign = HorizontalAlignment.Right;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.Controls.Add(btn_Equal, 5, 3);
            tableLayoutPanel1.Controls.Add(btn_Add, 4, 3);
            tableLayoutPanel1.Controls.Add(btn_Decimal, 3, 3);
            tableLayoutPanel1.Controls.Add(btn_Opposite, 2, 3);
            tableLayoutPanel1.Controls.Add(btn_0, 1, 3);
            tableLayoutPanel1.Controls.Add(btn_Mcong, 0, 3);
            tableLayoutPanel1.Controls.Add(btn_Fraction, 5, 2);
            tableLayoutPanel1.Controls.Add(btn_Subtract, 4, 2);
            tableLayoutPanel1.Controls.Add(btn_3, 3, 2);
            tableLayoutPanel1.Controls.Add(btn_2, 2, 2);
            tableLayoutPanel1.Controls.Add(btn_1, 1, 2);
            tableLayoutPanel1.Controls.Add(btn_MS, 0, 2);
            tableLayoutPanel1.Controls.Add(btn_Percent, 5, 1);
            tableLayoutPanel1.Controls.Add(btn_Multiple, 4, 1);
            tableLayoutPanel1.Controls.Add(btn_6, 3, 1);
            tableLayoutPanel1.Controls.Add(btn_5, 2, 1);
            tableLayoutPanel1.Controls.Add(btn_4, 1, 1);
            tableLayoutPanel1.Controls.Add(btn_MR, 0, 1);
            tableLayoutPanel1.Controls.Add(btn_Sqrt, 5, 0);
            tableLayoutPanel1.Controls.Add(btn_Divide, 4, 0);
            tableLayoutPanel1.Controls.Add(btn_9, 3, 0);
            tableLayoutPanel1.Controls.Add(btn_8, 2, 0);
            tableLayoutPanel1.Controls.Add(btn_MC, 0, 0);
            tableLayoutPanel1.Controls.Add(btn_7, 1, 0);
            tableLayoutPanel1.Location = new Point(15, 153);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(550, 260);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // btn_Equal
            // 
            btn_Equal.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btn_Equal.ForeColor = Color.Red;
            btn_Equal.Location = new Point(468, 198);
            btn_Equal.Name = "btn_Equal";
            btn_Equal.Size = new Size(79, 59);
            btn_Equal.TabIndex = 23;
            btn_Equal.Text = "=";
            btn_Equal.UseVisualStyleBackColor = true;
            btn_Equal.Click += btn_Equal_Click;
            // 
            // btn_Add
            // 
            btn_Add.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btn_Add.ForeColor = Color.Red;
            btn_Add.Location = new Point(386, 198);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(76, 59);
            btn_Add.TabIndex = 22;
            btn_Add.Text = "+";
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btn_UpdateExp_Click;
            // 
            // btn_Decimal
            // 
            btn_Decimal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_Decimal.ForeColor = SystemColors.HotTrack;
            btn_Decimal.Location = new Point(304, 198);
            btn_Decimal.Name = "btn_Decimal";
            btn_Decimal.Size = new Size(76, 59);
            btn_Decimal.TabIndex = 21;
            btn_Decimal.Text = ".";
            btn_Decimal.UseVisualStyleBackColor = true;
            btn_Decimal.Click += btn_UpdateExp_Click;
            // 
            // btn_Opposite
            // 
            btn_Opposite.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_Opposite.ForeColor = SystemColors.HotTrack;
            btn_Opposite.Location = new Point(222, 198);
            btn_Opposite.Name = "btn_Opposite";
            btn_Opposite.Size = new Size(76, 59);
            btn_Opposite.TabIndex = 20;
            btn_Opposite.Text = "+/-";
            btn_Opposite.UseVisualStyleBackColor = true;
            btn_Opposite.Click += btn_Opposite_Click;
            // 
            // btn_0
            // 
            btn_0.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_0.ForeColor = SystemColors.HotTrack;
            btn_0.Location = new Point(140, 198);
            btn_0.Name = "btn_0";
            btn_0.Size = new Size(76, 59);
            btn_0.TabIndex = 19;
            btn_0.Text = "0";
            btn_0.UseVisualStyleBackColor = true;
            btn_0.Click += btn_UpdateExp_Click;
            // 
            // btn_Mcong
            // 
            btn_Mcong.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btn_Mcong.ForeColor = Color.Red;
            btn_Mcong.Location = new Point(3, 198);
            btn_Mcong.Name = "btn_Mcong";
            btn_Mcong.Size = new Size(131, 59);
            btn_Mcong.TabIndex = 18;
            btn_Mcong.Text = "M+";
            btn_Mcong.UseVisualStyleBackColor = true;
            btn_Mcong.Click += btn_Mcong_Click;
            // 
            // btn_Fraction
            // 
            btn_Fraction.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_Fraction.ForeColor = SystemColors.HotTrack;
            btn_Fraction.Location = new Point(468, 133);
            btn_Fraction.Name = "btn_Fraction";
            btn_Fraction.Size = new Size(79, 59);
            btn_Fraction.TabIndex = 17;
            btn_Fraction.Text = "1/x";
            btn_Fraction.UseVisualStyleBackColor = true;
            btn_Fraction.Click += btn_Fraction_Click;
            // 
            // btn_Subtract
            // 
            btn_Subtract.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btn_Subtract.ForeColor = Color.Red;
            btn_Subtract.Location = new Point(386, 133);
            btn_Subtract.Name = "btn_Subtract";
            btn_Subtract.Size = new Size(76, 59);
            btn_Subtract.TabIndex = 16;
            btn_Subtract.Text = "-";
            btn_Subtract.UseVisualStyleBackColor = true;
            btn_Subtract.Click += btn_UpdateExp_Click;
            // 
            // btn_3
            // 
            btn_3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_3.ForeColor = SystemColors.HotTrack;
            btn_3.Location = new Point(304, 133);
            btn_3.Name = "btn_3";
            btn_3.Size = new Size(76, 59);
            btn_3.TabIndex = 15;
            btn_3.Text = "3";
            btn_3.UseVisualStyleBackColor = true;
            btn_3.Click += btn_UpdateExp_Click;
            // 
            // btn_2
            // 
            btn_2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_2.ForeColor = SystemColors.HotTrack;
            btn_2.Location = new Point(222, 133);
            btn_2.Name = "btn_2";
            btn_2.Size = new Size(76, 59);
            btn_2.TabIndex = 14;
            btn_2.Text = "2";
            btn_2.UseVisualStyleBackColor = true;
            btn_2.Click += btn_UpdateExp_Click;
            // 
            // btn_1
            // 
            btn_1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_1.ForeColor = SystemColors.HotTrack;
            btn_1.Location = new Point(140, 133);
            btn_1.Name = "btn_1";
            btn_1.Size = new Size(76, 59);
            btn_1.TabIndex = 13;
            btn_1.Text = "1";
            btn_1.UseVisualStyleBackColor = true;
            btn_1.Click += btn_UpdateExp_Click;
            // 
            // btn_MS
            // 
            btn_MS.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btn_MS.ForeColor = Color.Red;
            btn_MS.Location = new Point(3, 133);
            btn_MS.Name = "btn_MS";
            btn_MS.Size = new Size(131, 59);
            btn_MS.TabIndex = 12;
            btn_MS.Text = "MS";
            btn_MS.UseVisualStyleBackColor = true;
            btn_MS.Click += btn_MS_Click;
            // 
            // btn_Percent
            // 
            btn_Percent.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_Percent.ForeColor = SystemColors.HotTrack;
            btn_Percent.Location = new Point(468, 68);
            btn_Percent.Name = "btn_Percent";
            btn_Percent.Size = new Size(79, 59);
            btn_Percent.TabIndex = 11;
            btn_Percent.Text = "%";
            btn_Percent.UseVisualStyleBackColor = true;
            btn_Percent.Click += btn_Percent_Click;
            // 
            // btn_Multiple
            // 
            btn_Multiple.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btn_Multiple.ForeColor = Color.Red;
            btn_Multiple.Location = new Point(386, 68);
            btn_Multiple.Name = "btn_Multiple";
            btn_Multiple.Size = new Size(76, 59);
            btn_Multiple.TabIndex = 10;
            btn_Multiple.Text = "*";
            btn_Multiple.UseVisualStyleBackColor = true;
            btn_Multiple.Click += btn_UpdateExp_Click;
            // 
            // btn_6
            // 
            btn_6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_6.ForeColor = SystemColors.HotTrack;
            btn_6.Location = new Point(304, 68);
            btn_6.Name = "btn_6";
            btn_6.Size = new Size(76, 59);
            btn_6.TabIndex = 9;
            btn_6.Text = "6";
            btn_6.UseVisualStyleBackColor = true;
            btn_6.Click += btn_UpdateExp_Click;
            // 
            // btn_5
            // 
            btn_5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_5.ForeColor = SystemColors.HotTrack;
            btn_5.Location = new Point(222, 68);
            btn_5.Name = "btn_5";
            btn_5.Size = new Size(76, 59);
            btn_5.TabIndex = 8;
            btn_5.Text = "5";
            btn_5.UseVisualStyleBackColor = true;
            btn_5.Click += btn_UpdateExp_Click;
            // 
            // btn_4
            // 
            btn_4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_4.ForeColor = SystemColors.HotTrack;
            btn_4.Location = new Point(140, 68);
            btn_4.Name = "btn_4";
            btn_4.Size = new Size(76, 59);
            btn_4.TabIndex = 7;
            btn_4.Text = "4";
            btn_4.UseVisualStyleBackColor = true;
            btn_4.Click += btn_UpdateExp_Click;
            // 
            // btn_MR
            // 
            btn_MR.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btn_MR.ForeColor = Color.Red;
            btn_MR.Location = new Point(3, 68);
            btn_MR.Name = "btn_MR";
            btn_MR.Size = new Size(131, 59);
            btn_MR.TabIndex = 6;
            btn_MR.Text = "MR";
            btn_MR.UseVisualStyleBackColor = true;
            btn_MR.Click += btn_MR_Click;
            // 
            // btn_Sqrt
            // 
            btn_Sqrt.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_Sqrt.ForeColor = SystemColors.HotTrack;
            btn_Sqrt.Location = new Point(468, 3);
            btn_Sqrt.Name = "btn_Sqrt";
            btn_Sqrt.Size = new Size(79, 59);
            btn_Sqrt.TabIndex = 5;
            btn_Sqrt.Text = "sqrt";
            btn_Sqrt.UseVisualStyleBackColor = true;
            btn_Sqrt.Click += btn_Sqrt_Click;
            // 
            // btn_Divide
            // 
            btn_Divide.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btn_Divide.ForeColor = Color.Red;
            btn_Divide.Location = new Point(386, 3);
            btn_Divide.Name = "btn_Divide";
            btn_Divide.Size = new Size(76, 59);
            btn_Divide.TabIndex = 4;
            btn_Divide.Text = "/";
            btn_Divide.UseVisualStyleBackColor = true;
            btn_Divide.Click += btn_UpdateExp_Click;
            // 
            // btn_9
            // 
            btn_9.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_9.ForeColor = SystemColors.HotTrack;
            btn_9.Location = new Point(304, 3);
            btn_9.Name = "btn_9";
            btn_9.Size = new Size(76, 59);
            btn_9.TabIndex = 3;
            btn_9.Text = "9";
            btn_9.UseVisualStyleBackColor = true;
            btn_9.Click += btn_UpdateExp_Click;
            // 
            // btn_8
            // 
            btn_8.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_8.ForeColor = SystemColors.HotTrack;
            btn_8.Location = new Point(222, 3);
            btn_8.Name = "btn_8";
            btn_8.Size = new Size(76, 59);
            btn_8.TabIndex = 2;
            btn_8.Text = "8";
            btn_8.UseVisualStyleBackColor = true;
            btn_8.Click += btn_UpdateExp_Click;
            // 
            // btn_MC
            // 
            btn_MC.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btn_MC.ForeColor = Color.Red;
            btn_MC.Location = new Point(3, 3);
            btn_MC.Name = "btn_MC";
            btn_MC.Size = new Size(131, 59);
            btn_MC.TabIndex = 0;
            btn_MC.Text = "MC";
            btn_MC.UseVisualStyleBackColor = true;
            btn_MC.Click += btn_MC_Click;
            // 
            // btn_7
            // 
            btn_7.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_7.ForeColor = SystemColors.HotTrack;
            btn_7.Location = new Point(140, 3);
            btn_7.Name = "btn_7";
            btn_7.Size = new Size(76, 59);
            btn_7.TabIndex = 1;
            btn_7.Text = "7";
            btn_7.UseVisualStyleBackColor = true;
            btn_7.Click += btn_UpdateExp_Click;
            // 
            // btn_Backspace
            // 
            btn_Backspace.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btn_Backspace.ForeColor = Color.Red;
            btn_Backspace.Location = new Point(155, 85);
            btn_Backspace.Name = "btn_Backspace";
            btn_Backspace.Size = new Size(136, 59);
            btn_Backspace.TabIndex = 3;
            btn_Backspace.Text = "Backspace";
            btn_Backspace.UseVisualStyleBackColor = true;
            btn_Backspace.Click += btn_Backspace_Click;
            // 
            // btn_CE
            // 
            btn_CE.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btn_CE.ForeColor = Color.Red;
            btn_CE.Location = new Point(297, 85);
            btn_CE.Name = "btn_CE";
            btn_CE.Size = new Size(131, 59);
            btn_CE.TabIndex = 4;
            btn_CE.Text = "CE";
            btn_CE.UseVisualStyleBackColor = true;
            btn_CE.Click += btn_CE_Click;
            // 
            // btn_C
            // 
            btn_C.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btn_C.ForeColor = Color.Red;
            btn_C.Location = new Point(434, 85);
            btn_C.Name = "btn_C";
            btn_C.Size = new Size(131, 59);
            btn_C.TabIndex = 5;
            btn_C.Text = "C";
            btn_C.UseVisualStyleBackColor = true;
            btn_C.Click += btn_C_Click;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(582, 453);
            Controls.Add(btn_C);
            Controls.Add(btn_CE);
            Controls.Add(btn_Backspace);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(txt_Display);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "Calculator";
            Text = "Calculator";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem menu_Edit;
        private ToolStripMenuItem menu_View;
        private ToolStripMenuItem menu_Help;
        private TextBox txt_Display;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btn_MC;
        private Button btn_Equal;
        private Button btn_Add;
        private Button btn_Decimal;
        private Button btn_Opposite;
        private Button btn_0;
        private Button btn_Mcong;
        private Button btn_Fraction;
        private Button btn_Subtract;
        private Button btn_3;
        private Button btn_2;
        private Button btn_1;
        private Button btn_MS;
        private Button btn_Percent;
        private Button btn_Multiple;
        private Button btn_6;
        private Button btn_5;
        private Button btn_4;
        private Button btn_MR;
        private Button btn_Sqrt;
        private Button btn_Divide;
        private Button btn_9;
        private Button btn_8;
        private Button btn_7;
        private Button btn_Backspace;
        private Button btn_CE;
        private Button btn_C;
    }
}
