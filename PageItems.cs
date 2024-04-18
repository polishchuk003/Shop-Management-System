using Shop_Management_System.DBContext;
using Shop_Management_System.Model;
using System;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Windows.Forms;
using Shop_Management_System.ToolsForForms;

namespace Shop_Management_System
{
    public partial class PageItems : BaseForm
    {
        public PageItems()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            LoadComboBoxItems();
            dataGridViewItemsList.DataSource = _db.Items.ToList();
            dataGridViewItemsList.Columns[5].Visible = false;
            AutoSizeColumns(dataGridViewItemsList);
        }
        private void LoadComboBoxItems()
        {
            // Отримуємо всі категорії з бази даних і додаємо їх до Items у comboBox1
            foreach (var category in _db.Categories.ToList())
            {
                comboBoxCategory.Items.Add(category.Name); // Додаємо об'єкт категорії до випадаючого списку
            }
        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            var selectedItemForEdit = dataGridViewItemsList.CurrentRow.DataBoundItem as ItemModel;

            if (selectedItemForEdit != null)
            {
                selectedItemForEdit.Name = textBoxItem.Text;
                selectedItemForEdit.Price = int.Parse(textBoxPrice.Text);
                selectedItemForEdit.Stock = int.Parse(textBoxStock.Text);

                selectedItemForEdit.Category.Name = comboBoxCategory.SelectedIndex.ToString();

                selectedItemForEdit.Manufacturer = textBoxManufacturer.Text;

                _db.Items.AddOrUpdate(selectedItemForEdit);
                _db.SaveChanges();

                dataGridViewItemsList.DataSource = _db.Items.ToList();

            }
            else
            {
                MessageBox.Show("No items are selected for deletion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            if (textBoxItem.Text == string.Empty ||
                textBoxPrice.Text == string.Empty ||
                textBoxStock.Text == string.Empty ||
                textBoxManufacturer.Text == string.Empty ||
                comboBoxCategory.Text == string.Empty)
            {
                PrintErrorEmptyField();

            }
            else
            {
                var item = new ItemModel();
                item.Name = textBoxItem.Text;
                item.Price = int.Parse(textBoxPrice.Text);
                item.Stock = int.Parse(textBoxStock.Text);
                item.Manufacturer = textBoxManufacturer.Text;

                string categoryName = comboBoxCategory.SelectedItem?.ToString();

                if (categoryName != null)
                {
                    var category = _db.Categories.Single(c => c.Name == categoryName);
                    item.Category = category;
                }
                else
                {
                    MessageBox.Show("You need to select a category");
                }

                _db.Items.Add(item);
                _db.SaveChanges();

                ClearTextBoxes();
                comboBoxCategory.Text = string.Empty;
            }


            dataGridViewItemsList.DataSource = _db.Items.ToList();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var selectedItem = dataGridViewItemsList.CurrentRow.DataBoundItem as ItemModel;

            if (selectedItem != null)
            {
                _db.Items.Remove(selectedItem);
                _db.SaveChanges();

                // Оновлюємо DataGridView
                dataGridViewItemsList.DataSource = _db.Items.ToList();
            }
            else
            {
                MessageBox.Show("Не вибрано жодного елемента для видалення.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void labelCategories_Click(object sender, EventArgs e)
        {
            var categoriesWindow = new PageCategories();
            OpenFormAndCloseCurrent(categoriesWindow);
        }

        private void labelCustomers_Click_1(object sender, EventArgs e)
        {
            var customerWindow = new PageCustomers();
            OpenFormAndCloseCurrent(customerWindow);

        }

        private void labelBills_Click(object sender, EventArgs e)
        {
            var billingWindow = new PageBills();
            OpenFormAndCloseCurrent(billingWindow);

        }

        private void labelDashboard_Click(object sender, EventArgs e)
        {

        }

        private void labelCloseWindow_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
        private void Form_Clodes(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
