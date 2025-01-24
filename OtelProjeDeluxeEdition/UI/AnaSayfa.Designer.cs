namespace OtelProjeDeluxeEdition.UI
{
    partial class AnaSayfa
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAna = new System.Windows.Forms.Button();
            this.btnMusteri = new System.Windows.Forms.Button();
            this.btnOda = new System.Windows.Forms.Button();
            this.btnRezerv = new System.Windows.Forms.Button();
            this.btnFatura = new System.Windows.Forms.Button();
            this.btnYonetici = new System.Windows.Forms.Button();
            this.yoneticiController1 = new OtelProjeDeluxeEdition.UI.YoneticiController();
            this.rezervasyonController2 = new OtelProjeDeluxeEdition.UI.RezervasyonController();
            this.odaController1 = new OtelProjeDeluxeEdition.UI.OdaController();
            this.musteriController1 = new OtelProjeDeluxeEdition.UI.MusteriController();
            this.faturaController1 = new OtelProjeDeluxeEdition.UI.FaturaController();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Coral;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 486);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.panel2.Controls.Add(this.btnYonetici);
            this.panel2.Controls.Add(this.btnFatura);
            this.panel2.Controls.Add(this.btnRezerv);
            this.panel2.Controls.Add(this.btnOda);
            this.panel2.Controls.Add(this.btnMusteri);
            this.panel2.Controls.Add(this.btnAna);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(200, 486);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnAna
            // 
            this.btnAna.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(228)))), ((int)(((byte)(252)))));
            this.btnAna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAna.Location = new System.Drawing.Point(13, 63);
            this.btnAna.Name = "btnAna";
            this.btnAna.Size = new System.Drawing.Size(184, 56);
            this.btnAna.TabIndex = 0;
            this.btnAna.Text = "Ana Menü";
            this.btnAna.UseVisualStyleBackColor = false;
            this.btnAna.Click += new System.EventHandler(this.btnAna_Click);
            // 
            // btnMusteri
            // 
            this.btnMusteri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(228)))), ((int)(((byte)(252)))));
            this.btnMusteri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusteri.Location = new System.Drawing.Point(13, 128);
            this.btnMusteri.Name = "btnMusteri";
            this.btnMusteri.Size = new System.Drawing.Size(184, 56);
            this.btnMusteri.TabIndex = 1;
            this.btnMusteri.Text = "Müşteri";
            this.btnMusteri.UseVisualStyleBackColor = false;
            this.btnMusteri.Click += new System.EventHandler(this.btnMusteri_Click);
            // 
            // btnOda
            // 
            this.btnOda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(228)))), ((int)(((byte)(252)))));
            this.btnOda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOda.Location = new System.Drawing.Point(13, 193);
            this.btnOda.Name = "btnOda";
            this.btnOda.Size = new System.Drawing.Size(184, 56);
            this.btnOda.TabIndex = 2;
            this.btnOda.Text = "Odalar";
            this.btnOda.UseVisualStyleBackColor = false;
            this.btnOda.Click += new System.EventHandler(this.btnOda_Click);
            // 
            // btnRezerv
            // 
            this.btnRezerv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(228)))), ((int)(((byte)(252)))));
            this.btnRezerv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRezerv.Location = new System.Drawing.Point(13, 258);
            this.btnRezerv.Name = "btnRezerv";
            this.btnRezerv.Size = new System.Drawing.Size(184, 56);
            this.btnRezerv.TabIndex = 3;
            this.btnRezerv.Text = "Rezervasyon";
            this.btnRezerv.UseVisualStyleBackColor = false;
            this.btnRezerv.Click += new System.EventHandler(this.btnRezerv_Click);
            // 
            // btnFatura
            // 
            this.btnFatura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(228)))), ((int)(((byte)(252)))));
            this.btnFatura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFatura.Location = new System.Drawing.Point(13, 323);
            this.btnFatura.Name = "btnFatura";
            this.btnFatura.Size = new System.Drawing.Size(184, 56);
            this.btnFatura.TabIndex = 4;
            this.btnFatura.Text = "Fatura";
            this.btnFatura.UseVisualStyleBackColor = false;
            this.btnFatura.Click += new System.EventHandler(this.btnFatura_Click);
            // 
            // btnYonetici
            // 
            this.btnYonetici.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(228)))), ((int)(((byte)(252)))));
            this.btnYonetici.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYonetici.Location = new System.Drawing.Point(13, 388);
            this.btnYonetici.Name = "btnYonetici";
            this.btnYonetici.Size = new System.Drawing.Size(184, 56);
            this.btnYonetici.TabIndex = 5;
            this.btnYonetici.Text = "Yönetici";
            this.btnYonetici.UseVisualStyleBackColor = false;
            this.btnYonetici.Click += new System.EventHandler(this.btnYonetici_Click);
            // 
            // yoneticiController1
            // 
            this.yoneticiController1.Location = new System.Drawing.Point(220, 10);
            this.yoneticiController1.Name = "yoneticiController1";
            this.yoneticiController1.Padding = new System.Windows.Forms.Padding(10);
            this.yoneticiController1.Size = new System.Drawing.Size(800, 500);
            this.yoneticiController1.TabIndex = 4;
            // 
            // rezervasyonController2
            // 
            this.rezervasyonController2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rezervasyonController2.Location = new System.Drawing.Point(210, 10);
            this.rezervasyonController2.Name = "rezervasyonController2";
            this.rezervasyonController2.Padding = new System.Windows.Forms.Padding(10);
            this.rezervasyonController2.Size = new System.Drawing.Size(800, 500);
            this.rezervasyonController2.TabIndex = 3;
            // 
            // odaController1
            // 
            this.odaController1.BackColor = System.Drawing.Color.White;
            this.odaController1.Location = new System.Drawing.Point(220, 10);
            this.odaController1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.odaController1.Name = "odaController1";
            this.odaController1.Padding = new System.Windows.Forms.Padding(10);
            this.odaController1.Size = new System.Drawing.Size(800, 500);
            this.odaController1.TabIndex = 1;
            // 
            // musteriController1
            // 
            this.musteriController1.BackColor = System.Drawing.Color.White;
            this.musteriController1.Dock = System.Windows.Forms.DockStyle.Left;
            this.musteriController1.Location = new System.Drawing.Point(210, 10);
            this.musteriController1.Name = "musteriController1";
            this.musteriController1.Padding = new System.Windows.Forms.Padding(10);
            this.musteriController1.Size = new System.Drawing.Size(800, 486);
            this.musteriController1.TabIndex = 1;
            // 
            // faturaController1
            // 
            this.faturaController1.BackColor = System.Drawing.Color.White;
            this.faturaController1.Dock = System.Windows.Forms.DockStyle.Right;
            this.faturaController1.Location = new System.Drawing.Point(220, 10);
            this.faturaController1.Name = "faturaController1";
            this.faturaController1.Padding = new System.Windows.Forms.Padding(10);
            this.faturaController1.Size = new System.Drawing.Size(800, 486);
            this.faturaController1.TabIndex = 1;
            // 
            // AnaSayfa
            // 
            this.ClientSize = new System.Drawing.Size(1030, 506);
            this.Controls.Add(this.yoneticiController1);
            this.Controls.Add(this.rezervasyonController2);
            this.Controls.Add(this.odaController1);
            this.Controls.Add(this.musteriController1);
            this.Controls.Add(this.faturaController1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "AnaSayfa";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Load += new System.EventHandler(this.AnaSayfa_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAna;
        private FaturaController faturaController1;
        private System.Windows.Forms.Button btnYonetici;
        private System.Windows.Forms.Button btnFatura;
        private System.Windows.Forms.Button btnRezerv;
        private System.Windows.Forms.Button btnOda;
        private System.Windows.Forms.Button btnMusteri;
        private MusteriController musteriController1;
        private OdaController odaController1;
        private RezervasyonController rezervasyonController2;
        private YoneticiController yoneticiController1;
    }
}