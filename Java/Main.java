import javax.swing.*;
import java.awt.*;

public class Main extends JFrame {

    private final JTextField tfA1     = new JTextField(10);
    private final JTextField tfD      = new JTextField(10);
    private final JTextField tfN      = new JTextField(10);
    private final JLabel     lbResult = new JLabel("Результат:");
    private final JButton    btCalc   = new JButton("Вычислить");

    public Main() {
        setTitle("Лабораторная 1 — арифметическая прогрессия");
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

        // Панель ввода — сетка 3 строки × 2 столбца
        JPanel inputPanel = new JPanel(new GridLayout(3, 2, 8, 8));
        inputPanel.setBorder(BorderFactory.createEmptyBorder(15, 15, 10, 15));
        inputPanel.add(new JLabel("a1 (первый член):"));
        inputPanel.add(tfA1);
        inputPanel.add(new JLabel("d (разность):"));
        inputPanel.add(tfD);
        inputPanel.add(new JLabel("n (кол-во членов):"));
        inputPanel.add(tfN);

        // Панель кнопки
        JPanel buttonPanel = new JPanel(new FlowLayout(FlowLayout.LEFT));
        buttonPanel.setBorder(BorderFactory.createEmptyBorder(0, 15, 10, 15));
        buttonPanel.add(btCalc);

        // Панель результата
        JPanel resultPanel = new JPanel(new BorderLayout());
        resultPanel.setBorder(BorderFactory.createEmptyBorder(5, 15, 15, 15));
        resultPanel.add(lbResult, BorderLayout.CENTER);

        // Собираем окно
        setLayout(new BorderLayout());
        add(inputPanel,  BorderLayout.NORTH);
        add(buttonPanel, BorderLayout.CENTER);
        add(resultPanel, BorderLayout.SOUTH);

        // Обработчик кнопки
        btCalc.addActionListener(e -> calculate());

        // Финальная настройка
        pack();
        setLocationRelativeTo(null);
        setVisible(true);
    }

    private void calculate() {
        try {
            double a1 = Double.parseDouble(tfA1.getText().trim().replace(',', '.'));
            double d  = Double.parseDouble(tfD.getText().trim().replace(',', '.'));
            int    n  = Integer.parseInt(tfN.getText().trim());

            if (n <= 0) {
                lbResult.setText("n должно быть > 0");
                return;
            }

            double an = a1 + (n - 1) * d;                 // n-й член
            double sn = n * (2 * a1 + (n - 1) * d) / 2.0; // сумма n членов

            lbResult.setText(String.format(
                    "n-й член: a_n = %.4f    Сумма n членов: S_n = %.4f",
                    an, sn));
        } catch (NumberFormatException ex) {
            lbResult.setText("Ошибка ввода! Проверьте числа.");
        }
    }

    public static void main(String[] args) {
        SwingUtilities.invokeLater(Main::new);
    }
}