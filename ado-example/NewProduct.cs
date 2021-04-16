using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ado_example
{
    public partial class NewProduct : Form
    {
        private string studentId;
        private string connectionString = "server=LAB35\\SQL2012;database=abc;uid=lab;pwd=";

        public NewProduct(string studentId)
        {
            this.studentId = studentId;
            InitializeComponent();
        }

        private void NewProduct_Load(object sender, EventArgs e)
        {
            try
            {

                SqlConnection conn = new SqlConnection(connectionString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string queryString = "SELECT * FROM Students WHERE StudentID = @StudentID";
                SqlCommand cmd = new SqlCommand(queryString, conn);
                cmd.Connection = conn;
                cmd.CommandText = queryString;
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@StudentID", this.studentId);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    // Đọc từng dòng tập kết quả
                     while (reader.Read())
                     {
                         var name = reader["Name"];
                         Console.WriteLine(Name);
                         MessageBox.Show(name.ToString());
                     }
                }
                else
                {
                    Console.WriteLine("Không có dữ liệu trả về");
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
