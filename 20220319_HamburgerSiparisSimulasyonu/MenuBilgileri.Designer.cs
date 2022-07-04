
namespace _20220319_HamburgerSiparisSimulasyonu
{
    partial class MenuBilgileri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuBilgileri));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.nUDFiyat = new System.Windows.Forms.NumericUpDown();
            this.txtBoxMenü = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picBoxMinimize = new System.Windows.Forms.PictureBox();
            this.picBoxClose = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.nUDFiyat);
            this.groupBox1.Controls.Add(this.txtBoxMenü);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(16, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 216);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menü Bilgileri";
            // 
            // btnKaydet
            // 
            this.btnKaydet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnKaydet.Location = new System.Drawing.Point(165, 160);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(171, 42);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // nUDFiyat
            // 
            this.nUDFiyat.Location = new System.Drawing.Point(130, 110);
            this.nUDFiyat.Name = "nUDFiyat";
            this.nUDFiyat.Size = new System.Drawing.Size(253, 35);
            this.nUDFiyat.TabIndex = 2;
            // 
            // txtBoxMenü
            // 
            this.txtBoxMenü.Location = new System.Drawing.Point(129, 48);
            this.txtBoxMenü.Name = "txtBoxMenü";
            this.txtBoxMenü.Size = new System.Drawing.Size(254, 35);
            this.txtBoxMenü.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fiyat : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menü Adı : ";
            // 
            // picBoxMinimize
            // 
            this.picBoxMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.picBoxMinimize.Image = ((System.Drawing.Image)(resources.GetObject("picBoxMinimize.Image")));
            this.picBoxMinimize.Location = new System.Drawing.Point(320, 20);
            this.picBoxMinimize.Name = "picBoxMinimize";
            this.picBoxMinimize.Size = new System.Drawing.Size(51, 30);
            this.picBoxMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBoxMinimize.TabIndex = 15;
            this.picBoxMinimize.TabStop = false;
            this.picBoxMinimize.Click += new System.EventHandler(this.picBoxMinimize_Click);
            // 
            // picBoxClose
            // 
            this.picBoxClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.picBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("picBoxClose.Image")));
            this.picBoxClose.Location = new System.Drawing.Point(377, 20);
            this.picBoxClose.Name = "picBoxClose";
            this.picBoxClose.Size = new System.Drawing.Size(51, 30);
            this.picBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBoxClose.TabIndex = 14;
            this.picBoxClose.TabStop = false;
            this.picBoxClose.Click += new System.EventHandler(this.picBoxClose_Click);
            // 
            // MenuBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(454, 279);
            this.Controls.Add(this.picBoxMinimize);
            this.Controls.Add(this.picBoxClose);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuBilgileri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuBilgileri";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBoxMenü;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picBoxMinimize;
        private System.Windows.Forms.PictureBox picBoxClose;
        private System.Windows.Forms.NumericUpDown nUDFiyat;
        private System.Windows.Forms.Button btnKaydet;
    }
}