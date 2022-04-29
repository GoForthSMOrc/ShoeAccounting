using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;

namespace ShoeAccounting
{
    public partial class MainMenu : Form
    {
        //ОКРУГЛЕНИЕ УГЛОВ ПОРТИТ ОТОБРАЖЕНИЕ ОКНА ПРИ ИЗМЕНЕНИИ РАЗМЕРА

        //[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")] // для округления углов

        /*
        private static extern IntPtr CreateRoundRectRgn // для округления углов
    (
        int nLeftRect,
        int nTopRect,
        int nRightRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse
    );
        */

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")] //для перетаскивания окна, но с сохранением возможностей рамки
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        private int borderSize = 0;
        
        
        public MainMenu()
        {
            InitializeComponent();
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25)); //для округления углов
            this.Padding = new Padding(borderSize);
            this.BackColor = Color.FromArgb(46, 51, 73);

            panelForMainMenu.BackColor = Color.FromArgb(24, 30, 54);

            RefreshListButton.ForeColor = Color.FromArgb(0, 126, 249);
            RefreshListButton.BackColor = Color.FromArgb(24, 30, 54);

            OpenInsertWinButton.BackColor = Color.FromArgb(24, 30, 54);
            OpenInsertWinButton.ForeColor = Color.FromArgb(0, 126, 249);

            OpenDeleteWinButton.BackColor = Color.FromArgb(24, 30, 54);
            OpenDeleteWinButton.ForeColor = Color.FromArgb(0, 126, 249);

            OpenUpdateWinButton.BackColor = Color.FromArgb(24, 30, 54);
            OpenUpdateWinButton.ForeColor = Color.FromArgb(0, 126, 249);

            OpenNewUserWinButton.BackColor = Color.FromArgb(24, 30, 54);
            OpenNewUserWinButton.ForeColor = Color.FromArgb(0, 126, 249);

            labelMainMenu.ForeColor = Color.FromArgb(0, 126, 249);

            ExitButton.BackColor = Color.FromArgb(24, 30, 54);
            ExitButton.ForeColor = Color.FromArgb(0, 126, 249);

            labelFName.ForeColor = Color.FromArgb(0, 126, 249);
            
            findBox.BackColor = Color.FromArgb(74, 79, 99);
            findBox.ForeColor = Color.FromArgb(200, 200, 200);

            /*
            var designSize = this.ClientSize; //Для произвольного расширения/сужения окна. Выглядит интересно, но сомнительно
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.Size = designSize;
            */


            /*Берем информацию о пользователе и выводим его Имя и Отчество + выводим нужный ему список.
             * Для клиента -> список с номерами его заказов.
             * Для админа и мастеров -> общий список + возможность поиска по номеру + дополнительные кнопки и надписи согласно правам.
            */
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

        //Вывод общего списка
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

        //Вывод списка для пользователя
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

        //Приветствие
        void getNameUser()
        {
            USERFNAME = "Добро пожаловать, " + OurUserInfo.FName + " " + OurUserInfo.Patronymic + "!";
        }

        //Чтобы labelFName мог принять значение
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

        /* Старый способ двигать окно
        Point lastPoint;
        private void MainMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        */

        private void MainMenu_MouseDown(object sender, MouseEventArgs e)
        {
            //lastPoint = new Point(e.X, e.Y);
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
        }

        /*
        private void panelForMainMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        */

        private void panelForMainMenu_MouseDown(object sender, MouseEventArgs e)
        {
            //lastPoint = new Point(e.X, e.Y);
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        /*
        private void labelMainMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        */

        private void labelMainMenu_MouseDown(object sender, MouseEventArgs e)
        {
            //lastPoint = new Point(e.X, e.Y);
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        /*
        private void labelFName_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        */

        private void labelFName_MouseDown(object sender, MouseEventArgs e)
        {
            //lastPoint = new Point(e.X, e.Y);
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        /*
        private void labelForAdmin_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        */

        private void labelForAdmin_MouseDown(object sender, MouseEventArgs e)
        {
            //lastPoint = new Point(e.X, e.Y);
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        /*
        private void panelWithButtons_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        */

        //А эта панель вообще есть? 29.04.2022 Pepega
        private void panelWithButtons_MouseDown(object sender, MouseEventArgs e)
        {
            //lastPoint = new Point(e.X, e.Y);
        }

        //Хотел в начале оставить пользователю возможность поиска, но он тянул и не свои заказы, поэтому сделал сразу ему вывод списка его заказов, и убрал поле поиска
        private void findBox_TextChanged(object sender, EventArgs e)
        {
            if (findBox.Text == String.Empty)
            {
                CheckUsingElement.InsertIntoCheckUsingElement(false);
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
            NumberCheck.InsertIntoNumber(null);
            ControlNUMBER.InsertIntoControlNUMBER(null);
            findBox.Clear();
            getInfo(flowLayoutPanelShoeAccounting);
        }

        //Думал чего придумать,передумал
        private void shoeField1_Load(object sender, EventArgs e)
        {

        }

        //Манипуляции с номером записи 
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

        //Перекрытие метода для того, чтобы убрать рамку, но оставить ее функционал по масштабированию. Ссылочкаhttps://www.youtube.com/watch?v=N5oZnV3cA64&t=500s
        protected override void WndProc(ref Message m)
        {

            const int WM_NCCALSIZE = 0x0083;
            if(m.Msg == WM_NCCALSIZE && m.WParam.ToInt32()==1)
            {
                //m.Result = new IntPtr(0xF0); //В видео этого не было, но было на сайте с кодом. Долго не понимал, почему не работает. Пока не закомментил.
                return;
            }
            base.WndProc(ref m);
        }
        
        //При смене размера
        private void MainMenu_Resize(object sender, EventArgs e)
        {
            AdjustForm();
        }

        /* borderSize = 0, в начале создается Padding(0,0,0,0);
         * Начинаем с окна по центру экрана WindowState у такого окна Normal.
         * При изменении на полный экран WindowState = Maximized. (Normal->Maximized)
         * Смена на боковое или на четверть от монитора считается как переход на Normal.
         * Но в любом случае у тебя переходит в Normal при попытке перетянуть окно в другую часть.
         * Поэтому получается Maximized->Normal->Normal или Normal->Normal.
         * Minimized должен был работать при нажатии кнопки "Свернуть"(которой нет,мб сделаю).
         * Но сейчас есть вопросик по поводу Minimized. Зачем пишем Padding, если окно полностью сворачивается? Чтобы, когда разворачивалось, все было ок?
         */
        private void AdjustForm()
        {
            switch(this.WindowState)
            {
                case FormWindowState.Maximized:
                    this.Padding = new Padding(8, 8, 8, 0); //было 8,8,8,0
                    
                    break;
                case FormWindowState.Normal:
                    if (this.Padding.Top == borderSize)
                    {
                        this.Padding = new Padding(borderSize);
                        
                    }
                    break;
                case FormWindowState.Minimized:
                    this.Padding = new Padding(8, 8, 8, 0);
                    break;
                
            }
        }

        //Дополнительные панели, чтобы надписи и прочее не улетало.
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            
        }
    }
}
