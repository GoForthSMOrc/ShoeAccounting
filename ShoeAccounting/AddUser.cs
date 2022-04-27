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
    public partial class AddUser : Form
    {
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
        public AddUser()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            this.BackColor = Color.FromArgb(37, 42, 64);
            labelAddUser.ForeColor = Color.FromArgb(0, 126, 249);
            labelLog.ForeColor = Color.FromArgb(0, 126, 249);
            labelPass.ForeColor = Color.FromArgb(0,126,249);
            labelFname.ForeColor = Color.FromArgb(0, 126, 249);
            labelLName.ForeColor = Color.FromArgb(0, 126, 249);
            labelPatron.ForeColor = Color.FromArgb(0,126,249);
            labelPhone.ForeColor = Color.FromArgb(0, 126, 249);
            labelEmail.ForeColor = Color.FromArgb(0, 126, 249);
            labelStatus.ForeColor = Color.FromArgb(0, 126, 249);
            logBox.ForeColor = Color.FromArgb(200, 200, 200);
            logBox.BackColor = Color.FromArgb(74, 79, 99);
            passBox.ForeColor = Color.FromArgb(200, 200, 200);
            passBox.BackColor = Color.FromArgb(74,79,99);
            lnameBox.ForeColor = Color.FromArgb(200, 200, 200);
            lnameBox.BackColor = Color.FromArgb(74, 79, 99);
            fnameBox.ForeColor = Color.FromArgb(200, 200, 200);
            fnameBox.BackColor = Color.FromArgb(74,79,99);
            patronBox.ForeColor = Color.FromArgb(200, 200, 200);
            patronBox.BackColor = Color.FromArgb(74,79,99);
            phoneBox.ForeColor = Color.FromArgb(200, 200, 200);
            phoneBox.BackColor = Color.FromArgb(74,79,99);
            emailBox.ForeColor = Color.FromArgb(200, 200, 200);
            emailBox.BackColor = Color.FromArgb(74,79,99);
            statusBox.ForeColor = Color.FromArgb(200, 200, 200);
            statusBox.BackColor = Color.FromArgb(74,79,99);
            adduserButton.ForeColor = Color.FromArgb(0, 126, 249);
            adduserButton.BackColor = Color.FromArgb(37, 42, 64);
            closeWinButton.ForeColor = Color.FromArgb(0, 126, 249);
            closeWinButton.BackColor = Color.FromArgb(37,42,64);
        }

        private void closeWinButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void adduserButton_Click(object sender, EventArgs e)
        {
            if (logBox.Text == String.Empty || passBox.Text == String.Empty || lnameBox.Text == String.Empty || fnameBox.Text == String.Empty || patronBox.Text == String.Empty || phoneBox.Text == String.Empty || emailBox.Text == String.Empty || statusBox.Text == String.Empty)
            {
                MessageBox.Show("Для добавления пользователя все поля должны быть заполнены");
            }
            else
            {
                //String query = "Insert into usersdb (login,password,lastname,firstname,patronymic,phone,email, id_statususersdb) values ('" + logBox.Text + "','" + passBox.Text + "','" + lnameBox.Text + "','" + fnameBox.Text + "','" + patronBox.Text + "','" + phoneBox.Text + "','" + emailBox.Text + "','" + StatusUsersDB.StatusUsersDBvalue + "');";//
                String query = "call sp_InsertIntoUsersDB('" + logBox.Text + "','" + passBox.Text + "','" + lnameBox.Text + "','" + fnameBox.Text + "','" + patronBox.Text + "','" + phoneBox.Text + "','" + emailBox.Text + "','" + StatusUsersDB.StatusUsersDBvalue + "')";
                MySqlConnection conn = DBUtils.GetDBConnection();
                MySqlCommand cmDB = new MySqlCommand(query, conn);
                MySqlDataReader rd;
                cmDB.CommandTimeout = 60;
                try
                {
                    conn.Open();
                    rd = cmDB.ExecuteReader();
                    MessageBox.Show("Запись успешно добавлена");
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка добавления пользователя");
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void statusBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (statusBox.SelectedItem)
            {
                case ("Администратор"):
                    int StatusAdmin = 1;
                    StatusUsersDB.InsertIntoStatusUsersDBvalue(StatusAdmin);
                    break;
                case ("Мастер"):
                    int StatusMaster = 2;
                    StatusUsersDB.InsertIntoStatusUsersDBvalue(StatusMaster);
                    break;
                case ("Клиент"):
                    int StatusClient = 3;
                    StatusUsersDB.InsertIntoStatusUsersDBvalue(StatusClient);
                    break;
            }
        }

        private void AddUser_MouseHover(object sender, EventArgs e)
        {
            
        }
        Point lastPoint;
        private void AddUser_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                    this.Left += e.X - lastPoint.X;
                    this.Top += e.Y - lastPoint.Y;
            }
        }

        private void AddUser_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void labelAddUser_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void labelAddUser_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void labelLog_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void labelLog_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void labelPass_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void labelPass_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void labelLName_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void labelLName_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void labelFname_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void labelFname_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void labelPatron_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void labelPatron_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void labelPhone_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void labelPhone_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void labelEmail_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void labelEmail_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void labelStatus_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void labelStatus_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
