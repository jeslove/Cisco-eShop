namespace CiscoEshop.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            Hide();
            Shop shop = new Shop();
            shop.Show();
        }
    }
}