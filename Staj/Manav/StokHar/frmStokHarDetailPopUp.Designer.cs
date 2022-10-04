namespace Manav.StokHar
{
    partial class frmStokHarDetailPopUp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.miktarTextbox = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.birimcombobox = new Manav.Controls._combobox();
            this.renkcombobox = new Manav.Controls._combobox();
            this.uruncombobox = new Manav.Controls._combobox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.MaximumSize = new System.Drawing.Size(66, 25);
            this.label1.MinimumSize = new System.Drawing.Size(65, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Renk :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Birim :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Miktar : ";
            // 
            // miktarTextbox
            // 
            this.miktarTextbox.Location = new System.Drawing.Point(128, 156);
            this.miktarTextbox.Name = "miktarTextbox";
            this.miktarTextbox.Size = new System.Drawing.Size(176, 30);
            this.miktarTextbox.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(180, 220);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 40);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(16, 220);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(120, 40);
            this.closeButton.TabIndex = 9;
            this.closeButton.Text = "Kapat";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // birimcombobox
            // 
            this.birimcombobox.FormattingEnabled = true;
            this.birimcombobox.Location = new System.Drawing.Point(128, 108);
            this.birimcombobox.Name = "birimcombobox";
            this.birimcombobox.Size = new System.Drawing.Size(176, 33);
            this.birimcombobox.TabIndex = 15;
            // 
            // renkcombobox
            // 
            this.renkcombobox.FormattingEnabled = true;
            this.renkcombobox.Location = new System.Drawing.Point(128, 64);
            this.renkcombobox.Name = "renkcombobox";
            this.renkcombobox.Size = new System.Drawing.Size(176, 33);
            this.renkcombobox.TabIndex = 14;
            // 
            // uruncombobox
            // 
            this.uruncombobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.uruncombobox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.uruncombobox.FormattingEnabled = true;
            this.uruncombobox.Location = new System.Drawing.Point(128, 20);
            this.uruncombobox.Name = "uruncombobox";
            this.uruncombobox.Size = new System.Drawing.Size(176, 33);
            this.uruncombobox.TabIndex = 13;
            // 
            // frmStokHarDetailPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(332, 279);
            this.Controls.Add(this.birimcombobox);
            this.Controls.Add(this.renkcombobox);
            this.Controls.Add(this.uruncombobox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.miktarTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(350, 326);
            this.MinimumSize = new System.Drawing.Size(350, 326);
            this.Name = "frmStokHarDetailPopUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Details";
            this.Load += new System.EventHandler(this.frmPopUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox miktarTextbox;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button closeButton;
        private Controls._combobox uruncombobox;
        private Controls._combobox renkcombobox;
        private Controls._combobox birimcombobox;
    }
}