using MyPOS.DAL;
using System.Data;
using System.Drawing.Text;

namespace MyPOS
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();

        }

        private void LOGINbtn_Click(object sender, EventArgs e)
        {
            TextBox txtUsername = textBox2;
            TextBox txtPassword = textBox1;
            


            if (txtUsername.Text != "" && txtPassword.Text != "")
            {
                DataTable dt = new DataTable();
                dt = DBAccess.FillDataTable("Select * from tbUser WHERE Username='" + txtUsername.Text.Trim() + "' and Password='" + txtPassword.Text.Trim() + "' COLLATE SQL_Latin1_General_CP1_CS_AS", dt);
                if (dt != null && dt.Rows.Count > 0)
                {
                    
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.ShowDialog();
              

                    //MessageBox.Show("Successful Login", "Tech POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("Username or Password incorrect", "Tech POS", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }

            else MessageBox.Show("Please enter a user and a password", "Tech POS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void CLOSEbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}