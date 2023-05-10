using MyPOS.DAL;
using MyPOS.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace MyPOS
{
    public partial class MainWindow : Form
    {
        DataRow dr;

        public MainWindow()
        {
            InitializeComponent();
        }



        private void newbtn_Click(object sender, EventArgs e)
        {
            PanelItems.Visible = true;

        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            PanelItems.Visible = false;
            GetItemList();
            BindDLL();
            GetMaxInvoiceID();
            Paynowbtn.Enabled = false;
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Itemsbtn_Click(object sender, EventArgs e)
        {
            frmItem objItem = new frmItem();
            objItem.ShowDialog();
        }

        private void customersbtn_Click(object sender, EventArgs e)
        {
            frmCustomer customer = new frmCustomer();
            Customer objCustomer = new Customer();

            customer.ShowDialog();

            if (objCustomer.Id > 0)
            {


                lblCustName.Text = objCustomer.FirstName.ToString();

                grpCustomer.Visible = true;
            }
            else
            {
                
                lblCustName.Text = "";
         
                grpCustomer.Visible = false;
            }
        }

        private void Paynowbtn_Click(object sender, EventArgs e)
        {
            Receive_Payment payment = new Receive_Payment();
            payment.ShowDialog();
        }


        void BindDLL()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(DBAccess.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("Select ID, ItemName, LookupCode from tbItem Where Quantity>0", connection))
                    {
                        SqlDataAdapter sda = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        dr = dt.NewRow();
                        dr.ItemArray = new object[] { 0, "--Select--" };
                        dt.Rows.InsertAt(dr, 0);
                        ddlLookup.ValueMember = "ID";
                        ddlLookup.DisplayMember = "LookupCode";
                        ddlLookup.DataSource = dt;

                        ddlItems.ValueMember = "ID";
                        ddlItems.DisplayMember = "ItemName";
                        ddlItems.DataSource = dt;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error : " + ex);
                throw;
            }
        }

        List<Item> itemList = new List<Item>();
        public void GetItemList()
        {

            try
            {
                using (SqlConnection connection = new SqlConnection(DBAccess.ConnectionString))
                {
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }

                    using (SqlCommand cmd = new SqlCommand("Select ID, LookupCode, ItemName, DeptId, CateID,Cost, Price,Quantity,UOM,Weight,TaxID, 0 as Action from tbItem Where Quantity>0", connection))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();


                        while (reader.Read())
                        {
                            Item objItem = new Item();



                            objItem.ID = Convert.ToInt32(reader["ID"]);
                            objItem.LookupCode = Convert.ToString(reader["LookupCode"]);
                            objItem.ItemName = Convert.ToString(reader["ItemName"]);
                            objItem.Department = Convert.ToString(reader["DeptId"]);
                            objItem.Category = Convert.ToString(reader["CateID"]);
                            objItem.Price = Convert.ToDecimal(reader["Price"]);
                            objItem.Quantity = Convert.ToInt32(reader["Quantity"]);
                            objItem.UOM = Convert.ToString(reader["UOM"]);
                            objItem.Weight = Convert.ToDecimal(reader["Weight"]);
                            objItem.Tax = 0.0M;
                            objItem.TaxID = Convert.ToInt32(reader["TaxID"]);
                            objItem.Action = Convert.ToBoolean(reader["Action"]);

                            itemList.Add(objItem);
                        }
                        reader.Close();
                    }


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("error : " + ex);
                throw;
            }


        }

        int MaxId = 0;
        int InsertedInvId = 0;
        void GetMaxInvoiceID()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(DBAccess.ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("Select Max(ID) as MaxID from tbInvoice", connection))
                    {
                        if (connection.State != ConnectionState.Open)
                        {
                            connection.Open();
                        }
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            MaxId = Convert.ToInt32(reader["MaxID"]);
                            MaxId++;
                            lblInvoiceNo.Text = MaxId.ToString();

                        }

                        reader.Close();
                    }
                }
            }





            catch (Exception ec)
            {
                MessageBox.Show("Error : " + ec);
                throw;
            }
        }

        List<SalesItem> itemSalesList = new List<SalesItem>();
        List<SalesItem> EmptyList = new List<SalesItem>();
        List<Tax> taxList = new List<Tax>();

        private void ddlLookup_SelectedIndexChanged(object sender, EventArgs e)
        {


            try
            {
                int indx = ddlLookup.SelectedIndex;
                if (indx > 0)
                {
                    var item = itemList.FirstOrDefault(x => x.LookupCode.Equals(ddlLookup.Text.Trim()));
                    if (item != null)
                    {
                        SalesItem objItem = new SalesItem();
                        objItem.ID = item.ID;
                        objItem.LookupCode = item.LookupCode;
                        objItem.ItemName = item.ItemName;
                        objItem.ItemPrice = item.Price;
                        objItem.Quantity = 1;
                        objItem.TaxID = item.TaxID;
                        var taxPerc = taxList.FirstOrDefault(x => x.ID.Equals(item.TaxID));
                        decimal Tax = 0;
                        decimal BasePrice = 0;
                        if (taxPerc != null)
                        {

                            BasePrice = item.Price * (100 / (100 + taxPerc.Percentage));
                            Tax = item.Price - BasePrice;
                        }
                        else
                        {
                            BasePrice = Math.Round(item.Price, 2);
                            Tax = 0;
                        }
                        decimal total = (objItem.Quantity * BasePrice) + (Tax);
                        objItem.Tax = Math.Round(Tax, 2);
                        objItem.Cost = Math.Round(BasePrice, 2);
                        objItem.Price = Math.Round(BasePrice, 2);
                        objItem.Total = Math.Round(total, 2);
                        objItem.Action = false;

                        itemSalesList.Add(objItem);
                        dgvItems.DataSource = EmptyList;
                        dgvItems.DataSource = itemSalesList;
                        Calculate();

                    }



                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("error :" + ex);
                throw;
            }




        }
        decimal TotalAmt = 0;
        decimal TaxAmt = 0;
        decimal PriceAmt = 0;
        void Calculate()
        {
            try
            {

                decimal SumTotal = itemSalesList.Sum(x => x.Total);
                decimal Price = itemSalesList.Sum(x => x.Price);
                TotalAmt = SumTotal;
                PriceAmt = Price;
                lblAmount.Text = Price.ToString();
                lblTax.Text = "0";
                lblTotal.Text = SumTotal.ToString();

                if (SumTotal > 0)
                {
                    Paynowbtn.Enabled = true;
                    Paynowbtn.BackColor = Color.DarkGreen;
                }
                else
                {
                    Paynowbtn.Enabled = false;
                    Paynowbtn.BackColor = Color.Yellow;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception : " + ex);
            }
        }


    }
}
