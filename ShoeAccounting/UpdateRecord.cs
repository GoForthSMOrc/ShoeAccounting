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
    public partial class UpdateRecord : Form
    {
        public UpdateRecord()
        {
            InitializeComponent();
            getInfo();
            
        }
        

        void getInfo()
        {
            String query = "Select date_format(dateregistration,'%Y-%m-%d' ),shoeaccounting.descriptionoftheproblem,shoeaccounting.mastercomments,date_format(dateofcompletion,'%Y-%m-%d'),shoeaccounting.id_usersdb,master.firstname,statusshoe.namestatusshoe from shoeaccounting join master on shoeaccounting.id_master = master.id_master join statusshoe on shoeaccounting.id_statusshoe = statusshoe.id_statusshoe where id_shoeaccounting = '" + NumberCheck.Number + "';";
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            MySqlDataReader rd;
            cmDB.CommandTimeout = 60;
            try
            {
                conn.Open();
                rd = cmDB.ExecuteReader();
                if(rd.HasRows)
                {
                    while(rd.Read())
                    {
                        string[] row = {rd.GetString(0), rd.GetString(1), rd.GetString(2), rd.GetString(3), rd.GetString(4), rd.GetString(5), rd.GetString(6)};
                        dateregBox.Text = row[0];
                        descprobBox.Text = row[1];
                        mastercomBox.Text = row[2];
                        datecompBox.Text = row[3];
                        numuserBox.Text = row[4];
                        //masterBox.Text = row[5];//
                        shoestatBox.Text = row[6];
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка вывода информации записи");
                MessageBox.Show(ex.Message);
            }

        }
        private void closeWinButton_Click(object sender, EventArgs e)
        {
            MainMenu win = new MainMenu();
            win.Show();
            this.Close();
        }

        Point lastPoint;
        private void labelUpdateRec_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void labelUpdateRec_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void UpdateRecord_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void UpdateRecord_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void UpdateRecord_Load(object sender, EventArgs e)
        {

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (dateregBox.Text == String.Empty || datecompBox.Text == String.Empty || numuserBox.Text == String.Empty || masterBox.Text == String.Empty || shoestatBox.Text == String.Empty)
            {
                MessageBox.Show("Все поля кроме(возможно после осмотра мастера или по заявлению пользователя) Описания проблемы и Заметок мастера должны быть заполнены");
            }
            else
            {
                String query = "Update shoeaccounting set dateregistration = '" + dateregBox.Text + "',descriptionoftheproblem = '" + descprobBox.Text + "',mastercomments = '" + mastercomBox.Text + "',dateofcompletion = '" + datecompBox.Text + "',id_usersdb = '" + numuserBox.Text + "',id_master = '" + MasterNumber.MasterNumbervalue + "',id_statusshoe = '" + ShoeStatusNumber.ShoeStatusNumbervalue + "' where id_shoeaccounting = '" + NumberCheck.Number + "';";
                MySqlConnection conn = DBUtils.GetDBConnection();
                MySqlCommand cmDB = new MySqlCommand(query, conn);
                MySqlDataReader rd;
                cmDB.CommandTimeout = 60;
                try
                {
                    conn.Open();
                    rd = cmDB.ExecuteReader();
                    MessageBox.Show("Запись успешно обновлена");
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка обновления записи");
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void masterBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (masterBox.SelectedItem)
            {
                case ("Горцев И.И"):
                    int Master = 1;
                    MasterNumber.InsertIntoMasterNumbervalue(Master);
                    break;
                case ("Голубев В.И"):
                    Master = 2;
                    MasterNumber.InsertIntoMasterNumbervalue(Master);
                    break;
            }
        }

        private void shoestatBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (shoestatBox.SelectedItem)
            {
                case ("Осмотр"):
                    int StatusShoeNumber = 1;
                    ShoeStatusNumber.InsertIntoShoeStatusNumbervalue(StatusShoeNumber);
                    break;
                case ("На ремонте"):
                    StatusShoeNumber = 2;
                    ShoeStatusNumber.InsertIntoShoeStatusNumbervalue(StatusShoeNumber);
                    break;
                case ("Ремонт окончен"):
                    StatusShoeNumber = 3;
                    ShoeStatusNumber.InsertIntoShoeStatusNumbervalue(StatusShoeNumber);
                    break;
            }
        }
    }
}
