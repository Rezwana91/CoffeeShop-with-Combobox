using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using coffeeShopR.Manager;
using coffeeShopR.Model;

namespace coffeeShopR
{
    public partial class orderUi : Form
    {
        private OrderManager _orderManager = new OrderManager();

        public orderUi()
        {
            InitializeComponent();
        }

         private void addButton_Click(object sender, EventArgs e)
        {
             Order order = new Order();
            
             order.Customer = customerComboBox.Text;
             order.Item = itemComboBox.Text;

             //int price = Convert.ToInt16(itemComboBox.SelectedValue);

             //MessageBox.Show("" + price);
             order.Quantity = Convert.ToInt16(quantityTextBox.Text);
             
             order.Id = Convert.ToInt16(customerComboBox.SelectedValue);

            //Set Name as Mandatory
            //if (String.IsNullOrEmpty(customernameTextBox.Text))
            //{
            //    MessageBox.Show("Name Can not be Empty!!!");
            //    return;
            //}

            //Check UNIQUE
            if (_orderManager.IsNameExist(order))
            {
                MessageBox.Show(order + " Already Exists!");
                return;
            }

            //Check UNIQUE
            //if (_orderManager.IsInameExist(itemnameTextBox.Text))
            //{
            //    MessageBox.Show(itemnameTextBox.Text + " Already Exists!");
            //    return;
            //}

            bool isAdded = _orderManager.Add(order);


            if (isAdded)
            {
                MessageBox.Show("Saved");
                showdataGridView.DataSource= _orderManager.Display();
                //order.TotalPrice = Convert.ToDouble(totalpriceTextBox.Text) * price;

            }
            else
            {
                MessageBox.Show("Not Saved");
            }



         }

        //private void deleteButton_Click(object sender, EventArgs e)
        //{
        //    Order order = new Order();

        //    order.CustomerName = customerComboBox.Text;
        //    order.ItemName = itemComboBox.Text;
        //    order.Quantity = Convert.ToInt16(quantityTextBox.Text);
        //    order.TotalPrice = Convert.ToDouble(totalpriceTextBox.Text);
        //    order.Id = Convert.ToInt16(customerComboBox.SelectedValue);

        //    ////Set ID as Mandatory

        //    //if (String.IsNullOrEmpty(idTextBox.Text))
        //    //{
        //    //    MessageBox.Show("ID Can not be Empty!!!");
        //    //    return;
        //    //}


        //    bool isDeleted = _orderManager.Delete(order);

        //    if (isDeleted)
        //    {
        //        MessageBox.Show("Deleted");
        //        showdataGridView.DataSource = _orderManager.Display();
        //    }
        //    else
        //    {
        //        MessageBox.Show(" Not Deleted");

        //    }
        //}

        //private void updateButton_Click(object sender, EventArgs e)
        //{
        //    Order order = new Order();

        //    order.CustomerName = customerComboBox.Text;
        //    order.ItemName = itemComboBox.Text;
        //    order.Quantity = Convert.ToInt16(quantityTextBox.Text);
        //    order.TotalPrice = Convert.ToDouble(totalpriceTextBox.Text);
        //    order.Id = Convert.ToInt16(customerComboBox.SelectedValue);

        //    ////Set ID as Mandatory

        //    //if (String.IsNullOrEmpty(idTextBox.Text))
        //    //{
        //    //    MessageBox.Show("ID Can not be Empty!!!");
        //    //    return;
        //    //}

        //    bool isUpdated = _orderManager.Update(order);

        //    if (isUpdated)
        //    {
        //        MessageBox.Show("Updated");

        //        showdataGridView.DataSource = _orderManager.Display();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Not Updated");
        //    }

        //}

        //private void showButton_Click(object sender, EventArgs e)
        //{

        //    showdataGridView.DataSource = _orderManager.Display();
        //}

        //private void searchButton_Click(object sender, EventArgs e)
        //{

        //    ////Set Name as Mandatory

        //    //if (String.IsNullOrEmpty(customernameTextBox.Text))
        //    //{
        //    //    MessageBox.Show("Name Can not be Empty!!!");
        //    //    return;
        //    //}

        //    Order order = new Order();

        //    order.CustomerName = customerComboBox.Text;
        //    order.ItemName = itemComboBox.Text;
        //    order.Quantity = Convert.ToInt16(quantityTextBox.Text);
        //    order.TotalPrice = Convert.ToDouble(totalpriceTextBox.Text);
        //    order.Id = Convert.ToInt16(customerComboBox.SelectedValue);

        //    showdataGridView.DataSource = _orderManager.Search(order);
        //}

        private void orderUi_Load(object sender, EventArgs e)
        {

           
            itemComboBox.DataSource = _orderManager.CustomerCombo();
            customerComboBox.DataSource = _orderManager.ItemCombo();

        }





        //Method
        //Add


        //delete


        //update


        //show






    }
}
