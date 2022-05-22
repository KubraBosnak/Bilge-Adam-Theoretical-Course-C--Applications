
namespace GenericListveArrayList
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
            this.txtYeniVeri = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnListRemove = new System.Windows.Forms.Button();
            this.btnListReverse = new System.Windows.Forms.Button();
            this.btnListSort = new System.Windows.Forms.Button();
            this.btnListEkle = new System.Windows.Forms.Button();
            this.txtVeri = new System.Windows.Forms.TextBox();
            this.lstVeriler = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnArrayEkle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtYeniVeri
            // 
            this.txtYeniVeri.Location = new System.Drawing.Point(505, 483);
            this.txtYeniVeri.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtYeniVeri.Name = "txtYeniVeri";
            this.txtYeniVeri.Size = new System.Drawing.Size(205, 27);
            this.txtYeniVeri.TabIndex = 19;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Plum;
            this.btnUpdate.Location = new System.Drawing.Point(505, 522);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(205, 31);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnListRemove
            // 
            this.btnListRemove.BackColor = System.Drawing.Color.Plum;
            this.btnListRemove.Location = new System.Drawing.Point(505, 375);
            this.btnListRemove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnListRemove.Name = "btnListRemove";
            this.btnListRemove.Size = new System.Drawing.Size(205, 31);
            this.btnListRemove.TabIndex = 17;
            this.btnListRemove.Text = "Sil";
            this.btnListRemove.UseVisualStyleBackColor = false;
            this.btnListRemove.Click += new System.EventHandler(this.btnListRemove_Click);
            // 
            // btnListReverse
            // 
            this.btnListReverse.BackColor = System.Drawing.Color.Plum;
            this.btnListReverse.Location = new System.Drawing.Point(505, 336);
            this.btnListReverse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnListReverse.Name = "btnListReverse";
            this.btnListReverse.Size = new System.Drawing.Size(205, 31);
            this.btnListReverse.TabIndex = 16;
            this.btnListReverse.Text = "Ters Çevir";
            this.btnListReverse.UseVisualStyleBackColor = false;
            this.btnListReverse.Click += new System.EventHandler(this.btnListReverse_Click);
            // 
            // btnListSort
            // 
            this.btnListSort.BackColor = System.Drawing.Color.Plum;
            this.btnListSort.Location = new System.Drawing.Point(505, 298);
            this.btnListSort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnListSort.Name = "btnListSort";
            this.btnListSort.Size = new System.Drawing.Size(205, 31);
            this.btnListSort.TabIndex = 15;
            this.btnListSort.Text = "Sırala";
            this.btnListSort.UseVisualStyleBackColor = false;
            this.btnListSort.Click += new System.EventHandler(this.btnListSort_Click);
            // 
            // btnListEkle
            // 
            this.btnListEkle.BackColor = System.Drawing.Color.Plum;
            this.btnListEkle.Location = new System.Drawing.Point(505, 259);
            this.btnListEkle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnListEkle.Name = "btnListEkle";
            this.btnListEkle.Size = new System.Drawing.Size(205, 31);
            this.btnListEkle.TabIndex = 14;
            this.btnListEkle.Text = "List <> Ekle";
            this.btnListEkle.UseVisualStyleBackColor = false;
            this.btnListEkle.Click += new System.EventHandler(this.btnListEkle_Click);
            // 
            // txtVeri
            // 
            this.txtVeri.Location = new System.Drawing.Point(12, 26);
            this.txtVeri.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtVeri.Name = "txtVeri";
            this.txtVeri.Size = new System.Drawing.Size(459, 27);
            this.txtVeri.TabIndex = 13;
            // 
            // lstVeriler
            // 
            this.lstVeriler.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lstVeriler.FormattingEnabled = true;
            this.lstVeriler.ItemHeight = 20;
            this.lstVeriler.Location = new System.Drawing.Point(12, 67);
            this.lstVeriler.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstVeriler.Name = "lstVeriler";
            this.lstVeriler.Size = new System.Drawing.Size(459, 504);
            this.lstVeriler.TabIndex = 12;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Tan;
            this.groupBox4.Location = new System.Drawing.Point(495, 447);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(221, 125);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Generic List ile Güncelleme";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Tan;
            this.groupBox3.Location = new System.Drawing.Point(495, 227);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(221, 191);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Generic List ile İşlemler";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Tan;
            this.groupBox2.Controls.Add(this.btnArrayEkle);
            this.groupBox2.Location = new System.Drawing.Point(495, 118);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(221, 79);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Array List İşlemleri";
            // 
            // btnArrayEkle
            // 
            this.btnArrayEkle.BackColor = System.Drawing.Color.Plum;
            this.btnArrayEkle.Location = new System.Drawing.Point(10, 29);
            this.btnArrayEkle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnArrayEkle.Name = "btnArrayEkle";
            this.btnArrayEkle.Size = new System.Drawing.Size(205, 31);
            this.btnArrayEkle.TabIndex = 3;
            this.btnArrayEkle.Text = "Array List Ekle";
            this.btnArrayEkle.UseVisualStyleBackColor = false;
            this.btnArrayEkle.Click += new System.EventHandler(this.btnArrayEkle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Tan;
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Location = new System.Drawing.Point(495, 26);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(221, 72);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Normal Dizi İşlemleri";
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Plum;
            this.btnEkle.Location = new System.Drawing.Point(10, 29);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(205, 31);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Dizi Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(777, 599);
            this.Controls.Add(this.txtYeniVeri);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnListRemove);
            this.Controls.Add(this.btnListReverse);
            this.Controls.Add(this.btnListSort);
            this.Controls.Add(this.btnListEkle);
            this.Controls.Add(this.txtVeri);
            this.Controls.Add(this.lstVeriler);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Array List ve Generic List Ekleme Programı";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtYeniVeri;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnListRemove;
        private System.Windows.Forms.Button btnListReverse;
        private System.Windows.Forms.Button btnListSort;
        private System.Windows.Forms.Button btnListEkle;
        private System.Windows.Forms.TextBox txtVeri;
        private System.Windows.Forms.ListBox lstVeriler;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnArrayEkle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEkle;
    }
}

