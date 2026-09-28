import javax.swing.*;
import java.awt.*;
import java.awt.event.FocusAdapter;
import java.awt.event.FocusEvent;

public class ArithmeticProgressionTask2 extends JFrame {

    private final JTextField tfA1 = new JTextField(12);
    private final JTextField tfD  = new JTextField(12);
    private final JTextField tfN  = new JTextField(12);

    private final JLabel lblAn = new JLabel("n-й член:");
    private final JLabel lblSn = new JLabel("Сумма n членов:");

    public ArithmeticProgressionTask2() {
        super("Арифметическая прогрессия (Задание 2)");
        setDefaultCloseOperation(EXIT_ON_CLOSE);
        setLayout(new GridBagLayout());
        GridBagConstraints c = new GridBagConstraints();
        c.insets = new Insets(4, 6, 4, 6);
        c.anchor = GridBagConstraints.WEST;

        addRow(c, 0, "Введите a1:", tfA1);
        addRow(c, 1, "Введите d:",  tfD);
        addRow(c, 2, "Введите n:",  tfN);

        c.gridx = 0; c.gridy = 3; c.gridwidth = 2;
        add(lblAn, c);
        c.gridy = 4;
        add(lblSn, c);

        JButton btnExit = new JButton("Выход");
        btnExit.addActionListener(e -> System.exit(0));
        c.gridx = 0; c.gridy = 5; c.gridwidth = 2;
        c.anchor = GridBagConstraints.CENTER;
        add(btnExit, c);

        tfA1.addFocusListener(new FocusAdapter() {
            @Override public void focusLost(FocusEvent e) { onA1EditingFinished(); }
        });
        tfD.addFocusListener(new FocusAdapter() {
            @Override public void focusLost(FocusEvent e) { onDEditingFinished(); }
        });
        tfN.addFocusListener(new FocusAdapter() {
            @Override public void focusLost(FocusEvent e) { onNEditingFinished(); }
        });

        pack();
        setLocationRelativeTo(null);
    }

    private void addRow(GridBagConstraints c, int row, String label, JTextField field) {
        c.gridx = 0; c.gridy = row; c.gridwidth = 1;
        c.anchor = GridBagConstraints.WEST;
        add(new JLabel(label), c);
        c.gridx = 1;
        add(field, c);
    }

    private void onA1EditingFinished() {
        if (tryParseDouble(tfA1.getText()) == null) {
            JOptionPane.showMessageDialog(this,
                    "a1 должно быть числом.", "Ошибка ввода",
                    JOptionPane.WARNING_MESSAGE);
            tfA1.requestFocusInWindow();
            return;
        }
        tryCalculate();
    }

    private void onDEditingFinished() {
        if (tryParseDouble(tfD.getText()) == null) {
            JOptionPane.showMessageDialog(this,
                    "d должно быть числом.", "Ошибка ввода",
                    JOptionPane.WARNING_MESSAGE);
            tfD.requestFocusInWindow();
            return;
        }
        tryCalculate();
    }

    private void onNEditingFinished() {
        Integer n = tryParseInt(tfN.getText());
        if (n == null || n <= 0) {
            JOptionPane.showMessageDialog(this,
                    "Количество членов n должно быть положительным целым числом.",
                    "Ошибка ввода", JOptionPane.WARNING_MESSAGE);
            tfN.requestFocusInWindow();
            return;
        }
        tryCalculate();
    }

    private void tryCalculate() {
        Double a1 = tryParseDouble(tfA1.getText());
        Double d  = tryParseDouble(tfD.getText());
        Integer n = tryParseInt(tfN.getText());
        if (a1 == null || d == null || n == null || n <= 0) return;

        double an = a1 + (n - 1) * d;
        double sn = n * (2 * a1 + (n - 1) * d) / 2.0;

        lblAn.setText(String.format("n-й член: %.4f", an));
        lblSn.setText(String.format("Сумма n членов: %.4f", sn));
    }

    private static Double tryParseDouble(String s) {
        try { return Double.parseDouble(s.trim()); } catch (Exception e) { return null; }
    }
    private static Integer tryParseInt(String s) {
        try { return Integer.parseInt(s.trim()); } catch (Exception e) { return null; }
    }
}