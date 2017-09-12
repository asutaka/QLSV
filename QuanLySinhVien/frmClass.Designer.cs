namespace QuanLySinhVien
{
    partial class frmClass
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
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsiso = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcahoc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txttenlop = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grvClass = new System.Windows.Forms.DataGridView();
            this.txtmalop = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnthem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grvClass)).BeginInit();
            this.SuspendLayout();
            // 
            // btnthoat
            // 
            this.btnthoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnthoat.Location = new System.Drawing.Point(465, 352);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(91, 32);
            this.btnthoat.TabIndex = 27;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnxoa.Location = new System.Drawing.Point(319, 352);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(91, 32);
            this.btnxoa.TabIndex = 26;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            // 
            // btnsua
            // 
            this.btnsua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnsua.Location = new System.Drawing.Point(175, 352);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(91, 32);
            this.btnsua.TabIndex = 25;
            this.btnsua.Text = "Sửa ";
            this.btnsua.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(590, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 19);
            this.label5.TabIndex = 24;
            this.label5.Text = "Sĩ số";
            // 
            // txtsiso
            // 
            this.txtsiso.Location = new System.Drawing.Point(665, 233);
            this.txtsiso.Name = "txtsiso";
            this.txtsiso.Size = new System.Drawing.Size(125, 20);
            this.txtsiso.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(590, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 19);
            this.label4.TabIndex = 22;
            this.label4.Text = "Ca học";
            // 
            // txtcahoc
            // 
            this.txtcahoc.Location = new System.Drawing.Point(665, 194);
            this.txtcahoc.Name = "txtcahoc";
            this.txtcahoc.Size = new System.Drawing.Size(125, 20);
            this.txtcahoc.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(590, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 19);
            this.label3.TabIndex = 20;
            this.label3.Text = "Tên lớp";
            // 
            // txttenlop
            // 
            this.txttenlop.Location = new System.Drawing.Point(665, 157);
            this.txttenlop.Name = "txttenlop";
            this.txttenlop.Size = new System.Drawing.Size(125, 20);
            this.txttenlop.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(590, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Mã lớp";
            // 
            // grvClass
            // 
            this.grvClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvClass.Location = new System.Drawing.Point(7, 105);
            this.grvClass.Name = "grvClass";
            this.grvClass.Size = new System.Drawing.Size(577, 212);
            this.grvClass.TabIndex = 17;
            // 
            // txtmalop
            // 
            this.txtmalop.Location = new System.Drawing.Point(665, 120);
            this.txtmalop.Name = "txtmalop";
            this.txtmalop.Size = new System.Drawing.Size(125, 20);
            this.txtmalop.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(342, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Danh sách lớp học";
            // 
            // btnthem
            // 
            this.btnthem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnthem.Location = new System.Drawing.Point(40, 352);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(91, 32);
            this.btnthem.TabIndex = 14;
            this.btnthem.Text = "Thêm mới";
            this.btnthem.UseVisualStyleBackColor = true;
            // 
            // frmClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 444);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtsiso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtcahoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txttenlop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grvClass);
            this.Controls.Add(this.txtmalop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnthem);
            this.Name = "frmClass";
            this.Text = "frmClass";
            this.Load += new System.EventHandler(this.frmClass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvClass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsiso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcahoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttenlop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grvClass;
        private System.Windows.Forms.TextBox txtmalop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnthem;
    }
}