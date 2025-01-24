using System;
using System.Windows.Forms;

namespace OtelProjeDeluxeEdition.UI
{
    public partial class Giris : Form
    {
        private readonly YoneticiDAL _yoneticiDAL;

        public Giris()
        {
            InitializeComponent();
            _yoneticiDAL = new YoneticiDAL();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtGiris.Text.Trim();
            string sifre = txtGirisSifre.Text.Trim();

            if (string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş bırakılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var yoneticiler = _yoneticiDAL.GetAll();
            bool girisBasarili = false;

            foreach (var yonetici in yoneticiler)
            {
                if (yonetici.YoneticiAdi == kullaniciAdi && yonetici.YoneticiSifre == sifre)
                {
                    girisBasarili = true;
                    break;
                }
            }

            if (girisBasarili)
            {
                MessageBox.Show("Giriş başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Ana formu aç
                AnaSayfa anaForm = new AnaSayfa();
                this.Hide();
                anaForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGirisSifre.Clear();
                txtGiris.Focus();
            }
        }

        private void txtGirisSifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Enter tuşuna basıldığında giriş yap
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnGiris_Click(sender, e);
            }
        }

        private void Giris_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde kullanıcı adı textbox'ına odaklan
            txtGiris.Focus();
        }
    }
}