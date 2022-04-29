using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;

namespace ShoeAccounting
{
    public partial class Authorization : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")] //Скругление углов

        private static extern IntPtr CreateRoundRectRgn
    (
        int nLeftRect,
        int nTopRect,
        int nRightRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse
    );



        public Authorization()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            this.BackColor = Color.FromArgb(46, 51, 73);
            panelAuthorization.BackColor = Color.FromArgb(24, 30, 54);
            enterButton.ForeColor = Color.FromArgb(0, 126, 249);
            enterButton.BackColor = Color.FromArgb(46, 51, 73);
            exitButton.ForeColor = Color.FromArgb(0, 126, 249);
            exitButton.BackColor = Color.FromArgb(46, 51, 73);
            labelAuthorization.ForeColor = Color.FromArgb(0, 126, 249);
            labelLogin.ForeColor = Color.FromArgb(0, 126, 249);
            labelPassword.ForeColor = Color.FromArgb(0, 126, 249);
            logBox.BackColor = Color.FromArgb(74, 79, 99);
            passBox.BackColor = Color.FromArgb(74, 79, 99);
            logBox.ForeColor = Color.FromArgb(200, 200, 200);
            passBox.ForeColor = Color.FromArgb(200, 200, 200);
        }

        private void Authorization_Load(object sender, EventArgs e)
        {

        }

        private void panelLine_Paint(object sender, PaintEventArgs e)
        {

        }

        //Класс для работы с координатами окна Авторизация//
        Point lastPoint;

        //Перетаскивание за надпись авторизации//
        private void labelAuthorization_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void labelAuthorization_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        //Перетаскивание за верхнюю панель//
        private void panelAuthorization_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panelAuthorization_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        //Перетаскивание за верхнюю маленькую панель//
        private void panelLine_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panelLine_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        //Перетаскивание за основную панель//
        private void Authorization_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Authorization_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        //Перетаскивание за надпись логин//
        private void labelLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void labelLogin_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        //Перетаскивание за надпись пароль//
        private void labelPassword_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void labelPassword_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        //Авторизация: клик кнопки выйти//
        private void exitButton_Click(object sender, EventArgs e)
        {
            ExitConfirmation winExit = new ExitConfirmation();
            winExit.Show();
        }


        //Авторизация: клик кнопки войти//
        private void enterButton_Click(object sender, EventArgs e)
        {
            if (logBox.Text == String.Empty || passBox.Text == String.Empty)
            {
                MessageBox.Show("Поля должны быть заполнены");
            }
            else
            {
                int Count = 0;
                //String query = "Select usersdb.lastname,usersdb.firstname,usersdb.patronymic,usersdb.phone,usersdb.email,statususersdb.namestatususersdb, usersdb.id_usersdb from usersdb join statususersdb on usersdb.id_statususersdb = statususersdb.id_statususersdb where login = '" + logBox.Text + "' and password = '" + passBox.Text + "';";//
                String query = "call sp_Authorization('" + logBox.Text + "','" + passBox.Text + "');";
                MySqlConnection conn = DBUtils.GetDBConnection();
                MySqlCommand cmDB = new MySqlCommand(query, conn);
                MySqlDataReader rd;
                cmDB.CommandTimeout = 60;
                try
                {
                    conn.Open();
                    rd = cmDB.ExecuteReader();
                    if (rd.HasRows)
                    {
                        while (rd.Read())
                        {
                            string[] row = { rd.GetString(0), rd.GetString(1), rd.GetString(2), rd.GetString(3), rd.GetString(4), rd.GetString(5), rd.GetString(6) };
                            OurUserInfo.InsertIntoOurUserInfo(row);
                        }
                        Count = 1;
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка");
                    MessageBox.Show(ex.Message);
                }

                if (Count > 0)
                {
                    MainMenu win = new MainMenu();
                    win.Show();
                    this.Hide();
                }

                if (Count == 0)
                {
                    MessageBox.Show("Ошибка подключения к серверу");
                }
            }
        }
    }
}
