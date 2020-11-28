using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Mysql_Form_2
{
    public partial class Form1 : Form
    {
        MySqlConnection con = new MySqlConnection(Constanta.conString);
        MySqlCommand com;
        MySqlDataAdapter adp;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            RancangDataGrid();            
        }


        void RancangDataGrid()
        {
            dgv_data.ColumnCount = 7;
            dgv_data.Columns[0].Name = "npm";
            dgv_data.Columns[1].Name = "nama";
            dgv_data.Columns[2].Name = "alamat";
            dgv_data.Columns[3].Name = "jk";
            dgv_data.Columns[4].Name = "hp";
            dgv_data.Columns[5].Name = "asalsma";
            dgv_data.Columns[6].Name = "umur";

            //dgv_data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_data.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgv_data.AllowUserToAddRows = false;
            dgv_data.AllowUserToDeleteRows = false;
            dgv_data.AllowUserToResizeRows = false;
            dgv_data.AllowUserToResizeColumns = false;
            dgv_data.AllowUserToOrderColumns = false;
            dgv_data.ReadOnly = true;
            dgv_data.MultiSelect = false;
        }

        void TuruninData()
        {
            dgv_data.Rows.Clear();

            string query = "SELECT * FROM m_student";
            com = new MySqlCommand(query, con);

            try
            {
                con.Open();

                adp = new MySqlDataAdapter(com);
                DataTable dt = new DataTable();
                adp.Fill(dt);

                foreach (DataRow item in dt.Rows)
                {
                    dgv_data.Rows.Add(
                        item[0].ToString(),
                        item[1].ToString(),
                        item[2].ToString(),
                        item[3].ToString(),
                        item[4].ToString(),
                        item[5].ToString(),
                        item[6].ToString()
                        );
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("_ERROR: " + ex.Message);
            }

            txtbox_npm.ReadOnly = true;
        }

        private void dgv_data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string _npm = dgv_data.SelectedRows[0].Cells[0].Value.ToString();
            string _nama = dgv_data.SelectedRows[0].Cells[1].Value.ToString();
            string _alamat = dgv_data.SelectedRows[0].Cells[2].Value.ToString();
            string _jk = dgv_data.SelectedRows[0].Cells[3].Value.ToString();
            string _hp = dgv_data.SelectedRows[0].Cells[4].Value.ToString();
            string _asalsma = dgv_data.SelectedRows[0].Cells[5].Value.ToString();
            string _umur = dgv_data.SelectedRows[0].Cells[6].Value.ToString();

            txtbox_npm.Text = _npm;
            txtbox_nama.Text = _nama;
            richTextBox1.Text = _alamat;
            comboBox1.SelectedItem = _jk;
            txtbox_nohp.Text = _hp;
            txtbox_asalsma.Text = _asalsma;
            txtbox_umur.Text = _umur;
        }

        void ClearData()
        {
            txtbox_npm.Clear();
            txtbox_nama.Clear();
            richTextBox1.Clear();
            comboBox1.SelectedIndex = -1;
            txtbox_nohp.Clear();
            txtbox_asalsma.Clear();
            txtbox_umur.Clear();
        }

        private void btn_showdata_Click(object sender, EventArgs e)
        {
            TuruninData();            
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            txtbox_npm.ReadOnly = false;
            ClearData();
        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            //1
            txtbox_npm.ReadOnly = true;
            //2
            TambahDataKeDB(
                txtbox_npm.Text,
                txtbox_nama.Text,
                richTextBox1.Text,
                comboBox1.SelectedItem.ToString(),
                txtbox_nohp.Text,
                txtbox_asalsma.Text,
                txtbox_umur.Text);
            //3
            ClearData();

            //4
            TuruninData();
        }

        private void TambahDataKeDB(string _npm,
            string _nama, 
            string _alamat,
            string _jk,
            string _hp, 
            string _sma,
            string _umur)
        {
            string query = "INSERT INTO m_student(npm, nama, alamat, jk, nomorkontak, asalsma, umur) VALUES ('" + _npm + "','" + _nama + "','" + _alamat + "','" + _jk + "','" + _hp + "','" + _sma + "','" + _umur + "')";
            com = new MySqlCommand(query, con);

            try
            {
                con.Open();

                if( com.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("data has been inputed to DB");
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void HapusData(string _npm)
        {
            string query = "DELETE FROM m_student WHERE npm = '" + _npm + "'";
            com = new MySqlCommand(query, con);

            try
            {
                con.Open();

                if (com.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Data dengan NPM " + _npm + 
                        " Telah Berhasil Dihapus dari DB");
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_hapus_Click(object sender, EventArgs e)
        {
            //
            HapusData(txtbox_npm.Text);

            // 
            TuruninData();

            // 
            ClearData();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            if( MessageBox.Show(
                "Apakah anda yakin akan mengubah data pada NPM "+txtbox_npm.Text+"?", 
                "SIM Akademik", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //
                MengubahData(
                    txtbox_npm.Text,
                    txtbox_nama.Text,
                    richTextBox1.Text,
                    comboBox1.SelectedItem.ToString(),
                    txtbox_nohp.Text,
                    txtbox_asalsma.Text,
                    txtbox_umur.Text);
                //
                TuruninData();
                //
                ClearData();
            }            
        }

        void MengubahData(string _npm,
            string _nama,
            string _alamat,
            string _jk,
            string _hp,
            string _asalsma,
            string _umur)
        {
            string query = "UPDATE m_student SET nama='" + _nama + "', alamat='" + _alamat + "', jk='" + _jk + "',nomorkontak='" + _hp + "',asalsma='" + _asalsma + "',umur='" + _umur + "' WHERE npm = '" + _npm + "'";
            com = new MySqlCommand(query, con);

            try
            {
                con.Open();

                if (com.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Data dengan NPM " + _npm +
                        " Telah Berhasil Diubah dari DB");
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
