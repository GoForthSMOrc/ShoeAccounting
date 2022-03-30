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
            
            switch (OurUserInfo.StatusU)
            {
                case ("Клиент"):
                    showCommsButton.Visible = false;
                    showproblemButton.Visible = false;
                    userinfoButton.Visible = false;
                    break;
            }
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
            if (NumberCheck.Number == null)
            {
                MessageBox.Show("Вы должны кликнуть на соответствующую запись, чтобы выбрать ее!");
            }
            else
            {
                DescriptionProblem win = new DescriptionProblem();
                win.Show();
            }
           
        }

        private void ShoeField_Click(object sender, EventArgs e)
        {
          if (BackColor == Color.CornflowerBlue && CheckUsingElement.CheckUsing == false)
          {
            NumberCheck.InsertIntoNumber(NUMBER);
            ControlNUMBER.InsertIntoControlNUMBER(NUMBER);
            BackColor = Color.Navy;
            CheckUsingElement.InsertIntoCheckUsingElement(true);
          }
          else
          {
            if(BackColor == Color.Navy && CheckUsingElement.CheckUsing == true)
            {
               BackColor = Color.CornflowerBlue;
               CheckUsingElement.InsertIntoCheckUsingElement(false);
               NumberCheck.InsertIntoNumber(null);
               ControlNUMBER.InsertIntoControlNUMBER(null);
                }
            else
            { 
               if(BackColor == Color.CornflowerBlue && CheckUsingElement.CheckUsing == true)
               {
                  MessageBox.Show("Чтобы работать с другой записью необходимо убрать выделение с прошлой!");
               }
            }
           
          }
           
           
        }

        void getColor()
        {
            BackColor = Color.CornflowerBlue;
        }
        
        private void showCommsButton_Click(object sender, EventArgs e)
        {
            if(NumberCheck.Number == null)
            {
                MessageBox.Show("Вы должны кликнуть на соответствующую запись, чтобы выбрать ее!");
            }
            else
            {
                Comments win = new Comments();
                win.Show();
            }
            
        }

        private void userinfoButton_Click(object sender, EventArgs e)
        {
            if (NumberCheck.Number == null)
            {
                MessageBox.Show("Вы должны кликнуть на соответствующую запись, чтобы выбрать ее!");
            }
            else
            {
                User win = new User();
                win.Show();
            }
        }

        private void masterinfoButton_Click(object sender, EventArgs e)
        {
            if (NumberCheck.Number == null)
            {
                MessageBox.Show("Вы должны кликнуть на соответствующую запись, чтобы выбрать ее!");
            }
            else
            {
                Master win = new Master();
                win.Show();
            }
        }

        private void ShoeField_MouseEnter(object sender, EventArgs e)
        {
            if(BackColor == Color.CornflowerBlue)
            {
               NumberCheck.InsertIntoNumber(null);
            }
            else
            {
                NumberCheck.InsertIntoNumber(NUMBER);
            }
            
        }
    }
}
