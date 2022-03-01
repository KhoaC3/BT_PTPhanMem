namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
                string userName = txtUserName.Text;
                string passWord = txtPassword.Text;
                if (userName == "admin" && passWord == "admin")
                {
                    this.Hide();
                    Form2 form = new Form2();
                    form.Show();
                }
                else
                {
                    MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
                }
        }
    }
}