namespace lab4._1_graph_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            static double recursion(double x, int n) //x в степени n - рекурсия
            {
                if (n == 0)
                    return 1;
                else if (n < 0)
                {
                    return 1 / recursion(x, Math.Abs(n));
                }
                return x * recursion(x, n - 1);
            }

            {
                int n;
                double x;

                if (numericUpDown1.Value == 0)
                   {
                        MessageBox.Show("Ошибка! X не является вещественным числом или равен нулю! Повторите попытку!", "Ошибка",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                        return;
                    }

                x = (double)numericUpDown1.Value;
                n = (int)numericUpDown2.Value;


                textBox3.Text = (recursion(x, n)).ToString();
            }
        }
    }
}
