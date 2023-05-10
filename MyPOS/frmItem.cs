using MyPOS.DAL;
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
using System.Xml.Linq;

namespace MyPOS
{
    public partial class frmItem : Form
    {
        public frmItem()
        {
            InitializeComponent();
        }

        private void Item_Load(object sender, EventArgs e)
        {
            GetDepartment();
            GetTax();
        }
        string conn = DBAccess.ConnectionString;
        DataRow dr;
        public void GetDepartment()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    using (SqlCommand command = new SqlCommand("select ID, DeptName from tbDepartement", connection))
                    {
                        SqlDataAdapter sda = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        dr = dt.NewRow();
                        dr.ItemArray = new object[] { 0, "--Select--" };
                        dt.Rows.InsertAt(dr, 0);
                        ddlDepartment.ValueMember = "ID";
                        ddlDepartment.DisplayMember = "DeptName";
                        ddlDepartment.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception : " + ex);
            }
        }
        public void GetCategory(int deptId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    using (SqlCommand command = new SqlCommand("SELECT ID,Category from tbCategory where DeptID='" + deptId + "'", connection))
                    {
                        SqlDataAdapter sda = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        dr = dt.NewRow();
                        dr.ItemArray = new object[] { "0", "--Select--" };
                        dt.Rows.InsertAt(dr, 0);

                        ddlCategory.ValueMember = "ID";
                        ddlCategory.DisplayMember = "Category";
                        ddlCategory.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception : " + ex);
            }
        }

        public void GetTax()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    using (SqlCommand command = new SqlCommand("SELECT ID, TaxPercentage from tbTax", connection))
                    {
                        SqlDataAdapter sda = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        dr = dt.NewRow();
                        dr.ItemArray = new object[] { "0", "--Select--" };
                        dt.Rows.InsertAt(dr, 0);

                        ddlTax.ValueMember = "ID";
                        ddlTax.DisplayMember = "TaxPercentage";
                        ddlTax.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception : " + ex);
            }
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                int DeptID = Convert.ToInt32(ddlDepartment.SelectedValue.ToString());
                int CateID = Convert.ToInt32(ddlCategory.SelectedValue.ToString());
                int TaxID = Convert.ToInt32(ddlTax.SelectedValue.ToString());
                string qry = "INSERT INTO tbItem(LookupCode, ItemName, DeptID, CateID, Cost, Price, Quantity, Weight, TaxID) VALUES('" + txtLookup.Text.Trim() + "', '" + txtName.Text.Trim() + "', '" + DeptID + "', '" + CateID + "', '" + txtCost.Text.Trim() + "', '" + txtPrice.Text.Trim() + "', '" + txtQty.Text.Trim() + "', '" + txtWeight.Text.Trim() + "', '" + TaxID + "')";

                bool success = DBAccess.ExecuteInsertQuery(qry);

                if (success)
                {
                    MessageBox.Show("Item Inserted Successfully.", "Tech POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearText();
                }
                else
                {
                    MessageBox.Show("Item Inserted Failed.", "Tech POS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception : " + ex);
            }
        }
        void ClearText()
        {
            txtLookup.Clear();
            txtName.Clear();
            txtPrice.Clear();
            txtQty.Clear();
            txtWeight.Clear();
            txtCost.Clear();
            ddlDepartment.SelectedIndex = 0;
            ddlCategory.SelectedIndex = 0;
            ddlTax.SelectedIndex = 0;
            chkDiscount.Checked = false;
        }
        private void ddlDepartment_Selectindexchanged(object sender, EventArgs e)
        {
            try
            {
                if (ddlDepartment.SelectedValue.ToString() != null)
                {
                    int departmentID = Convert.ToInt32(ddlDepartment.SelectedValue.ToString());
                    if (departmentID > 0)
                    {
                        GetCategory(departmentID);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception : " + ex);
            }
        }

        private void closeitembtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtWeight_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
    }

}

