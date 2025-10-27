namespace Bai05
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
            components = new System.ComponentModel.Container();
            lb_Num1 = new Label();
            lb_Num2 = new Label();
            txt_Num1 = new TextBox();
            txt_Num2 = new TextBox();
            btn_Cong = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            btn_Nhan = new Button();
            btn_Chia = new Button();
            btn_Tru = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            lb_Ans = new Label();
            txt_Ans = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lb_Num1
            // 
            lb_Num1.AutoSize = true;
            lb_Num1.Font = new Font("Segoe UI", 9F);
            lb_Num1.Location = new Point(150, 70);
            lb_Num1.Name = "lb_Num1";
            lb_Num1.Size = new Size(75, 20);
            lb_Num1.TabIndex = 0;
            lb_Num1.Text = "Number 1";
            // 
            // lb_Num2
            // 
            lb_Num2.AutoSize = true;
            lb_Num2.Font = new Font("Segoe UI", 9F);
            lb_Num2.Location = new Point(150, 111);
            lb_Num2.Name = "lb_Num2";
            lb_Num2.Size = new Size(75, 20);
            lb_Num2.TabIndex = 1;
            lb_Num2.Text = "Number 2";
            // 
            // txt_Num1
            // 
            txt_Num1.BorderStyle = BorderStyle.FixedSingle;
            txt_Num1.Location = new Point(240, 70);
            txt_Num1.Name = "txt_Num1";
            txt_Num1.Size = new Size(440, 27);
            txt_Num1.TabIndex = 2;
            // 
            // txt_Num2
            // 
            txt_Num2.BorderStyle = BorderStyle.FixedSingle;
            txt_Num2.Location = new Point(240, 111);
            txt_Num2.Name = "txt_Num2";
            txt_Num2.Size = new Size(440, 27);
            txt_Num2.TabIndex = 3;
            // 
            // btn_Cong
            // 
            btn_Cong.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Cong.Location = new Point(3, 3);
            btn_Cong.Name = "btn_Cong";
            btn_Cong.Size = new Size(111, 67);
            btn_Cong.TabIndex = 4;
            btn_Cong.Text = "+";
            btn_Cong.UseVisualStyleBackColor = true;
            btn_Cong.Click += btn_Cong_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(btn_Nhan, 3, 0);
            tableLayoutPanel1.Controls.Add(btn_Chia, 2, 0);
            tableLayoutPanel1.Controls.Add(btn_Tru, 1, 0);
            tableLayoutPanel1.Controls.Add(btn_Cong, 0, 0);
            tableLayoutPanel1.Location = new Point(182, 186);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(470, 73);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // btn_Nhan
            // 
            btn_Nhan.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Nhan.Location = new Point(354, 3);
            btn_Nhan.Name = "btn_Nhan";
            btn_Nhan.Size = new Size(111, 67);
            btn_Nhan.TabIndex = 7;
            btn_Nhan.Text = "*";
            btn_Nhan.UseVisualStyleBackColor = true;
            btn_Nhan.Click += btn_Nhan_Click;
            // 
            // btn_Chia
            // 
            btn_Chia.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Chia.Location = new Point(237, 3);
            btn_Chia.Name = "btn_Chia";
            btn_Chia.Size = new Size(111, 67);
            btn_Chia.TabIndex = 6;
            btn_Chia.Text = "/";
            btn_Chia.UseVisualStyleBackColor = true;
            btn_Chia.Click += btn_Chia_Click;
            // 
            // btn_Tru
            // 
            btn_Tru.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Tru.Location = new Point(120, 3);
            btn_Tru.Name = "btn_Tru";
            btn_Tru.Size = new Size(111, 67);
            btn_Tru.TabIndex = 5;
            btn_Tru.Text = "-";
            btn_Tru.UseVisualStyleBackColor = true;
            btn_Tru.Click += btn_Tru_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // lb_Ans
            // 
            lb_Ans.AutoSize = true;
            lb_Ans.Font = new Font("Segoe UI", 9F);
            lb_Ans.Location = new Point(150, 322);
            lb_Ans.Name = "lb_Ans";
            lb_Ans.Size = new Size(57, 20);
            lb_Ans.TabIndex = 7;
            lb_Ans.Text = "Answer";
            // 
            // txt_Ans
            // 
            txt_Ans.BorderStyle = BorderStyle.FixedSingle;
            txt_Ans.Location = new Point(240, 322);
            txt_Ans.Name = "txt_Ans";
            txt_Ans.ReadOnly = true;
            txt_Ans.Size = new Size(440, 27);
            txt_Ans.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_Ans);
            Controls.Add(lb_Ans);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(txt_Num2);
            Controls.Add(txt_Num1);
            Controls.Add(lb_Num2);
            Controls.Add(lb_Num1);
            Name = "Form1";
            Text = "Calculator_Basic";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_Num1;
        private Label lb_Num2;
        private TextBox txt_Num1;
        private TextBox txt_Num2;
        private Button btn_Cong;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btn_Nhan;
        private Button btn_Chia;
        private Button btn_Tru;
        private ContextMenuStrip contextMenuStrip1;
        private Label lb_Ans;
        private TextBox txt_Ans;
    }
}
