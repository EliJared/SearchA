using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using SearchEngine;
using System.Data.SqlClient;
using System.IO;
using System.IO.Ports;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<Animal> animals = new List<Animal>();
        List<Animal> animals1= new List<Animal>();
        List<Animal> animals2 = new List<Animal>();
        List<Animal> animals3 = new List<Animal>();
        
        public Form1()
        {
            InitializeComponent();
            var Ani = new Animal("the", "cat", 69, "right");
            animals.Add(new Animal() { Aname = "Bessie", Pname = "Derick", Age = 3, Type = "Cow" });
            animals.Add(new Animal() { Aname = "Guppy", Pname = "Fred", Age = 1, Type = "fish" });
            animals.Add(new Animal() { Aname = "crank arm", Pname = "Jack",Age = 4, Type = "Dog" }); 
        }
       
        private void Searchbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Gobtn_Click(object sender, EventArgs e)
        {
            Global.Usename = Searchbox.Text;
            Global.spcies = Searchbox.Text;
            
            if (Global.Usename == "Fred" || Global.spcies == "Fish")
            {
                Global.Usename = "Fred";
                Global.Pet = "Guppy";
                Global.spcies = "Fish";
                Global.Age = 1;
                page f1 = new page();
                f1.ShowDialog();
            }
            else if (Global.Usename == "Derick" || Global.spcies == "Cow")
            {
                Global.Usename = "Derick";
                Global.Pet = "Bessie";
                Global.spcies = "Cow";
                Global.Age = 3;
                page f1 = new page();
                f1.ShowDialog();
            }
            else if (Global.Usename == "Beth" || Global.spcies == "Kangaroo")
            {
                Global.Usename = "Beth";
                Global.Pet = "Joey";
                Global.spcies = "Kangaroo";
                Global.Age = 3;
                page f1 = new page();
                f1.ShowDialog();
            }
            else if (Global.Usename == "Jack" || Global.spcies == "Dog")
            {
                Global.Usename = "Jack";
                Global.Pet = "crank arm";
                Global.spcies = "Dog";
                Global.Age = 4;
                page f1 = new page();
                f1.ShowDialog();
            }
            else if (Global.Usename == "Alanah" || Global.spcies == "Lizard")
            {
                Global.Usename = "Alanah";
                Global.Pet = "Greg";
                Global.spcies = "Lizard";
                Global.Age = 5;
                page f1 = new page();
                f1.ShowDialog();
            }
            //  if (Searchbox.Text == animals.Contains(new Animal { Aname == "Guppy" })) ;
            //   Process.Start("iexplore", "www.google.com/search?h1 = en&q=" + Searchbox.Text + "");

        }
        
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void Sign_Click(object sender, EventArgs e)
        {
            Signin f2 = new Signin();

            f2.ShowDialog(); // Shows Form2
        }

        private void Form1_Load(object sender, EventArgs e)
        {
  
        }
      
    private void userbox_TextChanged(object sender, EventArgs e)
        {
            userbox.Text = Global.Usename;
            userbox.Enabled = false;
        }

        private void Create_Click(object sender, EventArgs e)
        {
            Npage f3 = new Npage();
            f3.ShowDialog();
            /*
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
            userbox.Text = open.FileName;
            */
        }

        private void webBrowser1_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Searchbox.Text = button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Searchbox.Text = button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Searchbox.Text = button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Searchbox.Text = button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Searchbox.Text = button5.Text;
        }
    }
}
