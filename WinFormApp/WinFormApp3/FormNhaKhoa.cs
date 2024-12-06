using System.DirectoryServices.ActiveDirectory;

namespace WinFormApp3
{
    public partial class FormNhaKhoa : Form
    {
        public FormNhaKhoa()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            //1. khai báo biến total để lưu tổng tiền 
            int total = 0;  //default value: 0

            //2. lấy input value từ form + cộng dồn tiền vào biến "total"
            string name = txtKhachHang.Text;

            if (cbMenRang.Checked)
                total += 200000;    //total = total + 200000;
            if (cbTayRang.Checked)
                total += 500000;

            if (rdTramRang.Checked)
                total += 1000000;
            else if (rdNhoRang.Checked)
                total += 100000;

            //3. show kết quả
            txtTongTien.Text = total.ToString() + " đồng";
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            //reset tên khách hàng
            txtKhachHang.Text = "";

            //reset tổng tiền
            txtTongTien.Text = "";

            //reset checkbox  
            cbMenRang.Checked = false;
            cbTayRang.Checked = false;

            //reset radio button
            rdNhoRang.Checked = false;
            rdTramRang.Checked = false;
        }
    }
}
