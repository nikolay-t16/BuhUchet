namespace BuhUchet
{
    partial class Form1
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
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.clothesForCheldrenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.prihodnayaNaklodnayaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.vedomostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.tipyOdegdiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.spiskyDeteyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clothesForCheldrenToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(601, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // clothesForCheldrenToolStripMenuItem
      // 
      this.clothesForCheldrenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prihodnayaNaklodnayaToolStripMenuItem,
            this.vedomostToolStripMenuItem,
            this.tipyOdegdiToolStripMenuItem,
            this.spiskyDeteyToolStripMenuItem});
      this.clothesForCheldrenToolStripMenuItem.Name = "clothesForCheldrenToolStripMenuItem";
      this.clothesForCheldrenToolStripMenuItem.Size = new System.Drawing.Size(180, 20);
      this.clothesForCheldrenToolStripMenuItem.Text = "Учет выдачи детской одежды";
      // 
      // prihodnayaNaklodnayaToolStripMenuItem
      // 
      this.prihodnayaNaklodnayaToolStripMenuItem.Name = "prihodnayaNaklodnayaToolStripMenuItem";
      this.prihodnayaNaklodnayaToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
      this.prihodnayaNaklodnayaToolStripMenuItem.Text = "Товарные накладные";
      this.prihodnayaNaklodnayaToolStripMenuItem.Click += new System.EventHandler(this.prihodnayaNaklodnayaToolStripMenuItem_Click);
      // 
      // vedomostToolStripMenuItem
      // 
      this.vedomostToolStripMenuItem.Name = "vedomostToolStripMenuItem";
      this.vedomostToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
      this.vedomostToolStripMenuItem.Text = "Арматурные карты";
      this.vedomostToolStripMenuItem.Click += new System.EventHandler(this.vedomostToolStripMenuItem_Click);
      // 
      // tipyOdegdiToolStripMenuItem
      // 
      this.tipyOdegdiToolStripMenuItem.Name = "tipyOdegdiToolStripMenuItem";
      this.tipyOdegdiToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
      this.tipyOdegdiToolStripMenuItem.Text = "Типы одежды";
      this.tipyOdegdiToolStripMenuItem.Click += new System.EventHandler(this.tipyOdegdiToolStripMenuItem_Click);
      // 
      // spiskyDeteyToolStripMenuItem
      // 
      this.spiskyDeteyToolStripMenuItem.Name = "spiskyDeteyToolStripMenuItem";
      this.spiskyDeteyToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
      this.spiskyDeteyToolStripMenuItem.Text = "Списки детей";
      this.spiskyDeteyToolStripMenuItem.Click += new System.EventHandler(this.spiskyDeteyToolStripMenuItem_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(601, 359);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clothesForCheldrenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prihodnayaNaklodnayaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vedomostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipyOdegdiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spiskyDeteyToolStripMenuItem;
    }
}

