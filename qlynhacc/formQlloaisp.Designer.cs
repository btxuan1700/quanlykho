namespace qlynhacc
{
    partial class formQlloaisp
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
            this.txtmaloaisp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txttenloaisp = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonthem = new System.Windows.Forms.Button();
            this.buttonsua = new System.Windows.Forms.Button();
            this.buttonxoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // txtmaloaisp
            // 
            this.txtmaloaisp.Location = new System.Drawing.Point(186, 59);
            this.txtmaloaisp.Name = "txtmaloaisp";
            this.txtmaloaisp.Size = new System.Drawing.Size(214, 22);
            this.txtmaloaisp.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ma loai sp";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ten loai san pham";
            // 
            // txttenloaisp
            // 
            this.txttenloaisp.Location = new System.Drawing.Point(216, 136);
            this.txttenloaisp.Name = "txttenloaisp";
            this.txttenloaisp.Size = new System.Drawing.Size(184, 22);
            this.txttenloaisp.TabIndex = 2;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgv.Location = new System.Drawing.Point(69, 281);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(602, 150);
            this.dgv.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Ma loai sp";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ten loai san pham";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // buttonthem
            // 
            this.buttonthem.Location = new System.Drawing.Point(482, 52);
            this.buttonthem.Name = "buttonthem";
            this.buttonthem.Size = new System.Drawing.Size(75, 23);
            this.buttonthem.TabIndex = 6;
            this.buttonthem.Text = "Them";
            this.buttonthem.UseVisualStyleBackColor = true;
            this.buttonthem.Click += new System.EventHandler(this.buttonthem_Click);
            // 
            // buttonsua
            // 
            this.buttonsua.Location = new System.Drawing.Point(482, 136);
            this.buttonsua.Name = "buttonsua";
            this.buttonsua.Size = new System.Drawing.Size(75, 23);
            this.buttonsua.TabIndex = 7;
            this.buttonsua.Text = "Sua";
            this.buttonsua.UseVisualStyleBackColor = true;
            this.buttonsua.Click += new System.EventHandler(this.buttonsua_Click);
            // 
            // buttonxoa
            // 
            this.buttonxoa.Location = new System.Drawing.Point(482, 219);
            this.buttonxoa.Name = "buttonxoa";
            this.buttonxoa.Size = new System.Drawing.Size(75, 23);
            this.buttonxoa.TabIndex = 8;
            this.buttonxoa.Text = "Xoa";
            this.buttonxoa.UseVisualStyleBackColor = true;
            // 
            // formqlloaisp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonxoa);
            this.Controls.Add(this.buttonsua);
            this.Controls.Add(this.buttonthem);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txttenloaisp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtmaloaisp);
            this.Name = "formqlloaisp";
            this.Text = "qlloaisp";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmaloaisp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttenloaisp;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button buttonthem;
        private System.Windows.Forms.Button buttonsua;
        private System.Windows.Forms.Button buttonxoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}