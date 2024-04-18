using Shop_Management_System.DBContext;
using Shop_Management_System.Model;
using System;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using Shop_Management_System.ToolsForForms;

namespace Shop_Management_System
{
    public partial class PageBills : BaseForm
    {
        public PageBills()
        {
            InitializeComponent();
        }
        private void Billing_Load(object sender, EventArgs e)
        {
            LoadComboBoxItems();
            dataGridViewItems.DataSource = _db.Items.ToList();
            dataGridViewItems.Columns[5].Visible = false;
            dataGridViewBills.DataSource = _db.Bills.ToList();
            dataGridViewBills.Columns[3].Visible = false;
            dataGridViewBills.Columns[5].Visible = false;

            AutoSizeColumns(dataGridViewBills);
            AutoSizeColumns(dataGridViewItems);

        }
        private void dataGridViewItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedItem = dataGridViewItems.CurrentRow.DataBoundItem as ItemModel;
            textBoxItem.Text = selectedItem.Name;
            textBoxPrice.Text = selectedItem.Price.ToString();
        }
        private void AddToBill_Click(object sender, EventArgs e)
        {
            if (textBoxItem.Text == string.Empty ||
                textBoxPrice.Text == string.Empty ||
                textBoxQuality.Text == string.Empty ||
                comboBoxCustomer.Text == string.Empty)
            {
                PrintErrorEmptyField();
            }
            else
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
                    textBoxQuality.Text = string.Empty;

                }
                else
                {
                    var existingItem = _db.Items.Find(selectedItem.Id);
                    if (existingItem != null)
                    {
                        existingItem.Stock -= bill.Quality;
                        _db.Bills.Add(bill);
                        _db.SaveChanges();

                        ClearTextBoxes();
                        comboBoxCustomer.Text = string.Empty;
                        dataGridViewItems.DataSource = _db.Items.ToList();
                    }
                }
            }
            dataGridViewBills.DataSource = _db.Bills.ToList();
        }

        private void buttonPrintBill(object sender, EventArgs e)
        {
            var selectedBill = dataGridViewBills.CurrentRow.DataBoundItem as BillModel;

            string paymentMethod = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked)?.Text;

            if (radioButtonCash.Checked || radioButtonCard.Checked || radioButtonMobile.Checked)
            {
                MessageBox.Show($"Dear {selectedBill.Customer.Name}." +
                    $"\nYour order is {selectedBill.Item.Name} - {selectedBill.Quality} pcs. - {selectedBill.Total}$" +
                    $"\nYou have chosen a payment method - by {paymentMethod}");
            }
            else
            {
                MessageBox.Show("Choose a payment method!!");
            }
        }

        private void labelItems_Click(object sender, EventArgs e)
        {
            var itemsWindow = new PageItems();
            OpenFormAndCloseCurrent(itemsWindow);
        }

        private void labelCategories_Click(object sender, EventArgs e)
        {
            var catWindow = new PageCategories();
            OpenFormAndCloseCurrent(catWindow);
        }
        private void labelCustomers_Click(object sender, EventArgs e)
        {
            var customerWindow = new PageCustomers();
            OpenFormAndCloseCurrent(customerWindow);
        }
        private void labelLogout_Click(object sender, EventArgs e)
        {
            var loginPage = new PageLogin();
            OpenFormAndCloseCurrent(loginPage);
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
            ClearTextBoxes();
            comboBoxCustomer.Text = string.Empty;
        }


        private void LoadComboBoxItems()
        {
            foreach (var customer in _db.Customers.ToList())
            {
                comboBoxCustomer.Items.Add(customer.Name);
            }
        }
    }
}

