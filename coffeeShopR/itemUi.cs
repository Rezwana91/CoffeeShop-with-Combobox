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
        string id;
        ItemManager _itemManager =new ItemManager();

        public itemUi()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Item item = new Item();

            item.ItemName = itemnameTextBox.Text;


            //Set Name as Mandatory
            if (String.IsNullOrEmpty(itemnameTextBox.Text))
            {
                MessageBox.Show("Name Can not be Empty!!!");
                return;
            }

            //Set Price as Mandatory
            if (String.IsNullOrEmpty(priceTextBox.Text))
            {
                MessageBox.Show("Price Can not be Empty!!!");
                return;
            }
            item.Price = Convert.ToDouble(priceTextBox.Text);

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

            item.Id = Convert.ToInt32(id);



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
            item.Id = Convert.ToInt32(id);

            //Set Name as Mandatory
            if (String.IsNullOrEmpty(itemnameTextBox.Text))
            {
                MessageBox.Show("Name Can not be Empty!!!");
                return;
            }

            //Set Price as Mandatory
            if (String.IsNullOrEmpty(priceTextBox.Text))
            {
                MessageBox.Show("Price Can not be Empty!!!");
                return;
            }



            item.Price = Convert.ToDouble(priceTextBox.Text);


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




            //Set Name as Mandatory

            if (String.IsNullOrEmpty(itemnameTextBox.Text))
            {
                MessageBox.Show("Name Can not be Empty!!!");
                return;
            }
            
             item.ItemName = itemnameTextBox.Text;


            showdataGridView.DataSource = _itemManager.Search(item);

        }

       
       

        

        private void showdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.showdataGridView.Rows[e.RowIndex];
                id = row.Cells[0].Value.ToString();
                itemnameTextBox.Text = row.Cells[1].Value.ToString();
                priceTextBox.Text = row.Cells[2].Value.ToString();

            }
        }

     

    }
}
