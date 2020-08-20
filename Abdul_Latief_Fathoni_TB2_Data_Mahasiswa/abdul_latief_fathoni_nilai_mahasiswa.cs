using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abdul_Latief_Fathoni_TB2_Data_Mahasiswa
{
    public partial class abdul_latief_fathoni_nilai_mahasiswa : Form
    {
        public abdul_latief_fathoni_nilai_mahasiswa()
        {
            InitializeComponent();
        }

        public void LoadGridView()
        {
            this.table_nilai_mahasiswaTableAdapter.Fill(this.dataSet.table_nilai_mahasiswa);

        }

        public void CelarTextBox()
        {
            tbNim.Clear();
            tbNamaMahasiswa.Clear();
            tbMataKuliah.Clear();
            tbNilai.Clear();
        }

        private void abdul_latief_fathoni_nilai_mahasiswa_Load(object sender, EventArgs e)
        {
            LoadGridView();

            btnSimpan.Enabled = false;
            btnHapus.Enabled = false;
            btnCetak.Enabled = false;

            tbNim.Enabled = false;
            tbNamaMahasiswa.Enabled = false;
            tbMataKuliah.Enabled = false;
            tbNilai.Enabled = false;

            if (this.Tag == null)
            {
                MessageBox.Show("ada tag nya");
            }

        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            tbNim.Enabled = true;
            tbNamaMahasiswa.Enabled = true;
            tbMataKuliah.Enabled = true;
            tbNilai.Enabled = true;
            btnSimpan.Enabled = true;

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                this.table_nilai_mahasiswaTableAdapter.Insert(tbNim.Text, tbNamaMahasiswa.Text, tbMataKuliah.Text, Int32.Parse(tbNilai.Text));
                MessageBox.Show("Data has been saved");

                LoadGridView();
                CelarTextBox();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void onCellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}