namespace Library.WinForms
{
    partial class UpdateForm
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
            btnUpdate = new Button();
            nudYear = new NumericUpDown();
            nudPages = new NumericUpDown();
            cmbCategory = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnLoadBook = new Button();
            txtDescription = new TextBox();
            txtAuthor = new TextBox();
            txtTitle = new TextBox();
            txtId = new TextBox();
            label7 = new Label();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)nudYear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPages).BeginInit();
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnUpdate.Location = new Point(199, 396);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(167, 42);
            btnUpdate.TabIndex = 31;
            btnUpdate.Text = "Обновить";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // nudYear
            // 
            nudYear.Font = new Font("Segoe UI", 18F);
            nudYear.Location = new Point(168, 276);
            nudYear.Maximum = new decimal(new int[] { 2025, 0, 0, 0 });
            nudYear.Minimum = new decimal(new int[] { 1001, 0, 0, 0 });
            nudYear.Name = "nudYear";
            nudYear.Size = new Size(195, 39);
            nudYear.TabIndex = 30;
            nudYear.Value = new decimal(new int[] { 1001, 0, 0, 0 });
            // 
            // nudPages
            // 
            nudPages.Font = new Font("Segoe UI", 18F);
            nudPages.Location = new Point(168, 220);
            nudPages.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            nudPages.Name = "nudPages";
            nudPages.Size = new Size(195, 39);
            nudPages.TabIndex = 29;
            // 
            // cmbCategory
            // 
            cmbCategory.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(168, 337);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(195, 40);
            cmbCategory.TabIndex = 28;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F);
            label6.Location = new Point(26, 337);
            label6.Name = "label6";
            label6.Size = new Size(126, 32);
            label6.TabIndex = 27;
            label6.Text = "Категория";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F);
            label5.Location = new Point(26, 276);
            label5.Name = "label5";
            label5.Size = new Size(52, 32);
            label5.TabIndex = 26;
            label5.Text = "Год";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F);
            label4.Location = new Point(26, 220);
            label4.Name = "label4";
            label4.Size = new Size(106, 32);
            label4.TabIndex = 25;
            label4.Text = "Кол. Стр";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F);
            label3.Location = new Point(26, 169);
            label3.Name = "label3";
            label3.Size = new Size(124, 32);
            label3.TabIndex = 24;
            label3.Text = "Описание";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F);
            label2.Location = new Point(26, 117);
            label2.Name = "label2";
            label2.Size = new Size(80, 32);
            label2.TabIndex = 23;
            label2.Text = "Автор";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(26, 69);
            label1.Name = "label1";
            label1.Size = new Size(120, 32);
            label1.TabIndex = 22;
            label1.Text = "Название";
            // 
            // btnLoadBook
            // 
            btnLoadBook.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnLoadBook.Location = new Point(26, 396);
            btnLoadBook.Name = "btnLoadBook";
            btnLoadBook.Size = new Size(167, 42);
            btnLoadBook.TabIndex = 21;
            btnLoadBook.Text = "Загрузить";
            btnLoadBook.UseVisualStyleBackColor = true;
            btnLoadBook.Click += btnLoadBook_Click;
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI", 18F);
            txtDescription.Location = new Point(168, 166);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(195, 39);
            txtDescription.TabIndex = 20;
            // 
            // txtAuthor
            // 
            txtAuthor.Font = new Font("Segoe UI", 18F);
            txtAuthor.Location = new Point(168, 114);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(195, 39);
            txtAuthor.TabIndex = 19;
            // 
            // txtTitle
            // 
            txtTitle.Font = new Font("Segoe UI", 18F);
            txtTitle.Location = new Point(168, 69);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(195, 39);
            txtTitle.TabIndex = 18;
            // 
            // txtId
            // 
            txtId.Font = new Font("Segoe UI", 18F);
            txtId.Location = new Point(168, 12);
            txtId.Name = "txtId";
            txtId.Size = new Size(195, 39);
            txtId.TabIndex = 32;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F);
            label7.Location = new Point(26, 15);
            label7.Name = "label7";
            label7.Size = new Size(34, 32);
            label7.TabIndex = 33;
            label7.Text = "Id";
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnCancel.Location = new Point(112, 444);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(167, 42);
            btnCancel.TabIndex = 34;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // UpdateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 494);
            Controls.Add(btnCancel);
            Controls.Add(label7);
            Controls.Add(txtId);
            Controls.Add(btnUpdate);
            Controls.Add(nudYear);
            Controls.Add(nudPages);
            Controls.Add(cmbCategory);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLoadBook);
            Controls.Add(txtDescription);
            Controls.Add(txtAuthor);
            Controls.Add(txtTitle);
            Name = "UpdateForm";
            Text = "Обновление книги";
            Load += UpdateForm_Load;
            ((System.ComponentModel.ISupportInitialize)nudYear).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPages).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUpdate;
        private NumericUpDown nudYear;
        private NumericUpDown nudPages;
        private ComboBox cmbCategory;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnLoadBook;
        private TextBox txtDescription;
        private TextBox txtAuthor;
        private TextBox txtTitle;
        private TextBox txtId;
        private Label label7;
        private Button btnCancel;
    }
}