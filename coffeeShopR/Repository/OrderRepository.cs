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
    public class OrderRepository
    {
        public bool Add(Order order)
        {
            bool isadded = false;
            //Connection

            string connectionString = @"Server=DESKTOP-55FHBO2;Database=CoffeeShopR;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command

            string commandString = @"insert into orders (Quantity,TotalPrice,Customer,Item) values ('" + order.Quantity + "','" + order.TotalPrice + "','" + order.Customer + "','"+ order.Item + "');";
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

        public bool IsNameExist(Order order)
        {

            bool exist = false;

            //Connection

            string connectionString = @"Server=DESKTOP-55FHBO2;Database=CoffeeShopR;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command

            string commandString = @"select*from orders where CustomerName ='" + order.Customer + "'";
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


        //public bool Delete(Order order)
        //{
        //    bool isdeleted = false;

        //    //Connection

        //    string connectionString = @"Server=DESKTOP-55FHBO2;Database=CoffeeShopR;Integrated Security=True";
        //    SqlConnection sqlConnection = new SqlConnection(connectionString);

        //    //Command

        //    string commandString = @"delete from orders where Id='" + order.Id + "';";
        //    SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

        //    //Open

        //    sqlConnection.Open();

        //    //Execute

        //    int isExucuted = sqlCommand.ExecuteNonQuery();

        //    if (isExucuted > 0)
        //    {
        //        isdeleted = true;
        //    }

        //    //Close

        //    sqlConnection.Close();

        //    return isdeleted;
        //}

        //public bool Update(Order order)

        //{
        //    bool isupdate = false;


        //    //Connection

        //    string connectionString = @"Server=DESKTOP-55FHBO2;Database=CoffeeShopR;Integrated Security=True";
        //    SqlConnection sqlConnection = new SqlConnection(connectionString);

        //    //Command

        //    string commandString = @"update orders set Quantity='" + order.Quantity + "',TotalPrice='" + order.TotalPrice + "',CustomerName='" + order.CustomerName + "',ItemName='" + order.ItemName + "' where Id='" + order.Id + "';";
        //    SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

        //    //Open

        //    sqlConnection.Open();

        //    //Execute

        //    int isexecute = sqlCommand.ExecuteNonQuery();

        //    if (isexecute > 0)
        //    {
        //        isupdate = true;
        //    }

        //    //Close

        //    sqlConnection.Close();

        //    return isupdate;
        //}

        public DataTable Display()
        {
            //Connection

            string connectionString = @"Server=DESKTOP-55FHBO2;Database=CoffeeShopR;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command

            string commandString = @"select*from orders";
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

        //public DataTable Search(Order order)
        //{

        //    //Connection

        //    string connectionString = @"Server=DESKTOP-55FHBO2;Database=CoffeeShopR;Integrated Security=True";
        //    SqlConnection sqlConnection = new SqlConnection(connectionString);

        //    //Command

        //    string commandString = @"select*from orders where CustomerName ='" + order.CustomerName + "' or ItemName ='" + order.ItemName + "'";
        //    SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

        //    //Open

        //    sqlConnection.Open();

        //    //Execute

        //    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
        //    DataTable dataTable = new DataTable();
        //    sqlDataAdapter.Fill(dataTable);
        //    // showdataGridView.DataSource = dataTable;


        //    //if (dataTable.Rows.Count > 0)
        //    //{
        //    //    showdataGridView.DataSource = dataTable;
        //    //}
        //    //else
        //    //{
        //    //    MessageBox.Show("Data Tabel not found");

        //    //}

        //    //Close

        //    sqlConnection.Close();


        //    return dataTable;
        //}

        public DataTable ItemCombo()
        {
            //Connection

            string connectionString = @"Server=DESKTOP-55FHBO2;Database=CoffeeShopR;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command

            string commandString = @"select Item , ItemId from orders";
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

        public DataTable CustomerCombo()
        {
            //Connection

            string connectionString = @"Server=DESKTOP-55FHBO2;Database=CoffeeShopR;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command

            string commandString = @"select Customer , CustomerId from orders";
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

    }
}
