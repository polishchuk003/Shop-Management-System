using Shop_Management_System.DBContext;
using Shop_Management_System.Model;
using System;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows.Forms;

namespace Shop_Management_System
{
    public partial class PageBills : Form
    {
        private DataDbContext _db;
        public PageBills()
        {
            InitializeComponent();
            _db = new DataDbContext();
        }
        private void Billing_Load(object sender, EventArgs e)
        {
            LoadComboBoxItems();
            dataGridViewItems.DataSource = _db.Items.ToList();
            dataGridViewBills.DataSource = _db.Bills.ToList();
        }
        private void LoadComboBoxItems()
        {
            // Отримуємо всі категорії з бази даних і додаємо їх до Bills у comboBox1
            foreach (var customer in _db.Customers.ToList())
            {
                comboBoxCustomer.Items.Add(customer.Name);
            }
        }

        private void dataGridViewItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedItem = dataGridViewItems.CurrentRow.DataBoundItem as ItemModel;
            textBoxItem.Text = selectedItem.Name;
            textBoxPrice.Text = selectedItem.Price.ToString();
        }

        private void buttonReset(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                // Перевірка, чи контрол є текстовим полем
                if (control is TextBox textBox)
                {
                    // Встановлення властивості Text на порожній рядок
                    textBox.Text = string.Empty;
                    comboBoxCustomer.Text = string.Empty;
                }
            }

        }

        private void AddToBill_Click(object sender, EventArgs e)
        {
            var bill = new BillModel();

            string customerName = comboBoxCustomer.SelectedItem.ToString();
            if (customerName != null)
            {
                var customer = _db.Customers.Single(c => c.Name == customerName);
                bill.Customer = customer;
            }
            else
            {
                MessageBox.Show("error");
            }

            var selectedItem = dataGridViewItems.CurrentRow.DataBoundItem as ItemModel;

            bill.Item = selectedItem;
            bill.Quality = int.Parse(textBoxQuality.Text);
            bill.Total = decimal.Parse(textBoxPrice.Text) * bill.Quality;

            if (selectedItem.Stock < bill.Quality)
            {
                MessageBox.Show($"Not enough goods in stock\nAvailable only - {selectedItem.Stock} item(s)\nChoose a different quantity to order");
                textBoxQuality.Text = "";

            }
            else
            {
                var existingItem = _db.Items.Find(selectedItem.Id);
                if (existingItem != null)
                {
                    existingItem.Stock -= bill.Quality;
                    _db.Bills.Add(bill);
                    _db.SaveChanges();

                    // Проходження по всіх елементах у колекції контролів на формі
                    foreach (Control control in this.Controls)
                    {
                        // Перевірка, чи контрол є текстовим полем
                        if (control is TextBox textBox)
                        {
                            // Встановлення властивості Text на порожній рядок
                            textBox.Text = string.Empty;
                            comboBoxCustomer.Text = string.Empty;
                        }
                    }
                    dataGridViewItems.DataSource = _db.Items.ToList();
                }
            }
            dataGridViewBills.DataSource = _db.Bills.ToList();
        }

        private void buttonPrintBill(object sender, EventArgs e)
        {
            var selectedBill = dataGridViewBills.CurrentRow.DataBoundItem as BillModel;

            if (radioButtonCash.Checked || radioButtonCard.Checked || radioButtonMobile.Checked)
            {
                MessageBox.Show($"Dear {selectedBill.Customer.Name}." +
                    $"\nYour order is {selectedBill.Item.Name} - {selectedBill.Quality} pcs. - {selectedBill.Total}$");
            }
            else
            {
                MessageBox.Show("Choose a payment method!!");
            }
        }

        private void labelItems_Click(object sender, EventArgs e)
        {
            var itemsWindow = new PageItems();
            itemsWindow.StartPosition = FormStartPosition.CenterScreen;
            itemsWindow.ShowDialog();
            this.Close();
        }

        private void labelCategories_Click(object sender, EventArgs e)
        {
            var catWindow = new PageCategories();
            catWindow.StartPosition = FormStartPosition.CenterScreen;
            catWindow.ShowDialog();
            this.Close();
        }
        private void labelCustomers_Click(object sender, EventArgs e)
        {
            var customerWindow = new PageCustomers();
            customerWindow.StartPosition = FormStartPosition.CenterScreen;
            customerWindow.ShowDialog();
            this.Close();
        }
        private void labelLogout_Click(object sender, EventArgs e)
        {
            var loginPage = new PageLogin();
            loginPage.StartPosition = FormStartPosition.CenterScreen;
            loginPage.ShowDialog();
            this.Close();
        }

        private void pictureBoxItems_Click(object sender, EventArgs e)
        {
            labelItems_Click(sender, e);
        }

        private void labelCloseWindow_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                // Перевірка, чи контрол є текстовим полем
                if (control is TextBox textBox)
                {
                    // Встановлення властивості Text на порожній рядок
                    textBox.Text = string.Empty;
                    comboBoxCustomer.Text = string.Empty;
                }
            }
        }
    }


}

