using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalCafeApp
{
    public partial class shopTill : Form
    {
        //public List<dynamic> Test = new List<dynamic>(); 
        
        public static DataTable tillTest()
        {
            DataTable Test2 = new DataTable();
            Test2.Columns.Add("Name", typeof(String));
            Test2.Columns.Add("Value", typeof(double));
            return Test2;
        }
        public void costOfItems(double costOfItem)
        {

        }

        //public object itemCart()
        //{

        //}

        // adding an item to list
        private void purchaseItem(String nameOfItem, double costOfItem)
        {
            
        }
        //public void removeLastItem()
        //{
            /*Remove last Item           
            int lastItemIndex = 0;
            int lastCostItemIndex = 0;
            if (numberOfItems > 0)
            {
                --NumberOfItems;
                lastCostItemIndex = itemCostList.Count - 1;
                lastItemIndex = checkout.Items.Count - 1;
                if (LastItemIndex > 1)
                {
                    total -= ItemCostList[lastCostItemIndex];
                    checkout.Items.RemoveAt(lastItemIndex);
                    itemCostList.RemoveAt(lastCostItemIndex);
                };
                if (totalFlag)
                {
                    displayTotal();
                };
            };

            if (NumberOfItems == 0)
            {
                clearTotal();
                totalFlag = false;
            };
        */
        //}
        
        private void teaOrCoffee_Click(object sender, EventArgs e)
        {
            purchaseItem("Tea/Coffee", 0.90);
        }

        private void bottles_Click(object sender, EventArgs e)
        {
            purchaseItem("Bottle", 1.20);
        }

        private void soup_Click(object sender, EventArgs e)
        {
            purchaseItem("Soup", 1.00);
        }

        private void panini_Click(object sender, EventArgs e)
        {
            purchaseItem("Panini", 2.40);
        }

        private void pizza_Click(object sender, EventArgs e)
        {
            purchaseItem("Pizza", 2.50);
        }

        private void toppings_Click(object sender, EventArgs e)
        {
            purchaseItem("Toppings", 0.25);
        }

        private void bakedPotato_Click(object sender, EventArgs e)
        {
            purchaseItem("Baked Potato", 1.45);
        }

        private void sodas_Click(object sender, EventArgs e)
        {
            purchaseItem("Sodas", 1.60);
        }

        private void chips_Click(object sender, EventArgs e)
        {
            purchaseItem("Chips", 1.50);
        }

        private void curryAndRice_Click(object sender, EventArgs e)
        {
            purchaseItem("Curry & Rice", 1.80);
        }

        private void fry_Click(object sender, EventArgs e)
        {
            purchaseItem("Fry", 2.50);
        }

        private void sausageRolls_Click(object sender, EventArgs e)
        {
            purchaseItem("Sausage Rolls", 0.80);
        }

        private void clearCalculator_Click(object sender, EventArgs e)
        {

        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            int zero = 0;
        }

        private void periodButton_Click(object sender, EventArgs e)
        {

        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            int three = 3;
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            int two = 2;
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            int one = 1;
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            int six = 6;
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            int five = 5;
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            int four = 4;
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            int nine = 9;
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            int eight = 8;
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            int seven = 7;
        }

        private void checkoutButton_Click(object sender, EventArgs e)
        {

        }

        private void RemoveLastItem_Click(object sender, EventArgs e)
        {

        }

        private void clearCart_Click(object sender, EventArgs e)
        {

        }

        private void shopTill_Load(object sender, EventArgs e)
        {
            ItemCart.DataSource = tillTest();
            ItemCart.DisplayMember = "Name";
            ItemCart.ValueMember = "Value";
        }
    }
}
