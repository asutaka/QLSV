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
    public partial class frmThemMoi : Form
    {
        private DataTable dt = new DataTable("tblStudent");
        private DataTable dtClass = new DataTable("tblClass");
        private SqlDataAdapter da = new SqlDataAdapter();
        SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=QuanLySinhVien;Integrated Security=True");
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
        private void getdata()
        {
            SqlCommand command = new SqlCommand();  //Khia bao 1 command
            command.Connection = con;   //ket noi
            command.CommandType = CommandType.Text;
            command.CommandText = @"Select * from tblStudent";
            da.SelectCommand = command; //Gan command cho da
            da.Fill(dt);    //Nap du lieu cho table

            command.CommandText = "Select * from tblClass";
            da.SelectCommand = command;
            da.Fill(dtClass);
            cbolop.DataSource = dtClass;
            cbolop.DisplayMember = "fldClassName";
            cbolop.ValueMember = "fldID";
            //cbolop.SelectedValue = "fldID";
        }
        public frmThemMoi()
        {
            InitializeComponent();
        }

        private void frmThemMoi_Load(object sender, EventArgs e)
        {
            connect();
            getdata();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
            disconnect();
            frmSinhVien _frmSinhVien = new frmSinhVien();
            _frmSinhVien.Show();
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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            kiemtra();
            if (kt == true)
            {
                DataRow row = dt.NewRow();
                row["fldFirstName"] = txthosv.Text;
                row["fldLastName"] = txttensv.Text;
                row["fldAge"] = txttuoi.Text;
                if (cbogioitinh.Text == "Nam")
                    row["fldSex"] = 1;
                else if (cbogioitinh.Text == "Nữ")
                    row["fldSex"] = 0;
                row["fldCreatedDate"] = dtngay.Value;
                row["fldClassID"] = cbolop.SelectedValue;
                dt.Rows.Add(row);
                SqlCommand commandInsert = new SqlCommand();
                commandInsert.Connection = con;
                commandInsert.CommandType = CommandType.Text;
                commandInsert.CommandText = @"Insert tblStudent (fldFirstName, fldLastName, fldAge, fldSex, fldCreatedDate, fldClassID)
                                                Values (@fldFirstName, @fldLastName, @fldAge, @fldSex, @fldCreatedDate, @fldClassID)";
                commandInsert.Parameters.Add("fldFirstName", SqlDbType.NVarChar, 50, "fldFirstName");
                commandInsert.Parameters.Add("fldLastName", SqlDbType.NVarChar, 50, "fldLastName");
                commandInsert.Parameters.Add("fldAge", SqlDbType.Int, 50, "fldAge");
                commandInsert.Parameters.Add("fldSex", SqlDbType.Int, 50, "fldSex");
                commandInsert.Parameters.Add("fldCreatedDate", SqlDbType.DateTime, 50, "fldCreatedDate");
                commandInsert.Parameters.Add("fldClassID", SqlDbType.Int, 50, "fldClassID");
                da.InsertCommand = commandInsert;
                da.Update(dt);
                MessageBox.Show("Bạn đã thêm thành công !", "THÔNG BÁO", MessageBoxButtons.OK);
                Close();
                disconnect();
                Dispose();
                frmSinhVien _frmSinhVien = new frmSinhVien();
                _frmSinhVien.Show();
            }
        }
    }
}
