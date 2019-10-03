using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using coffeeShopR.Model;

namespace coffeeShopR.Repository
{
     public class CustomerRepository
    {
        public bool Add(Customer customer)
        {
            bool isadded = false;
            //Connection

            string connectionString = @"Server=DESKTOP-55FHBO2;Database=CoffeeShopR;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command

            string commandString = @"insert into customers (CustomerName,Adrs,Contact) values ('" + customer.CustomerName + "','" + customer.Adrs + "','" + customer.Contact + "');";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            //Open

            sqlConnection.Open();

            //Execute

            int isExucuted = sqlCommand.ExecuteNonQuery();

            if (isExucuted > 0)
            {
                isadded = true;
            }

            //Close

            sqlConnection.Close();

            return isadded;
        }

        public bool IsNameExist(Customer customer)
        {

            bool exist = false;

            //Connection

            string connectionString = @"Server=DESKTOP-55FHBO2;Database=CoffeeShopR;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command

            string commandString = @"select*from customers where CustomerName ='" + customer.CustomerName + "'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            //Open

            sqlConnection.Open();

            //Execute

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
           // showdataGridView.DataSource = dataTable;


            if (dataTable.Rows.Count > 0)
            {
                exist = true;
            }


            //Close

            sqlConnection.Close();

            return exist;
        }


        public bool Delete(Customer customer)
        {
            bool isdeleted = false;

            //Connection

            string connectionString = @"Server=DESKTOP-55FHBO2;Database=CoffeeShopR;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command

            string commandString = @"delete from customers where Id='" + customer.Id + "';";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            //Open

            sqlConnection.Open();

            //Execute

            int isExucuted = sqlCommand.ExecuteNonQuery();

            if (isExucuted > 0)
            {
                isdeleted = true;
            }

            //Close

            sqlConnection.Close();

            return isdeleted;
        }

        public bool Update(Customer customer)

        {
            bool isupdate = false;


            //Connection

            string connectionString = @"Server=DESKTOP-55FHBO2;Database=CoffeeShopR;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command

            string commandString = @"update customers set CustomerName='" + customer.CustomerName + "',Adrs='" + customer.Adrs + "',Contact='" + customer.Contact + "' where Id='" + customer.Id + "';";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            //Open

            sqlConnection.Open();

            //Execute

            int isexecute = sqlCommand.ExecuteNonQuery();

            if (isexecute > 0)
            {
                isupdate = true;
            }

            //Close

            sqlConnection.Close();

            return isupdate;
        }

        public DataTable Display()
        {
            //Connection

            string connectionString = @"Server=DESKTOP-55FHBO2;Database=CoffeeShopR;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command

            string commandString = @"select*from customers";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            //Open

            sqlConnection.Open();

            //Execute

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            //showdataGridView.DataSource = dataTable;


            //if (dataTable.Rows.Count > 0)
            //{
            //    //  showdataGridView.DataSource = dataTable;
            //}
            //else
            //{
            //    // MessageBox.Show("Data Tabel not found");

            //}

            //Close

            sqlConnection.Close();

            return dataTable;


        }
        public DataTable Search(Customer customer)
        {

            //Connection

            string connectionString = @"Server=DESKTOP-55FHBO2;Database=CoffeeShopR;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command

            string commandString = @"select * from customers where CustomerName ='" + customer.CustomerName + "'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            //Open

            sqlConnection.Open();

            //Execute

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
           // showdataGridView.DataSource = dataTable;


            //if (dataTable.Rows.Count > 0)
            //{
            //    showdataGridView.DataSource = dataTable;
            //}
            //else
            //{
            //    MessageBox.Show("Data Tabel not found");

            //}

            //Close

            sqlConnection.Close();

            return dataTable;


        }

        public DataTable Show(Customer customer)
        {
            //Connection

            string connectionString = @"Server=DESKTOP-55FHBO2;Database=CoffeeShopR;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command

            string commandString = @"select*from customers";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            //Open

            sqlConnection.Open();

            //Execute

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            //showdataGridView.DataSource = dataTable;


            //if (dataTable.Rows.Count > 0)
            //{
            //    //  showdataGridView.DataSource = dataTable;
            //}
            //else
            //{
            //    // MessageBox.Show("Data Tabel not found");

            //}

            //Close

            sqlConnection.Close();

            return dataTable;
        }
    }
}
