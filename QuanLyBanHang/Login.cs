using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
namespace QuanLyBanHang
{
    public partial class Login : Form
    {
        EntityNhanVien entityNV = new EntityNhanVien();
        public Login()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(txtTK.Text!="" && txtMK.Text != "")
            {
                if (entityNV.checkTaiKhoanLogin(txtTK.Text , txtMK.Text))
                {
                    NHAN_VIEN nv = entityNV.returnNhanVien(txtTK.Text, txtMK.Text);

                    /*Chức vụ [ 
                            0 : nhân viên bán;
                            1 : kế toán; 
                            2 : Quản lý cửa hàng 
                        ]
                        => Chỉ có kế toán và quản lý được đăng nhập vào Quản Lý Bán Hàng 
                     */

                    if (nv.CHUC_VU == 0)
                    {
                        MessageBox.Show("Bạn không có quyền đăng nhập !!!");
                    }
                    else
                    {
                        frmIndex frm = new frmIndex(nv);
                        this.Hide();
                        frm.ShowDialog();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng !!!\n Vui lòng kiểm tra lại");
                }
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không được để trống !!!");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            
        }
    }
}
