using Shop_Management_System.DBContext;
using Shop_Management_System.Model;
using Shop_Management_System.ToolsForForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        private void SignUpLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
