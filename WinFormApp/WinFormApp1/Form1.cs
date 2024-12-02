namespace WinFormApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //intialize form
            InitializeComponent();

            //show welcome message
            MessageBox.Show("Welcome to my Winform app !");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                //set web link
                string link = "https://greenwich.edu.vn/en/english/";

                //open website
                System.Diagnostics.Process.Start(link);
            }
            catch (Exception ex)
            {
                //show popup error
                MessageBox.Show("Link can not be opened !");
            }

        }

        private void linkLabel1_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Greenwich Vietnam is an international alliance between the University of Greenwich, United Kingdom, and FPT University, Vietnam. Established in 2009, it has had a global network of thousands of students and alumni from many countries in the world.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Start the program !");
        }
    }
}
