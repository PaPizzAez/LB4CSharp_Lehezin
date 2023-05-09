namespace LB4
{
  partial class FORMA
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addNewEmptyRow = new System.Windows.Forms.Button();
            this.authorsCombobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.newAuthorName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.changeAuthor = new System.Windows.Forms.Button();
            this.deleteAuthor = new System.Windows.Forms.Button();
            this.addAuthor = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addPublisher = new System.Windows.Forms.Button();
            this.publishersCombobox = new System.Windows.Forms.ComboBox();
            this.deletePublisher = new System.Windows.Forms.Button();
            this.newPublisherName = new System.Windows.Forms.TextBox();
            this.changePublisher = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.import = new System.Windows.Forms.Button();
            this.export = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(168, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(656, 616);
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EditBook_CellClick);
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.SortTable);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.DelOnClick);
            // 
            // addNewEmptyRow
            // 
            this.addNewEmptyRow.Location = new System.Drawing.Point(12, 164);
            this.addNewEmptyRow.Name = "addNewEmptyRow";
            this.addNewEmptyRow.Size = new System.Drawing.Size(131, 40);
            this.addNewEmptyRow.TabIndex = 1;
            this.addNewEmptyRow.Text = "Новий рядок";
            this.addNewEmptyRow.UseVisualStyleBackColor = true;
            this.addNewEmptyRow.Click += new System.EventHandler(this.NewRow);
            // 
            // authorsCombobox
            // 
            this.authorsCombobox.FormattingEnabled = true;
            this.authorsCombobox.Location = new System.Drawing.Point(17, 47);
            this.authorsCombobox.Name = "authorsCombobox";
            this.authorsCombobox.Size = new System.Drawing.Size(169, 23);
            this.authorsCombobox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Автор";
            // 
            // newAuthorName
            // 
            this.newAuthorName.Location = new System.Drawing.Point(17, 134);
            this.newAuthorName.Name = "newAuthorName";
            this.newAuthorName.Size = new System.Drawing.Size(169, 23);
            this.newAuthorName.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Нове ім\'я";
            // 
            // changeAuthor
            // 
            this.changeAuthor.Location = new System.Drawing.Point(17, 178);
            this.changeAuthor.Name = "changeAuthor";
            this.changeAuthor.Size = new System.Drawing.Size(75, 23);
            this.changeAuthor.TabIndex = 8;
            this.changeAuthor.Text = "Змінити";
            this.changeAuthor.UseVisualStyleBackColor = true;
            this.changeAuthor.Click += new System.EventHandler(this.changeAuthorButton);
            // 
            // deleteAuthor
            // 
            this.deleteAuthor.Location = new System.Drawing.Point(111, 178);
            this.deleteAuthor.Name = "deleteAuthor";
            this.deleteAuthor.Size = new System.Drawing.Size(75, 23);
            this.deleteAuthor.TabIndex = 9;
            this.deleteAuthor.Text = "Видалити";
            this.deleteAuthor.UseVisualStyleBackColor = true;
            this.deleteAuthor.Click += new System.EventHandler(this.delete_Author);
            // 
            // addAuthor
            // 
            this.addAuthor.Location = new System.Drawing.Point(17, 226);
            this.addAuthor.Name = "addAuthor";
            this.addAuthor.Size = new System.Drawing.Size(169, 47);
            this.addAuthor.TabIndex = 10;
            this.addAuthor.Text = "Добавити як нового";
            this.addAuthor.UseVisualStyleBackColor = true;
            this.addAuthor.Click += new System.EventHandler(this.addtheAuthor);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.addAuthor);
            this.groupBox1.Controls.Add(this.authorsCombobox);
            this.groupBox1.Controls.Add(this.deleteAuthor);
            this.groupBox1.Controls.Add(this.newAuthorName);
            this.groupBox1.Controls.Add(this.changeAuthor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(841, 294);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 279);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Автори";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.addPublisher);
            this.groupBox2.Controls.Add(this.publishersCombobox);
            this.groupBox2.Controls.Add(this.deletePublisher);
            this.groupBox2.Controls.Add(this.newPublisherName);
            this.groupBox2.Controls.Add(this.changePublisher);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(841, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(204, 249);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Видавництва";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Видавництво";
            // 
            // addPublisher
            // 
            this.addPublisher.Location = new System.Drawing.Point(6, 203);
            this.addPublisher.Name = "addPublisher";
            this.addPublisher.Size = new System.Drawing.Size(192, 39);
            this.addPublisher.TabIndex = 10;
            this.addPublisher.Text = "Добавити як нове ";
            this.addPublisher.UseVisualStyleBackColor = true;
            this.addPublisher.Click += new System.EventHandler(this.addthePublisher);
            // 
            // publishersCombobox
            // 
            this.publishersCombobox.FormattingEnabled = true;
            this.publishersCombobox.Location = new System.Drawing.Point(17, 52);
            this.publishersCombobox.Name = "publishersCombobox";
            this.publishersCombobox.Size = new System.Drawing.Size(169, 23);
            this.publishersCombobox.TabIndex = 4;
            // 
            // deletePublisher
            // 
            this.deletePublisher.Location = new System.Drawing.Point(123, 163);
            this.deletePublisher.Name = "deletePublisher";
            this.deletePublisher.Size = new System.Drawing.Size(75, 23);
            this.deletePublisher.TabIndex = 9;
            this.deletePublisher.Text = "Видалити";
            this.deletePublisher.UseVisualStyleBackColor = true;
            this.deletePublisher.Click += new System.EventHandler(this.delete_Publisher);
            // 
            // newPublisherName
            // 
            this.newPublisherName.Location = new System.Drawing.Point(17, 124);
            this.newPublisherName.Name = "newPublisherName";
            this.newPublisherName.Size = new System.Drawing.Size(169, 23);
            this.newPublisherName.TabIndex = 6;
            // 
            // changePublisher
            // 
            this.changePublisher.Location = new System.Drawing.Point(6, 163);
            this.changePublisher.Name = "changePublisher";
            this.changePublisher.Size = new System.Drawing.Size(75, 23);
            this.changePublisher.TabIndex = 8;
            this.changePublisher.Text = "Змінити";
            this.changePublisher.UseVisualStyleBackColor = true;
            this.changePublisher.Click += new System.EventHandler(this.СhangePublishers);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Нове ім\'я";
            // 
            // import
            // 
            this.import.Location = new System.Drawing.Point(12, 102);
            this.import.Name = "import";
            this.import.Size = new System.Drawing.Size(131, 39);
            this.import.TabIndex = 13;
            this.import.Text = "Вставити";
            this.import.UseVisualStyleBackColor = true;
            this.import.Click += new System.EventHandler(this.Import_json);
            // 
            // export
            // 
            this.export.Location = new System.Drawing.Point(12, 39);
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(131, 39);
            this.export.TabIndex = 14;
            this.export.Text = "Зберегти";
            this.export.UseVisualStyleBackColor = true;
            this.export.Click += new System.EventHandler(this.Export_json);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(12, 229);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(131, 39);
            this.clear.TabIndex = 15;
            this.clear.Text = "Видалити все";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // FORMA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 695);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.export);
            this.Controls.Add(this.import);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.addNewEmptyRow);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FORMA";
            this.Text = "LB4";
            this.Load += new System.EventHandler(this.FormaLoading);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion

    private DataGridView dataGridView1;
    private Button addNewEmptyRow;
    private ComboBox authorsCombobox;
    private Label label1;
    private TextBox newAuthorName;
    private Label label2;
    private Button changeAuthor;
    private Button deleteAuthor;
    private Button addAuthor;
    private GroupBox groupBox1;
    private GroupBox groupBox2;
    private Label label3;
    private Button addPublisher;
    private ComboBox publishersCombobox;
    private Button deletePublisher;
    private TextBox newPublisherName;
    private Button changePublisher;
    private Label label4;
    private Button import;
    private Button export;
    private Button clear;
  }
}