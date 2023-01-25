using MediaBazaar.Design;

namespace DuelSysDesktop.ParentForms.AssociationAdmin
{
    partial class MainAssociationAdmin
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
            this.btLogOut = new System.Windows.Forms.Button();
            this.btTournament = new System.Windows.Forms.Button();
            this.btEmployees = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btLogOut
            // 
            this.btLogOut.Location = new System.Drawing.Point(767, 12);
            this.btLogOut.Name = "btLogOut";
            this.btLogOut.Size = new System.Drawing.Size(93, 29);
            this.btLogOut.TabIndex = 5;
            this.btLogOut.Text = "log out";
            this.btLogOut.UseVisualStyleBackColor = true;
            this.btLogOut.Click += new System.EventHandler(this.btLogOut_Click);
            // 
            // btTournament
            // 
            this.btTournament.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btTournament.Location = new System.Drawing.Point(431, 446);
            this.btTournament.Name = "btTournament";
            this.btTournament.Size = new System.Drawing.Size(442, 52);
            this.btTournament.TabIndex = 4;
            this.btTournament.Text = "Tournaments";
            this.btTournament.UseVisualStyleBackColor = true;
            // 
            // btEmployees
            // 
            this.btEmployees.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btEmployees.Location = new System.Drawing.Point(-3, 446);
            this.btEmployees.Name = "btEmployees";
            this.btEmployees.Size = new System.Drawing.Size(436, 52);
            this.btEmployees.TabIndex = 3;
            this.btEmployees.Text = "Employees";
            this.btEmployees.UseVisualStyleBackColor = true;
            this.btEmployees.Click += new System.EventHandler(this.btEmployees_Click);
            // 
            // MainAssociationAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 498);
            this.Controls.Add(this.btLogOut);
            this.Controls.Add(this.btTournament);
            this.Controls.Add(this.btEmployees);
            this.Name = "MainAssociationAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainAssociationAdmin";
            this.ResumeLayout(false);
        }

        #endregion

        private Button btLogOut;
        private Button btTournament;
        private Button btEmployees;
    }
}