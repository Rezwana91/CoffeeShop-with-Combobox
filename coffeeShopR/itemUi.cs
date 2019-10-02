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
    public partial class itemUi : Form
    {
        ItemManager _itemManager =new ItemManager();

        public itemUi()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Item item = new Item();

            item.ItemName = itemnameTextBox.Text;
            item.Price = Convert.ToDouble(priceTextBox.Text);

            //Set Name as Mandatory
            //if (String.IsNullOrEmpty(itemnameTextBox.Text))
            //{
            //    MessageBox.Show("Name Can not be Empty!!!");
            //    return;
            //}

            //Check UNIQUE
            if (_itemManager.IsNameExist(item))
            {
                MessageBox.Show(item.ItemName + " Already Exists!");
                return;
            }     

            bool isAdded = _itemManager.Add(item);


            if (isAdded)
            {
                MessageBox.Show("Saved");
                showdataGridView.DataSource  = _itemManager.Display();

            }
            else
            {
                MessageBox.Show("Not Saved");
            }

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

            Item item = new Item();

            item.ItemName = itemnameTextBox.Text;
            item.Price = Convert.ToDouble(priceTextBox.Text);
            
            ////Set ID as Mandatory

            //if (String.IsNullOrEmpty(idTextBox.Text))
            //{
            //    MessageBox.Show("ID Can not be Empty!!!");
            //    return;
           // }


            bool isDeleted = _itemManager.Delete(item);

            if (isDeleted)
            {
                MessageBox.Show("Deleted");
                showdataGridView.DataSource = _itemManager.Display();
            }
            else
            {
                MessageBox.Show(" Not Deleted");

            }


        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            Item item = new Item();

            item.ItemName = itemnameTextBox.Text;
            item.Price = Convert.ToDouble(priceTextBox.Text);

            

            ////Set ID as Mandatory

            //if (String.IsNullOrEmpty(idTextBox.Text))
            //{
            //    MessageBox.Show("ID Can not be Empty!!!");
            //    return;
            //}

            bool isUpdated = _itemManager.Update(item);

            if (isUpdated)
            {
                MessageBox.Show("Updated");
                showdataGridView.DataSource = _itemManager.Display();
            }
            else
            {
                MessageBox.Show("Not Updated");
            }

               
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            showdataGridView.DataSource = _itemManager.Display();

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            Item item = new Item();

            item.ItemName = itemnameTextBox.Text;
            item.Price = Convert.ToDouble(priceTextBox.Text);

            ////Set Name as Mandatory

            ////if (String.IsNullOrEmpty(itemnameTextBox.Text))
            ////{
            ////    MessageBox.Show("Name Can not be Empty!!!");
            ////    return;
            ////}

            
            showdataGridView.DataSource = _itemManager.Search(item);

        }

        //Method
        //Add

     
        //Delete

       
        //update

        

        //show

       

        //search
       

        

    }
}
