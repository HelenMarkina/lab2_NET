using System;
using System.Linq;
using System.Windows.Forms;

namespace lab2
{
    public partial class FormTask1_4 : Form
    {
        public FormTask1_4()
        {
            InitializeComponent();

            cbFigure.SelectedIndex = 0;

            // Навешиваем фильтр на все текстовые поля
            foreach (TextBox tb in new[]
            {
                tbRectA, tbRectB,
                tbTriA, tbTriH,
                tbTrA, tbTrB, tbTrB,
                tbCircR,
                tbSectR, tbSectAngle
            })
            {
                tb.KeyPress += NumericOnly_KeyPress;
                tb.KeyDown += AnyTextBox_KeyDown;
            }

            ShowPanelForFigure(0);
        }

        // Обработчик смены фигуры: показываем нужную панель, остальные прячем.
        private void cbFigure_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowPanelForFigure(cbFigure.SelectedIndex);
        }

        private void ShowPanelForFigure(int index)
        {
            // Скрываем все панели
            pnlRect.Visible = false;
            pnlTriangle.Visible = false;
            pnlTrapezoid.Visible = false;
            pnlCircle.Visible = false;
            pnlSector.Visible = false;

            lblResult.Text = "";

            // Показываем выбранную
            switch (index)
            {
                case 0: pnlRect.Visible = true; break;
                case 1: pnlTriangle.Visible = true; break;
                case 2: pnlTrapezoid.Visible = true; break;
                case 3: pnlCircle.Visible = true; break;
                case 4: pnlSector.Visible = true; break;
            }
        }

        // Кнопка "Вычислить": считаем площадь по выбранной фигуре.
        private void btnCalc_Click(object sender, EventArgs e)
        {
            int n = cbFigure.SelectedIndex + 1;   // 1..5
            double S;

            switch (n)
            {
                case 1: // прямоугольник: a * b
                    if (!TryGetDouble(tbRectA, "a", out double rA)) return;
                    if (!TryGetDouble(tbRectB, "b", out double rB)) return;
                    if (rA <= 0 || rB <= 0)
                    {
                        MessageBox.Show("Стороны должны быть положительными!", "Ошибка",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    S = rA * rB;
                    break;

                case 2: // треугольник: a * h / 2
                    if (!TryGetDouble(tbTriA, "a", out double tA)) return;
                    if (!TryGetDouble(tbTriH, "h", out double tH)) return;
                    if (tA <= 0 || tH <= 0)
                    {
                        MessageBox.Show("Основание и высота должны быть положительными!", "Ошибка",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    S = tA * tH / 2.0;
                    break;

                case 3: // трапеция: (a + b) * h / 2
                    if (!TryGetDouble(tbTrA, "a", out double zA)) return;
                    if (!TryGetDouble(tbTrB, "b", out double zB)) return;
                    if (!TryGetDouble(tbTrB, "h", out double zH)) return;
                    if (zA <= 0 || zB <= 0 || zH <= 0)
                    {
                        MessageBox.Show("Размеры трапеции должны быть положительными!", "Ошибка",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    S = (zA + zB) * zH / 2.0;
                    break;

                case 4: // круг: π·R²
                    if (!TryGetDouble(tbCircR, "R", out double cR)) return;
                    if (cR <= 0)
                    {
                        MessageBox.Show("Радиус должен быть положительным!", "Ошибка",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    S = Math.PI * cR * cR;
                    break;

                case 5: // сектор: π·R²·α/360
                    if (!TryGetDouble(tbSectR, "R", out double sR)) return;
                    if (!TryGetDouble(tbSectAngle, "α", out double alpha)) return;
                    if (sR <= 0)
                    {
                        MessageBox.Show("Радиус должен быть положительным!", "Ошибка",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (alpha <= 0 || alpha > 360)
                    {
                        MessageBox.Show("Угол должен быть в пределах от 0 до 360 градусов!", "Ошибка",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    S = Math.PI * sR * sR * alpha / 360.0;
                    break;

                default:
                    MessageBox.Show("Выберите фигуру!", "Ошибка",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
            }

            lblResult.Text = $"Площадь S = {S:F2}";
        }



        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
            new FormTask1_3().ShowDialog();
            Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Hide();
            new FormTask2().ShowDialog();
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
    }
}
