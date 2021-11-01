namespace Milestone3
{
    partial class Form1
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
            this.InventoryDisplay = new System.Windows.Forms.ListBox();
            this.SearchResults = new System.Windows.Forms.ListBox();
            this.ItemNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ItemStockTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ItemPriceTextBox = new System.Windows.Forms.TextBox();
            this.AddItem = new System.Windows.Forms.Button();
            this.RemoveSelected = new System.Windows.Forms.Button();
            this.EditSelected = new System.Windows.Forms.Button();
            this.ItemPriceEditorTextBox = new System.Windows.Forms.TextBox();
            this.ItemStockEditorTextBox = new System.Windows.Forms.TextBox();
            this.ItemNameEditorTextBox = new System.Windows.Forms.TextBox();
            this.AddStockTextBox = new System.Windows.Forms.TextBox();
            this.AddStockButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SearchBar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // InventoryDisplay
            // 
            this.InventoryDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.InventoryDisplay.FormattingEnabled = true;
            this.InventoryDisplay.ItemHeight = 20;
            this.InventoryDisplay.Items.AddRange(new object[] {
            "Item\t\tStock\t\tPrice"});
            this.InventoryDisplay.Location = new System.Drawing.Point(12, 12);
            this.InventoryDisplay.Name = "InventoryDisplay";
            this.InventoryDisplay.Size = new System.Drawing.Size(388, 324);
            this.InventoryDisplay.TabIndex = 0;
            this.InventoryDisplay.SelectedIndexChanged += new System.EventHandler(this.InventoryDisplay_SelectedIndexChanged);
            // 
            // SearchResults
            // 
            this.SearchResults.FormattingEnabled = true;
            this.SearchResults.Location = new System.Drawing.Point(406, 64);
            this.SearchResults.Name = "SearchResults";
            this.SearchResults.Size = new System.Drawing.Size(159, 95);
            this.SearchResults.TabIndex = 5;
            this.SearchResults.SelectedIndexChanged += new System.EventHandler(this.SearchResults_SelectedIndexChanged);
            // 
            // ItemNameTextBox
            // 
            this.ItemNameTextBox.Location = new System.Drawing.Point(170, 413);
            this.ItemNameTextBox.Name = "ItemNameTextBox";
            this.ItemNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.ItemNameTextBox.TabIndex = 6;
            this.ItemNameTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(170, 373);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Item Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(300, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Item Stock";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ItemStockTextBox
            // 
            this.ItemStockTextBox.Location = new System.Drawing.Point(300, 413);
            this.ItemStockTextBox.Name = "ItemStockTextBox";
            this.ItemStockTextBox.Size = new System.Drawing.Size(100, 20);
            this.ItemStockTextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(430, 373);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Item Price";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ItemPriceTextBox
            // 
            this.ItemPriceTextBox.Location = new System.Drawing.Point(430, 413);
            this.ItemPriceTextBox.Name = "ItemPriceTextBox";
            this.ItemPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.ItemPriceTextBox.TabIndex = 10;
            // 
            // AddItem
            // 
            this.AddItem.Location = new System.Drawing.Point(40, 413);
            this.AddItem.Name = "AddItem";
            this.AddItem.Size = new System.Drawing.Size(100, 20);
            this.AddItem.TabIndex = 12;
            this.AddItem.Text = "Add Item";
            this.AddItem.UseVisualStyleBackColor = true;
            this.AddItem.Click += new System.EventHandler(this.AddItem_Click);
            // 
            // RemoveSelected
            // 
            this.RemoveSelected.Location = new System.Drawing.Point(406, 165);
            this.RemoveSelected.Name = "RemoveSelected";
            this.RemoveSelected.Size = new System.Drawing.Size(159, 41);
            this.RemoveSelected.TabIndex = 13;
            this.RemoveSelected.Text = "Remove Selected";
            this.RemoveSelected.UseVisualStyleBackColor = true;
            this.RemoveSelected.Visible = false;
            this.RemoveSelected.Click += new System.EventHandler(this.RemoveSelected_Click);
            // 
            // EditSelected
            // 
            this.EditSelected.Location = new System.Drawing.Point(40, 439);
            this.EditSelected.Name = "EditSelected";
            this.EditSelected.Size = new System.Drawing.Size(100, 20);
            this.EditSelected.TabIndex = 17;
            this.EditSelected.Text = "Edit Selected";
            this.EditSelected.UseVisualStyleBackColor = true;
            this.EditSelected.Visible = false;
            this.EditSelected.Click += new System.EventHandler(this.EditSelected_Click);
            // 
            // ItemPriceEditorTextBox
            // 
            this.ItemPriceEditorTextBox.Location = new System.Drawing.Point(430, 439);
            this.ItemPriceEditorTextBox.Name = "ItemPriceEditorTextBox";
            this.ItemPriceEditorTextBox.Size = new System.Drawing.Size(100, 20);
            this.ItemPriceEditorTextBox.TabIndex = 16;
            this.ItemPriceEditorTextBox.Visible = false;
            // 
            // ItemStockEditorTextBox
            // 
            this.ItemStockEditorTextBox.Location = new System.Drawing.Point(300, 439);
            this.ItemStockEditorTextBox.Name = "ItemStockEditorTextBox";
            this.ItemStockEditorTextBox.Size = new System.Drawing.Size(100, 20);
            this.ItemStockEditorTextBox.TabIndex = 15;
            this.ItemStockEditorTextBox.Visible = false;
            // 
            // ItemNameEditorTextBox
            // 
            this.ItemNameEditorTextBox.Location = new System.Drawing.Point(170, 439);
            this.ItemNameEditorTextBox.Name = "ItemNameEditorTextBox";
            this.ItemNameEditorTextBox.Size = new System.Drawing.Size(100, 20);
            this.ItemNameEditorTextBox.TabIndex = 14;
            this.ItemNameEditorTextBox.Visible = false;
            // 
            // AddStockTextBox
            // 
            this.AddStockTextBox.Location = new System.Drawing.Point(560, 439);
            this.AddStockTextBox.Name = "AddStockTextBox";
            this.AddStockTextBox.Size = new System.Drawing.Size(100, 20);
            this.AddStockTextBox.TabIndex = 18;
            this.AddStockTextBox.Visible = false;
            // 
            // AddStockButton
            // 
            this.AddStockButton.Location = new System.Drawing.Point(560, 413);
            this.AddStockButton.Name = "AddStockButton";
            this.AddStockButton.Size = new System.Drawing.Size(100, 20);
            this.AddStockButton.TabIndex = 19;
            this.AddStockButton.Text = "Add Stock";
            this.AddStockButton.UseVisualStyleBackColor = true;
            this.AddStockButton.Visible = false;
            this.AddStockButton.Click += new System.EventHandler(this.AddStockButton_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(406, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 23);
            this.label5.TabIndex = 20;
            this.label5.Text = "Search";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SearchBar
            // 
            this.SearchBar.Location = new System.Drawing.Point(406, 38);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(159, 20);
            this.SearchBar.TabIndex = 21;
            this.SearchBar.TextChanged += new System.EventHandler(this.SearchBar_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 506);
            this.Controls.Add(this.SearchBar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AddStockButton);
            this.Controls.Add(this.AddStockTextBox);
            this.Controls.Add(this.EditSelected);
            this.Controls.Add(this.ItemPriceEditorTextBox);
            this.Controls.Add(this.ItemStockEditorTextBox);
            this.Controls.Add(this.ItemNameEditorTextBox);
            this.Controls.Add(this.RemoveSelected);
            this.Controls.Add(this.AddItem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ItemPriceTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ItemStockTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ItemNameTextBox);
            this.Controls.Add(this.SearchResults);
            this.Controls.Add(this.InventoryDisplay);
            this.Name = "Form1";
            this.Text = "InventoryManager Class Test Program";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox InventoryDisplay;
        private System.Windows.Forms.ListBox SearchResults;
        private System.Windows.Forms.TextBox ItemNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ItemStockTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ItemPriceTextBox;
        private System.Windows.Forms.Button AddItem;
        private System.Windows.Forms.Button RemoveSelected;
        private System.Windows.Forms.Button EditSelected;
        private System.Windows.Forms.TextBox ItemPriceEditorTextBox;
        private System.Windows.Forms.TextBox ItemStockEditorTextBox;
        private System.Windows.Forms.TextBox ItemNameEditorTextBox;
        private System.Windows.Forms.TextBox AddStockTextBox;
        private System.Windows.Forms.Button AddStockButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SearchBar;
    }
}

