using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelProjeDeluxeEdition.UI
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        public void AnaSayfa_Load(object sender, EventArgs e)
        {
            AnaSayfaController anasayfaControl = new AnaSayfaController();

            Size userControlSize = new Size(800, 450);
            anasayfaControl.Size = userControlSize;

            int x = (this.ClientSize.Width - userControlSize.Width) / 2;
            int y = (this.ClientSize.Height - userControlSize.Height) / 2;
            Point location = new Point(x, y);

            anasayfaControl.Location = location;

            this.Controls.Add(anasayfaControl);

            KontrolGoster(anasayfaControl);
        }

        private Dictionary<string, UserControl> kontroller = new Dictionary<string, UserControl>();

        private UserControl GetOrCreateControl<T>() where T : UserControl, new()
        {
            string key = typeof(T).Name;

            if (!kontroller.ContainsKey(key))
            {
                var kontrol = new T();
                kontrol.Size = new Size(800, 450);
                int x = (this.ClientSize.Width - kontrol.Width) / 2;
                int y = (this.ClientSize.Height - kontrol.Height) / 2;
                kontrol.Location = new Point(x, y);
                kontrol.Visible = false;
                this.Controls.Add(kontrol);
                kontroller[key] = kontrol;
            }

            return kontroller[key];
        }


        private void KontrolGoster(UserControl kontrol)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is UserControl)
                {
                    ctrl.Visible = false;
                }
            }

            // Kontrolün boyutunu formun sağ kısmına kadar uzanacak şekilde ayarlıyoruz.
            kontrol.Size = new Size(this.ClientSize.Width - panel2.Width, this.ClientSize.Height);

            // X koordinatını panelin hemen sağından başlatıyoruz.
            int x = panel2.Width;
            int y = 0;

            kontrol.Location = new Point(x, y);

            kontrol.Visible = true;
            kontrol.BringToFront();
        }




        private void btnAna_Click(object sender, EventArgs e)
        {
            KontrolGoster(GetOrCreateControl<AnaSayfaController>());
        }

        private void btnMusteri_Click(object sender, EventArgs e)
        {
            KontrolGoster(GetOrCreateControl<MusteriController>());
        }

        private void btnOda_Click(object sender, EventArgs e)
        {
            KontrolGoster(GetOrCreateControl<OdaController>());
        }

        private void btnRezerv_Click(object sender, EventArgs e)
        {
            KontrolGoster(GetOrCreateControl<RezervasyonController>());
        }

        private void btnFatura_Click(object sender, EventArgs e)
        {
            KontrolGoster(GetOrCreateControl<FaturaController>());
        }

        private void btnYonetici_Click(object sender, EventArgs e)
        {
            KontrolGoster(GetOrCreateControl<YoneticiController>());
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
