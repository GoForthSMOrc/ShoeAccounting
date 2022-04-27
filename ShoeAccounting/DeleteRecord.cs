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
    public partial class DeleteRecord : Form
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
        public DeleteRecord()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

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
            this.Close();
            NumberCheck.InsertIntoNumber(null);
            ControlNUMBER.InsertIntoControlNUMBER(null);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //String query = "Delete from shoeaccounting where id_shoeaccounting = '" + NumberCheck.Number + "';";//
            if(NumberCheck.Number == null)
            {
                NumberCheck.InsertIntoNumber(ControlNUMBER.CheckNum);
            }
            String query = "call sp_DeleteRecord('" + NumberCheck.Number + "')";
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
                
                this.Close();
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
