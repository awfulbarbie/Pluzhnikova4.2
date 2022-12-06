using System.Windows.Forms;

namespace lab4._2_graph_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
        }

         void recursion(int n, int row)
        {
            if (row > n)
                return;

            for (int i = row; i > 0; i--)
            {
                textBox1.Text += "  " + i;
            }
            textBox1.Text += " " + Environment.NewLine;
            recursion(n, row + 1);
        }
        private void button1_Click(object sender, EventArgs e)
        {

            {
                textBox1.Text = "";
                int n;

                if (numericUpDown1.Value <= 0)
                {
                    MessageBox.Show("Ошибка! N не является целым числом или имеет отрицательное или нулевое значение! Повторите попытку!", "Ошибка",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    return;
                }

                n = (int)numericUpDown1.Value;

                recursion(n, 1);
            }

        }
    }
}