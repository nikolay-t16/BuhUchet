namespace BuhUchet
{
    partial class FormSpisokDetey
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
      this.components = new System.ComponentModel.Container();
      this.dataGridViewDetiSearch = new System.Windows.Forms.DataGridView();
      this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.data_otkritiya_karty = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.fio = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.razmer_odegdy = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.razmer_obuvy = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.razmer_golavy = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.buttonSearch = new System.Windows.Forms.Button();
      this.textBoxSearch = new System.Windows.Forms.TextBox();
      this.buhUchetDataSet = new BuhUchet.BuhUchetDataSet();
      this.detiBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.detiTableAdapter = new BuhUchet.BuhUchetDataSetTableAdapters.detiTableAdapter();
      this.tableAdapterManager = new BuhUchet.BuhUchetDataSetTableAdapters.TableAdapterManager();
      this.buhUchetDataSet1 = new BuhUchet.BuhUchetDataSet();
      this.buttonAdd = new System.Windows.Forms.Button();
      this.buttonEdit = new System.Windows.Forms.Button();
      this.buttonDelete = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetiSearch)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.buhUchetDataSet)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.detiBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.buhUchetDataSet1)).BeginInit();
      this.SuspendLayout();
      // 
      // dataGridViewDetiSearch
      // 
      this.dataGridViewDetiSearch.AllowUserToAddRows = false;
      this.dataGridViewDetiSearch.AllowUserToDeleteRows = false;
      this.dataGridViewDetiSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewDetiSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.data_otkritiya_karty,
            this.fio,
            this.razmer_odegdy,
            this.razmer_obuvy,
            this.razmer_golavy});
      this.dataGridViewDetiSearch.Location = new System.Drawing.Point(13, 65);
      this.dataGridViewDetiSearch.Name = "dataGridViewDetiSearch";
      this.dataGridViewDetiSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dataGridViewDetiSearch.Size = new System.Drawing.Size(643, 144);
      this.dataGridViewDetiSearch.TabIndex = 0;
      this.dataGridViewDetiSearch.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDetiSearch_CellContentClick);
      // 
      // id
      // 
      this.id.HeaderText = "№ а/к";
      this.id.Name = "id";
      this.id.ReadOnly = true;
      // 
      // data_otkritiya_karty
      // 
      this.data_otkritiya_karty.HeaderText = "Дата открытия карты";
      this.data_otkritiya_karty.Name = "data_otkritiya_karty";
      // 
      // fio
      // 
      this.fio.HeaderText = "Фио";
      this.fio.Name = "fio";
      this.fio.ReadOnly = true;
      // 
      // razmer_odegdy
      // 
      this.razmer_odegdy.HeaderText = "Размер одежды";
      this.razmer_odegdy.Name = "razmer_odegdy";
      this.razmer_odegdy.ReadOnly = true;
      // 
      // razmer_obuvy
      // 
      this.razmer_obuvy.HeaderText = "Размер обуви";
      this.razmer_obuvy.Name = "razmer_obuvy";
      this.razmer_obuvy.ReadOnly = true;
      // 
      // razmer_golavy
      // 
      this.razmer_golavy.HeaderText = "Размер головного убора";
      this.razmer_golavy.Name = "razmer_golavy";
      this.razmer_golavy.ReadOnly = true;
      // 
      // buttonSearch
      // 
      this.buttonSearch.Location = new System.Drawing.Point(581, 38);
      this.buttonSearch.Name = "buttonSearch";
      this.buttonSearch.Size = new System.Drawing.Size(75, 20);
      this.buttonSearch.TabIndex = 1;
      this.buttonSearch.Text = "Найти";
      this.buttonSearch.UseVisualStyleBackColor = true;
      this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
      // 
      // textBoxSearch
      // 
      this.textBoxSearch.Location = new System.Drawing.Point(13, 38);
      this.textBoxSearch.Name = "textBoxSearch";
      this.textBoxSearch.Size = new System.Drawing.Size(562, 20);
      this.textBoxSearch.TabIndex = 2;
      // 
      // buhUchetDataSet
      // 
      this.buhUchetDataSet.DataSetName = "BuhUchetDataSet";
      this.buhUchetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // detiBindingSource
      // 
      this.detiBindingSource.DataMember = "deti";
      this.detiBindingSource.DataSource = this.buhUchetDataSet;
      // 
      // detiTableAdapter
      // 
      this.detiTableAdapter.ClearBeforeFill = true;
      // 
      // tableAdapterManager
      // 
      this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
      this.tableAdapterManager.detiTableAdapter = this.detiTableAdapter;
      this.tableAdapterManager.UpdateOrder = BuhUchet.BuhUchetDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
      // 
      // buhUchetDataSet1
      // 
      this.buhUchetDataSet1.DataSetName = "BuhUchetDataSet";
      this.buhUchetDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // buttonAdd
      // 
      this.buttonAdd.Location = new System.Drawing.Point(13, 13);
      this.buttonAdd.Name = "buttonAdd";
      this.buttonAdd.Size = new System.Drawing.Size(75, 23);
      this.buttonAdd.TabIndex = 3;
      this.buttonAdd.Text = "Добавить";
      this.buttonAdd.UseVisualStyleBackColor = true;
      this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
      // 
      // buttonEdit
      // 
      this.buttonEdit.Location = new System.Drawing.Point(94, 12);
      this.buttonEdit.Name = "buttonEdit";
      this.buttonEdit.Size = new System.Drawing.Size(94, 23);
      this.buttonEdit.TabIndex = 4;
      this.buttonEdit.Text = "Редактировать";
      this.buttonEdit.UseVisualStyleBackColor = true;
      this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
      // 
      // buttonDelete
      // 
      this.buttonDelete.Location = new System.Drawing.Point(194, 13);
      this.buttonDelete.Name = "buttonDelete";
      this.buttonDelete.Size = new System.Drawing.Size(75, 23);
      this.buttonDelete.TabIndex = 5;
      this.buttonDelete.Text = "Удалить";
      this.buttonDelete.UseVisualStyleBackColor = true;
      this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
      // 
      // FormSpisokDetey
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.ClientSize = new System.Drawing.Size(692, 472);
      this.Controls.Add(this.buttonDelete);
      this.Controls.Add(this.buttonEdit);
      this.Controls.Add(this.buttonAdd);
      this.Controls.Add(this.textBoxSearch);
      this.Controls.Add(this.buttonSearch);
      this.Controls.Add(this.dataGridViewDetiSearch);
      this.Name = "FormSpisokDetey";
      this.Text = "FormSpisokDetey";
      this.Load += new System.EventHandler(this.FormSpisokDetey_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetiSearch)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.buhUchetDataSet)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.detiBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.buhUchetDataSet1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDetiSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private BuhUchetDataSet buhUchetDataSet;
        private System.Windows.Forms.BindingSource detiBindingSource;
        private BuhUchetDataSetTableAdapters.detiTableAdapter detiTableAdapter;
        private BuhUchetDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private BuhUchetDataSet buhUchetDataSet1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_otkritiya_karty;
        private System.Windows.Forms.DataGridViewTextBoxColumn fio;
        private System.Windows.Forms.DataGridViewTextBoxColumn razmer_odegdy;
        private System.Windows.Forms.DataGridViewTextBoxColumn razmer_obuvy;
        private System.Windows.Forms.DataGridViewTextBoxColumn razmer_golavy;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;

    }
}