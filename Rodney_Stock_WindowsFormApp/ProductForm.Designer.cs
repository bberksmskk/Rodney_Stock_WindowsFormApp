namespace Rodney_Stock_WindowsFormApp
{
    partial class ProductForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_barkodno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_urunAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_aciklama = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nud_fiyat = new System.Windows.Forms.NumericUpDown();
            this.checkBox_aktif = new System.Windows.Forms.CheckBox();
            this.cb_kategoriler = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_marka = new System.Windows.Forms.ComboBox();
            this.CMS_SilDuzenle = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TSMI_Duzenle = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Sil = new System.Windows.Forms.ToolStripMenuItem();
            this.yokEtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_duzenle = new System.Windows.Forms.Button();
            this.btn_xml = new System.Windows.Forms.Button();
            this.pb_resim = new System.Windows.Forms.PictureBox();
            this.dgv_variants = new System.Windows.Forms.DataGridView();
            this.btn_addVariant = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_fiyat)).BeginInit();
            this.CMS_SilDuzenle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_resim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_variants)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 372);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1083, 278);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDown);
            // 
            // btn_ekle
            // 
            this.btn_ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btn_ekle.Location = new System.Drawing.Point(800, 299);
            this.btn_ekle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(297, 43);
            this.btn_ekle.TabIndex = 12;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Barkod No :";
            // 
            // tb_barkodno
            // 
            this.tb_barkodno.Location = new System.Drawing.Point(29, 54);
            this.tb_barkodno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_barkodno.Name = "tb_barkodno";
            this.tb_barkodno.Size = new System.Drawing.Size(289, 22);
            this.tb_barkodno.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(24, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Ürün Adı : ";
            // 
            // tb_urunAdi
            // 
            this.tb_urunAdi.Location = new System.Drawing.Point(29, 121);
            this.tb_urunAdi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_urunAdi.Name = "tb_urunAdi";
            this.tb_urunAdi.Size = new System.Drawing.Size(289, 22);
            this.tb_urunAdi.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(795, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Resim : ";
            // 
            // tb_aciklama
            // 
            this.tb_aciklama.Location = new System.Drawing.Point(800, 190);
            this.tb_aciklama.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_aciklama.Multiline = true;
            this.tb_aciklama.Name = "tb_aciklama";
            this.tb_aciklama.Size = new System.Drawing.Size(297, 94);
            this.tb_aciklama.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(795, 161);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Açıklama";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(24, 156);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Fiyat : ";
            // 
            // nud_fiyat
            // 
            this.nud_fiyat.Location = new System.Drawing.Point(29, 187);
            this.nud_fiyat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nud_fiyat.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.nud_fiyat.Name = "nud_fiyat";
            this.nud_fiyat.Size = new System.Drawing.Size(291, 22);
            this.nud_fiyat.TabIndex = 20;
            // 
            // checkBox_aktif
            // 
            this.checkBox_aktif.AutoSize = true;
            this.checkBox_aktif.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox_aktif.Location = new System.Drawing.Point(384, 49);
            this.checkBox_aktif.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_aktif.Name = "checkBox_aktif";
            this.checkBox_aktif.Size = new System.Drawing.Size(64, 24);
            this.checkBox_aktif.TabIndex = 21;
            this.checkBox_aktif.Text = "Aktif";
            this.checkBox_aktif.UseVisualStyleBackColor = true;
            // 
            // cb_kategoriler
            // 
            this.cb_kategoriler.FormattingEnabled = true;
            this.cb_kategoriler.Location = new System.Drawing.Point(31, 316);
            this.cb_kategoriler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_kategoriler.Name = "cb_kategoriler";
            this.cb_kategoriler.Size = new System.Drawing.Size(288, 24);
            this.cb_kategoriler.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(25, 289);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Kategori";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(25, 224);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Marka";
            // 
            // cb_marka
            // 
            this.cb_marka.FormattingEnabled = true;
            this.cb_marka.Location = new System.Drawing.Point(31, 252);
            this.cb_marka.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_marka.Name = "cb_marka";
            this.cb_marka.Size = new System.Drawing.Size(288, 24);
            this.cb_marka.TabIndex = 24;
            // 
            // CMS_SilDuzenle
            // 
            this.CMS_SilDuzenle.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CMS_SilDuzenle.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Duzenle,
            this.TSMI_Sil,
            this.yokEtToolStripMenuItem});
            this.CMS_SilDuzenle.Name = "CMS_SilDuzenle";
            this.CMS_SilDuzenle.Size = new System.Drawing.Size(154, 76);
            // 
            // TSMI_Duzenle
            // 
            this.TSMI_Duzenle.Name = "TSMI_Duzenle";
            this.TSMI_Duzenle.Size = new System.Drawing.Size(153, 24);
            this.TSMI_Duzenle.Text = "Düzenle";
            this.TSMI_Duzenle.Click += new System.EventHandler(this.TSMI_Duzenle_Click);
            // 
            // TSMI_Sil
            // 
            this.TSMI_Sil.Name = "TSMI_Sil";
            this.TSMI_Sil.Size = new System.Drawing.Size(153, 24);
            this.TSMI_Sil.Text = "Sil / Geri Al";
            this.TSMI_Sil.Click += new System.EventHandler(this.TSMI_Sil_Click);
            // 
            // yokEtToolStripMenuItem
            // 
            this.yokEtToolStripMenuItem.Name = "yokEtToolStripMenuItem";
            this.yokEtToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.yokEtToolStripMenuItem.Text = "Yok Et!";
            this.yokEtToolStripMenuItem.Click += new System.EventHandler(this.yokEtToolStripMenuItem_Click);
            // 
            // btn_duzenle
            // 
            this.btn_duzenle.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn_duzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btn_duzenle.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_duzenle.Location = new System.Drawing.Point(801, 299);
            this.btn_duzenle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_duzenle.Name = "btn_duzenle";
            this.btn_duzenle.Size = new System.Drawing.Size(297, 43);
            this.btn_duzenle.TabIndex = 27;
            this.btn_duzenle.Text = "Düzenle";
            this.btn_duzenle.UseVisualStyleBackColor = false;
            this.btn_duzenle.Visible = false;
            // 
            // btn_xml
            // 
            this.btn_xml.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn_xml.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btn_xml.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_xml.Location = new System.Drawing.Point(432, 299);
            this.btn_xml.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_xml.Name = "btn_xml";
            this.btn_xml.Size = new System.Drawing.Size(271, 43);
            this.btn_xml.TabIndex = 28;
            this.btn_xml.Text = "XML Çıktısı";
            this.btn_xml.UseVisualStyleBackColor = false;
            this.btn_xml.Click += new System.EventHandler(this.btn_xml_Click);
            // 
            // pb_resim
            // 
            this.pb_resim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_resim.Image = global::Rodney_Stock_WindowsFormApp.Properties.Resources.add_image;
            this.pb_resim.Location = new System.Drawing.Point(800, 39);
            this.pb_resim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pb_resim.Name = "pb_resim";
            this.pb_resim.Size = new System.Drawing.Size(299, 121);
            this.pb_resim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_resim.TabIndex = 18;
            this.pb_resim.TabStop = false;
            this.pb_resim.Click += new System.EventHandler(this.pb_resim_Click);
            // 
            // dgv_variants
            // 
            this.dgv_variants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_variants.Location = new System.Drawing.Point(384, 100);
            this.dgv_variants.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_variants.Name = "dgv_variants";
            this.dgv_variants.RowHeadersWidth = 51;
            this.dgv_variants.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_variants.Size = new System.Drawing.Size(383, 98);
            this.dgv_variants.TabIndex = 29;
            // 
            // btn_addVariant
            // 
            this.btn_addVariant.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn_addVariant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btn_addVariant.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_addVariant.Location = new System.Drawing.Point(432, 214);
            this.btn_addVariant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_addVariant.Name = "btn_addVariant";
            this.btn_addVariant.Size = new System.Drawing.Size(271, 43);
            this.btn_addVariant.TabIndex = 30;
            this.btn_addVariant.Text = "Varyans Ekle";
            this.btn_addVariant.UseVisualStyleBackColor = false;
            this.btn_addVariant.Click += new System.EventHandler(this.btn_addVariant_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 665);
            this.Controls.Add(this.btn_addVariant);
            this.Controls.Add(this.dgv_variants);
            this.Controls.Add(this.btn_xml);
            this.Controls.Add(this.btn_duzenle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cb_marka);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_kategoriler);
            this.Controls.Add(this.checkBox_aktif);
            this.Controls.Add(this.nud_fiyat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pb_resim);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_aciklama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_urunAdi);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_barkodno);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_fiyat)).EndInit();
            this.CMS_SilDuzenle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_resim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_variants)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_barkodno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_urunAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_aciklama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pb_resim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nud_fiyat;
        private System.Windows.Forms.CheckBox checkBox_aktif;
        private System.Windows.Forms.ComboBox cb_kategoriler;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_marka;
        private System.Windows.Forms.ContextMenuStrip CMS_SilDuzenle;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Duzenle;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Sil;
        private System.Windows.Forms.Button btn_duzenle;
        private System.Windows.Forms.ToolStripMenuItem yokEtToolStripMenuItem;
        private System.Windows.Forms.Button btn_xml;
        private System.Windows.Forms.DataGridView dgv_variants;
        private System.Windows.Forms.Button btn_addVariant;
    }
}