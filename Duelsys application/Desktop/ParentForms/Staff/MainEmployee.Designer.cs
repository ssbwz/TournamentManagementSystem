using MediaBazaar.Design;

namespace DuelSysDesktop.ParentForms
{
    partial class MainEmployee
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
            this.btTournament = new System.Windows.Forms.Button();
            this.btLogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btTournament
            // 
            this.btTournament.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btTournament.Location = new System.Drawing.Point(222, 434);
            this.btTournament.Name = "btTournament";
            this.btTournament.Size = new System.Drawing.Size(417, 52);
            this.btTournament.TabIndex = 3;
            this.btTournament.Text = "Tournaments";
            this.btTournament.UseVisualStyleBackColor = true;
            this.btTournament.Click += new System.EventHandler(this.btTournament_Click);
            // 
            // btLogOut
            // 
            this.btLogOut.Location = new System.Drawing.Point(767, 12);
            this.btLogOut.Name = "btLogOut";
            this.btLogOut.Size = new System.Drawing.Size(93, 29);
            this.btLogOut.TabIndex = 4;
            this.btLogOut.Text = "log out";
            this.btLogOut.UseVisualStyleBackColor = true;
            this.btLogOut.Click += new System.EventHandler(this.btLogOut_Click);
            // 
            // MainEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 498);
            this.Controls.Add(this.btLogOut);
            this.Controls.Add(this.btTournament);
            this.Name = "MainEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MainEmployee";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainEmployee_FormClosing);
            this.ResumeLayout(false);
            DesignClass.AutoDesginerForForms(this.Controls, this);
        }

        #endregion

        private Button btTournament;
        private Button btLogOut;
    }
}