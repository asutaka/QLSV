﻿namespace QuanLySinhVien
{
    partial class frmSinhVienReport
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSet1 = new QuanLySinhVien.Dataset.DataSet1();
            this.sinhvienlopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinhvien_lopTableAdapter = new QuanLySinhVien.Dataset.DataSet1TableAdapters.sinhvien_lopTableAdapter();
            this.sinhvienreportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinhvienreportBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sinhvienreportTableAdapter = new QuanLySinhVien.Dataset.DataSet1TableAdapters.sinhvienreportTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhvienlopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhvienreportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhvienreportBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-2, 34);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(924, 492);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.reportViewer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(916, 466);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Danh sách sinh viên";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.reportViewer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(916, 466);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tình hình tuyển sinh";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.sinhvienlopBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLySinhVien.Report.DanhSachSinhVien.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 40);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(916, 426);
            this.reportViewer1.TabIndex = 0;
            // 
            // reportViewer2
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.sinhvienreportBindingSource1;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "QuanLySinhVien.Report.SinhVienReport.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 24);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(916, 442);
            this.reportViewer2.TabIndex = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sinhvienlopBindingSource
            // 
            this.sinhvienlopBindingSource.DataMember = "sinhvien_lop";
            this.sinhvienlopBindingSource.DataSource = this.dataSet1;
            // 
            // sinhvien_lopTableAdapter
            // 
            this.sinhvien_lopTableAdapter.ClearBeforeFill = true;
            // 
            // sinhvienreportBindingSource
            // 
            this.sinhvienreportBindingSource.DataMember = "sinhvienreport";
            this.sinhvienreportBindingSource.DataSource = this.dataSet1;
            // 
            // sinhvienreportBindingSource1
            // 
            this.sinhvienreportBindingSource1.DataMember = "sinhvienreport";
            this.sinhvienreportBindingSource1.DataSource = this.dataSet1;
            // 
            // sinhvienreportTableAdapter
            // 
            this.sinhvienreportTableAdapter.ClearBeforeFill = true;
            // 
            // frmSinhVienReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 526);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmSinhVienReport";
            this.Text = "frmSinhVienReport";
            this.Load += new System.EventHandler(this.frmSinhVienReport_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhvienlopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhvienreportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhvienreportBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.TabPage tabPage2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private Dataset.DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource sinhvienlopBindingSource;
        private Dataset.DataSet1TableAdapters.sinhvien_lopTableAdapter sinhvien_lopTableAdapter;
        private System.Windows.Forms.BindingSource sinhvienreportBindingSource;
        private System.Windows.Forms.BindingSource sinhvienreportBindingSource1;
        private Dataset.DataSet1TableAdapters.sinhvienreportTableAdapter sinhvienreportTableAdapter;
    }
}