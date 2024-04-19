using Shop_Management_System.DBContext;
using System.Drawing;
using System.Windows.Forms;

namespace Shop_Management_System.ToolsForForms
{
    public class BaseForm : Form
    {
        protected readonly DataDbContext _db;
        public BaseForm()
        {
            _db = new DataDbContext();
        }
        protected void OpenFormAndCloseCurrent(Form newForm)
        {
            newForm.StartPosition = FormStartPosition.CenterScreen;
            newForm.ShowDialog();
            this.Close();
        }

        protected void ClearTextBoxes()
        {
            foreach (Control control in this.Controls)
            {
                // Перевірка, чи контрол є текстовим полем
                if (control is TextBox textBox)
                {
                    // Встановлення властивості Text на порожній рядок
                    textBox.Text = string.Empty;
                }
            }
        }

        protected void AutoSizeColumns(DataGridView view)
        {
            foreach (DataGridViewColumn column in view.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        protected void PrintErrorEmptyField()
        {
            MessageBox.Show("Some fields are not filled in!!!");
        }

        protected void CustomStyleDataGriedView(DataGridView dataGridView)
        {
            dataGridView.DefaultCellStyle.Font = new Font("Arial", 10);
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
        }

    }
}
