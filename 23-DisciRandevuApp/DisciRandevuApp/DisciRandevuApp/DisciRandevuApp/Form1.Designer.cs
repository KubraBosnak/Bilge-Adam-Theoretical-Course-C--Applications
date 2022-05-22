
namespace DisciRandevuApp
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.trvDoctorsCustomers = new System.Windows.Forms.TreeView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnDoctorAdd = new System.Windows.Forms.ToolStripButton();
            this.btnDoctorEdit = new System.Windows.Forms.ToolStripButton();
            this.btnDoctorDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCustomerAdd = new System.Windows.Forms.ToolStripButton();
            this.btnCustomerEdit = new System.Windows.Forms.ToolStripButton();
            this.btnCustomerDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSaveDoctorsCustomers = new System.Windows.Forms.ToolStripButton();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lvAppointments = new System.Windows.Forms.ListView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnAppointmentAdd = new System.Windows.Forms.ToolStripButton();
            this.btnAppointmentDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSaveAppointments = new System.Windows.Forms.ToolStripButton();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtAppoinmentDetail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1135, 520);
            this.splitContainer1.SplitterDistance = 352;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.trvDoctorsCustomers);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 495);
            this.panel1.TabIndex = 1;
            // 
            // trvDoctorsCustomers
            // 
            this.trvDoctorsCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvDoctorsCustomers.Location = new System.Drawing.Point(0, 0);
            this.trvDoctorsCustomers.Name = "trvDoctorsCustomers";
            this.trvDoctorsCustomers.Size = new System.Drawing.Size(352, 495);
            this.trvDoctorsCustomers.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDoctorAdd,
            this.btnDoctorEdit,
            this.btnDoctorDelete,
            this.toolStripSeparator1,
            this.btnCustomerAdd,
            this.btnCustomerEdit,
            this.btnCustomerDelete,
            this.toolStripSeparator2,
            this.btnSaveDoctorsCustomers});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(352, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnDoctorAdd
            // 
            this.btnDoctorAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDoctorAdd.Image = global::DisciRandevuApp.Properties.Resources._2561291_plus_circle_icon;
            this.btnDoctorAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDoctorAdd.Name = "btnDoctorAdd";
            this.btnDoctorAdd.Size = new System.Drawing.Size(23, 22);
            this.btnDoctorAdd.Text = "Yeni Doktor Ekle";
            this.btnDoctorAdd.Click += new System.EventHandler(this.btnDoctorAdd_Click);
            // 
            // btnDoctorEdit
            // 
            this.btnDoctorEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDoctorEdit.Image = global::DisciRandevuApp.Properties.Resources._2561260_edit_icon;
            this.btnDoctorEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDoctorEdit.Name = "btnDoctorEdit";
            this.btnDoctorEdit.Size = new System.Drawing.Size(23, 22);
            this.btnDoctorEdit.Text = "Doktor Düzenle";
            // 
            // btnDoctorDelete
            // 
            this.btnDoctorDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDoctorDelete.Image = global::DisciRandevuApp.Properties.Resources._2561211_circle_x_icon;
            this.btnDoctorDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDoctorDelete.Name = "btnDoctorDelete";
            this.btnDoctorDelete.Size = new System.Drawing.Size(23, 22);
            this.btnDoctorDelete.Text = "Doktor Sil";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnCustomerAdd
            // 
            this.btnCustomerAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCustomerAdd.Image = global::DisciRandevuApp.Properties.Resources._216490_add_user_icon;
            this.btnCustomerAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCustomerAdd.Name = "btnCustomerAdd";
            this.btnCustomerAdd.Size = new System.Drawing.Size(23, 22);
            this.btnCustomerAdd.Text = "Yeni Hasta";
            this.btnCustomerAdd.Click += new System.EventHandler(this.btnCustomerAdd_Click);
            // 
            // btnCustomerEdit
            // 
            this.btnCustomerEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCustomerEdit.Image = global::DisciRandevuApp.Properties.Resources._216184_edit_icon;
            this.btnCustomerEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCustomerEdit.Name = "btnCustomerEdit";
            this.btnCustomerEdit.Size = new System.Drawing.Size(23, 22);
            this.btnCustomerEdit.Text = "Hasta Düzenle";
            // 
            // btnCustomerDelete
            // 
            this.btnCustomerDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCustomerDelete.Image = global::DisciRandevuApp.Properties.Resources._216479_trash_icon;
            this.btnCustomerDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCustomerDelete.Name = "btnCustomerDelete";
            this.btnCustomerDelete.Size = new System.Drawing.Size(23, 22);
            this.btnCustomerDelete.Text = "Hasta Sil";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnSaveDoctorsCustomers
            // 
            this.btnSaveDoctorsCustomers.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSaveDoctorsCustomers.Image = global::DisciRandevuApp.Properties.Resources.save;
            this.btnSaveDoctorsCustomers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveDoctorsCustomers.Name = "btnSaveDoctorsCustomers";
            this.btnSaveDoctorsCustomers.Size = new System.Drawing.Size(23, 22);
            this.btnSaveDoctorsCustomers.Text = "Kaydet";
            this.btnSaveDoctorsCustomers.Click += new System.EventHandler(this.btnSaveDoctorsCustomers_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.panel2);
            this.splitContainer2.Panel1.Controls.Add(this.toolStrip2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.txtAppoinmentDetail);
            this.splitContainer2.Panel2.Controls.Add(this.toolStrip3);
            this.splitContainer2.Size = new System.Drawing.Size(779, 520);
            this.splitContainer2.SplitterDistance = 553;
            this.splitContainer2.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lvAppointments);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(553, 495);
            this.panel2.TabIndex = 1;
            // 
            // lvAppointments
            // 
            this.lvAppointments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvAppointments.HideSelection = false;
            this.lvAppointments.Location = new System.Drawing.Point(0, 0);
            this.lvAppointments.Name = "lvAppointments";
            this.lvAppointments.Size = new System.Drawing.Size(553, 495);
            this.lvAppointments.TabIndex = 0;
            this.lvAppointments.UseCompatibleStateImageBehavior = false;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAppointmentAdd,
            this.btnAppointmentDelete,
            this.toolStripSeparator3,
            this.btnSaveAppointments});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(553, 25);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnAppointmentAdd
            // 
            this.btnAppointmentAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAppointmentAdd.Image = global::DisciRandevuApp.Properties.Resources._2561291_plus_circle_icon;
            this.btnAppointmentAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAppointmentAdd.Name = "btnAppointmentAdd";
            this.btnAppointmentAdd.Size = new System.Drawing.Size(23, 22);
            this.btnAppointmentAdd.Text = "Yeni Randevu";
            this.btnAppointmentAdd.Click += new System.EventHandler(this.btnAppointmentAdd_Click);
            // 
            // btnAppointmentDelete
            // 
            this.btnAppointmentDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAppointmentDelete.Image = global::DisciRandevuApp.Properties.Resources._216479_trash_icon;
            this.btnAppointmentDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAppointmentDelete.Name = "btnAppointmentDelete";
            this.btnAppointmentDelete.Size = new System.Drawing.Size(23, 22);
            this.btnAppointmentDelete.Text = "Randevu Sil";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnSaveAppointments
            // 
            this.btnSaveAppointments.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSaveAppointments.Image = global::DisciRandevuApp.Properties.Resources.save;
            this.btnSaveAppointments.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveAppointments.Name = "btnSaveAppointments";
            this.btnSaveAppointments.Size = new System.Drawing.Size(23, 22);
            this.btnSaveAppointments.Text = "Kaydet";
            this.btnSaveAppointments.Click += new System.EventHandler(this.btnSaveAppointments_Click);
            // 
            // toolStrip3
            // 
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip3.Location = new System.Drawing.Point(0, 0);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(222, 25);
            this.toolStrip3.TabIndex = 0;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(102, 22);
            this.toolStripLabel1.Text = "Randevu Notları";
            // 
            // txtAppoinmentDetail
            // 
            this.txtAppoinmentDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAppoinmentDetail.Location = new System.Drawing.Point(0, 25);
            this.txtAppoinmentDetail.Multiline = true;
            this.txtAppoinmentDetail.Name = "txtAppoinmentDetail";
            this.txtAppoinmentDetail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAppoinmentDetail.Size = new System.Drawing.Size(222, 495);
            this.txtAppoinmentDetail.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 520);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Dişçi Otomasyonu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnDoctorAdd;
        private System.Windows.Forms.ToolStripButton btnDoctorEdit;
        private System.Windows.Forms.ToolStripButton btnDoctorDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnCustomerAdd;
        private System.Windows.Forms.ToolStripButton btnCustomerEdit;
        private System.Windows.Forms.ToolStripButton btnCustomerDelete;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView trvDoctorsCustomers;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnAppointmentAdd;
        private System.Windows.Forms.ToolStripButton btnAppointmentDelete;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lvAppointments;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnSaveDoctorsCustomers;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnSaveAppointments;
        private System.Windows.Forms.TextBox txtAppoinmentDetail;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}

