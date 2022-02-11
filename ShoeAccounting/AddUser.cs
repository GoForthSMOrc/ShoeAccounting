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
            MainMenu win = new MainMenu();
            win.Show();
            this.Close();
        }

        private void adduserButton_Click(object sender, EventArgs e)
        {
            String query = "insert into UsersDB (Login,Password,LastName,FirstName,Patronymic,Phone,Email, id_StatusUsersDB) values ('" + logBox.Text +"','" + passBox.Text +"','" + lnameBox.Text +"','" + fnameBox.Text + "','" + patronBox.Text + "','" + phoneBox.Text + "','" + emailBox.Text + "','" + StatusUsersDB.StatusUsersDBvalue + "');";
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
    }
}
