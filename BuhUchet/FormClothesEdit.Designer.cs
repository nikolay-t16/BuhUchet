namespace BuhUchet
{
  partial class FormClothesEdit
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
      this.labelName = new System.Windows.Forms.Label();
      this.labelParent = new System.Windows.Forms.Label();
      this.textBoxName = new System.Windows.Forms.TextBox();
      this.comboBoxParent = new System.Windows.Forms.ComboBox();
      this.buttonEdit = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // labelName
      // 
      this.labelName.AutoSize = true;
      this.labelName.Location = new System.Drawing.Point(22, 50);
      this.labelName.Name = "labelName";
      this.labelName.Size = new System.Drawing.Size(60, 13);
      this.labelName.TabIndex = 0;
      this.labelName.Text = "Название:";
      // 
      // labelParent
      // 
      this.labelParent.AutoSize = true;
      this.labelParent.Location = new System.Drawing.Point(19, 92);
      this.labelParent.Name = "labelParent";
      this.labelParent.Size = new System.Drawing.Size(63, 13);
      this.labelParent.TabIndex = 1;
      this.labelParent.Text = "Категория:";
      // 
      // textBoxName
      // 
      this.textBoxName.Location = new System.Drawing.Point(88, 47);
      this.textBoxName.Name = "textBoxName";
      this.textBoxName.Size = new System.Drawing.Size(172, 20);
      this.textBoxName.TabIndex = 2;
      // 
      // comboBoxParent
      // 
      this.comboBoxParent.FormattingEnabled = true;
      this.comboBoxParent.Items.AddRange(new object[] {
            "Пусто",
            "12"});
      this.comboBoxParent.Location = new System.Drawing.Point(88, 89);
      this.comboBoxParent.Name = "comboBoxParent";
      this.comboBoxParent.Size = new System.Drawing.Size(172, 21);
      this.comboBoxParent.TabIndex = 3;
      // 
      // buttonEdit
      // 
      this.buttonEdit.Location = new System.Drawing.Point(185, 127);
      this.buttonEdit.Name = "buttonEdit";
      this.buttonEdit.Size = new System.Drawing.Size(75, 23);
      this.buttonEdit.TabIndex = 4;
      this.buttonEdit.Text = "Сохранить";
      this.buttonEdit.UseVisualStyleBackColor = true;
      this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
      // 
      // FormClothesEdit
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(317, 266);
      this.Controls.Add(this.buttonEdit);
      this.Controls.Add(this.comboBoxParent);
      this.Controls.Add(this.textBoxName);
      this.Controls.Add(this.labelParent);
      this.Controls.Add(this.labelName);
      this.Name = "FormClothesEdit";
      this.Text = "FormClothesEdit";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label labelName;
    private System.Windows.Forms.Label labelParent;
    private System.Windows.Forms.TextBox textBoxName;
    private System.Windows.Forms.ComboBox comboBoxParent;
    private System.Windows.Forms.Button buttonEdit;
  }
}