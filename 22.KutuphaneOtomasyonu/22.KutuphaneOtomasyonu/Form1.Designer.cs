
namespace _22.KutuphaneOtomasyonu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.chkIsSale = new System.Windows.Forms.CheckBox();
            this.dtpPublishDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.nudPageCount = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtAuthorName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvBooks = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPageCount)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel6);
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.chkIsSale);
            this.groupBox1.Controls.Add(this.dtpPublishDate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.nudPageCount);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.txtAuthorName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.txtBookName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(691, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(8);
            this.groupBox1.Size = new System.Drawing.Size(290, 500);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ekleme / Düzenleme / Silme";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnDelete);
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.btnUpdate);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.btnAdd);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(8, 433);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(274, 59);
            this.panel6.TabIndex = 13;
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDelete.Location = new System.Drawing.Point(5, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 59);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(80, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(10, 59);
            this.panel8.TabIndex = 3;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnUpdate.Location = new System.Drawing.Point(90, 0);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(99, 59);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(189, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(10, 59);
            this.panel7.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAdd.Location = new System.Drawing.Point(199, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 59);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(8, 301);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(274, 10);
            this.panel5.TabIndex = 12;
            // 
            // chkIsSale
            // 
            this.chkIsSale.AutoSize = true;
            this.chkIsSale.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkIsSale.Location = new System.Drawing.Point(8, 276);
            this.chkIsSale.Name = "chkIsSale";
            this.chkIsSale.Size = new System.Drawing.Size(274, 25);
            this.chkIsSale.TabIndex = 11;
            this.chkIsSale.Text = "Satışta";
            this.chkIsSale.UseVisualStyleBackColor = true;
            // 
            // dtpPublishDate
            // 
            this.dtpPublishDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpPublishDate.Location = new System.Drawing.Point(8, 247);
            this.dtpPublishDate.Name = "dtpPublishDate";
            this.dtpPublishDate.Size = new System.Drawing.Size(274, 29);
            this.dtpPublishDate.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(8, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(274, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Yayın Tarihi";
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(8, 212);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(274, 10);
            this.panel4.TabIndex = 8;
            // 
            // nudPageCount
            // 
            this.nudPageCount.Dock = System.Windows.Forms.DockStyle.Top;
            this.nudPageCount.Location = new System.Drawing.Point(8, 183);
            this.nudPageCount.Name = "nudPageCount";
            this.nudPageCount.Size = new System.Drawing.Size(274, 29);
            this.nudPageCount.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(8, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sayfa Sayısı";
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(8, 148);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(274, 10);
            this.panel3.TabIndex = 5;
            // 
            // txtAuthorName
            // 
            this.txtAuthorName.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAuthorName.Location = new System.Drawing.Point(8, 119);
            this.txtAuthorName.Name = "txtAuthorName";
            this.txtAuthorName.Size = new System.Drawing.Size(274, 29);
            this.txtAuthorName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(8, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Yazar Adı";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(8, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(274, 10);
            this.panel2.TabIndex = 2;
            // 
            // txtBookName
            // 
            this.txtBookName.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtBookName.Location = new System.Drawing.Point(8, 55);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(274, 29);
            this.txtBookName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(8, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap Adı";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvBooks);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(691, 500);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kitaplar";
            // 
            // lvBooks
            // 
            this.lvBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvBooks.HideSelection = false;
            this.lvBooks.Location = new System.Drawing.Point(3, 25);
            this.lvBooks.Name = "lvBooks";
            this.lvBooks.Size = new System.Drawing.Size(685, 472);
            this.lvBooks.TabIndex = 0;
            this.lvBooks.UseCompatibleStateImageBehavior = false;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(681, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 500);
            this.panel1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 500);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "Form1";
            this.Text = "Kütüphane Otomasyonu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudPageCount)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.CheckBox chkIsSale;
        private System.Windows.Forms.DateTimePicker dtpPublishDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown nudPageCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtAuthorName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lvBooks;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnUpdate;
    }
}

