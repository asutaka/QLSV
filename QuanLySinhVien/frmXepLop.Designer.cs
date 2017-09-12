namespace QuanLySinhVien
{
    partial class frmXepLop
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
            this.cboChonlop = new System.Windows.Forms.ComboBox();
            this.btnthoat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboHoTenSV = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grvxeplop = new System.Windows.Forms.DataGridView();
            this.btnxeplop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grvxeplop)).BeginInit();
            this.SuspendLayout();
            // 
            // cboChonlop
            // 
            this.cboChonlop.FormattingEnabled = true;
            this.cboChonlop.Location = new System.Drawing.Point(94, 177);
            this.cboChonlop.Name = "cboChonlop";
            this.cboChonlop.Size = new System.Drawing.Size(121, 21);
            this.cboChonlop.TabIndex = 16;
            // 
            // btnthoat
            // 
            this.btnthoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnthoat.Location = new System.Drawing.Point(140, 254);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(84, 35);
            this.btnthoat.TabIndex = 15;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(13, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Chọn lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(13, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Họ tên SV";
            // 
            // cboHoTenSV
            // 
            this.cboHoTenSV.FormattingEnabled = true;
            this.cboHoTenSV.Location = new System.Drawing.Point(94, 136);
            this.cboHoTenSV.Name = "cboHoTenSV";
            this.cboHoTenSV.Size = new System.Drawing.Size(121, 21);
            this.cboHoTenSV.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(309, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Xếp lớp cho sinh viên";
            // 
            // grvxeplop
            // 
            this.grvxeplop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvxeplop.Location = new System.Drawing.Point(247, 77);
            this.grvxeplop.Name = "grvxeplop";
            this.grvxeplop.Size = new System.Drawing.Size(503, 264);
            this.grvxeplop.TabIndex = 10;
            // 
            // btnxeplop
            // 
            this.btnxeplop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnxeplop.Location = new System.Drawing.Point(37, 254);
            this.btnxeplop.Name = "btnxeplop";
            this.btnxeplop.Size = new System.Drawing.Size(84, 35);
            this.btnxeplop.TabIndex = 9;
            this.btnxeplop.Text = "Xếp lớp";
            this.btnxeplop.UseVisualStyleBackColor = true;
            this.btnxeplop.Click += new System.EventHandler(this.btnxeplop_Click);
            // 
            // frmXepLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 390);
            this.Controls.Add(this.cboChonlop);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboHoTenSV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grvxeplop);
            this.Controls.Add(this.btnxeplop);
            this.Name = "frmXepLop";
            this.Text = "frmXepLop";
            this.Load += new System.EventHandler(this.frmXepLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvxeplop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboChonlop;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboHoTenSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grvxeplop;
        private System.Windows.Forms.Button btnxeplop;
    }
}