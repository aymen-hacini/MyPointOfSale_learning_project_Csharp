namespace MyPOS
{
    partial class MainWindow
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
            panel5 = new Panel();
            Settingsbtn = new Button();
            Storebtn = new Button();
            Cashbtn = new Button();
            Salesbtn = new Button();
            btnCustomer = new Button();
            Itemsbtn = new Button();
            newbtn = new Button();
            PanelItems = new Panel();
            dgvItems = new DataGridView();
            panel4 = new Panel();
            lblInvoiceNo = new Label();
            ddlItems = new ComboBox();
            ddlLookup = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            lblCustName = new Label();
            grpCustomer = new Label();
            label2 = new Label();
            panel3 = new Panel();
            Paynowbtn = new Button();
            clearItemsbtn = new Button();
            lblTax = new Label();
            labell2 = new Label();
            label8 = new Label();
            lblTotal = new Label();
            labell3 = new Label();
            lblAmount = new Label();
            labell1 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            logoutbtn = new Button();
            panel5.SuspendLayout();
            PanelItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel5
            // 
            panel5.AutoSize = true;
            panel5.BackColor = Color.Khaki;
            panel5.Controls.Add(Settingsbtn);
            panel5.Controls.Add(Storebtn);
            panel5.Controls.Add(Cashbtn);
            panel5.Controls.Add(Salesbtn);
            panel5.Controls.Add(btnCustomer);
            panel5.Controls.Add(Itemsbtn);
            panel5.Controls.Add(newbtn);
            panel5.Location = new Point(1019, 118);
            panel5.Margin = new Padding(4, 5, 4, 5);
            panel5.Name = "panel5";
            panel5.Size = new Size(309, 647);
            panel5.TabIndex = 1;
            // 
            // Settingsbtn
            // 
            Settingsbtn.AutoSize = true;
            Settingsbtn.BackColor = SystemColors.ScrollBar;
            Settingsbtn.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Settingsbtn.ForeColor = SystemColors.HotTrack;
            Settingsbtn.Location = new Point(9, 530);
            Settingsbtn.Margin = new Padding(4, 5, 4, 5);
            Settingsbtn.Name = "Settingsbtn";
            Settingsbtn.Size = new Size(234, 70);
            Settingsbtn.TabIndex = 0;
            Settingsbtn.Text = "Settings";
            Settingsbtn.UseVisualStyleBackColor = false;
            // 
            // Storebtn
            // 
            Storebtn.AutoSize = true;
            Storebtn.BackColor = SystemColors.ScrollBar;
            Storebtn.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Storebtn.ForeColor = SystemColors.HotTrack;
            Storebtn.Location = new Point(9, 452);
            Storebtn.Margin = new Padding(4, 5, 4, 5);
            Storebtn.Name = "Storebtn";
            Storebtn.Size = new Size(234, 70);
            Storebtn.TabIndex = 0;
            Storebtn.Text = "Store Manager";
            Storebtn.UseVisualStyleBackColor = false;
            // 
            // Cashbtn
            // 
            Cashbtn.AutoSize = true;
            Cashbtn.BackColor = SystemColors.ScrollBar;
            Cashbtn.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Cashbtn.ForeColor = SystemColors.HotTrack;
            Cashbtn.Location = new Point(9, 373);
            Cashbtn.Margin = new Padding(4, 5, 4, 5);
            Cashbtn.Name = "Cashbtn";
            Cashbtn.Size = new Size(234, 70);
            Cashbtn.TabIndex = 0;
            Cashbtn.Text = "Cash Drawer";
            Cashbtn.UseVisualStyleBackColor = false;
            // 
            // Salesbtn
            // 
            Salesbtn.AutoSize = true;
            Salesbtn.BackColor = SystemColors.ScrollBar;
            Salesbtn.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Salesbtn.ForeColor = SystemColors.HotTrack;
            Salesbtn.Location = new Point(9, 295);
            Salesbtn.Margin = new Padding(4, 5, 4, 5);
            Salesbtn.Name = "Salesbtn";
            Salesbtn.Size = new Size(234, 70);
            Salesbtn.TabIndex = 0;
            Salesbtn.Text = "Sales/Refunds";
            Salesbtn.UseVisualStyleBackColor = false;
            // 
            // btnCustomer
            // 
            btnCustomer.AutoSize = true;
            btnCustomer.BackColor = SystemColors.ScrollBar;
            btnCustomer.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCustomer.ForeColor = SystemColors.HotTrack;
            btnCustomer.Location = new Point(9, 217);
            btnCustomer.Margin = new Padding(4, 5, 4, 5);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(234, 70);
            btnCustomer.TabIndex = 0;
            btnCustomer.Text = "Customers list";
            btnCustomer.UseVisualStyleBackColor = false;
            btnCustomer.Click += customersbtn_Click;
            // 
            // Itemsbtn
            // 
            Itemsbtn.AutoSize = true;
            Itemsbtn.BackColor = SystemColors.ScrollBar;
            Itemsbtn.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Itemsbtn.ForeColor = SystemColors.HotTrack;
            Itemsbtn.Location = new Point(9, 138);
            Itemsbtn.Margin = new Padding(4, 5, 4, 5);
            Itemsbtn.Name = "Itemsbtn";
            Itemsbtn.Size = new Size(234, 70);
            Itemsbtn.TabIndex = 0;
            Itemsbtn.Text = "Items";
            Itemsbtn.UseVisualStyleBackColor = false;
            Itemsbtn.Click += Itemsbtn_Click;
            // 
            // newbtn
            // 
            newbtn.AutoSize = true;
            newbtn.BackColor = SystemColors.ScrollBar;
            newbtn.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            newbtn.ForeColor = SystemColors.HotTrack;
            newbtn.Location = new Point(9, 60);
            newbtn.Margin = new Padding(4, 5, 4, 5);
            newbtn.Name = "newbtn";
            newbtn.Size = new Size(234, 70);
            newbtn.TabIndex = 0;
            newbtn.Text = "New";
            newbtn.UseVisualStyleBackColor = false;
            newbtn.Click += newbtn_Click;
            // 
            // PanelItems
            // 
            PanelItems.BackColor = SystemColors.ActiveCaption;
            PanelItems.Controls.Add(dgvItems);
            PanelItems.Controls.Add(panel4);
            PanelItems.Controls.Add(panel3);
            PanelItems.Location = new Point(17, 148);
            PanelItems.Margin = new Padding(4, 5, 4, 5);
            PanelItems.Name = "PanelItems";
            PanelItems.Size = new Size(1001, 600);
            PanelItems.TabIndex = 1;
            // 
            // dgvItems
            // 
            dgvItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvItems.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvItems.BackgroundColor = SystemColors.ButtonFace;
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItems.GridColor = SystemColors.ActiveCaption;
            dgvItems.Location = new Point(9, 148);
            dgvItems.Margin = new Padding(4, 5, 4, 5);
            dgvItems.Name = "dgvItems";
            dgvItems.RowHeadersWidth = 62;
            dgvItems.RowTemplate.Height = 25;
            dgvItems.Size = new Size(660, 437);
            dgvItems.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.AutoSize = true;
            panel4.BackColor = Color.Khaki;
            panel4.Controls.Add(lblInvoiceNo);
            panel4.Controls.Add(ddlItems);
            panel4.Controls.Add(ddlLookup);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(lblCustName);
            panel4.Controls.Add(grpCustomer);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(4, 0);
            panel4.Margin = new Padding(4, 5, 4, 5);
            panel4.Name = "panel4";
            panel4.Size = new Size(664, 138);
            panel4.TabIndex = 3;
            // 
            // lblInvoiceNo
            // 
            lblInvoiceNo.AutoSize = true;
            lblInvoiceNo.Location = new Point(131, 10);
            lblInvoiceNo.Name = "lblInvoiceNo";
            lblInvoiceNo.Size = new Size(20, 25);
            lblInvoiceNo.TabIndex = 2;
            lblInvoiceNo.Text = "..";
            // 
            // ddlItems
            // 
            ddlItems.FormattingEnabled = true;
            ddlItems.Location = new Point(396, 13);
            ddlItems.Margin = new Padding(4, 5, 4, 5);
            ddlItems.Name = "ddlItems";
            ddlItems.Size = new Size(200, 33);
            ddlItems.TabIndex = 1;
            // 
            // ddlLookup
            // 
            ddlLookup.FormattingEnabled = true;
            ddlLookup.Location = new Point(396, 77);
            ddlLookup.Margin = new Padding(4, 5, 4, 5);
            ddlLookup.Name = "ddlLookup";
            ddlLookup.Size = new Size(200, 33);
            ddlLookup.TabIndex = 1;
            ddlLookup.SelectedIndexChanged += ddlLookup_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(248, 83);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(127, 22);
            label5.TabIndex = 0;
            label5.Text = "Lookup Code :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(308, 19);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(67, 22);
            label4.TabIndex = 0;
            label4.Text = "Name :";
            // 
            // lblCustName
            // 
            lblCustName.AutoSize = true;
            lblCustName.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblCustName.Location = new Point(108, 53);
            lblCustName.Margin = new Padding(4, 0, 4, 0);
            lblCustName.Name = "lblCustName";
            lblCustName.Size = new Size(20, 22);
            lblCustName.TabIndex = 0;
            lblCustName.Text = "..";
            // 
            // grpCustomer
            // 
            grpCustomer.AutoSize = true;
            grpCustomer.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            grpCustomer.Location = new Point(4, 53);
            grpCustomer.Margin = new Padding(4, 0, 4, 0);
            grpCustomer.Name = "grpCustomer";
            grpCustomer.Size = new Size(96, 22);
            grpCustomer.TabIndex = 0;
            grpCustomer.Text = "Customer :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(4, 13);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(109, 22);
            label2.TabIndex = 0;
            label2.Text = "Invoice No :";
            // 
            // panel3
            // 
            panel3.AutoSize = true;
            panel3.BackColor = Color.Khaki;
            panel3.Controls.Add(Paynowbtn);
            panel3.Controls.Add(clearItemsbtn);
            panel3.Controls.Add(lblTax);
            panel3.Controls.Add(labell2);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(lblTotal);
            panel3.Controls.Add(labell3);
            panel3.Controls.Add(lblAmount);
            panel3.Controls.Add(labell1);
            panel3.Location = new Point(677, 0);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(345, 612);
            panel3.TabIndex = 3;
            // 
            // Paynowbtn
            // 
            Paynowbtn.AutoSize = true;
            Paynowbtn.BackColor = Color.Red;
            Paynowbtn.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Paynowbtn.ForeColor = SystemColors.Desktop;
            Paynowbtn.Location = new Point(4, 475);
            Paynowbtn.Margin = new Padding(4, 5, 4, 5);
            Paynowbtn.Name = "Paynowbtn";
            Paynowbtn.Size = new Size(306, 93);
            Paynowbtn.TabIndex = 0;
            Paynowbtn.Text = "Pay Now";
            Paynowbtn.UseVisualStyleBackColor = false;
            Paynowbtn.Click += Paynowbtn_Click;
            // 
            // clearItemsbtn
            // 
            clearItemsbtn.AutoSize = true;
            clearItemsbtn.BackColor = SystemColors.ScrollBar;
            clearItemsbtn.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            clearItemsbtn.ForeColor = SystemColors.HotTrack;
            clearItemsbtn.Location = new Point(4, 5);
            clearItemsbtn.Margin = new Padding(4, 5, 4, 5);
            clearItemsbtn.Name = "clearItemsbtn";
            clearItemsbtn.Size = new Size(306, 93);
            clearItemsbtn.TabIndex = 0;
            clearItemsbtn.Text = "Clear Items";
            clearItemsbtn.UseVisualStyleBackColor = false;
            // 
            // lblTax
            // 
            lblTax.AutoSize = true;
            lblTax.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTax.Location = new Point(134, 245);
            lblTax.Margin = new Padding(4, 0, 4, 0);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(20, 22);
            lblTax.TabIndex = 0;
            lblTax.Text = "..";
            // 
            // labell2
            // 
            labell2.AutoSize = true;
            labell2.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labell2.Location = new Point(30, 245);
            labell2.Margin = new Padding(4, 0, 4, 0);
            labell2.Name = "labell2";
            labell2.Size = new Size(50, 22);
            labell2.TabIndex = 0;
            labell2.Text = "Tax :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(23, 308);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(318, 22);
            label8.TabIndex = 0;
            label8.Text = "--------------------------------------------";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotal.Location = new Point(134, 367);
            lblTotal.Margin = new Padding(4, 0, 4, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(20, 22);
            lblTotal.TabIndex = 0;
            lblTotal.Text = "..";
            // 
            // labell3
            // 
            labell3.AutoSize = true;
            labell3.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labell3.Location = new Point(30, 367);
            labell3.Margin = new Padding(4, 0, 4, 0);
            labell3.Name = "labell3";
            labell3.Size = new Size(62, 22);
            labell3.TabIndex = 0;
            labell3.Text = "Total :";
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblAmount.Location = new Point(134, 187);
            lblAmount.Margin = new Padding(4, 0, 4, 0);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(20, 22);
            lblAmount.TabIndex = 0;
            lblAmount.Text = "..";
            // 
            // labell1
            // 
            labell1.AutoSize = true;
            labell1.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labell1.Location = new Point(23, 187);
            labell1.Margin = new Padding(4, 0, 4, 0);
            labell1.Name = "labell1";
            labell1.Size = new Size(82, 22);
            labell1.TabIndex = 0;
            labell1.Text = "Amount :";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Khaki;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1315, 118);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(480, 27);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(283, 47);
            label1.TabIndex = 0;
            label1.Text = "AYMEN SHOP";
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.BackColor = Color.Khaki;
            panel2.Controls.Add(logoutbtn);
            panel2.Location = new Point(-1, 758);
            panel2.Margin = new Padding(4, 5, 4, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(1315, 138);
            panel2.TabIndex = 1;
            // 
            // logoutbtn
            // 
            logoutbtn.BackColor = SystemColors.InfoText;
            logoutbtn.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            logoutbtn.ForeColor = SystemColors.ControlLightLight;
            logoutbtn.Location = new Point(1066, 22);
            logoutbtn.Margin = new Padding(4, 5, 4, 5);
            logoutbtn.Name = "logoutbtn";
            logoutbtn.Size = new Size(179, 68);
            logoutbtn.TabIndex = 0;
            logoutbtn.Text = "Log out";
            logoutbtn.UseVisualStyleBackColor = false;
            logoutbtn.Click += logoutbtn_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1311, 892);
            ControlBox = false;
            Controls.Add(PanelItems);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel5);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "MainWindow";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainWindow";
            TopMost = true;
            WindowState = FormWindowState.Maximized;
            Load += MainWindow_Load;
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            PanelItems.ResumeLayout(false);
            PanelItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel5;
        private Button Settingsbtn;
        private Button Storebtn;
        private Button Cashbtn;
        private Button Salesbtn;
        private Button btnCustomer;
        private Button Itemsbtn;
        private Button newbtn;
        private Panel PanelItems;
        private Panel panel4;
        private ComboBox ddlItems;
        private ComboBox ddlLookup;
        private Label label5;
        private Label label4;
        private Label grpCustomer;
        private Label label2;
        private Panel panel3;
        private Button clearItemsbtn;
        private DataGridView dgvItems;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button Paynowbtn;
        private Label labell2;
        private Label label8;
        private Label labell3;
        private Label labell1;
        private Button logoutbtn;
        private Label lblInvoiceNo;
        private Label lblTax;
        private Label lblAmount;
        private Label lblTotal;
        private Label lblCustName;
    }
}