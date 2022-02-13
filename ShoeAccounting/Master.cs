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
            String query = "Select Master.FirstName,Master.LastName,Master.Patronymic,Master.Phone,Master.Email from ShoeAccounting join Master on ShoeAccounting.id_Master = Master.Id_Master where Id_ShoeAccounting = '" + NumberCheck.Number + "';";
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
    }
}
