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
            String query = "Select ShoeAccounting.DateRegistration,ShoeAccounting.DescriptionOfTheProblem,ShoeAccounting.MasterComments,ShoeAccounting.DateOfCompletion,ShoeAccounting.id_UsersDB,Master.FirstName,StatusShoe.NameStatusShoe from ShoeAccounting join Master on ShoeAccounting.id_Master = Master.Id_Master join StatusShoe on ShoeAccounting.id_StatusShoe = StatusShoe.Id_StatusShoe where Id_ShoeAccounting = '" + NumberCheck.Number + "';";
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
                        masterBox.Text = row[5];
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
            String query = "Update ShoeAccounting set DateRegistration = '" + dateregBox.Text + "',DescriptionOfTheProblem = '" + descprobBox.Text + "',MasterComments = '" + mastercomBox.Text + "',DateOfCompletion = '" + datecompBox.Text + "',id_UsersDB = '" + numuserBox.Text + "',id_Master = '" + MasterNumber.MasterNumbervalue + "',id_StatusShoe = '" + ShoeStatusNumber.ShoeStatusNumbervalue + "' where Id_ShoeAccounting = '" + NumberCheck.Number + "';";
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
