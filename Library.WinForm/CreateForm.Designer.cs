namespace Library.WinForms
{
    partial class CreateForm
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
            txtTitle = new TextBox();
            txtAuthor = new TextBox();
            txtDescription = new TextBox();
            btnAddBook = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            cmbCategory = new ComboBox();
            nudPages = new NumericUpDown();
            nudYear = new NumericUpDown();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)nudPages).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudYear).BeginInit();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.Font = new Font("Segoe UI", 18F);
            txtTitle.Location = new Point(163, 18);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(195, 39);
            txtTitle.TabIndex = 0;
            // 
            // txtAuthor
            // 
            txtAuthor.Font = new Font("Segoe UI", 18F);
            txtAuthor.Location = new Point(163, 63);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(195, 39);
            txtAuthor.TabIndex = 2;
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI", 18F);
            txtDescription.Location = new Point(163, 115);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(195, 39);
            txtDescription.TabIndex = 3;
            // 
            // btnAddBook
            // 
            btnAddBook.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnAddBook.Location = new Point(21, 345);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(167, 42);
            btnAddBook.TabIndex = 7;
            btnAddBook.Text = "Добавить книгу";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(21, 18);
            label1.Name = "label1";
            label1.Size = new Size(120, 32);
            label1.TabIndex = 8;
            label1.Text = "Название";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F);
            label2.Location = new Point(21, 66);
            label2.Name = "label2";
            label2.Size = new Size(80, 32);
            label2.TabIndex = 9;
            label2.Text = "Автор";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F);
            label3.Location = new Point(21, 118);
            label3.Name = "label3";
            label3.Size = new Size(124, 32);
            label3.TabIndex = 10;
            label3.Text = "Описание";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F);
            label4.Location = new Point(21, 169);
            label4.Name = "label4";
            label4.Size = new Size(106, 32);
            label4.TabIndex = 11;
            label4.Text = "Кол. Стр";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F);
            label5.Location = new Point(21, 225);
            label5.Name = "label5";
            label5.Size = new Size(52, 32);
            label5.TabIndex = 12;
            label5.Text = "Год";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F);
            label6.Location = new Point(21, 286);
            label6.Name = "label6";
            label6.Size = new Size(126, 32);
            label6.TabIndex = 13;
            label6.Text = "Категория";
            // 
            // cmbCategory
            // 
            cmbCategory.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(163, 286);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(195, 40);
            cmbCategory.TabIndex = 14;
            // 
            // nudPages
            // 
            nudPages.Font = new Font("Segoe UI", 18F);
            nudPages.Location = new Point(163, 169);
            nudPages.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            nudPages.Name = "nudPages";
            nudPages.Size = new Size(195, 39);
            nudPages.TabIndex = 15;
            // 
            // nudYear
            // 
            nudYear.Font = new Font("Segoe UI", 18F);
            nudYear.Location = new Point(163, 218);
            nudYear.Maximum = new decimal(new int[] { 2025, 0, 0, 0 });
            nudYear.Minimum = new decimal(new int[] { 1001, 0, 0, 0 });
            nudYear.Name = "nudYear";
            nudYear.Size = new Size(195, 39);
            nudYear.TabIndex = 16;
            nudYear.Value = new decimal(new int[] { 1001, 0, 0, 0 });
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(211, 345);
            button1.Name = "button1";
            button1.Size = new Size(167, 42);
            button1.TabIndex = 17;
            button1.Text = "Обновить";
            button1.UseVisualStyleBackColor = true;
            // 
            // CreateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 450);
            Controls.Add(button1);
            Controls.Add(nudYear);
            Controls.Add(nudPages);
            Controls.Add(cmbCategory);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAddBook);
            Controls.Add(txtDescription);
            Controls.Add(txtAuthor);
            Controls.Add(txtTitle);
            Name = "CreateForm";
            Text = "Создание книги";
            Load += CreateForm_Load;
            ((System.ComponentModel.ISupportInitialize)nudPages).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudYear).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitle;
        private TextBox txtAuthor;
        private TextBox txtDescription;
        private Button btnAddBook;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox cmbCategory;
        private NumericUpDown nudPages;
        private NumericUpDown nudYear;
        private Button button1;
    }
}