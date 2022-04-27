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
    public partial class Master : Form
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
        public Master()
        {
            InitializeComponent();
            getInfo();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            this.BackColor = System.Drawing.Color.FromArgb(37, 42, 64);
            labelDescription.ForeColor = Color.FromArgb(0, 126, 249);
            labelF.ForeColor = Color.FromArgb(0, 126, 249);
            labeli.ForeColor = Color.FromArgb(0, 126, 249);
            labelO.ForeColor = Color.FromArgb(0, 126, 249);
            labelPhone.ForeColor = Color.FromArgb(0, 126, 249);
            labelMail.ForeColor = Color.FromArgb(0, 126, 249);
            fBox.ForeColor = Color.FromArgb(200, 200, 200);
            fBox.BackColor = Color.FromArgb(74, 79, 99);
            iBox.ForeColor = Color.FromArgb(200, 200, 200);
            iBox.BackColor = Color.FromArgb(74, 79, 99);
            oBox.ForeColor = Color.FromArgb(200, 200, 200);
            oBox.BackColor = Color.FromArgb(74, 79, 99);
            pBox.ForeColor = Color.FromArgb(200, 200, 200);
            pBox.BackColor = Color.FromArgb(74, 79, 99);
            mBox.ForeColor = Color.FromArgb(200, 200, 200);
            mBox.BackColor = Color.FromArgb(74, 79, 99);
        }

        void getInfo()
        {
            //String query = "Select master.firstname,master.lastname,master.patronymic,master.phone,master.email from shoeaccounting join master on shoeaccounting.id_master = master.id_master where id_shoeaccounting = '" + NumberCheck.Number + "';";//
            String query = "call sp_getInfoForMasterWin('" + NumberCheck.Number + "')";
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
                        string[] row = { rd.GetString(0), rd.GetString(1), rd.GetString(2), rd.GetString(3), rd.GetString(4) };
                        ForMaster.InsertIntoForMaster(row);
                        fBox.Text = row[0];
                        iBox.Text = row[1];
                        oBox.Text = row[2];
                        pBox.Text = row[3];
                        mBox.Text = row[4];
                    }

                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка");
                MessageBox.Show(ex.Message);
            }
        }

        private void labelExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelExit_MouseHover(object sender, EventArgs e)
        {
            labelExit.ForeColor = Color.White;
        }

        private void labelExit_MouseLeave(object sender, EventArgs e)
        {
            labelExit.ForeColor = Color.DarkMagenta;
        }

        Point lastPoint;
        private void labelDescription_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void labelDescription_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y); 
        }

        private void Master_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Master_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void labelF_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void labelF_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void labeli_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void labeli_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void labelO_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void labelO_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void labelPhone_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void labelPhone_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void labelMail_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void labelMail_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
