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
    public partial class Customers : Form
    {
        private DataDbContext _db;
        public Customers()
        {
            InitializeComponent();
            _db = new DataDbContext();

        }

        private void Customers_Load(object sender, EventArgs e)
        {

            dataGridView2.DataSource = _db.Customers.ToList();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            var cus = new Customer();
            cus.Name = textBox1.Text;
            cus.Phone = textBox2.Text;
            cus.Gender = comboBox1.SelectedItem.ToString(); 

            _db.Customers.Add(cus);
            _db.SaveChanges();
            dataGridView2.DataSource = _db.Customers.ToList();

        }

        private void label11_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void label3_Click(object sender, EventArgs e)
        {
            var billingWindow = new Billing();
            billingWindow.StartPosition = FormStartPosition.CenterScreen;
            billingWindow.ShowDialog();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Logout();
        }

        public void Logout()
        {
            var startWindow = new MainPage();
            startWindow.StartPosition = FormStartPosition.CenterScreen;
            startWindow.ShowDialog();
            this.Hide();
        }
    }
}
