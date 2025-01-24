using System;
using System.Windows.Forms;
using OtelProjeDeluxeEdition.DAL;      // OdaDAL için

namespace OtelProjeDeluxeEdition.UI
{
    public partial class OdaController : UserControl
    {
        private readonly OdaDAL _odaDAL;
        private int seciliOdaID = 0;

        public OdaController()
        {
            InitializeComponent();
            _odaDAL = new OdaDAL();
            KombolariDoldur();
            OdalariListele();
        }

        private void KombolariDoldur()
        {
            // Kat combobox
            cmbKat.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            cmbKat.SelectedIndex = 0;

            // Oda tip combobox
            cmbOdaTip.Items.AddRange(new object[] { "Standart", "Süit", "Delux", "Aile", "Kral Dairesi" });
            cmbOdaTip.SelectedIndex = 0;

            // Müsaitlik combobox
            cmbMusaitlik.Items.AddRange(new object[] { "Müsait", "Dolu" });
            cmbMusaitlik.SelectedIndex = 0;

            // Fiyat textbox'ını readonly yap
            txtFiyat.ReadOnly = true;
        }

        private void OdalariListele()
        {
            dataGridViewOda.DataSource = _odaDAL.TumunuGetir();
        }

        private void Temizle()
        {
            txtOdaNumara.Clear();
            txtFiyat.Clear();
            cmbOdaTip.SelectedIndex = 0;
            cmbKat.SelectedIndex = 0;
            cmbMusaitlik.SelectedIndex = 0;
            seciliOdaID = 0;
            txtOdaNumara.Focus();
        }

        private decimal OdaTipineFiyatBelirle(string odaTipi)
        {
            switch (odaTipi)
            {
                case "Standart": return 300;
                case "Süit": return 500;
                case "Delux": return 700;
                case "Aile": return 1000;
                case "Kral Dairesi": return 1500;
                default: return 0;
            }
        }

        private void cmbOdaTip_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFiyat.Text = OdaTipineFiyatBelirle(cmbOdaTip.Text).ToString();
        }

        private void btnOdaEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtOdaNumara.Text))
                {
                    MessageBox.Show("Oda numarası boş bırakılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var oda = new Oda
                {
                    OdaNumara = txtOdaNumara.Text.Trim(),
                    Fiyat = Convert.ToDecimal(txtFiyat.Text),
                    OdaTip = cmbOdaTip.Text,
                    Musaitlik = cmbMusaitlik.Text,
                    Kat = Convert.ToInt32(cmbKat.Text)
                };

                _odaDAL.Ekle(oda);
                MessageBox.Show("Oda başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                OdalariListele();
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOdaGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (seciliOdaID == 0)
                {
                    MessageBox.Show("Lütfen güncellenecek odayı seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(txtOdaNumara.Text))
                {
                    MessageBox.Show("Oda numarası boş bırakılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var oda = new Oda
                {
                    OdaID = seciliOdaID,
                    OdaNumara = txtOdaNumara.Text.Trim(),
                    Fiyat = Convert.ToDecimal(txtFiyat.Text),
                    OdaTip = cmbOdaTip.Text,
                    Musaitlik = cmbMusaitlik.Text,
                    Kat = Convert.ToInt32(cmbKat.Text)
                };

                _odaDAL.Guncelle(oda);
                MessageBox.Show("Oda başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                OdalariListele();
                Temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOdaSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (seciliOdaID == 0)
                {
                    MessageBox.Show("Lütfen silinecek odayı seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var result = MessageBox.Show("Seçili odayı silmek istediğinize emin misiniz?", "Onay",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    _odaDAL.Sil(seciliOdaID);
                    MessageBox.Show("Oda başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    OdalariListele();
                    Temizle();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewOda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewOda.Rows[e.RowIndex];
                seciliOdaID = Convert.ToInt32(row.Cells["OdaID"].Value);
                txtOdaNumara.Text = row.Cells["OdaNumara"].Value.ToString();
                txtFiyat.Text = row.Cells["Fiyat"].Value.ToString();
                cmbOdaTip.Text = row.Cells["OdaTip"].Value.ToString();
                cmbMusaitlik.Text = row.Cells["Musaitlik"].Value.ToString();
                cmbKat.Text = row.Cells["Kat"].Value.ToString();
            }
        }

        private void OdaController_Load(object sender, EventArgs e)
        {
            OdalariListele();
        }

        private void bottomPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblOdaNumara_Click(object sender, EventArgs e)
        {

        }

        private void txtOdaNumara_TextChanged(object sender, EventArgs e)
        {

        }
    }
}