using System;
using System.Linq;
using System.Windows.Forms;

namespace lab2
{
    // Структура "Мотоцикл" предметная область варианта 4
    struct Motorcycle
    {
        public string Brand;   // марка
        public string Model;   // модель
        public int Year;    // год выпуска
        public double Price;   // цена, руб.

        // Метод отображения данных структуры 
        public string[] ToLines()
        {
            return new[]
            {
                $"Марка: {Brand}",
                $"Модель: {Model}",
                $"Год выпуска: {Year}",
                $"Цена: {Price:F2} руб."
            };
        }
    }

    public partial class FormTask2 : Form
    {
        public FormTask2()
        {
            InitializeComponent();

            foreach (TextBox tb in new[] { tbBrand, tbModel, tbYear, tbPrice })
                tb.KeyDown += AnyTextBox_KeyDown;

            tbYear.KeyPress += NumericOnly_KeyPress;
            tbPrice.KeyPress += NumericOnly_KeyPress;
        }

        // Кнопка "Показать данные": читает поля, создаёт структуру,
        // вызывает её метод отображения и выводит результат.
        private void btnShow_Click(object sender, EventArgs e)
        {
            if (!TryGetString(tbBrand, "Марка")) return;
            if (!TryGetString(tbModel, "Модель")) return;
            if (!TryGetInt(tbYear, "Год выпуска", out int year)) return;
            if (!TryGetDouble(tbPrice, "Цена", out double price)) return;

            // Проверки на разумные значения
            if (year < 1885 || year > DateTime.Now.Year)
            {
                MessageBox.Show($"Год должен быть от 1885 до {DateTime.Now.Year}!",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbYear.Focus();
                return;
            }
            if (price < 0)
            {
                MessageBox.Show("Цена не может быть отрицательной!",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbPrice.Focus();
                return;
            }

            Motorcycle m = new Motorcycle
            {
                Brand = tbBrand.Text.Trim(),
                Model = tbModel.Text.Trim(),
                Year = year,
                Price = price
            };

            lstResult.Items.Clear();
            foreach (string line in m.ToLines())
                lstResult.Items.Add(line);
        }

        // Чтение непустой строки
        private bool TryGetString(TextBox tb, string name)
        {
            if (string.IsNullOrWhiteSpace(tb.Text))
            {
                MessageBox.Show($"Поле «{name}» пустое!", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb.Focus();
                return false;
            }
            return true;
        }

        // Чтение целого числа
        private bool TryGetInt(TextBox tb, string name, out int value)
        {
            value = 0;

            if (string.IsNullOrWhiteSpace(tb.Text))
            {
                MessageBox.Show($"Поле «{name}» пустое!", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb.Focus();
                return false;
            }

            if (!int.TryParse(tb.Text, out value))
            {
                MessageBox.Show($"Поле «{name}»: введите целое число!", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb.Focus();
                tb.SelectAll();
                return false;
            }
            return true;
        }

        // Чтение вещественного числа
        private bool TryGetDouble(TextBox tb, string name, out double value)
        {
            value = 0;

            if (string.IsNullOrWhiteSpace(tb.Text))
            {
                MessageBox.Show($"Поле «{name}» пустое!", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb.Focus();
                return false;
            }

            if (!double.TryParse(tb.Text, out value))
            {
                MessageBox.Show($"Поле «{name}»: введите корректное число!", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb.Focus();
                tb.SelectAll();
                return false;
            }
            return true;
        }

        // Фильтр ввода: только цифры, один минус в начале и один разделитель
        private void NumericOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            char sep = Convert.ToChar(System.Globalization.CultureInfo
                .CurrentCulture.NumberFormat.NumberDecimalSeparator);

            if (char.IsControl(e.KeyChar)) return;
            if (char.IsDigit(e.KeyChar)) return;
            if (e.KeyChar == '-' && tb.SelectionStart == 0 && !tb.Text.Contains('-')) return;
            if (e.KeyChar == sep && !tb.Text.Contains(sep)) return;

            e.Handled = true;
        }

        // Стрелки ↑/↓ — переключение между полями
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
            new FormTask1_4().ShowDialog();
            Close();
        }
    }
}