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
            //завдання 1
            label1.Text = "x =";
            label2.Text = "y =";
            label4.Text = "Результат";
            BtnOk.Text = "Порахувати";
            IblResult.Text = "";

            //завдання 2
            X1.Text = "x1 =";
            Y1.Text = "y1 =";
            X2.Text = "x2 =";
            Y2.Text = "y2 =";
            label8.Text = "Результа";
            button1.Text = "Визначити";

            //завдання 3
            A.Text = "a = ";
            C.Text = "c = ";
            D.Text = "d = ";
            buttonCheck.Text = "Перевірити";

            //завдання 4
            label_x1.Text = "x1 =";
            label_y1.Text = "y1 =";
            label_x2.Text = "x2 =";
            label_y2.Text = "y2 =";
            label_x3.Text = "x3 =";
            label_y3.Text = "y3 =";
            btn_chek.Text = "Визначити";
            Result_Label.Text = "";

            // Завдання 5
            Resultlabel_1.Text = "";
            btnCalculate.Text = "порахувати";


            // Завдання 6
            btnReplaceMaxWithZero.Text = "Визначити";

            //завдання 7
            removeButton.Text = "Визначити ";
            label_input.Text = "Вписати рядок";
            label_output.Text = "Рядок без дужок";

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
                    // натиснута клавіша <Enter>
                    BtnOk.Focus();
                }
                return;
            }
            // інші символи заборонені
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
                    // натиснута клавіша <Enter>
                    BtnOk.Focus();
                }
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
         // Завдання 2
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Отримуємо координати точок від користувача
                double x1 = double.Parse(textBox1.Text);
                double y1 = double.Parse(textBox2.Text);
                double x2 = double.Parse(textBox3.Text);
                double y2 = double.Parse(textBox4.Text);

                // Обчислюємо відстань між двома точками
                double distance = CalculateDistance(x1, y1, x2, y2);

                // Виводимо результат
                label8.Text = $"Відстань між точками: {distance:F2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private double CalculateDistance(double x1, double y1, double x2, double y2)
        {
            // Формула для обчислення відстані між двома точками у просторі
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
                    // натиснута клавіша <Enter>
                    BtnOk.Focus();
                }
                return;
            }
            // інші символи заборонені
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
                    // натиснута клавіша <Enter>
                    BtnOk.Focus();
                }
                return;
            }
            // інші символи заборонені
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
                    // натиснута клавіша <Enter>
                    BtnOk.Focus();
                }
                return;
            }
            // інші символи заборонені
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
                    // натиснута клавіша <Enter>
                    BtnOk.Focus();
                }
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }
        //Завдання 3
        private void buttonCheck_Click(object sender, EventArgs e)
        {
            // Отримуємо значення з текстових полів
            int a, c, d;
            if (int.TryParse(txtboxA.Text, out a) && int.TryParse(txtboxC.Text, out c) && int.TryParse(txtboxD.Text, out d))
            {
                // Перевіряємо, чи є висловлення "Числа c і d є відповідно квадратом і кубом числа a" істинним
                bool result = c == a * a && d == a * a * a;

                // Виводимо результат
                MessageBox.Show(result.ToString());
            }
            else
            {
                // Виводимо повідомлення про помилку, якщо введені значення не є числами
                MessageBox.Show("Будь ласка, введіть коректні числові значення для a, c та d.");
            }
        }

        private void txtboxA_KeyUp(object sender, KeyEventArgs e)
        {

        }
                                                                     // Завдання 4
        private void btn_chek_Click(object sender, EventArgs e)
        {
            // Отримуємо координати точок A, B і C з текстових полів
            double x1 = Convert.ToDouble(x1textBox.Text);
            double y1 = Convert.ToDouble(y1textBox.Text);
            double x2 = Convert.ToDouble(x2textBox.Text);
            double y2 = Convert.ToDouble(y2textBox.Text);
            double x3 = Convert.ToDouble(x3textBox.Text);
            double y3 = Convert.ToDouble(y3textBox.Text);

            // Перевіряємо, чи точки розташовані на одній прямій
            if (ArePointsOnSameLine(x1, y1, x2, y2, x3, y3))
            {
                Result_Label.Text = "Точки розташовані на одній прямій";
            }
            else
            {
                // Обчислюємо площу трикутника ABC
                double area = CalculateTriangleArea(x1, y1, x2, y2, x3, y3);
                Result_Label.Text = $"Площа трикутника ABC: {area}";
            }
            // Функція для перевірки, чи точки розташовані на одній прямій
             bool ArePointsOnSameLine(double x1, double y1, double x2, double y2, double x3, double y3)
            {
                return (x2 - x1) * (y3 - y1) == (x3 - x1) * (y2 - y1);
            }

            // Функція для обчислення площі трикутника за координатами вершин
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
                    // натиснута клавіша <Enter>
                    BtnOk.Focus();
                }
                return;
            }
            // інші символи заборонені
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
                    // натиснута клавіша <Enter>
                    BtnOk.Focus();
                }
                return;
            }
            // інші символи заборонені
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
                    // натиснута клавіша <Enter>
                    BtnOk.Focus();
                }
                return;
            }
            // інші символи заборонені
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
                    // натиснута клавіша <Enter>
                    BtnOk.Focus();
                }
                return;
            }
            // інші символи заборонені
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
                    // натиснута клавіша <Enter>
                    BtnOk.Focus();
                }
                return;
            }
            // інші символи заборонені
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
                    // натиснута клавіша <Enter>
                    BtnOk.Focus();
                }
                return;
            }
            // інші символи заборонені
            e.Handled = true;
        }








        /// Завдання 5


        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }
           
        
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int petroHouseNumber = FindPetroHouseNumber();
            int schoolHouseNumber = FindSchoolHouseNumber(petroHouseNumber);

            MessageBox.Show($"Номер будинку Петра: {petroHouseNumber}\nНомер будинку школи: {schoolHouseNumber}");
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
            int houseNumber = petroHouseNumber + 1; // Починаємо з наступного будинку після будинку Петра

            while (true)
            {
                sum += houseNumber;
                if (sum == 117)
                    break;

                houseNumber++;
            }

            return houseNumber;
        }




        // ЗАвдання 6
        private void btnReplaceMaxWithZero_Click(object sender, EventArgs e)
        {
            // Отримати масив чисел з текстового вводу користувача
            double[] numbers = txtNumbers.Text.Split(' ').Select(double.Parse).ToArray();

            // Знайти максимальний елемент у масиві
            double maxNumber = numbers.Max();

            // Знайти індекс першого входження максимального елемента
            int indexOfMax = Array.IndexOf(numbers, maxNumber);

            // Замінити перший максимальний елемент нулем
            if (indexOfMax != -1)
            {
                numbers[indexOfMax] = 0;

                // Вивести оновлений масив у текстовий вивід
                txtResult.Text = string.Join(" ", numbers);
            }
            else
            {
                MessageBox.Show("Масив порожній або виникла помилка при знаходженні максимального елемента.", "Помилка");
            }

        }
        // Завдання 7
        
       
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
                // Вилучаємо частину між дужками (разом з дужками)
                return input.Remove(startIndex, endIndex - startIndex + 1);
            }
            else
            {
                // Якщо дужок немає або вони вказані у неправильному порядку
                return "Дужок не знайдено або вказано у неправильному порядку.";
            }
        }
    }
}


