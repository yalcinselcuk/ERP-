namespace Manav
{
    partial class Frm_StokHareketListesi
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.girisFişiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışFişiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.güncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stokDatagrid = new System.Windows.Forms.DataGridView();
            this.fisNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fisTipi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.belgeNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firmaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stokDatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem,
            this.güncelleToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(91, 489);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ekleToolStripMenuItem
            // 
            this.ekleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.girisFişiToolStripMenuItem,
            this.çıkışFişiToolStripMenuItem});
            this.ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            this.ekleToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.ekleToolStripMenuItem.Text = "Ekle";
            // 
            // girisFişiToolStripMenuItem
            // 
            this.girisFişiToolStripMenuItem.Name = "girisFişiToolStripMenuItem";
            this.girisFişiToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.girisFişiToolStripMenuItem.Text = "Giriş Fişi";
            this.girisFişiToolStripMenuItem.Click += new System.EventHandler(this.girisFişiToolStripMenuItem_Click);
            // 
            // çıkışFişiToolStripMenuItem
            // 
            this.çıkışFişiToolStripMenuItem.Name = "çıkışFişiToolStripMenuItem";
            this.çıkışFişiToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.çıkışFişiToolStripMenuItem.Text = "Çıkış Fişi";
            this.çıkışFişiToolStripMenuItem.Click += new System.EventHandler(this.çıkışFişiToolStripMenuItem_Click);
            // 
            // güncelleToolStripMenuItem
            // 
            this.güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            this.güncelleToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.güncelleToolStripMenuItem.Text = "Güncelle";
            this.güncelleToolStripMenuItem.Click += new System.EventHandler(this.güncelleToolStripMenuItem_Click);
            // 
            // stokDatagrid
            // 
            this.stokDatagrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stokDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stokDatagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fisNo,
            this.fisTipi,
            this.tarih,
            this.belgeNo,
            this.aciklama,
            this.firmaId,
            this.depoId});
            this.stokDatagrid.Location = new System.Drawing.Point(164, 0);
            this.stokDatagrid.Name = "stokDatagrid";
            this.stokDatagrid.RowHeadersWidth = 51;
            this.stokDatagrid.RowTemplate.Height = 24;
            this.stokDatagrid.Size = new System.Drawing.Size(826, 489);
            this.stokDatagrid.TabIndex = 1;
            this.stokDatagrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // fisNo
            // 
            this.fisNo.DataPropertyName = "fisNo";
            this.fisNo.HeaderText = "Fiş No";
            this.fisNo.MinimumWidth = 6;
            this.fisNo.Name = "fisNo";
            this.fisNo.Width = 125;
            // 
            // fisTipi
            // 
            this.fisTipi.DataPropertyName = "fisTipi";
            this.fisTipi.HeaderText = "Fiş Tipi";
            this.fisTipi.MinimumWidth = 6;
            this.fisTipi.Name = "fisTipi";
            this.fisTipi.Width = 125;
            // 
            // tarih
            // 
            this.tarih.DataPropertyName = "tarih";
            this.tarih.HeaderText = "Tarih";
            this.tarih.MinimumWidth = 6;
            this.tarih.Name = "tarih";
            this.tarih.Width = 125;
            // 
            // belgeNo
            // 
            this.belgeNo.DataPropertyName = "belgeNo";
            this.belgeNo.HeaderText = "Belge No";
            this.belgeNo.MinimumWidth = 6;
            this.belgeNo.Name = "belgeNo";
            this.belgeNo.Width = 125;
            // 
            // aciklama
            // 
            this.aciklama.DataPropertyName = "aciklama";
            this.aciklama.HeaderText = "Açıklama";
            this.aciklama.MinimumWidth = 6;
            this.aciklama.Name = "aciklama";
            this.aciklama.Width = 125;
            // 
            // firmaId
            // 
            this.firmaId.DataPropertyName = "firmaId";
            this.firmaId.HeaderText = "Firma Id";
            this.firmaId.MinimumWidth = 6;
            this.firmaId.Name = "firmaId";
            this.firmaId.Width = 125;
            // 
            // depoId
            // 
            this.depoId.DataPropertyName = "depoId";
            this.depoId.HeaderText = "Depo Id";
            this.depoId.MinimumWidth = 6;
            this.depoId.Name = "depoId";
            this.depoId.Width = 125;
            // 
            // Frm_StokHareketListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 489);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.stokDatagrid);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_StokHareketListesi";
            this.Text = "Stok Hareket Listesi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StokHareketListesi_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stokDatagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem girisFişiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışFişiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem güncelleToolStripMenuItem;
        private System.Windows.Forms.DataGridView stokDatagrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn fisNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fisTipi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn belgeNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn aciklama;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn depoId;
    }
}