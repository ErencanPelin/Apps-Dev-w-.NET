using System;
using System.Windows.Forms;

namespace Week8Program1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Complete the Method to create the payment receipt 
        public string GetReceipt()
        {
            // Write code to Initialize the variables for total proice and the recipt string
            double totalPrice = 0;
            string receipt = string.Empty;

            // Write code to Create a Checkbox array for food items and assigned each food item to an element
            CheckBox[] menuItems = new CheckBox[7];
            menuItems[0] = teaCoffeeCB;
            menuItems[1] = juiceCB;
            menuItems[2] = banBreadCB;
            menuItems[3] = cerealCB;
            menuItems[4] = sushiCB;
            menuItems[5] = pizzaCB;
            menuItems[6] = drinksCB;

            // Write code to Create a label array for food item prices and assigned each price item to an element
            Label[] price = new Label[7];
            price[0] = teaCoffeePLbl;
            price[1] = juicePLbl;
            price[2] = banBreadPLbl;
            price[3] = cerealPLbl;
            price[4] = sushiPLbl;
            price[5] = pizzaPLbl;
            price[6] = drinksPLbl;

            // Write code to Process each selected food item and calculate the total price
            for (int i = 0; i < menuItems.Length; i++)
            {
                if (menuItems[i].Checked)
                {
                    // Write code to Concatenate the selected food items and their price.
                    receipt += $"{menuItems[i].Text}: ${price[i].Text}\n";

                    //Write code to Calculate the total price
                    totalPrice += double.Parse(price[i].Text);
                }
            }

            // Write code to Add the total price to the Receipt
            receipt += $"\nSub Total: ${totalPrice}";

            // Write code to Return receipt
            return receipt;
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            var receipt = GetReceipt();
            MessageBox.Show($"Order:\n\n{receipt}");
        }

        private void exitButton_Click(object sender, EventArgs e) => Application.Exit();
    }
}
