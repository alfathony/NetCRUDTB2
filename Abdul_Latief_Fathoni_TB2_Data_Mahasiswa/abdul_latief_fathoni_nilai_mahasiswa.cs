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

        private void abdul_latief_fathoni_nilai_mahasiswa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet.abdul_latief_fathoni_table_nilai_mahasiswa' table. You can move, or remove it, as needed.
            this.abdul_latief_fathoni_table_nilai_mahasiswaTableAdapter.Fill(this.dataSet.abdul_latief_fathoni_table_nilai_mahasiswa);

            btnSimpan.Enabled = false;
            btnHapus.Enabled = false;
            btnCetak.Enabled = false;

            tbNim.Enabled = false;
            tbNamaMahasiswa.Enabled = false;
            tbMataKuliah.Enabled = false;
            tbNilai.Enabled = false;

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
                this.abdul_latief_fathoni_table_nilai_mahasiswaTableAdapter.Insert(5 ,Decimal.Parse(tbNim.Text), tbNamaMahasiswa.Text, tbMataKuliah.Text, Int32.Parse(tbNilai.Text));
                MessageBox.Show("Data has been saved");
                dataGridView.Refresh();
         
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}