using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_Management_System
{
    public partial class Billing : Form
    {
        public Billing()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            var itemsWindow = new Login();
            itemsWindow.StartPosition = FormStartPosition.CenterScreen;
            itemsWindow.ShowDialog();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            var catWindow = new Categories();
            catWindow.StartPosition = FormStartPosition.CenterScreen;
            catWindow.ShowDialog();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            var customerWindow = new Customers();
            customerWindow.StartPosition = FormStartPosition.CenterScreen;
            customerWindow.ShowDialog();
            this.Hide();
        }
    }
}
