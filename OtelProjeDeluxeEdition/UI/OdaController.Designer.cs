namespace OtelProjeDeluxeEdition.UI
{
    partial class OdaController
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewOda;
        private System.Windows.Forms.TextBox txtOdaNumara;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.ComboBox cmbOdaTip;
        private System.Windows.Forms.ComboBox cmbMusaitlik;
        private System.Windows.Forms.ComboBox cmbKat;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Label lblOdaNumara;
        private System.Windows.Forms.Label lblOdaTip;
        private System.Windows.Forms.Label lblKat;
        private System.Windows.Forms.Label lblMusaitlik;
        private System.Windows.Forms.Label lblFiyat;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewOda = new System.Windows.Forms.DataGridView();
            this.txtOdaNumara = new System.Windows.Forms.TextBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.cmbOdaTip = new System.Windows.Forms.ComboBox();
            this.cmbMusaitlik = new System.Windows.Forms.ComboBox();
            this.cmbKat = new System.Windows.Forms.ComboBox();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.btnOdaEkle = new System.Windows.Forms.Button();
            this.btnOdaGuncelle = new System.Windows.Forms.Button();
            this.btnOdaSil = new System.Windows.Forms.Button();
            this.lblOdaNumara = new System.Windows.Forms.Label();
            this.lblOdaTip = new System.Windows.Forms.Label();
            this.lblKat = new System.Windows.Forms.Label();
            this.lblMusaitlik = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOda)).BeginInit();
            this.bottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewOda
            // 
            this.dataGridViewOda.AllowUserToAddRows = false;
            this.dataGridViewOda.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.dataGridViewOda.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewOda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOda.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewOda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewOda.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewOda.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewOda.ColumnHeadersHeight = 29;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewOda.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewOda.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewOda.EnableHeadersVisualStyles = false;
            this.dataGridViewOda.Location = new System.Drawing.Point(10, 10);
            this.dataGridViewOda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewOda.MultiSelect = false;
            this.dataGridViewOda.Name = "dataGridViewOda";
            this.dataGridViewOda.ReadOnly = true;
            this.dataGridViewOda.RowHeadersVisible = false;
            this.dataGridViewOda.RowHeadersWidth = 51;
            this.dataGridViewOda.RowTemplate.Height = 35;
            this.dataGridViewOda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOda.Size = new System.Drawing.Size(780, 351);
            this.dataGridViewOda.TabIndex = 0;
            this.dataGridViewOda.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOda_CellClick);
            // 
            // txtOdaNumara
            // 
            this.txtOdaNumara.Location = new System.Drawing.Point(120, 22);
            this.txtOdaNumara.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOdaNumara.Name = "txtOdaNumara";
            this.txtOdaNumara.Size = new System.Drawing.Size(100, 22);
            this.txtOdaNumara.TabIndex = 1;
            this.txtOdaNumara.TextChanged += new System.EventHandler(this.txtOdaNumara_TextChanged);
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(550, 20);
            this.txtFiyat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(100, 22);
            this.txtFiyat.TabIndex = 9;
            // 
            // cmbOdaTip
            // 
            this.cmbOdaTip.Location = new System.Drawing.Point(120, 70);
            this.cmbOdaTip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbOdaTip.Name = "cmbOdaTip";
            this.cmbOdaTip.Size = new System.Drawing.Size(100, 24);
            this.cmbOdaTip.TabIndex = 3;
            // 
            // cmbMusaitlik
            // 
            this.cmbMusaitlik.Location = new System.Drawing.Point(327, 66);
            this.cmbMusaitlik.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMusaitlik.Name = "cmbMusaitlik";
            this.cmbMusaitlik.Size = new System.Drawing.Size(100, 24);
            this.cmbMusaitlik.TabIndex = 7;
            // 
            // cmbKat
            // 
            this.cmbKat.Location = new System.Drawing.Point(327, 22);
            this.cmbKat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbKat.Name = "cmbKat";
            this.cmbKat.Size = new System.Drawing.Size(100, 24);
            this.cmbKat.TabIndex = 5;
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.bottomPanel.Controls.Add(this.btnOdaEkle);
            this.bottomPanel.Controls.Add(this.btnOdaGuncelle);
            this.bottomPanel.Controls.Add(this.btnOdaSil);
            this.bottomPanel.Controls.Add(this.lblOdaNumara);
            this.bottomPanel.Controls.Add(this.txtOdaNumara);
            this.bottomPanel.Controls.Add(this.lblOdaTip);
            this.bottomPanel.Controls.Add(this.cmbOdaTip);
            this.bottomPanel.Controls.Add(this.lblKat);
            this.bottomPanel.Controls.Add(this.cmbKat);
            this.bottomPanel.Controls.Add(this.lblMusaitlik);
            this.bottomPanel.Controls.Add(this.cmbMusaitlik);
            this.bottomPanel.Controls.Add(this.lblFiyat);
            this.bottomPanel.Controls.Add(this.txtFiyat);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(10, 366);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Padding = new System.Windows.Forms.Padding(10);
            this.bottomPanel.Size = new System.Drawing.Size(780, 124);
            this.bottomPanel.TabIndex = 1;
            // 
            // btnOdaEkle
            // 
            this.btnOdaEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnOdaEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdaEkle.ForeColor = System.Drawing.Color.White;
            this.btnOdaEkle.Location = new System.Drawing.Point(475, 64);
            this.btnOdaEkle.Name = "btnOdaEkle";
            this.btnOdaEkle.Size = new System.Drawing.Size(100, 35);
            this.btnOdaEkle.TabIndex = 11;
            this.btnOdaEkle.Text = "Ekle";
            this.btnOdaEkle.UseVisualStyleBackColor = false;
            // 
            // btnOdaGuncelle
            // 
            this.btnOdaGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnOdaGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdaGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnOdaGuncelle.Location = new System.Drawing.Point(581, 64);
            this.btnOdaGuncelle.Name = "btnOdaGuncelle";
            this.btnOdaGuncelle.Size = new System.Drawing.Size(100, 35);
            this.btnOdaGuncelle.TabIndex = 12;
            this.btnOdaGuncelle.Text = "Güncelle";
            this.btnOdaGuncelle.UseVisualStyleBackColor = false;
            // 
            // btnOdaSil
            // 
            this.btnOdaSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnOdaSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdaSil.ForeColor = System.Drawing.Color.White;
            this.btnOdaSil.Location = new System.Drawing.Point(687, 64);
            this.btnOdaSil.Name = "btnOdaSil";
            this.btnOdaSil.Size = new System.Drawing.Size(100, 35);
            this.btnOdaSil.TabIndex = 13;
            this.btnOdaSil.Text = "Sil";
            this.btnOdaSil.UseVisualStyleBackColor = false;
            // 
            // lblOdaNumara
            // 
            this.lblOdaNumara.AutoSize = true;
            this.lblOdaNumara.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdaNumara.Location = new System.Drawing.Point(7, 24);
            this.lblOdaNumara.Name = "lblOdaNumara";
            this.lblOdaNumara.Size = new System.Drawing.Size(107, 20);
            this.lblOdaNumara.TabIndex = 0;
            this.lblOdaNumara.Text = "Oda Numarası:";
            this.lblOdaNumara.Click += new System.EventHandler(this.lblOdaNumara_Click);
            // 
            // lblOdaTip
            // 
            this.lblOdaTip.AutoSize = true;
            this.lblOdaTip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdaTip.Location = new System.Drawing.Point(45, 74);
            this.lblOdaTip.Name = "lblOdaTip";
            this.lblOdaTip.Size = new System.Drawing.Size(69, 20);
            this.lblOdaTip.TabIndex = 2;
            this.lblOdaTip.Text = "Oda Tipi:";
            // 
            // lblKat
            // 
            this.lblKat.AutoSize = true;
            this.lblKat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKat.Location = new System.Drawing.Point(287, 22);
            this.lblKat.Name = "lblKat";
            this.lblKat.Size = new System.Drawing.Size(34, 20);
            this.lblKat.TabIndex = 4;
            this.lblKat.Text = "Kat:";
            // 
            // lblMusaitlik
            // 
            this.lblMusaitlik.AutoSize = true;
            this.lblMusaitlik.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusaitlik.Location = new System.Drawing.Point(250, 70);
            this.lblMusaitlik.Name = "lblMusaitlik";
            this.lblMusaitlik.Size = new System.Drawing.Size(71, 20);
            this.lblMusaitlik.TabIndex = 6;
            this.lblMusaitlik.Text = "Müsaitlik:";
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFiyat.Location = new System.Drawing.Point(501, 20);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(43, 20);
            this.lblFiyat.TabIndex = 8;
            this.lblFiyat.Text = "Fiyat:";
            // 
            // OdaController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dataGridViewOda);
            this.Controls.Add(this.bottomPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "OdaController";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(800, 500);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOda)).EndInit();
            this.bottomPanel.ResumeLayout(false);
            this.bottomPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btnOdaEkle;
        private System.Windows.Forms.Button btnOdaGuncelle;
        private System.Windows.Forms.Button btnOdaSil;
    }
}