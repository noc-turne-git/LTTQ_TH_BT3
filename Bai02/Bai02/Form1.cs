namespace Bai02
{
    public partial class FormPaintEvent : Form
    {
        private Random rnd;
        public FormPaintEvent()
        {
            InitializeComponent();
            SetUpUI();
        }

        private void SetUpUI()
        {
            this.Paint += FormPaint; // được gọi khi resize, refresh, bị ẩn, Invalidate(),
                                     // vẽ thêm gì đó --> ko gọi Paint , tức là Windon ko yêu cầu hdh gọi Paint
                                     // deactivated: form có thể ko bị ẩn giao diện mà chỉ mất focus. --> ko ve lai
            rnd = new Random();
        }

        private void FormPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics; // PaintEventArgs có hai thuộc tính Graphics, ClipRectangle
            int x = rnd.Next(this.Width);
            int y = rnd.Next(this.Height);
            g.DrawString("Paint Event", this.Font, Brushes.Blue, x, y); // Brushes dùng để vẽ chữ, tô màu,
        }

    }
}
