namespace Bai07
{
    public partial class Form1 : Form
    {
        private long totalCost;
        const int Lo_A = 1;
        const int Lo_B = 2;
        const int Lo_C = 3;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn_1.Tag = Lo_A;
            btn_2.Tag = Lo_A;
            btn_3.Tag = Lo_A;
            btn_4.Tag = Lo_A;
            btn_5.Tag = Lo_A;

            btn_6.Tag = Lo_B;
            btn_7.Tag = Lo_B;
            btn_8.Tag = Lo_B;
            btn_9.Tag = Lo_B;
            btn_10.Tag = Lo_B;

            btn_11.Tag = Lo_C;
            btn_12.Tag = Lo_C;
            btn_13.Tag = Lo_C;
            btn_14.Tag = Lo_C;
            btn_15.Tag = Lo_C;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;  // button đang click

            if (btn.BackColor == Color.Yellow)  // nếu đã chọn thì thoát
            {
                MessageBox.Show("Ghế này đã được chọn.");
                return;
            }

            long tienGhe = 0;
            int hangGhe = (int)btn.Tag;//ep kieu tu object sang int
            if (hangGhe == Lo_A) tienGhe = 50000;
            else if (hangGhe == Lo_B) tienGhe = 65000;
            else if (hangGhe == Lo_C) tienGhe = 80000;

            if (btn.BackColor == Color.White)
            {
                btn.BackColor = Color.Blue;
                totalCost += tienGhe;
            }
            else
            {
                btn.BackColor = Color.White;
                totalCost -= tienGhe;
            }

            txt_ThanhTien.Text = totalCost.ToString();
        }

        private void btn_1_Click(object sender, EventArgs e) => Button_Click(sender, e);
        private void btn_2_Click(object sender, EventArgs e) => Button_Click(sender, e);
        private void btn_3_Click(object sender, EventArgs e) => Button_Click(sender, e);
        private void btn_4_Click(object sender, EventArgs e) => Button_Click(sender, e);
        private void btn_5_Click(object sender, EventArgs e) => Button_Click(sender, e);
        private void btn_6_Click(object sender, EventArgs e) => Button_Click(sender, e);
        private void btn_7_Click(object sender, EventArgs e) => Button_Click(sender, e);
        private void btn_8_Click(object sender, EventArgs e) => Button_Click(sender, e);
        private void btn_9_Click(object sender, EventArgs e) => Button_Click(sender, e);
        private void btn_10_Click(object sender, EventArgs e) => Button_Click(sender, e);
        private void btn_11_Click(object sender, EventArgs e) => Button_Click(sender, e);
        private void btn_12_Click(object sender, EventArgs e) => Button_Click(sender, e);
        private void btn_13_Click(object sender, EventArgs e) => Button_Click(sender, e);
        private void btn_14_Click(object sender, EventArgs e) => Button_Click(sender, e);
        private void btn_15_Click(object sender, EventArgs e) => Button_Click(sender, e);

        // --- Nút CHỌN ---
        private void btn_Chon_Click(object sender, EventArgs e)
        {
            List<int> GheDaChon = new List<int>();
            int i = 1;
            //đổi màu
            foreach (Control ctrl in FlPnl_Button.Controls)
            {
                //btn la ctrl Button
                if (ctrl is Button btn && btn.Name.StartsWith("btn_"))
                {
                    if (btn.BackColor == Color.Blue)
                    {
                        btn.BackColor = Color.Yellow;
                        GheDaChon.Add(i);
                    }
                    i++;
                }
            }
            string chiTiet = "Các ghế đã đặt: ";
            for (int j=0; j<GheDaChon.Count(); j++)
            {
               chiTiet += $"ghế số {GheDaChon[j]}";
               if (j != GheDaChon.Count() -1) chiTiet += " , ";
            }
            chiTiet += $"\nTổng giá: {txt_ThanhTien.Text}";

            DialogResult result = MessageBox.Show(chiTiet, "Chi tiết đặt hàng"); //(nội dung, title)

            //reset lại giá tiền
            if (result == DialogResult.OK)
            {
                totalCost = 0;
                txt_ThanhTien.Text = totalCost.ToString();
            }
        }

        private void btn_HuyBo_Click(object sender, EventArgs e)
        {
            //đổi màu
            foreach (Control ctrl in FlPnl_Button.Controls)
            {
                if (ctrl is Button btn && btn.Name.StartsWith("btn_"))
                {
                    if (btn.BackColor == Color.Blue)
                        btn.BackColor = Color.White;
                }
            }
            totalCost = 0;
            txt_ThanhTien.Text = totalCost.ToString();
        }

        private void btn_KetThuc_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo);

            if (r == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
