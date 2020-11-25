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
    public partial class FormRegister : Form
    {
        OleDbConnection connection = new OleDbConnection();

        public FormRegister()
        {
            InitializeComponent();
            koneksi kon = new koneksi();
            connection.ConnectionString = kon.con;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            connection.Open();
            String perintah = "INSERT INTO Login (Username,Password)values('" + txtUsername.Text + "','" + txtPassword.Text + "')";
            OleDbCommand cmd = new OleDbCommand(perintah, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
            connection.Dispose();
            this.Hide();
            Form2 MU = new Form2();
            MU.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Close();
            connection.Dispose();
            this.Hide();
            FormLogin Login = new FormLogin();
            Login.ShowDialog();
        }
    }
}
