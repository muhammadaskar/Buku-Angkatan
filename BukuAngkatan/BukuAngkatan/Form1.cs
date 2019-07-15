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
    public partial class Form1 : Form
    {
        Buku buku;

        public Form1()
        {
            InitializeComponent();
        }

        private void bukuAngkatanFILKOMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buku = new Buku();
            buku.MdiParent = this;
            buku.Show();
        }
    }
}
