namespace BuhUchet
{
  partial class FormOrder
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
      this.buttonSearch = new System.Windows.Forms.Button();
      this.textBoxSearch = new System.Windows.Forms.TextBox();
      this.dataGridViewList = new System.Windows.Forms.DataGridView();
      this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.buttonAdd = new System.Windows.Forms.Button();
      this.buttonEdit = new System.Windows.Forms.Button();
      this.buttonDel = new System.Windows.Forms.Button();
      this.CreateFile = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).BeginInit();
      this.SuspendLayout();
      // 
      // buttonSearch
      // 
      this.buttonSearch.Location = new System.Drawing.Point(393, 48);
      this.buttonSearch.Name = "buttonSearch";
      this.buttonSearch.Size = new System.Drawing.Size(75, 23);
      this.buttonSearch.TabIndex = 0;
      this.buttonSearch.Text = "Найти";
      this.buttonSearch.UseVisualStyleBackColor = true;
      this.buttonSearch.Click += new System.EventHandler(this.buttonSerch_Click);
      // 
      // textBoxSearch
      // 
      this.textBoxSearch.Location = new System.Drawing.Point(67, 48);
      this.textBoxSearch.Name = "textBoxSearch";
      this.textBoxSearch.Size = new System.Drawing.Size(306, 20);
      this.textBoxSearch.TabIndex = 1;
      // 
      // dataGridViewList
      // 
      this.dataGridViewList.AllowUserToAddRows = false;
      this.dataGridViewList.AllowUserToDeleteRows = false;
      this.dataGridViewList.AllowUserToOrderColumns = true;
      this.dataGridViewList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
      this.dataGridViewList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
      this.dataGridViewList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.date,
            this.name});
      this.dataGridViewList.Location = new System.Drawing.Point(67, 102);
      this.dataGridViewList.Name = "dataGridViewList";
      this.dataGridViewList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dataGridViewList.Size = new System.Drawing.Size(401, 150);
      this.dataGridViewList.TabIndex = 2;
      // 
      // id
      // 
      this.id.HeaderText = "Id";
      this.id.Name = "id";
      this.id.Width = 41;
      // 
      // date
      // 
      this.date.HeaderText = "Дата";
      this.date.Name = "date";
      this.date.Width = 58;
      // 
      // name
      // 
      this.name.HeaderText = "Фио";
      this.name.Name = "name";
      this.name.Width = 55;
      // 
      // buttonAdd
      // 
      this.buttonAdd.Location = new System.Drawing.Point(67, 75);
      this.buttonAdd.Name = "buttonAdd";
      this.buttonAdd.Size = new System.Drawing.Size(75, 23);
      this.buttonAdd.TabIndex = 3;
      this.buttonAdd.Text = "Добавить";
      this.buttonAdd.UseVisualStyleBackColor = true;
      this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
      // 
      // buttonEdit
      // 
      this.buttonEdit.Location = new System.Drawing.Point(149, 75);
      this.buttonEdit.Name = "buttonEdit";
      this.buttonEdit.Size = new System.Drawing.Size(105, 23);
      this.buttonEdit.TabIndex = 4;
      this.buttonEdit.Text = "Редактировать";
      this.buttonEdit.UseVisualStyleBackColor = true;
      this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
      // 
      // buttonDel
      // 
      this.buttonDel.Location = new System.Drawing.Point(260, 75);
      this.buttonDel.Name = "buttonDel";
      this.buttonDel.Size = new System.Drawing.Size(75, 23);
      this.buttonDel.TabIndex = 5;
      this.buttonDel.Text = "Удалить";
      this.buttonDel.UseVisualStyleBackColor = true;
      this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
      // 
      // CreateFile
      // 
      this.CreateFile.Location = new System.Drawing.Point(341, 75);
      this.CreateFile.Name = "CreateFile";
      this.CreateFile.Size = new System.Drawing.Size(107, 23);
      this.CreateFile.TabIndex = 6;
      this.CreateFile.Text = "Создать файл";
      this.CreateFile.UseVisualStyleBackColor = true;
      this.CreateFile.Click += new System.EventHandler(this.CreateFile_Click);
      // 
      // FormOrder
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(695, 308);
      this.Controls.Add(this.CreateFile);
      this.Controls.Add(this.buttonDel);
      this.Controls.Add(this.buttonEdit);
      this.Controls.Add(this.buttonAdd);
      this.Controls.Add(this.dataGridViewList);
      this.Controls.Add(this.textBoxSearch);
      this.Controls.Add(this.buttonSearch);
      this.Name = "FormOrder";
      this.Text = "FormOrder";
      this.Load += new System.EventHandler(this.FormOrder_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button buttonSearch;
    private System.Windows.Forms.TextBox textBoxSearch;
    private System.Windows.Forms.DataGridView dataGridViewList;
    private System.Windows.Forms.Button buttonAdd;
    private System.Windows.Forms.Button buttonEdit;
    private System.Windows.Forms.Button buttonDel;
    private System.Windows.Forms.DataGridViewTextBoxColumn id;
    private System.Windows.Forms.DataGridViewTextBoxColumn date;
    private System.Windows.Forms.DataGridViewTextBoxColumn name;
    private System.Windows.Forms.Button CreateFile;
  }
}