using WinFormApp3;

namespace WinForm3
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //1. get input
            string name = tbFullName.Text;

            string gender = "";
            if (rbMale.Checked)
                gender = "Male";
            else if (rbFemale.Checked)
                gender = "Female";

            string birthplace = cmbBirthplace.Text;

            string birthday = dtpBirthday.Value.ToString("dd/MM/yyyy");

            string graduate = "";
            if (cbGraduated.Checked)
                graduate = "Yes";
            else
                graduate = "No";

            //2. show output
            if (name != "" && gender != "" && birthplace != "" && birthday != "" && graduate != "")
            {
                tbFullName_Output.Text = name;
                tbGender_Output.Text = gender;
                tbBirthplace_Output.Text = birthplace;
                tbBirthday_Output.Text = birthday;
                tbGraduated_Output.Text = graduate;
            }
            else
            {
                MessageBox.Show("You must input all information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            //1. hide Admin Form 
            this.Hide();

            //2. show success message
            MessageBox.Show("Logout succeed !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);   

            //3. show Login Form again
            LoginForm loginForm = new LoginForm();
            loginForm.Show();

        }
    }
}
