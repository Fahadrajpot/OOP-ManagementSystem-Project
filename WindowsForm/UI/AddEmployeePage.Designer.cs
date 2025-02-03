namespace WindowsForm.UI
{
    partial class AddEmployeePage
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
            this.Add = new System.Windows.Forms.Button();
            this.EmpName = new System.Windows.Forms.TextBox();
            this.Gmail = new System.Windows.Forms.TextBox();
            this.CNIC = new System.Windows.Forms.TextBox();
            this.Contact = new System.Windows.Forms.TextBox();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(326, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Employee";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(309, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gmail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(309, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "CNIC:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(309, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Contact Number:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(447, 285);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(78, 30);
            this.Add.TabIndex = 5;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // EmpName
            // 
            this.EmpName.Location = new System.Drawing.Point(442, 80);
            this.EmpName.Name = "EmpName";
            this.EmpName.Size = new System.Drawing.Size(100, 22);
            this.EmpName.TabIndex = 6;
            // 
            // Gmail
            // 
            this.Gmail.Location = new System.Drawing.Point(442, 125);
            this.Gmail.Name = "Gmail";
            this.Gmail.Size = new System.Drawing.Size(100, 22);
            this.Gmail.TabIndex = 8;
            // 
            // CNIC
            // 
            this.CNIC.Location = new System.Drawing.Point(442, 172);
            this.CNIC.Name = "CNIC";
            this.CNIC.Size = new System.Drawing.Size(100, 22);
            this.CNIC.TabIndex = 9;
            // 
            // Contact
            // 
            this.Contact.Location = new System.Drawing.Point(442, 214);
            this.Contact.Name = "Contact";
            this.Contact.Size = new System.Drawing.Size(100, 22);
            this.Contact.TabIndex = 10;
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(332, 285);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(83, 30);
            this.Back.TabIndex = 11;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // AddEmployeePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsForm.Properties.Resources._3download;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Contact);
            this.Controls.Add(this.CNIC);
            this.Controls.Add(this.Gmail);
            this.Controls.Add(this.EmpName);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddEmployeePage";
            this.Text = "AddEmployeePage";
            this.Load += new System.EventHandler(this.AddEmployeePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox EmpName;
        private System.Windows.Forms.TextBox Gmail;
        private System.Windows.Forms.TextBox CNIC;
        private System.Windows.Forms.TextBox Contact;
        private System.Windows.Forms.Button Back;
    }
}