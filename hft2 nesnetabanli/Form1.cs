using System;
using System.Data;
using System.Windows.Forms;

namespace hft2_nesnetabanli
{
    public partial class Form1 : Form
    {
        // SQL veritabanı yerine verileri bellekte tutan sanal tablo
        DataTable dt = new DataTable();
        int idSayac = 1;

        public Form1()
        {
            InitializeComponent();

            // Olay bağlantılarını Form açılırken kod içerisinden zorla kuruyoruz
            this.Load += Form1_Load;

            // Önceki bağlantıları temizleyip yeniden ekleyerek çakışmayı önlüyoruz
            btnadd.Click -= btnadd_Click;
            btnadd.Click += btnadd_Click;

            btndelete.Click -= btndelete_Click;
            btndelete.Click += btndelete_Click;

            btnupdate.Click -= btnupdate_Click;
            btnupdate.Click += btnupdate_Click;

            dataGridView1.CellClick -= dataGridView1_CellClick;
            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Eğer sütunlar önceden eklenmediyse ekliyoruz
            if (dt.Columns.Count == 0)
            {
                dt.Columns.Add("Id", typeof(int));
                dt.Columns.Add("Ad", typeof(string));
                dt.Columns.Add("Soyad", typeof(string));
                dt.Columns.Add("Eposta", typeof(string));
            }

            dataGridView1.DataSource = dt;

            // Örnek Başlangıç Verileri
            if (dt.Rows.Count == 0)
            {
                dt.Rows.Add(idSayac++, "Ahmet", "Yılmaz", "ahmet@gmail.com");
                dt.Rows.Add(idSayac++, "Ayşe", "Kaya", "ayse@gmail.com");
            }
        }

        private void Temizle()
        {
            txtad.Clear();
            txtsoyad.Clear();
            txtmail.Clear();
            dataGridView1.ClearSelection();
        }

        // EKLE
        private void btnadd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtad.Text))
            {
                MessageBox.Show("Lütfen Ad alanını doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Doğrudan sanal tabloya ekleme yapıp görünümü tazeliyoruz
            dt.Rows.Add(idSayac++, txtad.Text.Trim(), txtsoyad.Text.Trim(), txtmail.Text.Trim());
            dataGridView1.Refresh();

            Temizle();
        }

        // SİL
        private void btndelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null && !dataGridView1.CurrentRow.IsNewRow)
            {
                int seciliIndeks = dataGridView1.CurrentRow.Index;
                if (seciliIndeks >= 0 && seciliIndeks < dt.Rows.Count)
                {
                    dt.Rows.RemoveAt(seciliIndeks);
                    dataGridView1.Refresh();
                    Temizle();
                }
            }
            else
            {
                MessageBox.Show("Lütfen tablodan silinecek bir kişi seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // GÜNCELLE
        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null && !dataGridView1.CurrentRow.IsNewRow)
            {
                int seciliIndeks = dataGridView1.CurrentRow.Index;
                if (seciliIndeks >= 0 && seciliIndeks < dt.Rows.Count)
                {
                    dt.Rows[seciliIndeks]["Ad"] = txtad.Text.Trim();
                    dt.Rows[seciliIndeks]["Soyad"] = txtsoyad.Text.Trim();
                    dt.Rows[seciliIndeks]["Eposta"] = txtmail.Text.Trim();

                    dataGridView1.Refresh();
                    Temizle();
                }
            }
            else
            {
                MessageBox.Show("Lütfen tablodan güncellenecek bir kişi seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // TABLODAN SEÇİLEN KİŞİYİ TEXTBOX'LARA AKTARMA
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dt.Rows.Count)
            {
                DataRow seciliSatir = dt.Rows[e.RowIndex];
                txtad.Text = seciliSatir["Ad"].ToString();
                txtsoyad.Text = seciliSatir["Soyad"].ToString();
                txtmail.Text = seciliSatir["Eposta"].ToString();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }
    }
}