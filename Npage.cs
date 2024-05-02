using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Npage : Form
    {
        public Npage()
        {
            InitializeComponent();
          
        }

        private void Npage_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void obtn_Click(object sender, EventArgs e)
        {
            olab.Text = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
  if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string selectedFile = openFileDialog1.FileName;
            }
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(open.FileName);
            }
        }

        private void pbtn_Click(object sender, EventArgs e)
        {
            plab.Text = textBox1.Text;
        }

        private void abtn_Click(object sender, EventArgs e)
        {
            alab.Text = textBox1.Text;
        }

        private void sbtn_Click(object sender, EventArgs e)
        {
            slab.Text = textBox1.Text;
        }
    }
}
