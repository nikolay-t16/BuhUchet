namespace BuhUchet
{
  partial class FormClothesList
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
      this.buttonDelete = new System.Windows.Forms.Button();
      this.buttonEdit = new System.Windows.Forms.Button();
      this.buttonAdd = new System.Windows.Forms.Button();
      this.textBoxSearch = new System.Windows.Forms.TextBox();
      this.buttonSearch = new System.Windows.Forms.Button();
      this.dataGridViewClothesSearch = new System.Windows.Forms.DataGridView();
      this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.parent = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.comboBoxParent = new System.Windows.Forms.ComboBox();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClothesSearch)).BeginInit();
      this.SuspendLayout();
      // 
      // buttonDelete
      // 
      this.buttonDelete.Location = new System.Drawing.Point(193, 55);
      this.buttonDelete.Name = "buttonDelete";
      this.buttonDelete.Size = new System.Drawing.Size(75, 23);
      this.buttonDelete.TabIndex = 11;
      this.buttonDelete.Text = "Удалить";
      this.buttonDelete.UseVisualStyleBackColor = true;
      this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
      // 
      // buttonEdit
      // 
      this.buttonEdit.Location = new System.Drawing.Point(93, 54);
      this.buttonEdit.Name = "buttonEdit";
      this.buttonEdit.Size = new System.Drawing.Size(94, 23);
      this.buttonEdit.TabIndex = 10;
      this.buttonEdit.Text = "Редактировать";
      this.buttonEdit.UseVisualStyleBackColor = true;
      this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
      // 
      // buttonAdd
      // 
      this.buttonAdd.Location = new System.Drawing.Point(12, 55);
      this.buttonAdd.Name = "buttonAdd";
      this.buttonAdd.Size = new System.Drawing.Size(75, 23);
      this.buttonAdd.TabIndex = 9;
      this.buttonAdd.Text = "Добавить";
      this.buttonAdd.UseVisualStyleBackColor = true;
      this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
      // 
      // textBoxSearch
      // 
      this.textBoxSearch.Location = new System.Drawing.Point(185, 80);
      this.textBoxSearch.Name = "textBoxSearch";
      this.textBoxSearch.Size = new System.Drawing.Size(389, 20);
      this.textBoxSearch.TabIndex = 8;
      // 
      // buttonSearch
      // 
      this.buttonSearch.Location = new System.Drawing.Point(580, 80);
      this.buttonSearch.Name = "buttonSearch";
      this.buttonSearch.Size = new System.Drawing.Size(75, 20);
      this.buttonSearch.TabIndex = 7;
      this.buttonSearch.Text = "Найти";
      this.buttonSearch.UseVisualStyleBackColor = true;
      this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
      // 
      // dataGridViewClothesSearch
      // 
      this.dataGridViewClothesSearch.AllowUserToAddRows = false;
      this.dataGridViewClothesSearch.AllowUserToDeleteRows = false;
      this.dataGridViewClothesSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewClothesSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.parent,
            this.name});
      this.dataGridViewClothesSearch.Location = new System.Drawing.Point(12, 107);
      this.dataGridViewClothesSearch.Name = "dataGridViewClothesSearch";
      this.dataGridViewClothesSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dataGridViewClothesSearch.Size = new System.Drawing.Size(643, 144);
      this.dataGridViewClothesSearch.TabIndex = 6;
      // 
      // id
      // 
      this.id.HeaderText = "№ а/к";
      this.id.Name = "id";
      this.id.ReadOnly = true;
      // 
      // parent
      // 
      this.parent.HeaderText = "Рубрика";
      this.parent.Name = "parent";
      // 
      // name
      // 
      this.name.HeaderText = "Название";
      this.name.Name = "name";
      this.name.ReadOnly = true;
      // 
      // comboBoxParent
      // 
      this.comboBoxParent.FormattingEnabled = true;
      this.comboBoxParent.Location = new System.Drawing.Point(12, 80);
      this.comboBoxParent.Name = "comboBoxParent";
      this.comboBoxParent.Size = new System.Drawing.Size(167, 21);
      this.comboBoxParent.TabIndex = 12;
      // 
      // FormClothesList
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(707, 348);
      this.Controls.Add(this.comboBoxParent);
      this.Controls.Add(this.buttonDelete);
      this.Controls.Add(this.buttonEdit);
      this.Controls.Add(this.buttonAdd);
      this.Controls.Add(this.textBoxSearch);
      this.Controls.Add(this.buttonSearch);
      this.Controls.Add(this.dataGridViewClothesSearch);
      this.Name = "FormClothesList";
      this.Text = "FormClothesList";
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClothesSearch)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button buttonDelete;
    private System.Windows.Forms.Button buttonEdit;
    private System.Windows.Forms.Button buttonAdd;
    private System.Windows.Forms.TextBox textBoxSearch;
    private System.Windows.Forms.Button buttonSearch;
    private System.Windows.Forms.DataGridView dataGridViewClothesSearch;
    private System.Windows.Forms.DataGridViewTextBoxColumn id;
    private System.Windows.Forms.DataGridViewTextBoxColumn parent;
    private System.Windows.Forms.DataGridViewTextBoxColumn name;
    private System.Windows.Forms.ComboBox comboBoxParent;
  }
}