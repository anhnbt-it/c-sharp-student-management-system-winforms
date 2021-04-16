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
    public partial class frmMain : Form
    {
        private string connectionString = "server=LAB35\\SQL2012;database=abc;uid=lab;pwd=";
        private ErrorProvider classNameErrorProvider;
        public frmMain()
        {
            InitializeComponent();

            classNameErrorProvider = new ErrorProvider();
            classNameErrorProvider.SetIconAlignment(txtAddNewClass, ErrorIconAlignment.MiddleRight);
            classNameErrorProvider.SetIconPadding(txtAddNewClass, 2);
            classNameErrorProvider.BlinkRate = 1000;
            classNameErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void dgvwProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.loadClass();
        }

        private void loadClass()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string query = "SELECT * FROM Classes";
            SqlDataAdapter dataAdapper = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            dataAdapper.Fill(dt);

            cboClassName.DataSource = dt;
            cboClassName.DisplayMember = "ClassName";
            cboClassName.ValueMember = "ClassID";
            conn.Close();
        }

        private void lblClassName_Click(object sender, EventArgs e)
        {

        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            if (this.IsNameValid())
            {
                try
                {
                    SqlConnection conn = new SqlConnection(connectionString);
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    string query = "INSERT INTO Classes (ClassName) VALUES ('" + txtAddNewClass.Text + "')";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = query;
                    cmd.CommandType = CommandType.Text;
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Add Class Successfully.");
                        this.loadClass();
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong!");
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                classNameErrorProvider.SetError(txtAddNewClass, "Class Name is required.");
            }
        }

        private bool IsNameValid()
        {
            // Determine whether the text box contains a zero-length string.
            return (txtAddNewClass.Text.Length > 0);
        }

        private void btnDeleteClass_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string query = "DELETE FROM Classes WHERE ClassID = " + cboClassName.SelectedValue.ToString();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Delete class successfully.");
                    this.loadClass();
                }
                else
                {
                    MessageBox.Show("Something went wrong!");
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void cboClassName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboClassName.SelectedIndex != -1)
                {

                    SqlConnection conn = new SqlConnection(connectionString);
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    string query = "SELECT * FROM Students WHERE ClassID = " + cboClassName.SelectedValue.ToString();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, conn);
                    DataSet ds = new DataSet();
                    dataAdapter.Fill(ds, "tblStudents");
                    lbStudents.DataSource = ds.Tables["tblStudents"];
                    lbStudents.DisplayMember = "Name";
                    lbStudents.ValueMember = "StudentID";
                    conn.Close();
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void lbStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnViewStudent_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbStudents.SelectedIndex > -1)
                {
                    Form frmAddProduct = new NewProduct(lbStudents.SelectedValue.ToString());
                    frmAddProduct.Show();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
