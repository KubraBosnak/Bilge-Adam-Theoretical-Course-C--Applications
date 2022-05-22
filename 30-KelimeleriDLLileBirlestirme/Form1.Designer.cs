
namespace _30_KelimeleriDLLileBirlestirme
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
            this.lstWords = new System.Windows.Forms.ListBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstWords);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.txtWord);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(260, 270);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Words";
            // 
            // lstWords
            // 
            this.lstWords.FormattingEnabled = true;
            this.lstWords.ItemHeight = 15;
            this.lstWords.Location = new System.Drawing.Point(4, 55);
            this.lstWords.Margin = new System.Windows.Forms.Padding(2);
            this.lstWords.Name = "lstWords";
            this.lstWords.Size = new System.Drawing.Size(252, 214);
            this.lstWords.TabIndex = 2;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(177, 17);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(2);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(78, 24);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Add";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtWord
            // 
            this.txtWord.Location = new System.Drawing.Point(4, 18);
            this.txtWord.Margin = new System.Windows.Forms.Padding(2);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(159, 23);
            this.txtWord.TabIndex = 0;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(264, 16);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(2);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(161, 25);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblResult.Location = new System.Drawing.Point(264, 55);
            this.lblResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(161, 209);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "...";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 270);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstWords;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lblResult;
    }
}

