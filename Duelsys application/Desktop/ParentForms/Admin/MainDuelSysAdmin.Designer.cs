using MediaBazaar.Design;

namespace DuelSysDesktop.ParentForms.Admin
{
    partial class MainDuelSysAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainDuelSysAdmin));
            this.btEmployees = new System.Windows.Forms.Button();
            this.btTournament = new System.Windows.Forms.Button();
            this.btLogOut = new System.Windows.Forms.Button();
            this.DGVViewAssociations = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.NUDPages = new System.Windows.Forms.NumericUpDown();
            this.btAdmins = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVViewAssociations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDPages)).BeginInit();
            this.SuspendLayout();
            // 
            // btEmployees
            // 
            this.btEmployees.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btEmployees.Location = new System.Drawing.Point(233, 447);
            this.btEmployees.Name = "btEmployees";
            this.btEmployees.Size = new System.Drawing.Size(313, 52);
            this.btEmployees.TabIndex = 0;
            this.btEmployees.Text = "Employees";
            this.btEmployees.UseVisualStyleBackColor = true;
            this.btEmployees.Click += new System.EventHandler(this.btEmployees_Click);
            // 
            // btTournament
            // 
            this.btTournament.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btTournament.Location = new System.Drawing.Point(542, 447);
            this.btTournament.Name = "btTournament";
            this.btTournament.Size = new System.Drawing.Size(330, 52);
            this.btTournament.TabIndex = 1;
            this.btTournament.Text = "Tournaments";
            this.btTournament.UseVisualStyleBackColor = true;
            // 
            // btLogOut
            // 
            this.btLogOut.Location = new System.Drawing.Point(767, 12);
            this.btLogOut.Name = "btLogOut";
            this.btLogOut.Size = new System.Drawing.Size(93, 29);
            this.btLogOut.TabIndex = 2;
            this.btLogOut.Text = "log out";
            this.btLogOut.UseVisualStyleBackColor = true;
            this.btLogOut.Click += new System.EventHandler(this.btLogOut_Click);
            // 
            // DGVViewAssociations
            // 
            this.DGVViewAssociations.AllowUserToAddRows = false;
            this.DGVViewAssociations.AllowUserToDeleteRows = false;
            this.DGVViewAssociations.AllowUserToResizeColumns = false;
            this.DGVViewAssociations.AllowUserToResizeRows = false;
            this.DGVViewAssociations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVViewAssociations.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVViewAssociations.ColumnHeadersHeight = 29;
            this.DGVViewAssociations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGVViewAssociations.Location = new System.Drawing.Point(3, 118);
            this.DGVViewAssociations.MultiSelect = false;
            this.DGVViewAssociations.Name = "DGVViewAssociations";
            this.DGVViewAssociations.ReadOnly = true;
            this.DGVViewAssociations.RowHeadersVisible = false;
            this.DGVViewAssociations.RowHeadersWidth = 51;
            this.DGVViewAssociations.RowTemplate.Height = 29;
            this.DGVViewAssociations.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DGVViewAssociations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVViewAssociations.Size = new System.Drawing.Size(857, 221);
            this.DGVViewAssociations.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Page number : ";
            // 
            // NUDPages
            // 
            this.NUDPages.Location = new System.Drawing.Point(428, 359);
            this.NUDPages.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDPages.Name = "NUDPages";
            this.NUDPages.Size = new System.Drawing.Size(69, 27);
            this.NUDPages.TabIndex = 16;
            this.NUDPages.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NUDPages.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUDPages.ValueChanged += new System.EventHandler(this.NUDPages_ValueChanged);
            // 
            // btAdmins
            // 
            this.btAdmins.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btAdmins.Location = new System.Drawing.Point(3, 447);
            this.btAdmins.Name = "btAdmins";
            this.btAdmins.Size = new System.Drawing.Size(242, 52);
            this.btAdmins.TabIndex = 18;
            this.btAdmins.Text = "Admins";
            this.btAdmins.UseVisualStyleBackColor = true;
            this.btAdmins.Click += new System.EventHandler(this.btAdmins_Click);
            // 
            // MainDuelSysAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 498);
            this.Controls.Add(this.btAdmins);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NUDPages);
            this.Controls.Add(this.DGVViewAssociations);
            this.Controls.Add(this.btLogOut);
            this.Controls.Add(this.btTournament);
            this.Controls.Add(this.btEmployees);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainDuelSysAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DuelSys inc.";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainAdmin_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.DGVViewAssociations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDPages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btEmployees;
        private Button btTournament;
        private Button btLogOut;
        private DataGridView DGVViewAssociations;
        private Label label2;
        private NumericUpDown NUDPages;
        private Button btAdmins;
    }
}