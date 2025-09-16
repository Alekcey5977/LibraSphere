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
    public partial class CreateForm : Form
    {
        private readonly Library_Logic _logic;

        public CreateForm()
        {
            InitializeComponent();
            _logic = new Library_Logic();
            LoadCategoriesIntoComboBox();
        }

        private void CreateForm_Load(object sender, EventArgs e)
        {

        }

        private void LoadCategoriesIntoComboBox()
        {
            try
            {
                var categories = _logic.GetAllCategories();
                cmbCategory.DataSource = categories;
                cmbCategory.DisplayMember = "Title";
                cmbCategory.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки категорий: " + ex.Message);
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtTitle.Text))
                {
                    MessageBox.Show("Введите название книги.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtAuthor.Text))
                {
                    MessageBox.Show("Введите автора.");
                    return;
                }

                if (cmbCategory.SelectedValue == null)
                {
                    MessageBox.Show("Выберите категорию.");
                    return;
                }

                var book = _logic.CreateBook(
                    title: txtTitle.Text,
                    description: txtDescription.Text,
                    author: txtAuthor.Text,
                    numberOfPages: (int)nudPages.Value,
                    yearCreate: (int)nudYear.Value,
                    categoryId: (int)cmbCategory.SelectedValue
                );

                MessageBox.Show($"Книга '{book.Title}' добавлена с ID {book.Id}");

                ClearBookInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка добавления книги: " + ex.Message);
            }
        }

        private void ClearBookInputs()
        {
            txtTitle.Clear();
            txtAuthor.Clear();
            txtDescription.Clear();
        }
    }
}
