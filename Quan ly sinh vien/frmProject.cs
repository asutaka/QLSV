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
    public partial class frmProject : Form
    {
        private DataTable dtClass = new DataTable("tblProject");
        private SqlDataAdapter da = new SqlDataAdapter();
        SqlConnection con = new SqlConnection(@"Data Source=KIEN-PC\SQLEXPRESS;Initial Catalog=QuanLySinhVien;Integrated Security=True");
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
        public frmProject()
        {
            InitializeComponent();
        }

        private void frmProject_Load(object sender, EventArgs e)
        {
            connect();
            getdata();
            binding();
            disconnect();
        }
        private void getdata()
        {
            SqlCommand command = new SqlCommand();  //Khia bao 1 command
            command.Connection = con;   //ket noi
            command.CommandType = CommandType.Text;
            command.CommandText = @"Select 
                                        fldID as N'MaDeTai',
                                        fldName as N'TenDeTai',
                                        fdlDescription as N'DienGiai'
                                    from tblProject";  //Viet cau sql   
            da.SelectCommand = command; //Gan command cho da
            da.Fill(dtClass);    //Nap du lieu cho table
            grvProject.DataSource = dtClass;    //Load du lieu len DataGridview
        }
        private void binding()
        {
            txtmadetai.DataBindings.Clear();
            txtmadetai.DataBindings.Add("Text", grvProject.DataSource, "MaDeTai");
            txttendetai.DataBindings.Clear();
            txttendetai.DataBindings.Add("Text", grvProject.DataSource, "TenDeTai");
            txtdiengiai.DataBindings.Clear();
            txtdiengiai.DataBindings.Add("Text", grvProject.DataSource, "DienGiai");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }
    }
}
