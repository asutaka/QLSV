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

namespace Quan_ly_sinh_vien
{
    public partial class frmLogin : Form
    {
        private DataTable dt = new DataTable("tblStudent");
        private SqlDataAdapter da = new SqlDataAdapter();
        SqlConnection con = new SqlConnection(@"Data Source=KIEN-PC\SQLEXPRESS;Initial Catalog=QuanLySinhVien;Integrated Security=True");
        //private Boolean kt;
        private void connect()
        {

            //string cn = "Data Source=KIEN-PC\SQLEXPRESS;Initial Catalog=QuanLySinhVien;Integrated Security=True";
            try
            {
                con.Open();     //Mo ket noi
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể kết nối tới cơ sở dữ liệu !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void disconnect()
        {
            con.Close();    //Dong ket noi
            con.Dispose();  //Giai phong tai nguyen
            con = null;     //Huy doi tuong
        }
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            connect();
            txtName.Text = "admin";
            this.AcceptButton = btnDangnhap;
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = con;
            command.CommandType = CommandType.Text;
            command.CommandText = @"Select * from tblUser
                                            where (fldName = @fldName)
                                            And (fldPass = @fldPass)";
            command.Parameters.Add("@fldName", SqlDbType.NVarChar, 50).Value = txtName.Text;
            command.Parameters.Add("@fldPass", SqlDbType.NVarChar, 50).Value = txtPass.Text;
            da.SelectCommand = command;
            da.Fill(dt);
            if(dt.Rows.Count >0)
            {
                frmTrangChinh _frmTrangChinh = new frmTrangChinh();
                _frmTrangChinh.Show();
                Hide();
            }
            else
            {
               if( MessageBox.Show("Đang nhập thất bại! Bạn có muốn đăng nhập lại không ?", "Đang nhập", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    txtName.Focus();
                }
               else
                {
                    Close();
                    System.Windows.Forms.Application.Exit();
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
            //if (MessageBox.Show("Đang nhập thất bại! Bạn có muốn đăng nhập lại không ?", "Đang nhập", MessageBoxButtons.YesNo) == DialogResult.No)
            //{
            //    Close();
            //    System.Windows.Forms.Application.Exit();
            //}
        }
    }
}
