using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 Ubah Nama variabel textBoxJk dan textBoxProdi menjadi comboBox
     */

namespace BukuAngkatan
{
    class mBuku
    {
        public MySqlConnection koneksi;
        public String koneksiString;
        //private bool CekKondisi = false;

        public mBuku()
        {
            koneksiString = "server=localhost; uid=root; pwd=; " +
                "database=buku_angkatan; persistsecurityinfo=True; SslMode=none;";
        }

        public void cekKoneksi()
        {
            //config();
            try
            {
                koneksi = new MySqlConnection();
                koneksi.ConnectionString = koneksiString;
                koneksi.Open();
                MessageBox.Show("Database Telah Terkoneksi");
                koneksi.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Gagal Terkoneksi" +"\n"
                    +ex);
            }
        }

        /*----------------------
         |        TAMPIL        |
         ----------------------*/
        public void tampil(DataGridView dgMhs)
        {
            // config();
            koneksi = new MySqlConnection();
            koneksi.ConnectionString = koneksiString;
            koneksi.Open();

            String sql = "SELECT * FROM mhs_filkom ORDER BY nama";
            MySqlCommand cmd = new MySqlCommand(sql, koneksi);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dgMhs.DataSource = dt;
            koneksi.Close();
        }

        /*----------------------
         |        TAMBAH       |
         ----------------------*/
        public void tambah(TextBox textBoxNim, TextBox textBoxNama, ComboBox textBoxJk, ComboBox textBoxProdi)
        {

            /*if ((textBoxNim.Text == "") && textBoxNama.Text == "" && (textBoxJk.Text == "") && (textBoxProdi.Text == ""))
            {
                MessageBox.Show("Data Harus Diisi");
            }
            else if ((textBoxNim.Text == ""))
            {
                MessageBox.Show("NIM Harus Diisi");
            }
            else if (textBoxNim.TextLength <= 15)
            {
                MessageBox.Show("Nim Tidak Sesuai");
            }
            else if (textBoxNama.Text == "")
            {
                MessageBox.Show("Nama Harus Diisi");
            }
            else if (textBoxProdi.Text == "")
            {
                MessageBox.Show("Program Studi Harus Diisi");
            }*/

            // else
            // {
            try // mengecek apakah terjadi eksepsi, jika tidak maka proses pada catch tidak akan dijalankan
                {
                    this.koneksi = new MySqlConnection();
                    this.koneksi.ConnectionString = koneksiString;
                    koneksi.Open();
                    String sql = "INSERT INTO mhs_filkom VALUES (@nim, @nama, @Jk, @prodi)";
                    MySqlCommand cmd = new MySqlCommand(sql, koneksi);

                    cmd.Parameters.AddWithValue("@nim", textBoxNim.Text);
                    cmd.Parameters.AddWithValue("@nama", textBoxNama.Text);
                    cmd.Parameters.AddWithValue("@Jk", textBoxJk.Text);
                    cmd.Parameters.AddWithValue("@prodi", textBoxProdi.Text);
                    //MySqlDataReader dr = cmd.ExecuteReader();

                    cmd.ExecuteNonQuery(); // melakukan eksekusi menggunak nonQuery
                    textBoxNim.Text = "";
                    textBoxNama.Text = "";
                    textBoxJk.Text = "";
                    textBoxProdi.Text = "";
                    koneksi.Close();
                }
                catch (MySqlException ex) // Jika Terjadi Eksepsi pada data
                {
                    MessageBox.Show(""+ex); // maka akan menampilkan messagebox
                }




        }

        /*----------------------
         |        EDIT        |
         ----------------------*/
        public void Edit(TextBox textBoxNim, TextBox textBoxNama, ComboBox textBoxJk, ComboBox textBoxProdi)
        {
            koneksi = new MySqlConnection();
            koneksi.ConnectionString = koneksiString;
            koneksi.Open();

            String sql = "UPDATE mhs_filkom SET nim=@nim, nama=@nama, jenis_kelamin=@Jk, prodi=@prodi WHERE nim=@nim";
            MySqlCommand cmd = new MySqlCommand(sql, koneksi);

            cmd.Parameters.AddWithValue("@nim", textBoxNim.Text);
            cmd.Parameters.AddWithValue("@nama", textBoxNama.Text);
            cmd.Parameters.AddWithValue("@Jk", textBoxJk.Text);
            cmd.Parameters.AddWithValue("@prodi", textBoxProdi.Text);

            MessageBox.Show("Data Berhasil Diubah");

            cmd.ExecuteNonQuery();
            koneksi.Close();

            textBoxNim.Text = "";
            textBoxNama.Text = "";
            textBoxJk.Text = "";
            textBoxProdi.Text = "";
        }

        /*----------------------
         |        HAPUS        |
         ----------------------*/

        public void Hapus(TextBox textBoxNim, TextBox textBoxNama, ComboBox textBoxJk, ComboBox textBoxProdi)
        {
            Buku buku = new Buku();
            koneksi = new MySqlConnection();
            koneksi.ConnectionString = koneksiString;
            DataGridView dgMhs = new DataGridView();
            // Menampilkan Pesan Pilihan dialog dengan 2 pilihan
            DialogResult dialogPilihan = MessageBox.Show("Apakah Anda Yakin Ingin Menghapus Data ?",
                "Pilih", MessageBoxButtons.YesNo);

            /*if ((textBoxNim.Text == "") && textBoxNama.Text == "" && (textBoxJk.Text == "") && (textBoxProdi.Text == ""))
            {
                MessageBox.Show("Data Yang Anda Pilih Tidak Ada");
            }*/

            if (dialogPilihan == DialogResult.Yes) // jika dialogPilihan sama dengan Yes
            {
                koneksi.Open();
                String sql = "DELETE FROM mhs_filkom WHERE nim = @nim";
                MySqlCommand cmd = new MySqlCommand(sql, koneksi);

                cmd.Parameters.AddWithValue("@nim", textBoxNim.Text);

                MessageBox.Show("Data Berhasil Dihapus");

                cmd.ExecuteNonQuery();
                koneksi.Close();

                textBoxNim.Text = "";
                textBoxNama.Text = "";
                textBoxJk.Text = "";
                textBoxProdi.Text = "";

            }
            else if (dialogPilihan == DialogResult.No) // jika dialogPilihan sama dengan No
            {
                tampil(dgMhs); // menampilkan kembali data mahasiswa
            }

        }

        public void ClickGrid(DataGridViewCellEventArgs e, DataGridView dgMhs, TextBox textBoxNim,
                                 TextBox textBoxNama, ComboBox textBoxJk, ComboBox textBoxProdi)
        {
            DataGridViewRow dtRow = dgMhs.Rows[e.RowIndex];

            textBoxNim.Text = dtRow.Cells["nim"].Value.ToString();
            textBoxNama.Text = dtRow.Cells["nama"].Value.ToString();
            textBoxJk.Text = dtRow.Cells["jenis_kelamin"].Value.ToString();
            textBoxProdi.Text = dtRow.Cells["prodi"].Value.ToString();
        }

    }
}
