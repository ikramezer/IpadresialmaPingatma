
namespace Lila
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblBilgisayarAdi = new System.Windows.Forms.Label();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.lblMac = new System.Windows.Forms.Label();
            this.lblIpAdresleri = new System.Windows.Forms.Label();
            this.lblTarih1 = new System.Windows.Forms.Label();
            this.lblZaman = new System.Windows.Forms.Label();
            this.lstIpAdresleri = new System.Windows.Forms.ListBox();
            this.btnBilgileriGuncelle = new System.Windows.Forms.Button();
            this.btnKopyala = new System.Windows.Forms.Button();
            this.btnTestSayfasi = new System.Windows.Forms.Button();
            this.lstBilgisayarAdi = new System.Windows.Forms.ListBox();
            this.lstKullaniciAdi = new System.Windows.Forms.ListBox();
            this.lstMacAdresi = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.IPAdresleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MacAdresiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CikisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.BTDestekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.LinkToolStrippMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TelefonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip4 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.contextMenuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBilgisayarAdi
            // 
            this.lblBilgisayarAdi.AutoSize = true;
            this.lblBilgisayarAdi.Location = new System.Drawing.Point(-4, 82);
            this.lblBilgisayarAdi.Name = "lblBilgisayarAdi";
            this.lblBilgisayarAdi.Size = new System.Drawing.Size(122, 20);
            this.lblBilgisayarAdi.TabIndex = 0;
            this.lblBilgisayarAdi.Text = "Bilgisayar Adınız:";
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(-4, 135);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(114, 20);
            this.lblKullaniciAdi.TabIndex = 1;
            this.lblKullaniciAdi.Text = "Kullanıcı Adınız:";
            // 
            // lblMac
            // 
            this.lblMac.AutoSize = true;
            this.lblMac.Location = new System.Drawing.Point(-3, 185);
            this.lblMac.Name = "lblMac";
            this.lblMac.Size = new System.Drawing.Size(109, 20);
            this.lblMac.TabIndex = 2;
            this.lblMac.Text = "MAC Adresiniz:";
            // 
            // lblIpAdresleri
            // 
            this.lblIpAdresleri.AutoSize = true;
            this.lblIpAdresleri.Location = new System.Drawing.Point(-3, 256);
            this.lblIpAdresleri.Name = "lblIpAdresleri";
            this.lblIpAdresleri.Size = new System.Drawing.Size(106, 20);
            this.lblIpAdresleri.TabIndex = 3;
            this.lblIpAdresleri.Text = "IP Adresleriniz:";
            // 
            // lblTarih1
            // 
            this.lblTarih1.AutoSize = true;
            this.lblTarih1.Location = new System.Drawing.Point(345, 350);
            this.lblTarih1.Name = "lblTarih1";
            this.lblTarih1.Size = new System.Drawing.Size(25, 20);
            this.lblTarih1.TabIndex = 4;
            this.lblTarih1.Text = "00";
            // 
            // lblZaman
            // 
            this.lblZaman.AutoSize = true;
            this.lblZaman.Location = new System.Drawing.Point(345, 376);
            this.lblZaman.Name = "lblZaman";
            this.lblZaman.Size = new System.Drawing.Size(25, 20);
            this.lblZaman.TabIndex = 5;
            this.lblZaman.Text = "00";
            // 
            // lstIpAdresleri
            // 
            this.lstIpAdresleri.FormattingEnabled = true;
            this.lstIpAdresleri.ItemHeight = 20;
            this.lstIpAdresleri.Location = new System.Drawing.Point(124, 237);
            this.lstIpAdresleri.Name = "lstIpAdresleri";
            this.lstIpAdresleri.Size = new System.Drawing.Size(169, 104);
            this.lstIpAdresleri.TabIndex = 9;
            // 
            // btnBilgileriGuncelle
            // 
            this.btnBilgileriGuncelle.Location = new System.Drawing.Point(14, 347);
            this.btnBilgileriGuncelle.Name = "btnBilgileriGuncelle";
            this.btnBilgileriGuncelle.Size = new System.Drawing.Size(297, 43);
            this.btnBilgileriGuncelle.TabIndex = 10;
            this.btnBilgileriGuncelle.Text = "Bilgileri Güncelle";
            this.btnBilgileriGuncelle.UseVisualStyleBackColor = true;
            this.btnBilgileriGuncelle.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnKopyala
            // 
            this.btnKopyala.Location = new System.Drawing.Point(14, 396);
            this.btnKopyala.Name = "btnKopyala";
            this.btnKopyala.Size = new System.Drawing.Size(297, 47);
            this.btnKopyala.TabIndex = 11;
            this.btnKopyala.Text = "Bilgileri Kopyala";
            this.btnKopyala.UseVisualStyleBackColor = true;
            this.btnKopyala.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnTestSayfasi
            // 
            this.btnTestSayfasi.Location = new System.Drawing.Point(14, 449);
            this.btnTestSayfasi.Name = "btnTestSayfasi";
            this.btnTestSayfasi.Size = new System.Drawing.Size(297, 56);
            this.btnTestSayfasi.TabIndex = 13;
            this.btnTestSayfasi.Text = "Test Sayfası";
            this.btnTestSayfasi.UseVisualStyleBackColor = true;
            this.btnTestSayfasi.Click += new System.EventHandler(this.button4_Click);
            // 
            // lstBilgisayarAdi
            // 
            this.lstBilgisayarAdi.FormattingEnabled = true;
            this.lstBilgisayarAdi.ItemHeight = 20;
            this.lstBilgisayarAdi.Location = new System.Drawing.Point(124, 74);
            this.lstBilgisayarAdi.Name = "lstBilgisayarAdi";
            this.lstBilgisayarAdi.Size = new System.Drawing.Size(168, 44);
            this.lstBilgisayarAdi.TabIndex = 14;
            // 
            // lstKullaniciAdi
            // 
            this.lstKullaniciAdi.FormattingEnabled = true;
            this.lstKullaniciAdi.ItemHeight = 20;
            this.lstKullaniciAdi.Location = new System.Drawing.Point(125, 124);
            this.lstKullaniciAdi.Name = "lstKullaniciAdi";
            this.lstKullaniciAdi.Size = new System.Drawing.Size(168, 44);
            this.lstKullaniciAdi.TabIndex = 14;
            // 
            // lstMacAdresi
            // 
            this.lstMacAdresi.FormattingEnabled = true;
            this.lstMacAdresi.ItemHeight = 20;
            this.lstMacAdresi.Location = new System.Drawing.Point(124, 174);
            this.lstMacAdresi.Name = "lstMacAdresi";
            this.lstMacAdresi.Size = new System.Drawing.Size(168, 44);
            this.lstMacAdresi.TabIndex = 14;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem10});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(441, 28);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked_3);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDown = this.contextMenuStrip1;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(94, 24);
            this.toolStripMenuItem1.Text = "Seçenekler";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IPAdresleriToolStripMenuItem,
            this.MacAdresiToolStripMenuItem,
            this.CikisToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(157, 76);
            // 
            // IPAdresleriToolStripMenuItem
            // 
            this.IPAdresleriToolStripMenuItem.Name = "IPAdresleriToolStripMenuItem";
            this.IPAdresleriToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.IPAdresleriToolStripMenuItem.Text = "IP Adresleri";
            // 
            // MacAdresiToolStripMenuItem
            // 
            this.MacAdresiToolStripMenuItem.Name = "MacAdresiToolStripMenuItem";
            this.MacAdresiToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.MacAdresiToolStripMenuItem.Text = "MAC Adresi";
            // 
            // CikisToolStripMenuItem
            // 
            this.CikisToolStripMenuItem.Name = "CikisToolStripMenuItem";
            this.CikisToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.CikisToolStripMenuItem.Text = "Çıkış";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDown = this.contextMenuStrip2;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(85, 24);
            this.toolStripMenuItem2.Text = "Hakkında";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BTDestekToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(144, 28);
            // 
            // BTDestekToolStripMenuItem
            // 
            this.BTDestekToolStripMenuItem.Name = "BTDestekToolStripMenuItem";
            this.BTDestekToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.BTDestekToolStripMenuItem.Text = "BT Destek";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDown = this.contextMenuStrip3;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(69, 24);
            this.toolStripMenuItem3.Text = "Yardım";
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LinkToolStrippMenuItem,
            this.TelefonToolStripMenuItem});
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(128, 52);
            // 
            // LinkToolStrippMenuItem
            // 
            this.LinkToolStrippMenuItem.Name = "LinkToolStrippMenuItem";
            this.LinkToolStrippMenuItem.Size = new System.Drawing.Size(210, 24);
            this.LinkToolStrippMenuItem.Text = "Link";
            // 
            // TelefonToolStripMenuItem
            // 
            this.TelefonToolStripMenuItem.Name = "TelefonToolStripMenuItem";
            this.TelefonToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.TelefonToolStripMenuItem.Text = "Telefon";
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(115, 24);
            this.toolStripMenuItem10.Text = "Komut İstemi ";
            // 
            // contextMenuStrip4
            // 
            this.contextMenuStrip4.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip4.Name = "contextMenuStrip4";
            this.contextMenuStrip4.Size = new System.Drawing.Size(61, 4);
            // 
            // frmBilgiPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 510);
            this.Controls.Add(this.lstMacAdresi);
            this.Controls.Add(this.lstKullaniciAdi);
            this.Controls.Add(this.lstBilgisayarAdi);
            this.Controls.Add(this.btnTestSayfasi);
            this.Controls.Add(this.btnKopyala);
            this.Controls.Add(this.btnBilgileriGuncelle);
            this.Controls.Add(this.lstIpAdresleri);
            this.Controls.Add(this.lblZaman);
            this.Controls.Add(this.lblTarih1);
            this.Controls.Add(this.lblIpAdresleri);
            this.Controls.Add(this.lblMac);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Controls.Add(this.lblBilgisayarAdi);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmBilgiPaneli";
            this.Text = "Lila Group Network Bilgi Paneli";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.contextMenuStrip3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBilgisayarAdi;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Label lblMac;
        private System.Windows.Forms.Label lblIpAdresleri;
        private System.Windows.Forms.Label lblTarih1;
        private System.Windows.Forms.Label lblZaman;
        private System.Windows.Forms.ListBox lstIpAdresleri;
        private System.Windows.Forms.Button btnBilgileriGuncelle;
        private System.Windows.Forms.Button btnKopyala;
        private System.Windows.Forms.Button btnTestSayfasi;
        private System.Windows.Forms.ListBox lstBilgisayarAdi;
        private System.Windows.Forms.ListBox lstKullaniciAdi;
        private System.Windows.Forms.ListBox lstMacAdresi;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem IPAdresleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MacAdresiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CikisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem BTDestekToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.ToolStripMenuItem LinkToolStrippMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TelefonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip4;
    }
}

