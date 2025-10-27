using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bai03
{
    public partial class Form1 : Form
    {
        private Button btnChangeColor;
        private Random random; // tạo biến random để random 3 màu cơ bản

        public Form1()
        {
            InitializeComponent();

            btnChangeColor = new Button();
            btnChangeColor.Text = "Change Color";
            btnChangeColor.Size = new Size(120, 40);
            btnChangeColor.Location = new Point(
                (this.Width - btnChangeColor.Width)/2, (this.Height - btnChangeColor.Width)/ 2
            );
            btnChangeColor.Click += BtnChangeColor_Click;
            btnChangeColor.BackColor =  Color.White;
            btnChangeColor.Anchor = AnchorStyles.None;//căn cho button ở giữa, kể cả phóng to
            this.Controls.Add(btnChangeColor);
         
            random = new Random();
        }

        private void BtnChangeColor_Click(object sender, EventArgs e)
        {
            Color randomColor = Color.FromArgb(
                random.Next(256), // Red
                random.Next(256), // Green
                random.Next(256)  // Black
            );

            // Đổi màu nền form
            this.BackColor = randomColor;
        }
    }
}
