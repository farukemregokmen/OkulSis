using Microsoft.Extensions.Options;

namespace OkulSis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void girisBut_Click(object sender, EventArgs e)
        {
            var userNo = userNoBox.Text;
            var userPass = passBox.Text;
            using (OkulSisContext context = new OkulSisContext())
            {
                if(context.Users.Any(u => u.UserNo.ToString() == userNo && u.Pass.ToString() == userPass))
                {
                    Form2 form = new Form2(this);
                    form.Show();
                    this.Hide();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
