using System;
using System.Windows.Forms;
using OtelProjeDeluxeEdition.DAL;  // DAL sınıfları için

namespace OtelProjeDeluxeEdition.UI
{
    public partial class RezervasyonController : UserControl
    {
        private readonly RezervasyonDAL _rezervasyonDAL;
        private readonly MusteriDAL _musteriDAL;
        private readonly OdaDAL _odaDAL;
        private readonly FaturaDAL _faturaDAL;
        private int seciliRezervasyonID = 0;

        public RezervasyonController()
        {
            InitializeComponent();
            _rezervasyonDAL = new RezervasyonDAL();
            _musteriDAL = new MusteriDAL();
            _odaDAL = new OdaDAL();
            _faturaDAL = new FaturaDAL();
            ListeleriDoldur();
        }

        private void KombolariDoldur()
        {
            // cmbDurum ile ilgili kodları kaldır

            // Minimum tarih bugün olsun
            dateGiris.MinDate = DateTime.Today;
            dateCikis.MinDate = DateTime.Today.AddDays(1);

            // Durum textbox'ını readonly yap ve varsayılan değeri ata
            txtDurum.ReadOnly = true;
            txtDurum.Text = "Aktif";
        }

        private void ListeleriDoldur()
        {
            dataGridViewRezervasyon.DataSource = _rezervasyonDAL.TumunuGetir();
            dataGridViewMusteri.DataSource = _musteriDAL.TumunuGetir();
            dataGridViewOda.DataSource = _odaDAL.TumunuGetir();
        }

        private void Temizle()
        {
            txtMusteriTCKimlik.Clear();
            txtOdaNumara.Clear();
            dateGiris.Value = DateTime.Today;
            dateCikis.Value = DateTime.Today.AddDays(1);
            txtDurum.Text = "Aktif";  // cmbDurum yerine txtDurum
            seciliRezervasyonID = 0;
        }

        private void dateGiris_ValueChanged(object sender, EventArgs e)
        {
            // Çıkış tarihi, giriş tarihinden önce olamaz
            dateCikis.MinDate = dateGiris.Value.AddDays(1);
            if (dateCikis.Value <= dateGiris.Value)
            {
                dateCikis.Value = dateGiris.Value.AddDays(1);
            }
        }

        private void btnRezervasyonYap_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMusteriTCKimlik.Text) || string.IsNullOrEmpty(txtOdaNumara.Text))
                {
                    MessageBox.Show("Müşteri ve oda seçimi yapmalısınız!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Tarih kontrolü
                if (!TarihlerMusaitMi(txtOdaNumara.Text, dateGiris.Value, dateCikis.Value))
                {
                    MessageBox.Show("Seçilen tarih aralığında oda dolu! Lütfen başka bir tarih aralığı veya oda seçin.",
                        "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Rezervasyon oluştur
                var rezervasyon = new Rezervasyon
                {
                    MusteriTCKimlik = txtMusteriTCKimlik.Text.Trim(),
                    OdaNumara = txtOdaNumara.Text.Trim(),
                    GirisTarihi = dateGiris.Value,
                    CikisTarihi = dateCikis.Value,
                    Durum = txtDurum.Text
                };

                // Rezervasyonu kaydet
                _rezervasyonDAL.Ekle(rezervasyon);

                // Fatura oluştur
                var musteri = _musteriDAL.TCyeGoreGetir(txtMusteriTCKimlik.Text.Trim());
                var oda = _odaDAL.Getir(txtOdaNumara.Text.Trim());

                if (musteri == null || oda == null)
                {
                    MessageBox.Show("Müşteri veya oda bilgilerine ulaşılamadı!", "Hata",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Gün sayısını hesapla
                int gunSayisi = (dateCikis.Value - dateGiris.Value).Days;

                // Toplam fiyatı hesapla
                decimal toplamFiyat = gunSayisi * oda.Fiyat;  // OdaFiyat yerine Fiyat kullanıldı

                var fatura = new Fatura
                {
                    MusteriTCKimlik = musteri.MusteriTCKimlik,
                    MusteriAdsoyad = musteri.MusteriAdsoyad,
                    GirisTarihi = dateGiris.Value,
                    CikisTarihi = dateCikis.Value,
                    GunSayisi = gunSayisi,
                    SonFiyat = toplamFiyat
                };

                // Faturayı kaydet
                _faturaDAL.Ekle(fatura);

                MessageBox.Show("Rezervasyon ve fatura başarıyla oluşturuldu.", "Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                ListeleriDoldur();
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRezervasyonIptal_Click(object sender, EventArgs e)
        {
            try
            {
                if (seciliRezervasyonID == 0)
                {
                    MessageBox.Show("Lütfen iptal edilecek rezervasyonu seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var result = MessageBox.Show("Seçili rezervasyonu iptal etmek istediğinize emin misiniz?", "Onay",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    var rezervasyon = _rezervasyonDAL.Getir(seciliRezervasyonID);
                    if (rezervasyon != null)
                    {
                        // Giriş tarihi geçmişse Pasif, geçmemişse Aktif olarak işaretle
                        string yeniDurum = rezervasyon.GirisTarihi < DateTime.Today ? "Pasif" : "Aktif";
                        rezervasyon.Durum = "İptal (" + yeniDurum + ")";
                        txtDurum.Text = rezervasyon.Durum;  // txtDurum'u güncelle

                        _rezervasyonDAL.Guncelle(rezervasyon);
                        MessageBox.Show("Rezervasyon başarıyla iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ListeleriDoldur();
                        Temizle();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewRezervasyon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewRezervasyon.Rows[e.RowIndex];
                seciliRezervasyonID = Convert.ToInt32(row.Cells["RezervasyonID"].Value); // ID'yi kaydet

                // Diğer bilgileri doldur
                txtMusteriTCKimlik.Text = row.Cells["MusteriTCKimlik"].Value.ToString();
                txtOdaNumara.Text = row.Cells["OdaNumara"].Value.ToString();
                dateGiris.Value = Convert.ToDateTime(row.Cells["GirisTarihi"].Value);
                dateCikis.Value = Convert.ToDateTime(row.Cells["CikisTarihi"].Value);
                txtDurum.Text = row.Cells["Durum"].Value.ToString();
            }
        }

        private void dataGridViewMusteri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewMusteri.Rows[e.RowIndex];
                txtMusteriTCKimlik.Text = row.Cells["MusteriTCKimlik"].Value.ToString();
            }
        }

        private void dataGridViewOda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewOda.Rows[e.RowIndex];
                txtOdaNumara.Text = row.Cells["OdaNumara"].Value.ToString();
            }
        }

        private void RezervasyonController_Load(object sender, EventArgs e)
        {
            ListeleriDoldur();
        }

        private void btnRezervasyonTemizle_Click(object sender, EventArgs e)
        {
            try
            {
                // Temizle metodunu çağır
                Temizle();

                // Seçili satırların seçimini kaldır
                if (dataGridViewRezervasyon.SelectedRows.Count > 0)
                    dataGridViewRezervasyon.ClearSelection();
                if (dataGridViewMusteri.SelectedRows.Count > 0)
                    dataGridViewMusteri.ClearSelection();
                if (dataGridViewOda.SelectedRows.Count > 0)
                    dataGridViewOda.ClearSelection();

                MessageBox.Show("Form temizlendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Temizleme işlemi sırasında bir hata oluştu: {ex.Message}", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool TarihlerMusaitMi(string odaNumara, DateTime girisTarihi, DateTime cikisTarihi, int? haricRezervasyonID = null)
        {
            var tumRezervasyonlar = _rezervasyonDAL.TumunuGetir();

            foreach (var rezervasyon in tumRezervasyonlar)
            {
                // Eğer bu rezervasyon güncelleniyorsa, kendi tarihlerini kontrol etme
                if (haricRezervasyonID.HasValue && rezervasyon.RezervID == haricRezervasyonID.Value)
                    continue;

                // Sadece aynı oda numarasına ve aktif duruma sahip rezervasyonları kontrol et
                if (rezervasyon.OdaNumara == odaNumara &&
                    !rezervasyon.Durum.Contains("İptal"))
                {
                    // Tarih çakışması kontrolü
                    if ((girisTarihi >= rezervasyon.GirisTarihi && girisTarihi < rezervasyon.CikisTarihi) ||  // Giriş tarihi çakışması
                        (cikisTarihi > rezervasyon.GirisTarihi && cikisTarihi <= rezervasyon.CikisTarihi) ||  // Çıkış tarihi çakışması
                        (girisTarihi <= rezervasyon.GirisTarihi && cikisTarihi >= rezervasyon.CikisTarihi))   // Kapsama durumu
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void txtMusteriTCKimlik_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewOda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}