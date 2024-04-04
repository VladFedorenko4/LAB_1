using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Число:";
            label2.Text = "Ступінь:";
            label3.Text = "Основа системи числення:";
            label4.Text = "Результат:";
            btnCalculate.Text = "Обчислити";
            numBase.Minimum = 2;
            numBase.Maximum = 9;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Отримуємо значення з полів введення
                string numberStr = txtNumber.Text;
                int exponent = (int)numExponent.Value;
                int baseValue = (int)numBase.Value;

                // Перевіряємо правильність введення
                if (string.IsNullOrWhiteSpace(numberStr))
                    throw new ArgumentException("Рядок числа не може бути порожнім або містити тільки пробіли.", nameof(numberStr));

                // Обчислюємо результат
                CustomNumber result = new CustomNumber(numberStr, baseValue).Power(exponent);

                // Виводимо результат на екран
                lblResult.Text = $"Результат: {result.ToString()} (десяткова: {result.ToDecimal()})";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public class CustomNumber
        {
            private List<int> digits;
            private int baseValue;

            public CustomNumber(string numberStr, int baseValue)
            {
                if (!IsValidNumberString(numberStr, baseValue))
                    throw new ArgumentException($"Рядок числа '{numberStr}' містить недопустимі символи для системи числення з основою {baseValue}.", nameof(numberStr));

                this.baseValue = baseValue;
                digits = numberStr.Select(c => int.Parse(c.ToString())).ToList();
            }

            private bool IsValidNumberString(string numberStr, int baseValue)
            {
                return !string.IsNullOrWhiteSpace(numberStr) &&
                       numberStr.All(c => char.IsDigit(c) && char.GetNumericValue(c) < baseValue);
            }

            public CustomNumber Power(int exponent)
            {
                CustomNumber result = new CustomNumber("1", baseValue);
                for (int i = 0; i < exponent; i++)
                {
                    result = Multiply(result);
                }
                return result;
            }

            private CustomNumber Multiply(CustomNumber other)
            {
                int carry = 0;
                int maxLength = Math.Max(digits.Count, other.digits.Count);
                List<int> result = new List<int>(maxLength + 1);

                for (int i = 0; i < maxLength + 1; i++)
                {
                    result.Add(0);
                }

                for (int i = 0; i < maxLength || carry > 0; i++)
                {
                    int sum = carry;
                    if (i < digits.Count)
                        sum += digits[digits.Count - 1 - i];
                    if (i < other.digits.Count)
                        sum *= other.digits[other.digits.Count - 1 - i];

                    carry = sum / baseValue;
                    sum %= baseValue;
                    result[maxLength - i] = sum;
                }

                return new CustomNumber(string.Join("", result), baseValue);
            }

            public override string ToString()
            {
                return string.Join("", digits);
            }

            public int ToDecimal()
            {
                int result = 0;
                for (int i = 0; i < digits.Count; i++)
                {
                    result += digits[i] * (int)Math.Pow(baseValue, digits.Count - 1 - i);
                }
                return result;
            }

        }

    }
}