using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLySinhVien
{
    public partial class frmTrangChinh : Form
    {
        public frmTrangChinh()
        {
            InitializeComponent();
        }

        private void frmTrangChinh_Load(object sender, EventArgs e)
        {

        }

        private void btnSinhvien_Click(object sender, EventArgs e)
        {
            frmSinhVien _frmSinhVien = new frmSinhVien();
            _frmSinhVien.Show();
        }

        private void sinhViToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSinhVien _frmSinhVien = new frmSinhVien();
            _frmSinhVien.Show();
        }

        private void btnLop_Click(object sender, EventArgs e)
        {
            frmClass _frmClass = new frmClass();
            _frmClass.Show();
        }

        private void lớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClass _frmClass = new frmClass();
            _frmClass.Show();
        }

        private void btnDetai_Click(object sender, EventArgs e)
        {
            frmProject _frmProject = new frmProject();
            _frmProject.Show();
        }

        private void đềTàiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProject _frmProject = new frmProject();
            _frmProject.Show();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát không ?", "THOÁT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
                System.Windows.Forms.Application.Exit();
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát không ?", "THOÁT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
                System.Windows.Forms.Application.Exit();
            }
        }

        private void btnchondetai_Click(object sender, EventArgs e)
        {

        }

        private void btnxeplop_Click(object sender, EventArgs e)
        {
            frmXepLop _frmXepLop = new frmXepLop();
            _frmXepLop.Show();
        }

        private void btnbaocao_Click(object sender, EventArgs e)
        {
            frmSinhVienReport _frmSinhVienReport = new frmSinhVienReport();
            _frmSinhVienReport.Show();
        }
    }
}
