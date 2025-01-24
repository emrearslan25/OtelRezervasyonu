using System;
using System.Windows.Forms;

namespace OtelProjeDeluxeEdition.UI
{
    public partial class MusteriController : UserControl
    {
        private readonly MusteriDAL _musteriDAL;
        private int seciliMusteriID = 0;

        public MusteriController()
        {
            InitializeComponent();
            _musteriDAL = new MusteriDAL();
            KombolariDoldur();
            MusterileriListele();
        }

        private void KombolariDoldur()
        {
            cmbCinsiyet.Items.AddRange(new object[] { "Erkek", "Kadın" });
            cmbCinsiyet.SelectedIndex = 0;
        }

        private void MusterileriListele()
        {
            dataGridViewMusteri.DataSource = _musteriDAL.TumunuGetir();
        }

        private void Temizle()
        {
            txtMusteriAdSoyad.Clear();
            txtMusteriTelefon.Clear();
            txtMusteriTCKimlik.Clear();
            cmbCinsiyet.SelectedIndex = 0;
            seciliMusteriID = 0;
            txtMusteriAdSoyad.Focus();
        }

        private void MusteriController_Load(object sender, EventArgs e)
        {
            MusterileriListele();
        }

        private void btnMusteriEkle_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMusteriAdSoyad.Text) || string.IsNullOrEmpty(txtMusteriTelefon.Text) ||
                    string.IsNullOrEmpty(txtMusteriTCKimlik.Text))
                {
                    MessageBox.Show("Tüm alanları doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (txtMusteriTCKimlik.Text.Length != 11)
                {
                    MessageBox.Show("TC Kimlik numarası 11 haneli olmalıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var musteri = new Musteri
                {
                    MusteriAdsoyad = txtMusteriAdSoyad.Text.Trim(),
                    MusteriTelefon = txtMusteriTelefon.Text.Trim(),
                    MusteriCinsiyet = cmbCinsiyet.Text,
                    MusteriTCKimlik = txtMusteriTCKimlik.Text.Trim()
                };

                _musteriDAL.Ekle(musteri);
                MessageBox.Show("Müşteri başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MusterileriListele();
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMusteriSil_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (seciliMusteriID == 0)
                {
                    MessageBox.Show("Lütfen silinecek müşteriyi seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var result = MessageBox.Show("Seçili müşteriyi silmek istediğinize emin misiniz?", "Onay",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    _musteriDAL.Sil(seciliMusteriID);
                    MessageBox.Show("Müşteri başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    MusterileriListele();
                    Temizle();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMusteriGuncelle_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (seciliMusteriID == 0)
                {
                    MessageBox.Show("Lütfen güncellenecek müşteriyi seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(txtMusteriAdSoyad.Text) || string.IsNullOrEmpty(txtMusteriTelefon.Text) ||
                    string.IsNullOrEmpty(txtMusteriTCKimlik.Text))
                {
                    MessageBox.Show("Tüm alanları doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (txtMusteriTCKimlik.Text.Length != 11)
                {
                    MessageBox.Show("TC Kimlik numarası 11 haneli olmalıdır!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var musteri = new Musteri
                {
                    MusteriID = seciliMusteriID,
                    MusteriAdsoyad = txtMusteriAdSoyad.Text.Trim(),
                    MusteriTelefon = txtMusteriTelefon.Text.Trim(),
                    MusteriCinsiyet = cmbCinsiyet.Text,
                    MusteriTCKimlik = txtMusteriTCKimlik.Text.Trim()
                };

                _musteriDAL.Guncelle(musteri);
                MessageBox.Show("Müşteri başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MusterileriListele();
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewMusteri_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewMusteri.Rows[e.RowIndex];
                seciliMusteriID = Convert.ToInt32(row.Cells["MusteriID"].Value);
                txtMusteriAdSoyad.Text = row.Cells["MusteriAdsoyad"].Value.ToString();
                txtMusteriTelefon.Text = row.Cells["MusteriTelefon"].Value.ToString();
                cmbCinsiyet.Text = row.Cells["MusteriCinsiyet"].Value.ToString();
                txtMusteriTCKimlik.Text = row.Cells["MusteriTCKimlik"].Value.ToString();
            }
        }
    }
}