using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_ly_sinh_vien
{
    public partial class frmsinhvienreport : Form
    {
        public frmsinhvienreport()
        {
            InitializeComponent();
        }

        private void frmsinhvienreport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.sinhvienreport' table. You can move, or remove it, as needed.
            this.sinhvienreportTableAdapter.Fill(this.dataSet1.sinhvienreport);
            // TODO: This line of code loads data into the 'dataSet1.sinhvien_lop' table. You can move, or remove it, as needed.
            this.sinhvien_lopTableAdapter.Fill(this.dataSet1.sinhvien_lop);

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
        }
    }
}
