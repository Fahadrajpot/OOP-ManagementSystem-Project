namespace WindowsForm.UI
{
    partial class CustomerMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.Order = new System.Windows.Forms.Button();
            this.OrderHistory = new System.Windows.Forms.Button();
            this.Feedback = new System.Windows.Forms.Button();
            this.EditProfile = new System.Windows.Forms.Button();
            this.LogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Menu";
            // 
            // Order
            // 
            this.Order.Location = new System.Drawing.Point(336, 123);
            this.Order.Name = "Order";
            this.Order.Size = new System.Drawing.Size(112, 36);
            this.Order.TabIndex = 1;
            this.Order.Text = "Order";
            this.Order.UseVisualStyleBackColor = true;
            this.Order.Click += new System.EventHandler(this.Order_Click);
            // 
            // OrderHistory
            // 
            this.OrderHistory.Location = new System.Drawing.Point(340, 184);
            this.OrderHistory.Name = "OrderHistory";
            this.OrderHistory.Size = new System.Drawing.Size(108, 26);
            this.OrderHistory.TabIndex = 2;
            this.OrderHistory.Text = "Order History";
            this.OrderHistory.UseVisualStyleBackColor = true;
            this.OrderHistory.Click += new System.EventHandler(this.OrderHistory_Click);
            // 
            // Feedback
            // 
            this.Feedback.Location = new System.Drawing.Point(336, 244);
            this.Feedback.Name = "Feedback";
            this.Feedback.Size = new System.Drawing.Size(108, 27);
            this.Feedback.TabIndex = 3;
            this.Feedback.Text = "Feedback";
            this.Feedback.UseVisualStyleBackColor = true;
            this.Feedback.Click += new System.EventHandler(this.Feedback_Click);
            // 
            // EditProfile
            // 
            this.EditProfile.Location = new System.Drawing.Point(336, 308);
            this.EditProfile.Name = "EditProfile";
            this.EditProfile.Size = new System.Drawing.Size(108, 25);
            this.EditProfile.TabIndex = 4;
            this.EditProfile.Text = "Edit Profile";
            this.EditProfile.UseVisualStyleBackColor = true;
            this.EditProfile.Click += new System.EventHandler(this.EditProfile_Click);
            // 
            // LogOut
            // 
            this.LogOut.Location = new System.Drawing.Point(336, 365);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(112, 26);
            this.LogOut.TabIndex = 5;
            this.LogOut.Text = "Log Out";
            this.LogOut.UseVisualStyleBackColor = true;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // CustomerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.EditProfile);
            this.Controls.Add(this.Feedback);
            this.Controls.Add(this.OrderHistory);
            this.Controls.Add(this.Order);
            this.Controls.Add(this.label1);
            this.Name = "CustomerMenu";
            this.Text = "CustomerMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Order;
        private System.Windows.Forms.Button OrderHistory;
        private System.Windows.Forms.Button Feedback;
        private System.Windows.Forms.Button EditProfile;
        private System.Windows.Forms.Button LogOut;
    }
}