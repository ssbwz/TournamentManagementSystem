using MediaBazaar.Design;

namespace DuelSysDesktop.UserControlsTournamentManagement
{
    partial class UCCreateTournament
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTournamentSystem = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSportType = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudMaxPlayers = new System.Windows.Forms.NumericUpDown();
            this.nudMinPlayers = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbBuidlingNum = new System.Windows.Forms.TextBox();
            this.tbStreet = new System.Windows.Forms.TextBox();
            this.tbZipcode = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinPlayers)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(33, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Title";
            // 
            // tbTitle
            // 
            this.tbTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbTitle.Location = new System.Drawing.Point(33, 55);
            this.tbTitle.MaxLength = 40;
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(314, 39);
            this.tbTitle.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(33, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Description";
            // 
            // tbDescription
            // 
            this.tbDescription.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbDescription.Location = new System.Drawing.Point(33, 135);
            this.tbDescription.MaxLength = 255;
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(1194, 105);
            this.tbDescription.TabIndex = 255;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbTournamentSystem);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbSportType);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(27, 296);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 122);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Types";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(217, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tournament system";
            // 
            // cbTournamentSystem
            // 
            this.cbTournamentSystem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTournamentSystem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbTournamentSystem.FormattingEnabled = true;
            this.cbTournamentSystem.Location = new System.Drawing.Point(217, 60);
            this.cbTournamentSystem.Name = "cbTournamentSystem";
            this.cbTournamentSystem.Size = new System.Drawing.Size(179, 31);
            this.cbTournamentSystem.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(24, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sport type";
            // 
            // cbSportType
            // 
            this.cbSportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSportType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbSportType.FormattingEnabled = true;
            this.cbSportType.Location = new System.Drawing.Point(24, 60);
            this.cbSportType.Name = "cbSportType";
            this.cbSportType.Size = new System.Drawing.Size(151, 31);
            this.cbSportType.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nudMaxPlayers);
            this.groupBox2.Controls.Add(this.nudMinPlayers);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(459, 296);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(411, 122);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Requirements";
            // 
            // nudMaxPlayers
            // 
            this.nudMaxPlayers.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nudMaxPlayers.Location = new System.Drawing.Point(217, 61);
            this.nudMaxPlayers.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudMaxPlayers.Name = "nudMaxPlayers";
            this.nudMaxPlayers.Size = new System.Drawing.Size(150, 30);
            this.nudMaxPlayers.TabIndex = 10;
            this.nudMaxPlayers.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudMaxPlayers.ValueChanged += new System.EventHandler(this.nudMaxPlayers_ValueChanged);
            // 
            // nudMinPlayers
            // 
            this.nudMinPlayers.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nudMinPlayers.Location = new System.Drawing.Point(24, 61);
            this.nudMinPlayers.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudMinPlayers.Name = "nudMinPlayers";
            this.nudMinPlayers.Size = new System.Drawing.Size(150, 30);
            this.nudMinPlayers.TabIndex = 9;
            this.nudMinPlayers.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudMinPlayers.ValueChanged += new System.EventHandler(this.nudMinPlayers_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(217, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Maximum players";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(24, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 23);
            this.label6.TabIndex = 7;
            this.label6.Text = "Minimum players";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbBuidlingNum);
            this.groupBox3.Controls.Add(this.tbStreet);
            this.groupBox3.Controls.Add(this.tbZipcode);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(27, 421);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(679, 108);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Location";
            // 
            // tbBuidlingNum
            // 
            this.tbBuidlingNum.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbBuidlingNum.Location = new System.Drawing.Point(167, 71);
            this.tbBuidlingNum.MaxLength = 3;
            this.tbBuidlingNum.Name = "tbBuidlingNum";
            this.tbBuidlingNum.Size = new System.Drawing.Size(76, 27);
            this.tbBuidlingNum.TabIndex = 12;
            // 
            // tbStreet
            // 
            this.tbStreet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbStreet.Location = new System.Drawing.Point(84, 28);
            this.tbStreet.MaxLength = 50;
            this.tbStreet.Name = "tbStreet";
            this.tbStreet.Size = new System.Drawing.Size(367, 27);
            this.tbStreet.TabIndex = 11;
            // 
            // tbZipcode
            // 
            this.tbZipcode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbZipcode.Location = new System.Drawing.Point(542, 28);
            this.tbZipcode.MaxLength = 7;
            this.tbZipcode.Name = "tbZipcode";
            this.tbZipcode.Size = new System.Drawing.Size(125, 27);
            this.tbZipcode.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(465, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 23);
            this.label9.TabIndex = 9;
            this.label9.Text = "Zipcode";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(24, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 23);
            this.label7.TabIndex = 8;
            this.label7.Text = "Buidling number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(24, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 23);
            this.label8.TabIndex = 7;
            this.label8.Text = "Street";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.Location = new System.Drawing.Point(1093, 493);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(123, 36);
            this.btnBack.TabIndex = 23;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCreate.Location = new System.Drawing.Point(944, 493);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(123, 36);
            this.btnCreate.TabIndex = 22;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtpEndDate);
            this.groupBox4.Controls.Add(this.dtpStartDate);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox4.Location = new System.Drawing.Point(876, 296);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(351, 122);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Duration";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CalendarFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpEndDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpEndDate.Location = new System.Drawing.Point(95, 89);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(250, 27);
            this.dtpEndDate.TabIndex = 10;
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpEndDate_ValueChanged);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CalendarFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpStartDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpStartDate.Location = new System.Drawing.Point(95, 38);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(250, 27);
            this.dtpStartDate.TabIndex = 9;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(11, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 23);
            this.label10.TabIndex = 8;
            this.label10.Text = "Start date";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(11, 93);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 23);
            this.label12.TabIndex = 7;
            this.label12.Text = "End date";
            // 
            // UCCreateTournament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTitle);
            this.Name = "UCCreateTournament";
            this.Size = new System.Drawing.Size(1230, 535);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinPlayers)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox tbTitle;
        private Label label2;
        private TextBox tbDescription;
        private GroupBox groupBox1;
        private Label label4;
        private ComboBox cbTournamentSystem;
        private Label label3;
        private ComboBox cbSportType;
        private GroupBox groupBox2;
        private NumericUpDown nudMaxPlayers;
        private NumericUpDown nudMinPlayers;
        private Label label5;
        private Label label6;
        private GroupBox groupBox3;
        private Label label7;
        private Label label8;
        private TextBox tbBuidlingNum;
        private TextBox tbStreet;
        private TextBox tbZipcode;
        private Label label9;
        private Button btnBack;
        private Button btnCreate;
        private GroupBox groupBox4;
        private Label label10;
        private Label label12;
        private DateTimePicker dtpEndDate;
        private DateTimePicker dtpStartDate;
    }
}
