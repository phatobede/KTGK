namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if(txtusername.Text == "admin" && txtpassword.Text == "admin")
            {
                Form2 khanh = new Form2();
                khanh.ShowDialog();
            }
        }
    }
}