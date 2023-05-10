namespace MyPOS
{
    partial class frmlogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        private TextBox GetTextBox2()
        {
            return textBox2;
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CLOSEbtn = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            LOGINbtn = new Button();
            label2 = new Label();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // CLOSEbtn
            // 
            CLOSEbtn.BackColor = Color.Gainsboro;
            CLOSEbtn.Location = new Point(355, 213);
            CLOSEbtn.Name = "CLOSEbtn";
            CLOSEbtn.Size = new Size(107, 42);
            CLOSEbtn.TabIndex = 0;
            CLOSEbtn.Text = "CLOSE";
            CLOSEbtn.UseVisualStyleBackColor = false;
            CLOSEbtn.Click += CLOSEbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(104, 135);
            label1.Name = "label1";
            label1.Size = new Size(144, 26);
            label1.TabIndex = 1;
            label1.Text = "PASSWORD";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(301, 126);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(244, 35);
            textBox1.TabIndex = 2;
            textBox1.UseSystemPasswordChar = true;
            // 
            // LOGINbtn
            // 
            LOGINbtn.BackColor = Color.Gainsboro;
            LOGINbtn.Location = new Point(167, 213);
            LOGINbtn.Name = "LOGINbtn";
            LOGINbtn.Size = new Size(107, 42);
            LOGINbtn.TabIndex = 0;
            LOGINbtn.Text = "LOGIN";
            LOGINbtn.UseVisualStyleBackColor = false;
            LOGINbtn.Click += LOGINbtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(123, 68);
            label2.Name = "label2";
            label2.Size = new Size(75, 26);
            label2.TabIndex = 1;
            label2.Text = "USER";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(301, 68);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(244, 35);
            textBox2.TabIndex = 2;
            // 
            // frmlogin
            // 
            AutoScaleDimensions = new SizeF(13F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(614, 325);
            ControlBox = false;
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LOGINbtn);
            Controls.Add(CLOSEbtn);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "frmlogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button CLOSEbtn;
        private Label label1;
        private TextBox textBox1;
        private Button LOGINbtn;
        private Label label2;
        private TextBox textBox2;
    }
}