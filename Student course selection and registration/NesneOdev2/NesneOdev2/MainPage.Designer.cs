namespace NesneOdev2
{
    partial class MainPage
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
            this.derslerList = new System.Windows.Forms.ListBox();
            this.ogrenciList = new System.Windows.Forms.ListBox();
            this.derscombo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dersNotu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // derslerList
            // 
            this.derslerList.FormattingEnabled = true;
            this.derslerList.Location = new System.Drawing.Point(368, 147);
            this.derslerList.Name = "derslerList";
            this.derslerList.Size = new System.Drawing.Size(306, 225);
            this.derslerList.TabIndex = 0;
            this.derslerList.SelectedIndexChanged += new System.EventHandler(this.derslerList_SelectedIndexChanged);
            // 
            // ogrenciList
            // 
            this.ogrenciList.FormattingEnabled = true;
            this.ogrenciList.Location = new System.Drawing.Point(33, 147);
            this.ogrenciList.Name = "ogrenciList";
            this.ogrenciList.Size = new System.Drawing.Size(274, 225);
            this.ogrenciList.TabIndex = 1;
            this.ogrenciList.SelectedIndexChanged += new System.EventHandler(this.ogrenciList_SelectedIndexChanged);
            // 
            // derscombo
            // 
            this.derscombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.derscombo.FormattingEnabled = true;
            this.derscombo.Items.AddRange(new object[] {
            "Lisans",
            "Yüksek Lisans",
            "Doktora"});
            this.derscombo.Location = new System.Drawing.Point(205, 66);
            this.derscombo.Name = "derscombo";
            this.derscombo.Size = new System.Drawing.Size(211, 21);
            this.derscombo.TabIndex = 2;
            this.derscombo.SelectedIndexChanged += new System.EventHandler(this.derscombo_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(270, 447);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Dersi Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(33, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 49);
            this.button2.TabIndex = 4;
            this.button2.Text = "Öğrenci Ekle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dersNotu
            // 
            this.dersNotu.Location = new System.Drawing.Point(260, 412);
            this.dersNotu.Name = "dersNotu";
            this.dersNotu.Size = new System.Drawing.Size(100, 20);
            this.dersNotu.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(406, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Lütfen Ders Seçiniz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(202, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Seçtiğiniz Dersin Başarı Notunu Giriniz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(226, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Öğrenci Tipiniz Seçiniz";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(30, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Öğrenci Listesi";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(428, 409);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 47);
            this.button3.TabIndex = 10;
            this.button3.Text = "Tüm Bilgileri Gör";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 500);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dersNotu);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.derscombo);
            this.Controls.Add(this.ogrenciList);
            this.Controls.Add(this.derslerList);
            this.Name = "MainPage";
            this.Text = "Öğrenci Bilgi Sistemi";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox derslerList;
        private System.Windows.Forms.ListBox ogrenciList;
        private System.Windows.Forms.ComboBox derscombo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox dersNotu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
    }
}

