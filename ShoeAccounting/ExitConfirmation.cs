using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ShoeAccounting
{
    public partial class ExitConfirmation : Form
    {
        public ExitConfirmation()
        {
            InitializeComponent();
        }

        //Подтверждение выхода: клик кнопки Да//
        private void yesButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Подтверждение выхода: клик кнопки Нет//
        private void notButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Класс для работы с координатами окна Подтверждения выхода//
        Point lastPoint;

        //Перетаскивание за надпись//
        private void labelExitConfirmation_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void labelExitConfirmation_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panelExitConfirmation_Paint(object sender, PaintEventArgs e)
        {

        }

        //Перетаскивание за верхнюю панель//
        private void panelExitConfirmation_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panelExitConfirmation_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void ExitConfirmation_Load(object sender, EventArgs e)
        {

        }

        //Перетаскивание за основную панельку//
        private void ExitConfirmation_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void ExitConfirmation_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }


        //Перетаскивание на верхнюю панель//
        private void panelLine2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panelLine2_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
