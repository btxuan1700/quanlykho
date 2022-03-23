namespace qlynhacc
{
    partial class formQlncc
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
            this.txtmancc = new System.Windows.Forms.TextBox();
            this.txttenncc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnnhapfile = new System.Windows.Forms.Button();
            this.buttonback = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // txtmancc
            // 
            this.txtmancc.Location = new System.Drawing.Point(177, 37);
            this.txtmancc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmancc.Name = "txtmancc";
            this.txtmancc.Size = new System.Drawing.Size(100, 22);
            this.txtmancc.TabIndex = 0;
            //this.txtmancc.TextChanged += new System.EventHandler(this.txtmancc_TextChanged);
            // 
            // txttenncc
            // 
            this.txttenncc.Location = new System.Drawing.Point(177, 92);
            this.txttenncc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttenncc.Name = "txttenncc";
            this.txttenncc.Size = new System.Drawing.Size(100, 22);
            this.txttenncc.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ma nha cung cap";
           // this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ten nha cung cap";
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgv.Location = new System.Drawing.Point(39, 303);
            this.dgv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(1091, 263);
            this.dgv.TabIndex = 5;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgv.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_CellMouseClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Ma ncc";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ten nha cun cap";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Dia chi";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "SDT";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Email";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "SDT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Dia chi";
            //this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(177, 217);
            this.txtsdt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(100, 22);
            this.txtsdt.TabIndex = 7;
            //this.txtsdt.TextChanged += new System.EventHandler(this.txtsdt_TextChanged);
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(177, 144);
            this.txtdiachi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(100, 22);
            this.txtdiachi.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Email";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(177, 274);
            this.txtemail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(100, 22);
            this.txtemail.TabIndex = 10;
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(604, 220);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 12;
            this.btnxoa.Text = "Xoa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(604, 174);
            this.btnsua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 13;
            this.btnsua.Text = "Sua";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(604, 110);
            this.btnthem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 30);
            this.btnthem.TabIndex = 14;
            this.btnthem.Text = "Them";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnnhapfile
            // 
            this.btnnhapfile.Location = new System.Drawing.Point(604, 39);
            this.btnnhapfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnnhapfile.Name = "btnnhapfile";
            this.btnnhapfile.Size = new System.Drawing.Size(75, 30);
            this.btnnhapfile.TabIndex = 15;
            this.btnnhapfile.Text = "Nhap file";
            this.btnnhapfile.UseVisualStyleBackColor = true;
            this.btnnhapfile.Click += new System.EventHandler(this.btnnhapfile_Click);
            // 
            // buttonback
            // 
            this.buttonback.Location = new System.Drawing.Point(1023, 236);
            this.buttonback.Name = "buttonback";
            this.buttonback.Size = new System.Drawing.Size(75, 23);
            this.buttonback.TabIndex = 16;
            this.buttonback.Text = "quay lai";
            this.buttonback.UseVisualStyleBackColor = true;
            this.buttonback.Click += new System.EventHandler(this.buttonback_Click);
            // 
            // formQlncc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 569);
            this.Controls.Add(this.buttonback);
            this.Controls.Add(this.btnnhapfile);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtsdt);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttenncc);
            this.Controls.Add(this.txtmancc);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "formQlncc";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmancc;
        private System.Windows.Forms.TextBox txttenncc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnnhapfile;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button buttonback;
    }
}

