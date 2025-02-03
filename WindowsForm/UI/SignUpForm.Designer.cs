namespace WindowsForm.UI
{
    partial class SignUpForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.TextBox();
            this.Confirm = new System.Windows.Forms.TextBox();
            this.Contact = new System.Windows.Forms.TextBox();
            this.CNIC = new System.Windows.Forms.TextBox();
            this.Gmail = new System.Windows.Forms.TextBox();
            this.Signup = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.Back = new System.Windows.Forms.Button();
            this.labl7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gmail:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "CNIC:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(307, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contact Number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(307, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Password:";
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(463, 71);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(100, 22);
            this.Username.TabIndex = 5;
            // 
            // Confirm
            // 
            this.Confirm.Location = new System.Drawing.Point(463, 254);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(100, 22);
            this.Confirm.TabIndex = 6;
            // 
            // Contact
            // 
            this.Contact.Location = new System.Drawing.Point(463, 179);
            this.Contact.Name = "Contact";
            this.Contact.Size = new System.Drawing.Size(100, 22);
            this.Contact.TabIndex = 7;
            // 
            // CNIC
            // 
            this.CNIC.Location = new System.Drawing.Point(463, 141);
            this.CNIC.Name = "CNIC";
            this.CNIC.Size = new System.Drawing.Size(100, 22);
            this.CNIC.TabIndex = 8;
            // 
            // Gmail
            // 
            this.Gmail.Location = new System.Drawing.Point(463, 113);
            this.Gmail.Name = "Gmail";
            this.Gmail.Size = new System.Drawing.Size(100, 22);
            this.Gmail.TabIndex = 9;
            // 
            // Signup
            // 
            this.Signup.Location = new System.Drawing.Point(463, 300);
            this.Signup.Name = "Signup";
            this.Signup.Size = new System.Drawing.Size(149, 29);
            this.Signup.TabIndex = 10;
            this.Signup.Text = "Create Account";
            this.Signup.UseVisualStyleBackColor = true;
            this.Signup.Click += new System.EventHandler(this.Signup_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(310, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Confirm Password:";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(463, 214);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(100, 22);
            this.Password.TabIndex = 12;
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(310, 300);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(88, 29);
            this.Back.TabIndex = 13;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // labl7
            // 
            this.labl7.AutoSize = true;
            this.labl7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labl7.Location = new System.Drawing.Point(328, 9);
            this.labl7.Name = "labl7";
            this.labl7.Size = new System.Drawing.Size(193, 32);
            this.labl7.TabIndex = 14;
            this.labl7.Text = "Sign Up Menu";
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsForm.Properties.Resources._3download;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labl7);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Signup);
            this.Controls.Add(this.Gmail);
            this.Controls.Add(this.CNIC);
            this.Controls.Add(this.Contact);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SignUpForm";
            this.Text = "SignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Confirm;
        private System.Windows.Forms.TextBox Contact;
        private System.Windows.Forms.TextBox CNIC;
        private System.Windows.Forms.TextBox Gmail;
        private System.Windows.Forms.Button Signup;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label labl7;
    }
}