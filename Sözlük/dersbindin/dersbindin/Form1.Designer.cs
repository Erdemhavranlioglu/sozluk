
namespace dersbindin
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtaranan = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtturk = new System.Windows.Forms.TextBox();
            this.txting = new System.Windows.Forms.TextBox();
            this.lstsonuc = new System.Windows.Forms.ListBox();
            this.txtsonuc = new System.Windows.Forms.TextBox();
            this.ayarlar = new System.Windows.Forms.Button();
            this.cikis = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtaranan);
            this.groupBox1.Location = new System.Drawing.Point(48, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(737, 59);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aradığınız Kelime";
            // 
            // txtaranan
            // 
            this.txtaranan.Location = new System.Drawing.Point(22, 21);
            this.txtaranan.Name = "txtaranan";
            this.txtaranan.Size = new System.Drawing.Size(651, 22);
            this.txtaranan.TabIndex = 0;
            this.txtaranan.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtsonuc);
            this.groupBox2.Controls.Add(this.lstsonuc);
            this.groupBox2.Controls.Add(this.txting);
            this.groupBox2.Controls.Add(this.txtturk);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(48, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(737, 356);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sonuçlar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "İngilizce";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Türkçe";
            // 
            // txtturk
            // 
            this.txtturk.Location = new System.Drawing.Point(392, 65);
            this.txtturk.Multiline = true;
            this.txtturk.Name = "txtturk";
            this.txtturk.Size = new System.Drawing.Size(215, 22);
            this.txtturk.TabIndex = 2;
            // 
            // txting
            // 
            this.txting.Location = new System.Drawing.Point(106, 65);
            this.txting.Name = "txting";
            this.txting.Size = new System.Drawing.Size(182, 22);
            this.txting.TabIndex = 3;
            // 
            // lstsonuc
            // 
            this.lstsonuc.FormattingEnabled = true;
            this.lstsonuc.ItemHeight = 16;
            this.lstsonuc.Location = new System.Drawing.Point(22, 109);
            this.lstsonuc.Name = "lstsonuc";
            this.lstsonuc.Size = new System.Drawing.Size(266, 228);
            this.lstsonuc.TabIndex = 4;
            this.lstsonuc.SelectedIndexChanged += new System.EventHandler(this.lstsonuc_SelectedIndexChanged);
            // 
            // txtsonuc
            // 
            this.txtsonuc.Location = new System.Drawing.Point(337, 109);
            this.txtsonuc.Multiline = true;
            this.txtsonuc.Name = "txtsonuc";
            this.txtsonuc.Size = new System.Drawing.Size(270, 228);
            this.txtsonuc.TabIndex = 5;
            // 
            // ayarlar
            // 
            this.ayarlar.Location = new System.Drawing.Point(154, 449);
            this.ayarlar.Name = "ayarlar";
            this.ayarlar.Size = new System.Drawing.Size(95, 42);
            this.ayarlar.TabIndex = 2;
            this.ayarlar.Text = "Ayarlar";
            this.ayarlar.UseVisualStyleBackColor = true;
            this.ayarlar.Click += new System.EventHandler(this.ayarlar_Click);
            // 
            // cikis
            // 
            this.cikis.Location = new System.Drawing.Point(440, 449);
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(97, 42);
            this.cikis.TabIndex = 3;
            this.cikis.Text = "Çıkış";
            this.cikis.UseVisualStyleBackColor = true;
            this.cikis.Click += new System.EventHandler(this.cikis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 513);
            this.Controls.Add(this.cikis);
            this.Controls.Add(this.ayarlar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtaranan;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtsonuc;
        private System.Windows.Forms.ListBox lstsonuc;
        private System.Windows.Forms.TextBox txting;
        private System.Windows.Forms.TextBox txtturk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ayarlar;
        private System.Windows.Forms.Button cikis;
    }
}

