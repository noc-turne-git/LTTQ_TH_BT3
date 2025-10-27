using System.Data;

namespace Bai06
{
    public partial class Calculator : Form
    {
        private string Exp = "";
        private double store = 0;
        public Calculator()
        {
            InitializeComponent();
        }

        // Clear 1 char
        private void btn_Backspace_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Display.Text)) return;
            Exp = Exp.Remove(Exp.Length - 1, 1);
            txt_Display.Text = Exp;
        }

        private void btn_UpdateExp_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Exp += btn.Text;
            txt_Display.Text = Exp;
        }

        private void btn_Opposite_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Exp)) return;

            int LastOp = -1;
            for (int i = Exp.Length - 1; i >= 0; i--)
            {
                char c = Exp[i];
                if ("+-*/".Contains(c))
                {
                    // neu la '-' va truoc co dau "+-*/" thì bỏ qua, (kiem tra them i = 0 tranh [i - 1] loi)
                    if (c == '-' && (i == 0 || "+-*/".Contains(Exp[i - 1])))
                        continue;

                    LastOp = i;
                    break;
                }
            }

            double tempt = double.Parse(Exp.Substring(LastOp + 1));
            tempt = -tempt;
            Exp = Exp.Substring(0, LastOp + 1);
            Exp += tempt.ToString();
            txt_Display.Text = Exp;
        }


        private void btn_Equal_Click(object sender, EventArgs e)
        {
            try
            {
                if (Exp.Contains("/0"))
                {
                    throw new DivideByZeroException("Cannot divide by zero!");
                }
                var dt = new DataTable();
                var result = dt.Compute(Exp, "");
                Exp = result.ToString();
                txt_Display.Text = Exp;
            }
            catch (DivideByZeroException) // /0
            {
                MessageBox.Show("Error: Divide by zero!");
            }
            catch (SyntaxErrorException) // +++
            {
                MessageBox.Show("Error : Invalid Syntax!");
            }
            catch (EvaluateException) // sqrt(-1)
            {
                MessageBox.Show("Error : Invalid Expression!");
            }
            catch
            {
                MessageBox.Show("Error: Can't define");
            }
        }

        //Clear the number closest to Last Operator
        private void btn_CE_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Display.Text)) return;
            int LastOp = -1;
            for (int i = Exp.Length - 1; i >= 0; i--)
            {
                char c = Exp[i];
                if ("+-*/".Contains(c))
                {
                    // neu la '-' va truoc co dau "+-*/" thì bỏ qua, (kiem tra them i = 0 tranh [i - 1] loi)
                    if (c == '-' && (i == 0 || "+-*/".Contains(Exp[i - 1])))
                        continue;

                    LastOp = i;
                    break;
                }
            }

            Exp = Exp.Remove(LastOp + 1, Exp.Length - LastOp - 1);
            txt_Display.Text = Exp;
        }

        // Clear All
        private void btn_C_Click(object sender, EventArgs e)
        {
            Exp = "";
            txt_Display.Text = Exp;
        }

        private void btn_MS_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.TryParse(txt_Display.Text, out double S))
                {
                    store = S;
                }
            }
            catch
            {
                MessageBox.Show("Can't store an expression");
            }
        }

        private void btn_Mcong_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.TryParse(txt_Display.Text, out double S))
                {
                    store += S;
                }
            }
            catch
            {
                MessageBox.Show("Can't add an expression");
            }
        }
        private void btn_MR_Click(object sender, EventArgs e)
        {
            Exp += store.ToString();
            txt_Display.Text = Exp;
        }

        private void btn_MC_Click(object sender, EventArgs e)
        {
            store = 0;
        }

        private void btn_Sqrt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Exp)) return;
            int LastAdd = Exp.LastIndexOf("+");
            int LastSub = Exp.LastIndexOf("-");
            int LastDiv = Exp.LastIndexOf("/");
            int LastMuti = Exp.LastIndexOf("*");
            int LastOp = Math.Max(LastAdd, Math.Max(LastSub, Math.Max(LastDiv, LastMuti)));

            double tempt = double.Parse(Exp.Substring(LastOp + 1, Exp.Length - LastOp - 1));
            tempt = Math.Sqrt(tempt);
            tempt = Math.Round(tempt, 3); // lam tron 3 so sau dau thap phan
            Exp = Exp.Remove(LastOp + 1, Exp.Length - LastOp - 1);
            Exp += tempt.ToString();
            txt_Display.Text = Exp;
        }

        private void btn_Percent_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Exp)) return;
            int LastAdd = Exp.LastIndexOf("+");
            int LastSub = Exp.LastIndexOf("-");
            int LastDiv = Exp.LastIndexOf("/");
            int LastMuti = Exp.LastIndexOf("*");
            int LastOp = Math.Max(LastAdd, Math.Max(LastSub, Math.Max(LastDiv, LastMuti)));

            double tempt = double.Parse(Exp.Substring(LastOp + 1, Exp.Length - LastOp - 1));
            tempt = tempt / 100;
            tempt = Math.Round(tempt, 3); // lam tron 3 so sau dau thap phan
            Exp = Exp.Remove(LastOp + 1, Exp.Length - LastOp - 1);
            Exp += tempt.ToString();
            txt_Display.Text = Exp;
        }

        private void btn_Fraction_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Exp)) return;
            int LastAdd = Exp.LastIndexOf("+");
            int LastSub = Exp.LastIndexOf("-");
            int LastDiv = Exp.LastIndexOf("/");
            int LastMuti = Exp.LastIndexOf("*");
            int LastOp = Math.Max(LastAdd, Math.Max(LastSub, Math.Max(LastDiv, LastMuti)));

            double tempt = double.Parse(Exp.Substring(LastOp + 1, Exp.Length - LastOp - 1));
            tempt = 1 / tempt;
            tempt = Math.Round(tempt, 3); // lam tron 3 so sau dau thap phan
            Exp = Exp.Remove(LastOp + 1, Exp.Length - LastOp - 1);
            Exp += tempt.ToString();
            txt_Display.Text = Exp;
        }

        
    }
}
