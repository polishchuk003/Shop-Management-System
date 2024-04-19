using Shop_Management_System.ToolsForForms;
using System;
using System.Windows.Forms;

namespace Shop_Management_System
{
    public partial class PageLogin : BaseForm
    {
        public PageLogin()
        {
            InitializeComponent();
        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (LoginTextBox.Text == "1" && PasswordTextBox.Text == "1")
            {
                var itemPage = new PageItems();
                OpenFormAndCloseCurrent(itemPage);
            }
            else
            {
                MessageBox.Show("Missing data!!!");
                ClearTextBoxes();
            }
        }

        private void labelCloseWindow_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

    }
}
