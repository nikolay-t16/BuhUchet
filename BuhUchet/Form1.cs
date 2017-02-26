using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml;
namespace BuhUchet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void spiskyDeteyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSpisokDetey f = new FormSpisokDetey();
            f.Show();
            //this.Hide();
        }

        private void tipyOdegdiToolStripMenuItem_Click(object sender, EventArgs e)
        {
          FormClothesList f = new FormClothesList();
          //FormClosed f = new FormSpisokDetey();
          f.Show();
        }

        private void prihodnayaNaklodnayaToolStripMenuItem_Click(object sender, EventArgs e)
        {
          FormPrihodnayaNaklodnayaSpisok f = new FormPrihodnayaNaklodnayaSpisok();
          f.Show();
        }

        private void vedomostToolStripMenuItem_Click(object sender, EventArgs e)
        {
          FormOrder f = new FormOrder();
          f.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
