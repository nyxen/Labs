#include "mainwindow.h"
#include "ui_mainwindow.h"
#include <QMessageBox>
#include <QApplication>

MainWindow::MainWindow(QWidget *parent) :
QMainWindow(parent),
ui(new Ui::MainWindow)
{
ui->setupUi(this);

// Проверка ввода при выходе из поля
connect(ui->LeA1, &QLineEdit::editingFinished, this, &MainWindow::onA1EditingFinished);
connect(ui->LeD,  &QLineEdit::editingFinished, this, &MainWindow::onDEditingFinished);
connect(ui->LeN,  &QLineEdit::editingFinished, this, &MainWindow::onNEditingFinished);

ui->pushButton->setText("Выход");
connect(ui->pushButton, &QPushButton::clicked, qApp, &QApplication::quit);
}

MainWindow::~MainWindow()
{
delete ui;
}

void MainWindow::onA1EditingFinished()
{
    bool ok = false;
    ui->LeA1->text().toDouble(&ok);
    if (!ok) {
        QMessageBox::warning(this, "Ошибка ввода", "a1 должно быть числом.");
        ui->LeA1->setFocus();
        return;
    }
    tryCalculate();
}

void MainWindow::onDEditingFinished()
{
    bool ok = false;
    ui->LeD->text().toDouble(&ok);
    if (!ok) {
        QMessageBox::warning(this, "Ошибка ввода", "d должно быть числом.");
        ui->LeD->setFocus();
        return;
    }
    tryCalculate();
}

void MainWindow::onNEditingFinished()
{
    bool ok = false;
    int n = ui->LeN->text().toInt(&ok);
    if (!ok || n <= 0) {
        QMessageBox::warning(this, "Ошибка ввода",
                              "Количество членов n должно быть положительным целым числом.");
        ui->LeN->setFocus();
        return;
    }
    tryCalculate();
}

void MainWindow::tryCalculate()
{
    bool ok1, ok2, ok3;
    double a1 = ui->LeA1->text().toDouble(&ok1);
    double d = ui->LeD->text().toDouble(&ok2);
    int n = ui->LeN->text().toInt(&ok3);

    if (!ok1 || !ok2 || !ok3 || n <= 0)
        return;

    double an = a1 +(n - 1) * d;
    double sn = n * (2 * a1 + (n - 1) * d) / 2.0;

    ui->lblAn->setText(QString("n-й член: %1").arg(an, 0, 'f', 4));
    ui->lblSn->setText(QString("Сумма n членов: %1").arg(sn, 0, 'f', 4));
}