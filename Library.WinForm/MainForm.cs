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
            LoadCategoriesForSearch();
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

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateForm updateForm = new UpdateForm();
            updateForm.ShowDialog();
        }

        private void LoadCategoriesForSearch()
        {
            try
            {
                var categories = _logic.GetAllCategories();
                cmbSearchCategory.DataSource = categories;
                cmbSearchCategory.DisplayMember = "Title";
                cmbSearchCategory.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки категорий для поиска: " + ex.Message);
            }
        }

        private void btnSearchByYear_Click(object sender, EventArgs e)
        {
            try
            {
                int year = (int)nudSearchYear.Value;
                var books = _logic.GetBooksByYearRange(year);
                if (books.Count == 0)
                {
                    MessageBox.Show($"Книг за {year} год не найдено.");
                    dgvBooks.DataSource = null;
                    return;
                }

                dgvBooks.DataSource = books;
                MessageBox.Show($"Найдено {books.Count} книг за {year} год.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка поиска по году: " + ex.Message);
            }
        }

        private void btnSearchByCategory_Click(object sender, EventArgs e)
        {
            if (cmbSearchCategory.SelectedValue == null)
            {
                MessageBox.Show("Выберите категорию.");
                return;
            }

            try
            {
                int categoryId = (int)cmbSearchCategory.SelectedValue;
                var books = _logic.GetCategoryByTitle(categoryId);

                if (books.Count == 0)
                {
                    MessageBox.Show($"Книг в категории '{cmbSearchCategory.Text}' не найдено.");
                    dgvBooks.DataSource = null;
                    return;
                }

                dgvBooks.DataSource = books;
                MessageBox.Show($"Найдено {books.Count} книг в категории '{cmbSearchCategory.Text}'.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка поиска по категории: " + ex.Message);
            }
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            string title = txtNewCategory.Text.Trim();

            if (string.IsNullOrWhiteSpace(title))
            {
                MessageBox.Show("Введите название категории.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var category = _logic.CreateCategory(title);
                MessageBox.Show($"Категория '{category.Title}' успешно добавлена с ID {category.Id}", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtNewCategory.Clear();

                LoadCategoriesForSearch();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка добавления категории: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
