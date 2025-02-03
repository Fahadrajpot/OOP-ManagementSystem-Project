namespace WindowsForm.UI
{
    partial class UpdateEmployeePage
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
            this.Back = new System.Windows.Forms.Button();
            this.UpdateName = new System.Windows.Forms.Button();
            this.UpdateContact = new System.Windows.Forms.Button();
            this.EmployeeData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(287, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Update Employee";
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(204, 233);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(94, 43);
            this.Back.TabIndex = 1;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // UpdateName
            // 
            this.UpdateName.Location = new System.Drawing.Point(359, 233);
            this.UpdateName.Name = "UpdateName";
            this.UpdateName.Size = new System.Drawing.Size(81, 43);
            this.UpdateName.TabIndex = 2;
            this.UpdateName.Text = "Update Name";
            this.UpdateName.UseVisualStyleBackColor = true;
            this.UpdateName.Click += new System.EventHandler(this.UpdateName_Click);
            // 
            // UpdateContact
            // 
            this.UpdateContact.Location = new System.Drawing.Point(504, 233);
            this.UpdateContact.Name = "UpdateContact";
            this.UpdateContact.Size = new System.Drawing.Size(103, 43);
            this.UpdateContact.TabIndex = 3;
            this.UpdateContact.Text = "Update Contact No.";
            this.UpdateContact.UseVisualStyleBackColor = true;
            this.UpdateContact.Click += new System.EventHandler(this.UpdateContact_Click);
            // 
            // EmployeeData
            // 
            this.EmployeeData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeData.Location = new System.Drawing.Point(166, 99);
            this.EmployeeData.Name = "EmployeeData";
            this.EmployeeData.RowHeadersWidth = 51;
            this.EmployeeData.RowTemplate.Height = 24;
            this.EmployeeData.Size = new System.Drawing.Size(461, 91);
            this.EmployeeData.TabIndex = 4;
            this.EmployeeData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeeData_CellContentClick);
            // 
            // UpdateEmployeePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsForm.Properties.Resources._3download;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EmployeeData);
            this.Controls.Add(this.UpdateContact);
            this.Controls.Add(this.UpdateName);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.label1);
            this.Name = "UpdateEmployeePage";
            this.Text = "UpdateEmployeePage";
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button UpdateName;
        private System.Windows.Forms.Button UpdateContact;
        private System.Windows.Forms.DataGridView EmployeeData;
    }
}