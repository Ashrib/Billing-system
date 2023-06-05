using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication7
{
    public partial class ManageProductPage : Form
    {
        private readonly string pattern = @"^\d+$";
        private readonly SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4N5QPIK\SQLEXPRESS;Initial Catalog=FoodItems;Integrated Security=True");
        private int itemID;

        public ManageProductPage()
        {
            InitializeComponent();
        }

        public void ClearFields()
        {
            itemID = 0;
            nameTextBox.Clear();
            priceTextBox.Clear();
            categoryTextBox.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                InsertFoodItem(nameTextBox.Text, int.Parse(priceTextBox.Text), categoryTextBox.Text);
                MessageBox.Show("New item added successfully", "Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                GetAllItems();
            }
        }

        private void ManageProductPage_Load(object sender, EventArgs e)
        {
            GetAllItems();
        }

        private void GetAllItems()
        {
            DataTable dt = ExecuteQuery("select * from FoodItemTB");
            allFoodItems.DataSource = dt;
        }

        private bool IsValid()
        {
            try
            {
                if (string.IsNullOrEmpty(nameTextBox.Text))
                    throw new MyException("Name is required!");
                else if (string.IsNullOrEmpty(priceTextBox.Text))
                    throw new MyException("Price is required!");
                else if (string.IsNullOrEmpty(categoryTextBox.Text))
                    throw new MyException("Category is required!");
                else if (nameTextBox.Text.Length < 3)
                    throw new MyException("Name must be 3 or more characters!");
                else if (!Regex.IsMatch(priceTextBox.Text, pattern) || int.Parse(priceTextBox.Text) <= 0)
                    throw new MyException("Please input a proper Price!");
                else if (categoryTextBox.Text.Length < 3)
                    throw new MyException("Category must be 3 or more characters!");

                return true;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

        private void allFoodItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = allFoodItems.Rows[e.RowIndex];
                itemID = Convert.ToInt32(row.Cells["ItemID"].Value);
                nameTextBox.Text = row.Cells["Name"].Value.ToString();
                priceTextBox.Text = row.Cells["Price"].Value.ToString();
                categoryTextBox.Text = row.Cells["Category"].Value.ToString();
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (itemID > 0)
            {
                UpdateFoodItem(nameTextBox.Text, int.Parse(priceTextBox.Text), categoryTextBox.Text, itemID);
                MessageBox.Show("Item updated successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                GetAllItems();
            }
            else
            {
                MessageBox.Show("Please select an item to update its information", "Select", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (itemID > 0)
            {
                DeleteFoodItem(itemID);
                MessageBox.Show("Item deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
                GetAllItems();
            }
            else
            {
                MessageBox.Show("Please select an item to delete", "Select", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataTable ExecuteQuery(string query)
        {
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sqr = cmd.ExecuteReader();
            dt.Load(sqr);
            con.Close();
            return dt;
        }

        private void InsertFoodItem(string name, int price, string category)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO FoodItemTB VALUES (@Name, @Price, @Category)", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Price", price);
            cmd.Parameters.AddWithValue("@Category", category);

            ExecuteNonQueryCommand(cmd);
        }

        private void UpdateFoodItem(string name, int price, string category, int id)
        {
            SqlCommand cmd = new SqlCommand("UPDATE FoodItemTB SET Name=@Name, Price=@Price, Category=@Category WHERE ItemID=@ID", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Price", price);
            cmd.Parameters.AddWithValue("@Category", category);
            cmd.Parameters.AddWithValue("@ID", id);

            ExecuteNonQueryCommand(cmd);
        }

        private void DeleteFoodItem(int id)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM FoodItemTB WHERE ItemID=@ID", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@ID", id);

            ExecuteNonQueryCommand(cmd);
        }

        private void ExecuteNonQueryCommand(SqlCommand cmd)
        {
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }

    class MyException : Exception
    {
        public MyException(string msg) : base(msg) { }
    }
}
