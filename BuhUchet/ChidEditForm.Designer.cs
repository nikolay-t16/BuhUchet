namespace BuhUchet
{
    partial class ChildEditForm
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
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxFio = new System.Windows.Forms.TextBox();
            this.textBoxClothesSize = new System.Windows.Forms.TextBox();
            this.textBoxShoesSize = new System.Windows.Forms.TextBox();
            this.textBoxHeadSize = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DhildSave = new System.Windows.Forms.Button();
            this.dateTimePickerCreateDate = new System.Windows.Forms.DateTimePicker();
            this.labelCreateDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(175, 27);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(273, 20);
            this.textBoxId.TabIndex = 0;
            // 
            // textBoxFio
            // 
            this.textBoxFio.Location = new System.Drawing.Point(175, 77);
            this.textBoxFio.Name = "textBoxFio";
            this.textBoxFio.Size = new System.Drawing.Size(273, 20);
            this.textBoxFio.TabIndex = 1;
            // 
            // textBoxClothesSize
            // 
            this.textBoxClothesSize.Location = new System.Drawing.Point(175, 104);
            this.textBoxClothesSize.Name = "textBoxClothesSize";
            this.textBoxClothesSize.Size = new System.Drawing.Size(273, 20);
            this.textBoxClothesSize.TabIndex = 2;
            // 
            // textBoxShoesSize
            // 
            this.textBoxShoesSize.Location = new System.Drawing.Point(175, 130);
            this.textBoxShoesSize.Name = "textBoxShoesSize";
            this.textBoxShoesSize.Size = new System.Drawing.Size(273, 20);
            this.textBoxShoesSize.TabIndex = 3;
            // 
            // textBoxHeadSize
            // 
            this.textBoxHeadSize.Location = new System.Drawing.Point(175, 162);
            this.textBoxHeadSize.Name = "textBoxHeadSize";
            this.textBoxHeadSize.Size = new System.Drawing.Size(273, 20);
            this.textBoxHeadSize.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "№ арматурной карты:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "ФИО:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Размер одежды:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Размер обуви";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Размер головного убора:";
            // 
            // DhildSave
            // 
            this.DhildSave.Location = new System.Drawing.Point(175, 189);
            this.DhildSave.Name = "DhildSave";
            this.DhildSave.Size = new System.Drawing.Size(100, 21);
            this.DhildSave.TabIndex = 10;
            this.DhildSave.Text = "Сохранить";
            this.DhildSave.UseVisualStyleBackColor = true;
            this.DhildSave.Click += new System.EventHandler(this.DhildSave_Click);
            // 
            // dateTimePickerCreateDate
            // 
            this.dateTimePickerCreateDate.Location = new System.Drawing.Point(175, 51);
            this.dateTimePickerCreateDate.MaxDate = new System.DateTime(2015, 9, 4, 0, 0, 0, 0);
            this.dateTimePickerCreateDate.Name = "dateTimePickerCreateDate";
            this.dateTimePickerCreateDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerCreateDate.TabIndex = 11;
            this.dateTimePickerCreateDate.Value = new System.DateTime(2015, 9, 4, 0, 0, 0, 0);
            // 
            // labelCreateDate
            // 
            this.labelCreateDate.AutoSize = true;
            this.labelCreateDate.Location = new System.Drawing.Point(82, 57);
            this.labelCreateDate.Name = "labelCreateDate";
            this.labelCreateDate.Size = new System.Drawing.Size(87, 13);
            this.labelCreateDate.TabIndex = 12;
            this.labelCreateDate.Text = "Дата создания:";
            // 
            // ChildEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 289);
            this.Controls.Add(this.labelCreateDate);
            this.Controls.Add(this.dateTimePickerCreateDate);
            this.Controls.Add(this.DhildSave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxHeadSize);
            this.Controls.Add(this.textBoxShoesSize);
            this.Controls.Add(this.textBoxClothesSize);
            this.Controls.Add(this.textBoxFio);
            this.Controls.Add(this.textBoxId);
            this.Name = "ChildEditForm";
            this.Text = "Орма редактирования";
            this.Load += new System.EventHandler(this.ChildEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxFio;
        private System.Windows.Forms.TextBox textBoxClothesSize;
        private System.Windows.Forms.TextBox textBoxShoesSize;
        private System.Windows.Forms.TextBox textBoxHeadSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button DhildSave;
        private System.Windows.Forms.DateTimePicker dateTimePickerCreateDate;
        private System.Windows.Forms.Label labelCreateDate;
    }
}