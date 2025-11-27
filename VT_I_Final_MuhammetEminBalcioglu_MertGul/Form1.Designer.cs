namespace VT_I_Final_MuhammetEminBalcioglu_MertGul
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.akademikbirim1 = new System.Windows.Forms.TextBox();
            this.akademikbirim2 = new System.Windows.Forms.TextBox();
            this.akademikbirimeklebuton = new System.Windows.Forms.Button();
            this.akademikbirimsilbuton = new System.Windows.Forms.Button();
            this.akademikbirimno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.akademikbirimadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ogertimelemani1 = new System.Windows.Forms.TextBox();
            this.ogretimelemani2 = new System.Windows.Forms.TextBox();
            this.ogretimelemani3 = new System.Windows.Forms.TextBox();
            this.ogretimelemani4 = new System.Windows.Forms.TextBox();
            this.ogretimelemani5 = new System.Windows.Forms.TextBox();
            this.ogretimelemaniekle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ogretimelemanisil = new System.Windows.Forms.Button();
            this.ogretimelemanino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.İsim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyisim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.akademikbirimnoogret = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dersno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1052, 620);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.akademikbirimsilbuton);
            this.tabPage1.Controls.Add(this.akademikbirimeklebuton);
            this.tabPage1.Controls.Add(this.akademikbirim2);
            this.tabPage1.Controls.Add(this.akademikbirim1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1044, 594);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Akademik Birim";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ogretimelemanisil);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.ogretimelemaniekle);
            this.tabPage2.Controls.Add(this.ogretimelemani5);
            this.tabPage2.Controls.Add(this.ogretimelemani4);
            this.tabPage2.Controls.Add(this.ogretimelemani3);
            this.tabPage2.Controls.Add(this.ogretimelemani2);
            this.tabPage2.Controls.Add(this.ogertimelemani1);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1044, 594);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Öğretim Elemanı";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1044, 594);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Dersler";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1044, 594);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Ders Adları";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1044, 594);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Notlar";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1044, 594);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Öğrenci";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(1044, 594);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Program";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabPage8
            // 
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(1044, 594);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "Ders Programı";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.akademikbirimno,
            this.akademikbirimadi});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView1.Location = new System.Drawing.Point(562, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(479, 588);
            this.dataGridView1.TabIndex = 0;
            // 
            // akademikbirim1
            // 
            this.akademikbirim1.Location = new System.Drawing.Point(27, 20);
            this.akademikbirim1.Name = "akademikbirim1";
            this.akademikbirim1.Size = new System.Drawing.Size(100, 20);
            this.akademikbirim1.TabIndex = 1;
            // 
            // akademikbirim2
            // 
            this.akademikbirim2.Location = new System.Drawing.Point(27, 46);
            this.akademikbirim2.Name = "akademikbirim2";
            this.akademikbirim2.Size = new System.Drawing.Size(100, 20);
            this.akademikbirim2.TabIndex = 2;
            // 
            // akademikbirimeklebuton
            // 
            this.akademikbirimeklebuton.Location = new System.Drawing.Point(27, 72);
            this.akademikbirimeklebuton.Name = "akademikbirimeklebuton";
            this.akademikbirimeklebuton.Size = new System.Drawing.Size(100, 23);
            this.akademikbirimeklebuton.TabIndex = 3;
            this.akademikbirimeklebuton.Text = "ekle";
            this.akademikbirimeklebuton.UseVisualStyleBackColor = true;
            // 
            // akademikbirimsilbuton
            // 
            this.akademikbirimsilbuton.Location = new System.Drawing.Point(177, 72);
            this.akademikbirimsilbuton.Name = "akademikbirimsilbuton";
            this.akademikbirimsilbuton.Size = new System.Drawing.Size(100, 23);
            this.akademikbirimsilbuton.TabIndex = 4;
            this.akademikbirimsilbuton.Text = "sil";
            this.akademikbirimsilbuton.UseVisualStyleBackColor = true;
            // 
            // akademikbirimno
            // 
            this.akademikbirimno.HeaderText = "Akademik Birim No";
            this.akademikbirimno.Name = "akademikbirimno";
            // 
            // akademikbirimadi
            // 
            this.akademikbirimadi.HeaderText = "Akademik Birim Adı";
            this.akademikbirimadi.Name = "akademikbirimadi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Akademik Birim No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Akademik Birim Adı";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogretimelemanino,
            this.İsim,
            this.soyisim,
            this.akademikbirimnoogret,
            this.dersno});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView2.Location = new System.Drawing.Point(350, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(691, 588);
            this.dataGridView2.TabIndex = 0;
            // 
            // ogertimelemani1
            // 
            this.ogertimelemani1.Location = new System.Drawing.Point(35, 35);
            this.ogertimelemani1.Name = "ogertimelemani1";
            this.ogertimelemani1.Size = new System.Drawing.Size(100, 20);
            this.ogertimelemani1.TabIndex = 1;
            // 
            // ogretimelemani2
            // 
            this.ogretimelemani2.Location = new System.Drawing.Point(35, 61);
            this.ogretimelemani2.Name = "ogretimelemani2";
            this.ogretimelemani2.Size = new System.Drawing.Size(100, 20);
            this.ogretimelemani2.TabIndex = 2;
            // 
            // ogretimelemani3
            // 
            this.ogretimelemani3.Location = new System.Drawing.Point(35, 87);
            this.ogretimelemani3.Name = "ogretimelemani3";
            this.ogretimelemani3.Size = new System.Drawing.Size(100, 20);
            this.ogretimelemani3.TabIndex = 3;
            // 
            // ogretimelemani4
            // 
            this.ogretimelemani4.Location = new System.Drawing.Point(35, 113);
            this.ogretimelemani4.Name = "ogretimelemani4";
            this.ogretimelemani4.Size = new System.Drawing.Size(100, 20);
            this.ogretimelemani4.TabIndex = 4;
            // 
            // ogretimelemani5
            // 
            this.ogretimelemani5.Location = new System.Drawing.Point(35, 139);
            this.ogretimelemani5.Name = "ogretimelemani5";
            this.ogretimelemani5.Size = new System.Drawing.Size(100, 20);
            this.ogretimelemani5.TabIndex = 5;
            // 
            // ogretimelemaniekle
            // 
            this.ogretimelemaniekle.Location = new System.Drawing.Point(35, 165);
            this.ogretimelemaniekle.Name = "ogretimelemaniekle";
            this.ogretimelemaniekle.Size = new System.Drawing.Size(100, 23);
            this.ogretimelemaniekle.TabIndex = 6;
            this.ogretimelemaniekle.Text = "Ekle";
            this.ogretimelemaniekle.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Öğretim Elemanı No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Öğretim Elemanı İsim";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(141, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Öğretim Elemanı Soyisim";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(141, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Akademik Birim";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(141, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Ders No";
            // 
            // ogretimelemanisil
            // 
            this.ogretimelemanisil.Location = new System.Drawing.Point(144, 165);
            this.ogretimelemanisil.Name = "ogretimelemanisil";
            this.ogretimelemanisil.Size = new System.Drawing.Size(100, 23);
            this.ogretimelemanisil.TabIndex = 12;
            this.ogretimelemanisil.Text = "Sil";
            this.ogretimelemanisil.UseVisualStyleBackColor = true;
            // 
            // ogretimelemanino
            // 
            this.ogretimelemanino.HeaderText = "Öğretim Elemanı No";
            this.ogretimelemanino.Name = "ogretimelemanino";
            // 
            // İsim
            // 
            this.İsim.HeaderText = "isim";
            this.İsim.Name = "İsim";
            // 
            // soyisim
            // 
            this.soyisim.HeaderText = "Soyisim";
            this.soyisim.Name = "soyisim";
            // 
            // akademikbirimnoogret
            // 
            this.akademikbirimnoogret.HeaderText = "Akademik Birim";
            this.akademikbirimnoogret.Name = "akademikbirimnoogret";
            // 
            // dersno
            // 
            this.dersno.HeaderText = "Ders No";
            this.dersno.Name = "dersno";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 644);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Veri Tabanı Proje";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button akademikbirimsilbuton;
        private System.Windows.Forms.Button akademikbirimeklebuton;
        private System.Windows.Forms.TextBox akademikbirim2;
        private System.Windows.Forms.TextBox akademikbirim1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn akademikbirimno;
        private System.Windows.Forms.DataGridViewTextBoxColumn akademikbirimadi;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ogretimelemaniekle;
        private System.Windows.Forms.TextBox ogretimelemani5;
        private System.Windows.Forms.TextBox ogretimelemani4;
        private System.Windows.Forms.TextBox ogretimelemani3;
        private System.Windows.Forms.TextBox ogretimelemani2;
        private System.Windows.Forms.TextBox ogertimelemani1;
        private System.Windows.Forms.Button ogretimelemanisil;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogretimelemanino;
        private System.Windows.Forms.DataGridViewTextBoxColumn İsim;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyisim;
        private System.Windows.Forms.DataGridViewTextBoxColumn akademikbirimnoogret;
        private System.Windows.Forms.DataGridViewTextBoxColumn dersno;
    }
}

