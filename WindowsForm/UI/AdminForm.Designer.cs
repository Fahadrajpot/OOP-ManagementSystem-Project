namespace WindowsForm.UI
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.AddDish = new System.Windows.Forms.Button();
            this.RemoveDish = new System.Windows.Forms.Button();
            this.UpdateDish = new System.Windows.Forms.Button();
            this.AddEmployee = new System.Windows.Forms.Button();
            this.RemoveEmployee = new System.Windows.Forms.Button();
            this.UpdateEmployee = new System.Windows.Forms.Button();
            this.Sales = new System.Windows.Forms.Button();
            this.LogOut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.EmployeeInfo = new System.Windows.Forms.Button();
            this.MenuCard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddDish
            // 
            this.AddDish.Location = new System.Drawing.Point(321, 103);
            this.AddDish.Name = "AddDish";
            this.AddDish.Size = new System.Drawing.Size(132, 26);
            this.AddDish.TabIndex = 1;
            this.AddDish.Text = "Add Dish";
            this.AddDish.UseVisualStyleBackColor = true;
            this.AddDish.Click += new System.EventHandler(this.AddDish_Click);
            // 
            // RemoveDish
            // 
            this.RemoveDish.Location = new System.Drawing.Point(321, 135);
            this.RemoveDish.Name = "RemoveDish";
            this.RemoveDish.Size = new System.Drawing.Size(132, 25);
            this.RemoveDish.TabIndex = 2;
            this.RemoveDish.Text = "Remove Dish";
            this.RemoveDish.UseVisualStyleBackColor = true;
            this.RemoveDish.Click += new System.EventHandler(this.RemoveDish_Click);
            // 
            // UpdateDish
            // 
            this.UpdateDish.Location = new System.Drawing.Point(321, 166);
            this.UpdateDish.Name = "UpdateDish";
            this.UpdateDish.Size = new System.Drawing.Size(132, 23);
            this.UpdateDish.TabIndex = 3;
            this.UpdateDish.Text = "Update Dish";
            this.UpdateDish.UseVisualStyleBackColor = true;
            this.UpdateDish.Click += new System.EventHandler(this.UpdateDish_Click);
            // 
            // AddEmployee
            // 
            this.AddEmployee.Location = new System.Drawing.Point(321, 230);
            this.AddEmployee.Name = "AddEmployee";
            this.AddEmployee.Size = new System.Drawing.Size(132, 27);
            this.AddEmployee.TabIndex = 4;
            this.AddEmployee.Text = "Add Employee";
            this.AddEmployee.UseVisualStyleBackColor = true;
            this.AddEmployee.Click += new System.EventHandler(this.AddEmployee_Click);
            // 
            // RemoveEmployee
            // 
            this.RemoveEmployee.Location = new System.Drawing.Point(321, 265);
            this.RemoveEmployee.Name = "RemoveEmployee";
            this.RemoveEmployee.Size = new System.Drawing.Size(132, 61);
            this.RemoveEmployee.TabIndex = 5;
            this.RemoveEmployee.Text = "Remove Employee";
            this.RemoveEmployee.UseVisualStyleBackColor = true;
            this.RemoveEmployee.Click += new System.EventHandler(this.RemoveEmployee_Click);
            // 
            // UpdateEmployee
            // 
            this.UpdateEmployee.Location = new System.Drawing.Point(321, 332);
            this.UpdateEmployee.Name = "UpdateEmployee";
            this.UpdateEmployee.Size = new System.Drawing.Size(132, 29);
            this.UpdateEmployee.TabIndex = 6;
            this.UpdateEmployee.Text = "Update Employee";
            this.UpdateEmployee.UseVisualStyleBackColor = true;
            this.UpdateEmployee.Click += new System.EventHandler(this.UpdateEmployee_Click);
            // 
            // Sales
            // 
            this.Sales.Location = new System.Drawing.Point(321, 367);
            this.Sales.Name = "Sales";
            this.Sales.Size = new System.Drawing.Size(132, 28);
            this.Sales.TabIndex = 7;
            this.Sales.Text = "Sales";
            this.Sales.UseVisualStyleBackColor = true;
            this.Sales.Click += new System.EventHandler(this.Sales_Click);
            // 
            // LogOut
            // 
            this.LogOut.Location = new System.Drawing.Point(321, 412);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(132, 26);
            this.LogOut.TabIndex = 8;
            this.LogOut.Text = "Log Out";
            this.LogOut.UseVisualStyleBackColor = true;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 36);
            this.label1.TabIndex = 9;
            this.label1.Text = "Admin Menu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // EmployeeInfo
            // 
            this.EmployeeInfo.Location = new System.Drawing.Point(321, 195);
            this.EmployeeInfo.Name = "EmployeeInfo";
            this.EmployeeInfo.Size = new System.Drawing.Size(132, 29);
            this.EmployeeInfo.TabIndex = 10;
            this.EmployeeInfo.Text = "Employee Info";
            this.EmployeeInfo.UseVisualStyleBackColor = true;
            this.EmployeeInfo.Click += new System.EventHandler(this.EmployeeInfo_Click);
            // 
            // MenuCard
            // 
            this.MenuCard.Location = new System.Drawing.Point(321, 72);
            this.MenuCard.Name = "MenuCard";
            this.MenuCard.Size = new System.Drawing.Size(132, 25);
            this.MenuCard.TabIndex = 12;
            this.MenuCard.Text = "Menu Card";
            this.MenuCard.UseVisualStyleBackColor = true;
            this.MenuCard.Click += new System.EventHandler(this.MenuCard_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MenuCard);
            this.Controls.Add(this.EmployeeInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.Sales);
            this.Controls.Add(this.UpdateEmployee);
            this.Controls.Add(this.RemoveEmployee);
            this.Controls.Add(this.AddEmployee);
            this.Controls.Add(this.UpdateDish);
            this.Controls.Add(this.RemoveDish);
            this.Controls.Add(this.AddDish);
            this.Name = "AdminForm";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddDish;
        private System.Windows.Forms.Button RemoveDish;
        private System.Windows.Forms.Button UpdateDish;
        private System.Windows.Forms.Button AddEmployee;
        private System.Windows.Forms.Button RemoveEmployee;
        private System.Windows.Forms.Button UpdateEmployee;
        private System.Windows.Forms.Button Sales;
        private System.Windows.Forms.Button LogOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EmployeeInfo;
        private System.Windows.Forms.Button MenuCard;
    }
}