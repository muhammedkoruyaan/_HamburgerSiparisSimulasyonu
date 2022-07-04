
namespace _20220319_HamburgerSiparisSimulasyonu
{
    partial class BaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.siparişYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparişEkleToStMe = new System.Windows.Forms.ToolStripMenuItem();
            this.siparisBilgileri = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ekstraMalzemeBilgisi = new System.Windows.Forms.ToolStripMenuItem();
            this.HamburgerBilgilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drinkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStrip1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siparişYönetimiToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1480, 36);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // siparişYönetimiToolStripMenuItem
            // 
            this.siparişYönetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siparişEkleToStMe,
            this.siparisBilgileri});
            this.siparişYönetimiToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.siparişYönetimiToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("siparişYönetimiToolStripMenuItem.Image")));
            this.siparişYönetimiToolStripMenuItem.Name = "siparişYönetimiToolStripMenuItem";
            this.siparişYönetimiToolStripMenuItem.Size = new System.Drawing.Size(199, 32);
            this.siparişYönetimiToolStripMenuItem.Text = "Sipariş Yönetimi";
            // 
            // siparişEkleToStMe
            // 
            this.siparişEkleToStMe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.siparişEkleToStMe.Name = "siparişEkleToStMe";
            this.siparişEkleToStMe.Size = new System.Drawing.Size(244, 32);
            this.siparişEkleToStMe.Text = "Sipariş Ekle";
            this.siparişEkleToStMe.Click += new System.EventHandler(this.siparişEkleToStMe_Click);
            // 
            // siparisBilgileri
            // 
            this.siparisBilgileri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.siparisBilgileri.Name = "siparisBilgileri";
            this.siparisBilgileri.Size = new System.Drawing.Size(244, 32);
            this.siparisBilgileri.Text = "Sipariş Bilgileri";
            this.siparisBilgileri.Click += new System.EventHandler(this.siparisBilgileri_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ekstraMalzemeBilgisi,
            this.HamburgerBilgilerToolStripMenuItem,
            this.drinkToolStripMenuItem});
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.Black;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(157, 32);
            this.toolStripMenuItem1.Text = "Ürün Yönetimi";
            // 
            // ekstraMalzemeBilgisi
            // 
            this.ekstraMalzemeBilgisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ekstraMalzemeBilgisi.Name = "ekstraMalzemeBilgisi";
            this.ekstraMalzemeBilgisi.Size = new System.Drawing.Size(282, 32);
            this.ekstraMalzemeBilgisi.Text = "Extra Malzeme Ekle";
            this.ekstraMalzemeBilgisi.Click += new System.EventHandler(this.ekstraMalzemeBilgisi_Click);
            // 
            // HamburgerBilgilerToolStripMenuItem
            // 
            this.HamburgerBilgilerToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.HamburgerBilgilerToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.HamburgerBilgilerToolStripMenuItem.Name = "HamburgerBilgilerToolStripMenuItem";
            this.HamburgerBilgilerToolStripMenuItem.Size = new System.Drawing.Size(282, 32);
            this.HamburgerBilgilerToolStripMenuItem.Text = "Hamburger Ekle";
            this.HamburgerBilgilerToolStripMenuItem.Click += new System.EventHandler(this.menüBilgilerToolStripMenuItem_Click);
            // 
            // drinkToolStripMenuItem
            // 
            this.drinkToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.drinkToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.drinkToolStripMenuItem.Name = "drinkToolStripMenuItem";
            this.drinkToolStripMenuItem.Size = new System.Drawing.Size(282, 32);
            this.drinkToolStripMenuItem.Text = "İçecek Ekle";
            this.drinkToolStripMenuItem.Click += new System.EventHandler(this.drinkToolStripMenuItem_Click);
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1480, 611);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "BaseForm";
            this.Text = "BaseForm";
            this.Load += new System.EventHandler(this.BaseForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem siparişYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparişEkleToStMe;
        private System.Windows.Forms.ToolStripMenuItem siparisBilgileri;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ekstraMalzemeBilgisi;
        private System.Windows.Forms.ToolStripMenuItem HamburgerBilgilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drinkToolStripMenuItem;
    }
}