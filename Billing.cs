using Shop_Management_System.DBContext;
using Shop_Management_System.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.Migrations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Shop_Management_System
{
    public partial class Billing : Form
    {
        private DataDbContext _db;
        public Billing()
        {
            InitializeComponent();
            _db = new DataDbContext();
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

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Billing_Load(object sender, EventArgs e)
        {
            LoadComboBoxItems();
            dataGridView2.DataSource = _db.Items.ToList();
            dataGridView1.DataSource = _db.Bills.ToList();
            

        }


        private void LoadComboBoxItems()
        {
            // Отримуємо всі категорії з бази даних і додаємо їх до Bills у comboBox1
            foreach (var customer in _db.Customers.ToList())
            {
                comboBox1.Items.Add(customer.Name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var bill = new Bill();
            string customerName = comboBox1.SelectedItem.ToString();

            if (customerName != null)
            {
                var customer = _db.Customers.Single(c => c.Name == customerName);
                bill.Customer = customer;
            }
            else
            {
                MessageBox.Show("error");
            }

            var selectedItem = dataGridView2.CurrentRow.DataBoundItem as Item;

            bill.Item = selectedItem;
            bill.Quality = int.Parse(textBox2.Text);
            bill.Total = decimal.Parse(textBoxPrice.Text) * bill.Quality;


            _db.Bills.Add(bill);
            _db.SaveChanges();

            dataGridView1.DataSource = _db.Bills.ToList();


        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedItem = dataGridView2.CurrentRow.DataBoundItem as Item;
            textBox1.Text = selectedItem.Name;
            textBoxPrice.Text = selectedItem.Price.ToString();
        }
    }


}

