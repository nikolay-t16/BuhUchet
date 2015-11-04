namespace BuhUchet
{
  partial class FormPrihodnayaNakadnayaEdit
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
      this.textName = new System.Windows.Forms.TextBox();
      this.textCount = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.textCena = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.comboBoxParent = new System.Windows.Forms.ComboBox();
      this.comboBoxClothes = new System.Windows.Forms.ComboBox();
      this.SuspendLayout();
      // 
      // buttonSave
      // 
      this.buttonSave.Location = new System.Drawing.Point(147, 212);
      this.buttonSave.Name = "buttonSave";
      this.buttonSave.Size = new System.Drawing.Size(75, 23);
      this.buttonSave.TabIndex = 0;
      this.buttonSave.Text = "Сохранить";
      this.buttonSave.UseVisualStyleBackColor = true;
      this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(48, 50);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(60, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Название:";
      // 
      // textName
      // 
      this.textName.Location = new System.Drawing.Point(114, 47);
      this.textName.Name = "textName";
      this.textName.Size = new System.Drawing.Size(169, 20);
      this.textName.TabIndex = 2;
      // 
      // textCount
      // 
      this.textCount.Location = new System.Drawing.Point(114, 77);
      this.textCount.Name = "textCount";
      this.textCount.Size = new System.Drawing.Size(169, 20);
      this.textCount.TabIndex = 4;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(39, 77);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(69, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "Количество:";
      // 
      // textCena
      // 
      this.textCena.Location = new System.Drawing.Point(114, 111);
      this.textCena.Name = "textCena";
      this.textCena.Size = new System.Drawing.Size(169, 20);
      this.textCena.TabIndex = 6;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(72, 111);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(36, 13);
      this.label3.TabIndex = 5;
      this.label3.Text = "Цена:";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(45, 143);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(63, 13);
      this.label4.TabIndex = 7;
      this.label4.Text = "Категория:";
      // 
      // comboBoxParent
      // 
      this.comboBoxParent.FormattingEnabled = true;
      this.comboBoxParent.Items.AddRange(new object[] {
            "Пусто",
            "12"});
      this.comboBoxParent.Location = new System.Drawing.Point(111, 143);
      this.comboBoxParent.Name = "comboBoxParent";
      this.comboBoxParent.Size = new System.Drawing.Size(172, 21);
      this.comboBoxParent.TabIndex = 8;
      this.comboBoxParent.SelectedIndexChanged += new System.EventHandler(this.comboBoxParent_SelectedIndexChanged);
      // 
      // comboBoxClothes
      // 
      this.comboBoxClothes.FormattingEnabled = true;
      this.comboBoxClothes.Items.AddRange(new object[] {
            "Пусто",
            "12"});
      this.comboBoxClothes.Location = new System.Drawing.Point(111, 175);
      this.comboBoxClothes.Name = "comboBoxClothes";
      this.comboBoxClothes.Size = new System.Drawing.Size(172, 21);
      this.comboBoxClothes.TabIndex = 9;
      this.comboBoxClothes.SelectedIndexChanged += new System.EventHandler(this.comboBoxClothes_SelectedIndexChanged);
      // 
      // FormPrihodnayaNakadnayaEdit
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(373, 262);
      this.Controls.Add(this.comboBoxClothes);
      this.Controls.Add(this.comboBoxParent);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.textCena);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.textCount);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.textName);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.buttonSave);
      this.Name = "FormPrihodnayaNakadnayaEdit";
      this.Text = "FormPrihodnayaNakadnayaEdit";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button buttonSave;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox textName;
    private System.Windows.Forms.TextBox textCount;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textCena;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.ComboBox comboBoxParent;
    private System.Windows.Forms.ComboBox comboBoxClothes;
  }
}