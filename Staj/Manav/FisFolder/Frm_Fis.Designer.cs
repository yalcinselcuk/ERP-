namespace Manav
{
    partial class Fis
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
            this.panelLeft = new System.Windows.Forms.Panel();
            this.fisNoTextBox = new System.Windows.Forms.TextBox();
            this.belgeNoTextBox = new System.Windows.Forms.TextBox();
            this.fisNoLabel = new System.Windows.Forms.Label();
            this.tarihNoLabel = new System.Windows.Forms.Label();
            this.aciklamaTextBox = new System.Windows.Forms.RichTextBox();
            this.belgeNoLabel = new System.Windows.Forms.Label();
            this.tarihBox = new System.Windows.Forms.DateTimePicker();
            this.aciklamaLabel = new System.Windows.Forms.Label();
            this.panelRight = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.firmaLabel = new System.Windows.Forms.Label();
            this.depoLabel = new System.Windows.Forms.Label();
            this.firmaComboBox = new System.Windows.Forms.ComboBox();
            this.depoComboBox = new System.Windows.Forms.ComboBox();
            this.saveButtons = new System.Windows.Forms.Button();
            this.dataGridFis = new System.Windows.Forms.DataGridView();
            this.tblFisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new System.Data.DataSet();
            this.main = new System.Data.DataTable();
            this.details = new System.Data.DataTable();
            this.deleteButton = new System.Windows.Forms.Button();
            this.urun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.renk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.renkId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birimId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.details)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLeft.Controls.Add(this.fisNoTextBox);
            this.panelLeft.Controls.Add(this.belgeNoTextBox);
            this.panelLeft.Controls.Add(this.fisNoLabel);
            this.panelLeft.Controls.Add(this.tarihNoLabel);
            this.panelLeft.Controls.Add(this.aciklamaTextBox);
            this.panelLeft.Controls.Add(this.belgeNoLabel);
            this.panelLeft.Controls.Add(this.tarihBox);
            this.panelLeft.Controls.Add(this.aciklamaLabel);
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(601, 331);
            this.panelLeft.TabIndex = 26;
            // 
            // fisNoTextBox
            // 
            this.fisNoTextBox.Location = new System.Drawing.Point(114, 31);
            this.fisNoTextBox.Name = "fisNoTextBox";
            this.fisNoTextBox.ReadOnly = true;
            this.fisNoTextBox.Size = new System.Drawing.Size(324, 28);
            this.fisNoTextBox.TabIndex = 100;
            // 
            // belgeNoTextBox
            // 
            this.belgeNoTextBox.Location = new System.Drawing.Point(114, 134);
            this.belgeNoTextBox.Name = "belgeNoTextBox";
            this.belgeNoTextBox.Size = new System.Drawing.Size(324, 28);
            this.belgeNoTextBox.TabIndex = 1;
            // 
            // fisNoLabel
            // 
            this.fisNoLabel.AutoSize = true;
            this.fisNoLabel.Location = new System.Drawing.Point(4, 31);
            this.fisNoLabel.Name = "fisNoLabel";
            this.fisNoLabel.Size = new System.Drawing.Size(80, 22);
            this.fisNoLabel.TabIndex = 0;
            this.fisNoLabel.Text = "Fiş No :";
            // 
            // tarihNoLabel
            // 
            this.tarihNoLabel.AutoSize = true;
            this.tarihNoLabel.Location = new System.Drawing.Point(4, 89);
            this.tarihNoLabel.Name = "tarihNoLabel";
            this.tarihNoLabel.Size = new System.Drawing.Size(69, 22);
            this.tarihNoLabel.TabIndex = 1;
            this.tarihNoLabel.Text = "Tarih :";
            // 
            // aciklamaTextBox
            // 
            this.aciklamaTextBox.Location = new System.Drawing.Point(114, 190);
            this.aciklamaTextBox.Name = "aciklamaTextBox";
            this.aciklamaTextBox.Size = new System.Drawing.Size(324, 57);
            this.aciklamaTextBox.TabIndex = 2;
            this.aciklamaTextBox.Text = "";
            // 
            // belgeNoLabel
            // 
            this.belgeNoLabel.AutoSize = true;
            this.belgeNoLabel.Location = new System.Drawing.Point(4, 134);
            this.belgeNoLabel.Name = "belgeNoLabel";
            this.belgeNoLabel.Size = new System.Drawing.Size(104, 22);
            this.belgeNoLabel.TabIndex = 2;
            this.belgeNoLabel.Text = "Belge No :";
            // 
            // tarihBox
            // 
            this.tarihBox.CustomFormat = "dd//MM/yyyy";
            this.tarihBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tarihBox.Location = new System.Drawing.Point(114, 83);
            this.tarihBox.Name = "tarihBox";
            this.tarihBox.Size = new System.Drawing.Size(139, 28);
            this.tarihBox.TabIndex = 0;
            this.tarihBox.Value = new System.DateTime(2022, 7, 18, 0, 0, 0, 0);
            // 
            // aciklamaLabel
            // 
            this.aciklamaLabel.AutoSize = true;
            this.aciklamaLabel.Location = new System.Drawing.Point(4, 190);
            this.aciklamaLabel.Name = "aciklamaLabel";
            this.aciklamaLabel.Size = new System.Drawing.Size(102, 22);
            this.aciklamaLabel.TabIndex = 3;
            this.aciklamaLabel.Text = "Açıklama :";
            // 
            // panelRight
            // 
            this.panelRight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRight.Controls.Add(this.label4);
            this.panelRight.Controls.Add(this.comboBox2);
            this.panelRight.Controls.Add(this.label3);
            this.panelRight.Controls.Add(this.comboBox1);
            this.panelRight.Controls.Add(this.firmaLabel);
            this.panelRight.Controls.Add(this.depoLabel);
            this.panelRight.Controls.Add(this.firmaComboBox);
            this.panelRight.Controls.Add(this.depoComboBox);
            this.panelRight.Location = new System.Drawing.Point(602, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(402, 331);
            this.panelRight.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 22);
            this.label4.TabIndex = 16;
            this.label4.Text = "Depo Id :";
            this.label4.Visible = false;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(140, 156);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(222, 30);
            this.comboBox2.TabIndex = 17;
            this.comboBox2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 22);
            this.label3.TabIndex = 14;
            this.label3.Text = "Firma Id :";
            this.label3.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(141, 120);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(222, 30);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.Visible = false;
            // 
            // firmaLabel
            // 
            this.firmaLabel.AutoSize = true;
            this.firmaLabel.Location = new System.Drawing.Point(39, 22);
            this.firmaLabel.Name = "firmaLabel";
            this.firmaLabel.Size = new System.Drawing.Size(72, 22);
            this.firmaLabel.TabIndex = 8;
            this.firmaLabel.Text = "Firma :";
            // 
            // depoLabel
            // 
            this.depoLabel.AutoSize = true;
            this.depoLabel.Location = new System.Drawing.Point(39, 79);
            this.depoLabel.Name = "depoLabel";
            this.depoLabel.Size = new System.Drawing.Size(69, 22);
            this.depoLabel.TabIndex = 9;
            this.depoLabel.Text = "Depo :";
            // 
            // firmaComboBox
            // 
            this.firmaComboBox.FormattingEnabled = true;
            this.firmaComboBox.Location = new System.Drawing.Point(140, 22);
            this.firmaComboBox.Name = "firmaComboBox";
            this.firmaComboBox.Size = new System.Drawing.Size(222, 30);
            this.firmaComboBox.TabIndex = 3;
            // 
            // depoComboBox
            // 
            this.depoComboBox.FormattingEnabled = true;
            this.depoComboBox.Location = new System.Drawing.Point(140, 77);
            this.depoComboBox.Name = "depoComboBox";
            this.depoComboBox.Size = new System.Drawing.Size(222, 30);
            this.depoComboBox.TabIndex = 4;
            // 
            // saveButtons
            // 
            this.saveButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButtons.Location = new System.Drawing.Point(837, 529);
            this.saveButtons.Name = "saveButtons";
            this.saveButtons.Size = new System.Drawing.Size(155, 42);
            this.saveButtons.TabIndex = 14;
            this.saveButtons.Text = "Kaydet";
            this.saveButtons.UseVisualStyleBackColor = true;
            this.saveButtons.Click += new System.EventHandler(this.saveButtons_Click);
            // 
            // dataGridFis
            // 
            this.dataGridFis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridFis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridFis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urun,
            this.renk,
            this.birim,
            this.miktar,
            this.urunId,
            this.renkId,
            this.birimId});
            this.dataGridFis.Location = new System.Drawing.Point(0, 355);
            this.dataGridFis.Name = "dataGridFis";
            this.dataGridFis.RowHeadersWidth = 51;
            this.dataGridFis.RowTemplate.Height = 24;
            this.dataGridFis.Size = new System.Drawing.Size(1004, 168);
            this.dataGridFis.TabIndex = 5;
            this.dataGridFis.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridFis_CellDoubleClick);
            // 
            // tblFisBindingSource
            // 
            this.tblFisBindingSource.DataMember = "Tbl_Fis";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            this.dataSet1.Tables.AddRange(new System.Data.DataTable[] {
            this.main,
            this.details});
            // 
            // main
            // 
            this.main.TableName = "Main";
            // 
            // details
            // 
            this.details.TableName = "Details";
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.Location = new System.Drawing.Point(683, 529);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(148, 42);
            this.deleteButton.TabIndex = 0;
            this.deleteButton.Text = "Sil";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // urun
            // 
            this.urun.HeaderText = "Ürün";
            this.urun.MinimumWidth = 6;
            this.urun.Name = "urun";
            this.urun.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.urun.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // renk
            // 
            this.renk.HeaderText = "Renk";
            this.renk.MinimumWidth = 6;
            this.renk.Name = "renk";
            this.renk.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.renk.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // birim
            // 
            this.birim.HeaderText = "Birim";
            this.birim.MinimumWidth = 6;
            this.birim.Name = "birim";
            this.birim.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.birim.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // miktar
            // 
            this.miktar.HeaderText = "Miktar";
            this.miktar.MinimumWidth = 6;
            this.miktar.Name = "miktar";
            // 
            // urunId
            // 
            this.urunId.HeaderText = "UrunId";
            this.urunId.MinimumWidth = 6;
            this.urunId.Name = "urunId";
            this.urunId.Visible = false;
            // 
            // renkId
            // 
            this.renkId.HeaderText = "RenkId";
            this.renkId.MinimumWidth = 6;
            this.renkId.Name = "renkId";
            this.renkId.Visible = false;
            // 
            // birimId
            // 
            this.birimId.HeaderText = "BirimId";
            this.birimId.MinimumWidth = 6;
            this.birimId.Name = "birimId";
            this.birimId.Visible = false;
            // 
            // Fis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1004, 586);
            this.Controls.Add(this.saveButtons);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.dataGridFis);
            this.Controls.Add(this.panelLeft);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "Fis";
            this.Text = "FİŞ";
            this.Load += new System.EventHandler(this.Fis_Load);
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.details)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker tarihBox;
        private System.Windows.Forms.Label aciklamaLabel;
        private System.Windows.Forms.Label belgeNoLabel;
        private System.Windows.Forms.Label tarihNoLabel;
        private System.Windows.Forms.Label fisNoLabel;
        private System.Windows.Forms.RichTextBox aciklamaTextBox;
        private System.Windows.Forms.TextBox belgeNoTextBox;
        private System.Windows.Forms.TextBox fisNoTextBox;
        private System.Windows.Forms.BindingSource tblFisBindingSource;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Label firmaLabel;
        private System.Windows.Forms.Label depoLabel;
        private System.Windows.Forms.ComboBox firmaComboBox;
        private System.Windows.Forms.ComboBox depoComboBox;
        private System.Windows.Forms.Button saveButtons;
        private System.Windows.Forms.Panel panelLeft;
        public System.Windows.Forms.DataGridView dataGridFis;
        private System.Data.DataSet dataSet1;
        private System.Data.DataTable main;
        private System.Data.DataTable details;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn urun;
        private System.Windows.Forms.DataGridViewTextBoxColumn renk;
        private System.Windows.Forms.DataGridViewTextBoxColumn birim;
        private System.Windows.Forms.DataGridViewTextBoxColumn miktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunId;
        private System.Windows.Forms.DataGridViewTextBoxColumn renkId;
        private System.Windows.Forms.DataGridViewTextBoxColumn birimId;
    }
}