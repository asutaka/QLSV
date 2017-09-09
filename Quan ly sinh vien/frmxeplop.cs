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
    public partial class frmxeplop : Form
    {
        private DataTable dt = new DataTable("tblStudent");
        private DataTable dtClass = new DataTable("tblClass");
        private SqlDataAdapter da = new SqlDataAdapter();
        SqlConnection con = new SqlConnection(@"Data Source=KIEN-PC\SQLEXPRESS;Initial Catalog=QuanLySinhVien;Integrated Security=True");
        private Boolean kt;
        private void connect()
        {
            //
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

        private void getdata()
        {
            SqlCommand command = new SqlCommand();  //Khai bao 1 command
            command.Connection = con;   //ket noi
            command.CommandType = CommandType.Text;
            command.CommandText = @"Select 
                                        tblStudent.fldID as N'MaSV',
                                        (fldFirstName + ' ' + fldLastName ) as N'HoTenSV',
                                        fldAge as N'Tuoi',
                                        (Case fldSex when 'True' then N'Nam' else N'Nữ' end) as N'GioiTinh',
                                        fldCreatedDate as N'CreatedDate',
                                        isNull(fldClassName, 'Chưa học') as N'Tenlop',
                                        fldClassID as N'ClassID'
                                    from tblStudent
                                        left outer join tblClass
                                        on tblStudent.fldClassID = tblClass.fldID";  //Viet cau sql   
            da.SelectCommand = command; //Gan command cho da
            da.Fill(dt);    //Nap du lieu cho table
            grvxeplop.DataSource = dt;    //Load du lieu len DataGridview

            cboHoTenSV.DataSource = dt;
            cboHoTenSV.DisplayMember = "HoTenSV";
            cboHoTenSV.ValueMember = "MaSV";

            command.CommandText = "Select *from tblClass";
            da.SelectCommand = command;
            da.Fill(dtClass);
            cboChonlop.DataSource = dtClass;
            cboChonlop.DisplayMember = "fldClassName";
            cboChonlop.ValueMember = "fldID";
        }
        public frmxeplop()
        {
            InitializeComponent();
        }
        private void frmxeplop_Load(object sender, EventArgs e)
        {
            connect();
            getdata();
            cboChonlop.DataBindings.Add("Text", grvxeplop.DataSource, "TenLop");
        }
        private bool kiemtra()
        {
            kt = true;
            if (cboHoTenSV.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập họ của SV !", "THÔNG BÁO", MessageBoxButtons.OK);
                kt = false;
            }
            else if (cboHoTenSV.Text == null)
            {
                MessageBox.Show("Bạn chưa có ngày tháng !", "THÔNG BÁO", MessageBoxButtons.OK);
                kt = false;
            }
            return kt;
        }
        private void button1_Click(object sender, EventArgs e)  // Nút xếp lớp
        {
            kiemtra();
            if (kt == true)
            {
                DataRow row = dt.Select("MaSV = " + Convert.ToInt32(cboHoTenSV.SelectedValue))[0];
                row.BeginEdit();
                row["Tenlop"] = cboChonlop.SelectedValue;
                row.EndEdit();
                SqlCommand commandUpdate = new SqlCommand();
                commandUpdate.Connection = con;
                commandUpdate.CommandType = CommandType.Text;
                commandUpdate.CommandText = @"Update tblStudent Set fldClassID = @fldClassID
                                                            where fldID = @fldID";
                commandUpdate.Parameters.Add("@fldID", SqlDbType.Int, 50, "MaSV");
                commandUpdate.Parameters.Add("@fldClassName", SqlDbType.Int, 50, "Tenlop");
                commandUpdate.Parameters.Add("@fldClassID", SqlDbType.Int, 50, "ClassID");
                da.UpdateCommand = commandUpdate;
                da.Update(dt);
                MessageBox.Show("Bạn đã xếp lớp thành công !", "THÔNG BÁO", MessageBoxButtons.OK);
            }
        }
        private void button2_Click(object sender, EventArgs e)  //Nút thoát
        {
            Close();
            Dispose();
            disconnect();
        }
    }
}
