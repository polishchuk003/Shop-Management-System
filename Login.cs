using Shop_Management_System.DBContext;
using Shop_Management_System.Model;
using System;
using System.Data.Entity.Migrations;
using System.Linq;
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
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var item = new Item();
            item.Name = textBox1.Text;
            item.Price = int.Parse(textBox2.Text);
            item.Stock = int.Parse(textBox3.Text);

            string categoryName = comboBox1.SelectedItem?.ToString();


            if (categoryName != null)
            {
                var category = _db.Categories.Single(c => c.Name == categoryName);
                item.Category = category;
            }

            //item.Category = new Category();
            //item.Category.Name = comboBox1.SelectedIndex.ToString();

            ////var selectedCategory = comboBox1.SelectedItem as Category;
            ////if (selectedCategory != null)
            ////{
            ////    // Присвоєння вибраної категорії до елемента
            ////    item.Category = selectedCategory;
            ////}

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

        private void Form_Clodes(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var selectedItem = dataGridView2.CurrentRow.DataBoundItem as Item;

            if (selectedItem != null)
            {
                _db.Items.Remove(selectedItem);
                _db.SaveChanges();

                // Оновлюємо DataGridView
                dataGridView2.DataSource = _db.Items.ToList();
            }
            else
            {
                MessageBox.Show("Не вибрано жодного елемента для видалення.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var selectedItemForEdit = dataGridView2.CurrentRow.DataBoundItem as Item;

            if (selectedItemForEdit != null)
            {
                selectedItemForEdit.Name = textBox1.Text;
                selectedItemForEdit.Price = int.Parse(textBox2.Text);
                selectedItemForEdit.Stock = int.Parse(textBox3.Text);

                selectedItemForEdit.Category.Name = comboBox1.SelectedIndex.ToString();

                //var selectedCategory = comboBox1.SelectedItem as Category;
                //if (selectedCategory != null)
                //{
                //    // Присвоєння вибраної категорії до елемента
                //    item.Category = selectedCategory;
                //}

                selectedItemForEdit.Manufacturer = textBox4.Text;

                _db.Items.AddOrUpdate(selectedItemForEdit);
                _db.SaveChanges();

                dataGridView2.DataSource = _db.Items.ToList();

            }
            else
            {
                MessageBox.Show("Не вибрано жодного елемента для видалення.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
