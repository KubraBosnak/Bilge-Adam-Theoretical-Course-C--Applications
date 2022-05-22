
namespace MasaustuUygulamalarınaGiris
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
            this.btnTopla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSayi2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCıkar = new System.Windows.Forms.Button();
            this.btnCarp = new System.Windows.Forms.Button();
            this.btnBol = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.nudSayi1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudSayi1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTopla
            // 
            this.btnTopla.Location = new System.Drawing.Point(231, 28);
            this.btnTopla.Margin = new System.Windows.Forms.Padding(4);
            this.btnTopla.Name = "btnTopla";
            this.btnTopla.Size = new System.Drawing.Size(96, 29);
            this.btnTopla.TabIndex = 0;
            this.btnTopla.Text = "Topla";
            this.btnTopla.UseVisualStyleBackColor = true;
            this.btnTopla.Click += new System.EventHandler(this.btnTopla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sayı 1 : ";
            // 
            // txtSayi2
            // 
            this.txtSayi2.Location = new System.Drawing.Point(97, 77);
            this.txtSayi2.Name = "txtSayi2";
            this.txtSayi2.Size = new System.Drawing.Size(100, 29);
            this.txtSayi2.TabIndex = 5;
            this.txtSayi2.Text = "20";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(28, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sayı 2 : ";
            // 
            // btnCıkar
            // 
            this.btnCıkar.Location = new System.Drawing.Point(231, 77);
            this.btnCıkar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCıkar.Name = "btnCıkar";
            this.btnCıkar.Size = new System.Drawing.Size(96, 29);
            this.btnCıkar.TabIndex = 3;
            this.btnCıkar.Text = "Çıkar";
            this.btnCıkar.UseVisualStyleBackColor = true;
            this.btnCıkar.Click += new System.EventHandler(this.btnCıkar_Click);
            // 
            // btnCarp
            // 
            this.btnCarp.Location = new System.Drawing.Point(231, 126);
            this.btnCarp.Margin = new System.Windows.Forms.Padding(4);
            this.btnCarp.Name = "btnCarp";
            this.btnCarp.Size = new System.Drawing.Size(96, 29);
            this.btnCarp.TabIndex = 7;
            this.btnCarp.Text = "Çarpma";
            this.btnCarp.UseVisualStyleBackColor = true;
            this.btnCarp.Click += new System.EventHandler(this.btnCarp_Click);
            // 
            // btnBol
            // 
            this.btnBol.Location = new System.Drawing.Point(231, 172);
            this.btnBol.Margin = new System.Windows.Forms.Padding(4);
            this.btnBol.Name = "btnBol";
            this.btnBol.Size = new System.Drawing.Size(96, 29);
            this.btnBol.TabIndex = 6;
            this.btnBol.Text = "Bölme";
            this.btnBol.UseVisualStyleBackColor = true;
            this.btnBol.Click += new System.EventHandler(this.btnBol_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSonuc.Location = new System.Drawing.Point(40, 126);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(139, 61);
            this.lblSonuc.TabIndex = 8;
            this.lblSonuc.Text = "0";
            this.lblSonuc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudSayi1
            // 
            this.nudSayi1.DecimalPlaces = 2;
            this.nudSayi1.Location = new System.Drawing.Point(97, 32);
            this.nudSayi1.Name = "nudSayi1";
            this.nudSayi1.Size = new System.Drawing.Size(100, 29);
            this.nudSayi1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(371, 229);
            this.Controls.Add(this.nudSayi1);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.btnCarp);
            this.Controls.Add(this.btnBol);
            this.Controls.Add(this.txtSayi2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCıkar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTopla);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Benim İlk Masaüstü Uygulama Örneğim";
            ((System.ComponentModel.ISupportInitialize)(this.nudSayi1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTopla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSayi2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCıkar;
        private System.Windows.Forms.Button btnCarp;
        private System.Windows.Forms.Button btnBol;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.NumericUpDown nudSayi1;
    }
}

