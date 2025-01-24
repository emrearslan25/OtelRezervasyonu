namespace OtelProjeDeluxeEdition.UI
{
    partial class Giris
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewGiris;
        private System.Windows.Forms.TextBox txtGiris;
        private System.Windows.Forms.TextBox txtGirisSifre;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel bottomPanel;

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
            this.dataGridViewGiris = new System.Windows.Forms.DataGridView();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGiris = new System.Windows.Forms.Button();
            this.txtGirisSifre = new System.Windows.Forms.TextBox();
            this.txtGiris = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGiris)).BeginInit();
            this.bottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewGiris
            // 
            this.dataGridViewGiris.AllowUserToAddRows = false;
            this.dataGridViewGiris.AllowUserToDeleteRows = false;
            this.dataGridViewGiris.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewGiris.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewGiris.ColumnHeadersHeight = 29;
            this.dataGridViewGiris.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewGiris.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewGiris.Name = "dataGridViewGiris";
            this.dataGridViewGiris.ReadOnly = true;
            this.dataGridViewGiris.RowHeadersWidth = 51;
            this.dataGridViewGiris.Size = new System.Drawing.Size(240, 0);
            this.dataGridViewGiris.TabIndex = 0;
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.bottomPanel.Controls.Add(this.label2);
            this.bottomPanel.Controls.Add(this.label1);
            this.bottomPanel.Controls.Add(this.btnGiris);
            this.bottomPanel.Controls.Add(this.txtGirisSifre);
            this.bottomPanel.Controls.Add(this.txtGiris);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomPanel.Location = new System.Drawing.Point(10, 12);
            this.bottomPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Padding = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.bottomPanel.Size = new System.Drawing.Size(380, 601);
            this.bottomPanel.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(93, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(93, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiris.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnGiris.ForeColor = System.Drawing.Color.White;
            this.btnGiris.Location = new System.Drawing.Point(93, 380);
            this.btnGiris.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(200, 44);
            this.btnGiris.TabIndex = 2;
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // txtGirisSifre
            // 
            this.txtGirisSifre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtGirisSifre.Location = new System.Drawing.Point(93, 270);
            this.txtGirisSifre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGirisSifre.Name = "txtGirisSifre";
            this.txtGirisSifre.Size = new System.Drawing.Size(200, 30);
            this.txtGirisSifre.TabIndex = 1;
            this.txtGirisSifre.UseSystemPasswordChar = true;
            // 
            // txtGiris
            // 
            this.txtGiris.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtGiris.Location = new System.Drawing.Point(93, 196);
            this.txtGiris.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGiris.Name = "txtGiris";
            this.txtGiris.Size = new System.Drawing.Size(200, 30);
            this.txtGiris.TabIndex = 0;
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 625);
            this.Controls.Add(this.bottomPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Giris";
            this.Padding = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGiris)).EndInit();
            this.bottomPanel.ResumeLayout(false);
            this.bottomPanel.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}