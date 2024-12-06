using QuanLyNhanVien;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class formQuanLy : Form
    {

        public formQuanLy()
        {
            InitializeComponent();

            //xóa output thông tin nhân viên khi chạy chương trình
            xoaOutput();

            //add initial data của nhân viên vào list box
            List<NhanVien> danhSachNhanVien = new List<NhanVien>
            {
                new NhanVien { HoTen = "Nguyen Van A", Tuoi = 25, DiaChi = "Hanoi", Phong = "Quản lý đào tạo", ChucVu = "Trưởng phòng" },
                new NhanVien { HoTen = "Tran Thi B", Tuoi = 28, DiaChi = "Ho Chi Minh City", Phong = "Quản lý khoa học", ChucVu = "Phó phòng" },
                new NhanVien { HoTen = "Le Quang C", Tuoi = 30, DiaChi = "Da Nang", Phong = "Công tác sinh viên", ChucVu = "Giám đốc" },
                new NhanVien { HoTen = "Pham Thi D", Tuoi = 22, DiaChi = "Can Tho", Phong = "Quan hệ doanh nghiệp", ChucVu = "Phó giám đốc" },
                new NhanVien { HoTen = "Bui Thi E", Tuoi = 35, DiaChi = "Hue", Phong = "Quản lý đào tạo", ChucVu = "Viện trưởng" },
                new NhanVien { HoTen = "Nguyen Thi F", Tuoi = 27, DiaChi = "Hai Phong", Phong = "Quản lý khoa học", ChucVu = "Viện phó" },
                new NhanVien { HoTen = "Tran Quang G", Tuoi = 26, DiaChi = "Vinh", Phong = "Công tác sinh viên", ChucVu = "Trưởng khoa" },
                new NhanVien { HoTen = "Le Thi H", Tuoi = 24, DiaChi = "Nha Trang", Phong = "Quan hệ doanh nghiệp", ChucVu = "Phó khoa" },
                new NhanVien { HoTen = "Pham Quang I", Tuoi = 32, DiaChi = "Quy Nhon", Phong = "Quản lý đào tạo", ChucVu = "Giám đốc" },
                new NhanVien { HoTen = "Bui Quang J", Tuoi = 29, DiaChi = "Hai Duong", Phong = "Quản lý khoa học", ChucVu = "Phó phòng" }
            };

            foreach (NhanVien nhanVien in danhSachNhanVien)
            {
                // You can customize the display format as needed
                lbNhanVien.Items.Add(nhanVien);
            }
        }

        //Procedural programming
        public void xoaOutput()
        {
            lblHoTen.Text = "";
            lblTuoi.Text = "";
            lblDiaChi.Text = "";
            lblPhong.Text = "";
            lblChucVu.Text = "";
        }

        public void xoaInput()
        {
            //reset tên + địa chỉ về rỗng
            txtHoTen.Text = "";
            txtDiaChi.Text = "";

            //reset tuổi về value mặc định (18)
            nudTuoi.Value = 18;

            //reset phòng + chức vụ về empty value (non selected)
            cbbPhong.SelectedIndex = -1;
            cbbChucVu.SelectedIndex = -1;
        }

        private void btnXoaForm_Click(object sender, EventArgs e)
        {
            xoaInput();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //1. lấy thông tin từ form
            //lấy input của họ tên & địa chỉ
            string hoTen = txtHoTen.Text;
            string diaChi = txtDiaChi.Text;
            //lấy input của tuổi
            int tuoi = (int)nudTuoi.Value;
            //lấy input của phòng và chức vụ
            string phong = cbbPhong.Text;
            string chucVu = cbbChucVu.Text;

            //2. tạo đối tượng staff theo thông tin từ form
            if (hoTen != "" && diaChi != "" && phong != "" && chucVu != "")
            {
                NhanVien nhanVien = new NhanVien(hoTen, tuoi, diaChi, phong, chucVu);

                //3. đẩy đối tượng staff vào list box
                lbNhanVien.Items.Add(nhanVien);
            } 
            else  //hiển thị lỗi nếu người dùng không nhập đầy đủ thông tin
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void lbNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            //1. lấy index của item nhân viên trong list box
            int index = lbNhanVien.SelectedIndex;

            //2. validate xem index có hợp lệ không
            if (index != -1) { 
                //3. gọi object nhân viên tương ứng với index
                NhanVien nhanVien = (NhanVien)lbNhanVien.Items[index];

                //4. show thông tin của nhân viên lên groupbox "Thông tin chi tiết"
                lblHoTen.Text = nhanVien.HoTen;
                lblTuoi.Text = nhanVien.Tuoi.ToString();
                lblDiaChi.Text = nhanVien.DiaChi;
                lblPhong.Text = nhanVien.Phong;
                lblChucVu.Text = nhanVien.ChucVu;
            }    
        }

        private void btnXoaNhanVien_Click(object sender, EventArgs e)
        {
            //1. lấy index của item nhân viên trong list box
            int index = lbNhanVien.SelectedIndex;

            //2. validate xem index có hợp lệ không
            if (index != -1)
            {
                //3. xóa nhân viên theo index
                lbNhanVien.Items.RemoveAt(index);

                //4. xóa thông tin hiển thị chi tiết
                xoaOutput();

                //5. hiển thị message sau khi xóa
                MessageBox.Show("Xóa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        } 
    }
}
