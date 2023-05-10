namespace MyPOS
{
    partial class frmItem
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
            closeitembtn = new Button();
            Savebtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtName = new TextBox();
            txtLookup = new TextBox();
            txtCost = new TextBox();
            txtPrice = new TextBox();
            txtWeight = new TextBox();
            txtQty = new TextBox();
            ddlDepartment = new ComboBox();
            ddlCategory = new ComboBox();
            ddlTax = new ComboBox();
            chkDiscount = new CheckBox();
            SuspendLayout();
            // 
            // closeitembtn
            // 
            closeitembtn.BackColor = Color.FromArgb(192, 0, 0);
            closeitembtn.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            closeitembtn.Location = new Point(366, 742);
            closeitembtn.Margin = new Padding(4, 5, 4, 5);
            closeitembtn.Name = "closeitembtn";
            closeitembtn.Size = new Size(216, 73);
            closeitembtn.TabIndex = 0;
            closeitembtn.Text = "Close";
            closeitembtn.UseVisualStyleBackColor = false;
            closeitembtn.Click += closeitembtn_Click;
            // 
            // Savebtn
            // 
            Savebtn.BackColor = Color.FromArgb(0, 192, 0);
            Savebtn.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Savebtn.Location = new Point(100, 742);
            Savebtn.Margin = new Padding(4, 5, 4, 5);
            Savebtn.Name = "Savebtn";
            Savebtn.Size = new Size(216, 73);
            Savebtn.TabIndex = 0;
            Savebtn.Text = "Save";
            Savebtn.UseVisualStyleBackColor = false;
            Savebtn.Click += Savebtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(41, 80);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(126, 26);
            label1.TabIndex = 1;
            label1.Text = "Item Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(22, 130);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(145, 26);
            label2.TabIndex = 1;
            label2.Text = "Item Lookup :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(25, 180);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(142, 26);
            label3.TabIndex = 1;
            label3.Text = "Departement :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(60, 230);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(107, 26);
            label4.TabIndex = 1;
            label4.Text = "Category :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(101, 280);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(66, 26);
            label5.TabIndex = 1;
            label5.Text = "Cost :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(96, 330);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(71, 26);
            label6.TabIndex = 1;
            label6.Text = "Price :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(79, 380);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(88, 26);
            label7.TabIndex = 1;
            label7.Text = "Weight :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(63, 430);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(104, 26);
            label8.TabIndex = 1;
            label8.Text = "Quantity :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(110, 480);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(57, 26);
            label9.TabIndex = 1;
            label9.Text = "Tax :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(37, 564);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(130, 20);
            label10.TabIndex = 1;
            label10.Text = "Apply Discount :";
            // 
            // txtName
            // 
            txtName.Location = new Point(259, 82);
            txtName.Name = "txtName";
            txtName.Size = new Size(363, 31);
            txtName.TabIndex = 2;
            // 
            // txtLookup
            // 
            txtLookup.Location = new Point(259, 130);
            txtLookup.Name = "txtLookup";
            txtLookup.Size = new Size(363, 31);
            txtLookup.TabIndex = 2;
            // 
            // txtCost
            // 
            txtCost.Location = new Point(259, 275);
            txtCost.Name = "txtCost";
            txtCost.Size = new Size(363, 31);
            txtCost.TabIndex = 2;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(259, 330);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(363, 31);
            txtPrice.TabIndex = 2;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(259, 380);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(363, 31);
            txtWeight.TabIndex = 2;
            txtWeight.KeyPress += txtWeight_KeyPress;
            // 
            // txtQty
            // 
            txtQty.Location = new Point(259, 430);
            txtQty.Name = "txtQty";
            txtQty.Size = new Size(363, 31);
            txtQty.TabIndex = 2;
            // 
            // ddlDepartment
            // 
            ddlDepartment.FormattingEnabled = true;
            ddlDepartment.Location = new Point(259, 180);
            ddlDepartment.Name = "ddlDepartment";
            ddlDepartment.Size = new Size(363, 33);
            ddlDepartment.TabIndex = 3;
            ddlDepartment.SelectedIndexChanged += ddlDepartment_Selectindexchanged;
            // 
            // ddlCategory
            // 
            ddlCategory.FormattingEnabled = true;
            ddlCategory.Location = new Point(259, 227);
            ddlCategory.Name = "ddlCategory";
            ddlCategory.Size = new Size(363, 33);
            ddlCategory.TabIndex = 3;
            // 
            // ddlTax
            // 
            ddlTax.FormattingEnabled = true;
            ddlTax.Location = new Point(259, 480);
            ddlTax.Name = "ddlTax";
            ddlTax.Size = new Size(363, 33);
            ddlTax.TabIndex = 3;
            // 
            // chkDiscount
            // 
            chkDiscount.AutoSize = true;
            chkDiscount.Location = new Point(259, 564);
            chkDiscount.Name = "chkDiscount";
            chkDiscount.Size = new Size(22, 21);
            chkDiscount.TabIndex = 4;
            chkDiscount.UseVisualStyleBackColor = true;
            // 
            // Item
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(699, 883);
            ControlBox = false;
            Controls.Add(chkDiscount);
            Controls.Add(ddlTax);
            Controls.Add(ddlCategory);
            Controls.Add(ddlDepartment);
            Controls.Add(txtQty);
            Controls.Add(txtWeight);
            Controls.Add(txtPrice);
            Controls.Add(txtCost);
            Controls.Add(txtLookup);
            Controls.Add(txtName);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Savebtn);
            Controls.Add(closeitembtn);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Item";
            ShowIcon = false;
            Text = "Item";
            TopMost = true;
            Load += Item_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button closeitembtn;
        private Button Savebtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtName;
        private TextBox txtLookup;
        private TextBox txtCost;
        private TextBox txtPrice;
        private TextBox txtWeight;
        private TextBox txtQty;
        private ComboBox ddlDepartment;
        private ComboBox ddlCategory;
        private ComboBox ddlTax;
        private CheckBox chkDiscount;
    }
}