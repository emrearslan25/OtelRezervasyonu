using System;
using System.Drawing;
using System.Windows.Forms;

namespace OtelProjeDeluxeEdition.UI
{
    partial class MusteriController
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridViewMusteri;
        private Button btnMusteriEkle;
        private Button btnMusteriGuncelle;
        private Button btnMusteriSil;
        private TextBox txtMusteriAdSoyad;
        private TextBox txtMusteriTelefon;
        private TextBox txtMusteriTCKimlik;
        private ComboBox cmbCinsiyet;
        private Panel bottomPanel;
        private Label lblMusteriAdSoyad;
        private Label lblMusteriTelefon;
        private Label lblCinsiyet;
        private Label lblTCKimlik;

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
            this.dataGridViewMusteri = new System.Windows.Forms.DataGridView();
            this.btnMusteriEkle = new System.Windows.Forms.Button();
            this.btnMusteriGuncelle = new System.Windows.Forms.Button();
            this.btnMusteriSil = new System.Windows.Forms.Button();
            this.txtMusteriAdSoyad = new System.Windows.Forms.TextBox();
            this.txtMusteriTelefon = new System.Windows.Forms.TextBox();
            this.txtMusteriTCKimlik = new System.Windows.Forms.TextBox();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.lblMusteriAdSoyad = new System.Windows.Forms.Label();
            this.lblMusteriTelefon = new System.Windows.Forms.Label();
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.lblTCKimlik = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMusteri)).BeginInit();
            this.bottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewMusteri
            // 
            this.dataGridViewMusteri.AllowUserToAddRows = false;
            this.dataGridViewMusteri.AllowUserToDeleteRows = false;
            this.dataGridViewMusteri.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.dataGridViewMusteri.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewMusteri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMusteri.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewMusteri.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewMusteri.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewMusteri.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMusteri.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewMusteri.ColumnHeadersHeight = 30;
            this.dataGridViewMusteri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMusteri.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewMusteri.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewMusteri.EnableHeadersVisualStyles = false;
            this.dataGridViewMusteri.Location = new System.Drawing.Point(10, 10);
            this.dataGridViewMusteri.MultiSelect = false;
            this.dataGridViewMusteri.Name = "dataGridViewMusteri";
            this.dataGridViewMusteri.ReadOnly = true;
            this.dataGridViewMusteri.RowHeadersVisible = false;
            this.dataGridViewMusteri.RowHeadersWidth = 51;
            this.dataGridViewMusteri.RowTemplate.Height = 35;
            this.dataGridViewMusteri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMusteri.Size = new System.Drawing.Size(780, 350);
            this.dataGridViewMusteri.TabIndex = 0;
            this.dataGridViewMusteri.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMusteri_CellContentClick);
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnMusteriEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusteriEkle.ForeColor = System.Drawing.Color.White;
            this.btnMusteriEkle.Location = new System.Drawing.Point(454, 53);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(100, 35);
            this.btnMusteriEkle.TabIndex = 8;
            this.btnMusteriEkle.Text = "Ekle";
            this.btnMusteriEkle.UseVisualStyleBackColor = false;
            this.btnMusteriEkle.Click += new System.EventHandler(this.btnMusteriEkle_Click_1);
            // 
            // btnMusteriGuncelle
            // 
            this.btnMusteriGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnMusteriGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusteriGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnMusteriGuncelle.Location = new System.Drawing.Point(560, 53);
            this.btnMusteriGuncelle.Name = "btnMusteriGuncelle";
            this.btnMusteriGuncelle.Size = new System.Drawing.Size(100, 35);
            this.btnMusteriGuncelle.TabIndex = 9;
            this.btnMusteriGuncelle.Text = "Güncelle";
            this.btnMusteriGuncelle.UseVisualStyleBackColor = false;
            this.btnMusteriGuncelle.Click += new System.EventHandler(this.btnMusteriGuncelle_Click_1);
            // 
            // btnMusteriSil
            // 
            this.btnMusteriSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnMusteriSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusteriSil.ForeColor = System.Drawing.Color.White;
            this.btnMusteriSil.Location = new System.Drawing.Point(666, 53);
            this.btnMusteriSil.Name = "btnMusteriSil";
            this.btnMusteriSil.Size = new System.Drawing.Size(100, 35);
            this.btnMusteriSil.TabIndex = 10;
            this.btnMusteriSil.Text = "Sil";
            this.btnMusteriSil.UseVisualStyleBackColor = false;
            this.btnMusteriSil.Click += new System.EventHandler(this.btnMusteriSil_Click_1);
            // 
            // txtMusteriAdSoyad
            // 
            this.txtMusteriAdSoyad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtMusteriAdSoyad.Location = new System.Drawing.Point(20, 30);
            this.txtMusteriAdSoyad.Name = "txtMusteriAdSoyad";
            this.txtMusteriAdSoyad.Size = new System.Drawing.Size(150, 22);
            this.txtMusteriAdSoyad.TabIndex = 1;
            // 
            // txtMusteriTelefon
            // 
            this.txtMusteriTelefon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtMusteriTelefon.Location = new System.Drawing.Point(20, 89);
            this.txtMusteriTelefon.Name = "txtMusteriTelefon";
            this.txtMusteriTelefon.Size = new System.Drawing.Size(150, 22);
            this.txtMusteriTelefon.TabIndex = 3;
            // 
            // txtMusteriTCKimlik
            // 
            this.txtMusteriTCKimlik.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtMusteriTCKimlik.Location = new System.Drawing.Point(200, 30);
            this.txtMusteriTCKimlik.Name = "txtMusteriTCKimlik";
            this.txtMusteriTCKimlik.Size = new System.Drawing.Size(150, 22);
            this.txtMusteriTCKimlik.TabIndex = 7;
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmbCinsiyet.Location = new System.Drawing.Point(200, 87);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(150, 24);
            this.cmbCinsiyet.TabIndex = 5;
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.bottomPanel.Controls.Add(this.lblMusteriAdSoyad);
            this.bottomPanel.Controls.Add(this.txtMusteriAdSoyad);
            this.bottomPanel.Controls.Add(this.lblMusteriTelefon);
            this.bottomPanel.Controls.Add(this.txtMusteriTelefon);
            this.bottomPanel.Controls.Add(this.lblCinsiyet);
            this.bottomPanel.Controls.Add(this.cmbCinsiyet);
            this.bottomPanel.Controls.Add(this.lblTCKimlik);
            this.bottomPanel.Controls.Add(this.txtMusteriTCKimlik);
            this.bottomPanel.Controls.Add(this.btnMusteriEkle);
            this.bottomPanel.Controls.Add(this.btnMusteriGuncelle);
            this.bottomPanel.Controls.Add(this.btnMusteriSil);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(10, 366);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Padding = new System.Windows.Forms.Padding(10);
            this.bottomPanel.Size = new System.Drawing.Size(780, 124);
            this.bottomPanel.TabIndex = 1;
            // 
            // lblMusteriAdSoyad
            // 
            this.lblMusteriAdSoyad.AutoSize = true;
            this.lblMusteriAdSoyad.Location = new System.Drawing.Point(17, 10);
            this.lblMusteriAdSoyad.Name = "lblMusteriAdSoyad";
            this.lblMusteriAdSoyad.Size = new System.Drawing.Size(70, 16);
            this.lblMusteriAdSoyad.TabIndex = 0;
            this.lblMusteriAdSoyad.Text = "Ad Soyad:";
            // 
            // lblMusteriTelefon
            // 
            this.lblMusteriTelefon.AutoSize = true;
            this.lblMusteriTelefon.Location = new System.Drawing.Point(17, 70);
            this.lblMusteriTelefon.Name = "lblMusteriTelefon";
            this.lblMusteriTelefon.Size = new System.Drawing.Size(56, 16);
            this.lblMusteriTelefon.TabIndex = 2;
            this.lblMusteriTelefon.Text = "Telefon:";
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.AutoSize = true;
            this.lblCinsiyet.Location = new System.Drawing.Point(197, 68);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(57, 16);
            this.lblCinsiyet.TabIndex = 4;
            this.lblCinsiyet.Text = "Cinsiyet:";
            // 
            // lblTCKimlik
            // 
            this.lblTCKimlik.AutoSize = true;
            this.lblTCKimlik.Location = new System.Drawing.Point(197, 11);
            this.lblTCKimlik.Name = "lblTCKimlik";
            this.lblTCKimlik.Size = new System.Drawing.Size(66, 16);
            this.lblTCKimlik.TabIndex = 6;
            this.lblTCKimlik.Text = "TC Kimlik:";
            // 
            // MusteriController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dataGridViewMusteri);
            this.Controls.Add(this.bottomPanel);
            this.Name = "MusteriController";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(800, 500);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMusteri)).EndInit();
            this.bottomPanel.ResumeLayout(false);
            this.bottomPanel.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}