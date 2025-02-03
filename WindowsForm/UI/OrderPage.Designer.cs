namespace WindowsForm.UI
{
    partial class OrderPage
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
            this.Back = new System.Windows.Forms.Button();
            this.DishList = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DishName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DishList)).BeginInit();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(238, 398);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(83, 30);
            this.Back.TabIndex = 12;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // DishList
            // 
            this.DishList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DishList.Location = new System.Drawing.Point(212, 99);
            this.DishList.Name = "DishList";
            this.DishList.RowHeadersWidth = 51;
            this.DishList.RowTemplate.Height = 24;
            this.DishList.Size = new System.Drawing.Size(387, 223);
            this.DishList.TabIndex = 15;
            this.DishList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DishList_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(447, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 30);
            this.button1.TabIndex = 14;
            this.button1.Text = "Order";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(314, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 32);
            this.label1.TabIndex = 13;
            this.label1.Text = "Make Order";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Enter Dish Name:";
            // 
            // DishName
            // 
            this.DishName.Location = new System.Drawing.Point(392, 350);
            this.DishName.Name = "DishName";
            this.DishName.Size = new System.Drawing.Size(100, 22);
            this.DishName.TabIndex = 17;
            // 
            // OrderPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DishName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DishList);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Back);
            this.Name = "OrderPage";
            this.Text = "OrderPage";
            ((System.ComponentModel.ISupportInitialize)(this.DishList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.DataGridView DishList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DishName;
    }
}