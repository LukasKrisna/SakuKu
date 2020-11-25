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
    public partial class Form1 : Form
    {
        OleDbConnection connection = new OleDbConnection();

        public Form1()
        {
            InitializeComponent();
            koneksi kon = new koneksi();
            connection.ConnectionString = kon.con;
        }

        string query;

        #region Load
        private void Form1_Load(object sender, EventArgs e)
        {
            dGV.Rows.Clear();
            GetData();
        }
        #endregion

        #region Get Data
        private void GetData()
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            query = "select * from peminjaman";
            command.CommandText = query;

            OleDbDataAdapter da = new OleDbDataAdapter(command);
            DataSet ds = new DataSet();
            da.Fill(ds);

            int cnt = ds.Tables[0].Rows.Count;
            dGV.Rows.Add(cnt);

            int no = 0;

            for (int i = 0; i < cnt; i++)
            {
                no = no + 1;
                DataRow row = ds.Tables[0].Rows[i];
                dGV.Rows[i].Cells[0].Value = no.ToString();
                dGV.Rows[i].Cells[1].Value = row.ItemArray.GetValue(0).ToString();
                dGV.Rows[i].Cells[2].Value = row.ItemArray.GetValue(1).ToString();
                dGV.Rows[i].Cells[3].Value = row.ItemArray.GetValue(2).ToString();
                dGV.Rows[i].Cells[4].Value = Convert.ToDateTime(row.ItemArray.GetValue(3).ToString()).ToString("dd MMMM yyyy");
                dGV.Rows[i].Cells[5].Value = row.ItemArray.GetValue(4).ToString();
                dGV.Rows[i].Cells[6].Value = row.ItemArray.GetValue(5).ToString();
                dGV.Rows[i].Cells[7].Value = row.ItemArray.GetValue(6).ToString();
            }

            connection.Close();
        }
        #endregion

        #region Add Data
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                query = "INSERT INTO `peminjaman` (`nama`, `tmpt lahir`, `tgl lahir`, `jenis kelamin`, `alamat`, `telepon`, `jumlah uang`)" +
                "VALUES ('" + txtNama.Text.ToUpper() + "', '" + txtTempatLahir.Text.ToUpper() + "', '" + dtpTanggal.Value.ToString("dd/MM/yyyy") + "', '" + cmbJK.Text.ToUpper() + "', '" + txtAlamat.Text.ToUpper() + "', '" + txtTelp.Text.ToUpper() + "','" + txtJumlahUang.Text.ToUpper() +"');";
                command.CommandText = query;

                command.ExecuteNonQuery();
                MessageBox.Show("ADD Data Success");
                connection.Close();

                txtNama.Clear();
                txtTempatLahir.Clear();
                dtpTanggal.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
                cmbJK.Text = "LAKI - LAKI";
                txtAlamat.Clear();
                txtTelp.Clear();
                txtJumlahUang.Clear();

                dGV.Rows.Clear();
                GetData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString());
            }
        }
        #endregion

        #region Edit Data
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                query = "UPDATE `peminjaman` SET nama ='" + txtNama.Text.ToUpper() + "', tmpt lahir ='" + txtTempatLahir.Text.ToUpper() + "', tgl lahir ='" + dtpTanggal.Value.ToString("dd/MM/yyyy") + "'," +
                "jenis kelamin ='" + cmbJK.Text.ToUpper() + "', alamat ='" + txtAlamat.Text.ToUpper() + "', telepon ='" + txtTelp.Text.ToUpper() + "', jumlah uang ='" + txtJumlahUang.Text.ToUpper() + "' WHERE nama = '" + txtNama.Text.ToUpper() + "';";
                command.CommandText = query;

                command.ExecuteNonQuery();
                MessageBox.Show("EDIT Data Success");
                connection.Close();

                txtNama.Clear();
                txtTempatLahir.Clear();
                dtpTanggal.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
                cmbJK.Text = "LAKI - LAKI";
                txtAlamat.Clear();
                txtTelp.Clear();
                txtJumlahUang.Clear();

                dGV.Rows.Clear();
                GetData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString());
            }
        }
        #endregion

        #region Delete Data
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                query = "DELETE FROM peminjaman WHERE nama = '" + txtNama.Text.ToUpper() + "';";
                command.CommandText = query;

                command.ExecuteNonQuery();
                MessageBox.Show("DELETE Data Success");
                connection.Close();

                
                txtNama.Clear();
                txtTempatLahir.Clear();
                dtpTanggal.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
                cmbJK.Text = "LAKI - LAKI";
                txtAlamat.Clear();
                txtTelp.Clear();
                txtJumlahUang.Clear();

                dGV.Rows.Clear();
                GetData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString());
            }
        }
        #endregion

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}