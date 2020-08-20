namespace Abdul_Latief_Fathoni_TB2_Data_Mahasiswa
{
    partial class abdul_latief_fathoni_nilai_mahasiswa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namamahasiswaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matakuliahDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nilaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abdullatieffathonitablenilaimahasiswaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new Abdul_Latief_Fathoni_TB2_Data_Mahasiswa.DataSet1();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCetak = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.tbNilai = new System.Windows.Forms.TextBox();
            this.tbMataKuliah = new System.Windows.Forms.TextBox();
            this.tbNamaMahasiswa = new System.Windows.Forms.TextBox();
            this.tbNim = new System.Windows.Forms.TextBox();
            this.abdul_latief_fathoni_table_nilai_mahasiswaTableAdapter = new Abdul_Latief_Fathoni_TB2_Data_Mahasiswa.DataSet1TableAdapters.abdul_latief_fathoni_table_nilai_mahasiswaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abdullatieffathonitablenilaimahasiswaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nimDataGridViewTextBoxColumn,
            this.namamahasiswaDataGridViewTextBoxColumn,
            this.matakuliahDataGridViewTextBoxColumn,
            this.nilaiDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.abdullatieffathonitablenilaimahasiswaBindingSource;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(800, 371);
            this.dataGridView.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nimDataGridViewTextBoxColumn
            // 
            this.nimDataGridViewTextBoxColumn.DataPropertyName = "nim";
            this.nimDataGridViewTextBoxColumn.HeaderText = "nim";
            this.nimDataGridViewTextBoxColumn.Name = "nimDataGridViewTextBoxColumn";
            // 
            // namamahasiswaDataGridViewTextBoxColumn
            // 
            this.namamahasiswaDataGridViewTextBoxColumn.DataPropertyName = "nama_mahasiswa";
            this.namamahasiswaDataGridViewTextBoxColumn.HeaderText = "nama_mahasiswa";
            this.namamahasiswaDataGridViewTextBoxColumn.Name = "namamahasiswaDataGridViewTextBoxColumn";
            // 
            // matakuliahDataGridViewTextBoxColumn
            // 
            this.matakuliahDataGridViewTextBoxColumn.DataPropertyName = "mata_kuliah";
            this.matakuliahDataGridViewTextBoxColumn.HeaderText = "mata_kuliah";
            this.matakuliahDataGridViewTextBoxColumn.Name = "matakuliahDataGridViewTextBoxColumn";
            // 
            // nilaiDataGridViewTextBoxColumn
            // 
            this.nilaiDataGridViewTextBoxColumn.DataPropertyName = "nilai";
            this.nilaiDataGridViewTextBoxColumn.HeaderText = "nilai";
            this.nilaiDataGridViewTextBoxColumn.Name = "nilaiDataGridViewTextBoxColumn";
            // 
            // abdullatieffathonitablenilaimahasiswaBindingSource
            // 
            this.abdullatieffathonitablenilaimahasiswaBindingSource.DataMember = "abdul_latief_fathoni_table_nilai_mahasiswa";
            this.abdullatieffathonitablenilaimahasiswaBindingSource.DataSource = this.dataSetBindingSource;
            // 
            // dataSetBindingSource
            // 
            this.dataSetBindingSource.DataSource = this.dataSet;
            this.dataSetBindingSource.Position = 0;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.label4);
            this.panelBottom.Controls.Add(this.label3);
            this.panelBottom.Controls.Add(this.label2);
            this.panelBottom.Controls.Add(this.label1);
            this.panelBottom.Controls.Add(this.btnCetak);
            this.panelBottom.Controls.Add(this.btnHapus);
            this.panelBottom.Controls.Add(this.btnSimpan);
            this.panelBottom.Controls.Add(this.btnTambah);
            this.panelBottom.Controls.Add(this.tbNilai);
            this.panelBottom.Controls.Add(this.tbMataKuliah);
            this.panelBottom.Controls.Add(this.tbNamaMahasiswa);
            this.panelBottom.Controls.Add(this.tbNim);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 370);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(800, 235);
            this.panelBottom.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nilai";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Mata Kuliah";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nama Mahasiswa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "NIM";
            // 
            // btnCetak
            // 
            this.btnCetak.Location = new System.Drawing.Point(479, 143);
            this.btnCetak.Name = "btnCetak";
            this.btnCetak.Size = new System.Drawing.Size(156, 23);
            this.btnCetak.TabIndex = 7;
            this.btnCetak.Text = "Cetak Data";
            this.btnCetak.UseVisualStyleBackColor = true;
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(479, 105);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(156, 23);
            this.btnHapus.TabIndex = 6;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(479, 68);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(156, 23);
            this.btnSimpan.TabIndex = 5;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(479, 30);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(156, 23);
            this.btnTambah.TabIndex = 4;
            this.btnTambah.Text = "Tambah Data";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // tbNilai
            // 
            this.tbNilai.Location = new System.Drawing.Point(158, 146);
            this.tbNilai.Name = "tbNilai";
            this.tbNilai.Size = new System.Drawing.Size(238, 20);
            this.tbNilai.TabIndex = 3;
            // 
            // tbMataKuliah
            // 
            this.tbMataKuliah.Location = new System.Drawing.Point(158, 105);
            this.tbMataKuliah.Name = "tbMataKuliah";
            this.tbMataKuliah.Size = new System.Drawing.Size(238, 20);
            this.tbMataKuliah.TabIndex = 2;
            // 
            // tbNamaMahasiswa
            // 
            this.tbNamaMahasiswa.Location = new System.Drawing.Point(158, 68);
            this.tbNamaMahasiswa.Name = "tbNamaMahasiswa";
            this.tbNamaMahasiswa.Size = new System.Drawing.Size(238, 20);
            this.tbNamaMahasiswa.TabIndex = 1;
            // 
            // tbNim
            // 
            this.tbNim.Location = new System.Drawing.Point(158, 30);
            this.tbNim.Name = "tbNim";
            this.tbNim.Size = new System.Drawing.Size(238, 20);
            this.tbNim.TabIndex = 0;
            // 
            // abdul_latief_fathoni_table_nilai_mahasiswaTableAdapter
            // 
            this.abdul_latief_fathoni_table_nilai_mahasiswaTableAdapter.ClearBeforeFill = true;
            // 
            // abdul_latief_fathoni_nilai_mahasiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 605);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.dataGridView);
            this.Name = "abdul_latief_fathoni_nilai_mahasiswa";
            this.Text = "Nilai Mahasiswa";
            this.Load += new System.EventHandler(this.abdul_latief_fathoni_nilai_mahasiswa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abdullatieffathonitablenilaimahasiswaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.BindingSource dataSetBindingSource;
        private DataSet1 dataSet;
        private System.Windows.Forms.Panel panelBottom;
        private DataSet1TableAdapters.abdul_latief_fathoni_table_nilai_mahasiswaTableAdapter abdul_latief_fathoni_table_nilai_mahasiswaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namamahasiswaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matakuliahDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nilaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource abdullatieffathonitablenilaimahasiswaBindingSource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCetak;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.TextBox tbNilai;
        private System.Windows.Forms.TextBox tbMataKuliah;
        private System.Windows.Forms.TextBox tbNamaMahasiswa;
        private System.Windows.Forms.TextBox tbNim;
    }
}

