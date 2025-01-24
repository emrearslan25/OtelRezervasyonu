using System;
using System.Drawing;
using System.Windows.Forms;

namespace OtelProjeDeluxeEdition.UI
{
    partial class YoneticiController
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridViewYonetici;
        private Button btnYoneticiEkle;
        private Button btnYoneticiGuncelle;
        private Button btnYoneticiSil;
        private TextBox txtYoneticiAdi;
        private TextBox txtYoneticiSifre;
        private Panel bottomPanel;
        private Label lblYoneticiAdi;
        private Label lblYoneticiSifre;

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
            this.dataGridViewYonetici = new System.Windows.Forms.DataGridView();
            this.btnYoneticiEkle = new System.Windows.Forms.Button();
            this.btnYoneticiGuncelle = new System.Windows.Forms.Button();
            this.btnYoneticiSil = new System.Windows.Forms.Button();
            this.txtYoneticiAdi = new System.Windows.Forms.TextBox();
            this.txtYoneticiSifre = new System.Windows.Forms.TextBox();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.lblYoneticiAdi = new System.Windows.Forms.Label();
            this.lblYoneticiSifre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewYonetici)).BeginInit();
            this.bottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewYonetici
            // 
            this.dataGridViewYonetici.AllowUserToAddRows = false;
            this.dataGridViewYonetici.AllowUserToDeleteRows = false;
            this.dataGridViewYonetici.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.dataGridViewYonetici.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewYonetici.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewYonetici.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewYonetici.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewYonetici.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewYonetici.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewYonetici.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewYonetici.ColumnHeadersHeight = 30;
            this.dataGridViewYonetici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewYonetici.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewYonetici.EnableHeadersVisualStyles = false;
            this.dataGridViewYonetici.Location = new System.Drawing.Point(10, 10);
            this.dataGridViewYonetici.MultiSelect = false;
            this.dataGridViewYonetici.Name = "dataGridViewYonetici";
            this.dataGridViewYonetici.ReadOnly = true;
            this.dataGridViewYonetici.RowHeadersVisible = false;
            this.dataGridViewYonetici.RowHeadersWidth = 51;
            this.dataGridViewYonetici.RowTemplate.Height = 35;
            this.dataGridViewYonetici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewYonetici.Size = new System.Drawing.Size(780, 350);
            this.dataGridViewYonetici.TabIndex = 0;
            // 
            // btnYoneticiEkle
            // 
            this.btnYoneticiEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnYoneticiEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYoneticiEkle.ForeColor = System.Drawing.Color.White;
            this.btnYoneticiEkle.Location = new System.Drawing.Point(454, 53);
            this.btnYoneticiEkle.Name = "btnYoneticiEkle";
            this.btnYoneticiEkle.Size = new System.Drawing.Size(100, 35);
            this.btnYoneticiEkle.TabIndex = 8;
            this.btnYoneticiEkle.Text = "Ekle";
            this.btnYoneticiEkle.UseVisualStyleBackColor = false;
            this.btnYoneticiEkle.Click += new System.EventHandler(this.btnYoneticiEkle_Click);
            // 
            // btnYoneticiGuncelle
            // 
            this.btnYoneticiGuncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnYoneticiGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYoneticiGuncelle.ForeColor = System.Drawing.Color.White;
            this.btnYoneticiGuncelle.Location = new System.Drawing.Point(560, 53);
            this.btnYoneticiGuncelle.Name = "btnYoneticiGuncelle";
            this.btnYoneticiGuncelle.Size = new System.Drawing.Size(100, 35);
            this.btnYoneticiGuncelle.TabIndex = 9;
            this.btnYoneticiGuncelle.Text = "Güncelle";
            this.btnYoneticiGuncelle.UseVisualStyleBackColor = false;
            this.btnYoneticiGuncelle.Click += new System.EventHandler(this.btnYoneticiGuncelle_Click);
            // 
            // btnYoneticiSil
            // 
            this.btnYoneticiSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnYoneticiSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYoneticiSil.ForeColor = System.Drawing.Color.White;
            this.btnYoneticiSil.Location = new System.Drawing.Point(666, 53);
            this.btnYoneticiSil.Name = "btnYoneticiSil";
            this.btnYoneticiSil.Size = new System.Drawing.Size(100, 35);
            this.btnYoneticiSil.TabIndex = 10;
            this.btnYoneticiSil.Text = "Sil";
            this.btnYoneticiSil.UseVisualStyleBackColor = false;
            this.btnYoneticiSil.Click += new System.EventHandler(this.btnYoneticiSil_Click);
            // 
            // txtYoneticiAdi
            // 
            this.txtYoneticiAdi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtYoneticiAdi.Location = new System.Drawing.Point(20, 30);
            this.txtYoneticiAdi.Name = "txtYoneticiAdi";
            this.txtYoneticiAdi.Size = new System.Drawing.Size(150, 27);
            this.txtYoneticiAdi.TabIndex = 1;
            // 
            // txtYoneticiSifre
            // 
            this.txtYoneticiSifre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtYoneticiSifre.Location = new System.Drawing.Point(20, 89);
            this.txtYoneticiSifre.Name = "txtYoneticiSifre";
            this.txtYoneticiSifre.Size = new System.Drawing.Size(150, 27);
            this.txtYoneticiSifre.TabIndex = 3;
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.bottomPanel.Controls.Add(this.lblYoneticiAdi);
            this.bottomPanel.Controls.Add(this.txtYoneticiAdi);
            this.bottomPanel.Controls.Add(this.lblYoneticiSifre);
            this.bottomPanel.Controls.Add(this.txtYoneticiSifre);
            this.bottomPanel.Controls.Add(this.btnYoneticiEkle);
            this.bottomPanel.Controls.Add(this.btnYoneticiGuncelle);
            this.bottomPanel.Controls.Add(this.btnYoneticiSil);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(10, 366);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Padding = new System.Windows.Forms.Padding(10);
            this.bottomPanel.Size = new System.Drawing.Size(780, 124);
            this.bottomPanel.TabIndex = 1;
            // 
            // lblYoneticiAdi
            // 
            this.lblYoneticiAdi.AutoSize = true;
            this.lblYoneticiAdi.Location = new System.Drawing.Point(17, 10);
            this.lblYoneticiAdi.Name = "lblYoneticiAdi";
            this.lblYoneticiAdi.Size = new System.Drawing.Size(43, 20);
            this.lblYoneticiAdi.TabIndex = 0;
            this.lblYoneticiAdi.Text = "Adı : ";
            // 
            // lblYoneticiSifre
            // 
            this.lblYoneticiSifre.AutoSize = true;
            this.lblYoneticiSifre.Location = new System.Drawing.Point(17, 66);
            this.lblYoneticiSifre.Name = "lblYoneticiSifre";
            this.lblYoneticiSifre.Size = new System.Drawing.Size(50, 20);
            this.lblYoneticiSifre.TabIndex = 2;
            this.lblYoneticiSifre.Text = "Şifre : ";
            // 
            // YoneticiController
            // 
            this.Controls.Add(this.dataGridViewYonetici);
            this.Controls.Add(this.bottomPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "YoneticiController";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(800, 500);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewYonetici)).EndInit();
            this.bottomPanel.ResumeLayout(false);
            this.bottomPanel.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}
