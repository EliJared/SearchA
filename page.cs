using SearchEngine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp1
{
    public partial class page : Form
    {
        public page()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (Global.Usename != "Alanah")
            {
                pictureBox1.Visible = false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Text = Global.Usename;
        }

        private void lname_Click(object sender, EventArgs e)
        {
            lname.Text = Global.Pet;
        }

        private void lage_Click(object sender, EventArgs e)
        {
            string age = Global.Age.ToString();
            lage.Text = age;
        }

        private void lspecies_Click(object sender, EventArgs e)
        {
            lspecies.Text = Global.spcies;
        }

        private void bcom_Click(object sender, EventArgs e)
        {
            comment.Text = Fbox.Text;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (Global.Usename != "Jack")
            {
                pictureBox3.Visible = false;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (Global.Usename != "Fred")
            {
                pictureBox4.Visible = false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (Global.Usename != "Derick")
            {
                pictureBox2.Visible = false;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (Global.Usename != "Beth")
            {
                pictureBox5.Visible = false;
            }
        }

    }
}
