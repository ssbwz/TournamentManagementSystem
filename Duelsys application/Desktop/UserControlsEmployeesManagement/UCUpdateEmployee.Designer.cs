using MediaBazaar.Design;

namespace DuelSysDesktop.UserControlsEmployeesManagement
{
    partial class UCUpdateEmployee
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbUserType = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pAdminView = new System.Windows.Forms.Panel();
            this.lbType = new System.Windows.Forms.Label();
            this.lbBSN = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbBSN = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbPhoneNumber = new System.Windows.Forms.Label();
            this.lbDateOfBirth = new System.Windows.Forms.Label();
            this.lbGender = new System.Windows.Forms.Label();
            this.lbLastName = new System.Windows.Forms.Label();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.pAdminView.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbUserType
            // 
            this.cbUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUserType.FormattingEnabled = true;
            this.cbUserType.Items.AddRange(new object[] {
            "Employee",
            "Admin",
            "Association Admin"});
            this.cbUserType.Location = new System.Drawing.Point(46, 38);
            this.cbUserType.Name = "cbUserType";
            this.cbUserType.Size = new System.Drawing.Size(151, 28);
            this.cbUserType.TabIndex = 36;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(53, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 28);
            this.label11.TabIndex = 39;
            this.label11.Text = "Type";
            // 
            // pAdminView
            // 
            this.pAdminView.Controls.Add(this.cbUserType);
            this.pAdminView.Controls.Add(this.lbType);
            this.pAdminView.Controls.Add(this.label11);
            this.pAdminView.Location = new System.Drawing.Point(593, 282);
            this.pAdminView.Name = "pAdminView";
            this.pAdminView.Size = new System.Drawing.Size(250, 125);
            this.pAdminView.TabIndex = 65;
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.ForeColor = System.Drawing.Color.Red;
            this.lbType.Location = new System.Drawing.Point(47, 69);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(157, 20);
            this.lbType.TabIndex = 40;
            this.lbType.Text = "Place enter vaild value";
            this.lbType.Visible = false;
            // 
            // lbBSN
            // 
            this.lbBSN.AutoSize = true;
            this.lbBSN.ForeColor = System.Drawing.Color.Red;
            this.lbBSN.Location = new System.Drawing.Point(351, 350);
            this.lbBSN.Name = "lbBSN";
            this.lbBSN.Size = new System.Drawing.Size(157, 20);
            this.lbBSN.TabIndex = 64;
            this.lbBSN.Text = "Place enter vaild value";
            this.lbBSN.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(351, 282);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 28);
            this.label8.TabIndex = 63;
            this.label8.Text = "BSN";
            // 
            // tbBSN
            // 
            this.tbBSN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbBSN.Location = new System.Drawing.Point(351, 313);
            this.tbBSN.MaxLength = 15;
            this.tbBSN.Name = "tbBSN";
            this.tbBSN.Size = new System.Drawing.Size(212, 34);
            this.tbBSN.TabIndex = 62;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPassword.ForeColor = System.Drawing.Color.Red;
            this.lbPassword.Location = new System.Drawing.Point(31, 457);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(144, 19);
            this.lbPassword.TabIndex = 61;
            this.lbPassword.Text = "Place enter vaild value";
            this.lbPassword.Visible = false;
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbUsername.ForeColor = System.Drawing.Color.Red;
            this.lbUsername.Location = new System.Drawing.Point(31, 350);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(144, 19);
            this.lbUsername.TabIndex = 60;
            this.lbUsername.Text = "Place enter vaild value";
            this.lbUsername.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(31, 282);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 28);
            this.label9.TabIndex = 59;
            this.label9.Text = "Username";
            // 
            // tbUsername
            // 
            this.tbUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbUsername.Location = new System.Drawing.Point(31, 313);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(212, 34);
            this.tbUsername.TabIndex = 58;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(31, 389);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 28);
            this.label10.TabIndex = 57;
            this.label10.Text = "Password";
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPassword.Location = new System.Drawing.Point(31, 420);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(212, 34);
            this.tbPassword.TabIndex = 56;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(704, 441);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(123, 36);
            this.btnBack.TabIndex = 55;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.ForeColor = System.Drawing.Color.Red;
            this.lbEmail.Location = new System.Drawing.Point(640, 240);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(157, 20);
            this.lbEmail.TabIndex = 54;
            this.lbEmail.Text = "Place enter vaild value";
            this.lbEmail.Visible = false;
            // 
            // lbPhoneNumber
            // 
            this.lbPhoneNumber.AutoSize = true;
            this.lbPhoneNumber.ForeColor = System.Drawing.Color.Red;
            this.lbPhoneNumber.Location = new System.Drawing.Point(352, 245);
            this.lbPhoneNumber.Name = "lbPhoneNumber";
            this.lbPhoneNumber.Size = new System.Drawing.Size(157, 20);
            this.lbPhoneNumber.TabIndex = 53;
            this.lbPhoneNumber.Text = "Place enter vaild value";
            this.lbPhoneNumber.Visible = false;
            // 
            // lbDateOfBirth
            // 
            this.lbDateOfBirth.AutoSize = true;
            this.lbDateOfBirth.ForeColor = System.Drawing.Color.Red;
            this.lbDateOfBirth.Location = new System.Drawing.Point(32, 240);
            this.lbDateOfBirth.Name = "lbDateOfBirth";
            this.lbDateOfBirth.Size = new System.Drawing.Size(157, 20);
            this.lbDateOfBirth.TabIndex = 52;
            this.lbDateOfBirth.Text = "Place enter vaild value";
            this.lbDateOfBirth.Visible = false;
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.ForeColor = System.Drawing.Color.Red;
            this.lbGender.Location = new System.Drawing.Point(640, 146);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(137, 20);
            this.lbGender.TabIndex = 51;
            this.lbGender.Text = "Place select gender";
            this.lbGender.Visible = false;
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.ForeColor = System.Drawing.Color.Red;
            this.lbLastName.Location = new System.Drawing.Point(352, 152);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(157, 20);
            this.lbLastName.TabIndex = 50;
            this.lbLastName.Text = "Place enter vaild value";
            this.lbLastName.Visible = false;
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.ForeColor = System.Drawing.Color.Red;
            this.lbFirstName.Location = new System.Drawing.Point(31, 152);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(157, 20);
            this.lbFirstName.TabIndex = 49;
            this.lbFirstName.Text = "Place enter vaild value";
            this.lbFirstName.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.Location = new System.Drawing.Point(552, 441);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(123, 36);
            this.btnUpdate.TabIndex = 48;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cbGender
            // 
            this.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Location = new System.Drawing.Point(640, 115);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(151, 28);
            this.cbGender.TabIndex = 47;
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Location = new System.Drawing.Point(32, 208);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(250, 27);
            this.dtpDateOfBirth.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(352, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 28);
            this.label6.TabIndex = 45;
            this.label6.Text = "Phone number";
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPhoneNumber.Location = new System.Drawing.Point(352, 208);
            this.tbPhoneNumber.MaxLength = 15;
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(212, 34);
            this.tbPhoneNumber.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(640, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 28);
            this.label5.TabIndex = 43;
            this.label5.Text = "Email";
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbEmail.Location = new System.Drawing.Point(640, 203);
            this.tbEmail.MaxLength = 256;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(212, 34);
            this.tbEmail.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(639, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 28);
            this.label4.TabIndex = 41;
            this.label4.Text = "Gender";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(32, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 28);
            this.label3.TabIndex = 40;
            this.label3.Text = "Date of Birth";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(351, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 28);
            this.label2.TabIndex = 39;
            this.label2.Text = "Last name";
            // 
            // tbLastName
            // 
            this.tbLastName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbLastName.Location = new System.Drawing.Point(351, 115);
            this.tbLastName.MaxLength = 30;
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(212, 34);
            this.tbLastName.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(31, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 28);
            this.label1.TabIndex = 37;
            this.label1.Text = "First name";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbFirstName.Location = new System.Drawing.Point(31, 115);
            this.tbFirstName.MaxLength = 30;
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(212, 34);
            this.tbFirstName.TabIndex = 36;
            // 
            // UCUpdateEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pAdminView);
            this.Controls.Add(this.lbBSN);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbBSN);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbPhoneNumber);
            this.Controls.Add(this.lbDateOfBirth);
            this.Controls.Add(this.lbGender);
            this.Controls.Add(this.lbLastName);
            this.Controls.Add(this.lbFirstName);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.dtpDateOfBirth);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbPhoneNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbFirstName);
            this.Name = "UCUpdateEmployee";
            this.Size = new System.Drawing.Size(876, 505);
            this.pAdminView.ResumeLayout(false);
            this.pAdminView.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
            DesignClass.AutoDesginerForUserControl(this.Controls, this);
        }

        #endregion

        private ComboBox cbUserType;
        private Label label11;
        private Panel pAdminView;
        private Label lbType;
        private Label lbBSN;
        private Label label8;
        private TextBox tbBSN;
        private Label lbPassword;
        private Label lbUsername;
        private Label label9;
        private TextBox tbUsername;
        private Label label10;
        private TextBox tbPassword;
        private Button btnBack;
        private Label lbEmail;
        private Label lbPhoneNumber;
        private Label lbDateOfBirth;
        private Label lbGender;
        private Label lbLastName;
        private Label lbFirstName;
        private Button btnUpdate;
        private ComboBox cbGender;
        private DateTimePicker dtpDateOfBirth;
        private Label label6;
        private TextBox tbPhoneNumber;
        private Label label5;
        private TextBox tbEmail;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox tbLastName;
        private Label label1;
        private TextBox tbFirstName;
    }
}
