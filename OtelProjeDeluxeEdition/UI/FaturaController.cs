using System;
using System.Drawing;
using System.Windows.Forms;
using OtelProjeDeluxeEdition.DAL;

namespace OtelProjeDeluxeEdition.UI
{
    public partial class FaturaController : UserControl
    {
        private readonly FaturaDAL _faturaDAL;
        private int seciliFaturaID = 0;

        public FaturaController()
        {
            InitializeComponent();
            _faturaDAL = new FaturaDAL();
            FaturalariListele();
        }

        private void FaturalariListele()
        {
            dataGridViewFatura.DataSource = _faturaDAL.TumunuGetir();

            // Kolon başlıklarını düzenle
            dataGridViewFatura.Columns["FaturaID"].HeaderText = "Fatura No";
            dataGridViewFatura.Columns["MusteriTCKimlik"].HeaderText = "TC Kimlik";
            dataGridViewFatura.Columns["MusteriAdsoyad"].HeaderText = "Müşteri";
            dataGridViewFatura.Columns["GirisTarihi"].HeaderText = "Giriş Tarihi";
            dataGridViewFatura.Columns["CikisTarihi"].HeaderText = "Çıkış Tarihi";
            dataGridViewFatura.Columns["GunSayisi"].HeaderText = "Gün";
            dataGridViewFatura.Columns["SonFiyat"].HeaderText = "Tutar";

            // Para birimi formatı
            dataGridViewFatura.Columns["SonFiyat"].DefaultCellStyle.Format = "C2";
        }

        private void DataGridViewFatura_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewFatura.Rows[e.RowIndex];
                seciliFaturaID = Convert.ToInt32(row.Cells["FaturaID"].Value);
                txtFaturaID.Text = seciliFaturaID.ToString();
            }
        }

        private void BtnGoster_Click(object sender, EventArgs e)
        {
            if (seciliFaturaID > 0)
            {
                var fatura = _faturaDAL.Getir(seciliFaturaID);
                if (fatura != null)
                {
                    // Modern fatura detay formu oluştur
                    Form faturaDetayForm = new Form
                    {
                        Text = "Fatura Detayları",
                        Size = new Size(400, 500),
                        StartPosition = FormStartPosition.CenterParent,
                        FormBorderStyle = FormBorderStyle.FixedDialog,
                        MaximizeBox = false,
                        MinimizeBox = false,
                        BackColor = Color.White
                    };

                    // Üst panel - Başlık için
                    Panel ustPanel = new Panel
                    {
                        Dock = DockStyle.Top,
                        Height = 60,
                        BackColor = Color.FromArgb(45, 66, 91)
                    };

                    Label baslikLabel = new Label
                    {
                        Text = "FATURA DETAYLARI",
                        ForeColor = Color.White,
                        Font = new Font("Segoe UI", 14, FontStyle.Bold),
                        AutoSize = true
                    };
                    baslikLabel.Location = new Point((ustPanel.Width - baslikLabel.Width) / 2, (ustPanel.Height - baslikLabel.Height) / 2);
                    ustPanel.Controls.Add(baslikLabel);

                    // Ana panel - Fatura bilgileri için
                    Panel anaPanel = new Panel
                    {
                        Dock = DockStyle.Fill,
                        Padding = new Padding(20)
                    };

                    // Fatura bilgilerini içeren TableLayoutPanel
                    TableLayoutPanel bilgiPanel = new TableLayoutPanel
                    {
                        Dock = DockStyle.Top,
                        ColumnCount = 2,
                        RowCount = 7,
                        AutoSize = true,
                        Padding = new Padding(10),
                        CellBorderStyle = TableLayoutPanelCellBorderStyle.None
                    };

                    // Stil için font tanımları
                    Font baslikFont = new Font("Segoe UI", 9, FontStyle.Bold);
                    Font icerikFont = new Font("Segoe UI", 10);

                    // Bilgi satırlarını ekle
                    EkleBilgiSatiri("Fatura No:", fatura.FaturaID.ToString(), 0);
                    EkleBilgiSatiri("Müşteri:", fatura.MusteriAdsoyad, 1);
                    EkleBilgiSatiri("TC Kimlik:", fatura.MusteriTCKimlik, 2);
                    EkleBilgiSatiri("Giriş Tarihi:", fatura.GirisTarihi.ToString("dd.MM.yyyy"), 3);
                    EkleBilgiSatiri("Çıkış Tarihi:", fatura.CikisTarihi.ToString("dd.MM.yyyy"), 4);
                    EkleBilgiSatiri("Konaklama:", $"{fatura.GunSayisi} Gün", 5);

                    // Toplam tutar için özel panel
                    Panel tutarPanel = new Panel
                    {
                        Dock = DockStyle.Bottom,
                        Height = 60,
                        BackColor = Color.FromArgb(247, 246, 255)
                    };

                    Label tutarLabel = new Label
                    {
                        Text = "TOPLAM TUTAR:",
                        Font = new Font("Segoe UI", 12, FontStyle.Bold),
                        ForeColor = Color.FromArgb(45, 66, 91),
                        AutoSize = true
                    };
                    tutarLabel.Location = new Point(20, (tutarPanel.Height - tutarLabel.Height) / 2);

                    Label tutarDegerLabel = new Label
                    {
                        Text = fatura.SonFiyat.ToString("C2"),
                        Font = new Font("Segoe UI", 14, FontStyle.Bold),
                        ForeColor = Color.FromArgb(45, 66, 91),
                        AutoSize = true
                    };
                    tutarDegerLabel.Location = new Point(tutarPanel.Width - tutarDegerLabel.Width - 20, (tutarPanel.Height - tutarDegerLabel.Height) / 2);

                    tutarPanel.Controls.AddRange(new Control[] { tutarLabel, tutarDegerLabel });

                    tutarPanel.SizeChanged += (s, ev) =>
                    {
                        tutarDegerLabel.Location = new Point(
                            tutarPanel.Width - tutarDegerLabel.PreferredWidth - 20,
                            (tutarPanel.Height - tutarDegerLabel.Height) / 2
                        );
                    };

                    // Kapat butonu
                    Button kapatBtn = new Button
                    {
                        Text = "Kapat",
                        Size = new Size(100, 35),
                        FlatStyle = FlatStyle.Flat,
                        BackColor = Color.FromArgb(45, 66, 91),
                        ForeColor = Color.White,
                        Font = new Font("Segoe UI", 9),
                        Cursor = Cursors.Hand
                    };
                    kapatBtn.FlatAppearance.BorderSize = 0;
                    kapatBtn.Location = new Point((faturaDetayForm.ClientSize.Width - kapatBtn.Width) / 2,
                                                faturaDetayForm.ClientSize.Height - kapatBtn.Height - 20);

                    // Hover efekti
                    kapatBtn.MouseEnter += (s, ev) => kapatBtn.BackColor = Color.FromArgb(55, 76, 101);
                    kapatBtn.MouseLeave += (s, ev) => kapatBtn.BackColor = Color.FromArgb(45, 66, 91);
                    kapatBtn.Click += (s, ev) => faturaDetayForm.Close();

                    // Kontrolleri forma ekle
                    anaPanel.Controls.Add(bilgiPanel);
                    faturaDetayForm.Controls.AddRange(new Control[] { ustPanel, anaPanel, tutarPanel, kapatBtn });

                    // Formu göster
                    faturaDetayForm.ShowDialog();

                    // Yerel fonksiyon - Bilgi satırı ekleme
                    void EkleBilgiSatiri(string baslik, string icerik, int satirIndeks)
                    {
                        Label bilgiBaslikLabel = new Label
                        {
                            Text = baslik,
                            Font = baslikFont,
                            ForeColor = Color.FromArgb(45, 66, 91),
                            Dock = DockStyle.Fill,
                            TextAlign = ContentAlignment.MiddleLeft
                        };

                        Label bilgiIcerikLabel = new Label
                        {
                            Text = icerik,
                            Font = icerikFont,
                            ForeColor = Color.Black,
                            Dock = DockStyle.Fill,
                            TextAlign = ContentAlignment.MiddleLeft
                        };

                        bilgiPanel.Controls.Add(bilgiBaslikLabel, 0, satirIndeks);
                        bilgiPanel.Controls.Add(bilgiIcerikLabel, 1, satirIndeks);
                        bilgiPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
                    }

                }
            }
            else
            {
                MessageBox.Show("Lütfen bir fatura seçin!", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Form yüklendiğinde veya yenilendiğinde
        private void FaturaController_Load(object sender, EventArgs e)
        {
            FaturalariListele();
        }

        // Temizleme işlemi için
        private void Temizle()
        {
            txtFaturaID.Clear();
            seciliFaturaID = 0;
            dataGridViewFatura.ClearSelection();
        }
    }
}