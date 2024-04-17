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
    public partial class PageCustomers : Form
    {
        private DataDbContext _db;
        public PageCustomers()
        {
            InitializeComponent();
            _db = new DataDbContext();

        }
        private void Customers_Load(object sender, EventArgs e)
        {
            dataGridViewCustomersList.DataSource = _db.Customers.ToList();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var cus = new CustomerModel();
            cus.Name = textBoxName.Text;
            cus.Phone = textBoxPhone.Text;
            cus.Gender = comboBoxGender.SelectedItem.ToString();

            _db.Customers.Add(cus);
            _db.SaveChanges();

            dataGridViewCustomersList.DataSource = _db.Customers.ToList();

            foreach (Control control in this.Controls)
            {
                // Перевірка, чи контрол є текстовим полем
                if (control is TextBox textBox)
                {
                    // Встановлення властивості Text на порожній рядок
                    textBox.Text = string.Empty;
                    comboBoxGender.Text = string.Empty;
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var selectedCustomer = dataGridViewCustomersList.CurrentRow.DataBoundItem as CustomerModel;

            if (selectedCustomer != null)
            {
                _db.Customers.Remove(selectedCustomer);
                _db.SaveChanges();

                // Оновлюємо DataGridView
                dataGridViewCustomersList.DataSource = _db.Customers.ToList();
            }
            else
            {
                MessageBox.Show("Не вибрано жодного елемента для видалення.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void labelBills_Click(object sender, EventArgs e)
        {
            var billingWindow = new PageBills();
            billingWindow.StartPosition = FormStartPosition.CenterScreen;
            billingWindow.ShowDialog();
            this.Close();
        }

        private void labelCloseWindow_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void labelLogout_Click(object sender, EventArgs e)
        {
            var startWindow = new PageLogin();
            startWindow.StartPosition = FormStartPosition.CenterScreen;
            startWindow.ShowDialog();
            this.Close();

        }
    }
}
