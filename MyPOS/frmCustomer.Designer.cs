namespace MyPOS
{
    partial class frmCustomer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            ddlState = new ComboBox();
            ddlCity = new ComboBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtMobile = new TextBox();
            txtEmail = new TextBox();
            txtAddress = new TextBox();
            txtPin = new TextBox();
            savebtn = new Button();
            closebtn = new Button();
            label9 = new Label();
            label10 = new Label();
            groupBox1 = new GroupBox();
            chkupdate = new CheckBox();
            dllCustomer = new ComboBox();
            btnSelect = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 111);
            label1.Name = "label1";
            label1.Size = new Size(106, 25);
            label1.TabIndex = 0;
            label1.Text = "First Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 174);
            label2.Name = "label2";
            label2.Size = new Size(104, 25);
            label2.TabIndex = 0;
            label2.Text = "Last Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(94, 237);
            label3.Name = "label3";
            label3.Size = new Size(76, 25);
            label3.TabIndex = 0;
            label3.Text = "Mobile :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(107, 300);
            label4.Name = "label4";
            label4.Size = new Size(63, 25);
            label4.TabIndex = 0;
            label4.Text = "Email :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(110, 363);
            label5.Name = "label5";
            label5.Size = new Size(60, 25);
            label5.TabIndex = 0;
            label5.Text = "State :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(119, 426);
            label6.Name = "label6";
            label6.Size = new Size(51, 25);
            label6.TabIndex = 0;
            label6.Text = "City :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(84, 489);
            label7.Name = "label7";
            label7.Size = new Size(86, 25);
            label7.TabIndex = 0;
            label7.Text = "Address :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(78, 552);
            label8.Name = "label8";
            label8.Size = new Size(92, 25);
            label8.TabIndex = 0;
            label8.Text = "Pin Code :";
            // 
            // ddlState
            // 
            ddlState.FormattingEnabled = true;
            ddlState.Location = new Point(285, 283);
            ddlState.Name = "ddlState";
            ddlState.Size = new Size(368, 33);
            ddlState.TabIndex = 1;
            ddlState.SelectedIndexChanged += ddlState_SelectedIndexChanged;
            // 
            // ddlCity
            // 
            ddlCity.FormattingEnabled = true;
            ddlCity.Location = new Point(308, 423);
            ddlCity.Name = "ddlCity";
            ddlCity.Size = new Size(368, 33);
            ddlCity.TabIndex = 1;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(308, 113);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(368, 31);
            txtFirstName.TabIndex = 2;
            txtFirstName.KeyPress += txtFirstName_KeyPress;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(308, 171);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(368, 31);
            txtLastName.TabIndex = 2;
            txtLastName.KeyPress += txtFirstName_KeyPress;
            // 
            // txtMobile
            // 
            txtMobile.Location = new Point(308, 237);
            txtMobile.Name = "txtMobile";
            txtMobile.Size = new Size(368, 31);
            txtMobile.TabIndex = 2;
            txtMobile.KeyPress += txtMobile_KeyPress;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(308, 294);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(368, 31);
            txtEmail.TabIndex = 2;
            txtEmail.Leave += txtEmail_Leave;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(308, 489);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(368, 31);
            txtAddress.TabIndex = 2;
            // 
            // txtPin
            // 
            txtPin.Location = new Point(308, 549);
            txtPin.Name = "txtPin";
            txtPin.Size = new Size(368, 31);
            txtPin.TabIndex = 2;
            txtPin.KeyPress += txtPin_KeyPress;
            // 
            // savebtn
            // 
            savebtn.BackColor = Color.FromArgb(0, 192, 0);
            savebtn.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            savebtn.ForeColor = SystemColors.ButtonFace;
            savebtn.Location = new Point(167, 696);
            savebtn.Name = "savebtn";
            savebtn.Size = new Size(149, 53);
            savebtn.TabIndex = 3;
            savebtn.Text = "Save";
            savebtn.UseVisualStyleBackColor = false;
            savebtn.Click += savebtn_Click;
            // 
            // closebtn
            // 
            closebtn.BackColor = Color.Maroon;
            closebtn.Font = new Font("Times New Roman", 14F, FontStyle.Regular, GraphicsUnit.Point);
            closebtn.ForeColor = SystemColors.ButtonFace;
            closebtn.Location = new Point(429, 696);
            closebtn.Name = "closebtn";
            closebtn.Size = new Size(149, 53);
            closebtn.TabIndex = 3;
            closebtn.Text = "Close";
            closebtn.UseVisualStyleBackColor = false;
            closebtn.Click += closebtn_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(704, 113);
            label9.Name = "label9";
            label9.Size = new Size(23, 30);
            label9.TabIndex = 4;
            label9.Text = "*";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(704, 174);
            label10.Name = "label10";
            label10.Size = new Size(23, 30);
            label10.TabIndex = 4;
            label10.Text = "*";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ddlState);
            groupBox1.Location = new Point(23, 77);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(736, 691);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Tag = "Customer Details";
            groupBox1.Text = "Customer Details";
            // 
            // chkupdate
            // 
            chkupdate.AutoSize = true;
            chkupdate.Location = new Point(74, 23);
            chkupdate.Name = "chkupdate";
            chkupdate.Size = new Size(96, 29);
            chkupdate.TabIndex = 6;
            chkupdate.Text = "Update";
            chkupdate.UseVisualStyleBackColor = true;
            chkupdate.CheckedChanged += chkupdate_CheckedChanged;
            // 
            // dllCustomer
            // 
            dllCustomer.FormattingEnabled = true;
            dllCustomer.Location = new Point(308, 23);
            dllCustomer.Name = "dllCustomer";
            dllCustomer.Size = new Size(368, 33);
            dllCustomer.TabIndex = 1;
            dllCustomer.SelectedIndexChanged += dllCustomer_SelectedIndexChanged;
            // 
            // btnSelect
            // 
            btnSelect.Location = new Point(745, 22);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(112, 34);
            btnSelect.TabIndex = 7;
            btnSelect.Text = "Select";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // frmCustomer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(881, 780);
            ControlBox = false;
            Controls.Add(btnSelect);
            Controls.Add(dllCustomer);
            Controls.Add(chkupdate);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(closebtn);
            Controls.Add(savebtn);
            Controls.Add(txtPin);
            Controls.Add(txtAddress);
            Controls.Add(txtEmail);
            Controls.Add(txtMobile);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(ddlCity);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "frmCustomer";
            Text = "Customer";
            TopMost = true;
            Load += Customer_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private ComboBox ddlState;
        private ComboBox ddlCity;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtMobile;
        private TextBox txtEmail;
        private TextBox txtAddress;
        private TextBox txtPin;
        private Button savebtn;
        private Button closebtn;
        private Label label9;
        private Label label10;
        private GroupBox groupBox1;
        private CheckBox chkupdate;
        private ComboBox dllCustomer;
        private Button btnSelect;
    }
}