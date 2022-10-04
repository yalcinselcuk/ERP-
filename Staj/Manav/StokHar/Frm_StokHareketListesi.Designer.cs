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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.girisFişiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışFişiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.güncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datagridstok = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fisKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fisNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fisTipi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.belgeNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firmaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firmaKod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depoKod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridstok)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekleToolStripMenuItem,
            this.güncelleToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 4);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(11, 2, 0, 2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(143, 54);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ekleToolStripMenuItem
            // 
            this.ekleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.girisFişiToolStripMenuItem,
            this.çıkışFişiToolStripMenuItem});
            this.ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            this.ekleToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.ekleToolStripMenuItem.Text = "Yeni Kayıt";
            // 
            // girisFişiToolStripMenuItem
            // 
            this.girisFişiToolStripMenuItem.Name = "girisFişiToolStripMenuItem";
            this.girisFişiToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.girisFişiToolStripMenuItem.Text = "Giriş Fişi";
            this.girisFişiToolStripMenuItem.Click += new System.EventHandler(this.girisFişiToolStripMenuItem_Click);
            // 
            // çıkışFişiToolStripMenuItem
            // 
            this.çıkışFişiToolStripMenuItem.Name = "çıkışFişiToolStripMenuItem";
            this.çıkışFişiToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.çıkışFişiToolStripMenuItem.Text = "Çıkış Fişi";
            this.çıkışFişiToolStripMenuItem.Click += new System.EventHandler(this.çıkışFişiToolStripMenuItem_Click);
            // 
            // güncelleToolStripMenuItem
            // 
            this.güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            this.güncelleToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.güncelleToolStripMenuItem.Text = "Listeyi Güncelle";
            this.güncelleToolStripMenuItem.Click += new System.EventHandler(this.güncelleToolStripMenuItem_Click);
            // 
            // datagridstok
            // 
            this.datagridstok.AllowUserToAddRows = false;
            this.datagridstok.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.datagridstok.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridstok.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagridstok.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.datagridstok.BackgroundColor = System.Drawing.SystemColors.Window;
            this.datagridstok.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridstok.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagridstok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridstok.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.fisKodu,
            this.fisNo,
            this.fisTipi,
            this.tarih,
            this.belgeNo,
            this.aciklama,
            this.firmaId,
            this.firmaKod,
            this.depoId,
            this.depoKod});
            this.datagridstok.EnableHeadersVisualStyles = false;
            this.datagridstok.Location = new System.Drawing.Point(136, 0);
            this.datagridstok.Name = "datagridstok";
            this.datagridstok.RowHeadersWidth = 51;
            this.datagridstok.RowTemplate.Height = 24;
            this.datagridstok.Size = new System.Drawing.Size(854, 489);
            this.datagridstok.TabIndex = 1;
            this.datagridstok.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.datagridstok.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.stokDatagrid_DataBindingComplete);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Visible = false;
            this.id.Width = 125;
            // 
            // fisKodu
            // 
            this.fisKodu.DataPropertyName = "Fiş Kodu";
            this.fisKodu.HeaderText = "Fiş Kodu";
            this.fisKodu.MinimumWidth = 6;
            this.fisKodu.Name = "fisKodu";
            this.fisKodu.Width = 112;
            // 
            // fisNo
            // 
            this.fisNo.DataPropertyName = "fisNo";
            this.fisNo.HeaderText = "Fiş No";
            this.fisNo.MinimumWidth = 6;
            this.fisNo.Name = "fisNo";
            this.fisNo.Width = 93;
            // 
            // fisTipi
            // 
            this.fisTipi.DataPropertyName = "fisTipi";
            this.fisTipi.HeaderText = "Fiş Tipi";
            this.fisTipi.MinimumWidth = 6;
            this.fisTipi.Name = "fisTipi";
            this.fisTipi.Visible = false;
            this.fisTipi.Width = 125;
            // 
            // tarih
            // 
            this.tarih.DataPropertyName = "tarih";
            this.tarih.HeaderText = "Tarih";
            this.tarih.MinimumWidth = 6;
            this.tarih.Name = "tarih";
            this.tarih.Width = 81;
            // 
            // belgeNo
            // 
            this.belgeNo.DataPropertyName = "belgeNo";
            this.belgeNo.HeaderText = "Belge No";
            this.belgeNo.MinimumWidth = 6;
            this.belgeNo.Name = "belgeNo";
            this.belgeNo.Width = 115;
            // 
            // aciklama
            // 
            this.aciklama.DataPropertyName = "aciklama";
            this.aciklama.HeaderText = "Açıklama";
            this.aciklama.MinimumWidth = 6;
            this.aciklama.Name = "aciklama";
            this.aciklama.Width = 114;
            // 
            // firmaId
            // 
            this.firmaId.DataPropertyName = "firmaId";
            this.firmaId.HeaderText = "Firma Id";
            this.firmaId.MinimumWidth = 6;
            this.firmaId.Name = "firmaId";
            this.firmaId.Visible = false;
            this.firmaId.Width = 125;
            // 
            // firmaKod
            // 
            this.firmaKod.DataPropertyName = "firmaKod";
            this.firmaKod.HeaderText = "Firma Kodu";
            this.firmaKod.MinimumWidth = 6;
            this.firmaKod.Name = "firmaKod";
            this.firmaKod.Width = 134;
            // 
            // depoId
            // 
            this.depoId.DataPropertyName = "depoId";
            this.depoId.HeaderText = "Depo Id";
            this.depoId.MinimumWidth = 6;
            this.depoId.Name = "depoId";
            this.depoId.Visible = false;
            this.depoId.Width = 125;
            // 
            // depoKod
            // 
            this.depoKod.DataPropertyName = "depoKod";
            this.depoKod.HeaderText = "Depo Kodu";
            this.depoKod.MinimumWidth = 6;
            this.depoKod.Name = "depoKod";
            this.depoKod.Width = 130;
            // 
            // Frm_StokHareketListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(989, 489);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.datagridstok);
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
            ((System.ComponentModel.ISupportInitialize)(this.datagridstok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem girisFişiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışFişiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem güncelleToolStripMenuItem;
        private System.Windows.Forms.DataGridView datagridstok;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fisKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn fisNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fisTipi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn belgeNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn aciklama;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmaKod;
        private System.Windows.Forms.DataGridViewTextBoxColumn depoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn depoKod;
    }
}