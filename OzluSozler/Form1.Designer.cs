namespace OzluSozler
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoz = new System.Windows.Forms.TextBox();
            this.txtYazar = new System.Windows.Forms.TextBox();
            this.nudDerece = new System.Windows.Forms.NumericUpDown();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lstSozler = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cboSiralama = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudDerece)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Söz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Yazar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "Derece";
            // 
            // txtSoz
            // 
            this.txtSoz.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSoz.Location = new System.Drawing.Point(126, 6);
            this.txtSoz.Name = "txtSoz";
            this.txtSoz.Size = new System.Drawing.Size(832, 36);
            this.txtSoz.TabIndex = 1;
            // 
            // txtYazar
            // 
            this.txtYazar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtYazar.Location = new System.Drawing.Point(126, 49);
            this.txtYazar.Name = "txtYazar";
            this.txtYazar.Size = new System.Drawing.Size(832, 36);
            this.txtYazar.TabIndex = 2;
            // 
            // nudDerece
            // 
            this.nudDerece.Location = new System.Drawing.Point(126, 93);
            this.nudDerece.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.nudDerece.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudDerece.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDerece.Name = "nudDerece";
            this.nudDerece.Size = new System.Drawing.Size(120, 36);
            this.nudDerece.TabIndex = 3;
            this.nudDerece.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnEkle
            // 
            this.btnEkle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEkle.Location = new System.Drawing.Point(12, 138);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(946, 42);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lstSozler
            // 
            this.lstSozler.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstSozler.DisplayMember = "Ozet";
            this.lstSozler.FormattingEnabled = true;
            this.lstSozler.ItemHeight = 30;
            this.lstSozler.Location = new System.Drawing.Point(12, 246);
            this.lstSozler.Name = "lstSozler";
            this.lstSozler.Size = new System.Drawing.Size(946, 334);
            this.lstSozler.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(720, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 30);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ara";
            // 
            // txtAra
            // 
            this.txtAra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAra.Location = new System.Drawing.Point(772, 201);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(186, 36);
            this.txtAra.TabIndex = 7;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // btnSil
            // 
            this.btnSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSil.Location = new System.Drawing.Point(823, 596);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(136, 42);
            this.btnSil.TabIndex = 8;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDuzenle.Location = new System.Drawing.Point(681, 596);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(136, 42);
            this.btnDuzenle.TabIndex = 9;
            this.btnDuzenle.Text = "DÜZENLE";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 30);
            this.label5.TabIndex = 10;
            this.label5.Text = "Sıralama Ölçütü";
            // 
            // cboSiralama
            // 
            this.cboSiralama.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSiralama.FormattingEnabled = true;
            this.cboSiralama.Items.AddRange(new object[] {
            "Seçiniz",
            "Dereceye Göre Artan",
            "Dereceye Göre Azalan"});
            this.cboSiralama.Location = new System.Drawing.Point(182, 199);
            this.cboSiralama.Name = "cboSiralama";
            this.cboSiralama.Size = new System.Drawing.Size(280, 38);
            this.cboSiralama.TabIndex = 11;
            this.cboSiralama.SelectedIndexChanged += new System.EventHandler(this.cboSiralama_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 650);
            this.Controls.Add(this.cboSiralama);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstSozler);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.nudDerece);
            this.Controls.Add(this.txtYazar);
            this.Controls.Add(this.txtSoz);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.Text = "Özlü Sözler";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.nudDerece)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtSoz;
        private TextBox txtYazar;
        private NumericUpDown nudDerece;
        private Button btnEkle;
        private ListBox lstSozler;
        private Label label4;
        private TextBox txtAra;
        private Button btnSil;
        private Button btnDuzenle;
        private Label label5;
        private ComboBox cboSiralama;
    }
}