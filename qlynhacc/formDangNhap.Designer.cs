namespace qlynhacc
{
    partial class formDangNhap
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
            this.txttk = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmk = new System.Windows.Forms.TextBox();
            this.buttondn = new System.Windows.Forms.Button();
            this.buttonthoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txttk
            // 
            this.txttk.Location = new System.Drawing.Point(166, 50);
            this.txttk.Name = "txttk";
            this.txttk.Size = new System.Drawing.Size(221, 22);
            this.txttk.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ten dang nhap";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mat Khau";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtmk
            // 
            this.txtmk.Location = new System.Drawing.Point(166, 134);
            this.txtmk.Name = "txtmk";
            this.txtmk.Size = new System.Drawing.Size(221, 22);
            this.txtmk.TabIndex = 2;
            // 
            // buttondn
            // 
            this.buttondn.Location = new System.Drawing.Point(97, 265);
            this.buttondn.Name = "buttondn";
            this.buttondn.Size = new System.Drawing.Size(131, 36);
            this.buttondn.TabIndex = 4;
            this.buttondn.Text = "Dang nhap";
            this.buttondn.UseVisualStyleBackColor = true;
            this.buttondn.Click += new System.EventHandler(this.buttondn_Click);
            // 
            // buttonthoat
            // 
            this.buttonthoat.Location = new System.Drawing.Point(366, 265);
            this.buttonthoat.Name = "buttonthoat";
            this.buttonthoat.Size = new System.Drawing.Size(75, 36);
            this.buttonthoat.TabIndex = 5;
            this.buttonthoat.Text = "Thoat";
            this.buttonthoat.UseVisualStyleBackColor = true;
            this.buttonthoat.Click += new System.EventHandler(this.buttonthoat_Click);
            // 
            // formDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonthoat);
            this.Controls.Add(this.buttondn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttk);
            this.Name = "formDangNhap";
            this.Text = "formDangNhap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txttk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmk;
        private System.Windows.Forms.Button buttondn;
        private System.Windows.Forms.Button buttonthoat;
    }
}