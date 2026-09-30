using System;
using System.Linq;
using System.Windows.Forms;

namespace lab2
{
    public partial class FormTask1_1 : Form
    {
        public FormTask1_1()
        {
            InitializeComponent();
            
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            // Проверка на пустые поля / нечисловой ввод
            if (!TryGetDouble(tbX, "X", out double x)) return;
            if (!TryGetDouble(tbY, "Y", out double y)) return;
            if (!TryGetDouble(tbZ, "Z", out double z)) return;

            if (y + x * x == 0)
            {
                MessageBox.Show("Деление на ноль! Выражение (y + x^2) равно 0", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double znam = y * y + Math.Abs((x * x) / (y + x * x));
            if (znam == 0)
            {
                MessageBox.Show("Общий знаменатель равен 0", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double a = y + (x / znam);
            double b = Math.Pow(1 + Math.Pow(Math.Tan(z / 2.0), 2), 2);

            lblResult.Text = $"Результат: a = {a:F2}; b = {b:F2}";
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

        private void btnNext_Click(object sender, EventArgs e)
        {
            Hide();
            new FormTask1_2().ShowDialog();
            Close();
        }
    }
}
