using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ShoeAccounting
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
           
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
