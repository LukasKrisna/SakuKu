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
    public partial class Form3 : Form
    {
        OleDbConnection connection = new OleDbConnection();

        string query;

        public Form3()
        {
            InitializeComponent();
            koneksi kon = new koneksi();
            connection.ConnectionString = kon.con;
        }
        private void getData()
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            query = "select * from tabungan";
            command.CommandText = query;

            OleDbDataAdapter da = new OleDbDataAdapter(command);
            DataSet ds = new DataSet();
            da.Fill(ds);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                query = "INSERT INTO `tabungan` (`nama`, `tmpt lahir`, `tgl lahir`, `jenis kelamin`, `alamat`, `telepon`, `jumlah uang`)" +
                "VALUES ('" + txtNama.Text.ToUpper() + "', '" + txtTempatLahir.Text.ToUpper() + "', '" + dtpTanggal.Value.ToString("dd/MM/yyyy") + "', '" + cmbJK.Text.ToUpper() + "', '" + txtAlamat.Text.ToUpper() + "', '" + txtTelp.Text.ToUpper() + "','" + txtJumlahUang.Text.ToUpper() + "');";
                command.CommandText = query;

                command.ExecuteNonQuery();
                MessageBox.Show("Tabungan berhasil ditambahkan!");
                connection.Close();

                txtNama.Clear();
                txtTempatLahir.Clear();
                dtpTanggal.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
                cmbJK.Text = "LAKI - LAKI";
                txtAlamat.Clear();
                txtTelp.Clear();
                txtJumlahUang.Clear();

                
                getData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbJK_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtJumlahUang_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtAlamat_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelp_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTempatLahir_TextChanged(object sender, EventArgs e)
        {

        }

        private void label99_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dtpTanggal_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
