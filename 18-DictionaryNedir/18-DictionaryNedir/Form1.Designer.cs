
namespace _18_DictionaryNedir
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
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.btnTranslate = new System.Windows.Forms.Button();
            this.lstWords = new System.Windows.Forms.ListBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(21, 40);
            this.txtKeyword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(293, 23);
            this.txtKeyword.TabIndex = 0;
            // 
            // btnTranslate
            // 
            this.btnTranslate.Location = new System.Drawing.Point(343, 40);
            this.btnTranslate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(75, 23);
            this.btnTranslate.TabIndex = 1;
            this.btnTranslate.Text = "Çevir";
            this.btnTranslate.UseVisualStyleBackColor = true;
            this.btnTranslate.Click += new System.EventHandler(this.btnTranslate_Click);
            // 
            // lstWords
            // 
            this.lstWords.FormattingEnabled = true;
            this.lstWords.ItemHeight = 15;
            this.lstWords.Location = new System.Drawing.Point(21, 72);
            this.lstWords.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstWords.Name = "lstWords";
            this.lstWords.Size = new System.Drawing.Size(293, 244);
            this.lstWords.TabIndex = 2;
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(21, 13);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(148, 23);
            this.txtKey.TabIndex = 3;
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(175, 12);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(139, 23);
            this.txtValue.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(343, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 332);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.lstWords);
            this.Controls.Add(this.btnTranslate);
            this.Controls.Add(this.txtKeyword);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Button btnTranslate;
        private System.Windows.Forms.ListBox lstWords;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Button btnAdd;
    }
}

