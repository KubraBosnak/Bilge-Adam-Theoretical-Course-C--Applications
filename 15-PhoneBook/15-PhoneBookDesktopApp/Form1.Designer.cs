
namespace _15_PhoneBookDesktopApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblListTitle = new System.Windows.Forms.Label();
            this.lstPeople = new System.Windows.Forms.ListBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.rdbMale = new System.Windows.Forms.RadioButton();
            this.rdbFemale = new System.Windows.Forms.RadioButton();
            this.mtxtPhone = new System.Windows.Forms.MaskedTextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.chkFavorite = new System.Windows.Forms.CheckBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblgender = new System.Windows.Forms.Label();
            this.lblcategory = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblListTitle
            // 
            this.lblListTitle.AutoSize = true;
            this.lblListTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblListTitle.Location = new System.Drawing.Point(12, 23);
            this.lblListTitle.Name = "lblListTitle";
            this.lblListTitle.Size = new System.Drawing.Size(55, 19);
            this.lblListTitle.TabIndex = 0;
            this.lblListTitle.Text = "Person";
            // 
            // lstPeople
            // 
            this.lstPeople.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lstPeople.FormattingEnabled = true;
            this.lstPeople.ItemHeight = 15;
            this.lstPeople.Location = new System.Drawing.Point(12, 51);
            this.lstPeople.Name = "lstPeople";
            this.lstPeople.Size = new System.Drawing.Size(220, 274);
            this.lstPeople.TabIndex = 1;
            this.lstPeople.SelectedIndexChanged += new System.EventHandler(this.lstPeople_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(73, 22);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Write a text..";
            this.txtSearch.Size = new System.Drawing.Size(159, 23);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.Orange;
            this.btnAddNew.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAddNew.Location = new System.Drawing.Point(431, 6);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(60, 47);
            this.btnAddNew.TabIndex = 3;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnDel);
            this.groupBox1.Controls.Add(this.rdbMale);
            this.groupBox1.Controls.Add(this.rdbFemale);
            this.groupBox1.Controls.Add(this.mtxtPhone);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.chkFavorite);
            this.groupBox1.Controls.Add(this.cmbCategory);
            this.groupBox1.Controls.Add(this.txtSurname);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.lblgender);
            this.groupBox1.Controls.Add(this.lblcategory);
            this.groupBox1.Controls.Add(this.lblPhone);
            this.groupBox1.Controls.Add(this.lblSurname);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Location = new System.Drawing.Point(271, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 275);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Person Add / Edit / Delete";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Olive;
            this.btnSave.Location = new System.Drawing.Point(81, 234);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(60, 25);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.OrangeRed;
            this.btnDel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDel.Location = new System.Drawing.Point(15, 234);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(60, 25);
            this.btnDel.TabIndex = 16;
            this.btnDel.Text = "Del";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.Location = new System.Drawing.Point(156, 175);
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.Size = new System.Drawing.Size(51, 19);
            this.rdbMale.TabIndex = 15;
            this.rdbMale.TabStop = true;
            this.rdbMale.Text = "Male";
            this.rdbMale.UseVisualStyleBackColor = true;
            // 
            // rdbFemale
            // 
            this.rdbFemale.AutoSize = true;
            this.rdbFemale.Location = new System.Drawing.Point(90, 175);
            this.rdbFemale.Name = "rdbFemale";
            this.rdbFemale.Size = new System.Drawing.Size(63, 19);
            this.rdbFemale.TabIndex = 14;
            this.rdbFemale.TabStop = true;
            this.rdbFemale.Text = "Female";
            this.rdbFemale.UseVisualStyleBackColor = true;
            // 
            // mtxtPhone
            // 
            this.mtxtPhone.Location = new System.Drawing.Point(90, 105);
            this.mtxtPhone.Mask = "(999) 000-0000";
            this.mtxtPhone.Name = "mtxtPhone";
            this.mtxtPhone.Size = new System.Drawing.Size(100, 23);
            this.mtxtPhone.TabIndex = 13;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.Location = new System.Drawing.Point(147, 234);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(60, 25);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // chkFavorite
            // 
            this.chkFavorite.AutoSize = true;
            this.chkFavorite.Location = new System.Drawing.Point(90, 200);
            this.chkFavorite.Name = "chkFavorite";
            this.chkFavorite.Size = new System.Drawing.Size(68, 19);
            this.chkFavorite.TabIndex = 10;
            this.chkFavorite.Text = "Favorite";
            this.chkFavorite.UseVisualStyleBackColor = true;
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "Family",
            "Friends",
            "Bussiness"});
            this.cmbCategory.Location = new System.Drawing.Point(90, 140);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(100, 23);
            this.cmbCategory.TabIndex = 7;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(90, 65);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.PlaceholderText = "Doe";
            this.txtSurname.Size = new System.Drawing.Size(100, 23);
            this.txtSurname.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(90, 30);
            this.txtName.Name = "txtName";
            this.txtName.PlaceholderText = "John";
            this.txtName.Size = new System.Drawing.Size(100, 23);
            this.txtName.TabIndex = 5;
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Location = new System.Drawing.Point(6, 177);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(45, 15);
            this.lblgender.TabIndex = 6;
            this.lblgender.Text = "Gender";
            // 
            // lblcategory
            // 
            this.lblcategory.AutoSize = true;
            this.lblcategory.Location = new System.Drawing.Point(6, 143);
            this.lblcategory.Name = "lblcategory";
            this.lblcategory.Size = new System.Drawing.Size(55, 15);
            this.lblcategory.TabIndex = 6;
            this.lblcategory.Text = "Category";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(6, 108);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(41, 15);
            this.lblPhone.TabIndex = 6;
            this.lblPhone.Text = "Phone";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(6, 68);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(54, 15);
            this.lblSurname.TabIndex = 6;
            this.lblSurname.Text = "Surname";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 33);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 15);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(277, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(507, 350);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lstPeople);
            this.Controls.Add(this.lblListTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Telefon Rehberi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblListTitle;
        private System.Windows.Forms.ListBox lstPeople;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.RadioButton rdbMale;
        private System.Windows.Forms.RadioButton rdbFemale;
        private System.Windows.Forms.MaskedTextBox mtxtPhone;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.CheckBox chkFavorite;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.Label lblcategory;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

