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
    public partial class InsertNewRecord : Form
    {
        public InsertNewRecord()
        {
            InitializeComponent();
        }

        private void InsertNewRecord_Load(object sender, EventArgs e)
        {

        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            if (dateregBox.Text == String.Empty || datecompBox.Text == String.Empty || numuserBox.Text == String.Empty || masterBox.Text == String.Empty || shoestatBox.Text == String.Empty)
            {
                MessageBox.Show("Все поля кроме(возможно после осмотра мастера или по заявлению пользователя) Описания проблемы и Заметок мастера должны быть заполнены");
            }
            else
            {
                //String query = "Insert into shoeaccounting (dateregistration,descriptionoftheproblem,mastercomments,dateofcompletion,id_usersdb,id_master,id_statusshoe) values ('" + dateregBox.Text + "','" + descprobBox.Text + "','" + mastercomBox.Text + "','" + datecompBox.Text + "', '" + numuserBox.Text + "','" + MasterNumber.MasterNumbervalue + "','" + ShoeStatusNumber.ShoeStatusNumbervalue + "');";//
                String query = "call sp_InsertIntoShoeAccounting('" + dateregBox.Text + "','" + descprobBox.Text + "','" + mastercomBox.Text + "','" + datecompBox.Text + "', '" + numuserBox.Text + "','" + MasterNumber.MasterNumbervalue + "','" + ShoeStatusNumber.ShoeStatusNumbervalue + "')";
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
                    MessageBox.Show("Ошибка ввода");
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void closeWinButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        Point lastPoint;
        private void labelInsertNewRecord_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void labelInsertNewRecord_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void InsertNewRecord_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void InsertNewRecord_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void labelDateReg_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void labelDateReg_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void labelDateComp_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void labelDateComp_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void labelNumUser_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void labelNumUser_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void labelDescProb_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void labelDescProb_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void labelMasterCom_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void labelMasterCom_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void labelMaster_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void labelMaster_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void labelShoeStatus_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void labelShoeStatus_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
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
