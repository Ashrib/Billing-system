using System;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    public partial class AdminLoginPage : Form
    {
        public AdminLoginPage()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (userNameField.Text == string.Empty) throw new MyExceptions("UserName is required");
                else if (passwordField.Text == string.Empty) throw new MyExceptions("Password is required");
                else if (userNameField.Text != "admin") throw new MyExceptions("Invalid Username !");
                else if (passwordField.Text != "admin123") throw new MyExceptions("Invalid Password !");
                ManageProductPage mg = new ManageProductPage();
                mg.Show();
                this.Hide();
            }
            catch (Exception error)
            {
                MessageBox.Show($"{error.Message}");
            }
        }
    }
    class MyExceptions : Exception
    {
        public MyExceptions(string msg) : base(msg) { }
    }
}
