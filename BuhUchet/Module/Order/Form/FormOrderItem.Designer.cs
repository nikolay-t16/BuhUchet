namespace BuhUchet
{
  partial class FormOrderItem
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
      this.buttonAdd = new System.Windows.Forms.Button();
      this.buttonSave = new System.Windows.Forms.Button();
      this.buttonDel = new System.Windows.Forms.Button();
      this.buttonEdit = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.comboBoxChild = new System.Windows.Forms.ComboBox();
      this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
      this.dataGridView = new System.Windows.Forms.DataGridView();
      this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.id_order = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.clothes = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
      this.SuspendLayout();
      // 
      // buttonAdd
      // 
      this.buttonAdd.Location = new System.Drawing.Point(71, 138);
      this.buttonAdd.Name = "buttonAdd";
      this.buttonAdd.Size = new System.Drawing.Size(75, 23);
      this.buttonAdd.TabIndex = 0;
      this.buttonAdd.Text = "Добавить";
      this.buttonAdd.UseVisualStyleBackColor = true;
      this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
      // 
      // buttonSave
      // 
      this.buttonSave.Location = new System.Drawing.Point(271, 84);
      this.buttonSave.Name = "buttonSave";
      this.buttonSave.Size = new System.Drawing.Size(75, 23);
      this.buttonSave.TabIndex = 1;
      this.buttonSave.Text = "Сохранить";
      this.buttonSave.UseVisualStyleBackColor = true;
      this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
      // 
      // buttonDel
      // 
      this.buttonDel.Location = new System.Drawing.Point(271, 138);
      this.buttonDel.Name = "buttonDel";
      this.buttonDel.Size = new System.Drawing.Size(75, 23);
      this.buttonDel.TabIndex = 2;
      this.buttonDel.Text = "Удалить";
      this.buttonDel.UseVisualStyleBackColor = true;
      this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
      // 
      // buttonEdit
      // 
      this.buttonEdit.Location = new System.Drawing.Point(163, 138);
      this.buttonEdit.Name = "buttonEdit";
      this.buttonEdit.Size = new System.Drawing.Size(92, 23);
      this.buttonEdit.TabIndex = 3;
      this.buttonEdit.Text = "Редактировать";
      this.buttonEdit.UseVisualStyleBackColor = true;
      this.buttonEdit.Click += new System.EventHandler(this.button4_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(84, 31);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(33, 13);
      this.label1.TabIndex = 6;
      this.label1.Text = "Дата";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(87, 60);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(30, 13);
      this.label2.TabIndex = 7;
      this.label2.Text = "Фио";
      // 
      // comboBoxChild
      // 
      this.comboBoxChild.FormattingEnabled = true;
      this.comboBoxChild.Location = new System.Drawing.Point(123, 57);
      this.comboBoxChild.Name = "comboBoxChild";
      this.comboBoxChild.Size = new System.Drawing.Size(223, 21);
      this.comboBoxChild.TabIndex = 8;
      // 
      // dateTimePicker
      // 
      this.dateTimePicker.Location = new System.Drawing.Point(123, 25);
      this.dateTimePicker.Name = "dateTimePicker";
      this.dateTimePicker.Size = new System.Drawing.Size(223, 20);
      this.dateTimePicker.TabIndex = 9;
      // 
      // dataGridView
      // 
      this.dataGridView.AllowUserToAddRows = false;
      this.dataGridView.AllowUserToDeleteRows = false;
      this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
      this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.id_order,
            this.clothes,
            this.count});
      this.dataGridView.Location = new System.Drawing.Point(12, 178);
      this.dataGridView.Name = "dataGridView";
      this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dataGridView.Size = new System.Drawing.Size(500, 150);
      this.dataGridView.TabIndex = 10;
      // 
      // id
      // 
      this.id.HeaderText = "Id";
      this.id.Name = "id";
      this.id.ReadOnly = true;
      this.id.Visible = false;
      // 
      // id_order
      // 
      this.id_order.HeaderText = "id_order";
      this.id_order.Name = "id_order";
      this.id_order.Visible = false;
      // 
      // clothes
      // 
      this.clothes.HeaderText = "Одежда";
      this.clothes.Name = "clothes";
      this.clothes.ReadOnly = true;
      this.clothes.Width = 72;
      // 
      // count
      // 
      this.count.HeaderText = "Кол-во";
      this.count.Name = "count";
      this.count.ReadOnly = true;
      this.count.Width = 66;
      // 
      // FormOrderItem
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(540, 421);
      this.Controls.Add(this.dataGridView);
      this.Controls.Add(this.dateTimePicker);
      this.Controls.Add(this.comboBoxChild);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.buttonEdit);
      this.Controls.Add(this.buttonDel);
      this.Controls.Add(this.buttonSave);
      this.Controls.Add(this.buttonAdd);
      this.Name = "FormOrderItem";
      this.Text = "Ы";
      this.Load += new System.EventHandler(this.FormOrderItem_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button buttonAdd;
    private System.Windows.Forms.Button buttonSave;
    private System.Windows.Forms.Button buttonDel;
    private System.Windows.Forms.Button buttonEdit;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ComboBox comboBoxChild;
    private System.Windows.Forms.DateTimePicker dateTimePicker;
    private System.Windows.Forms.DataGridView dataGridView;
    private System.Windows.Forms.DataGridViewTextBoxColumn id;
    private System.Windows.Forms.DataGridViewTextBoxColumn id_order;
    private System.Windows.Forms.DataGridViewTextBoxColumn clothes;
    private System.Windows.Forms.DataGridViewTextBoxColumn count;
  }
}