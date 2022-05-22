
namespace KutuphaneOtomasyonu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.chkIsSale = new System.Windows.Forms.CheckBox();
            this.panel5 = new System.Windows.Forms.Panel();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvBooks = new System.Windows.Forms.ListView();
            this.clmBookName = new System.Windows.Forms.ColumnHeader();
            this.clmBookAuthor = new System.Windows.Forms.ColumnHeader();
            this.clmPageCount = new System.Windows.Forms.ColumnHeader();
            this.clmPublishedDate = new System.Windows.Forms.ColumnHeader();
            this.clmIsSale = new System.Windows.Forms.ColumnHeader();
            this.imgListViewLargeIcons = new System.Windows.Forms.ImageList(this.components);
            this.imgListViewSmallIcons = new System.Windows.Forms.ImageList(this.components);
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.cmbListViewTypes = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNewBook = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPageCount)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Controls.Add(this.chkIsSale);
            this.groupBox1.Controls.Add(this.panel5);
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
            this.groupBox1.Location = new System.Drawing.Point(705, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(8, 20, 8, 8);
            this.groupBox1.Size = new System.Drawing.Size(281, 499);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ekleme/Düzenleme/Silme";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnAdd);
            this.flowLayoutPanel1.Controls.Add(this.btnEdit);
            this.flowLayoutPanel1.Controls.Add(this.btnDelete);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(8, 450);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(265, 41);
            this.flowLayoutPanel1.TabIndex = 13;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(187, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 35);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(95, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(86, 35);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Güncelle";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(14, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 35);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // chkIsSale
            // 
            this.chkIsSale.AutoSize = true;
            this.chkIsSale.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkIsSale.Location = new System.Drawing.Point(8, 298);
            this.chkIsSale.Name = "chkIsSale";
            this.chkIsSale.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkIsSale.Size = new System.Drawing.Size(265, 25);
            this.chkIsSale.TabIndex = 12;
            this.chkIsSale.Text = "Satışta";
            this.chkIsSale.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chkIsSale.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(8, 288);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(265, 10);
            this.panel5.TabIndex = 11;
            // 
            // dtpPublishDate
            // 
            this.dtpPublishDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpPublishDate.Location = new System.Drawing.Point(8, 259);
            this.dtpPublishDate.Name = "dtpPublishDate";
            this.dtpPublishDate.Size = new System.Drawing.Size(265, 29);
            this.dtpPublishDate.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(8, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(265, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Yayın Tarihi";
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(8, 224);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(265, 10);
            this.panel4.TabIndex = 8;
            // 
            // nudPageCount
            // 
            this.nudPageCount.Dock = System.Windows.Forms.DockStyle.Top;
            this.nudPageCount.Location = new System.Drawing.Point(8, 195);
            this.nudPageCount.Name = "nudPageCount";
            this.nudPageCount.Size = new System.Drawing.Size(265, 29);
            this.nudPageCount.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(8, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sayfa Sayısı";
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(8, 160);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(265, 10);
            this.panel3.TabIndex = 5;
            // 
            // txtAuthorName
            // 
            this.txtAuthorName.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtAuthorName.Location = new System.Drawing.Point(8, 131);
            this.txtAuthorName.Name = "txtAuthorName";
            this.txtAuthorName.Size = new System.Drawing.Size(265, 29);
            this.txtAuthorName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(8, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Yazar Adı";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(8, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(265, 10);
            this.panel2.TabIndex = 2;
            // 
            // txtBookName
            // 
            this.txtBookName.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtBookName.Location = new System.Drawing.Point(8, 67);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(265, 29);
            this.txtBookName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(8, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap Adı";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(695, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 499);
            this.panel1.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvBooks);
            this.groupBox2.Controls.Add(this.flowLayoutPanel2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(10, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(8);
            this.groupBox2.Size = new System.Drawing.Size(685, 499);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kitaplar";
            // 
            // lvBooks
            // 
            this.lvBooks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmBookName,
            this.clmBookAuthor,
            this.clmPageCount,
            this.clmPublishedDate,
            this.clmIsSale});
            this.lvBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvBooks.HideSelection = false;
            this.lvBooks.LargeImageList = this.imgListViewLargeIcons;
            this.lvBooks.Location = new System.Drawing.Point(8, 67);
            this.lvBooks.Name = "lvBooks";
            this.lvBooks.Size = new System.Drawing.Size(669, 424);
            this.lvBooks.SmallImageList = this.imgListViewSmallIcons;
            this.lvBooks.TabIndex = 1;
            this.lvBooks.UseCompatibleStateImageBehavior = false;
            this.lvBooks.View = System.Windows.Forms.View.Details;
            // 
            // clmBookName
            // 
            this.clmBookName.Text = "Kitap Adı";
            this.clmBookName.Width = 150;
            // 
            // clmBookAuthor
            // 
            this.clmBookAuthor.Text = "Yazar Adı";
            this.clmBookAuthor.Width = 120;
            // 
            // clmPageCount
            // 
            this.clmPageCount.Text = "Sayfa Sayısı";
            this.clmPageCount.Width = 100;
            // 
            // clmPublishedDate
            // 
            this.clmPublishedDate.Text = "Yayın Tarihi";
            this.clmPublishedDate.Width = 120;
            // 
            // clmIsSale
            // 
            this.clmIsSale.Text = "Satışta";
            // 
            // imgListViewLargeIcons
            // 
            this.imgListViewLargeIcons.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgListViewLargeIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListViewLargeIcons.ImageStream")));
            this.imgListViewLargeIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListViewLargeIcons.Images.SetKeyName(0, "285636_book_icon.png");
            // 
            // imgListViewSmallIcons
            // 
            this.imgListViewSmallIcons.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgListViewSmallIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListViewSmallIcons.ImageStream")));
            this.imgListViewSmallIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListViewSmallIcons.Images.SetKeyName(0, "285636_book_icon (1).png");
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.cmbListViewTypes);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(8, 30);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(669, 37);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // cmbListViewTypes
            // 
            this.cmbListViewTypes.FormattingEnabled = true;
            this.cmbListViewTypes.Items.AddRange(new object[] {
            "Large Icon",
            "Small Icon",
            "Tile",
            "Details",
            "List"});
            this.cmbListViewTypes.Location = new System.Drawing.Point(469, 3);
            this.cmbListViewTypes.Name = "cmbListViewTypes";
            this.cmbListViewTypes.Size = new System.Drawing.Size(197, 29);
            this.cmbListViewTypes.TabIndex = 0;
            this.cmbListViewTypes.Text = "Details";
            this.cmbListViewTypes.SelectedIndexChanged += new System.EventHandler(this.cmbListViewTypes_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(10, 10);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(976, 25);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNewBook});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(56, 21);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // mnuNewBook
            // 
            this.mnuNewBook.Name = "mnuNewBook";
            this.mnuNewBook.Size = new System.Drawing.Size(180, 22);
            this.mnuNewBook.Text = "Yeni Kitap";
            this.mnuNewBook.Click += new System.EventHandler(this.mnuNewBook_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 544);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(877, 458);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kütüphane Otomasyonu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudPageCount)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkIsSale;
        private System.Windows.Forms.Panel panel5;
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
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListView lvBooks;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.ComboBox cmbListViewTypes;
        private System.Windows.Forms.ImageList imgListViewLargeIcons;
        private System.Windows.Forms.ImageList imgListViewSmallIcons;
        private System.Windows.Forms.ColumnHeader clmBookName;
        private System.Windows.Forms.ColumnHeader clmBookAuthor;
        private System.Windows.Forms.ColumnHeader clmPageCount;
        private System.Windows.Forms.ColumnHeader clmPublishedDate;
        private System.Windows.Forms.ColumnHeader clmIsSale;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuNewBook;
    }
}

