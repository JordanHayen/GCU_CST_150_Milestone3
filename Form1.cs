using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milestone3
{
    public partial class Form1 : Form
    {
        InventoryManager manager; // An InventoryManager object
        const string LISTBOXHEADER = "Item\t\tStock\t\tPrice"; // A string constant that will contain the header for the InventoryDisplay ListBox. Made with help from Microsoft documentation (2021)

        public Form1()
        {
            InitializeComponent();
        }

        // This code runs when the form is loaded. It sets the manager field to a new InventoryManager object
        private void Form1_Load(object sender, EventArgs e)
        {
            manager = new InventoryManager();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            manager.AddItem(new InventoryItem("Forks", 300, 4.99));
            manager.AddItem(new InventoryItem("Knives", 550, 7.99));
            manager.AddItem(new InventoryItem("Spoons", 875, 3.99));

            InventoryDisplay.Items.AddRange(manager.Display().ToArray());
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        // This code runs when the AddItem button is clicked. It processes data from the TextBoxes for the new item's name, price and stock, uses that information to create a new InventoryItem, adds that to the manager field, and updates the InventoryDisplay ListBox
        private void AddItem_Click(object sender, EventArgs e)
        {
            try
            {
                manager.AddItem(new InventoryItem(ItemNameTextBox.Text, int.Parse(ItemStockTextBox.Text), double.Parse(ItemPriceTextBox.Text))); // Processes data from the TextBoxes for the new item's name, price and stock and uses that information to create a new InventoryItem, then add that InventoryItem to the manager object
                InventoryDisplay.Items.Clear(); // Clears the InventoryDisplay ListBox. Made with help from the textbook (Gaddis, 257)
                InventoryDisplay.Items.Add(LISTBOXHEADER); // Adds the LISTBOXHEADER string to the InventoryDisplay ListBox
                InventoryDisplay.Items.AddRange(manager.Display().ToArray()); // Calls the manager object's Display method, sets the result to an array, and adds the result to the InventoryDisplay ListBox
            }
            catch(Exception ex) // If any errors occur when parsing data from the TextBoxes, a message box containing the error message is displayed
            {
                MessageBox.Show(ex.Message);
            }

            // The TextBoxes are cleared
            ItemNameTextBox.Text = "";
            ItemStockTextBox.Text = "";
            ItemPriceTextBox.Text = "";
        }

        //  This code runs when an item is selected in the InventoryDisplay ListBox. If the selected item is not the heder, then the button for removing an item is displayed, along with the button and TextBoxes used to edit an item
        private void InventoryDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(InventoryDisplay.SelectedIndex > 0) // If an item is selected that is not the header, then the button for removing an item is displayed, along with the button and TextBoxes used to edit an item
            {
                RemoveSelected.Visible = true; // The button for removing a selected item is set to be visible
                EditSelected.Visible = true; // The button for editting a selected item is set to be visible
                ItemNameEditorTextBox.Visible = true; // The TextBox for editting an item's name is set to be visible
                ItemNameEditorTextBox.Text = manager.Items[InventoryDisplay.SelectedIndex - 1].ItemName;
                ItemStockEditorTextBox.Visible = true; // The textbox for editting an item's stock is set to be visible
                ItemStockEditorTextBox.Text = manager.Items[InventoryDisplay.SelectedIndex - 1].Stock.ToString();
                ItemPriceEditorTextBox.Visible = true; // The textbox for editting an item's price is set to be visible
                ItemPriceEditorTextBox.Text = manager.Items[InventoryDisplay.SelectedIndex - 1].Price.ToString();
                AddStockButton.Visible = true; // The button for adding to an item's stock is set to be visible 
                AddStockTextBox.Visible = true; // The textbox for adding to an item's stock is set to be visible
            } 
            else
            {
                RemoveSelected.Visible = false; // The button for removing a selected item is set to be invisible
                EditSelected.Visible = false; // The button for editting a selected item is set to be invisible
                ItemNameEditorTextBox.Visible = false; // The textbox for editting an item's name is set to be invisible
                ItemStockEditorTextBox.Visible = false; // The textbox for editting an item's stock is set to be invisible
                ItemPriceEditorTextBox.Visible = false; // The textbox for editting an item's price is set to be invisible
                AddStockButton.Visible = false; // The button for adding to an item's stock is set to be invisible
                AddStockTextBox.Visible = false; // The textbox for adding to an item's stock is set to be invisible
            }
        }

        // This code runs when the RemoveSelected button is clicked. It removes the selected item from the manager object and updates the InventoryDisplay listbox
        private void RemoveSelected_Click(object sender, EventArgs e)
        {
            int selectedIndex = InventoryDisplay.SelectedIndex; // An integer variable that stores the selected index of the InventoryDisplay object at the start of the method
            manager.RemoveItem(manager.Items[InventoryDisplay.SelectedIndex - 1]); // The item selected is removed from the manager object
            InventoryDisplay.Items.Clear(); // The InventoryDisplay listbox is cleared. Made with help from the textbook (Gaddis, 257)
            InventoryDisplay.Items.Add(LISTBOXHEADER); // The LISTBOXHEADER string is added to the InventoryDisplay listbox
            InventoryDisplay.Items.AddRange(manager.Display().ToArray()); // Calls the manager object's Display method, sets the result to an array, and adds the result to the InventoryDisplay ListBox
            InventoryDisplay.SelectedIndex = selectedIndex - 1; // The selected index of the InventoryDisplay listbox is set to the selectedIndex variable minus one
            if(selectedIndex - 1 == 0) // If the selectedIndex variable minus one equals zero, then the item in the InventoryDisplay listbox is deselected
            {
                InventoryDisplay.SelectedIndex = -1;
            }
        }

        // This code runs when the EditSelected button is clicked. It changes the ItemName, Stock and Price of the selected InventoryItem based on data entered in the textboxes
        private void EditSelected_Click(object sender, EventArgs e)
        {
            try
            {
                manager.Items[InventoryDisplay.SelectedIndex - 1].ItemName = ItemNameEditorTextBox.Text; // The name of the selected InventoryItem is set to the data entered in the textbox
                manager.RestockItem(manager.Items[InventoryDisplay.SelectedIndex - 1], int.Parse(ItemStockEditorTextBox.Text) - manager.Items[InventoryDisplay.SelectedIndex - 1].Stock); // The stock of the selected InventoryItem is set to the data entered in the textbox
                manager.Items[InventoryDisplay.SelectedIndex - 1].Price = double.Parse(ItemPriceEditorTextBox.Text);  // The price of the selected InventoryItem is set to the data entered in the textbox
                InventoryDisplay.Items.Clear(); // The InventoryDisplay listbox is cleared. Made with help from the textbook (Gaddis, 257)
                InventoryDisplay.Items.Add(LISTBOXHEADER); // The LISTBOXHEADER string is added to the InventoryDisplay listbox
                InventoryDisplay.Items.AddRange(manager.Display().ToArray()); // Calls the manager object's Display method, sets the result to an array, and adds the result to the InventoryDisplay ListBox

                // The textboxes are cleared
                ItemNameEditorTextBox.Text = "";
                ItemStockEditorTextBox.Text = "";
                ItemPriceEditorTextBox.Text = "";

                RemoveSelected.Visible = false; // The button for removing a selected item is set to be invisible
                EditSelected.Visible = false; // The button for editting a selected item is set to be invisible
                ItemNameEditorTextBox.Visible = false; // The textbox for editting an item's name is set to be invisible
                ItemStockEditorTextBox.Visible = false; // The textbox for editting an item's stock is set to be invisible
                ItemPriceEditorTextBox.Visible = false; // The textbox for editting an item's price is set to be invisible
                AddStockButton.Visible = false; // The button for adding to an item's stock is set to be invisible
                AddStockTextBox.Visible = false; // The textbox for adding to an item's stock is set to be invisible
            }
            catch(Exception ex) // If any errors occur when parsing data from the textboxes, a message box containing the error message is displayed
            {
                MessageBox.Show(ex.Message);
            }

        }

        // This code runs when the AddStockButton is clicked. It adds the data entered in the textbox to the selected InventoryItem's stock
        private void AddStockButton_Click(object sender, EventArgs e)
        {
            try 
            {
                manager.RestockItem(manager.Items[InventoryDisplay.SelectedIndex - 1], int.Parse(AddStockTextBox.Text)); // The manager object's RestockItem method is called with the selected InventoryItem and the data from the textbox as parameters
                InventoryDisplay.Items.Clear(); // The InventoryDisplay listbox is cleared. Made with help from the textbook (Gaddis, 257)
                InventoryDisplay.Items.Add(LISTBOXHEADER); // The LISTBOXHEADER string is added to the InventoryDisplay listbox
                InventoryDisplay.Items.AddRange(manager.Display().ToArray()); // Calls the manager object's Display method, sets the result to an array, and adds the result to the InventoryDisplay ListBox
            }
            catch(Exception ex) // If any errors occur when parsing data from the textboxes, a message box containing the error message is displayed
            {
                MessageBox.Show(ex.Message);
            }
        }

        // This code runs when the text of the SearchBar textbox is changed. The manager object's Search method is called with the data entered in the textbox as a parameter and the results are displayed in the SearchResult listbox
        private void SearchBar_TextChanged(object sender, EventArgs e)
        {
            List<int> indeces = new List<int>(); // A List of integers that will contain the output of the Search method
            List<InventoryItem> items = new List<InventoryItem>(); // A List of InventoryItem objects that will contain the output of the Search method

            SearchResults.Items.Clear(); // The SearchResults listbox is cleared

            manager.Search(SearchBar.Text, out indeces, out items); // The manager object's Search method is called with the text of the SearchBar textbox, the indeces List, and the items List as parameters
            SearchResults.Items.AddRange((from item in items select item.ItemName).ToArray<string>()); // LINQ is used to add the names of the found items to the SearchResults listbox. Made with help from Codecademy (n.d.)
        }

        // This code runs when an item is selected in the SearchResults listbox. It selects the corresponding item in the InventoryDisplay listbox
        private void SearchResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            for(int i = 0; i < manager.Items.Count; i++) // This loop iterates for every item in the manager object
            {
                if (manager.Items[i].ItemName == (string)SearchResults.SelectedItem) // If the current ItemName property of the current item is equal to the SelectItem of the SearchResults listbox, the SelectedIndex of the InventoryDisplay listbox is set to the index of the item in the manager object plus one
                {
                    InventoryDisplay.SelectedIndex = manager.Items.IndexOf(manager.Items[i]) + 1;
                }
            }
            
        }

    }
}

// References:
// Codecademy. (n.d.).Learn C#: Lists and LINQ. https://www.codecademy.com/learn/learn-c-sharp/modules/learn-csharp-lists-and-linq/cheatsheet
// Gaddis, T. (2020). Starting Out With Visual C#. Pearson.
// Microsoft. (2021, September 15). Character Escapes in Regular Expressions. https://docs.microsoft.com/en-us/dotnet/standard/base-types/character-escapes-in-regular-expressions
