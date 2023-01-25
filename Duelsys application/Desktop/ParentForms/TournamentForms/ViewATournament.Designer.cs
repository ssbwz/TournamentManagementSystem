using MediaBazaar.Design;

namespace DuelSysDesktop.ParentForms.TournamentFroms
{
    partial class ViewATournament
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TournamentTabs = new System.Windows.Forms.TabControl();
            this.tpInformation = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbBuidlingNum = new System.Windows.Forms.TextBox();
            this.tbStreet = new System.Windows.Forms.TextBox();
            this.tbZipcode = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTournamentSystem = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSportType = new System.Windows.Forms.ComboBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudMaxPlayers = new System.Windows.Forms.NumericUpDown();
            this.nudMinPlayers = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbSchedule = new System.Windows.Forms.TabPage();
            this.lbPageNumber = new System.Windows.Forms.Label();
            this.NUDPages = new System.Windows.Forms.NumericUpDown();
            this.DGVViewMatches = new System.Windows.Forms.DataGridView();
            this.lbThereAreNoSchedule = new System.Windows.Forms.Label();
            this.btGenerateSchedule = new System.Windows.Forms.Button();
            this.tpOverview = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lbSportType = new System.Windows.Forms.Label();
            this.lbTournamentSystem = new System.Windows.Forms.Label();
            this.lbStreet = new System.Windows.Forms.Label();
            this.lbStartDate = new System.Windows.Forms.Label();
            this.lbEndDate = new System.Windows.Forms.Label();
            this.lbGold = new System.Windows.Forms.Label();
            this.lbSilver = new System.Windows.Forms.Label();
            this.lbBronze = new System.Windows.Forms.Label();
            this.DGVParticipants = new System.Windows.Forms.DataGridView();
            this.DGVFinalMatches = new System.Windows.Forms.DataGridView();
            this.TournamentTabs.SuspendLayout();
            this.tpInformation.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinPlayers)).BeginInit();
            this.tbSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDPages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVViewMatches)).BeginInit();
            this.tpOverview.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVParticipants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVFinalMatches)).BeginInit();
            this.SuspendLayout();
            // 
            // TournamentTabs
            // 
            this.TournamentTabs.Controls.Add(this.tpInformation);
            this.TournamentTabs.Controls.Add(this.tbSchedule);
            this.TournamentTabs.Controls.Add(this.tpOverview);
            this.TournamentTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TournamentTabs.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TournamentTabs.ItemSize = new System.Drawing.Size(404, 40);
            this.TournamentTabs.Location = new System.Drawing.Point(0, 0);
            this.TournamentTabs.Name = "TournamentTabs";
            this.TournamentTabs.SelectedIndex = 0;
            this.TournamentTabs.Size = new System.Drawing.Size(1216, 563);
            this.TournamentTabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TournamentTabs.TabIndex = 0;
            // 
            // tpInformation
            // 
            this.tpInformation.Controls.Add(this.groupBox3);
            this.tpInformation.Controls.Add(this.label1);
            this.tpInformation.Controls.Add(this.groupBox1);
            this.tpInformation.Controls.Add(this.tbTitle);
            this.tpInformation.Controls.Add(this.label2);
            this.tpInformation.Controls.Add(this.tbDescription);
            this.tpInformation.Controls.Add(this.groupBox4);
            this.tpInformation.Controls.Add(this.groupBox2);
            this.tpInformation.Controls.Add(this.btnSave);
            this.tpInformation.Location = new System.Drawing.Point(4, 44);
            this.tpInformation.Name = "tpInformation";
            this.tpInformation.Padding = new System.Windows.Forms.Padding(3);
            this.tpInformation.Size = new System.Drawing.Size(1208, 515);
            this.tpInformation.TabIndex = 0;
            this.tpInformation.Text = "Information";
            this.tpInformation.UseVisualStyleBackColor = true;
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
            this.groupBox3.Location = new System.Drawing.Point(4, 402);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(679, 108);
            this.groupBox3.TabIndex = 271;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(10, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 32);
            this.label1.TabIndex = 267;
            this.label1.Text = "Title";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbTournamentSystem);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbSportType);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(4, 277);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 122);
            this.groupBox1.TabIndex = 269;
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
            // tbTitle
            // 
            this.tbTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbTitle.Location = new System.Drawing.Point(10, 36);
            this.tbTitle.MaxLength = 40;
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(314, 39);
            this.tbTitle.TabIndex = 266;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(10, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 32);
            this.label2.TabIndex = 268;
            this.label2.Text = "Description";
            // 
            // tbDescription
            // 
            this.tbDescription.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbDescription.Location = new System.Drawing.Point(10, 116);
            this.tbDescription.MaxLength = 255;
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(1194, 105);
            this.tbDescription.TabIndex = 274;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtpEndDate);
            this.groupBox4.Controls.Add(this.dtpStartDate);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox4.Location = new System.Drawing.Point(853, 277);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(351, 122);
            this.groupBox4.TabIndex = 272;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nudMaxPlayers);
            this.groupBox2.Controls.Add(this.nudMinPlayers);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(436, 277);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(411, 122);
            this.groupBox2.TabIndex = 270;
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
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(1075, 474);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(123, 36);
            this.btnSave.TabIndex = 273;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbSchedule
            // 
            this.tbSchedule.Controls.Add(this.lbPageNumber);
            this.tbSchedule.Controls.Add(this.NUDPages);
            this.tbSchedule.Controls.Add(this.DGVViewMatches);
            this.tbSchedule.Controls.Add(this.lbThereAreNoSchedule);
            this.tbSchedule.Controls.Add(this.btGenerateSchedule);
            this.tbSchedule.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbSchedule.Location = new System.Drawing.Point(4, 44);
            this.tbSchedule.Name = "tbSchedule";
            this.tbSchedule.Padding = new System.Windows.Forms.Padding(3);
            this.tbSchedule.Size = new System.Drawing.Size(1208, 515);
            this.tbSchedule.TabIndex = 1;
            this.tbSchedule.Text = "Schedule";
            this.tbSchedule.UseVisualStyleBackColor = true;
            // 
            // lbPageNumber
            // 
            this.lbPageNumber.AutoSize = true;
            this.lbPageNumber.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPageNumber.Location = new System.Drawing.Point(369, 408);
            this.lbPageNumber.Name = "lbPageNumber";
            this.lbPageNumber.Size = new System.Drawing.Size(175, 32);
            this.lbPageNumber.TabIndex = 278;
            this.lbPageNumber.Text = "Page number : ";
            // 
            // NUDPages
            // 
            this.NUDPages.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NUDPages.Location = new System.Drawing.Point(573, 401);
            this.NUDPages.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDPages.Name = "NUDPages";
            this.NUDPages.Size = new System.Drawing.Size(76, 39);
            this.NUDPages.TabIndex = 277;
            this.NUDPages.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NUDPages.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDPages.ValueChanged += new System.EventHandler(this.NUDPages_ValueChanged);
            // 
            // DGVViewMatches
            // 
            this.DGVViewMatches.AllowUserToAddRows = false;
            this.DGVViewMatches.AllowUserToDeleteRows = false;
            this.DGVViewMatches.AllowUserToResizeColumns = false;
            this.DGVViewMatches.AllowUserToResizeRows = false;
            this.DGVViewMatches.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVViewMatches.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVViewMatches.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.DGVViewMatches.ColumnHeadersHeight = 29;
            this.DGVViewMatches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVViewMatches.DefaultCellStyle = dataGridViewCellStyle11;
            this.DGVViewMatches.Location = new System.Drawing.Point(24, 40);
            this.DGVViewMatches.MultiSelect = false;
            this.DGVViewMatches.Name = "DGVViewMatches";
            this.DGVViewMatches.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVViewMatches.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.DGVViewMatches.RowHeadersVisible = false;
            this.DGVViewMatches.RowHeadersWidth = 51;
            this.DGVViewMatches.RowTemplate.Height = 29;
            this.DGVViewMatches.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DGVViewMatches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVViewMatches.Size = new System.Drawing.Size(1149, 334);
            this.DGVViewMatches.TabIndex = 276;
            this.DGVViewMatches.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVViewMatches_CellDoubleClick);
            // 
            // lbThereAreNoSchedule
            // 
            this.lbThereAreNoSchedule.AutoSize = true;
            this.lbThereAreNoSchedule.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbThereAreNoSchedule.Location = new System.Drawing.Point(343, 115);
            this.lbThereAreNoSchedule.Name = "lbThereAreNoSchedule";
            this.lbThereAreNoSchedule.Size = new System.Drawing.Size(512, 67);
            this.lbThereAreNoSchedule.TabIndex = 275;
            this.lbThereAreNoSchedule.Text = "There are no schedule";
            // 
            // btGenerateSchedule
            // 
            this.btGenerateSchedule.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btGenerateSchedule.Location = new System.Drawing.Point(923, 429);
            this.btGenerateSchedule.Name = "btGenerateSchedule";
            this.btGenerateSchedule.Size = new System.Drawing.Size(272, 60);
            this.btGenerateSchedule.TabIndex = 274;
            this.btGenerateSchedule.Text = "Generate schedule";
            this.btGenerateSchedule.UseVisualStyleBackColor = true;
            this.btGenerateSchedule.Click += new System.EventHandler(this.btGenerateSchedule_Click);
            // 
            // tpOverview
            // 
            this.tpOverview.Controls.Add(this.DGVFinalMatches);
            this.tpOverview.Controls.Add(this.DGVParticipants);
            this.tpOverview.Controls.Add(this.groupBox6);
            this.tpOverview.Controls.Add(this.groupBox5);
            this.tpOverview.Location = new System.Drawing.Point(4, 44);
            this.tpOverview.Name = "tpOverview";
            this.tpOverview.Size = new System.Drawing.Size(1208, 515);
            this.tpOverview.TabIndex = 2;
            this.tpOverview.Text = "Overview";
            this.tpOverview.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lbEndDate);
            this.groupBox5.Controls.Add(this.lbStartDate);
            this.groupBox5.Controls.Add(this.lbStreet);
            this.groupBox5.Controls.Add(this.lbTournamentSystem);
            this.groupBox5.Controls.Add(this.lbSportType);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox5.Location = new System.Drawing.Point(12, 15);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1170, 193);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tournament information";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lbBronze);
            this.groupBox6.Controls.Add(this.lbSilver);
            this.groupBox6.Controls.Add(this.lbGold);
            this.groupBox6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox6.Location = new System.Drawing.Point(12, 362);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(340, 145);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Final results";
            // 
            // lbSportType
            // 
            this.lbSportType.AutoSize = true;
            this.lbSportType.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSportType.Location = new System.Drawing.Point(21, 40);
            this.lbSportType.Name = "lbSportType";
            this.lbSportType.Size = new System.Drawing.Size(77, 30);
            this.lbSportType.TabIndex = 0;
            this.lbSportType.Text = "Sport: ";
            // 
            // lbTournamentSystem
            // 
            this.lbTournamentSystem.AutoSize = true;
            this.lbTournamentSystem.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTournamentSystem.Location = new System.Drawing.Point(21, 80);
            this.lbTournamentSystem.Name = "lbTournamentSystem";
            this.lbTournamentSystem.Size = new System.Drawing.Size(93, 30);
            this.lbTournamentSystem.TabIndex = 1;
            this.lbTournamentSystem.Text = "System: ";
            // 
            // lbStreet
            // 
            this.lbStreet.AutoSize = true;
            this.lbStreet.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbStreet.Location = new System.Drawing.Point(21, 133);
            this.lbStreet.Name = "lbStreet";
            this.lbStreet.Size = new System.Drawing.Size(81, 30);
            this.lbStreet.TabIndex = 2;
            this.lbStreet.Text = "Street: ";
            // 
            // lbStartDate
            // 
            this.lbStartDate.AutoSize = true;
            this.lbStartDate.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbStartDate.Location = new System.Drawing.Point(623, 50);
            this.lbStartDate.Name = "lbStartDate";
            this.lbStartDate.Size = new System.Drawing.Size(117, 30);
            this.lbStartDate.TabIndex = 3;
            this.lbStartDate.Text = "Start date: ";
            // 
            // lbEndDate
            // 
            this.lbEndDate.AutoSize = true;
            this.lbEndDate.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbEndDate.Location = new System.Drawing.Point(623, 108);
            this.lbEndDate.Name = "lbEndDate";
            this.lbEndDate.Size = new System.Drawing.Size(109, 30);
            this.lbEndDate.TabIndex = 4;
            this.lbEndDate.Text = "End date: ";
            // 
            // lbGold
            // 
            this.lbGold.AutoSize = true;
            this.lbGold.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbGold.Location = new System.Drawing.Point(21, 52);
            this.lbGold.Name = "lbGold";
            this.lbGold.Size = new System.Drawing.Size(70, 30);
            this.lbGold.TabIndex = 5;
            this.lbGold.Text = "Gold: ";
            // 
            // lbSilver
            // 
            this.lbSilver.AutoSize = true;
            this.lbSilver.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSilver.Location = new System.Drawing.Point(21, 82);
            this.lbSilver.Name = "lbSilver";
            this.lbSilver.Size = new System.Drawing.Size(83, 30);
            this.lbSilver.TabIndex = 6;
            this.lbSilver.Text = "Silver:  ";
            // 
            // lbBronze
            // 
            this.lbBronze.AutoSize = true;
            this.lbBronze.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbBronze.Location = new System.Drawing.Point(6, 112);
            this.lbBronze.Name = "lbBronze";
            this.lbBronze.Size = new System.Drawing.Size(98, 30);
            this.lbBronze.TabIndex = 7;
            this.lbBronze.Text = "Bronze:  ";
            // 
            // DGVParticipants
            // 
            this.DGVParticipants.AllowUserToAddRows = false;
            this.DGVParticipants.AllowUserToDeleteRows = false;
            this.DGVParticipants.AllowUserToResizeColumns = false;
            this.DGVParticipants.AllowUserToResizeRows = false;
            this.DGVParticipants.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVParticipants.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVParticipants.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.DGVParticipants.ColumnHeadersHeight = 29;
            this.DGVParticipants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVParticipants.DefaultCellStyle = dataGridViewCellStyle14;
            this.DGVParticipants.Location = new System.Drawing.Point(12, 214);
            this.DGVParticipants.MultiSelect = false;
            this.DGVParticipants.Name = "DGVParticipants";
            this.DGVParticipants.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVParticipants.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.DGVParticipants.RowHeadersVisible = false;
            this.DGVParticipants.RowHeadersWidth = 51;
            this.DGVParticipants.RowTemplate.Height = 29;
            this.DGVParticipants.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DGVParticipants.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVParticipants.Size = new System.Drawing.Size(486, 142);
            this.DGVParticipants.TabIndex = 277;
            // 
            // DGVFinalMatches
            // 
            this.DGVFinalMatches.AllowUserToAddRows = false;
            this.DGVFinalMatches.AllowUserToDeleteRows = false;
            this.DGVFinalMatches.AllowUserToResizeColumns = false;
            this.DGVFinalMatches.AllowUserToResizeRows = false;
            this.DGVFinalMatches.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVFinalMatches.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVFinalMatches.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.DGVFinalMatches.ColumnHeadersHeight = 29;
            this.DGVFinalMatches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVFinalMatches.DefaultCellStyle = dataGridViewCellStyle17;
            this.DGVFinalMatches.Location = new System.Drawing.Point(535, 214);
            this.DGVFinalMatches.MultiSelect = false;
            this.DGVFinalMatches.Name = "DGVFinalMatches";
            this.DGVFinalMatches.ReadOnly = true;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVFinalMatches.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.DGVFinalMatches.RowHeadersVisible = false;
            this.DGVFinalMatches.RowHeadersWidth = 51;
            this.DGVFinalMatches.RowTemplate.Height = 29;
            this.DGVFinalMatches.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DGVFinalMatches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVFinalMatches.Size = new System.Drawing.Size(647, 293);
            this.DGVFinalMatches.TabIndex = 278;
            // 
            // ViewATournament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 563);
            this.Controls.Add(this.TournamentTabs);
            this.Name = "ViewATournament";
            this.Text = "View a tournament";
            this.TournamentTabs.ResumeLayout(false);
            this.tpInformation.ResumeLayout(false);
            this.tpInformation.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinPlayers)).EndInit();
            this.tbSchedule.ResumeLayout(false);
            this.tbSchedule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDPages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVViewMatches)).EndInit();
            this.tpOverview.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVParticipants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVFinalMatches)).EndInit();
            this.ResumeLayout(false);
            DesignClass.AutoDesginerForForms(this.Controls, this);
        }

        #endregion

        private TabControl TournamentTabs;
        private TabPage tpInformation;
        private TabPage tbSchedule;
        private GroupBox groupBox3;
        private TextBox tbBuidlingNum;
        private TextBox tbStreet;
        private TextBox tbZipcode;
        private Label label9;
        private Label label7;
        private Label label8;
        private Label label1;
        private GroupBox groupBox1;
        private Label label4;
        private ComboBox cbTournamentSystem;
        private Label label3;
        private ComboBox cbSportType;
        private TextBox tbTitle;
        private Label label2;
        private TextBox tbDescription;
        private GroupBox groupBox4;
        private DateTimePicker dtpEndDate;
        private DateTimePicker dtpStartDate;
        private Label label10;
        private Label label12;
        private GroupBox groupBox2;
        private NumericUpDown nudMaxPlayers;
        private NumericUpDown nudMinPlayers;
        private Label label5;
        private Label label6;
        private Button btnSave;
        private Label lbThereAreNoSchedule;
        private Button btGenerateSchedule;
        private DataGridView DGVViewMatches;
        private Label lbPageNumber;
        private NumericUpDown NUDPages;
        private TabPage tpOverview;
        private GroupBox groupBox6;
        private GroupBox groupBox5;
        private Label lbStreet;
        private Label lbTournamentSystem;
        private Label lbSportType;
        private Label lbEndDate;
        private Label lbStartDate;
        private Label lbBronze;
        private Label lbSilver;
        private Label lbGold;
        private DataGridView DGVFinalMatches;
        private DataGridView DGVParticipants;
    }
}