using System;
using System.Globalization;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Проверка при выходе из поля (аналог editingFinished в Qt)
            txtA1.Leave += (s, e) => OnA1EditingFinished();
            txtD.Leave += (s, e) => OnDEditingFinished();
            txtN.Leave += (s, e) => OnNEditingFinished();

            // Кнопка «Выход» — завершение приложения
            btnExit.Click += (s, e) => Application.Exit();
        }

        private void OnA1EditingFinished()
        {
            if (!double.TryParse(txtA1.Text.Replace(',', '.'), NumberStyles.Float,
                                 CultureInfo.InvariantCulture, out _))
            {
                MessageBox.Show(this, "a1 должно быть числом.", "Ошибка ввода",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtA1.Focus();
                return;
            }
            TryCalculate();
        }

        private void OnDEditingFinished()
        {
            if (!double.TryParse(txtD.Text.Replace(',', '.'), NumberStyles.Float,
                                 CultureInfo.InvariantCulture, out _))
            {
                MessageBox.Show(this, "d должно быть числом.", "Ошибка ввода",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtD.Focus();
                return;
            }
            TryCalculate();
        }

        private void OnNEditingFinished()
        {
            if (!int.TryParse(txtN.Text, out int n) || n <= 0)
            {
                MessageBox.Show(this,
                    "Количество членов n должно быть положительным целым числом.",
                    "Ошибка ввода",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtN.Focus();
                return;
            }
            TryCalculate();
        }

        private void TryCalculate()
        {
            if (!double.TryParse(txtA1.Text.Replace(',', '.'), NumberStyles.Float,
                                 CultureInfo.InvariantCulture, out double a1)) return;
            if (!double.TryParse(txtD.Text.Replace(',', '.'), NumberStyles.Float,
                                 CultureInfo.InvariantCulture, out double d)) return;
            if (!int.TryParse(txtN.Text, out int n) || n <= 0) return;

            double an = a1 + (n - 1) * d;
            double sn = n * (2 * a1 + (n - 1) * d) / 2.0;

            lblAn.Text = $"n-й член: {an:F4}";
            lblSn.Text = $"Сумма n членов: {sn:F4}";
        }
    }
}