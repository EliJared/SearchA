namespace WindowsFormsApp1
{
    partial class Signin
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
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.MaskedTextBox();
            this.Signbut = new System.Windows.Forms.Button();
            this.signbut2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(35, 31);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(172, 26);
            this.txt1.TabIndex = 0;
            this.txt1.Text = "First Name";
            this.txt1.TextChanged += new System.EventHandler(this.txt1_TextChanged);
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(35, 88);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(172, 26);
            this.txt2.TabIndex = 1;
            this.txt2.Text = "Password";
            this.txt2.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txt2_MaskInputRejected);
            // 
            // Signbut
            // 
            this.Signbut.Location = new System.Drawing.Point(255, 31);
            this.Signbut.Name = "Signbut";
            this.Signbut.Size = new System.Drawing.Size(87, 31);
            this.Signbut.TabIndex = 2;
            this.Signbut.Text = "Sign In";
            this.Signbut.UseVisualStyleBackColor = true;
            this.Signbut.Click += new System.EventHandler(this.Signbut_Click);
            // 
            // signbut2
            // 
            this.signbut2.Location = new System.Drawing.Point(255, 68);
            this.signbut2.Name = "signbut2";
            this.signbut2.Size = new System.Drawing.Size(87, 54);
            this.signbut2.TabIndex = 3;
            this.signbut2.Text = "Create Account";
            this.signbut2.UseVisualStyleBackColor = true;
            this.signbut2.Click += new System.EventHandler(this.signbut2_Click);
            // 
            // Signin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 251);
            this.Controls.Add(this.signbut2);
            this.Controls.Add(this.Signbut);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Name = "Signin";
            this.Text = "Signin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.MaskedTextBox txt2;
        private System.Windows.Forms.Button Signbut;
        private System.Windows.Forms.Button signbut2;
    }
}