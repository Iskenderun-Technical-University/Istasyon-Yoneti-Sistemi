namespace OTOMASYON_ÖDEV
{
    partial class YöneticiFormu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YöneticiFormu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şifreDegiştirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.işlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelEklemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yöneticiEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcılarıGörüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ımageList3 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayarlarToolStripMenuItem,
            this.toolStripMenuItem1,
            this.işlemlerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1002, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ayarlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.şifreDegiştirToolStripMenuItem,
            this.çıkışYapToolStripMenuItem});
            this.ayarlarToolStripMenuItem.Image = global::OTOMASYON_ÖDEV.Properties.Resources.unnamed;
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(108, 32);
            this.ayarlarToolStripMenuItem.Text = "Ayarlar";
            this.ayarlarToolStripMenuItem.Click += new System.EventHandler(this.ayarlarToolStripMenuItem_Click);
            // 
            // şifreDegiştirToolStripMenuItem
            // 
            this.şifreDegiştirToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.şifreDegiştirToolStripMenuItem.Name = "şifreDegiştirToolStripMenuItem";
            this.şifreDegiştirToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.şifreDegiştirToolStripMenuItem.Text = "Şifre Değiştir";
            this.şifreDegiştirToolStripMenuItem.Click += new System.EventHandler(this.şifreDegiştirToolStripMenuItem_Click);
            // 
            // çıkışYapToolStripMenuItem
            // 
            this.çıkışYapToolStripMenuItem.Name = "çıkışYapToolStripMenuItem";
            this.çıkışYapToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.çıkışYapToolStripMenuItem.Text = "Çıkış Yap";
            this.çıkışYapToolStripMenuItem.Click += new System.EventHandler(this.çıkışYapToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(14, 32);
            // 
            // işlemlerToolStripMenuItem
            // 
            this.işlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelEklemeToolStripMenuItem});
            this.işlemlerToolStripMenuItem.Name = "işlemlerToolStripMenuItem";
            this.işlemlerToolStripMenuItem.Size = new System.Drawing.Size(93, 32);
            this.işlemlerToolStripMenuItem.Text = "İşlemler";
            this.işlemlerToolStripMenuItem.Click += new System.EventHandler(this.işlemlerToolStripMenuItem_Click);
            // 
            // personelEklemeToolStripMenuItem
            // 
            this.personelEklemeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kullanıcıEkleToolStripMenuItem,
            this.yöneticiEkleToolStripMenuItem,
            this.kullanıcıGüncelleToolStripMenuItem,
            this.kullanıcılarıGörüntüleToolStripMenuItem});
            this.personelEklemeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.personelEklemeToolStripMenuItem.Name = "personelEklemeToolStripMenuItem";
            this.personelEklemeToolStripMenuItem.Size = new System.Drawing.Size(253, 32);
            this.personelEklemeToolStripMenuItem.Text = " Personel İşlemleri";
            this.personelEklemeToolStripMenuItem.Click += new System.EventHandler(this.personelEklemeToolStripMenuItem_Click);
            // 
            // kullanıcıEkleToolStripMenuItem
            // 
            this.kullanıcıEkleToolStripMenuItem.Name = "kullanıcıEkleToolStripMenuItem";
            this.kullanıcıEkleToolStripMenuItem.Size = new System.Drawing.Size(291, 32);
            this.kullanıcıEkleToolStripMenuItem.Text = "Personel Ekle";
            this.kullanıcıEkleToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıEkleToolStripMenuItem_Click);
            // 
            // yöneticiEkleToolStripMenuItem
            // 
            this.yöneticiEkleToolStripMenuItem.Name = "yöneticiEkleToolStripMenuItem";
            this.yöneticiEkleToolStripMenuItem.Size = new System.Drawing.Size(291, 32);
            this.yöneticiEkleToolStripMenuItem.Text = "Personel Sil";
            this.yöneticiEkleToolStripMenuItem.Click += new System.EventHandler(this.yöneticiEkleToolStripMenuItem_Click);
            // 
            // kullanıcıGüncelleToolStripMenuItem
            // 
            this.kullanıcıGüncelleToolStripMenuItem.Name = "kullanıcıGüncelleToolStripMenuItem";
            this.kullanıcıGüncelleToolStripMenuItem.Size = new System.Drawing.Size(291, 32);
            this.kullanıcıGüncelleToolStripMenuItem.Text = "Personel Güncelle";
            this.kullanıcıGüncelleToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıGüncelleToolStripMenuItem_Click);
            // 
            // kullanıcılarıGörüntüleToolStripMenuItem
            // 
            this.kullanıcılarıGörüntüleToolStripMenuItem.Name = "kullanıcılarıGörüntüleToolStripMenuItem";
            this.kullanıcılarıGörüntüleToolStripMenuItem.Size = new System.Drawing.Size(291, 32);
            this.kullanıcılarıGörüntüleToolStripMenuItem.Text = "Personelleri Görüntüle";
            this.kullanıcılarıGörüntüleToolStripMenuItem.Click += new System.EventHandler(this.kullanıcılarıGörüntüleToolStripMenuItem_Click);
            // 
            // ımageList2
            // 
            this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList2.Images.SetKeyName(0, "clipboard.png");
            this.ımageList2.Images.SetKeyName(1, "clipboard_add.png");
            this.ımageList2.Images.SetKeyName(2, "clipboard_delete.png");
            this.ımageList2.Images.SetKeyName(3, "clipboard_empty.png");
            this.ımageList2.Images.SetKeyName(4, "paste.png");
            this.ımageList2.Images.SetKeyName(5, "clipboard_next_down.png");
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "customers-icon-12.png");
            this.ımageList1.Images.SetKeyName(1, "clipboard_delete.png");
            this.ımageList1.Images.SetKeyName(2, "clipboard_add.png");
            this.ımageList1.Images.SetKeyName(3, "paste.png");
            this.ımageList1.Images.SetKeyName(4, "table2_view.png");
            this.ımageList1.Images.SetKeyName(5, "table2.png");
            this.ımageList1.Images.SetKeyName(6, "computer-icons-download-icon-design-png-favpng-kg77nYb0fnfMbWhNbLqQW4BGx_t.jpg");
            // 
            // button6
            // 
            this.button6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button6.ImageIndex = 2;
            this.button6.ImageList = this.ımageList2;
            this.button6.Location = new System.Drawing.Point(664, 329);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(194, 201);
            this.button6.TabIndex = 7;
            this.button6.Text = "İstasyon Sil";
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button3
            // 
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.ImageIndex = 4;
            this.button3.ImageList = this.ımageList1;
            this.button3.Location = new System.Drawing.Point(380, 100);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(194, 201);
            this.button3.TabIndex = 6;
            this.button3.Text = "Satılan Biletleri Bilgilere Göre Ara";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button5.ImageIndex = 0;
            this.button5.ImageList = this.ımageList1;
            this.button5.Location = new System.Drawing.Point(664, 100);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(194, 201);
            this.button5.TabIndex = 5;
            this.button5.Text = "Satış Yapan Personel Bilgileri";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.ImageIndex = 5;
            this.button4.ImageList = this.ımageList1;
            this.button4.Location = new System.Drawing.Point(107, 100);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(194, 201);
            this.button4.TabIndex = 4;
            this.button4.Text = "Satılan Biletleri Görüntüle";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.ImageIndex = 5;
            this.button2.ImageList = this.ımageList2;
            this.button2.Location = new System.Drawing.Point(380, 329);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 204);
            this.button2.TabIndex = 2;
            this.button2.Text = "İstasyon Bilgilerini Güncelle";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.ImageIndex = 1;
            this.button1.ImageList = this.ımageList2;
            this.button1.Location = new System.Drawing.Point(107, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 201);
            this.button1.TabIndex = 1;
            this.button1.Text = "İstasyon Ekle";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ımageList3
            // 
            this.ımageList3.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList3.ImageStream")));
            this.ımageList3.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList3.Images.SetKeyName(0, "computer-icons-download-icon-design-png-favpng-kg77nYb0fnfMbWhNbLqQW4BGx_t.jpg");
            this.ımageList3.Images.SetKeyName(1, "52-529801_this-is-a-back-arrow-colour-in-green-clip-art-green-arrow.png");
            // 
            // YöneticiFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1002, 666);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "YöneticiFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yönetici Formu";
            this.Load += new System.EventHandler(this.YöneticiFormu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şifreDegiştirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışYapToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem işlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelEklemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yöneticiEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcılarıGörüntüleToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.ImageList ımageList2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ImageList ımageList3;
    }
}