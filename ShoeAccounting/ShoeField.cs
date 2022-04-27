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
    public partial class ShoeField : UserControl
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
        public ShoeField()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            this.BackColor = System.Drawing.Color.FromArgb(74, 79, 99);
            masterinfoButton.BackColor = Color.FromArgb(74, 79, 99);
            masterinfoButton.ForeColor = Color.FromArgb(46, 51, 73);
            userinfoButton.BackColor = Color.FromArgb(74, 79, 99);
            userinfoButton.ForeColor = Color.FromArgb(46, 51, 73);
            showproblemButton.BackColor = Color.FromArgb(74, 79, 99);
            showproblemButton.ForeColor = Color.FromArgb(46, 51, 73);
            showCommsButton.BackColor = Color.FromArgb(74, 79, 99);
            showCommsButton.ForeColor = Color.FromArgb(46, 51, 73);

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
          if (BackColor == Color.FromArgb(74, 79, 99) && CheckUsingElement.CheckUsing == false)
          {
                NumberCheck.InsertIntoNumber(NUMBER);
                ControlNUMBER.InsertIntoControlNUMBER(NUMBER);
                BackColor = Color.FromArgb(37, 42, 64);
                labelNum.ForeColor = Color.FromArgb(0, 126, 249);
                labelNumber.ForeColor = Color.FromArgb(0, 126, 249);
                labelDateReg.ForeColor = Color.FromArgb(0, 126, 249);
                labelDateRegistration.ForeColor = Color.FromArgb(0, 126, 249);
                labelDateComp.ForeColor = Color.FromArgb(0, 126, 249);
                labelDateCompletion.ForeColor = Color.FromArgb(0, 126, 249);
                labelStat.ForeColor = Color.FromArgb(0, 126, 249);
                labelStatus.ForeColor = Color.FromArgb(0, 126, 249);
                masterinfoButton.BackColor = Color.FromArgb(37, 42, 64);
                masterinfoButton.ForeColor = Color.FromArgb(0, 126, 249);
                userinfoButton.BackColor = Color.FromArgb(37, 42, 64);
                userinfoButton.ForeColor = Color.FromArgb(0, 126, 249);
                showproblemButton.BackColor = Color.FromArgb(37, 42, 64);
                showproblemButton.ForeColor = Color.FromArgb(0, 126, 249);
                showCommsButton.BackColor = Color.FromArgb(37, 42, 64);
                showCommsButton.ForeColor = Color.FromArgb(0, 126, 249);
                CheckUsingElement.InsertIntoCheckUsingElement(true);
          }
          else
          {
            if(BackColor == Color.FromArgb(37, 42, 64) && CheckUsingElement.CheckUsing == true)
            {
               BackColor = Color.FromArgb(74, 79, 99);
               labelNum.ForeColor = Color.White;
               labelNumber.ForeColor = Color.White;
               labelDateReg.ForeColor = Color.White;
               labelDateRegistration.ForeColor = Color.White;
               labelDateComp.ForeColor = Color.White;
               labelDateCompletion.ForeColor = Color.White;
               labelStat.ForeColor = Color.White;
               labelStatus.ForeColor = Color.White;
               masterinfoButton.BackColor = Color.FromArgb(74, 79, 99);
               masterinfoButton.ForeColor = Color.FromArgb(46, 51, 73);
               userinfoButton.BackColor = Color.FromArgb(74, 79, 99);
               userinfoButton.ForeColor = Color.FromArgb(46, 51, 73);
               showproblemButton.BackColor = Color.FromArgb(74, 79, 99);
               showproblemButton.ForeColor = Color.FromArgb(46, 51, 73);
               showCommsButton.BackColor = Color.FromArgb(74, 79, 99);
               showCommsButton.ForeColor = Color.FromArgb(46, 51, 73);
               CheckUsingElement.InsertIntoCheckUsingElement(true);
               CheckUsingElement.InsertIntoCheckUsingElement(false);
               NumberCheck.InsertIntoNumber(null);
               ControlNUMBER.InsertIntoControlNUMBER(null);
                }
            else
            { 
               if(BackColor == Color.FromArgb(74, 79, 99) && CheckUsingElement.CheckUsing == true)
               {
                  MessageBox.Show("Чтобы работать с другой записью необходимо убрать выделение с прошлой!");
               }
            }
           
          }
           
           
        }

        /*void getColor()
        {
            BackColor = Color.CornflowerBlue;
        }*/
        
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
            if(BackColor == Color.FromArgb(74, 79, 99))
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
