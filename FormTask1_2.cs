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
    public partial class FormTask1_2 : Form
    {
        public FormTask1_2()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (!TryGetDouble(tbH, "H", out double H)) return;
            if (!TryGetDouble(tbV, "V", out double V)) return;

            // Высота не может быть отрицательной.
            if (H < 0)
            {
                MessageBox.Show("Высота H не может быть отрицательной!", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbH.Focus();
                tbH.SelectAll();
                return;
            }

            // Начальная скорость направлена вниз (положительная).
            // Если пользователь ввёл отрицательную — считаем по модулю.
            if (V < 0)
            {
                MessageBox.Show("Начальная скорость V не может быть отрицательной!", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbV.Focus();
                tbV.SelectAll();
                return;
            }

            const double g = 9.8;

            // Уравнение движения: H = V*t + g*t^2/2.
            // Приводим к квадратному относительно t и берём положительный корень:
            // t = (-V + sqrt(V^2 + 2*g*H)) / g
            double t = (-V + Math.Sqrt(V * V + 2 * g * H)) / g;

            lblResult.Text = $"Время падения: t = {t:F2} с";
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Hide();
            new FormTask1_3().ShowDialog();
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
            new FormTask1_1().ShowDialog();
            Close();
        }
    }
}
