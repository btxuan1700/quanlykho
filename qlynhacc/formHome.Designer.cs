namespace qlynhacc
{
    partial class formHome
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
            this.buttonnhapkho = new System.Windows.Forms.Button();
            this.buttonqlncc = new System.Windows.Forms.Button();
            this.buttonxuatkho = new System.Windows.Forms.Button();
            this.buttonquanlysp = new System.Windows.Forms.Button();
            this.buttondangxuat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonnhapkho
            // 
            this.buttonnhapkho.Location = new System.Drawing.Point(138, 65);
            this.buttonnhapkho.Name = "buttonnhapkho";
            this.buttonnhapkho.Size = new System.Drawing.Size(172, 23);
            this.buttonnhapkho.TabIndex = 0;
            this.buttonnhapkho.Text = "Quan ly nhap kho";
            this.buttonnhapkho.UseVisualStyleBackColor = true;
            // 
            // buttonqlncc
            // 
            this.buttonqlncc.Location = new System.Drawing.Point(138, 207);
            this.buttonqlncc.Name = "buttonqlncc";
            this.buttonqlncc.Size = new System.Drawing.Size(176, 23);
            this.buttonqlncc.TabIndex = 1;
            this.buttonqlncc.Text = "Quan ly nha chung cap";
            this.buttonqlncc.UseVisualStyleBackColor = true;
            this.buttonqlncc.Click += new System.EventHandler(this.buttonqlncc_Click);
            // 
            // buttonxuatkho
            // 
            this.buttonxuatkho.Location = new System.Drawing.Point(424, 65);
            this.buttonxuatkho.Name = "buttonxuatkho";
            this.buttonxuatkho.Size = new System.Drawing.Size(183, 23);
            this.buttonxuatkho.TabIndex = 2;
            this.buttonxuatkho.Text = "Quan ly xuat kho";
            this.buttonxuatkho.UseVisualStyleBackColor = true;
            // 
            // buttonquanlysp
            // 
            this.buttonquanlysp.Location = new System.Drawing.Point(424, 207);
            this.buttonquanlysp.Name = "buttonquanlysp";
            this.buttonquanlysp.Size = new System.Drawing.Size(191, 23);
            this.buttonquanlysp.TabIndex = 3;
            this.buttonquanlysp.Text = "Quan ly san pham";
            this.buttonquanlysp.UseVisualStyleBackColor = true;
            // 
            // buttondangxuat
            // 
            this.buttondangxuat.Location = new System.Drawing.Point(472, 330);
            this.buttondangxuat.Name = "buttondangxuat";
            this.buttondangxuat.Size = new System.Drawing.Size(100, 42);
            this.buttondangxuat.TabIndex = 4;
            this.buttondangxuat.Text = "Dang xuat";
            this.buttondangxuat.UseVisualStyleBackColor = true;
            this.buttondangxuat.Click += new System.EventHandler(this.buttondangxuat_Click);
            // 
            // formHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttondangxuat);
            this.Controls.Add(this.buttonquanlysp);
            this.Controls.Add(this.buttonxuatkho);
            this.Controls.Add(this.buttonqlncc);
            this.Controls.Add(this.buttonnhapkho);
            this.Name = "formHome";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonnhapkho;
        private System.Windows.Forms.Button buttonqlncc;
        private System.Windows.Forms.Button buttonxuatkho;
        private System.Windows.Forms.Button buttonquanlysp;
        private System.Windows.Forms.Button buttondangxuat;
    }
}