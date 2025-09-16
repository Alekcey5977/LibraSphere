namespace Library.WinForms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvBooks = new DataGridView();
            btnGetAllBooks = new Button();
            btnCreate = new Button();
            btnDelete = new Button();
            txtBookId = new TextBox();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            nudSearchYear = new NumericUpDown();
            label3 = new Label();
            btnSearchByYear = new Button();
            btnSearchByCategory = new Button();
            cmbSearchCategory = new ComboBox();
            txtNewCategory = new TextBox();
            btnAddCategory = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSearchYear).BeginInit();
            SuspendLayout();
            // 
            // dgvBooks
            // 
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.Location = new Point(22, 12);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.Size = new Size(852, 281);
            dgvBooks.TabIndex = 0;
            // 
            // btnGetAllBooks
            // 
            btnGetAllBooks.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnGetAllBooks.Location = new Point(22, 308);
            btnGetAllBooks.Name = "btnGetAllBooks";
            btnGetAllBooks.Size = new Size(272, 39);
            btnGetAllBooks.TabIndex = 1;
            btnGetAllBooks.Text = "Загрузить все книги";
            btnGetAllBooks.UseVisualStyleBackColor = true;
            btnGetAllBooks.Click += btnGetAllBooks_Click;
            // 
            // btnCreate
            // 
            btnCreate.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnCreate.Location = new Point(586, 547);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(288, 45);
            btnCreate.TabIndex = 2;
            btnCreate.Text = "Добавить книгу";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 18F);
            btnDelete.Location = new Point(212, 565);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(218, 39);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Удалить книгу";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += txtBookId_Click;
            // 
            // txtBookId
            // 
            txtBookId.Font = new Font("Segoe UI", 18F);
            txtBookId.Location = new Point(78, 565);
            txtBookId.Name = "txtBookId";
            txtBookId.Size = new Size(107, 39);
            txtBookId.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(17, 530);
            label1.Name = "label1";
            label1.Size = new Size(262, 32);
            label1.TabIndex = 5;
            label1.Text = "ID книги для удаления";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(586, 598);
            button1.Name = "button1";
            button1.Size = new Size(288, 45);
            button1.TabIndex = 6;
            button1.Text = "Обновить книгу";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(586, 314);
            label2.Name = "label2";
            label2.Size = new Size(52, 32);
            label2.TabIndex = 7;
            label2.Text = "Год";
            // 
            // nudSearchYear
            // 
            nudSearchYear.Font = new Font("Segoe UI", 18F);
            nudSearchYear.Location = new Point(679, 312);
            nudSearchYear.Maximum = new decimal(new int[] { 2025, 0, 0, 0 });
            nudSearchYear.Minimum = new decimal(new int[] { 1001, 0, 0, 0 });
            nudSearchYear.Name = "nudSearchYear";
            nudSearchYear.Size = new Size(195, 39);
            nudSearchYear.TabIndex = 16;
            nudSearchYear.Value = new decimal(new int[] { 1001, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(510, 419);
            label3.Name = "label3";
            label3.Size = new Size(128, 32);
            label3.TabIndex = 17;
            label3.Text = "Категории";
            // 
            // btnSearchByYear
            // 
            btnSearchByYear.Font = new Font("Segoe UI", 18F);
            btnSearchByYear.Location = new Point(651, 358);
            btnSearchByYear.Name = "btnSearchByYear";
            btnSearchByYear.Size = new Size(223, 48);
            btnSearchByYear.TabIndex = 19;
            btnSearchByYear.Text = "Фильт по году";
            btnSearchByYear.UseVisualStyleBackColor = true;
            btnSearchByYear.Click += btnSearchByYear_Click;
            // 
            // btnSearchByCategory
            // 
            btnSearchByCategory.Font = new Font("Segoe UI", 18F);
            btnSearchByCategory.Location = new Point(596, 469);
            btnSearchByCategory.Name = "btnSearchByCategory";
            btnSearchByCategory.Size = new Size(278, 39);
            btnSearchByCategory.TabIndex = 20;
            btnSearchByCategory.Text = "Фильт по категории";
            btnSearchByCategory.UseVisualStyleBackColor = true;
            btnSearchByCategory.Click += btnSearchByCategory_Click;
            // 
            // cmbSearchCategory
            // 
            cmbSearchCategory.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cmbSearchCategory.FormattingEnabled = true;
            cmbSearchCategory.Location = new Point(679, 416);
            cmbSearchCategory.Name = "cmbSearchCategory";
            cmbSearchCategory.Size = new Size(195, 40);
            cmbSearchCategory.TabIndex = 21;
            // 
            // txtNewCategory
            // 
            txtNewCategory.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtNewCategory.Location = new Point(257, 381);
            txtNewCategory.Name = "txtNewCategory";
            txtNewCategory.Size = new Size(180, 39);
            txtNewCategory.TabIndex = 22;
            // 
            // btnAddCategory
            // 
            btnAddCategory.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnAddCategory.Location = new Point(49, 426);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(288, 45);
            btnAddCategory.TabIndex = 23;
            btnAddCategory.Text = "Добавить категорию";
            btnAddCategory.UseVisualStyleBackColor = true;
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(12, 381);
            label4.Name = "label4";
            label4.Size = new Size(239, 32);
            label4.TabIndex = 24;
            label4.Text = "Название категории";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(898, 650);
            Controls.Add(label4);
            Controls.Add(btnAddCategory);
            Controls.Add(txtNewCategory);
            Controls.Add(cmbSearchCategory);
            Controls.Add(btnSearchByCategory);
            Controls.Add(btnSearchByYear);
            Controls.Add(label3);
            Controls.Add(nudSearchYear);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(txtBookId);
            Controls.Add(btnDelete);
            Controls.Add(btnCreate);
            Controls.Add(btnGetAllBooks);
            Controls.Add(dgvBooks);
            Name = "MainForm";
            Text = "Меню";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSearchYear).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvBooks;
        private Button btnGetAllBooks;
        private Button btnCreate;
        private Button btnDelete;
        private TextBox txtBookId;
        private Label label1;
        private Button button1;
        private Label label2;
        private NumericUpDown nudSearchYear;
        private Label label3;
        private Button btnSearchByYear;
        private Button btnSearchByCategory;
        private ComboBox cmbSearchCategory;
        private TextBox txtNewCategory;
        private Button btnAddCategory;
        private Label label4;
    }
}