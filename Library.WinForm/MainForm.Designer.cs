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
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            SuspendLayout();
            // 
            // dgvBooks
            // 
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.Location = new Point(22, 12);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.Size = new Size(663, 281);
            dgvBooks.TabIndex = 0;
            // 
            // btnGetAllBooks
            // 
            btnGetAllBooks.Location = new Point(22, 308);
            btnGetAllBooks.Name = "btnGetAllBooks";
            btnGetAllBooks.Size = new Size(156, 39);
            btnGetAllBooks.TabIndex = 1;
            btnGetAllBooks.Text = "Загрузить все книги";
            btnGetAllBooks.UseVisualStyleBackColor = true;
            btnGetAllBooks.Click += btnGetAllBooks_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(627, 407);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(143, 31);
            btnCreate.TabIndex = 2;
            btnCreate.Text = "Добавить книгу";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCreate);
            Controls.Add(btnGetAllBooks);
            Controls.Add(dgvBooks);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvBooks;
        private Button btnGetAllBooks;
        private Button btnCreate;
    }
}