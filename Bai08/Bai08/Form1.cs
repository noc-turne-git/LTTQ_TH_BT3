namespace Bai08
{
    public partial class Form : System.Windows.Forms.Form
    {
        private Dictionary<string, int> ListSoTK = new Dictionary<string, int>(); // luu so tài khoản và index trong ListView
        double totalCost = 0;
        public Form()
        {
            InitializeComponent();
        }
        private void Form_Paint(object sender, EventArgs e)
        {
            int width = lvTaiKhoan.ClientSize.Width;
            lvTaiKhoan.Columns[0].Width = (int)(width * 0.1);
            lvTaiKhoan.Columns[1].Width = (int)(width * 0.2);
            lvTaiKhoan.Columns[2].Width = (int)(width * 0.25);
            lvTaiKhoan.Columns[3].Width = (int)(width * 0.25);
            lvTaiKhoan.Columns[4].Width = (int)(width * 0.2);
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn muốn thoát ư?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_SoTK.Text) || string.IsNullOrEmpty(txt_Ten.Text)
                || string.IsNullOrEmpty(txt_DiaChi.Text) || string.IsNullOrEmpty(txt_Tien.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            string soTK = txt_SoTK.Text;
            string ten = txt_Ten.Text;
            string diaChi = txt_DiaChi.Text;
            double tien = 0;
            string cleanTxt_Tien = txt_Tien.Text.Replace(",", "");
            if (double.TryParse(cleanTxt_Tien, out double money))
            {
                tien = money;
            } else
            {
                MessageBox.Show("Lỗi cú pháp ở Số tiền trong tài khoản!");
                return;
            }

            if (!ListSoTK.ContainsKey(soTK))
            {
                int index = ListSoTK.Count();
                ListSoTK.Add(soTK, index);
                ListViewItem item = new ListViewItem((index + 1).ToString()); // cột đầu tiên trong constructor
                item.SubItems.Add(soTK);
                item.SubItems.Add(ten);
                item.SubItems.Add(diaChi);
                item.SubItems.Add(string.Format("{0:N0}", tien));
                lvTaiKhoan.Items.Add(item);

                totalCost += tien;
                txt_TotalCost.Text = string.Format("{0:N0}", totalCost);
                MessageBox.Show("Thêm mới dữ liệu thành công!");
            }
            else
            {
                int index = ListSoTK[soTK];
                ListViewItem item = lvTaiKhoan.Items[index];
                // thay đổi tổng tiền
                string cleanTien = item.SubItems[4].Text.Replace(",", "");
                totalCost -= double.Parse(cleanTien);
                totalCost += tien;
                txt_TotalCost.Text = string.Format("{0:N0}", totalCost);
                // thay đổi dữ liệu
                item.SubItems[2].Text = ten;
                item.SubItems[3].Text = diaChi;
                item.SubItems[4].Text = string.Format("{0:N0}", tien);

                MessageBox.Show("Cập nhật dữ liệu thành công!");
            }
        }

        private void lvTaiKhoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            // khi selected item trong listview --> 2 sự kiện : chọn item (count > 0) và bỏ chọn item (count = 0)
            // nên chỉ chạy khi count > 0 để lvTaiKhoan.SelectedItems[0] không bị lỗi
            if (lvTaiKhoan.SelectedItems.Count > 0)
            {
                ListViewItem item = lvTaiKhoan.SelectedItems[0];
                txt_SoTK.Text = item.SubItems[1].Text;
                txt_Ten.Text = item.SubItems[2].Text;
                txt_DiaChi.Text = item.SubItems[3].Text;
                txt_Tien.Text = item.SubItems[4].Text;
            }
            else
            {
                txt_SoTK.Text = "";
                txt_Ten.Text = "";
                txt_DiaChi.Text = "";
                txt_Tien.Text = "";
            }
        }

        private void UpdateSTT(int DeletedIndex)
        {
            for (int i = 0; i < ListSoTK.Count(); i++)
            {
                ListViewItem item = lvTaiKhoan.Items[i];
                int STT = int.Parse(item.SubItems[0].Text);
                string soTK = item.SubItems[1].Text;

                // chỉ những item sau vị trí bị xóa cần sửa.
                if (STT > DeletedIndex)
                {
                    item.SubItems[0].Text = $"{STT - 1}";
                    ListSoTK[soTK] -= 1;
                }
            }
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_SoTK.Text))
            {
                MessageBox.Show("Vui lòng nhập số tài khoản cần xóa!");
                return;
            }

            string soTK = txt_SoTK.Text;

            if (ListSoTK.ContainsKey(soTK))
            {
                DialogResult r;
                r = MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    int index = ListSoTK[soTK];
                    ListViewItem item = lvTaiKhoan.Items[index];

                    // thay đổi tổng tiền
                    string cleanText = item.SubItems[4].Text.Replace(",", "");
                    totalCost -= double.Parse(cleanText);
                    txt_TotalCost.Text = string.Format("{0:N0}", totalCost);

                    // xóa khỏi ListView và Dictionary
                    lvTaiKhoan.Items.RemoveAt(index);
                    ListSoTK.Remove(soTK);

                    UpdateSTT(index);

                    MessageBox.Show("Xóa tài khoản thành công");
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy số tài khoản cần xóa");
            }
        }

        private void txt_Tien_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (string.IsNullOrWhiteSpace(txt.Text)) return;

            //giữ lại vị trí con trỏ ban đầu và độ dài ban đầu của chuỗi
            int selectionStart = txt.SelectionStart;
            int lengthBefore = txt.Text.Length;

            //Bỏ dấu , trong chuỗi để có thể TryParse ra số
            string cleanText = txt.Text.Replace(",", "");


            if (long.TryParse(cleanText, out long value))
            {
                /*{0} : ko định dạng 
                {0:N} : định dạng số (thêm dấu , ) mặc định - có 2 thập phân
                {0:N0} : định dạng số không có số thập phân
                --> chuỗi có thể bị thay đổi nên cần thay đổi selectionStart - vi tri cua con tro*/
                txt.Text = string.Format("{0:N0}", value);

                // thêm bao nhiêu kí tự = diff
                int diff = txt.Text.Length - lengthBefore;
                txt.SelectionStart = Math.Max(0, selectionStart + diff);
            }
        }
    }
}
