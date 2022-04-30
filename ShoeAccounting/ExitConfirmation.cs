using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ShoeAccounting
{
    public partial class ExitConfirmation : Form
    {
        //Для скругления углов
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
    (
        int nLeftRect,
        int nTopRect,
        int nRightRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse
    );



        public ExitConfirmation()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25)); //Для скругления углов
            this.BackColor = Color.FromArgb(46, 51, 73);
            panelExitConfirmation.BackColor = Color.FromArgb(24, 30, 54);
            yesButton.ForeColor = Color.FromArgb(0, 126, 249);
            notButton.BackColor = Color.FromArgb(46, 51, 73);
            notButton.ForeColor = Color.FromArgb(0, 126, 249);
            yesButton.BackColor = Color.FromArgb(46, 51, 73);
            labelExitConfirmation.ForeColor = Color.FromArgb(0, 126, 249);
            labelExitConfirmation.BackColor = Color.FromArgb(24, 30, 54);
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
