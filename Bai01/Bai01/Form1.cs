namespace Bai01
{
    using System;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        // Cấp console cho app WinForms
        [DllImport("kernel32.dll")]
        private static extern bool AllocConsole();

        public Form1()
        {
            InitializeComponent();

            // this.Created += Form1_Created; only to read
            this.Load += Form1_Load;
            this.Shown += Form1_Shown;
            this.Activated += Form1_Activated;
            this.Deactivate += Form1_Deactivated;
            this.FormClosing += Form1_FormClosing;
            this.FormClosed += Form1_FormClosed;

            /*Button btnExit = new Button();
            btnExit.Text = "Thoát";
            btnExit.Location = new System.Drawing.Point(50, 50);
            btnExit.Click += FormCloseActivate; // this.Close sẽ chạy this.FormClosing --> this.FormClosed
            Controls.Add(btnExit);*/
        }

        // object: form1, e: thông tin của event
        private void Form1_Load(object? sender, EventArgs e)
        {
            AllocConsole(); // Hiển thị cửa sổ console khi form chạy
            Console.WriteLine("Form lifetime event.");
            Console.WriteLine("Form is loading!");
        }

        private void Form1_Shown(object? sender, EventArgs e)
        {
            Console.WriteLine("Form have been shown.");
        }

        private void Form1_Activated(object? sender, EventArgs e)
        {
            Console.WriteLine("Form activated: ready for user interaction.");
        }

        private void Form1_Deactivated(object? sender, EventArgs e)
        {
            Console.WriteLine("Form is deactivated: Form is not ready to interact");
        }

        private void FormCloseActivate(object? sender, EventArgs e)
        {
            Console.WriteLine("Exit button clicked. Attempting to close the form...");
            this.Close(); // this.Close sẽ chạy this.FormClosing --> this.FormClosed
        }

        private void Form1_FormClosing(object? sender, FormClosingEventArgs e)
        {
            //DialogResult : kiểu trả về của hộp thoại DialogResult.OK/No/Yes/Cancel
            DialogResult r;
            r = MessageBox.Show("Are you sure want to close this form?", "Confirm", MessageBoxButtons.YesNo);

            if (r == DialogResult.No)
            {
                // e.Cancel là một thuộc tính của FormClosingEventArgs
                e.Cancel = true;
                Console.WriteLine("You chose to keep the form open.");
            }
            else
            {
                Console.WriteLine("You confirmed to close the form.");
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Console.WriteLine("The form has been closed.");
        }
    }
}
