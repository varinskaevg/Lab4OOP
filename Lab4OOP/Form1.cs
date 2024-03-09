using System.Data;
using System.Windows.Forms;

namespace Lab4OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "������ �����: ";
            label3.Text = "������� ������: ";
            label4.Text = "���� ������: ";
            label5.Text = "����� ���� ����������: ";
            btnOK.Text = "����������";

            label6.Text = "������ ����� :";
            btnOK2.Text = "����������";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtN.Text))
            {
                MessageBox.Show("���������, �������� �� ������� ����");
                return;
            }

            string input = txtN.Text;
            double[] array = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                   .Select(double.Parse)
                                   .ToArray();

            double positiveProduct = 1;
            foreach (var num in array)
            {
                if (num > 0)
                {
                    positiveProduct *= num;
                }
            }

            double min = array.Min();
            double sumBeforeMin = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == min)
                {
                    break;
                }
                sumBeforeMin += array[i];
            }

            var evenSorted = array.Where((x, i) => i % 2 == 0).OrderBy(x => x).ToArray();
            var oddSorted = array.Where((x, i) => i % 2 != 0).OrderBy(x => x).ToArray();

            lblResult1.Text = $"������� �������� ��������: {positiveProduct}";
            lblResult2.Text = $"���� �������� �� ����������: {sumBeforeMin}";
            lblResult3.Text = $"���� �������� (���������): {string.Join(", ", oddSorted)}\n" +
                          $"������ �������� (���������): {string.Join(", ", evenSorted)}";

        }

        private void txtN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == ' ')
            {
                return;
            }
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            {
                return;
            }
            e.Handled = true;
        }

        private int[,] array;

        private void btnOK2_Click(object sender, EventArgs e)
        {
            string input = txtArray.Text.Trim();
            string[] elements = input.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            int n = (int)Math.Sqrt(elements.Length);
            if (n * n != elements.Length)
            {
                MessageBox.Show("�������� ����� �� ������ ���������� �����.");
                return;
            }

            int[,] array = new int[n, n];
            int index = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (!int.TryParse(elements[index], out array[i, j]))
                    {
                        MessageBox.Show("������ ��� ����� ������� ������.");
                        return;
                    }
                    index++;
                }
            }

            int bottomRightElement = array[n - 1, n - 1];
            int topLeftElement = array[0, 0];

            lblResult4.Text = $"\n�����:\n{ArrayToString(array)}";
            lblResult5.Text = $"\n������� � ������� �������� ���: {bottomRightElement}";
            lblResult6.Text = $"\n������� � ����� ��������� ���: {topLeftElement}";

        }
        private string ArrayToString(int[,] array)
        {
            string arrayString = "";
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    arrayString += array[i, j] + " ";
                }
                arrayString += "\n";
            }
            return arrayString;
        }

        private void txtArray_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == ' ' || e.KeyChar == ',')
            {
                return;
            }
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            {
                return;
            }
            e.Handled = true;
        }
    }
}

        