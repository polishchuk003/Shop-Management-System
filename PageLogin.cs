using Shop_Management_System.DBContext;
using Shop_Management_System.Model;
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
    public partial class PageLogin : Form
    {
        private DataDbContext _db;
        public PageLogin()
        {
            InitializeComponent();
            _db = new DataDbContext();
        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            if(LoginTextBox.Text == "1" && PasswordTextBox.Text == "1")
            {
                var itemPage = new PageItems();
                itemPage.StartPosition = FormStartPosition.CenterScreen;
                itemPage.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Missing data!!!");

                foreach (Control control in this.Controls)
                {
                    // Перевірка, чи контрол є текстовим полем
                    if (control is System.Windows.Forms.TextBox textBox)
                    {
                        // Встановлення властивості Text на порожній рядок
                        textBox.Text = string.Empty;
                    }
                }
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
