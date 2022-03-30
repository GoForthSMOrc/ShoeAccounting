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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            getNameUser();
            switch (OurUserInfo.StatusU)
            {
                case ("Администратор"):
                    labelForAdmin.Visible = true;
                    getInfo(flowLayoutPanelShoeAccounting);
                    break;

                case ("Мастер"):
                    OpenNewUserWinButton.Visible = false;
                    labelForAdmin.Visible = false;
                    getInfo(flowLayoutPanelShoeAccounting);
                    break;
                case ("Клиент"):
                    OpenNewUserWinButton.Visible = false;
                    labelForAdmin.Visible = false;
                    OpenInsertWinButton.Visible = false;
                    OpenDeleteWinButton.Visible = false;
                    OpenUpdateWinButton.Visible = false;
                    findBox.Visible = false;
                    getInfoOnlyForUser(flowLayoutPanelShoeAccounting);
                    break;
            }
        }

        /*public void DeleteCheckInfo()
        {
            if(DeleteCheck.DeleteCheckMark == true)
            {
                flowLayoutPanelShoeAccounting.Controls.Clear();
                switch (OurUserInfo.StatusU)
                {
                    case ("Администратор"):
                        labelForAdmin.Visible = true;
                        getInfo(flowLayoutPanelShoeAccounting);
                        break;

                    case ("Мастер"):
                        OpenNewUserWinButton.Visible = false;
                        labelForAdmin.Visible = false;
                        getInfo(flowLayoutPanelShoeAccounting);
                        break;
                    case ("Клиент"):
                        OpenNewUserWinButton.Visible = false;
                        labelForAdmin.Visible = false;
                        OpenInsertWinButton.Visible = false;
                        OpenDeleteWinButton.Visible = false;
                        OpenUpdateWinButton.Visible = false;
                        findBox.Visible = false;
                        getInfoOnlyForUser(flowLayoutPanelShoeAccounting);
                        break;
                }
                DeleteCheck.ChangeDeleteCheckMarkFalse();
            }

        }*/
        void getInfo(FlowLayoutPanel panel)
        {
            flowLayoutPanelShoeAccounting.Controls.Clear();
            //String query = "Select shoeaccounting.id_shoeaccounting, date_format(dateregistration,'%d.%m.%y' ),date_format(dateofcompletion,'%d.%m.%y'), statusshoe.namestatusshoe from shoeaccounting join statusshoe on shoeaccounting.id_statusshoe = statusshoe.id_statusshoe order by shoeaccounting.id_shoeaccounting asc";//
            String query = "call sp_getInfo()";
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
                        string[] row = { rd.GetString(0), rd.GetString(1), rd.GetString(2), rd.GetString(3)};
                        OurShoeInfo.InsertIntoOurShoeInfo(row);
                        ShoeField shoeField = new ShoeField();
                        shoeField.NUMBER = OurShoeInfo.Id;
                        shoeField.DATEREGISTRATION = OurShoeInfo.DateReg;
                        shoeField.DATECOMPLETION = OurShoeInfo.DateComp;
                        shoeField.STATUSSHOE = OurShoeInfo.StatusShoe;

                        flowLayoutPanelShoeAccounting.Controls.Add(shoeField);
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка вывода списка");
                MessageBox.Show(ex.Message);
            }
        }

        void getInfoOnlyForUser(FlowLayoutPanel panel)
        {
            flowLayoutPanelShoeAccounting.Controls.Clear();
            //String query = "Select shoeaccounting.id_shoeaccounting, date_format(dateregistration,'%d.%m.%y' ),date_format(dateofcompletion,'%d.%m.%y'), statusshoe.namestatusshoe from shoeaccounting join statusshoe on shoeaccounting.id_statusshoe = statusshoe.id_statusshoe where id_usersdb = '" + OurUserInfo.id_UsersDBInfo + "' order by shoeaccounting.id_shoeaccounting asc;";//
            String query = "call sp_getInfoOnlyForUser('" + OurUserInfo.id_UsersDBInfo + "');";
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
                        string[] row = { rd.GetString(0), rd.GetString(1), rd.GetString(2), rd.GetString(3)};
                        OurShoeInfo.InsertIntoOurShoeInfo(row);
                        ShoeField shoeField = new ShoeField();
                        shoeField.NUMBER = OurShoeInfo.Id;
                        shoeField.DATEREGISTRATION = OurShoeInfo.DateReg;
                        shoeField.DATECOMPLETION = OurShoeInfo.DateComp;
                        shoeField.STATUSSHOE = OurShoeInfo.StatusShoe;
                        

                        flowLayoutPanelShoeAccounting.Controls.Add(shoeField);
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка вывода списка");
                MessageBox.Show(ex.Message);
            }
        }
        void getNameUser()
        {
            USERFNAME = "Добро пожаловать, " + OurUserInfo.FName + " " + OurUserInfo.Patronymic + "!";
        }

        private string _userfname;

        public string USERFNAME
        {
            get { return _userfname; }
            set { _userfname = value; labelFName.Text = value; }
        }

        private void OpenInsertWinButton_Click(object sender, EventArgs e)
        {
            InsertNewRecord win = new InsertNewRecord();
            win.Show();
        }

        private void OpenDeleteWinButton_Click(object sender, EventArgs e)
        {
            if (NumberCheck.Number == null)
            {
                MessageBox.Show("Выберите запись щелкнув на нее");
            }
            else
            {
                DeleteRecord win = new DeleteRecord();
                win.Show();
            }
        }

        private void OpenUpdateWinButton_Click(object sender, EventArgs e)
        {
            if (NumberCheck.Number == null)
            {
                MessageBox.Show("Выберите запись щелкнув на нее");
            }
            else
            {
                UpdateRecord win = new UpdateRecord();
                win.Show();
            }
        }

        private void OpenNewUserWinButton_Click(object sender, EventArgs e)
        {
            AddUser win = new AddUser();
            win.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            ExitConfirmation win = new ExitConfirmation();
            win.Show();
            
        }

        Point lastPoint;
        private void MainMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void MainMenu_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panelForMainMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panelForMainMenu_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void labelMainMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void labelMainMenu_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void labelFName_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void labelFName_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void labelForAdmin_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void labelForAdmin_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panelWithButtons_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panelWithButtons_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void findBox_TextChanged(object sender, EventArgs e)
        {
            if (findBox.Text == String.Empty)
            {
                switch (OurUserInfo.StatusU)
                {
                    case ("Администратор"):
                        getInfo(flowLayoutPanelShoeAccounting);
                        break;

                    case ("Мастер"):
                        getInfo(flowLayoutPanelShoeAccounting);
                        break;
                    /*case ("Клиент"):
                        getInfoOnlyForUser(flowLayoutPanelShoeAccounting);
                        break;
                    */
                }
            }
            else
            {
                flowLayoutPanelShoeAccounting.Controls.Clear();
                //String query = "Select shoeaccounting.id_shoeaccounting, date_format(dateregistration,'%d.%m.%y' ),date_format(dateofcompletion,'%d.%m.%y'), statusshoe.namestatusshoe from shoeaccounting join statusshoe on shoeaccounting.id_statusshoe = statusshoe.id_statusshoe where id_shoeaccounting = '" + findBox.Text + "';";//
                String query = "call sp_FindByNumber('" + findBox.Text + "');";
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
                            string[] row = { rd.GetString(0), rd.GetString(1), rd.GetString(2), rd.GetString(3) };
                            OurShoeInfo.InsertIntoOurShoeInfo(row);
                            ShoeField shoeField = new ShoeField();
                            shoeField.NUMBER = OurShoeInfo.Id;
                            shoeField.DATEREGISTRATION = OurShoeInfo.DateReg;
                            shoeField.DATECOMPLETION = OurShoeInfo.DateComp;
                            shoeField.STATUSSHOE = OurShoeInfo.StatusShoe;
                            

                            flowLayoutPanelShoeAccounting.Controls.Add(shoeField);
                        }
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка вывода списка");
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void findBox_MouseClick(object sender, MouseEventArgs e)
        {
            findBox.Clear();
            getInfo(flowLayoutPanelShoeAccounting);
        }

        private void shoeField1_Load(object sender, EventArgs e)
        {

        }

        private void panelForMainMenu_MouseEnter(object sender, EventArgs e)
        {
            NumberCheck.InsertIntoNumber(ControlNUMBER.CheckNum);
        }

        private void RefreshListButton_Click(object sender, EventArgs e)
        {
            flowLayoutPanelShoeAccounting.Controls.Clear();
            switch (OurUserInfo.StatusU)
            {
                case ("Администратор"):
                    labelForAdmin.Visible = true;
                    getInfo(flowLayoutPanelShoeAccounting);
                    CheckUsingElement.InsertIntoCheckUsingElement(false);
                    break;

                case ("Мастер"):
                    OpenNewUserWinButton.Visible = false;
                    labelForAdmin.Visible = false;
                    getInfo(flowLayoutPanelShoeAccounting);
                    CheckUsingElement.InsertIntoCheckUsingElement(false);
                    break;
                case ("Клиент"):
                    OpenNewUserWinButton.Visible = false;
                    labelForAdmin.Visible = false;
                    OpenInsertWinButton.Visible = false;
                    OpenDeleteWinButton.Visible = false;
                    OpenUpdateWinButton.Visible = false;
                    findBox.Visible = false;
                    getInfoOnlyForUser(flowLayoutPanelShoeAccounting);
                    CheckUsingElement.InsertIntoCheckUsingElement(false);
                    break;
            }
        }
    }
}
