namespace Bai05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calculate(char op)
        {
            try
            {
                double num1 = double.Parse(txt_Num1.Text);
                double num2 = double.Parse(txt_Num2.Text);
                double result = 0;

                switch (op)
                {
                    case '+': result = num1 + num2; break;
                    case '-': result = num1 - num2; break;
                    case '*': result = num1 * num2; break;
                    case '/':
                        if (num2 == 0)
                            throw new DivideByZeroException("Không thể chia cho 0");
                        result = num1 / num2;
                        break;
                }

                txt_Ans.Text = result.ToString();
            }
            catch (FormatException)
            {
                txt_Ans.Text = "Error";
                MessageBox.Show("Vui lòng nhập số hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DivideByZeroException ex)
            {
                txt_Ans.Text = "Error";
                MessageBox.Show(ex.Message, "Lỗi chia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Cong_Click(object sender, EventArgs e)
        {
            Calculate('+');
        }

        private void btn_Tru_Click(object sender, EventArgs e)
        {
            Calculate('-');
        }

        private void btn_Chia_Click(object sender, EventArgs e)
        {
            Calculate('/');
        }

        private void btn_Nhan_Click(object sender, EventArgs e)
        {
            Calculate('*');
        }
    }
}
