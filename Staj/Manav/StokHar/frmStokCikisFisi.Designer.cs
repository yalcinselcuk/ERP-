namespace Manav.StokHar
{
    partial class frmStokCikisFisi
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fisNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fisTipi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.belgeNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firmaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firmaKod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depoKod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.renkId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birimId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunKod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.renkKod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birimKod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addButton = new System.Windows.Forms.Button();
            this.addandcloseButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.fisNo,
            this.fisTipi,
            this.tarih,
            this.belgeNo,
            this.aciklama,
            this.firmaId,
            this.depoId,
            this.firmaKod,
            this.depoKod,
            this.mainId,
            this.urunId,
            this.renkId,
            this.birimId,
            this.urunKod,
            this.renkKod,
            this.birimKod,
            this.miktar});
            this.dataGridView1.Location = new System.Drawing.Point(0, 32);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(924, 476);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
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
            this.fisTipi.Visible = false;
            this.fisTipi.Width = 125;
            // 
            // tarih
            // 
            this.tarih.DataPropertyName = "tarih";
            this.tarih.HeaderText = "Tarih";
            this.tarih.MinimumWidth = 6;
            this.tarih.Name = "tarih";
            this.tarih.Visible = false;
            this.tarih.Width = 125;
            // 
            // belgeNo
            // 
            this.belgeNo.DataPropertyName = "belgeNo";
            this.belgeNo.HeaderText = "Belge No";
            this.belgeNo.MinimumWidth = 6;
            this.belgeNo.Name = "belgeNo";
            this.belgeNo.Visible = false;
            this.belgeNo.Width = 125;
            // 
            // aciklama
            // 
            this.aciklama.DataPropertyName = "aciklama";
            this.aciklama.HeaderText = "Açıklama";
            this.aciklama.MinimumWidth = 6;
            this.aciklama.Name = "aciklama";
            this.aciklama.Visible = false;
            this.aciklama.Width = 125;
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
            // depoId
            // 
            this.depoId.DataPropertyName = "depoId";
            this.depoId.HeaderText = "Depo Id";
            this.depoId.MinimumWidth = 6;
            this.depoId.Name = "depoId";
            this.depoId.Visible = false;
            this.depoId.Width = 125;
            // 
            // firmaKod
            // 
            this.firmaKod.DataPropertyName = "firmaKod";
            this.firmaKod.HeaderText = "Firma";
            this.firmaKod.MinimumWidth = 6;
            this.firmaKod.Name = "firmaKod";
            this.firmaKod.Width = 125;
            // 
            // depoKod
            // 
            this.depoKod.DataPropertyName = "depoKod";
            this.depoKod.HeaderText = "Depo";
            this.depoKod.MinimumWidth = 6;
            this.depoKod.Name = "depoKod";
            this.depoKod.Width = 125;
            // 
            // mainId
            // 
            this.mainId.DataPropertyName = "mainId";
            this.mainId.HeaderText = "Main Id";
            this.mainId.MinimumWidth = 6;
            this.mainId.Name = "mainId";
            this.mainId.Visible = false;
            this.mainId.Width = 125;
            // 
            // urunId
            // 
            this.urunId.DataPropertyName = "urunId";
            this.urunId.HeaderText = "Ürün Id";
            this.urunId.MinimumWidth = 6;
            this.urunId.Name = "urunId";
            this.urunId.Visible = false;
            this.urunId.Width = 125;
            // 
            // renkId
            // 
            this.renkId.DataPropertyName = "renkId";
            this.renkId.HeaderText = "Renk Id";
            this.renkId.MinimumWidth = 6;
            this.renkId.Name = "renkId";
            this.renkId.Visible = false;
            this.renkId.Width = 125;
            // 
            // birimId
            // 
            this.birimId.DataPropertyName = "birimId";
            this.birimId.HeaderText = "Birim Id";
            this.birimId.MinimumWidth = 6;
            this.birimId.Name = "birimId";
            this.birimId.Visible = false;
            this.birimId.Width = 125;
            // 
            // urunKod
            // 
            this.urunKod.DataPropertyName = "urunKod";
            this.urunKod.HeaderText = "Ürün";
            this.urunKod.MinimumWidth = 6;
            this.urunKod.Name = "urunKod";
            this.urunKod.Width = 125;
            // 
            // renkKod
            // 
            this.renkKod.DataPropertyName = "renkKod";
            this.renkKod.HeaderText = "Renk";
            this.renkKod.MinimumWidth = 6;
            this.renkKod.Name = "renkKod";
            this.renkKod.Width = 125;
            // 
            // birimKod
            // 
            this.birimKod.DataPropertyName = "birimKod";
            this.birimKod.HeaderText = "Birim";
            this.birimKod.MinimumWidth = 6;
            this.birimKod.Name = "birimKod";
            this.birimKod.Width = 125;
            // 
            // miktar
            // 
            this.miktar.DataPropertyName = "miktar";
            this.miktar.HeaderText = "Miktar";
            this.miktar.MinimumWidth = 6;
            this.miktar.Name = "miktar";
            this.miktar.Width = 125;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(0, 0);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(80, 32);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Ekle";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // addandcloseButton
            // 
            this.addandcloseButton.Location = new System.Drawing.Point(80, 0);
            this.addandcloseButton.Name = "addandcloseButton";
            this.addandcloseButton.Size = new System.Drawing.Size(148, 32);
            this.addandcloseButton.TabIndex = 2;
            this.addandcloseButton.Text = "Ekle ve Kapat";
            this.addandcloseButton.UseVisualStyleBackColor = true;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(228, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(92, 32);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "Kapat";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // frmStokGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 510);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.addandcloseButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(946, 557);
            this.MinimumSize = new System.Drawing.Size(946, 557);
            this.Name = "frmStokGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Giriş Fişleri";
            this.Load += new System.EventHandler(this.frmStokGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fisNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fisTipi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn belgeNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn aciklama;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn depoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmaKod;
        private System.Windows.Forms.DataGridViewTextBoxColumn depoKod;
        private System.Windows.Forms.DataGridViewTextBoxColumn mainId;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunId;
        private System.Windows.Forms.DataGridViewTextBoxColumn renkId;
        private System.Windows.Forms.DataGridViewTextBoxColumn birimId;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunKod;
        private System.Windows.Forms.DataGridViewTextBoxColumn renkKod;
        private System.Windows.Forms.DataGridViewTextBoxColumn birimKod;
        private System.Windows.Forms.DataGridViewTextBoxColumn miktar;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button addandcloseButton;
        private System.Windows.Forms.Button closeButton;
    }
}