using Shop_Management_System.Model;
using Shop_Management_System.ToolsForForms;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Shop_Management_System
{
    public partial class PageCustomers : BaseForm
    {
        public PageCustomers()
        {
            InitializeComponent();
        }
        private void Customers_Load(object sender, EventArgs e)
        {
            dataGridViewCustomersList.DataSource = _db.Customers.ToList();
            CustomStyleDataGriedView(dataGridViewCustomersList);

            // AutoSizeColumns(dataGridViewCustomersList);
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == string.Empty ||
                textBoxPhone.Text == string.Empty ||
                comboBoxGender.Text == string.Empty)
            {
                PrintErrorEmptyField();
            }
            else
            {
                var cus = new CustomerModel();
                cus.Name = textBoxName.Text;
                cus.Phone = textBoxPhone.Text;
                cus.Gender = comboBoxGender.SelectedItem.ToString();

                _db.Customers.Add(cus);
                _db.SaveChanges();

                ClearTextBoxes();
                comboBoxGender.Text = string.Empty;
            }

            dataGridViewCustomersList.DataSource = _db.Customers.ToList();

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
            OpenFormAndCloseCurrent(itemsWindow);
        }

        private void labelCategories_Click(object sender, EventArgs e)
        {
            var catWindow = new PageCategories();
            OpenFormAndCloseCurrent(catWindow);


        }
        private void labelBills_Click(object sender, EventArgs e)
        {
            var billingWindow = new PageBills();
            OpenFormAndCloseCurrent(billingWindow);

        }

        private void labelCloseWindow_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void labelLogout_Click(object sender, EventArgs e)
        {
            var startWindow = new PageLogin();
            OpenFormAndCloseCurrent(startWindow);


        }
    }
}
