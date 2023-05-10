using MyPOS.DAL;
using MyPOS.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPOS
{
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }
        string conn = DBAccess.ConnectionString;
        DataRow dr;
        
        private void Customer_Load(object sender, EventArgs e)
        {
            GetState();
            GetCustomer();
            dllCustomer.Enabled = false;
        }

        public void GetState()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    using (SqlCommand command = new SqlCommand("Select ID, StateName from tbState", connection))
                    {
                        SqlDataAdapter sda = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        dr = dt.NewRow();
                        dr.ItemArray = new object[] { 0, "--Select--" };
                        dt.Rows.InsertAt(dr, 0);
                        ddlState.ValueMember = "ID";
                        ddlState.DisplayMember = "StateName";
                        ddlState.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception : " + ex);
            }
        }
        public void GetCity(int stateId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    using (SqlCommand command = new SqlCommand("SELECT ID,CityName from tbCity where StateId='" + stateId + "'", connection))
                    {
                        SqlDataAdapter sda = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        dr = dt.NewRow();
                        dr.ItemArray = new object[] { "0", "--Select--" };
                        dt.Rows.InsertAt(dr, 0);

                        ddlCity.ValueMember = "ID";
                        ddlCity.DisplayMember = "CityName";
                        ddlCity.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception : " + ex);
            }
        }




        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ddlState_SelectedIndexChanged(object sender, EventArgs e)
        {
            int stateId = ddlState.SelectedIndex;
            GetCity(stateId);
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtFirstName.Text != "" && txtLastName.Text != "")

                {
                    if (dllCustomer.SelectedIndex > 0 && chkupdate.Checked)
                    {
                        string qury = "Update tbCustomer Set FirstName='" + txtFirstName.Text.Trim() + "',LastName='" + txtLastName.Text.Trim() + "',MobileNo='" + txtMobile.Text.Trim() + "',Email='" + txtEmail.Text.Trim() + "',StateID=" + ddlState.SelectedValue + ",CityID=" + ddlCity.SelectedValue + ",Address='" + txtAddress.Text.Trim() + "',PinCode='" + txtPin.Text.Trim() + "' Where ID=" + dllCustomer.SelectedValue + "";
                        bool success1 = DBAccess.ExecuteInsertQuery(qury);
                        if (success1)
                        {
                            MessageBox.Show("Congrats! Customer Updated Successfully.", "Tech POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearText();
                            return;
                        }


                    }
                    int stateId = int.Parse(ddlState.SelectedValue.ToString());
                    int cityId = int.Parse(ddlCity.SelectedValue.ToString());

                    string qry = "Insert into tbCustomer(FirstName,LastName,MobileNo,Email,StateID,CityID,Address,PinCode,RegDate)Values('" + txtFirstName.Text.Trim() + "','" + txtLastName.Text.Trim() + "','" + txtMobile.Text.Trim() + "','" + txtEmail.Text.Trim() + "','" + stateId + "','" + cityId + "','" + txtAddress.Text.Trim() + "','" + txtPin.Text.Trim() + "','" + DateTime.Now + "')";

                    bool success = DBAccess.ExecuteInsertQuery(qry);

                    if (success)
                    {
                        MessageBox.Show("Congrats! Customer Added Successfully.", "Tech POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearText();
                    }
                    else
                    {
                        MessageBox.Show("Customer Not Added.", "Tech POS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }


                else MessageBox.Show("Mandatory fields must be filled.", "Tech POS", MessageBoxButtons.OK, MessageBoxIcon.Warning);



            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception " + ex);
            }
        }
        void ClearText()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtMobile.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            txtPin.Clear();

            ddlState.SelectedIndex = 0;
            ddlCity.SelectedIndex = 0;
        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsLetter(e.KeyChar)) && (!char.IsControl(e.KeyChar)) && (!char.IsWhiteSpace(e.KeyChar)))
            {
                e.Handled = true;
            }

        }

        private void txtMobile_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((!char.IsNumber(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtPin_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((!char.IsDigit(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            EmailValidation();
        }
        void EmailValidation()
        {
            if (txtEmail.Text.Length > 0)
            {
                Regex RegxEmail = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");
                if (!RegxEmail.IsMatch(txtEmail.Text.Trim()))
                {
                    MessageBox.Show("Email is not valid, Please provide a valid email.", "Tech POS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEmail.Focus();
                    return;
                }
            }
        }
        public void GetCustomer()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(conn))
                {
                    using (SqlCommand cmd = new SqlCommand("Select ID, FirstName from tbCustomer ", connection))
                    {
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        dr = dt.NewRow();
                        dr.ItemArray = new object[] { 0, "--Select--" };
                        dt.Rows.InsertAt(dr, 0);
                        dllCustomer.ValueMember = "ID";
                        dllCustomer.DisplayMember = "FirstName";
                        dllCustomer.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("exception : " + ex);
            }
        }
        void GetCustomerDetail(int id)
        {
            try
            {
                string Qry = "Select * from tbCustomer where ID=" + id + "";
                SqlDataReader dr = DBAccess.ExecuteReader(Qry);
                while (dr.Read())
                {
                    //FirstName, LastName, Email, MobileNo, StateId, CityId,Address,PinCode
                    txtFirstName.Text = dr["FirstName"].ToString();
                    txtLastName.Text = dr["LastName"].ToString();
                    txtEmail.Text = dr["Email"].ToString();
                    txtMobile.Text = dr["MobileNo"].ToString();
                    txtAddress.Text = dr["Address"].ToString();
                    ddlState.SelectedIndex = Convert.ToInt32(dr["StateId"]);
                    ddlCity.SelectedIndex = Convert.ToInt32(dr["CityId"]);
                    txtPin.Text = dr["PinCode"].ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception : " + ex);
            }
        }
        private void chkupdate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkupdate.Checked)
            {
                dllCustomer.Enabled = true;
                if (dllCustomer.Text != "--Select--")
                {
                    int CustId = Convert.ToInt32(dllCustomer.SelectedValue);
                    GetCustomerDetail(CustId);
                }
            }
            else
            {
                dllCustomer.Enabled = false;
                dllCustomer.SelectedIndex = 0;
            }
        }

        private void dllCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            int CustID = Convert.ToInt32(dllCustomer.SelectedValue);
            if (CustID > 0)
            {
                GetCustomerDetail(CustID);
            }
            else
            {
                ClearText();
                dllCustomer.SelectedValue = 0;
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            Customer objCust = new Customer();
            try
            {
                objCust.Id = Convert.ToInt32(dllCustomer.SelectedValue);
                objCust.FirstName = txtFirstName.Text.Trim();
                objCust.MobileNo = txtMobile.Text.Trim();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception btnSelect_Click " + ex);
            }
        }
        Customer objCust = new Customer();
        public Customer ShowDialog()
        {
            base.ShowDialog();
            return objCust;
        }
    }
}