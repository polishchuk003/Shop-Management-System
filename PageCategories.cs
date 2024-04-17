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

namespace Shop_Management_System
{
    public partial class PageCategories : Form
    {
        private DataDbContext _db;
        public PageCategories()
        {
            _db = new DataDbContext();
            InitializeComponent();

        }
        private void Categories_Load(object sender, EventArgs e)
        {
            dataGridViewCategoryList.DataSource = _db.Categories.ToList();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var newCategory = new CategoryModel();
            newCategory.Name = textBoxCategoryName.Text;

            _db.Categories.Add(newCategory);
            _db.SaveChanges();

            dataGridViewCategoryList.DataSource = _db.Categories.ToList();

            textBoxCategoryName.Text = "";
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
                textBoxCategoryName.Text = "";

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
            itemWindow.StartPosition = FormStartPosition.CenterScreen;
            itemWindow.ShowDialog();
            this.Close();
        }

        private void labelCustomers_Click(object sender, EventArgs e)
        {
            var customerWindow = new PageCustomers();
            customerWindow.StartPosition = FormStartPosition.CenterScreen;
            customerWindow.ShowDialog();
            this.Close();
        }

        private void labelBills_Click(object sender, EventArgs e)
        {
            var billingWindow = new PageBills();
            billingWindow.StartPosition = FormStartPosition.CenterScreen;
            billingWindow.ShowDialog();
            this.Close();
        }

        private void labelDashboard_Click(object sender, EventArgs e)
        {

        }



    }
}
