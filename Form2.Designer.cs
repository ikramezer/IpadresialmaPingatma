
namespace LilaUygulama
{
    partial class frmTestPanel
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
            this.lblFabrika = new System.Windows.Forms.Label();
            this.lblMerkez = new System.Windows.Forms.Label();
            this.lblHostVeyaIp = new System.Windows.Forms.Label();
            this.txtFabrikaIp = new System.Windows.Forms.TextBox();
            this.txtMerkezIp = new System.Windows.Forms.TextBox();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.lstSonucFabrika = new System.Windows.Forms.ListBox();
            this.lstSonucMerkez = new System.Windows.Forms.ListBox();
            this.lstSonucIp = new System.Windows.Forms.ListBox();
            this.btnPingAt = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFabrika
            // 
            this.lblFabrika.AutoSize = true;
            this.lblFabrika.Location = new System.Drawing.Point(29, 9);
            this.lblFabrika.Name = "lblFabrika";
            this.lblFabrika.Size = new System.Drawing.Size(56, 20);
            this.lblFabrika.TabIndex = 0;
            this.lblFabrika.Text = "Fabrika";
            // 
            // lblMerkez
            // 
            this.lblMerkez.AutoSize = true;
            this.lblMerkez.Location = new System.Drawing.Point(236, 9);
            this.lblMerkez.Name = "lblMerkez";
            this.lblMerkez.Size = new System.Drawing.Size(57, 20);
            this.lblMerkez.TabIndex = 1;
            this.lblMerkez.Text = "Merkez";
            this.lblMerkez.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblHostVeyaIp
            // 
            this.lblHostVeyaIp.AutoSize = true;
            this.lblHostVeyaIp.Location = new System.Drawing.Point(404, 9);
            this.lblHostVeyaIp.Name = "lblHostVeyaIp";
            this.lblHostVeyaIp.Size = new System.Drawing.Size(91, 20);
            this.lblHostVeyaIp.TabIndex = 2;
            this.lblHostVeyaIp.Text = "Host Veya IP";
            this.lblHostVeyaIp.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtFabrikaIp
            // 
            this.txtFabrikaIp.Location = new System.Drawing.Point(12, 33);
            this.txtFabrikaIp.Name = "txtFabrikaIp";
            this.txtFabrikaIp.ReadOnly = true;
            this.txtFabrikaIp.Size = new System.Drawing.Size(125, 27);
            this.txtFabrikaIp.TabIndex = 3;
            this.txtFabrikaIp.Text = "FabrikaIpAdresi";
            this.txtFabrikaIp.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtMerkezIp
            // 
            this.txtMerkezIp.Location = new System.Drawing.Point(205, 33);
            this.txtMerkezIp.Name = "txtMerkezIp";
            this.txtMerkezIp.ReadOnly = true;
            this.txtMerkezIp.Size = new System.Drawing.Size(125, 27);
            this.txtMerkezIp.TabIndex = 4;
            this.txtMerkezIp.Text = "MerkezIpAdresi";
            this.txtMerkezIp.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(389, 32);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(125, 27);
            this.txtIp.TabIndex = 5;
            this.txtIp.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lstSonucFabrika
            // 
            this.lstSonucFabrika.FormattingEnabled = true;
            this.lstSonucFabrika.ItemHeight = 20;
            this.lstSonucFabrika.Location = new System.Drawing.Point(12, 80);
            this.lstSonucFabrika.Name = "lstSonucFabrika";
            this.lstSonucFabrika.Size = new System.Drawing.Size(150, 104);
            this.lstSonucFabrika.TabIndex = 6;
            // 
            // lstSonucMerkez
            // 
            this.lstSonucMerkez.FormattingEnabled = true;
            this.lstSonucMerkez.ItemHeight = 20;
            this.lstSonucMerkez.Location = new System.Drawing.Point(205, 80);
            this.lstSonucMerkez.Name = "lstSonucMerkez";
            this.lstSonucMerkez.Size = new System.Drawing.Size(150, 104);
            this.lstSonucMerkez.TabIndex = 6;
            // 
            // lstSonucIp
            // 
            this.lstSonucIp.FormattingEnabled = true;
            this.lstSonucIp.ItemHeight = 20;
            this.lstSonucIp.Location = new System.Drawing.Point(389, 80);
            this.lstSonucIp.Name = "lstSonucIp";
            this.lstSonucIp.Size = new System.Drawing.Size(150, 104);
            this.lstSonucIp.TabIndex = 6;
            // 
            // btnPingAt
            // 
            this.btnPingAt.Location = new System.Drawing.Point(12, 206);
            this.btnPingAt.Name = "btnPingAt";
            this.btnPingAt.Size = new System.Drawing.Size(269, 75);
            this.btnPingAt.TabIndex = 7;
            this.btnPingAt.Text = "Ping At";
            this.btnPingAt.UseVisualStyleBackColor = true;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(326, 206);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(213, 75);
            this.btnTemizle.TabIndex = 8;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            // 
            // frmTestPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 336);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnPingAt);
            this.Controls.Add(this.lstSonucIp);
            this.Controls.Add(this.lstSonucMerkez);
            this.Controls.Add(this.lstSonucFabrika);
            this.Controls.Add(this.txtIp);
            this.Controls.Add(this.txtMerkezIp);
            this.Controls.Add(this.txtFabrikaIp);
            this.Controls.Add(this.lblHostVeyaIp);
            this.Controls.Add(this.lblMerkez);
            this.Controls.Add(this.lblFabrika);
            this.Name = "frmTestPanel";
            this.Text = "Lila Group BT Test Paneli";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFabrika;
        private System.Windows.Forms.Label lblMerkez;
        private System.Windows.Forms.Label lblHostVeyaIp;
        private System.Windows.Forms.TextBox txtFabrikaIp;
        private System.Windows.Forms.TextBox txtMerkezIp;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.ListBox lstSonucFabrika;
        private System.Windows.Forms.ListBox lstSonucMerkez;
        private System.Windows.Forms.ListBox lstSonucIp;
        private System.Windows.Forms.Button btnPingAt;
        private System.Windows.Forms.Button btnTemizle;
    }
}