using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BukuAngkatan
{
    public partial class Buku : Form
    {
        public MySqlConnection koneksi;
        public String koneksiString;

        mBuku buku;

        public Buku()
        {
            InitializeComponent();
        }

        private void buttonCekKoneksi_Click(object sender, EventArgs e)
        {
            buku = new mBuku();
            buku.cekKoneksi();
        }

        private void buttonTampilData_Click(object sender, EventArgs e)
        {
            buku = new mBuku();
            buku.tampil(dgMhs);
        }

        private void Buku_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            buku = new mBuku();
            buku.tambah(textBoxNim, textBoxNama, textBoxJk, textBoxProdi);
            buku.tampil(dgMhs);
        }

        private void dgMhs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            buku = new mBuku();
            buku.ClickGrid(e, dgMhs, textBoxNim, textBoxNama, textBoxJk, textBoxProdi);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            buku = new mBuku();
            buku.Edit(textBoxNim, textBoxNama, textBoxJk, textBoxProdi);
            buku.tampil(dgMhs);
        }
         
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            buku = new mBuku();
            buku.Hapus(textBoxNim, textBoxNama, textBoxJk, textBoxProdi);
            buku.tampil(dgMhs);
        }
    }
}
