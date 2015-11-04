namespace BuhUchet
{
  partial class FormPrihodnayaNaklodnaya
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
      this.buttonSave = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.textBoxNomer = new System.Windows.Forms.TextBox();
      this.labelCreateDate = new System.Windows.Forms.Label();
      this.dateTimePickerCreateDate = new System.Windows.Forms.DateTimePicker();
      this.buttonDelete = new System.Windows.Forms.Button();
      this.buttonEdit = new System.Windows.Forms.Button();
      this.buttonAdd = new System.Windows.Forms.Button();
      this.dataGridViewList = new System.Windows.Forms.DataGridView();
      this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.id_clothes = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.group_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).BeginInit();
      this.SuspendLayout();
      // 
      // buttonSave
      // 
      this.buttonSave.Location = new System.Drawing.Point(104, 81);
      this.buttonSave.Name = "buttonSave";
      this.buttonSave.Size = new System.Drawing.Size(75, 23);
      this.buttonSave.TabIndex = 0;
      this.buttonSave.Text = "Сохранить";
      this.buttonSave.UseVisualStyleBackColor = true;
      this.buttonSave.Click += new System.EventHandler(this.button1_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(54, 32);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(44, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Номер:";
      // 
      // textBoxNomer
      // 
      this.textBoxNomer.Location = new System.Drawing.Point(105, 29);
      this.textBoxNomer.Name = "textBoxNomer";
      this.textBoxNomer.Size = new System.Drawing.Size(199, 20);
      this.textBoxNomer.TabIndex = 2;
      // 
      // labelCreateDate
      // 
      this.labelCreateDate.AutoSize = true;
      this.labelCreateDate.Location = new System.Drawing.Point(12, 61);
      this.labelCreateDate.Name = "labelCreateDate";
      this.labelCreateDate.Size = new System.Drawing.Size(87, 13);
      this.labelCreateDate.TabIndex = 14;
      this.labelCreateDate.Text = "Дата создания:";
      // 
      // dateTimePickerCreateDate
      // 
      this.dateTimePickerCreateDate.Location = new System.Drawing.Point(104, 55);
      this.dateTimePickerCreateDate.MaxDate = new System.DateTime(2115, 10, 31, 0, 0, 0, 0);
      this.dateTimePickerCreateDate.Name = "dateTimePickerCreateDate";
      this.dateTimePickerCreateDate.Size = new System.Drawing.Size(200, 20);
      this.dateTimePickerCreateDate.TabIndex = 13;
      this.dateTimePickerCreateDate.Value = new System.DateTime(2015, 10, 19, 0, 0, 0, 0);
      // 
      // buttonDelete
      // 
      this.buttonDelete.Location = new System.Drawing.Point(216, 109);
      this.buttonDelete.Name = "buttonDelete";
      this.buttonDelete.Size = new System.Drawing.Size(75, 23);
      this.buttonDelete.TabIndex = 18;
      this.buttonDelete.Text = "Удалить";
      this.buttonDelete.UseVisualStyleBackColor = true;
      this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
      // 
      // buttonEdit
      // 
      this.buttonEdit.Location = new System.Drawing.Point(105, 108);
      this.buttonEdit.Name = "buttonEdit";
      this.buttonEdit.Size = new System.Drawing.Size(105, 23);
      this.buttonEdit.TabIndex = 17;
      this.buttonEdit.Text = "Редактировать";
      this.buttonEdit.UseVisualStyleBackColor = true;
      this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
      // 
      // buttonAdd
      // 
      this.buttonAdd.Location = new System.Drawing.Point(23, 109);
      this.buttonAdd.Name = "buttonAdd";
      this.buttonAdd.Size = new System.Drawing.Size(75, 23);
      this.buttonAdd.TabIndex = 16;
      this.buttonAdd.Text = "Добавить";
      this.buttonAdd.UseVisualStyleBackColor = true;
      this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
      // 
      // dataGridViewList
      // 
      this.dataGridViewList.AllowUserToAddRows = false;
      this.dataGridViewList.AllowUserToDeleteRows = false;
      this.dataGridViewList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
      this.dataGridViewList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
      this.dataGridViewList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.id_clothes,
            this.name,
            this.group_name,
            this.count,
            this.price});
      this.dataGridViewList.Location = new System.Drawing.Point(23, 138);
      this.dataGridViewList.Name = "dataGridViewList";
      this.dataGridViewList.ReadOnly = true;
      this.dataGridViewList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dataGridViewList.Size = new System.Drawing.Size(621, 125);
      this.dataGridViewList.TabIndex = 15;
      // 
      // id
      // 
      this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.id.HeaderText = "id";
      this.id.Name = "id";
      this.id.ReadOnly = true;
      this.id.Visible = false;
      this.id.Width = 40;
      // 
      // id_clothes
      // 
      this.id_clothes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.id_clothes.HeaderText = "id_clothes";
      this.id_clothes.Name = "id_clothes";
      this.id_clothes.ReadOnly = true;
      this.id_clothes.Visible = false;
      this.id_clothes.Width = 80;
      // 
      // name
      // 
      this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.name.HeaderText = "Название";
      this.name.Name = "name";
      this.name.ReadOnly = true;
      this.name.Width = 82;
      // 
      // group_name
      // 
      this.group_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.group_name.HeaderText = "Группа";
      this.group_name.Name = "group_name";
      this.group_name.ReadOnly = true;
      this.group_name.Width = 67;
      // 
      // count
      // 
      this.count.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.count.HeaderText = "Количество";
      this.count.Name = "count";
      this.count.ReadOnly = true;
      this.count.Width = 91;
      // 
      // price
      // 
      this.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.price.HeaderText = "Цена за еденицу";
      this.price.Name = "price";
      this.price.ReadOnly = true;
      this.price.Width = 107;
      // 
      // FormPrihodnayaNaklodnaya
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(656, 350);
      this.Controls.Add(this.buttonDelete);
      this.Controls.Add(this.buttonEdit);
      this.Controls.Add(this.buttonAdd);
      this.Controls.Add(this.dataGridViewList);
      this.Controls.Add(this.labelCreateDate);
      this.Controls.Add(this.dateTimePickerCreateDate);
      this.Controls.Add(this.textBoxNomer);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.buttonSave);
      this.Name = "FormPrihodnayaNaklodnaya";
      this.Text = "FormPrihodnayaNaklodnaya";
      this.Load += new System.EventHandler(this.FormPrihodnayaNaklodnaya_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button buttonSave;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox textBoxNomer;
    private System.Windows.Forms.Label labelCreateDate;
    private System.Windows.Forms.DateTimePicker dateTimePickerCreateDate;
    private System.Windows.Forms.Button buttonDelete;
    private System.Windows.Forms.Button buttonEdit;
    private System.Windows.Forms.Button buttonAdd;
    private System.Windows.Forms.DataGridView dataGridViewList;
    private System.Windows.Forms.DataGridViewTextBoxColumn id;
    private System.Windows.Forms.DataGridViewTextBoxColumn id_clothes;
    private System.Windows.Forms.DataGridViewTextBoxColumn name;
    private System.Windows.Forms.DataGridViewTextBoxColumn group_name;
    private System.Windows.Forms.DataGridViewTextBoxColumn count;
    private System.Windows.Forms.DataGridViewTextBoxColumn price;
  }
}