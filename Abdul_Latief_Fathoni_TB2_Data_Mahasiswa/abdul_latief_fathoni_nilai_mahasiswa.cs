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
        int abdul_latief_fathoni_var_mhsID = 0;

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
            abdul_latief_fathoni_var_mhsID = 0;
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
                if (abdul_latief_fathoni_var_mhsID > 0)
                {
                    // run query update
                    this.table_nilai_mahasiswaTableAdapter.Update(tbNim.Text, tbNamaMahasiswa.Text, tbMataKuliah.Text, Int32.Parse(tbNilai.Text), abdul_latief_fathoni_var_mhsID, abdul_latief_fathoni_var_mhsID);
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

            abdul_latief_fathoni_var_mhsID = Convert.ToInt32(row.Cells[0].Value.ToString());

            if (abdul_latief_fathoni_var_mhsID > 0)
            {
                abdul_latief_fathoni_enable_textbox(true);

                tbNim.Text = row.Cells[1].Value.ToString();
                tbNamaMahasiswa.Text = row.Cells[2].Value.ToString();
                tbMataKuliah.Text = row.Cells[3].Value.ToString();
                tbNilai.Text = row.Cells[4].Value.ToString();
                
                btnSimpan.Text = "Update";
                btnSimpan.Enabled = true;
                btnHapus.Enabled = true;
                btnCetak.Enabled = true;
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure want to delete it?", "Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    this.table_nilai_mahasiswaTableAdapter.Delete(Convert.ToInt32(abdul_latief_fathoni_var_mhsID));
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

        private void btnCetak_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            if(printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("NIM : " + tbNim.Text, new Font("Arial", 12), Brushes.Black, 90, 140);
            e.Graphics.DrawString("Nama Mahasiswa : " + tbNamaMahasiswa.Text, new Font("Arial", 12), Brushes.Black, 90, 160);
            e.Graphics.DrawString("Mata Kuliah : " + tbMataKuliah.Text, new Font("Arial", 12), Brushes.Black, 90, 180);
            e.Graphics.DrawString("Nilai : " + tbNilai.Text, new Font("Arial", 12), Brushes.Black, 90, 200);
        }
    }
}