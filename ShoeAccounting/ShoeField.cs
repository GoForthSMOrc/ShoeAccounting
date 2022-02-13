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
    public partial class ShoeField : UserControl
    {
        public ShoeField()
        {
            InitializeComponent();
        }

        private string _number;

        public string NUMBER
        {
            get { return _number; }
            set { _number = value; labelNumber.Text = value; }
        }

        private string _dateregistration;

        public string DATEREGISTRATION
        {
            get { return _dateregistration; }
            set { _dateregistration = value; labelDateRegistration.Text = value; }
        }

        private string _datecompletion;

        public string DATECOMPLETION
        {
            get { return _datecompletion; }
            set { _datecompletion = value; labelDateCompletion.Text = value; }
        }

        private string _statusshoe;

        public string STATUSSHOE
        {
            get { return _statusshoe; }
            set { _statusshoe = value; labelStatus.Text = value; }
        }

        private void showproblemButton_Click(object sender, EventArgs e)
        {
            DescriptionProblem win = new DescriptionProblem();
            win.Show();
           
        }

        private void ShoeField_Click(object sender, EventArgs e)
        {
            if (BackColor == Color.CornflowerBlue)
            {
                NumberCheck.InsertIntoNumber(NUMBER);
                BackColor = Color.Navy;
            }
            else
            {
                BackColor = Color.CornflowerBlue;
            }
        }

        private void showCommsButton_Click(object sender, EventArgs e)
        {
            Comments win = new Comments();
            win.Show();
        }

        private void userinfoButton_Click(object sender, EventArgs e)
        {
            User win = new User();
            win.Show();
        }

        private void masterinfoButton_Click(object sender, EventArgs e)
        {
            Master win = new Master();
            win.Show();
        }
    }
}
