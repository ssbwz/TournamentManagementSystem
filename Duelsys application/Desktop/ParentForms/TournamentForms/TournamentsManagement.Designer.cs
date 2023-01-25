using MediaBazaar.Design;

namespace DuelSysDesktop.ParentForms.TournamentFroms
{
    partial class TournamentsManagement
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.ucCreateTournament = new DuelSysDesktop.UserControlsTournamentManagement.UCCreateTournament();
            this.ucViewTournaments = new DuelSysDesktop.UserControlsTournamentManagement.UCViewTournaments();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(610, 462);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(179, 54);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(413, 462);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(179, 54);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ucCreateTournament
            // 
            this.ucCreateTournament.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucCreateTournament.Location = new System.Drawing.Point(0, 0);
            this.ucCreateTournament.Name = "ucCreateTournament";
            this.ucCreateTournament.Size = new System.Drawing.Size(1244, 545);
            this.ucCreateTournament.TabIndex = 7;
            this.ucCreateTournament.Visible = false;
            // 
            // ucViewTournaments
            // 
            this.ucViewTournaments.Location = new System.Drawing.Point(0, 0);
            this.ucViewTournaments.Name = "ucViewTournaments";
            this.ucViewTournaments.Size = new System.Drawing.Size(1244, 441);
            this.ucViewTournaments.TabIndex = 8;
            // 
            // TournamentsManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 545);
            this.Controls.Add(this.ucViewTournaments);
            this.Controls.Add(this.ucCreateTournament);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCreate);
            this.Name = "TournamentsManagement";
            this.Text = "Tournaments Management";
            this.ResumeLayout(false);
            DesignClass.AutoDesginerForForms(this.Controls, this);
        }

        #endregion

        private Button btnCreate;
        private Button btnDelete;
        private UserControlsTournamentManagement.UCCreateTournament ucCreateTournament;
        private UserControlsTournamentManagement.UCViewTournaments ucViewTournaments;
    }
}