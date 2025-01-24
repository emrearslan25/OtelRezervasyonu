using System;
using System.Drawing;
using System.Windows.Forms;

namespace OtelProjeDeluxeEdition.UI
{
    public partial class AnaSayfaController : UserControl
    {
        public AnaSayfaController()
        {
            InitializeComponent(); // This will call the auto-generated method in the designer file
        }

        private void AnaSayfaController_Load(object sender, EventArgs e)
        {
            HoşgeldinizMesajiGoster();
        }

        private void HoşgeldinizMesajiGoster()
        {
            Label lblHoşgeldiniz = new Label
            {
                Text = "Hoşgeldiniz!",
                Font = new Font("Segoe UI", 36, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = Color.Transparent,
                AutoSize = true,
                Location = new Point(150, 100),
                TextAlign = ContentAlignment.MiddleCenter
            };

            Label lblMotif = new Label
            {
                Text = "Büyük bir macera seni bekliyor!",
                Font = new Font("Segoe UI", 18, FontStyle.Italic),
                ForeColor = Color.White,
                BackColor = Color.Transparent,
                AutoSize = true,
                Location = new Point(100, 200),
                TextAlign = ContentAlignment.MiddleCenter
            };

            this.Controls.Add(lblHoşgeldiniz);
            this.Controls.Add(lblMotif);
        }
    }
}
