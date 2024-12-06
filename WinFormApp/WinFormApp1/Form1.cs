namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //cleart text for label result when startup form
            lblResult.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //get values from 2 numeric up down 
            int x = (int)numX.Value;
            int y = (int)numY.Value;

            ///calculate result
            int result = x + y;

            //show result value to label result
            lblResult.Text = result.ToString();
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            //get values from 2 numeric up down 
            int x = (int)numX.Value;
            int y = (int)numY.Value;

            ///calculate result
            int result = x - y;

            //show result value to label result
            lblResult.Text = result.ToString();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            //get values from 2 numeric up down 
            int x = (int)numX.Value;
            int y = (int)numY.Value;

            ///calculate result
            int result = x * y;

            //show result value to label result
            lblResult.Text = result.ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            //set initial value for result 
            int result = 0;

            //get values from 2 numeric up down 
            int x = (int)numX.Value;
            int y = (int)numY.Value;

            //calculate result
            //validate value "y" is equal to zero or not
            if (y == 0)
                MessageBox.Show("Y must be different from 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
               result = x / y;

            //show result value to label result
            lblResult.Text = result.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //reset value to 0 for numeric up down
            numX.Value = 0;
            numY.Value = 0;
            //reset value to empty for label
            lblResult.Text = "";
        }
    }
}
