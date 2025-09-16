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
    public partial class UpdateForm : Form
    {
        private readonly Library_Logic _logic;
        private bool _bookLoaded = false; // флаг — загружена ли книга

        public UpdateForm()
        {
            InitializeComponent();
            _logic = new Library_Logic();
            LoadCategoriesIntoComboBox();
            DisableEditing();
        }

        private void UpdateForm_Load(object sender, EventArgs e)
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

        private void DisableEditing()
        {
            txtTitle.Enabled = false;
            txtAuthor.Enabled = false;
            txtDescription.Enabled = false;
            nudPages.Enabled = false;
            nudYear.Enabled = false;
            cmbCategory.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void EnableEditing()
        {
            txtTitle.Enabled = true;
            txtAuthor.Enabled = true;
            txtDescription.Enabled = true;
            nudPages.Enabled = true;
            nudYear.Enabled = true;
            cmbCategory.Enabled = true;
            btnUpdate.Enabled = true;
        }

        private void btnLoadBook_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int id))
            {
                MessageBox.Show("Введите корректный ID книги.");
                return;
            }

            try
            {
                var book = _logic.GetBookById(id);
                if (book == null)
                {
                    MessageBox.Show("Книга с таким ID не найдена.");
                    DisableEditing();
                    return;
                }

                txtTitle.Text = book.Title;
                txtAuthor.Text = book.Author;
                txtDescription.Text = book.Description;
                nudPages.Value = book.Number_of_pages;
                nudYear.Value = book.Year_Create;

                cmbCategory.SelectedValue = book.CategoryId;

                EnableEditing();
                _bookLoaded = true;

                MessageBox.Show("Книга загружена. Внесите изменения и нажмите 'Обновить'.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки книги: " + ex.Message);
                DisableEditing();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!_bookLoaded)
            {
                MessageBox.Show("Сначала загрузите книгу.");
                return;
            }

            if (!int.TryParse(txtId.Text, out int id))
            {
                MessageBox.Show("ID книги не определён.");
                return;
            }

            try
            {
                bool updated = _logic.UpdateBook(
                    id: id,
                    title: txtTitle.Text,
                    description: txtDescription.Text,
                    author: txtAuthor.Text,
                    numberOfPages: (int)nudPages.Value,
                    yearCreate: (int)nudYear.Value,
                    categoryId: (int)cmbCategory.SelectedValue
                );

                if (updated)
                {
                    MessageBox.Show("Книга успешно обновлена!");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Не удалось обновить книгу.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка обновления: " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
