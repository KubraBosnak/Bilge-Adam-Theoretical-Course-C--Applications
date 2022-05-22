
namespace DisciRandevuApp
{
    partial class frmDoctorAdd
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDoctorName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDoctorPhone = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDoctorEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDoctorField = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDoctorTcNo = new System.Windows.Forms.MaskedTextBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnAdd);
            this.flowLayoutPanel1.Controls.Add(this.btnCancel);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 433);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(349, 55);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAdd.Location = new System.Drawing.Point(261, 13);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 33);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(180, 13);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 33);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Vazgeç";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.txtDoctorName);
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.txtDoctorPhone);
            this.flowLayoutPanel2.Controls.Add(this.label3);
            this.flowLayoutPanel2.Controls.Add(this.txtDoctorEmail);
            this.flowLayoutPanel2.Controls.Add(this.label4);
            this.flowLayoutPanel2.Controls.Add(this.txtDoctorField);
            this.flowLayoutPanel2.Controls.Add(this.label5);
            this.flowLayoutPanel2.Controls.Add(this.txtDoctorTcNo);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(349, 433);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doktor Ad && Soyad";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtDoctorName
            // 
            this.txtDoctorName.Location = new System.Drawing.Point(16, 51);
            this.txtDoctorName.Name = "txtDoctorName";
            this.txtDoctorName.Size = new System.Drawing.Size(321, 29);
            this.txtDoctorName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(16, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Doktor Telefon";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtDoctorPhone
            // 
            this.txtDoctorPhone.Location = new System.Drawing.Point(16, 122);
            this.txtDoctorPhone.Mask = "(999) 000-0000";
            this.txtDoctorPhone.Name = "txtDoctorPhone";
            this.txtDoctorPhone.Size = new System.Drawing.Size(321, 29);
            this.txtDoctorPhone.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(16, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 36);
            this.label3.TabIndex = 8;
            this.label3.Text = "Doktor E-Posta Adresi";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtDoctorEmail
            // 
            this.txtDoctorEmail.Location = new System.Drawing.Point(16, 193);
            this.txtDoctorEmail.Name = "txtDoctorEmail";
            this.txtDoctorEmail.Size = new System.Drawing.Size(321, 29);
            this.txtDoctorEmail.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(16, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 36);
            this.label4.TabIndex = 10;
            this.label4.Text = "Doktor Branş";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtDoctorField
            // 
            this.txtDoctorField.Location = new System.Drawing.Point(16, 264);
            this.txtDoctorField.Name = "txtDoctorField";
            this.txtDoctorField.Size = new System.Drawing.Size(321, 29);
            this.txtDoctorField.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(16, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(226, 36);
            this.label5.TabIndex = 12;
            this.label5.Text = "Doktor TC No";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtDoctorTcNo
            // 
            this.txtDoctorTcNo.Location = new System.Drawing.Point(16, 335);
            this.txtDoctorTcNo.Mask = "00000000000";
            this.txtDoctorTcNo.Name = "txtDoctorTcNo";
            this.txtDoctorTcNo.Size = new System.Drawing.Size(321, 29);
            this.txtDoctorTcNo.TabIndex = 13;
            this.txtDoctorTcNo.ValidatingType = typeof(int);
            // 
            // frmDoctorAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 488);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmDoctorAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Doktor Ekle";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtDoctorName;
        public System.Windows.Forms.MaskedTextBox txtDoctorPhone;
        public System.Windows.Forms.TextBox txtDoctorEmail;
        public System.Windows.Forms.TextBox txtDoctorField;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.MaskedTextBox txtDoctorTcNo;
    }
}