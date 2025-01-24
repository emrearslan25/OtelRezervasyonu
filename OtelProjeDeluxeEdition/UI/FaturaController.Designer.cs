using System;
using System.Drawing;
using System.Windows.Forms;

namespace OtelProjeDeluxeEdition.UI
{
    partial class FaturaController
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridViewFatura;
        private Button btnGoster;
        private TextBox txtFaturaID;
        private Panel bottomPanel;
        private Label lblFaturaID;

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
            this.dataGridViewFatura = new System.Windows.Forms.DataGridView();
            this.btnGoster = new System.Windows.Forms.Button();
            this.txtFaturaID = new System.Windows.Forms.TextBox();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.lblFaturaID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFatura)).BeginInit();
            this.bottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewFatura
            // 
            this.dataGridViewFatura.AllowUserToAddRows = false;
            this.dataGridViewFatura.AllowUserToDeleteRows = false;
            this.dataGridViewFatura.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.dataGridViewFatura.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewFatura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFatura.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewFatura.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewFatura.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewFatura.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFatura.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewFatura.ColumnHeadersHeight = 30;
            this.dataGridViewFatura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewFatura.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewFatura.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewFatura.EnableHeadersVisualStyles = false;
            this.dataGridViewFatura.Location = new System.Drawing.Point(10, 10);
            this.dataGridViewFatura.MultiSelect = false;
            this.dataGridViewFatura.Name = "dataGridViewFatura";
            this.dataGridViewFatura.ReadOnly = true;
            this.dataGridViewFatura.RowHeadersVisible = false;
            this.dataGridViewFatura.RowHeadersWidth = 51;
            this.dataGridViewFatura.RowTemplate.Height = 35;
            this.dataGridViewFatura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFatura.Size = new System.Drawing.Size(780, 350);
            this.dataGridViewFatura.TabIndex = 0;
            // 
            // btnGoster
            // 
            this.btnGoster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.btnGoster.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGoster.FlatAppearance.BorderSize = 0;
            this.btnGoster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoster.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGoster.ForeColor = System.Drawing.Color.White;
            this.btnGoster.Location = new System.Drawing.Point(180, 67);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(120, 35);
            this.btnGoster.TabIndex = 2;
            this.btnGoster.Text = "Faturayı Göster";
            this.btnGoster.UseVisualStyleBackColor = false;
            // 
            // txtFaturaID
            // 
            this.txtFaturaID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFaturaID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFaturaID.Location = new System.Drawing.Point(13, 72);
            this.txtFaturaID.Name = "txtFaturaID";
            this.txtFaturaID.ReadOnly = true;
            this.txtFaturaID.Size = new System.Drawing.Size(150, 30);
            this.txtFaturaID.TabIndex = 1;
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.bottomPanel.Controls.Add(this.lblFaturaID);
            this.bottomPanel.Controls.Add(this.txtFaturaID);
            this.bottomPanel.Controls.Add(this.btnGoster);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(10, 366);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Padding = new System.Windows.Forms.Padding(10);
            this.bottomPanel.Size = new System.Drawing.Size(780, 124);
            this.bottomPanel.TabIndex = 1;
            // 
            // lblFaturaID
            // 
            this.lblFaturaID.AutoSize = true;
            this.lblFaturaID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFaturaID.Location = new System.Drawing.Point(13, 49);
            this.lblFaturaID.Name = "lblFaturaID";
            this.lblFaturaID.Size = new System.Drawing.Size(76, 20);
            this.lblFaturaID.TabIndex = 0;
            this.lblFaturaID.Text = "Fatura No:";
            // 
            // FaturaController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dataGridViewFatura);
            this.Controls.Add(this.bottomPanel);
            this.Name = "FaturaController";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(800, 500);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFatura)).EndInit();
            this.bottomPanel.ResumeLayout(false);
            this.bottomPanel.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}