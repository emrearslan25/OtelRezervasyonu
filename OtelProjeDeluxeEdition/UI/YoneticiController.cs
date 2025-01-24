using System;
using System.Windows.Forms;

namespace OtelProjeDeluxeEdition.UI
{
    public partial class YoneticiController : UserControl
    {
        private readonly YoneticiDAL _yoneticiDAL;
        private int seciliYoneticiID = 0;

        public YoneticiController()
        {
            InitializeComponent();
            _yoneticiDAL = new YoneticiDAL();
            YoneticileriListele();
        }

        private void YoneticileriListele()
        {
            dataGridViewYonetici.DataSource = _yoneticiDAL.GetAll();
        }

        private void Temizle()
        {
            txtYoneticiAdi.Clear();
            txtYoneticiSifre.Clear();
            seciliYoneticiID = 0;
            txtYoneticiAdi.Focus();
        }

        private void btnYoneticiEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtYoneticiAdi.Text) || string.IsNullOrEmpty(txtYoneticiSifre.Text))
                {
                    MessageBox.Show("Yönetici adı ve şifre boş bırakılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var yonetici = new Yonetici
                {
                    YoneticiAdi = txtYoneticiAdi.Text.Trim(),
                    YoneticiSifre = txtYoneticiSifre.Text.Trim()
                };

                _yoneticiDAL.Ekle(yonetici);
                MessageBox.Show("Yönetici başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                YoneticileriListele();
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnYoneticiGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (seciliYoneticiID == 0)
                {
                    MessageBox.Show("Lütfen güncellenecek yöneticiyi seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(txtYoneticiAdi.Text) || string.IsNullOrEmpty(txtYoneticiSifre.Text))
                {
                    MessageBox.Show("Yönetici adı ve şifre boş bırakılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var yonetici = new Yonetici
                {
                    YoneticiID = seciliYoneticiID,
                    YoneticiAdi = txtYoneticiAdi.Text.Trim(),
                    YoneticiSifre = txtYoneticiSifre.Text.Trim()
                };

                _yoneticiDAL.Guncelle(yonetici);
                MessageBox.Show("Yönetici başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                YoneticileriListele();
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnYoneticiSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (seciliYoneticiID == 0)
                {
                    MessageBox.Show("Lütfen silinecek yöneticiyi seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var result = MessageBox.Show("Seçili yöneticiyi silmek istediğinize emin misiniz?", "Onay",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    _yoneticiDAL.Sil(seciliYoneticiID);
                    MessageBox.Show("Yönetici başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    YoneticileriListele();
                    Temizle();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewYonetici_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewYonetici.Rows[e.RowIndex];
                seciliYoneticiID = Convert.ToInt32(row.Cells["YoneticiID"].Value);
                txtYoneticiAdi.Text = row.Cells["YoneticiAdi"].Value.ToString();
                txtYoneticiSifre.Text = row.Cells["YoneticiSifre"].Value.ToString();
            }
        }

        private void YoneticiController_Load(object sender, EventArgs e)
        {
            YoneticileriListele();
        }

        private void dataGridViewOda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewYonetici_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}