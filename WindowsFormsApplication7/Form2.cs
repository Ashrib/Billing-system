using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WindowsFormsApplication7
{
    public partial class MenuPage : Form
    {
        private readonly SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4N5QPIK\SQLEXPRESS;Initial Catalog=FoodItems;Integrated Security=True");

        public MenuPage()
        {
            InitializeComponent();
        }

        private void fastfood_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

    }
    private void GetAllItems()
    {
        DataTable dt = ExecuteQuery("select * from FoodItemTB");
        fastfood.DataSource = dt;
           
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

        private void MenuPage_Load(object sender, EventArgs e)
        {
            GetAllItems();
            dataGridView1.Columns.Add("Column1", "Column 1"); 
            dataGridView1.Columns.Add("Column2", "Column 2");
            dataGridView1.Columns.Add("Column3", "Column 3");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
        }
        private void fastfood_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = fastfood.Rows[e.RowIndex];
            DataTable dt = new DataTable();
            SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-4N5QPIK\SQLEXPRESS;Initial Catalog=FoodItems;Integrated Security=True");

            string id = row.Cells[0].Value.ToString();
            SqlCommand cmd = new SqlCommand("Select *FROM FoodItemTB WHERE ItemID=@ID", Con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@ID", id);

            Con.Open();
            SqlDataReader sqr = cmd.ExecuteReader();
            dt.Load(sqr);
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                dataGridView1.Rows.Add(dr.ItemArray);
            }
            con.Close();
        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            int total = 0;

            if (dataGridView1.Rows.Count == 1)
            {
                MessageBox.Show("Select items first to order!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DataGridViewRow row = dataGridView1.Rows[i];

                if (row.Cells[2].Value != null)
                {
                    int price;
                    if (int.TryParse(row.Cells[2].Value.ToString(), out price))
                    {
                        total += price;
                    }
                    else
                    {
                        MessageBox.Show("Invalid price value for row " + (i + 1), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            DialogResult result = MessageBox.Show("Do you want to pdf of your bill?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf|*.pdf)";
                save.FileName = "Bill";
                bool ErrorMessage = false;
                if (save.ShowDialog()==DialogResult.OK)
                {
                    if (File.Exists(save.FileName))
                    {
                        try {
                            File.Delete(save.FileName);
                        }
                        catch (Exception ex)
                        {
                            ErrorMessage = true;
                            MessageBox.Show("unable to wride data in disk",ex.Message);
                        }
                    }
                    if (!ErrorMessage)
                    {
                        try {
                            PdfPTable pTable = new pdfPTable();
                        }
                        catch (Exception)
                        {

                        }
                    }
                }
            }
            MessageBox.Show($"Your total amount to pay: {total}","Bill",MessageBoxButtons.OK,MessageBoxIcon.Information);
            dataGridView1.Rows.Clear();
        }

    }
}
