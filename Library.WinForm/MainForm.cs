using Library.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.WinForms
{
    public partial class MainForm : Form
    {
        private readonly Library_Logic _logic;
        public MainForm()
        {
            InitializeComponent();
            _logic = new Library_Logic();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnGetAllBooks_Click(object sender, EventArgs e)
        {
            try
            {
                var books = _logic.GetAllBook();
                dgvBooks.DataSource = books;
                MessageBox.Show($"Загружено {books.Count} книг.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки книг: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreateForm createForm = new CreateForm();
            createForm.ShowDialog();
        }

        private void txtBookId_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtBookId.Text, out int id))
            {
                MessageBox.Show("Введите корректный ID книги.");
                return;
            }

            try
            {
                bool deleted = _logic.DeleteBook(id);
                if (deleted)
                {
                    MessageBox.Show("Книга удалена.");
                    btnGetAllBooks_Click(null, null);
                    txtBookId.Clear();
                }
                else
                {
                    MessageBox.Show("Книга с таким ID не найдена.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка удаления: " + ex.Message);
            }
        }
    }
}
