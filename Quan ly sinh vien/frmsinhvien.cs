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
    public partial class frmsinhvien : Form
    { 
        //private SqlConnection con;
        private DataTable dt = new DataTable("tblStudent");
        private SqlDataAdapter da = new SqlDataAdapter();
        SqlConnection con = new SqlConnection(@"Data Source=KIEN-PC\SQLEXPRESS;Initial Catalog=QuanLySinhVien;Integrated Security=True");
        private Boolean kt;
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
        public frmsinhvien()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            connect();
            getdata();
            binding();
        }
        private void getdata()
        {
            SqlCommand command = new SqlCommand();  //Khai bao 1 command
            command.Connection = con;   //ket noi
            command.CommandType = CommandType.Text;
            command.CommandText = @"Select 
                                        tblStudent.fldID as N'MaSV',
                                        fldFirstName as N'HoSV',
                                        fldLastName as N'TenSV',
                                        fldAge as N'Tuoi',
                                        (Case fldSex when 'True' then N'Nam' else N'Nữ' end) as N'GioiTinh',
                                        fldCreatedDate as N'CreatedDate',
                                        isNull(fldClassName, 'Chưa học') as N'Tenlop'
                                    from tblStudent
                                        left outer join tblClass
                                        on tblStudent.fldClassID = tblClass.fldID";  //Viet cau sql   
            da.SelectCommand = command; //Gan command cho da
            da.Fill(dt);    //Nap du lieu cho table
            grvdata.DataSource = dt;    //Load du lieu len DataGridview
        }
        private void binding()
        {
            txtmasv.DataBindings.Clear();
            txtmasv.DataBindings.Add("Text", grvdata.DataSource, "MaSV");
            txthosv.DataBindings.Clear();
            txthosv.DataBindings.Add("Text", grvdata.DataSource, "HoSV");
            txttensv.DataBindings.Clear();
            txttensv.DataBindings.Add("Text", grvdata.DataSource, "TenSV");
            txttuoi.DataBindings.Clear();
            txttuoi.DataBindings.Add("Text", grvdata.DataSource, "Tuoi");
            cboGioitinh.DataBindings.Clear();
            cboGioitinh.DataBindings.Add("Text", grvdata.DataSource, "GioiTinh");
            dtngay.DataBindings.Clear();
            dtngay.DataBindings.Add("Text", grvdata.DataSource, "CreatedDate");
            cbolop.DataBindings.Clear();
            cbolop.DataBindings.Add("Text", grvdata.DataSource, "Tenlop");
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }

        private void btnthemmoi_Click(object sender, EventArgs e)
        {
            frmThemMoi _frmThemMoi = new frmThemMoi();
            _frmThemMoi.Show();
            Hide();
        }
        private bool kiemtra()
        {
            kt = true;
            if (txthosv.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập họ của SV !", "THÔNG BÁO", MessageBoxButtons.OK);
                kt = false;
            }
            else if (dtngay.Value == null)
            {
                MessageBox.Show("Bạn chưa có ngày tháng !", "THÔNG BÁO", MessageBoxButtons.OK);
                kt = false;
            }
            return kt;
        }
        private void btnsua_Click(object sender, EventArgs e)
        {
            if (txtmasv.Text.Length > 0)
            {
                kiemtra();
                if (kt == true)
                {
                    DataRow row = dt.Select("MaSV = " + Convert.ToInt32(txtmasv.Text))[0];
                    row.BeginEdit();
                    row["HoSV"] = txthosv.Text;
                    row["TenSV"] = txttensv.Text;
                    row["Tuoi"] = txttuoi.Text;
                    if (cboGioitinh.Text == "Nam")
                        row["GioiTinh"] = 1;
                    else if (cboGioitinh.Text == "Nam")
                        row["GioiTinh"] = 0;
                    row["CreatedDate"] = dtngay.Value;
                    row["Tenlop"] = cbolop.SelectedValue;
                    row.EndEdit();
                    SqlCommand commandUpdate = new SqlCommand();
                    commandUpdate.Connection = con;
                    commandUpdate.CommandType = CommandType.Text;
                    commandUpdate.CommandText = @"Update tblStudent Set fldFirstName = @fldFirstName,
                                                                fldLastName = @fldLastName,
                                                                fldAge = @fldAge, fldSex = @fldSex,
                                                                fldCreatedDate = @fldCreatedDate,
                                                                fldClassID = @fldClassID
                                                            where fldID = @fldID";
                    commandUpdate.Parameters.Add("@fldID", SqlDbType.Int, 50, "MaSV");
                    commandUpdate.Parameters.Add("@fldFirstName", SqlDbType.NVarChar, 50, "HoSV");
                    commandUpdate.Parameters.Add("@fldLastName", SqlDbType.NVarChar, 50, "TenSV");
                    commandUpdate.Parameters.Add("@fldAge", SqlDbType.Int, 50, "Tuoi");
                    commandUpdate.Parameters.Add("@fldSex", SqlDbType.Int, 50, "GioiTinh");
                    commandUpdate.Parameters.Add("@fldCreatedDate", SqlDbType.DateTime, 50, "CreatedDate");
                    commandUpdate.Parameters.Add("@fldClassID", SqlDbType.Int, 50, "ClassID");
                    da.UpdateCommand = commandUpdate;
                    da.Update(dt);
                    MessageBox.Show("Bạn đã sửa thành công !", "THÔNG BÁO", MessageBoxButtons.OK);
                }
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (txtmasv.Text.Length > 0)
            {
                kiemtra();
                if (kt == true)
                {
                    DataRow row = dt.Select("MaSV = " + Convert.ToInt32(txtmasv.Text))[0];
                    row.BeginEdit();
                    row.Delete();
                    row.EndEdit();
                    SqlCommand commandDelete = new SqlCommand();
                    commandDelete.Connection = con;
                    commandDelete.CommandType = CommandType.Text;
                    commandDelete.CommandText = "Delete from tblStudent Where fldID = @fldID";
                    commandDelete.Parameters.Add("@fldID", SqlDbType.Int, 50, "MaSV");
                    da.DeleteCommand = commandDelete;
                    da.Update(dt);
                    MessageBox.Show("Bạn đã xóa thành công !", "THÔNG BÁO", MessageBoxButtons.OK);
                }
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            dt.Clear();
            SqlCommand command = new SqlCommand();
            command.Connection = con;
            command.CommandType = CommandType.Text;
            command.CommandText = @"Select 
                                        tblStudent.fldID as N'MaSV',
                                        fldFirstName as N'HoSV',
                                        fldLastName as N'TenSV',
                                        fldAge as N'Tuoi',
                                        (Case fldSex when 'True' then N'Nam' when 'False' then 'Nữ'
                                        else N'Chưa xác định' end) as N'GioiTinh',
                                        fldCreatedDate as N'fldCreatedDate',
                                        IsNULL(fldClassName, N'Chưa học') as N'TenLop',
                                        fldClassID as N'fldClassID'
                                    from tblStudent
                                        left outer join tblClass
                                        on tblStudent.fldClassID = tblClass.fldID
                                    where fldLastName LIKE '%'+@TenSV+'%'";
            command.Parameters.Add("@TenSV", SqlDbType.NVarChar, 50).Value = txtTensvtim.Text;
            da.SelectCommand = command;
            da.Fill(dt);
            if(dt.Rows.Count >0)
            {
                grvdata.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Không tìm thấy dữ liệu phù hợp !", "THÔNG BÁO", MessageBoxButtons.OK);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtTensvtim.Text = "";
            cbogioitinhtim.Text = "";
            dt.Clear();
            getdata(); 
        }
    }
}
