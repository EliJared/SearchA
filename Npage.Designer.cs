namespace WindowsFormsApp1
{
    partial class Npage
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
            this.slab = new System.Windows.Forms.Label();
            this.alab = new System.Windows.Forms.Label();
            this.olab = new System.Windows.Forms.Label();
            this.plab = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pbtn = new System.Windows.Forms.Button();
            this.obtn = new System.Windows.Forms.Button();
            this.sbtn = new System.Windows.Forms.Button();
            this.abtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // slab
            // 
            this.slab.AutoSize = true;
            this.slab.Location = new System.Drawing.Point(66, 214);
            this.slab.Name = "slab";
            this.slab.Size = new System.Drawing.Size(66, 20);
            this.slab.TabIndex = 4;
            this.slab.Text = "Species";
            // 
            // alab
            // 
            this.alab.AutoSize = true;
            this.alab.Location = new System.Drawing.Point(77, 172);
            this.alab.Name = "alab";
            this.alab.Size = new System.Drawing.Size(38, 20);
            this.alab.TabIndex = 5;
            this.alab.Text = "Age";
            // 
            // olab
            // 
            this.olab.AutoSize = true;
            this.olab.Location = new System.Drawing.Point(66, 97);
            this.olab.Name = "olab";
            this.olab.Size = new System.Drawing.Size(55, 20);
            this.olab.TabIndex = 6;
            this.olab.Text = "Owner";
            // 
            // plab
            // 
            this.plab.AutoSize = true;
            this.plab.Location = new System.Drawing.Point(77, 140);
            this.plab.Name = "plab";
            this.plab.Size = new System.Drawing.Size(33, 20);
            this.plab.TabIndex = 7;
            this.plab.Text = "Pet";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(60, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pbtn
            // 
            this.pbtn.Location = new System.Drawing.Point(159, 126);
            this.pbtn.Name = "pbtn";
            this.pbtn.Size = new System.Drawing.Size(75, 34);
            this.pbtn.TabIndex = 9;
            this.pbtn.Text = "Pet";
            this.pbtn.UseVisualStyleBackColor = true;
            this.pbtn.Click += new System.EventHandler(this.pbtn_Click);
            // 
            // obtn
            // 
            this.obtn.Location = new System.Drawing.Point(159, 82);
            this.obtn.Name = "obtn";
            this.obtn.Size = new System.Drawing.Size(75, 38);
            this.obtn.TabIndex = 10;
            this.obtn.Text = "Owner";
            this.obtn.UseVisualStyleBackColor = true;
            this.obtn.Click += new System.EventHandler(this.obtn_Click);
            // 
            // sbtn
            // 
            this.sbtn.Location = new System.Drawing.Point(159, 208);
            this.sbtn.Name = "sbtn";
            this.sbtn.Size = new System.Drawing.Size(75, 33);
            this.sbtn.TabIndex = 11;
            this.sbtn.Text = "Species";
            this.sbtn.UseVisualStyleBackColor = true;
            this.sbtn.Click += new System.EventHandler(this.sbtn_Click);
            // 
            // abtn
            // 
            this.abtn.Location = new System.Drawing.Point(159, 169);
            this.abtn.Name = "abtn";
            this.abtn.Size = new System.Drawing.Size(75, 33);
            this.abtn.TabIndex = 12;
            this.abtn.Text = "Age";
            this.abtn.UseVisualStyleBackColor = true;
            this.abtn.Click += new System.EventHandler(this.abtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(303, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(356, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 50);
            this.button1.TabIndex = 14;
            this.button1.Text = "insert Picture";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Npage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 324);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.abtn);
            this.Controls.Add(this.sbtn);
            this.Controls.Add(this.obtn);
            this.Controls.Add(this.pbtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.plab);
            this.Controls.Add(this.olab);
            this.Controls.Add(this.alab);
            this.Controls.Add(this.slab);
            this.Name = "Npage";
            this.Text = "Npage";
            this.Load += new System.EventHandler(this.Npage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label slab;
        private System.Windows.Forms.Label alab;
        private System.Windows.Forms.Label olab;
        private System.Windows.Forms.Label plab;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button pbtn;
        private System.Windows.Forms.Button obtn;
        private System.Windows.Forms.Button sbtn;
        private System.Windows.Forms.Button abtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button button1;
    }
}