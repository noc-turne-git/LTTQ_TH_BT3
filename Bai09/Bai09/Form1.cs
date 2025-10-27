using System.Collections.Generic;
using System.Windows.Forms;

namespace Bai09
{
    public partial class Form1 : Form
    {
       /* const bool Nu = false;
        const bool Nam = true;*/
        private HashSet<string> ListMSSV = new HashSet<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void ResetForm()
        {
            txt_MSSV.Clear();
            txt_Name.Clear();
            radMale.Checked = false;
            radFemale.Checked = false;
            combo_Major.SelectedIndex = -1;
            list_MonDaChon.Items.Clear();
            list_MonHoc.Items.Clear();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MSSV.Text) || string.IsNullOrEmpty(txt_Name.Text)
                || combo_Major.SelectedItem == null || (!radMale.Checked && !radFemale.Checked))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!.");
                return;
            }

            string Sexual = "Nam"; // mặc định
            if (radFemale.Checked) Sexual = "Nữ";
            string MSSV = txt_MSSV.Text;
            string Name = txt_Name.Text;
            string Major = combo_Major.SelectedItem?.ToString();
            int SoMon = list_MonDaChon.Items.Count;

            if (!ListMSSV.Contains(MSSV))
            {
                ListMSSV.Add(MSSV);
                dgvSinhVien.Rows.Add(MSSV, Name, Major, Sexual, SoMon);
                MessageBox.Show("Thêm sinh viên mới thành công!");
                ResetForm();
            }
            else
            {
                MessageBox.Show("Mã số sinh viên này đã tồn tại");
                txt_MSSV.Clear();
            }
        }

        private void combo_Major_SelectedIndexChanged(object sender, EventArgs e)
        {
            //mỗi lần chuyển sẽ xóa toàn bộ và thêm vào lại các item đúng với ngành đó
            list_MonHoc.Items.Clear();
            list_MonDaChon.Items.Clear(); //đảm bảo ko chọn 2 môn trùng nhau / hay chọn môn kp của ngành mình

            string Major = (string)combo_Major.SelectedItem;
            //Them cac mon dai cuong va chính trị (bắt buộc phải học)
            list_MonHoc.Items.Add("Nhập môn lập trình");
            list_MonHoc.Items.Add("Lập trình hướng đối tượng");
            list_MonHoc.Items.Add("Cấu trúc dữ liệu và giải thuật");
            list_MonHoc.Items.Add("Triết học Mác - Lênin");
            list_MonHoc.Items.Add("Kinh tế chính trị Mác - Lênin");
            list_MonHoc.Items.Add("Tư tưởng Hồ Chí Minh");
            list_MonHoc.Items.Add("Pháp luật đại cương");
            //Them cac mon co so nganh va chuyen nganh (tuy nganh)
            switch (Major)
            {

                case " Hệ Thống Thông Tin":
                    list_MonHoc.Items.Add("Cơ sở dữ liệu");
                    list_MonHoc.Items.Add("Phân tích và thiết kế hệ thống thông tin");
                    list_MonHoc.Items.Add("Hệ quản trị cơ sở dữ liệu");
                    list_MonHoc.Items.Add("Quản lý dự án công nghệ thông tin");
                    list_MonHoc.Items.Add("Hệ thống thông tin doanh nghiệp");
                    break;
                case "Khoa học Máy tính":
                    list_MonHoc.Items.Add("Học máy");
                    list_MonHoc.Items.Add("Nguyên lý ngôn ngữ lập trình");
                    list_MonHoc.Items.Add("Lý thuyết đồ thị");
                    list_MonHoc.Items.Add("Trí tuệ nhân tạo");
                    list_MonHoc.Items.Add("Học máy");
                    break;
                case "Kỹ thuật Máy tính":
                    list_MonHoc.Items.Add("Kiến trúc máy tính");
                    list_MonHoc.Items.Add("Nguyên lý hệ điều hành");
                    list_MonHoc.Items.Add("Hệ thống nhúng");
                    list_MonHoc.Items.Add("Thiết kế vi mạch số");
                    break;
                case "Mạng máy tính và Truyền thông":
                    list_MonHoc.Items.Add("Mạng máy tính");
                    list_MonHoc.Items.Add("An toàn mạng");
                    list_MonHoc.Items.Add("Quản trị mạng");
                    list_MonHoc.Items.Add("Bảo mật hệ thống thông tin");
                    break;
                case "Khoa học và Kỹ thuật Thông tin":
                    list_MonHoc.Items.Add("Xử lý tín hiệu số");
                    list_MonHoc.Items.Add("Truyền thông dữ liệu");
                    list_MonHoc.Items.Add("Phân tích dữ liệu lớn");
                    list_MonHoc.Items.Add("Hệ thống thông tin thông minh");
                    list_MonHoc.Items.Add("Internet of Things (IoT)");
                    break;
                case "Công Nghệ Phần Mềm":
                    list_MonHoc.Items.Add("Phát triển ứng dụng web");
                    list_MonHoc.Items.Add("Phát triển ứng dụng di động");
                    list_MonHoc.Items.Add("Quản trị cấu hình và DevOps");
                    list_MonHoc.Items.Add("Lập trình trực quan");
                    break;
            }
        }

        private void btn_Chon_Click(object sender, EventArgs e)
        {
            // vừa xóa vừa duyệt danh sách sẽ gây ra lỗi--> cần bộ nhớ tạm
            var MonHoc = list_MonHoc.SelectedItems.Cast<object>().ToList();
            foreach (var mon in MonHoc)
            {
                list_MonDaChon.Items.Add(mon);
                list_MonHoc.Items.Remove(mon);
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            var MonDaChon = list_MonDaChon.SelectedItems.Cast<object>().ToList();
            foreach (var mon in MonDaChon)
            {
                list_MonHoc.Items.Add(mon);
                list_MonDaChon.Items.Remove(mon);
            }
        }

        private void btn_XoaChon_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MSSV.Text)) 
            {
                MessageBox.Show("Vui lòng nhập mã số sinh viên cần xóa!");
                return; 
            }

            if (!ListMSSV.Contains(txt_MSSV.Text))
            {
                MessageBox.Show("Mã số sinh viên không tồn tại!");
                return;
            }

            DialogResult r = MessageBox.Show("Bạn có muốn xóa sinh viên này?", "Xác nhận", MessageBoxButtons.YesNo);

            if (r == DialogResult.Yes)
            {
                // DataGridview để cập nhật giá trị --> .Rows
                foreach (DataGridViewRow row in dgvSinhVien.Rows)
                {
                    if (row.Cells["colMSSV"].Value.ToString() == txt_MSSV.Text)
                    {
                        dgvSinhVien.Rows.Remove(row);
                        ListMSSV.Remove(txt_MSSV.Text);
                        MessageBox.Show("Xoá sinh viên thành công!");
                        ResetForm();
                        break;
                    }
                }
            }
        }
    }
}
