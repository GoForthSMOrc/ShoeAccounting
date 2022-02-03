using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
                    break;

                case ("Мастер"):
                    OpenNewUserWinButton.Visible = false;
                    labelForAdmin.Visible = false;
                    break;
                case ("Пользователь"):
                    OpenNewUserWinButton.Visible = false;
                    labelForAdmin.Visible = false;
                    OpenInsertWinButton.Visible = false;
                    OpenDeleteWinButton.Visible = false;
                    OpenUpdateWinButton.Visible = false;
                    break;
            }
        }

        void getNameUser()
        {
            USERFNAME = "Добро пожаловать, " + OurUserInfo.FName + "!";
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
            this.Close();
        }

        private void OpenDeleteWinButton_Click(object sender, EventArgs e)
        {

        }

        private void OpenUpdateWinButton_Click(object sender, EventArgs e)
        {

        }

        private void OpenNewUserWinButton_Click(object sender, EventArgs e)
        {

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
    }
}
