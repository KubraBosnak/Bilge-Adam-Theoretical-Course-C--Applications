namespace _28_Serialization
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudAge = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCreatePersonal = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstPersons = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSaveXmlFile = new System.Windows.Forms.Button();
            this.btnCreateCustonXML = new System.Windows.Forms.Button();
            this.btnBinarySerialization = new System.Windows.Forms.Button();
            this.btnCreateJson = new System.Windows.Forms.Button();
            this.btnReadJson = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).BeginInit();
            this.flowLayoutPanel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(8);
            this.groupBox1.Size = new System.Drawing.Size(300, 549);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personals Info";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.txtFirstName);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.txtLastName);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.nudAge);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(8, 32);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(284, 509);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name :";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(3, 41);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(259, 31);
            this.txtFirstName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name :";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(3, 112);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(259, 31);
            this.txtLastName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 38);
            this.label3.TabIndex = 4;
            this.label3.Text = "Age :";
            // 
            // nudAge
            // 
            this.nudAge.Location = new System.Drawing.Point(3, 187);
            this.nudAge.Name = "nudAge";
            this.nudAge.Size = new System.Drawing.Size(259, 31);
            this.nudAge.TabIndex = 5;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.btnCreatePersonal);
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 224);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(259, 40);
            this.flowLayoutPanel3.TabIndex = 6;
            // 
            // btnCreatePersonal
            // 
            this.btnCreatePersonal.Location = new System.Drawing.Point(144, 3);
            this.btnCreatePersonal.Name = "btnCreatePersonal";
            this.btnCreatePersonal.Size = new System.Drawing.Size(112, 34);
            this.btnCreatePersonal.TabIndex = 1;
            this.btnCreatePersonal.Text = "ADD";
            this.btnCreatePersonal.UseVisualStyleBackColor = true;
            this.btnCreatePersonal.Click += new System.EventHandler(this.btnCreatePersonal_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstPersons);
            this.groupBox2.Controls.Add(this.flowLayoutPanel2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(300, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(910, 549);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Personals";
            // 
            // lstPersons
            // 
            this.lstPersons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstPersons.FormattingEnabled = true;
            this.lstPersons.ItemHeight = 25;
            this.lstPersons.Location = new System.Drawing.Point(3, 27);
            this.lstPersons.Name = "lstPersons";
            this.lstPersons.Size = new System.Drawing.Size(904, 470);
            this.lstPersons.TabIndex = 1;
            this.lstPersons.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstPersons_MouseDoubleClick);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnSaveXmlFile);
            this.flowLayoutPanel2.Controls.Add(this.btnCreateCustonXML);
            this.flowLayoutPanel2.Controls.Add(this.btnBinarySerialization);
            this.flowLayoutPanel2.Controls.Add(this.btnCreateJson);
            this.flowLayoutPanel2.Controls.Add(this.btnReadJson);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 497);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(904, 49);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // btnSaveXmlFile
            // 
            this.btnSaveXmlFile.Location = new System.Drawing.Point(790, 3);
            this.btnSaveXmlFile.Name = "btnSaveXmlFile";
            this.btnSaveXmlFile.Size = new System.Drawing.Size(111, 41);
            this.btnSaveXmlFile.TabIndex = 0;
            this.btnSaveXmlFile.Text = "Create XML";
            this.btnSaveXmlFile.UseVisualStyleBackColor = true;
            this.btnSaveXmlFile.Click += new System.EventHandler(this.btnSaveXmlFile_Click);
            // 
            // btnCreateCustonXML
            // 
            this.btnCreateCustonXML.Location = new System.Drawing.Point(605, 3);
            this.btnCreateCustonXML.Name = "btnCreateCustonXML";
            this.btnCreateCustonXML.Size = new System.Drawing.Size(179, 41);
            this.btnCreateCustonXML.TabIndex = 1;
            this.btnCreateCustonXML.Text = "Create Custom XML";
            this.btnCreateCustonXML.UseVisualStyleBackColor = true;
            this.btnCreateCustonXML.Click += new System.EventHandler(this.btnCreateCustonXML_Click);
            // 
            // btnBinarySerialization
            // 
            this.btnBinarySerialization.Location = new System.Drawing.Point(376, 3);
            this.btnBinarySerialization.Name = "btnBinarySerialization";
            this.btnBinarySerialization.Size = new System.Drawing.Size(223, 41);
            this.btnBinarySerialization.TabIndex = 2;
            this.btnBinarySerialization.Text = "Create Binary Serialization";
            this.btnBinarySerialization.UseVisualStyleBackColor = true;
            this.btnBinarySerialization.Click += new System.EventHandler(this.btnBinarySerialization_Click);
            // 
            // btnCreateJson
            // 
            this.btnCreateJson.Location = new System.Drawing.Point(247, 3);
            this.btnCreateJson.Name = "btnCreateJson";
            this.btnCreateJson.Size = new System.Drawing.Size(123, 41);
            this.btnCreateJson.TabIndex = 3;
            this.btnCreateJson.Text = "Create JSON";
            this.btnCreateJson.UseVisualStyleBackColor = true;
            this.btnCreateJson.Click += new System.EventHandler(this.btnCreateJson_Click);
            // 
            // btnReadJson
            // 
            this.btnReadJson.Location = new System.Drawing.Point(132, 3);
            this.btnReadJson.Name = "btnReadJson";
            this.btnReadJson.Size = new System.Drawing.Size(109, 41);
            this.btnReadJson.TabIndex = 4;
            this.btnReadJson.Text = "Read JSON";
            this.btnReadJson.UseVisualStyleBackColor = true;
            this.btnReadJson.Click += new System.EventHandler(this.btnReadJson_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 549);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Serialization";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).EndInit();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudAge;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button btnCreatePersonal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnSaveXmlFile;
        private System.Windows.Forms.ListBox lstPersons;
        private System.Windows.Forms.Button btnCreateCustonXML;
        private System.Windows.Forms.Button btnBinarySerialization;
        private System.Windows.Forms.Button btnCreateJson;
        private System.Windows.Forms.Button btnReadJson;
    }
}
