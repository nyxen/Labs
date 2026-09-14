#include "mainwindow.h"
#include "ui_mainwindow.h"
#include <QMessageBox>
MainWindow::MainWindow(QWidget *parent) :
QMainWindow(parent),
ui(new Ui::MainWindow)
{
ui->setupUi(this);
}
MainWindow::~MainWindow()
{
delete ui;
}
void MainWindow::Calculate()
{
    bool ok1, ok2, ok3;
    double a1 = ui->LeA1->text().toDouble(&ok1);
    double d = ui->LeD->text().toDouble(&ok2);
    int n = ui->LeN->text().toInt(&ok3);

    if(!ok1 || !ok2 || !ok3) {
        QMessageBox::warning(this, "Ошибка ввода",
                                      "Количество членов n должно быть положительным целым числом.");
        return;
    }
    if(n <= 0){
        QMessageBox::warning(this, "Ошибка ввода",
                                      "Количество членов n должно быть положительным целым числом.");
        return;
    }
    double an = a1 +(n - 1) * d;
    double sn = n * (2 * a1 + (n - 1) * d) / 2.0;

    ui->lblAn->setText(QString("n-й член: %1").arg(an, 0, 'f', 4));
    ui->lblSn->setText(QString("Сумма n членов: %1").arg(sn, 0, 'f', 4));
}
