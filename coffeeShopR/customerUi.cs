using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using coffeeShopR.Manager;
using coffeeShopR.Model;

namespace coffeeShopR
{
    public partial class customerUi : Form
    {

        CustomerManager _customerManager = new CustomerManager();

        public customerUi()
        {
            InitializeComponent();
        }

   

        private void addButton_Click(object sender, EventArgs e)
        {

            Customer customer = new Customer();

            customer.CustomerName = customernameTextBox.Text;

            //Check UNIQUE
            if (_customerManager.IsNameExist(customer))
            {
                MessageBox.Show(customernameTextBox.Text + " Already Exists!");
                return;
            }

            customer.Adrs = addressTextBox.Text;
            customer.Contact = contactTextBox.Text;
            //customer.Id = Convert.ToInt16(idTextBox.Text);

            bool isAdded = _customerManager.Add(customer);


          if (isAdded)
          {
              MessageBox.Show("Saved");
              showdataGridView.DataSource = _customerManager.Display();

            }
          else
          {
              MessageBox.Show("Not Saved");
            }

         

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

            Customer customer = new Customer();

            customer.CustomerName = customernameTextBox.Text;
            customer.Adrs = addressTextBox.Text;
            customer.Contact = contactTextBox.Text;


            //Set ID as Mandatory

            if (String.IsNullOrEmpty(customernameTextBox.Text))
            {
                MessageBox.Show("Name Can not be Empty!!!");
                return;
            }


            bool isDeleted = _customerManager.Delete(customer);

            if (isDeleted)
            {
                MessageBox.Show("Deleted");
                showdataGridView.DataSource = _customerManager.Display();
            }
            else
            {
                MessageBox.Show(" Not Deleted");

            }

           
        }

        private void updateButton_Click(object sender, EventArgs e)
        {

            Customer customer = new Customer();

            customer.CustomerName = customernameTextBox.Text;
            customer.Adrs = addressTextBox.Text;
            customer.Contact = contactTextBox.Text;

            ////Set ID as Mandatory

            //if (String.IsNullOrEmpty(idTextBox.Text))
            //{
            //    MessageBox.Show("ID Can not be Empty!!!");
            //    return;
            //}

            bool isUpdated = _customerManager.Update(customer);

            if (isUpdated)
            {
                MessageBox.Show("Updated");
                showdataGridView.DataSource = _customerManager.Display();
            }
            else
            {
                MessageBox.Show("Not Updated");
            }

           

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            showdataGridView.DataSource = _customerManager.Display();


        }

        private void searchButton_Click(object sender, EventArgs e)
        {

            Customer customer = new Customer();

            customer.CustomerName = customernameTextBox.Text;
            customer.Adrs = addressTextBox.Text;
            customer.Contact = contactTextBox.Text;

            //Set Name as Mandatory

            //if (String.IsNullOrEmpty(customernameTextBox.Text))
            //{
            //    MessageBox.Show("Name Can not be Empty!!!");
            //    return;
            //}

            showdataGridView.DataSource = _customerManager.Search(customer);
        }

        private void customerUi_Load(object sender, EventArgs e)
        {
            if (showdataGridView.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {
                string customername = showdataGridView.SelectedRows[0].Cells[1].Value + string.Empty;
                string contact = showdataGridView.SelectedRows[0].Cells[2].Value + string.Empty;
                string address = showdataGridView.SelectedRows[0].Cells[3].Value + string.Empty;

                customernameTextBox.Text = customername;
                contactTextBox.Text = contact;
                addressTextBox.Text = address;
            }
        }
    }
}
