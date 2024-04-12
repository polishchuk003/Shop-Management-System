using Shop_Management_System.DBContext;
using Shop_Management_System.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_Management_System
{
    public partial class Login : Form
    {
        private DataDbContext _db;
        public Login()
        {
            InitializeComponent();
            _db = new DataDbContext();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            LoadComboBoxItems();
            dataGridView2.DataSource = _db.Items.ToList();

        }
        private void LoadComboBoxItems()
        {
            // Отримуємо всі категорії з бази даних і додаємо їх до Items у comboBox1
            foreach (var category in _db.Categories.ToList())
            {
                comboBox1.Items.Add(category.Name); // Додаємо об'єкт категорії до випадаючого списку
            }
        }

        private void label11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            var item = new Item();
            item.Name = textBox1.Text;
            item.Price = int.Parse(textBox2.Text);
            item.Stock = int.Parse(textBox3.Text);
            //comboBox1.Text = item.Category.Name;
            item.Manufacturer = textBox4.Text;

            _db.Items.Add(item);
            _db.SaveChanges();

            dataGridView2.DataSource = _db.Items.ToList();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {
            var customerWindow = new Customers();
            customerWindow.StartPosition = FormStartPosition.CenterScreen;
            customerWindow.ShowDialog();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            var categoriesWindow = new Categories();
            categoriesWindow.StartPosition = FormStartPosition.CenterScreen;
            categoriesWindow.ShowDialog();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            var billingWindow = new Billing();
            billingWindow.StartPosition = FormStartPosition.CenterScreen;
            billingWindow.ShowDialog();
            this.Hide();
        }

        public void TransferWindow()
        {
            var billingWindow = new Billing();
            billingWindow.StartPosition = FormStartPosition.CenterScreen;
            billingWindow.ShowDialog();
            this.Hide();
        }
    }
}
