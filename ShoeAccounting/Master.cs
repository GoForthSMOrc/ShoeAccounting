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
    public partial class Master : Form
    {
        public Master()
        {
            InitializeComponent();
            getInfo();
        }

        void getInfo()
        {
            String query = "Select master.firstname,master.lastname,master.patronymic,master.phone,master.email from shoeaccounting join master on shoeaccounting.id_master = master.id_master where id_shoeaccounting = '" + NumberCheck.Number + "';";
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
