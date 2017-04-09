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
      this.textBoxEdIzm = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.textBoxSrok = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.textBoxNormaVidachi = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // labelName
      // 
      this.labelName.AutoSize = true;
      this.labelName.Location = new System.Drawing.Point(46, 48);
      this.labelName.Name = "labelName";
      this.labelName.Size = new System.Drawing.Size(60, 13);
      this.labelName.TabIndex = 0;
      this.labelName.Text = "Название:";
      // 
      // labelParent
      // 
      this.labelParent.AutoSize = true;
      this.labelParent.Location = new System.Drawing.Point(43, 74);
      this.labelParent.Name = "labelParent";
      this.labelParent.Size = new System.Drawing.Size(63, 13);
      this.labelParent.TabIndex = 1;
      this.labelParent.Text = "Категория:";
      // 
      // textBoxName
      // 
      this.textBoxName.Location = new System.Drawing.Point(112, 45);
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
      this.comboBoxParent.Location = new System.Drawing.Point(112, 71);
      this.comboBoxParent.Name = "comboBoxParent";
      this.comboBoxParent.Size = new System.Drawing.Size(172, 21);
      this.comboBoxParent.TabIndex = 3;
      // 
      // buttonEdit
      // 
      this.buttonEdit.Location = new System.Drawing.Point(209, 176);
      this.buttonEdit.Name = "buttonEdit";
      this.buttonEdit.Size = new System.Drawing.Size(75, 23);
      this.buttonEdit.TabIndex = 4;
      this.buttonEdit.Text = "Сохранить";
      this.buttonEdit.UseVisualStyleBackColor = true;
      this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
      // 
      // textBoxEdIzm
      // 
      this.textBoxEdIzm.Location = new System.Drawing.Point(112, 98);
      this.textBoxEdIzm.Name = "textBoxEdIzm";
      this.textBoxEdIzm.Size = new System.Drawing.Size(172, 20);
      this.textBoxEdIzm.TabIndex = 6;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(21, 98);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(85, 13);
      this.label1.TabIndex = 5;
      this.label1.Text = "Ед. измерения:";
      // 
      // textBoxSrok
      // 
      this.textBoxSrok.Location = new System.Drawing.Point(112, 124);
      this.textBoxSrok.Name = "textBoxSrok";
      this.textBoxSrok.Size = new System.Drawing.Size(172, 20);
      this.textBoxSrok.TabIndex = 8;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(27, 127);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(79, 13);
      this.label2.TabIndex = 7;
      this.label2.Text = "Срок носки(г):";
      // 
      // textBoxNormaVidachi
      // 
      this.textBoxNormaVidachi.Location = new System.Drawing.Point(112, 150);
      this.textBoxNormaVidachi.Name = "textBoxNormaVidachi";
      this.textBoxNormaVidachi.Size = new System.Drawing.Size(172, 20);
      this.textBoxNormaVidachi.TabIndex = 9;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(22, 153);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(84, 13);
      this.label3.TabIndex = 10;
      this.label3.Text = "Норма выдачи:";
      // 
      // FormClothesEdit
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(317, 266);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.textBoxNormaVidachi);
      this.Controls.Add(this.textBoxSrok);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.textBoxEdIzm);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.buttonEdit);
      this.Controls.Add(this.comboBoxParent);
      this.Controls.Add(this.textBoxName);
      this.Controls.Add(this.labelParent);
      this.Controls.Add(this.labelName);
      this.Name = "FormClothesEdit";
      this.Text = "FormClothesEdit";
      this.Load += new System.EventHandler(this.FormClothesEdit_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label labelName;
    private System.Windows.Forms.Label labelParent;
    private System.Windows.Forms.TextBox textBoxName;
    private System.Windows.Forms.ComboBox comboBoxParent;
    private System.Windows.Forms.Button buttonEdit;
    private System.Windows.Forms.TextBox textBoxEdIzm;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox textBoxSrok;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textBoxNormaVidachi;
    private System.Windows.Forms.Label label3;
  }
}