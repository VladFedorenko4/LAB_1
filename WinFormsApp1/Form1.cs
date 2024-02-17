using System;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            //�������� 1
            label1.Text = "x =";
            label2.Text = "y =";
            label4.Text = "���������";
            BtnOk.Text = "����������";
            IblResult.Text = "";

            //�������� 2
            X1.Text = "x1 =";
            Y1.Text = "y1 =";
            X2.Text = "x2 =";
            Y2.Text = "y2 =";
            label8.Text = "��������";
            button1.Text = "���������";

            //�������� 3
            A.Text = "a = ";
            C.Text = "c = ";
            D.Text = "d = ";
            buttonCheck.Text = "���������";

            //�������� 4
            label_x1.Text = "x1 =";
            label_y1.Text = "y1 =";
            label_x2.Text = "x2 =";
            label_y2.Text = "y2 =";
            label_x3.Text = "x3 =";
            label_y3.Text = "y3 =";
            btn_chek.Text = "���������";
            Result_Label.Text = "";

            // �������� 5
            Resultlabel_1.Text = "";
            btnCalculate.Text = "����������";


            // �������� 6
            btnReplaceMaxWithZero.Text = "���������";

            //�������� 7
            removeButton.Text = "��������� ";
            label_input.Text = "������� �����";
            label_output.Text = "����� ��� �����";

        }

        private void BtnOk_Click_1(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(txtA.Text);
            double y = Convert.ToDouble(txtB.Text);
            double result = (1 + Math.Sin(Math.Sqrt(x + 1))) / Math.Cos(12 * y - 4);
            IblResult.Text = result.ToString();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                return;
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    // ��������� ������ <Enter>
                    BtnOk.Focus();
                }
                return;
            }
            // ���� ������� ���������
            e.Handled = true;

        }

        private void txtB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                return;
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    // ��������� ������ <Enter>
                    BtnOk.Focus();
                }
                return;
            }
            // ���� ������� ���������
            e.Handled = true;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
         // �������� 2
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // �������� ���������� ����� �� �����������
                double x1 = double.Parse(textBox1.Text);
                double y1 = double.Parse(textBox2.Text);
                double x2 = double.Parse(textBox3.Text);
                double y2 = double.Parse(textBox4.Text);

                // ���������� ������� �� ����� �������
                double distance = CalculateDistance(x1, y1, x2, y2);

                // �������� ���������
                label8.Text = $"³������ �� �������: {distance:F2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"�������: {ex.Message}", "�������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private double CalculateDistance(double x1, double y1, double x2, double y2)
        {
            // ������� ��� ���������� ������ �� ����� ������� � �������
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                return;
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    // ��������� ������ <Enter>
                    BtnOk.Focus();
                }
                return;
            }
            // ���� ������� ���������
            e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                return;
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    // ��������� ������ <Enter>
                    BtnOk.Focus();
                }
                return;
            }
            // ���� ������� ���������
            e.Handled = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                return;
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    // ��������� ������ <Enter>
                    BtnOk.Focus();
                }
                return;
            }
            // ���� ������� ���������
            e.Handled = true;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                return;
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    // ��������� ������ <Enter>
                    BtnOk.Focus();
                }
                return;
            }
            // ���� ������� ���������
            e.Handled = true;
        }
        //�������� 3
        private void buttonCheck_Click(object sender, EventArgs e)
        {
            // �������� �������� � ��������� ����
            int a, c, d;
            if (int.TryParse(txtboxA.Text, out a) && int.TryParse(txtboxC.Text, out c) && int.TryParse(txtboxD.Text, out d))
            {
                // ����������, �� � ����������� "����� c � d � �������� ��������� � ����� ����� a" ��������
                bool result = c == a * a && d == a * a * a;

                // �������� ���������
                MessageBox.Show(result.ToString());
            }
            else
            {
                // �������� ����������� ��� �������, ���� ������ �������� �� � �������
                MessageBox.Show("���� �����, ������ ������� ������ �������� ��� a, c �� d.");
            }
        }

        private void txtboxA_KeyUp(object sender, KeyEventArgs e)
        {

        }
                                                                     // �������� 4
        private void btn_chek_Click(object sender, EventArgs e)
        {
            // �������� ���������� ����� A, B � C � ��������� ����
            double x1 = Convert.ToDouble(x1textBox.Text);
            double y1 = Convert.ToDouble(y1textBox.Text);
            double x2 = Convert.ToDouble(x2textBox.Text);
            double y2 = Convert.ToDouble(y2textBox.Text);
            double x3 = Convert.ToDouble(x3textBox.Text);
            double y3 = Convert.ToDouble(y3textBox.Text);

            // ����������, �� ����� ���������� �� ���� �����
            if (ArePointsOnSameLine(x1, y1, x2, y2, x3, y3))
            {
                Result_Label.Text = "����� ���������� �� ���� �����";
            }
            else
            {
                // ���������� ����� ���������� ABC
                double area = CalculateTriangleArea(x1, y1, x2, y2, x3, y3);
                Result_Label.Text = $"����� ���������� ABC: {area}";
            }
            // ������� ��� ��������, �� ����� ���������� �� ���� �����
             bool ArePointsOnSameLine(double x1, double y1, double x2, double y2, double x3, double y3)
            {
                return (x2 - x1) * (y3 - y1) == (x3 - x1) * (y2 - y1);
            }

            // ������� ��� ���������� ����� ���������� �� ������������ ������
             double CalculateTriangleArea(double x1, double y1, double x2, double y2, double x3, double y3)
            {
                return Math.Abs((x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2)) / 2);
            }
        }

        private void x1textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                return;
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    // ��������� ������ <Enter>
                    BtnOk.Focus();
                }
                return;
            }
            // ���� ������� ���������
            e.Handled = true;
        }
        private void x2textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                return;
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    // ��������� ������ <Enter>
                    BtnOk.Focus();
                }
                return;
            }
            // ���� ������� ���������
            e.Handled = true;
        }
        private void x3textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                return;
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    // ��������� ������ <Enter>
                    BtnOk.Focus();
                }
                return;
            }
            // ���� ������� ���������
            e.Handled = true;
        }
        private void y1textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                return;
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    // ��������� ������ <Enter>
                    BtnOk.Focus();
                }
                return;
            }
            // ���� ������� ���������
            e.Handled = true;
        }
        private void y2textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                return;
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    // ��������� ������ <Enter>
                    BtnOk.Focus();
                }
                return;
            }
            // ���� ������� ���������
            e.Handled = true;
        }
        private void y3textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                return;
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    // ��������� ������ <Enter>
                    BtnOk.Focus();
                }
                return;
            }
            // ���� ������� ���������
            e.Handled = true;
        }








        /// �������� 5


        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }
           
        
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int petroHouseNumber = FindPetroHouseNumber();
            int schoolHouseNumber = FindSchoolHouseNumber(petroHouseNumber);

            MessageBox.Show($"����� ������� �����: {petroHouseNumber}\n����� ������� �����: {schoolHouseNumber}");
        }

        private int FindPetroHouseNumber()
        {
            int sum = 0;
            int houseNumber = 1;

            while (true)
            {
                sum += houseNumber;
                if (sum == 99)
                    break;

                houseNumber++;
            }

            return houseNumber;
        }

        private int FindSchoolHouseNumber(int petroHouseNumber)
        {
            int sum = 0;
            int houseNumber = petroHouseNumber + 1; // �������� � ���������� ������� ���� ������� �����

            while (true)
            {
                sum += houseNumber;
                if (sum == 117)
                    break;

                houseNumber++;
            }

            return houseNumber;
        }




        // �������� 6
        private void btnReplaceMaxWithZero_Click(object sender, EventArgs e)
        {
            // �������� ����� ����� � ���������� ����� �����������
            double[] numbers = txtNumbers.Text.Split(' ').Select(double.Parse).ToArray();

            // ������ ������������ ������� � �����
            double maxNumber = numbers.Max();

            // ������ ������ ������� ��������� ������������� ��������
            int indexOfMax = Array.IndexOf(numbers, maxNumber);

            // ������� ������ ������������ ������� �����
            if (indexOfMax != -1)
            {
                numbers[indexOfMax] = 0;

                // ������� ��������� ����� � ��������� ����
                txtResult.Text = string.Join(" ", numbers);
            }
            else
            {
                MessageBox.Show("����� ������� ��� ������� ������� ��� ���������� ������������� ��������.", "�������");
            }

        }
        // �������� 7
        
       
        private void removeButton_Click(object sender, EventArgs e)
        {
            string inputText = inputTextBox.Text;
            string result = RemoveTextInBrackets(inputText);
            outputTextBox.Text = result;
        }

        private string RemoveTextInBrackets(string input)
        {
            int startIndex = input.IndexOf('(');
            int endIndex = input.IndexOf(')');

            if (startIndex != -1 && endIndex != -1 && startIndex < endIndex)
            {
                // �������� ������� �� ������� (����� � �������)
                return input.Remove(startIndex, endIndex - startIndex + 1);
            }
            else
            {
                // ���� ����� ���� ��� ���� ������ � ������������� �������
                return "����� �� �������� ��� ������� � ������������� �������.";
            }
        }
    }
}


