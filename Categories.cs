using Shop_Management_System.DBContext;
using Shop_Management_System.Model;
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
    public partial class Categories : Form
    {
        private DataDbContext _db;
        public Categories()
        {
            _db = new DataDbContext();
            InitializeComponent();

        }
        private void Categories_Load(object sender, EventArgs e)
        {
            dataGridView2.DataSource = _db.Categories.ToList();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            var itemWindow = new Login();
            itemWindow.StartPosition = FormStartPosition.CenterScreen;
            itemWindow.ShowDialog();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            var customerWindow = new Customers();
            customerWindow.StartPosition = FormStartPosition.CenterScreen;
            customerWindow.ShowDialog();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            var billingWindow = new Billing();
            billingWindow.StartPosition = FormStartPosition.CenterScreen;
            billingWindow.ShowDialog();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var newCategory = new Category();
            newCategory.Name = textBox1.Text;

            _db.Categories.Add(newCategory);
            _db.SaveChanges();

            dataGridView2.DataSource = _db.Categories.ToList();

        }
    }
}
