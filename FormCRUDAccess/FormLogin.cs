using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace FormCRUDAccess
{
    public partial class FormLogin : Form
    {
        OleDbConnection connection = new OleDbConnection();
        public FormLogin()
        {
            InitializeComponent();
            koneksi kon = new koneksi();
            connection.ConnectionString = kon.con;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            string perintah = "select count (*) from Login where Username='" + text_Username.Text + "'and Password='" + text_Password.Text + "'";

            OleDbDataAdapter da = new OleDbDataAdapter(perintah, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                connection.Close();
                connection.Dispose();
                this.Hide();
                Form2 MU = new Form2();
                MU.ShowDialog();
            }
            else
            {
                MessageBox.Show("Username or password is incorrect try again..");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            connection.Close();
            connection.Dispose();
            this.Hide();
            FormRegister Register = new FormRegister();
            Register.ShowDialog();
        }
    }
}
