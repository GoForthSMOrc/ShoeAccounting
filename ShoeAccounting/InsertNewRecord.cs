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
    public partial class InsertNewRecord : Form
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
        public InsertNewRecord()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            dateregBox.MaskInputRejected += new MaskInputRejectedEventHandler(dateregBox_MaskInputRejected);
            dateregBox.KeyDown += new KeyEventHandler(dateregBox_KeyDown);
            datecompBox.MaskInputRejected += new MaskInputRejectedEventHandler(datecompBox_MaskInputRejected);
            datecompBox.KeyDown += new KeyEventHandler(datecompBox_KeyDown);
            this.BackColor = System.Drawing.Color.FromArgb(37, 42, 64);
            labelInsertNewRecord.ForeColor = Color.FromArgb(0, 126, 249);
            labelDateReg.ForeColor = Color.FromArgb(0, 126, 249);
            labelDateComp.ForeColor = Color.FromArgb(0, 126, 249);
            labelNumUser.ForeColor = Color.FromArgb(0, 126, 249);
            labelMaster.ForeColor = Color.FromArgb(0, 126, 249);
            labelShoeStatus.ForeColor = Color.FromArgb(0, 126, 249);
            labelDescProb.ForeColor = Color.FromArgb(0, 126, 249);
            labelMasterCom.ForeColor = Color.FromArgb(0, 126, 249);
            dateregBox.ForeColor = Color.FromArgb(200, 200, 200);
            dateregBox.BackColor = Color.FromArgb(74, 79, 99);
            datecompBox.ForeColor = Color.FromArgb(200, 200, 200);
            datecompBox.BackColor = Color.FromArgb(74, 79, 99);
            numuserBox.ForeColor = Color.FromArgb(200, 200, 200);
            numuserBox.BackColor = Color.FromArgb(74, 79, 99);
            masterBox.ForeColor = Color.FromArgb(200, 200, 200);
            masterBox.BackColor = Color.FromArgb(74, 79, 99);
            shoestatBox.ForeColor = Color.FromArgb(200, 200, 200);
            shoestatBox.BackColor = Color.FromArgb(74, 79, 99);
            descprobBox.ForeColor = Color.FromArgb(200, 200, 200);
            descprobBox.BackColor = Color.FromArgb(74, 79, 99);
            mastercomBox.ForeColor = Color.FromArgb(200, 200, 200);
            mastercomBox.BackColor = Color.FromArgb(74, 79, 99);
            insertButton.ForeColor = Color.FromArgb(0, 126, 249);
            insertButton.BackColor = Color.FromArgb(37,42,64);
            closeWinButton.ForeColor = Color.FromArgb(0, 126, 249);
            closeWinButton.BackColor = Color.FromArgb(37,42,64);
        }
        private void dateregBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (dateregBox.MaskFull)
            {
                toolTipDateCheck.ToolTipTitle = "Ввод отклонен - слишком много данных";
                toolTipDateCheck.Show("Вы больше не можете вводить какие-либо данные в поле даты. Формат даты 2022-04-25.", dateregBox, 0, -20, 5000);
            }
            else if (e.Position == dateregBox.Mask.Length)
            {
                toolTipDateCheck.ToolTipTitle = "Ввод отклонен - конец поля";
                toolTipDateCheck.Show("Вы не можете добавлять дополнительные символы в конец этого поля даты. Формат даты 2022-04-25.", dateregBox, 0, -20, 5000);
            }
            else
            {
                toolTipDateCheck.ToolTipTitle = "Ввод отклонен";
                toolTipDateCheck.Show("Вы можете добавлять только цифровые символы (0-9) в это поле даты. Формат даты 2022-04-25.", dateregBox, 0, -20, 5000);
            }
        }
        void dateregBox_KeyDown(object sender, KeyEventArgs e)
        {
            // The balloon tip is visible for five seconds; if the user types any data before it disappears, collapse it ourselves.
            toolTipDateCheck.Hide(dateregBox);
        }

        private void datecompBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (datecompBox.MaskFull)
            {
                toolTipDateCheck.ToolTipTitle = "Ввод отклонен - слишком много данных";
                toolTipDateCheck.Show("Вы больше не можете вводить какие-либо данные в поле даты. Формат даты 2022-04-25.", datecompBox, 0, -20, 5000);
            }
            else if (e.Position == datecompBox.Mask.Length)
            {
                toolTipDateCheck.ToolTipTitle = "Ввод отклонен - конец поля";
                toolTipDateCheck.Show("Вы не можете добавлять дополнительные символы в конец этого поля даты. Формат даты 2022-04-25.", datecompBox, 0, -20, 5000);
            }
            else
            {
                toolTipDateCheck.ToolTipTitle = "Ввод отклонен";
                toolTipDateCheck.Show("Вы можете добавлять только цифровые символы (0-9) в это поле даты. Формат даты 2022-04-25.", datecompBox, 0, -20, 5000);
            }
        }
        void datecompBox_KeyDown(object sender, KeyEventArgs e)
        {
            // The balloon tip is visible for five seconds; if the user types any data before it disappears, collapse it ourselves.
            toolTipDateCheck.Hide(datecompBox);
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
