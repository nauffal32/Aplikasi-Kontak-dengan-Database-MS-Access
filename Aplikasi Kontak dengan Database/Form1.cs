using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace Aplikasi_Kontak_dengan_Database
{
    public partial class Form1 : Form
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Mystogan\Documents\kosnigel.accdb");

        int checker;
        Bitmap bitmap;
        public Form1()
        {
            InitializeComponent();
        }

        void dataviewer()
        {
            try
            {
                conn.Open();
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from kosnigel";                    
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter dp = new OleDbDataAdapter(cmd);
                dp.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataviewer();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            try
            {

                conn.Open();
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into kosnigel(NomorKamar, NamaDepan, NamaBelakang, Alamat, Pekerjaan, Telepon)values('" + txtNomorKamar.Text + "', '" + txtNamaDepan.Text + "','" +
                    txtNamaBelakang.Text + "', '" + txtAlamat.Text + "', '" + txtPekerjaan.Text + "', '" + txtTelepon.Text + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Telah Disimpan", "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
                dataviewer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                e.Graphics.DrawImage(bitmap, 0, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            dataviewer();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Apakah ingin keluar aplikasi?", "Access Connect", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnPerbarui_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update kosnigel set NomorKamar='" + txtNomorKamar.Text + "' where NamaDepan = '" + txtNamaDepan.Text + 
                    "' and NamaBelakang = '" + txtNamaBelakang.Text +"'";
                cmd.ExecuteNonQuery();               
                conn.Close();
                MessageBox.Show("Data telah diperbarui", "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataviewer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtNomorKamar.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                txtNamaDepan.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txtNamaBelakang.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                txtAlamat.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                txtPekerjaan.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                txtTelepon.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete* from kosnigel where NomorKamar='" + txtNomorKamar.Text + "'";
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Data telah dihapus", "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataviewer();
                
                txtNomorKamar.Text = "";
                txtNamaDepan.Text = "";
                txtNamaBelakang.Text = "";
                txtAlamat.Text = "";
                txtPekerjaan.Text = "";
                txtTelepon.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dataviewer();

            txtNomorKamar.Text = "";
            txtNamaDepan.Text = "";
            txtNamaBelakang.Text = "";
            txtAlamat.Text = "";
            txtPekerjaan.Text = "";
            txtTelepon.Text = "";
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            checker = 0;
            try
            {
                conn.Open();
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from kosnigel where NomorKamar = '" + txtCari.Text + "' or NamaDepan = '" + txtCari.Text + "' or NamaBelakang = '" + txtCari.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter dp = new OleDbDataAdapter(cmd);
                dp.Fill(dt);
                checker = Convert.ToInt32(dt.Rows.Count.ToString());
                dataGridView1.DataSource = dt;
                conn.Close();
                if (checker == 0)
                {
                    MessageBox.Show("Data tidak ditemukan", "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCari.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                int heigt = dataGridView1.Height;
                dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height * 2;
                bitmap = new Bitmap(dataGridView1.Width, dataGridView1.Height);
                dataGridView1.DrawToBitmap(bitmap, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
                printPreviewDialog1.PrintPreviewControl.Zoom = 1;
                printPreviewDialog1.ShowDialog();
                dataGridView1.Height = Height;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Access Connect", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
