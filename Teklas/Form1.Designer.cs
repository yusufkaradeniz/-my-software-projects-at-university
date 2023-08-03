namespace Teklas
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ad = new System.Windows.Forms.TextBox();
            this.syad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dtarih = new System.Windows.Forms.DateTimePicker();
            this.snfog = new System.Windows.Forms.ComboBox();
            this.snf = new System.Windows.Forms.ComboBox();
            this.ara = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.okulDataSet = new Teklas.okulDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.okulDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(657, 392);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // ad
            // 
            this.ad.Location = new System.Drawing.Point(783, 41);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(100, 20);
            this.ad.TabIndex = 1;
            // 
            // syad
            // 
            this.syad.Location = new System.Drawing.Point(783, 84);
            this.syad.Name = "syad";
            this.syad.Size = new System.Drawing.Size(100, 20);
            this.syad.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(752, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ADI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(730, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "SOYADI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(690, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "DOĞUM TARİHİ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(740, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "SINIFI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(675, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "SINIF ÖĞRETMENİ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(702, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "EKLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(783, 315);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "GÜNCELLE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(864, 315);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Sil";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dtarih
            // 
            this.dtarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtarih.Location = new System.Drawing.Point(783, 128);
            this.dtarih.Name = "dtarih";
            this.dtarih.Size = new System.Drawing.Size(120, 20);
            this.dtarih.TabIndex = 14;
            this.dtarih.Value = new System.DateTime(2023, 7, 26, 13, 9, 14, 0);
            // 
            // snfog
            // 
            this.snfog.FormattingEnabled = true;
            this.snfog.Items.AddRange(new object[] {
            "DERMAN KURTOĞLU",
            "MEHMET ÖZGÜR ŞİVİL",
            "MÜGE BAYSAL"});
            this.snfog.Location = new System.Drawing.Point(782, 204);
            this.snfog.Name = "snfog";
            this.snfog.Size = new System.Drawing.Size(121, 21);
            this.snfog.TabIndex = 15;
            // 
            // snf
            // 
            this.snf.FormattingEnabled = true;
            this.snf.Items.AddRange(new object[] {
            "1-A",
            "1-B",
            "1-C"});
            this.snf.Location = new System.Drawing.Point(783, 167);
            this.snf.Name = "snf";
            this.snf.Size = new System.Drawing.Size(121, 21);
            this.snf.TabIndex = 16;
            this.snf.SelectedIndexChanged += new System.EventHandler(this.snf_SelectedIndexChanged);
            // 
            // ara
            // 
            this.ara.Location = new System.Drawing.Point(103, 432);
            this.ara.Name = "ara";
            this.ara.Size = new System.Drawing.Size(177, 20);
            this.ara.TabIndex = 17;
            this.ara.TextChanged += new System.EventHandler(this.ara_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 435);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Öğrenci ARAMA\r\n";
            // 
            // Id
            // 
            this.Id.Enabled = false;
            this.Id.Location = new System.Drawing.Point(1268, 12);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(100, 20);
            this.Id.TabIndex = 19;
            this.Id.Visible = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(378, 410);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(958, 206);
            this.dataGridView2.TabIndex = 20;
            // 
            // okulDataSet
            // 
            this.okulDataSet.DataSetName = "okulDataSet";
            this.okulDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 675);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ara);
            this.Controls.Add(this.snf);
            this.Controls.Add(this.snfog);
            this.Controls.Add(this.dtarih);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.syad);
            this.Controls.Add(this.ad);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.okulDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox ad;
        private System.Windows.Forms.TextBox syad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker dtarih;
        private System.Windows.Forms.ComboBox snfog;
        private System.Windows.Forms.ComboBox snf;
        private System.Windows.Forms.TextBox ara;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Id;
        private System.Windows.Forms.DataGridView dataGridView2;
        private okulDataSet okulDataSet;
    }
}

