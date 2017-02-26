namespace BuhUchet
{
  partial class FormOrderItemEdit
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
      this.comboBoxParent = new System.Windows.Forms.ComboBox();
      this.label4 = new System.Windows.Forms.Label();
      this.comboBoxCount = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.comboBoxClothes = new System.Windows.Forms.ComboBox();
      this.Save = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // comboBoxParent
      // 
      this.comboBoxParent.FormattingEnabled = true;
      this.comboBoxParent.Items.AddRange(new object[] {
            "Пусто",
            "12"});
      this.comboBoxParent.Location = new System.Drawing.Point(92, 22);
      this.comboBoxParent.Name = "comboBoxParent";
      this.comboBoxParent.Size = new System.Drawing.Size(172, 21);
      this.comboBoxParent.TabIndex = 11;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(20, 30);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(66, 13);
      this.label4.TabIndex = 10;
      this.label4.Text = "Накладная:";
      // 
      // comboBoxCount
      // 
      this.comboBoxCount.FormattingEnabled = true;
      this.comboBoxCount.Items.AddRange(new object[] {
            "Пусто",
            "12"});
      this.comboBoxCount.Location = new System.Drawing.Point(92, 84);
      this.comboBoxCount.Name = "comboBoxCount";
      this.comboBoxCount.Size = new System.Drawing.Size(172, 21);
      this.comboBoxCount.TabIndex = 13;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(36, 60);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(50, 13);
      this.label1.TabIndex = 14;
      this.label1.Text = "Одежда:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(17, 87);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(69, 13);
      this.label2.TabIndex = 15;
      this.label2.Text = "Количество:";
      // 
      // comboBoxClothes
      // 
      this.comboBoxClothes.FormattingEnabled = true;
      this.comboBoxClothes.Items.AddRange(new object[] {
            "Пусто",
            "12"});
      this.comboBoxClothes.Location = new System.Drawing.Point(92, 57);
      this.comboBoxClothes.Name = "comboBoxClothes";
      this.comboBoxClothes.Size = new System.Drawing.Size(172, 21);
      this.comboBoxClothes.TabIndex = 16;
      this.comboBoxClothes.SelectedIndexChanged += new System.EventHandler(this.comboBoxClothes_SelectedIndexChanged);
      // 
      // Save
      // 
      this.Save.Location = new System.Drawing.Point(92, 139);
      this.Save.Name = "Save";
      this.Save.Size = new System.Drawing.Size(75, 23);
      this.Save.TabIndex = 17;
      this.Save.Text = "Сохранить";
      this.Save.UseVisualStyleBackColor = true;
      this.Save.Click += new System.EventHandler(this.Save_Click);
      // 
      // FormOrderItemEdit
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 262);
      this.Controls.Add(this.Save);
      this.Controls.Add(this.comboBoxClothes);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.comboBoxCount);
      this.Controls.Add(this.comboBoxParent);
      this.Controls.Add(this.label4);
      this.Name = "FormOrderItemEdit";
      this.Text = "FormOrderItemEdit";
      this.Load += new System.EventHandler(this.FormOrderItemEdit_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ComboBox comboBoxParent;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.ComboBox comboBoxCount;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ComboBox comboBoxClothes;
    private System.Windows.Forms.Button Save;
  }
}