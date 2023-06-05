namespace WindowsFormsApplication7
{
    partial class ManageProductPage
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
            this.addItems = new System.Windows.Forms.GroupBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.itemCategory = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.itemPrice = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.itemName = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.allFoodItems = new System.Windows.Forms.DataGridView();
            this.addItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allFoodItems)).BeginInit();
            this.SuspendLayout();
            // 
            // addItems
            // 
            this.addItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addItems.Controls.Add(this.deleteBtn);
            this.addItems.Controls.Add(this.updateBtn);
            this.addItems.Controls.Add(this.itemCategory);
            this.addItems.Controls.Add(this.addBtn);
            this.addItems.Controls.Add(this.categoryTextBox);
            this.addItems.Controls.Add(this.itemPrice);
            this.addItems.Controls.Add(this.priceTextBox);
            this.addItems.Controls.Add(this.itemName);
            this.addItems.Controls.Add(this.nameTextBox);
            this.addItems.Location = new System.Drawing.Point(82, 12);
            this.addItems.Name = "addItems";
            this.addItems.Size = new System.Drawing.Size(507, 215);
            this.addItems.TabIndex = 0;
            this.addItems.TabStop = false;
            this.addItems.Text = "Manage items";
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(335, 172);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 7;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(219, 172);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 23);
            this.updateBtn.TabIndex = 6;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // itemCategory
            // 
            this.itemCategory.AutoSize = true;
            this.itemCategory.Location = new System.Drawing.Point(126, 120);
            this.itemCategory.Name = "itemCategory";
            this.itemCategory.Size = new System.Drawing.Size(49, 13);
            this.itemCategory.TabIndex = 5;
            this.itemCategory.Text = "Category";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(104, 172);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.Location = new System.Drawing.Point(181, 120);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(191, 20);
            this.categoryTextBox.TabIndex = 4;
            // 
            // itemPrice
            // 
            this.itemPrice.AutoSize = true;
            this.itemPrice.Location = new System.Drawing.Point(126, 78);
            this.itemPrice.Name = "itemPrice";
            this.itemPrice.Size = new System.Drawing.Size(31, 13);
            this.itemPrice.TabIndex = 3;
            this.itemPrice.Text = "Price";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(181, 78);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(191, 20);
            this.priceTextBox.TabIndex = 2;
            // 
            // itemName
            // 
            this.itemName.AutoSize = true;
            this.itemName.Location = new System.Drawing.Point(126, 39);
            this.itemName.Name = "itemName";
            this.itemName.Size = new System.Drawing.Size(35, 13);
            this.itemName.TabIndex = 1;
            this.itemName.Text = "Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(181, 39);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(191, 20);
            this.nameTextBox.TabIndex = 0;
            // 
            // allFoodItems
            // 
            this.allFoodItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allFoodItems.Location = new System.Drawing.Point(82, 233);
            this.allFoodItems.Name = "allFoodItems";
            this.allFoodItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.allFoodItems.Size = new System.Drawing.Size(507, 150);
            this.allFoodItems.TabIndex = 1;
            this.allFoodItems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.allFoodItems_CellClick);
            // 
            // ManageProductPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 385);
            this.Controls.Add(this.allFoodItems);
            this.Controls.Add(this.addItems);
            this.Name = "ManageProductPage";
            this.Text = "Manage Products";
            this.Load += new System.EventHandler(this.ManageProductPage_Load);
            this.addItems.ResumeLayout(false);
            this.addItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allFoodItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox addItems;
        private System.Windows.Forms.Label itemCategory;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.Label itemPrice;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label itemName;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.DataGridView allFoodItems;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
    }
}