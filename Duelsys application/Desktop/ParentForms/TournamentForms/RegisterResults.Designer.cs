using MediaBazaar.Design;

namespace DuelSysDesktop.ParentForms.TournamentForms
{
    partial class RegisterResults
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
            this.tbTeamAwayScore = new System.Windows.Forms.TextBox();
            this.lbTeamAway = new System.Windows.Forms.Label();
            this.btRegisterResult = new System.Windows.Forms.Button();
            this.lbTeamHome = new System.Windows.Forms.Label();
            this.tbTeamHomeScore = new System.Windows.Forms.TextBox();
            this.lbMatchId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbTeamAwayScore
            // 
            this.tbTeamAwayScore.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbTeamAwayScore.Location = new System.Drawing.Point(96, 73);
            this.tbTeamAwayScore.Name = "tbTeamAwayScore";
            this.tbTeamAwayScore.Size = new System.Drawing.Size(236, 41);
            this.tbTeamAwayScore.TabIndex = 0;
            // 
            // lbTeamAway
            // 
            this.lbTeamAway.AutoSize = true;
            this.lbTeamAway.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTeamAway.Location = new System.Drawing.Point(96, 35);
            this.lbTeamAway.Name = "lbTeamAway";
            this.lbTeamAway.Size = new System.Drawing.Size(133, 35);
            this.lbTeamAway.TabIndex = 2;
            this.lbTeamAway.Text = "TeamAway";
            // 
            // btRegisterResult
            // 
            this.btRegisterResult.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btRegisterResult.Location = new System.Drawing.Point(357, 179);
            this.btRegisterResult.Name = "btRegisterResult";
            this.btRegisterResult.Size = new System.Drawing.Size(192, 43);
            this.btRegisterResult.TabIndex = 3;
            this.btRegisterResult.Text = "Register result";
            this.btRegisterResult.UseVisualStyleBackColor = true;
            this.btRegisterResult.Click += new System.EventHandler(this.btRegisterResult_Click);
            // 
            // lbTeamHome
            // 
            this.lbTeamHome.AutoSize = true;
            this.lbTeamHome.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTeamHome.Location = new System.Drawing.Point(96, 142);
            this.lbTeamHome.Name = "lbTeamHome";
            this.lbTeamHome.Size = new System.Drawing.Size(142, 35);
            this.lbTeamHome.TabIndex = 5;
            this.lbTeamHome.Text = "TeamHome";
            // 
            // tbTeamHomeScore
            // 
            this.tbTeamHomeScore.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbTeamHomeScore.Location = new System.Drawing.Point(96, 180);
            this.tbTeamHomeScore.Name = "tbTeamHomeScore";
            this.tbTeamHomeScore.Size = new System.Drawing.Size(236, 41);
            this.tbTeamHomeScore.TabIndex = 4;
            // 
            // lbMatchId
            // 
            this.lbMatchId.AutoSize = true;
            this.lbMatchId.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbMatchId.Location = new System.Drawing.Point(357, 75);
            this.lbMatchId.Name = "lbMatchId";
            this.lbMatchId.Size = new System.Drawing.Size(125, 35);
            this.lbMatchId.TabIndex = 6;
            this.lbMatchId.Text = "Match Id: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 70);
            this.label1.TabIndex = 7;
            this.label1.Text = "Team\r\nAway";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(7, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 70);
            this.label2.TabIndex = 8;
            this.label2.Text = "Team\r\nHome\r\n";
            // 
            // RegisterResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 231);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbMatchId);
            this.Controls.Add(this.lbTeamHome);
            this.Controls.Add(this.tbTeamHomeScore);
            this.Controls.Add(this.btRegisterResult);
            this.Controls.Add(this.lbTeamAway);
            this.Controls.Add(this.tbTeamAwayScore);
            this.Name = "RegisterResults";
            this.Text = "RegisterResults";
            this.ResumeLayout(false);
            this.PerformLayout();
            DesignClass.AutoDesginerForForms(this.Controls, this);
        }

        #endregion

        private TextBox tbTeamAwayScore;
        private Label lbTeamAway;
        private Button btRegisterResult;
        private Label lbTeamHome;
        private TextBox tbTeamHomeScore;
        private Label lbMatchId;
        private Label label1;
        private Label label2;
    }
}