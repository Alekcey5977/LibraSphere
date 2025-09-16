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
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            SuspendLayout();
            // 
            // dgvBooks
            // 
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.Location = new Point(22, 12);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.Size = new Size(748, 281);
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
            btnCreate.Location = new Point(500, 593);
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
            btnDelete.Location = new Point(227, 490);
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
            txtBookId.Location = new Point(93, 490);
            txtBookId.Name = "txtBookId";
            txtBookId.Size = new Size(107, 39);
            txtBookId.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(32, 455);
            label1.Name = "label1";
            label1.Size = new Size(262, 32);
            label1.TabIndex = 5;
            label1.Text = "ID книги для удаления";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 650);
            Controls.Add(label1);
            Controls.Add(txtBookId);
            Controls.Add(btnDelete);
            Controls.Add(btnCreate);
            Controls.Add(btnGetAllBooks);
            Controls.Add(dgvBooks);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
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
    }
}