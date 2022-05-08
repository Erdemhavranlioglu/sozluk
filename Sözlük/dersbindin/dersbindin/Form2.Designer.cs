
namespace dersbindin
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ingilizce = new System.Windows.Forms.Label();
            this.turkce = new System.Windows.Forms.Label();
            this.txting = new System.Windows.Forms.TextBox();
            this.txtturk = new System.Windows.Forms.TextBox();
            this.lstsonuc = new System.Windows.Forms.ListBox();
            this.txtsonuc = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtsonuc);
            this.groupBox1.Controls.Add(this.lstsonuc);
            this.groupBox1.Controls.Add(this.txting);
            this.groupBox1.Controls.Add(this.txtturk);
            this.groupBox1.Controls.Add(this.turkce);
            this.groupBox1.Controls.Add(this.ingilizce);
            this.groupBox1.Location = new System.Drawing.Point(29, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(728, 394);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // ingilizce
            // 
            this.ingilizce.AutoSize = true;
            this.ingilizce.Location = new System.Drawing.Point(41, 31);
            this.ingilizce.Name = "ingilizce";
            this.ingilizce.Size = new System.Drawing.Size(58, 17);
            this.ingilizce.TabIndex = 0;
            this.ingilizce.Text = "İngilizce";
            // 
            // turkce
            // 
            this.turkce.AutoSize = true;
            this.turkce.Location = new System.Drawing.Point(411, 31);
            this.turkce.Name = "turkce";
            this.turkce.Size = new System.Drawing.Size(52, 17);
            this.turkce.TabIndex = 1;
            this.turkce.Text = "Türkçe";
            // 
            // txting
            // 
            this.txting.Location = new System.Drawing.Point(105, 31);
            this.txting.Name = "txting";
            this.txting.Size = new System.Drawing.Size(138, 22);
            this.txting.TabIndex = 1;
            // 
            // txtturk
            // 
            this.txtturk.Location = new System.Drawing.Point(463, 28);
            this.txtturk.Name = "txtturk";
            this.txtturk.Size = new System.Drawing.Size(137, 22);
            this.txtturk.TabIndex = 2;
            // 
            // lstsonuc
            // 
            this.lstsonuc.FormattingEnabled = true;
            this.lstsonuc.ItemHeight = 16;
            this.lstsonuc.Location = new System.Drawing.Point(44, 86);
            this.lstsonuc.Name = "lstsonuc";
            this.lstsonuc.Size = new System.Drawing.Size(199, 276);
            this.lstsonuc.TabIndex = 3;
            this.lstsonuc.SelectedIndexChanged += new System.EventHandler(this.lstsonuc_SelectedIndexChanged);
            // 
            // txtsonuc
            // 
            this.txtsonuc.Location = new System.Drawing.Point(414, 86);
            this.txtsonuc.Multiline = true;
            this.txtsonuc.Name = "txtsonuc";
            this.txtsonuc.Size = new System.Drawing.Size(186, 276);
            this.txtsonuc.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(154, 427);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 43);
            this.button1.TabIndex = 5;
            this.button1.Text = "temizle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(243, 427);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 43);
            this.button2.TabIndex = 6;
            this.button2.Text = "ekle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(336, 427);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 43);
            this.button3.TabIndex = 7;
            this.button3.Text = "güncelle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(417, 427);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 43);
            this.button4.TabIndex = 8;
            this.button4.Text = "sil";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(498, 427);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(89, 43);
            this.button5.TabIndex = 9;
            this.button5.Text = "anasayfa";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(187, 476);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 32);
            this.button6.TabIndex = 10;
            this.button6.Text = "ilk kayıt";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(268, 476);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(111, 32);
            this.button7.TabIndex = 11;
            this.button7.Text = "önceki kayıt";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(498, 476);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(89, 32);
            this.button8.TabIndex = 12;
            this.button8.Text = "son kayıt";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(388, 476);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(104, 32);
            this.button9.TabIndex = 13;
            this.button9.Text = "sonraki kayıt";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 547);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstsonuc;
        private System.Windows.Forms.TextBox txting;
        private System.Windows.Forms.TextBox txtturk;
        private System.Windows.Forms.Label turkce;
        private System.Windows.Forms.Label ingilizce;
        private System.Windows.Forms.TextBox txtsonuc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
    }
}