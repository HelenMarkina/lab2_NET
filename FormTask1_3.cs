using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class FormTask1_3 : Form
    {
        public FormTask1_3()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (!TryGetDouble(tbA, "a", out double a)) return;
            if (!TryGetDouble(tbB, "b", out double b)) return;
            if (!TryGetDouble(tbC, "c", out double c)) return;

            // Если a = 0 уравнение не квадратное, а линейное.
            if (a == 0)
            {
                if (b == 0)
                {
                    // 0·x + c = 0
                    lblResult.Text = (c == 0) ? "Не квадратное уравнение. Решений бесконечно много."
                        : "Не квадратное уравнение. Решений нет.";
                }
                else
                {
                    double x = -c / b;
                    lblResult.Text = $"Не квадратное уравнение (a = 0). Линейное: x = {x:F2}";
                }
                return;
            }

            // Дискриминант D=b^2-4ac
            double D = b * b - 4 * a * c;

            if (D > 0)
            {
                double x1 = (-b + Math.Sqrt(D)) / (2 * a);
                double x2 = (-b - Math.Sqrt(D)) / (2 * a);
                lblResult.Text = $"D = {D:F2} > 0, два корня: x1 = {x1:F2}; x2 = {x2:F2}";
            }
            else if (D == 0)
            {
                double x = -b / (2 * a);
                lblResult.Text = $"D = 0, один корень: x = {x:F2}";
            }
            else
            {
                lblResult.Text = $"Действительных корней нет (D = {D:F2} < 0)";
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Hide();
            new FormTask1_4().ShowDialog();
            Close();
        }

        // Фильтр ввода. Пропускает только цифры, один минус в начале и один десятичный разделитель (запятую или точку — по локали)
        private void NumericOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            char sep = Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);

            // Управляющие клавиши
            if (char.IsControl(e.KeyChar)) return;

            // Цифры
            if (char.IsDigit(e.KeyChar)) return;

            // Минус только первым и только один
            if (e.KeyChar == '-' && tb.SelectionStart == 0 && !tb.Text.Contains('-')) return;

            // Разделитель только один
            if (e.KeyChar == sep && !tb.Text.Contains(sep)) return;

            // Всё остальное блокируем
            e.Handled = true;
        }

        // Чтение числа из TextBox. Проверяет пустоту и формат. Возвращает false при любой ошибке и подсказывает пользователю что не так
        private bool TryGetDouble(TextBox tb, string name, out double value)
        {
            value = 0;

            if (string.IsNullOrWhiteSpace(tb.Text))
            {
                MessageBox.Show($"Поле {name} пустое!", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb.Focus();
                return false;
            }

            if (!double.TryParse(tb.Text, out value))
            {
                MessageBox.Show($"Поле {name}: введите корректное число!", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb.Focus();
                tb.SelectAll();
                return false;
            }

            return true;
        }

        // Переключение фокуса между полями стрелками ↑/↓
        private void AnyTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (e.KeyCode == Keys.Down)
            {
                SelectNextControl(tb, true, true, true, true);
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Up)
            {
                SelectNextControl(tb, false, true, true, true);
                e.SuppressKeyPress = true;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            new FormTask1_2().ShowDialog();
            Close();
        }
    }
}
