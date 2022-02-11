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
    public partial class DeleteRecord : Form
    {
        public DeleteRecord()
        {
            InitializeComponent();
        }


        Point lastPoint;
        private void labelDeleteRec_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void labelDeleteRec_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void DeleteRecord_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void DeleteRecord_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void closeWinButton_Click(object sender, EventArgs e)
        {
            MainMenu win = new MainMenu();
            win.Show();
            this.Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            String query = "Delete from ShoeAccounting where Id_ShoeAccounting = '" + NumberCheck.Number + "';";
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            MySqlDataReader rd;
            cmDB.CommandTimeout = 60;
            try
            {
                conn.Open();
                rd = cmDB.ExecuteReader();
                MessageBox.Show("Запись удалена");
                DeleteCheck.ChangeDeleteCheckMarkTrue();
                NumberCheck.InsertIntoNumber(null);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка удаления записи");
                MessageBox.Show(ex.Message);
            }
        }
    }
}
