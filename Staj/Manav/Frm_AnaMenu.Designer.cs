namespace Manav
{
    partial class Frm_AnaMenu
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.tanımlarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünlerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.birimToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.depoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.firmalarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.renkToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.stokHareketleriStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tanımlarToolStripMenuItem1,
            this.stokHareketleriStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1169, 30);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            // 
            // tanımlarToolStripMenuItem1
            // 
            this.tanımlarToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ürünlerToolStripMenuItem1,
            this.birimToolStripMenuItem1,
            this.depoToolStripMenuItem1,
            this.firmalarToolStripMenuItem1,
            this.renkToolStripMenuItem1});
            this.tanımlarToolStripMenuItem1.Name = "tanımlarToolStripMenuItem1";
            this.tanımlarToolStripMenuItem1.Size = new System.Drawing.Size(84, 26);
            this.tanımlarToolStripMenuItem1.Text = "Tanımlar";
            // 
            // ürünlerToolStripMenuItem1
            // 
            this.ürünlerToolStripMenuItem1.Name = "ürünlerToolStripMenuItem1";
            this.ürünlerToolStripMenuItem1.Size = new System.Drawing.Size(150, 26);
            this.ürünlerToolStripMenuItem1.Text = "Ürünler";
            this.ürünlerToolStripMenuItem1.Click += new System.EventHandler(this.ürünlerToolStripMenuItem1_Click);
            // 
            // birimToolStripMenuItem1
            // 
            this.birimToolStripMenuItem1.Name = "birimToolStripMenuItem1";
            this.birimToolStripMenuItem1.Size = new System.Drawing.Size(150, 26);
            this.birimToolStripMenuItem1.Text = "Birim";
            this.birimToolStripMenuItem1.Click += new System.EventHandler(this.birimToolStripMenuItem1_Click);
            // 
            // depoToolStripMenuItem1
            // 
            this.depoToolStripMenuItem1.Name = "depoToolStripMenuItem1";
            this.depoToolStripMenuItem1.Size = new System.Drawing.Size(150, 26);
            this.depoToolStripMenuItem1.Text = "Depo";
            this.depoToolStripMenuItem1.Click += new System.EventHandler(this.depoToolStripMenuItem1_Click);
            // 
            // firmalarToolStripMenuItem1
            // 
            this.firmalarToolStripMenuItem1.Name = "firmalarToolStripMenuItem1";
            this.firmalarToolStripMenuItem1.Size = new System.Drawing.Size(150, 26);
            this.firmalarToolStripMenuItem1.Text = "Firmalar";
            this.firmalarToolStripMenuItem1.Click += new System.EventHandler(this.firmalarToolStripMenuItem1_Click);
            // 
            // renkToolStripMenuItem1
            // 
            this.renkToolStripMenuItem1.Name = "renkToolStripMenuItem1";
            this.renkToolStripMenuItem1.Size = new System.Drawing.Size(150, 26);
            this.renkToolStripMenuItem1.Text = "Renk";
            this.renkToolStripMenuItem1.Click += new System.EventHandler(this.renkToolStripMenuItem1_Click);
            // 
            // stokHareketleriStripMenuItem
            // 
            this.stokHareketleriStripMenuItem.Name = "stokHareketleriStripMenuItem";
            this.stokHareketleriStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.stokHareketleriStripMenuItem.Text = "Stok Hareketleri";
            this.stokHareketleriStripMenuItem.Click += new System.EventHandler(this.stokHareketleriStripMenuItem_Click);
            // 
            // Frm_AnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1169, 556);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Frm_AnaMenu";
            this.Text = "Ana Menü";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem tanımlarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ürünlerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem birimToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem depoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem firmalarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem renkToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem stokHareketleriStripMenuItem;
    }
}

