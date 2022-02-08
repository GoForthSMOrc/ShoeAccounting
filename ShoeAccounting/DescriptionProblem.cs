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
    public partial class DescriptionProblem : Form
    {
        public DescriptionProblem()
        {
            InitializeComponent();
            getInfo();
        }

        void getInfo()
        {
            String query = "Select ShoeAccounting.DescriptionOfTheProblem from ShoeAccounting where Id_ShoeAccounting = '" + NumberCheck.Number + "';";
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
                        string[] row = {rd.GetString(0)};
                        descrBox.Text = row[0];
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
