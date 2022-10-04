namespace Manav.StokHar
{
    partial class frmStokHar
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
            this.components = new System.ComponentModel.Container();
            this.depoComboBox = new System.Windows.Forms.ComboBox();
            this.main = new System.Data.DataTable();
            this.details = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataSet1 = new System.Data.DataSet();
            this.saveButtons = new System.Windows.Forms.Button();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.fisNoTextBox = new System.Windows.Forms.TextBox();
            this.belgeNoTextBox = new System.Windows.Forms.TextBox();
            this.fisNoLabel = new System.Windows.Forms.Label();
            this.tarihNoLabel = new System.Windows.Forms.Label();
            this.aciklamaTextBox = new System.Windows.Forms.RichTextBox();
            this.belgeNoLabel = new System.Windows.Forms.Label();
            this.tarihBox = new System.Windows.Forms.DateTimePicker();
            this.aciklamaLabel = new System.Windows.Forms.Label();
            this.firmaLabel = new System.Windows.Forms.Label();
            this.depoLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.panelRight = new System.Windows.Forms.Panel();
            this.firmaComboBox = new System.Windows.Forms.ComboBox();
            this.dataGridFis = new System.Windows.Forms.DataGridView();
            this.urunKod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.renkKod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birimKod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.renkId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birimId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closeButton = new System.Windows.Forms.Button();
            this.addrow = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dsStokHar1 = new Manav.StokHar.dsStokHar();
            this.sihirbaziac = new System.Windows.Forms.Button();
            this.tblFisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.details)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStokHar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFisBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // depoComboBox
            // 
            this.depoComboBox.FormattingEnabled = true;
            this.depoComboBox.Location = new System.Drawing.Point(88, 52);
            this.depoComboBox.Name = "depoComboBox";
            this.depoComboBox.Size = new System.Drawing.Size(222, 28);
            this.depoComboBox.TabIndex = 4;
            // 
            // main
            // 
            this.main.TableName = "Main";
            // 
            // details
            // 
            this.details.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4});
            this.details.TableName = "Details";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "urun";
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "renk";
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "birim";
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "miktar";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            this.dataSet1.Tables.AddRange(new System.Data.DataTable[] {
            this.main,
            this.details});
            // 
            // saveButtons
            // 
            this.saveButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButtons.AutoSize = true;
            this.saveButtons.Location = new System.Drawing.Point(808, 440);
            this.saveButtons.Name = "saveButtons";
            this.saveButtons.Size = new System.Drawing.Size(155, 42);
            this.saveButtons.TabIndex = 8;
            this.saveButtons.Text = "Kaydet";
            this.saveButtons.UseVisualStyleBackColor = true;
            this.saveButtons.Click += new System.EventHandler(this.saveButtons_Click);
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.fisNoTextBox);
            this.panelLeft.Controls.Add(this.belgeNoTextBox);
            this.panelLeft.Controls.Add(this.fisNoLabel);
            this.panelLeft.Controls.Add(this.tarihNoLabel);
            this.panelLeft.Controls.Add(this.aciklamaTextBox);
            this.panelLeft.Controls.Add(this.belgeNoLabel);
            this.panelLeft.Controls.Add(this.tarihBox);
            this.panelLeft.Controls.Add(this.aciklamaLabel);
            this.panelLeft.Location = new System.Drawing.Point(4, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(452, 152);
            this.panelLeft.TabIndex = 1;
            // 
            // fisNoTextBox
            // 
            this.fisNoTextBox.Location = new System.Drawing.Point(114, 11);
            this.fisNoTextBox.Name = "fisNoTextBox";
            this.fisNoTextBox.ReadOnly = true;
            this.fisNoTextBox.Size = new System.Drawing.Size(324, 27);
            this.fisNoTextBox.TabIndex = 1;
            // 
            // belgeNoTextBox
            // 
            this.belgeNoTextBox.Location = new System.Drawing.Point(112, 76);
            this.belgeNoTextBox.Name = "belgeNoTextBox";
            this.belgeNoTextBox.Size = new System.Drawing.Size(324, 27);
            this.belgeNoTextBox.TabIndex = 4;
            // 
            // fisNoLabel
            // 
            this.fisNoLabel.AutoSize = true;
            this.fisNoLabel.Location = new System.Drawing.Point(24, 13);
            this.fisNoLabel.Name = "fisNoLabel";
            this.fisNoLabel.Size = new System.Drawing.Size(76, 20);
            this.fisNoLabel.TabIndex = 0;
            this.fisNoLabel.Text = "Fiş No :";
            // 
            // tarihNoLabel
            // 
            this.tarihNoLabel.AutoSize = true;
            this.tarihNoLabel.Location = new System.Drawing.Point(36, 48);
            this.tarihNoLabel.Name = "tarihNoLabel";
            this.tarihNoLabel.Size = new System.Drawing.Size(64, 20);
            this.tarihNoLabel.TabIndex = 1;
            this.tarihNoLabel.Text = "Tarih :";
            // 
            // aciklamaTextBox
            // 
            this.aciklamaTextBox.Location = new System.Drawing.Point(112, 108);
            this.aciklamaTextBox.Multiline = false;
            this.aciklamaTextBox.Name = "aciklamaTextBox";
            this.aciklamaTextBox.Size = new System.Drawing.Size(324, 28);
            this.aciklamaTextBox.TabIndex = 5;
            this.aciklamaTextBox.Text = "";
            // 
            // belgeNoLabel
            // 
            this.belgeNoLabel.AutoSize = true;
            this.belgeNoLabel.Location = new System.Drawing.Point(2, 78);
            this.belgeNoLabel.Name = "belgeNoLabel";
            this.belgeNoLabel.Size = new System.Drawing.Size(98, 20);
            this.belgeNoLabel.TabIndex = 2;
            this.belgeNoLabel.Text = "Belge No :";
            // 
            // tarihBox
            // 
            this.tarihBox.CustomFormat = "dd//MM/yyyy";
            this.tarihBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tarihBox.Location = new System.Drawing.Point(112, 44);
            this.tarihBox.Name = "tarihBox";
            this.tarihBox.Size = new System.Drawing.Size(158, 27);
            this.tarihBox.TabIndex = 1;
            this.tarihBox.Value = new System.DateTime(2022, 9, 28, 0, 0, 0, 0);
            // 
            // aciklamaLabel
            // 
            this.aciklamaLabel.AutoSize = true;
            this.aciklamaLabel.Location = new System.Drawing.Point(3, 110);
            this.aciklamaLabel.Name = "aciklamaLabel";
            this.aciklamaLabel.Size = new System.Drawing.Size(97, 20);
            this.aciklamaLabel.TabIndex = 3;
            this.aciklamaLabel.Text = "Açıklama :";
            // 
            // firmaLabel
            // 
            this.firmaLabel.AutoSize = true;
            this.firmaLabel.Location = new System.Drawing.Point(15, 14);
            this.firmaLabel.Name = "firmaLabel";
            this.firmaLabel.Size = new System.Drawing.Size(69, 20);
            this.firmaLabel.TabIndex = 8;
            this.firmaLabel.Text = "Firma :";
            // 
            // depoLabel
            // 
            this.depoLabel.AutoSize = true;
            this.depoLabel.Location = new System.Drawing.Point(15, 54);
            this.depoLabel.Name = "depoLabel";
            this.depoLabel.Size = new System.Drawing.Size(65, 20);
            this.depoLabel.TabIndex = 9;
            this.depoLabel.Text = "Depo :";
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.AutoSize = true;
            this.deleteButton.Location = new System.Drawing.Point(652, 440);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(148, 42);
            this.deleteButton.TabIndex = 7;
            this.deleteButton.Text = "Sil";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.sihirbaziac);
            this.panelRight.Controls.Add(this.firmaComboBox);
            this.panelRight.Controls.Add(this.firmaLabel);
            this.panelRight.Controls.Add(this.depoLabel);
            this.panelRight.Controls.Add(this.depoComboBox);
            this.panelRight.Location = new System.Drawing.Point(460, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(418, 152);
            this.panelRight.TabIndex = 2;
            // 
            // firmaComboBox
            // 
            this.firmaComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.firmaComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.firmaComboBox.FormattingEnabled = true;
            this.firmaComboBox.Location = new System.Drawing.Point(88, 12);
            this.firmaComboBox.Name = "firmaComboBox";
            this.firmaComboBox.Size = new System.Drawing.Size(224, 28);
            this.firmaComboBox.TabIndex = 10;
            // 
            // dataGridFis
            // 
            this.dataGridFis.AllowUserToAddRows = false;
            this.dataGridFis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridFis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridFis.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridFis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urunKod,
            this.renkKod,
            this.birimKod,
            this.miktar,
            this.id,
            this.mainId,
            this.urunId,
            this.renkId,
            this.birimId});
            this.dataGridFis.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.dataSet1, "Details.miktar", true));
            this.dataGridFis.Location = new System.Drawing.Point(4, 184);
            this.dataGridFis.MultiSelect = false;
            this.dataGridFis.Name = "dataGridFis";
            this.dataGridFis.ReadOnly = true;
            this.dataGridFis.RowHeadersWidth = 51;
            this.dataGridFis.RowTemplate.Height = 24;
            this.dataGridFis.Size = new System.Drawing.Size(960, 248);
            this.dataGridFis.TabIndex = 4;
            this.dataGridFis.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridFis_CellDoubleClick);
            this.dataGridFis.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridFis_DataBindingComplete);
            this.dataGridFis.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridFis_DataError);
            // 
            // urunKod
            // 
            this.urunKod.DataPropertyName = "urunKod";
            this.urunKod.HeaderText = "Ürün";
            this.urunKod.MinimumWidth = 6;
            this.urunKod.Name = "urunKod";
            this.urunKod.ReadOnly = true;
            // 
            // renkKod
            // 
            this.renkKod.DataPropertyName = "renkKod";
            this.renkKod.HeaderText = "Renk";
            this.renkKod.MinimumWidth = 6;
            this.renkKod.Name = "renkKod";
            this.renkKod.ReadOnly = true;
            this.renkKod.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.renkKod.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // birimKod
            // 
            this.birimKod.DataPropertyName = "birimKod";
            this.birimKod.HeaderText = "Birim";
            this.birimKod.MinimumWidth = 6;
            this.birimKod.Name = "birimKod";
            this.birimKod.ReadOnly = true;
            this.birimKod.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.birimKod.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // miktar
            // 
            this.miktar.DataPropertyName = "miktar";
            this.miktar.HeaderText = "Miktar";
            this.miktar.MinimumWidth = 6;
            this.miktar.Name = "miktar";
            this.miktar.ReadOnly = true;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // mainId
            // 
            this.mainId.DataPropertyName = "mainId";
            this.mainId.HeaderText = "MainId";
            this.mainId.MinimumWidth = 6;
            this.mainId.Name = "mainId";
            this.mainId.ReadOnly = true;
            this.mainId.Visible = false;
            // 
            // urunId
            // 
            this.urunId.DataPropertyName = "urunId";
            this.urunId.HeaderText = "UrunId";
            this.urunId.MinimumWidth = 6;
            this.urunId.Name = "urunId";
            this.urunId.ReadOnly = true;
            this.urunId.Visible = false;
            // 
            // renkId
            // 
            this.renkId.DataPropertyName = "renkId";
            this.renkId.HeaderText = "RenkId";
            this.renkId.MinimumWidth = 6;
            this.renkId.Name = "renkId";
            this.renkId.ReadOnly = true;
            this.renkId.Visible = false;
            // 
            // birimId
            // 
            this.birimId.DataPropertyName = "birimId";
            this.birimId.HeaderText = "BirimId";
            this.birimId.MinimumWidth = 6;
            this.birimId.Name = "birimId";
            this.birimId.ReadOnly = true;
            this.birimId.Visible = false;
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.AutoSize = true;
            this.closeButton.Location = new System.Drawing.Point(488, 440);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(155, 42);
            this.closeButton.TabIndex = 10;
            this.closeButton.Text = "Kapat";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // addrow
            // 
            this.addrow.Location = new System.Drawing.Point(4, 160);
            this.addrow.Name = "addrow";
            this.addrow.Size = new System.Drawing.Size(32, 24);
            this.addrow.TabIndex = 11;
            this.addrow.Text = "+";
            this.toolTip1.SetToolTip(this.addrow, "Satır Ekle");
            this.addrow.UseVisualStyleBackColor = true;
            this.addrow.Click += new System.EventHandler(this.addrow_Click);
            // 
            // dsStokHar1
            // 
            this.dsStokHar1.DataSetName = "dsStokHar";
            this.dsStokHar1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sihirbaziac
            // 
            this.sihirbaziac.Location = new System.Drawing.Point(88, 92);
            this.sihirbaziac.Name = "sihirbaziac";
            this.sihirbaziac.Size = new System.Drawing.Size(220, 28);
            this.sihirbaziac.TabIndex = 11;
            this.sihirbaziac.Text = "Sihirbazı Aç";
            this.sihirbaziac.UseVisualStyleBackColor = true;
            this.sihirbaziac.Visible = false;
            this.sihirbaziac.Click += new System.EventHandler(this.sihirbaziac_Click);
            // 
            // tblFisBindingSource
            // 
            this.tblFisBindingSource.DataMember = "Tbl_Fis";
            // 
            // frmStokHar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(974, 486);
            this.Controls.Add(this.addrow);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.saveButtons);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.dataGridFis);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmStokHar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fiş";
            this.Load += new System.EventHandler(this.frmStokHar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.details)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsStokHar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFisBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox depoComboBox;
        private System.Windows.Forms.BindingSource tblFisBindingSource;
        private System.Data.DataTable main;
        private System.Data.DataTable details;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.Button saveButtons;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.TextBox fisNoTextBox;
        private System.Windows.Forms.TextBox belgeNoTextBox;
        private System.Windows.Forms.Label fisNoLabel;
        private System.Windows.Forms.Label tarihNoLabel;
        private System.Windows.Forms.RichTextBox aciklamaTextBox;
        private System.Windows.Forms.Label belgeNoLabel;
        private System.Windows.Forms.DateTimePicker tarihBox;
        private System.Windows.Forms.Label aciklamaLabel;
        private System.Windows.Forms.Label firmaLabel;
        private System.Windows.Forms.Label depoLabel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Panel panelRight;
        public System.Windows.Forms.DataGridView dataGridFis;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button addrow;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunKod;
        private System.Windows.Forms.DataGridViewTextBoxColumn renkKod;
        private System.Windows.Forms.DataGridViewTextBoxColumn birimKod;
        private System.Windows.Forms.DataGridViewTextBoxColumn miktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn mainId;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunId;
        private System.Windows.Forms.DataGridViewTextBoxColumn renkId;
        private System.Windows.Forms.DataGridViewTextBoxColumn birimId;
        private dsStokHar dsStokHar1;
        private System.Windows.Forms.ComboBox firmaComboBox;
        private System.Windows.Forms.Button sihirbaziac;
    }
}