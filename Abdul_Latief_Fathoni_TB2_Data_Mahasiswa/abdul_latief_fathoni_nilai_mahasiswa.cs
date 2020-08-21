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
        int mahasiswaID = 0;

        public abdul_latief_fathoni_nilai_mahasiswa()
        {
            InitializeComponent();
        }

        public void abdul_latief_fathoni_load_data_grid()
        {
            this.table_nilai_mahasiswaTableAdapter.Fill(this.dataSet.table_nilai_mahasiswa);

        }

        private void abdul_latief_fathoni_nilai_mahasiswa_Load(object sender, EventArgs e)
        {
            abdul_latief_fathoni_load_data_grid();

            btnSimpan.Enabled = false;
            btnHapus.Enabled = false;
            btnCetak.Enabled = false;

            abdul_latief_fathoni_enable_textbox(false);

            id_label.Text = mahasiswaID.ToString();
        }

        public void abdul_latief_fathoni_clear_textbox()
        {
            tbNim.Clear();
            tbNamaMahasiswa.Clear();
            tbMataKuliah.Clear();
            tbNilai.Clear();
        }

        public void abdul_latief_fathoni_enable_textbox(Boolean val)
        {
            tbNim.Enabled = val;
            tbNamaMahasiswa.Enabled = val;
            tbMataKuliah.Enabled = val;
            tbNilai.Enabled = val;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            mahasiswaID = 0;
            abdul_latief_fathoni_enable_textbox(true);
            abdul_latief_fathoni_clear_textbox();
            btnSimpan.Text = "Simpan";
            btnSimpan.Enabled = true;
            btnHapus.Enabled = false;

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (mahasiswaID > 0)
                {
                    // run query update
                    this.table_nilai_mahasiswaTableAdapter.Update(tbNim.Text, tbNamaMahasiswa.Text, tbMataKuliah.Text, Int32.Parse(tbNilai.Text), mahasiswaID, mahasiswaID);
                }
                else
                {
                    // run query insert
                    this.table_nilai_mahasiswaTableAdapter.Insert(tbNim.Text, tbNamaMahasiswa.Text, tbMataKuliah.Text, Int32.Parse(tbNilai.Text));
                }

                MessageBox.Show("Data has been saved");

                abdul_latief_fathoni_load_data_grid();
                abdul_latief_fathoni_clear_textbox();
                abdul_latief_fathoni_enable_textbox(false);
                btnSimpan.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void onCellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView.Rows[rowIndex];

            mahasiswaID = Convert.ToInt32(row.Cells[0].Value.ToString());
            id_label.Text = mahasiswaID.ToString();

            if (mahasiswaID > 0)
            {
                abdul_latief_fathoni_enable_textbox(true);

                tbNim.Text = row.Cells[1].Value.ToString();
                tbNamaMahasiswa.Text = row.Cells[2].Value.ToString();
                tbMataKuliah.Text = row.Cells[3].Value.ToString();
                tbNilai.Text = row.Cells[4].Value.ToString();
                
                btnSimpan.Text = "Update";
                btnSimpan.Enabled = true;
                btnHapus.Enabled = true;
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure want to delete it?", "Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    this.table_nilai_mahasiswaTableAdapter.Delete(Convert.ToInt32(mahasiswaID));
                    abdul_latief_fathoni_load_data_grid();
                    abdul_latief_fathoni_clear_textbox();
                    abdul_latief_fathoni_enable_textbox(false);
                    btnSimpan.Text = "Simpan";
                    btnSimpan.Enabled = false;
                    btnHapus.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}