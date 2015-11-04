namespace BuhUchet
{
  partial class FormPrihodnayaNaklodnayaSpisok
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
      this.dataGridViewList = new System.Windows.Forms.DataGridView();
      this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.nomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.buttonAdd = new System.Windows.Forms.Button();
      this.buttonOpen = new System.Windows.Forms.Button();
      this.buttonDelete = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).BeginInit();
      this.SuspendLayout();
      // 
      // dataGridViewList
      // 
      this.dataGridViewList.AllowUserToAddRows = false;
      this.dataGridViewList.AllowUserToDeleteRows = false;
      this.dataGridViewList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nomer,
            this.date});
      this.dataGridViewList.Location = new System.Drawing.Point(53, 82);
      this.dataGridViewList.Name = "dataGridViewList";
      this.dataGridViewList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dataGridViewList.Size = new System.Drawing.Size(337, 125);
      this.dataGridViewList.TabIndex = 0;
      // 
      // id
      // 
      this.id.HeaderText = "id";
      this.id.Name = "id";
      this.id.Visible = false;
      // 
      // nomer
      // 
      this.nomer.HeaderText = "Номер";
      this.nomer.Name = "nomer";
      this.nomer.ReadOnly = true;
      this.nomer.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      // 
      // date
      // 
      this.date.HeaderText = "Дата";
      this.date.Name = "date";
      this.date.ReadOnly = true;
      // 
      // buttonAdd
      // 
      this.buttonAdd.Location = new System.Drawing.Point(53, 53);
      this.buttonAdd.Name = "buttonAdd";
      this.buttonAdd.Size = new System.Drawing.Size(75, 23);
      this.buttonAdd.TabIndex = 1;
      this.buttonAdd.Text = "Добавить";
      this.buttonAdd.UseVisualStyleBackColor = true;
      this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
      // 
      // buttonOpen
      // 
      this.buttonOpen.Location = new System.Drawing.Point(135, 52);
      this.buttonOpen.Name = "buttonOpen";
      this.buttonOpen.Size = new System.Drawing.Size(75, 23);
      this.buttonOpen.TabIndex = 2;
      this.buttonOpen.Text = "Открыть";
      this.buttonOpen.UseVisualStyleBackColor = true;
      this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
      // 
      // buttonDelete
      // 
      this.buttonDelete.Location = new System.Drawing.Point(217, 53);
      this.buttonDelete.Name = "buttonDelete";
      this.buttonDelete.Size = new System.Drawing.Size(75, 23);
      this.buttonDelete.TabIndex = 3;
      this.buttonDelete.Text = "Удалить";
      this.buttonDelete.UseVisualStyleBackColor = true;
      // 
      // FormPrihodnayaNaklodnayaSpisok
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(610, 295);
      this.Controls.Add(this.buttonDelete);
      this.Controls.Add(this.buttonOpen);
      this.Controls.Add(this.buttonAdd);
      this.Controls.Add(this.dataGridViewList);
      this.Name = "FormPrihodnayaNaklodnayaSpisok";
      this.Text = "FormPrihodnayaNaklodnayaSpisok";
      this.Load += new System.EventHandler(this.FormPrihodnayaNaklodnayaSpisok_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewList)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView dataGridViewList;
    private System.Windows.Forms.Button buttonAdd;
    private System.Windows.Forms.Button buttonOpen;
    private System.Windows.Forms.Button buttonDelete;
    private System.Windows.Forms.DataGridViewTextBoxColumn id;
    private System.Windows.Forms.DataGridViewTextBoxColumn nomer;
    private System.Windows.Forms.DataGridViewTextBoxColumn date;
  }
}