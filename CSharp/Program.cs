using System;
using System.Drawing;
using System.Windows.Forms;

static class Program
{
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        var form = new Form
        {
            Text = "Лабораторная 1 — арифметическая прогрессия",
            ClientSize = new Size(500, 320),
            StartPosition = FormStartPosition.CenterScreen,
            FormBorderStyle = FormBorderStyle.FixedSingle,
            MaximizeBox = false
        };

        var tfA1 = new TextBox { Left = 200, Top = 60, Width = 200 };
        var tfD = new TextBox { Left = 200, Top = 95, Width = 200 };
        var tfN = new TextBox { Left = 200, Top = 130, Width = 200 };
        var lbResult = new Label
        {
            Left = 20,
            Top = 220,
            Width = 460,
            Height = 60,
            Font = new Font("Consolas", 11, FontStyle.Bold)
        };

        form.Controls.Add(new Label
        {
            Left = 20,
            Top = 20,
            Width = 460,
            Text = "Введите a1, d и n:",
            Font = new Font("Segoe UI", 12, FontStyle.Bold)
        });
        form.Controls.Add(new Label { Left = 20, Top = 62, Width = 170, Text = "a1 (первый член):" });
        form.Controls.Add(tfA1);
        form.Controls.Add(new Label { Left = 20, Top = 97, Width = 170, Text = "d (разность):" });
        form.Controls.Add(tfD);
        form.Controls.Add(new Label { Left = 20, Top = 132, Width = 170, Text = "n (кол-во членов):" });
        form.Controls.Add(tfN);

        var btCalc = new Button
        {
            Left = 20,
            Top = 170,
            Width = 160,
            Height = 32,
            Text = "Вычислить",
            Font = new Font("Segoe UI", 10, FontStyle.Bold)
        };
        form.Controls.Add(btCalc);
        form.Controls.Add(lbResult);

        btCalc.Click += (s, e) =>
        {
            try
            {
                double a1 = double.Parse(tfA1.Text.Trim().Replace('.', ','));
                double d = double.Parse(tfD.Text.Trim().Replace('.', ','));
                int n = int.Parse(tfN.Text.Trim());

                if (n <= 0)
                {
                    lbResult.ForeColor = Color.Red;
                    lbResult.Text = "n должно быть > 0";
                    return;
                }

                double an = a1 + (n - 1) * d;
                double sn = n * (2 * a1 + (n - 1) * d) / 2.0;

                lbResult.ForeColor = Color.DarkBlue;
                lbResult.Text = string.Format(
                    "n-й член: a_n = {0:F4}\r\nСумма n членов: S_n = {1:F4}",
                    an, sn);
            }
            catch (FormatException)
            {
                lbResult.ForeColor = Color.Red;
                lbResult.Text = "Ошибка ввода! Проверьте числа.";
            }
        };

        Application.Run(form);
    }
}