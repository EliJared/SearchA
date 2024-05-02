using SearchEngine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Signin : Form 
    {
        List<User> users = new List<User>();
       
        public Signin()
        {
            InitializeComponent();
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }
        public void signbut2_Click(object sender, EventArgs e)
        {
            var owner = new User(txt1.Text,txt2.Text);
           Global.Usename = txt1.Text;
            System.Windows.Forms.MessageBox.Show("Welcome"+txt1.Text);
            this.Close();
            users.Add(owner);
        }

        private void Signbut_Click(object sender, EventArgs e)
        {
            var owner1 = new User("Elijah", "12345");
            var owner2 = new User("Mary", "Fake4");
            users.Add(owner1);
            users.Add(owner2);
            string word = txt1.Text;
            string word2 = txt2.Text;
            if ( word == "Elijah" && word2 == "12345")
            {
                Global.Usename = txt1.Text;
                System.Windows.Forms.MessageBox.Show("Welcome" + txt1.Text);
                this.Close();
            }
            if (word == "Mary" && word2 == "Fake4")
            {
                Global.Usename = txt1.Text;
                System.Windows.Forms.MessageBox.Show("Welcome" + txt1.Text);
                this.Close();
            }

        }

        private void txt2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
