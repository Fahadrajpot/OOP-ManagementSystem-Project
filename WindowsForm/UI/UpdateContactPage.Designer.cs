﻿namespace WindowsForm.UI
{
    partial class UpdateContactPage
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
            this.UpdateContact = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Contact = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // UpdateContact
            // 
            this.UpdateContact.Location = new System.Drawing.Point(403, 233);
            this.UpdateContact.Name = "UpdateContact";
            this.UpdateContact.Size = new System.Drawing.Size(91, 34);
            this.UpdateContact.TabIndex = 0;
            this.UpdateContact.Text = "Update";
            this.UpdateContact.UseVisualStyleBackColor = true;
            this.UpdateContact.Click += new System.EventHandler(this.UpdateContact_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(242, 233);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(91, 34);
            this.Back.TabIndex = 1;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(265, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Update Contact Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter New Contact Number:";
            // 
            // Contact
            // 
            this.Contact.Location = new System.Drawing.Point(413, 151);
            this.Contact.Name = "Contact";
            this.Contact.Size = new System.Drawing.Size(100, 22);
            this.Contact.TabIndex = 4;
            // 
            // UpdateContactPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsForm.Properties.Resources._3download;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Contact);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.UpdateContact);
            this.Name = "UpdateContactPage";
            this.Text = "UpdateContactPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UpdateContact;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Contact;
    }
}