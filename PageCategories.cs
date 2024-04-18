using Shop_Management_System.DBContext;
using Shop_Management_System.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shop_Management_System.ToolsForForms;

namespace Shop_Management_System
{
    public partial class PageCategories : BaseForm
    {
        public PageCategories()
        {
            InitializeComponent();
        }
        private void Categories_Load(object sender, EventArgs e)
        {
            dataGridViewCategoryList.DataSource = _db.Categories.ToList();
            AutoSizeColumns(dataGridViewCategoryList);
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxCategoryName.Text == string.Empty)
            {
                PrintErrorEmptyField();
            }
            else
            {
                var newCategory = new CategoryModel();
                newCategory.Name = textBoxCategoryName.Text;

                _db.Categories.Add(newCategory);
                _db.SaveChanges();

                dataGridViewCategoryList.DataSource = _db.Categories.ToList();

                ClearTextBoxes();
            }

        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var selectedCategory = dataGridViewCategoryList.CurrentRow.DataBoundItem as CategoryModel;

            if (selectedCategory != null)
            {
                _db.Categories.Remove(selectedCategory);
                _db.SaveChanges();

                // Оновлюємо DataGridView
                dataGridViewCategoryList.DataSource = _db.Categories.ToList();
            }
            else
            {
                MessageBox.Show("Не вибрано жодного елемента для видалення.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            var selectedCategotyForEdit = dataGridViewCategoryList.CurrentRow.DataBoundItem as CategoryModel;

            if (selectedCategotyForEdit != null)
            {
                selectedCategotyForEdit.Name = textBoxCategoryName.Text;

                _db.Categories.AddOrUpdate(selectedCategotyForEdit);
                _db.SaveChanges();

                ClearTextBoxes();

                dataGridViewCategoryList.DataSource = _db.Categories.ToList();
            }
            else
            {
                MessageBox.Show("No items are selected for deletion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void labelItems_Click(object sender, EventArgs e)
        {
            var itemWindow = new PageItems();
            OpenFormAndCloseCurrent(itemWindow);
        }

        private void labelCustomers_Click(object sender, EventArgs e)
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
    }
}
