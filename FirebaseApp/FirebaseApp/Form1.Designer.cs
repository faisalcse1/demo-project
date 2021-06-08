namespace FirebaseApp
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.employeeDataGridView = new System.Windows.Forms.DataGridView();
            this.saveButton = new System.Windows.Forms.Button();
            this.fatherNameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.phoneNoTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.employeeNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FatherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblId = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deleteButton);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Controls.Add(this.employeeDataGridView);
            this.groupBox1.Controls.Add(this.saveButton);
            this.groupBox1.Controls.Add(this.fatherNameTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.phoneNoTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.addressTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.emailTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.employeeNameTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(740, 453);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Info";
            // 
            // employeeDataGridView
            // 
            this.employeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.EmployeeName,
            this.PhoneNo,
            this.Address,
            this.FatherName,
            this.Email});
            this.employeeDataGridView.Location = new System.Drawing.Point(6, 278);
            this.employeeDataGridView.Name = "employeeDataGridView";
            this.employeeDataGridView.Size = new System.Drawing.Size(728, 169);
            this.employeeDataGridView.TabIndex = 3;
            this.employeeDataGridView.DoubleClick += new System.EventHandler(this.employeeDataGridView_DoubleClick);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(350, 230);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(94, 37);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // fatherNameTextBox
            // 
            this.fatherNameTextBox.Location = new System.Drawing.Point(217, 195);
            this.fatherNameTextBox.Name = "fatherNameTextBox";
            this.fatherNameTextBox.Size = new System.Drawing.Size(227, 29);
            this.fatherNameTextBox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Father Name";
            // 
            // phoneNoTextBox
            // 
            this.phoneNoTextBox.Location = new System.Drawing.Point(217, 160);
            this.phoneNoTextBox.Name = "phoneNoTextBox";
            this.phoneNoTextBox.Size = new System.Drawing.Size(227, 29);
            this.phoneNoTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Phone No";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(217, 125);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(227, 29);
            this.addressTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Address";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(217, 90);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(227, 29);
            this.emailTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Email";
            // 
            // employeeNameTextBox
            // 
            this.employeeNameTextBox.Location = new System.Drawing.Point(217, 55);
            this.employeeNameTextBox.Name = "employeeNameTextBox";
            this.employeeNameTextBox.Size = new System.Drawing.Size(227, 29);
            this.employeeNameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Name";
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // EmployeeName
            // 
            this.EmployeeName.HeaderText = "Employee Name";
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.Width = 180;
            // 
            // PhoneNo
            // 
            this.PhoneNo.HeaderText = "Phone No";
            this.PhoneNo.Name = "PhoneNo";
            this.PhoneNo.Width = 130;
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.Width = 150;
            // 
            // FatherName
            // 
            this.FatherName.HeaderText = "Father Name";
            this.FatherName.Name = "FatherName";
            this.FatherName.Width = 180;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.Width = 180;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(544, 92);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 24);
            this.lblId.TabIndex = 4;
            this.lblId.Visible = false;
            // 
            // deleteButton
            // 
            this.deleteButton.Enabled = false;
            this.deleteButton.Location = new System.Drawing.Point(227, 230);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(117, 37);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 477);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox fatherNameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox phoneNoTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox employeeNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DataGridView employeeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn FatherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button deleteButton;
    }
}

